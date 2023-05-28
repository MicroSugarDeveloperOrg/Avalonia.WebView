using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CoreServices;
using Foundation;

namespace CFNetwork;

[Obsolete("Use 'System.Net.Http.CFNetworkHandler' or the more recent 'Foundation.NSUrlSessionHandler' instead.")]
public class MessageHandler : HttpClientHandler
{
	private CFHTTPAuthentication auth;

	public WorkerThread WorkerThread { get; private set; }

	public MessageHandler()
	{
	}

	public MessageHandler(WorkerThread worker)
	{
		WorkerThread = worker;
	}

	protected internal new async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!request.RequestUri.IsAbsoluteUri)
		{
			throw new InvalidOperationException();
		}
		using CFHTTPMessage message = CreateRequest(request, isFirstRequest: true);
		return await ProcessRequest(request, message, await CreateBody(request, message, cancellationToken), retryWithCredentials: true, cancellationToken, isFirstRequest: true);
	}

	private CFHTTPMessage CreateRequest(HttpRequestMessage request, bool isFirstRequest)
	{
		CFHTTPMessage cFHTTPMessage = CFHTTPMessage.CreateRequest(request.RequestUri, request.Method.Method, request.Version);
		SetupRequest(request, cFHTTPMessage, isFirstRequest);
		if (auth == null || base.Credentials == null || !base.PreAuthenticate)
		{
			return cFHTTPMessage;
		}
		if (!auth.AppliesToRequest(cFHTTPMessage))
		{
			return cFHTTPMessage;
		}
		string method = auth.GetMethod();
		NetworkCredential credential = base.Credentials.GetCredential(request.RequestUri, method);
		if (credential == null)
		{
			return cFHTTPMessage;
		}
		if (isFirstRequest)
		{
			cFHTTPMessage.ApplyCredentials(auth, credential);
		}
		return cFHTTPMessage;
	}

	private void SetupRequest(HttpRequestMessage request, CFHTTPMessage message, bool isFirstRequest)
	{
		string text = null;
		if ((base.AutomaticDecompression & DecompressionMethods.GZip) != 0)
		{
			text = "gzip";
		}
		if ((base.AutomaticDecompression & DecompressionMethods.Deflate) != 0)
		{
			text = ((text != null) ? "gzip, deflate" : "deflate");
		}
		if (text != null)
		{
			message.SetHeaderFieldValue("Accept-Encoding", text);
		}
		if (request.Content != null)
		{
			foreach (KeyValuePair<string, IEnumerable<string>> header in request.Content.Headers)
			{
				if (isFirstRequest || !(header.Key == "Authorization"))
				{
					string value = string.Join(",", header.Value);
					message.SetHeaderFieldValue(header.Key, value);
				}
			}
		}
		foreach (KeyValuePair<string, IEnumerable<string>> header2 in request.Headers)
		{
			if (text == null || !header2.Key.Equals("Accept-Encoding"))
			{
				string value2 = string.Join(",", header2.Value);
				message.SetHeaderFieldValue(header2.Key, value2);
			}
		}
		if (base.UseCookies && base.CookieContainer != null)
		{
			string cookieHeader = base.CookieContainer.GetCookieHeader(request.RequestUri);
			if (cookieHeader != "")
			{
				message.SetHeaderFieldValue("Cookie", cookieHeader);
			}
		}
	}

	private async Task<WebRequestStream> CreateBody(HttpRequestMessage request, CFHTTPMessage message, CancellationToken cancellationToken)
	{
		if (request.Content == null)
		{
			return null;
		}
		long? length = request.Content.Headers.ContentLength;
		if (request.Content is StreamContent || !length.HasValue)
		{
			return new WebRequestStream(await request.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false), cancellationToken);
		}
		message.SetBody(await request.Content.ReadAsByteArrayAsync().ConfigureAwait(continueOnCapturedContext: false));
		return null;
	}

	private bool GetKeepAlive(HttpRequestMessage request)
	{
		if (request.Version != HttpVersion.Version10)
		{
			return request.Headers.ConnectionClose != true;
		}
		foreach (string item in request.Headers.Connection)
		{
			if (string.Equals(item, "Keep-Alive", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return request.Headers.Contains("Keep-Alive");
	}

	private static bool IsRedirect(HttpStatusCode status)
	{
		return status == HttpStatusCode.MultipleChoices || status == HttpStatusCode.MovedPermanently || status == HttpStatusCode.Found || status == HttpStatusCode.SeeOther || status == HttpStatusCode.TemporaryRedirect;
	}

	private async Task<HttpResponseMessage> ProcessRequest(HttpRequestMessage request, CFHTTPMessage message, WebRequestStream body, bool retryWithCredentials, CancellationToken cancellationToken, bool isFirstRequest)
	{
		cancellationToken.ThrowIfCancellationRequested();
		WebResponseStream stream = ((body == null) ? WebResponseStream.Create(message) : WebResponseStream.Create(message, body));
		if (stream == null)
		{
			throw new HttpRequestException($"Failed to create web request for '{request.RequestUri}'.");
		}
		if (!isFirstRequest)
		{
			stream.Stream.ShouldAutoredirect = base.AllowAutoRedirect;
		}
		stream.Stream.AttemptPersistentConnection = GetKeepAlive(request);
		CFHTTPMessage response = await stream.Open(WorkerThread, cancellationToken).ConfigureAwait(continueOnCapturedContext: true);
		HttpStatusCode status = response.ResponseStatusCode;
		if (IsRedirect(status))
		{
			request.Headers.Authorization = null;
			stream.Dispose();
			using CFHTTPMessage message2 = CreateRequest(request, isFirstRequest: false);
			return await ProcessRequest(request, message2, null, retryWithCredentials: false, cancellationToken, isFirstRequest: false);
		}
		if (((retryWithCredentials && body == null && status == HttpStatusCode.Unauthorized) || status == HttpStatusCode.ProxyAuthenticationRequired) && HandleAuthentication(request.RequestUri, message, response))
		{
			stream.Dispose();
			using (CreateRequest(request, isFirstRequest: true))
			{
				return await ProcessRequest(request, message, null, retryWithCredentials: false, cancellationToken, isFirstRequest: true);
			}
		}
		HttpResponseMessage retval = new HttpResponseMessage
		{
			StatusCode = response.ResponseStatusCode,
			ReasonPhrase = GetReasonPhrase(response),
			Version = response.Version
		};
		Content content = (Content)(retval.Content = new Content(stream));
		DecodeHeaders(response, retval, content);
		return retval;
	}

	private string GetReasonPhrase(CFHTTPMessage response)
	{
		string responseStatusLine = response.ResponseStatusLine;
		Match match = Regex.Match(responseStatusLine, "HTTP/1.(0|1) (\\d+) (.*)");
		if (!match.Success)
		{
			return responseStatusLine;
		}
		return match.Groups[3].Value;
	}

	private bool HandleAuthentication(Uri uri, CFHTTPMessage request, CFHTTPMessage response)
	{
		if (base.Credentials == null)
		{
			return false;
		}
		if (base.PreAuthenticate)
		{
			FindAuthenticationObject(response);
			return HandlePreAuthentication(uri, request);
		}
		NetworkCredential credential = base.Credentials.GetCredential(uri, "Basic");
		NetworkCredential credential2 = base.Credentials.GetCredential(uri, "Digest");
		bool flag = false;
		if (credential != null && credential2 == null)
		{
			flag = HandleAuthentication(request, response, CFHTTPMessage.AuthenticationScheme.Basic, credential);
		}
		if (credential2 != null && credential == null)
		{
			flag = HandleAuthentication(request, response, CFHTTPMessage.AuthenticationScheme.Digest, credential2);
		}
		if (flag)
		{
			return true;
		}
		FindAuthenticationObject(response);
		return HandlePreAuthentication(uri, request);
	}

	private bool HandlePreAuthentication(Uri uri, CFHTTPMessage message)
	{
		string method = auth.GetMethod();
		NetworkCredential credential = base.Credentials.GetCredential(uri, method);
		if (credential == null)
		{
			return false;
		}
		message.ApplyCredentials(auth, credential);
		return true;
	}

	private bool HandleAuthentication(CFHTTPMessage request, CFHTTPMessage response, CFHTTPMessage.AuthenticationScheme scheme, NetworkCredential credential)
	{
		bool forProxy = response.ResponseStatusCode == HttpStatusCode.ProxyAuthenticationRequired;
		return request.AddAuthentication(response, (NSString)credential.UserName, (NSString)credential.Password, scheme, forProxy);
	}

	private void FindAuthenticationObject(CFHTTPMessage response)
	{
		if (auth != null)
		{
			if (auth.IsValid)
			{
				return;
			}
			auth.Dispose();
			auth = null;
		}
		if (auth == null)
		{
			auth = CFHTTPAuthentication.CreateFromResponse(response);
			if (auth == null)
			{
				throw new HttpRequestException("Failed to create CFHTTPAuthentication");
			}
		}
		if (!auth.IsValid)
		{
			throw new HttpRequestException("Failed to validate CFHTTPAuthentication");
		}
	}

	private void DecodeHeaders(CFHTTPMessage message, HttpResponseMessage response, Content content)
	{
		using NSDictionary nSDictionary = message.GetAllHeaderFields();
		foreach (KeyValuePair<NSObject, NSObject> item in nSDictionary)
		{
			DecodeHeader(response, content, item);
		}
	}

	private void DecodeHeader(HttpResponseMessage response, Content content, KeyValuePair<NSObject, NSObject> entry)
	{
		string text = (NSString)entry.Key;
		string value = (NSString)entry.Value;
		try
		{
			if (!content.DecodeHeader(text, value))
			{
				response.Headers.Add(text, value);
			}
			return;
		}
		catch
		{
		}
		if (text.Equals("Date"))
		{
			response.Headers.Date = DateTime.Now;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && auth != null)
		{
			auth.Dispose();
			auth = null;
		}
		base.Dispose(disposing);
	}
}
