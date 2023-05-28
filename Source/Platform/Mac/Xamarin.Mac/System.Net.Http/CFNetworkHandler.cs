using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;
using CoreServices;
using Foundation;

namespace System.Net.Http;

public class CFNetworkHandler : HttpMessageHandler
{
	private class StreamBucket
	{
		public TaskCompletionSource<HttpResponseMessage> Response;

		public HttpRequestMessage Request;

		public CancellationTokenRegistration CancellationTokenRegistration;

		public CFContentStream ContentStream;

		public bool StreamCanBeDisposed;

		public void Close()
		{
			CancellationTokenRegistration.Dispose();
			if (ContentStream != null)
			{
				if (StreamCanBeDisposed)
				{
					ContentStream.Dispose();
				}
				else
				{
					ContentStream.Close();
				}
			}
		}
	}

	private bool allowAutoRedirect;

	private bool sentRequest;

	private bool useSystemProxy;

	private CookieContainer cookies;

	private Dictionary<IntPtr, StreamBucket> streamBuckets;

	public bool AllowAutoRedirect
	{
		get
		{
			return allowAutoRedirect;
		}
		set
		{
			EnsureModifiability();
			allowAutoRedirect = value;
		}
	}

	public CookieContainer CookieContainer
	{
		get
		{
			return cookies ?? (cookies = new CookieContainer());
		}
		set
		{
			EnsureModifiability();
			cookies = value;
		}
	}

	public bool UseSystemProxy
	{
		get
		{
			return useSystemProxy;
		}
		set
		{
			EnsureModifiability();
			useSystemProxy = value;
		}
	}

	public CFNetworkHandler()
	{
		allowAutoRedirect = true;
		streamBuckets = new Dictionary<IntPtr, StreamBucket>();
	}

	private void EnsureModifiability()
	{
		if (sentRequest)
		{
			throw new InvalidOperationException("This instance has already started one or more requests. Properties can only be modified before sending the first request.");
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	private CFHTTPMessage CreateWebRequestAsync(HttpRequestMessage request)
	{
		CFHTTPMessage cFHTTPMessage = CFHTTPMessage.CreateRequest(request.RequestUri, request.Method.Method, request.Version);
		if (cookies != null)
		{
			string cookieHeader = cookies.GetCookieHeader(request.RequestUri);
			if (cookieHeader != "")
			{
				cFHTTPMessage.SetHeaderFieldValue("Cookie", cookieHeader);
			}
		}
		foreach (KeyValuePair<string, IEnumerable<string>> header in request.Headers)
		{
			foreach (string item in header.Value)
			{
				cFHTTPMessage.SetHeaderFieldValue(header.Key, item);
			}
		}
		if (request.Content != null)
		{
			foreach (KeyValuePair<string, IEnumerable<string>> header2 in request.Content.Headers)
			{
				foreach (string item2 in header2.Value)
				{
					cFHTTPMessage.SetHeaderFieldValue(header2.Key, item2);
				}
			}
		}
		return cFHTTPMessage;
	}



	internal async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken, bool isFirstRequest)
	{
		sentRequest = true;
		CFHTTPStream stream;
		using (CFHTTPMessage message = CreateWebRequestAsync(request))
		{
			if (request.Content != null)
			{
				message.SetBody(await request.Content.ReadAsByteArrayAsync().ConfigureAwait(continueOnCapturedContext: false));
			}
			stream = CFStream.CreateForHTTPRequest(message);
		}
		if (useSystemProxy)
		{
			CFProxySettings proxies = CoreFoundation.CFNetwork.GetSystemProxySettings();
			if (proxies.HTTPEnable)
			{
				stream.SetProxy(proxies);
			}
		}
		if (!isFirstRequest && allowAutoRedirect)
		{
			stream.ShouldAutoredirect = allowAutoRedirect;
		}
		stream.HasBytesAvailableEvent += HandleHasBytesAvailableEvent;
		stream.ErrorEvent += HandleErrorEvent;
		stream.ClosedEvent += HandleClosedEvent;
		TaskCompletionSource<HttpResponseMessage> response = new TaskCompletionSource<HttpResponseMessage>();
		if (cancellationToken.IsCancellationRequested)
		{
			response.SetCanceled();
			return await response.Task;
		}
		StreamBucket bucket = new StreamBucket
		{
			Request = request,
			Response = response
		};
		streamBuckets.Add(stream.Handle, bucket);
		stream.EnableEvents(CFRunLoop.Main, CFRunLoop.ModeCommon);
		stream.Open();
		bucket.CancellationTokenRegistration = cancellationToken.Register(delegate
		{
			if (streamBuckets.TryGetValue(stream.Handle, out var value))
			{
				value.Response.TrySetCanceled();
				CloseStream(stream);
			}
		});
		if (isFirstRequest)
		{
			HttpResponseMessage initialRequest = await response.Task;
			HttpStatusCode status = initialRequest.StatusCode;
			if (IsRedirect(status) && allowAutoRedirect)
			{
				bucket.StreamCanBeDisposed = true;
				stream.HasBytesAvailableEvent -= HandleHasBytesAvailableEvent;
				stream.ErrorEvent -= HandleErrorEvent;
				stream.ClosedEvent -= HandleClosedEvent;
				request.Headers.Authorization = null;
				return await SendAsync(request, cancellationToken, isFirstRequest: false).ConfigureAwait(continueOnCapturedContext: false);
			}
			return initialRequest;
		}
		return await response.Task;
	}

	private static bool IsRedirect(HttpStatusCode status)
	{
		return status == HttpStatusCode.MultipleChoices || status == HttpStatusCode.MovedPermanently || status == HttpStatusCode.Found || status == HttpStatusCode.SeeOther || status == HttpStatusCode.TemporaryRedirect;
	}

	private void HandleErrorEvent(object sender, CFStream.StreamEventArgs e)
	{
		CFHTTPStream cFHTTPStream = (CFHTTPStream)sender;
		if (streamBuckets.TryGetValue(cFHTTPStream.Handle, out var value))
		{
			CFException error = cFHTTPStream.GetError();
			value.Response.TrySetException(new HttpRequestException(error.FailureReason, error));
			CloseStream(cFHTTPStream);
		}
	}

	private void HandleClosedEvent(object sender, CFStream.StreamEventArgs e)
	{
		CFHTTPStream stream = (CFHTTPStream)sender;
		HandleHasBytesAvailableEvent(sender, e);
		CloseStream(stream);
	}

	private void CloseStream(CFHTTPStream stream)
	{
		lock (streamBuckets)
		{
			if (streamBuckets.TryGetValue(stream.Handle, out var value))
			{
				value.Close();
				streamBuckets.Remove(stream.Handle);
			}
		}
		stream.Close();
	}

	private void HandleHasBytesAvailableEvent(object sender, CFStream.StreamEventArgs e)
	{
		CFHTTPStream cFHTTPStream = (CFHTTPStream)sender;
		if (!streamBuckets.TryGetValue(cFHTTPStream.Handle, out var value))
		{
			return;
		}
		if (value.Response.Task.IsCompleted)
		{
			value.ContentStream.ReadStreamData();
			return;
		}
		CFHTTPMessage responseHeader = cFHTTPStream.GetResponseHeader();
		if (!responseHeader.IsHeaderComplete)
		{
			throw new NotImplementedException();
		}
		value.ContentStream = new CFContentStream(cFHTTPStream);
		HttpResponseMessage httpResponseMessage = new HttpResponseMessage(responseHeader.ResponseStatusCode);
		httpResponseMessage.RequestMessage = value.Request;
		httpResponseMessage.ReasonPhrase = responseHeader.ResponseStatusLine;
		httpResponseMessage.Content = value.ContentStream;
		NSDictionary allHeaderFields = responseHeader.GetAllHeaderFields();
		if (allHeaderFields != null)
		{
			foreach (KeyValuePair<NSObject, NSObject> item in allHeaderFields)
			{
				if (item.Key == null)
				{
					continue;
				}
				string text = item.Key.ToString();
				string value2 = ((item.Value == null) ? string.Empty : item.Value.ToString());
				HttpHeaders headers;
				if (IsContentHeader(text))
				{
					headers = httpResponseMessage.Content.Headers;
				}
				else
				{
					headers = httpResponseMessage.Headers;
					if (cookies != null && (text == "Set-Cookie" || text == "Set-Cookie2"))
					{
						AddCookie(value2, value.Request.RequestUri, text);
					}
				}
				headers.TryAddWithoutValidation(text, value2);
			}
		}
		if (!value.Response.Task.IsCanceled)
		{
			value.Response.TrySetResult(httpResponseMessage);
			value.ContentStream.ReadStreamData();
		}
	}

	private void AddCookie(string value, Uri uri, string header)
	{
		try
		{
            cookies.SetCookies(uri, value);
        }
		catch
		{
		}
		 
	}

	private static bool IsContentHeader(string header)
	{
		switch (header)
		{
		case "Allow":
		case "ContentDisposition":
		case "ContentEncoding":
		case "ContentLanguage":
		case "ContentLength":
		case "ContentLocation":
		case "ContentMD5":
		case "ContentRange":
		case "ContentType":
		case "Expires":
		case "LastModified":
			return true;
		default:
			return false;
		}
	}

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
       return await SendAsync(request, cancellationToken, isFirstRequest: true).ConfigureAwait(continueOnCapturedContext: false);
    }
	 
}
