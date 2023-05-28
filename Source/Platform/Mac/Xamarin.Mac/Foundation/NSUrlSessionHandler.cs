using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CoreFoundation;
using Security;
using Xamarin.Mac.System.Mac;

namespace Foundation;

public class NSUrlSessionHandler : HttpMessageHandler
{
	private class NSUrlSessionHandlerDelegate : NSUrlSessionDataDelegate
	{
		private readonly NSUrlSessionHandler sessionHandler;

		private static readonly string RejectProtectionSpaceAuthType = "reject";

		public NSUrlSessionHandlerDelegate(NSUrlSessionHandler handler)
		{
			sessionHandler = handler;
		}

		private InflightData GetInflightData(NSUrlSessionTask task)
		{
			InflightData value = null;
			lock (sessionHandler.inflightRequestsLock)
			{
				if (sessionHandler.inflightRequests.TryGetValue(task, out value))
				{
					if (value.CancellationToken.IsCancellationRequested)
					{
						task?.Cancel();
					}
					return value;
				}
			}
			task?.Cancel();
			return null;
		}

		private void UpdateManagedCookieContainer(NSUrl url, NSHttpCookie[] cookies)
		{
			Uri uri = new Uri(url.AbsoluteString);
			if (sessionHandler.cookieContainer == null || cookies.Length == 0)
			{
				return;
			}
			lock (sessionHandler.inflightRequestsLock)
			{
				string[] array = new string[cookies.Length];
				for (int i = 0; i < cookies.Length; i++)
				{
					array[i] = cookies[i].GetHeaderValue();
				}
				sessionHandler.cookieContainer.SetCookies(uri, string.Join(",", array));
			}
		}

		[Preserve(Conditional = true)]
		public override void DidReceiveResponse(NSUrlSession session, NSUrlSessionDataTask dataTask, NSUrlResponse response, Action<NSUrlSessionResponseDisposition> completionHandler)
		{
			InflightData inflight = GetInflightData(dataTask);
			if (inflight == null)
			{
				return;
			}
			try
			{
				NSHttpUrlResponse nSHttpUrlResponse = (NSHttpUrlResponse)response;
				int statusCode = (int)nSHttpUrlResponse.StatusCode;
				NSUrlSessionDataTaskStreamContent content = new NSUrlSessionDataTaskStreamContent(inflight.Stream, delegate
				{
					if (!inflight.Completed)
					{
						dataTask.Cancel();
					}
					inflight.Disposed = true;
					inflight.Stream.TrySetException(new ObjectDisposedException("The content stream was disposed."));
					sessionHandler.RemoveInflightData(dataTask);
				}, inflight.CancellationTokenSource.Token);
				HttpResponseMessage httpResponseMessage = new HttpResponseMessage((HttpStatusCode)statusCode)
				{
					Content = content,
					RequestMessage = inflight.Request
				};
				httpResponseMessage.RequestMessage.RequestUri = new Uri(nSHttpUrlResponse.Url.AbsoluteString);
				foreach (KeyValuePair<NSObject, NSObject> allHeaderField in nSHttpUrlResponse.AllHeaderFields)
				{
					if (allHeaderField.Key != null && allHeaderField.Value != null && !(allHeaderField.Key.ToString() == "Set-Cookie"))
					{
						httpResponseMessage.Headers.TryAddWithoutValidation(allHeaderField.Key.ToString(), allHeaderField.Value.ToString());
						httpResponseMessage.Content.Headers.TryAddWithoutValidation(allHeaderField.Key.ToString(), allHeaderField.Value.ToString());
					}
				}
				if (session.Configuration.HttpCookieStorage != null)
				{
					NSHttpCookie[] array = session.Configuration.HttpCookieStorage.CookiesForUrl(response.Url);
					UpdateManagedCookieContainer(response.Url, array);
					for (int i = 0; i < array.Length; i++)
					{
						httpResponseMessage.Headers.TryAddWithoutValidation("Set-Cookie", array[i].GetHeaderValue());
					}
				}
				inflight.Response = httpResponseMessage;
				if (dataTask.State == NSUrlSessionTaskState.Suspended)
				{
					dataTask.Resume();
				}
			}
			catch (Exception ex)
			{
				inflight.CompletionSource.TrySetException(ex);
				inflight.Stream.TrySetException(ex);
				sessionHandler.RemoveInflightData(dataTask);
			}
			completionHandler(NSUrlSessionResponseDisposition.Allow);
		}

		[Preserve(Conditional = true)]
		public override void DidReceiveData(NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
		{
			InflightData inflightData = GetInflightData(dataTask);
			if (inflightData != null)
			{
				inflightData.Stream.Add(data);
				SetResponse(inflightData);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidCompleteWithError(NSUrlSession session, NSUrlSessionTask task, NSError error)
		{
			InflightData inflightData = GetInflightData(task);
			NSError error2 = task.Error;
			if (inflightData != null)
			{
				inflightData.Stream.TrySetReceivedAllData();
				if (error != null || error2 != null)
				{
					inflightData.CancellationTokenSource.Cancel();
					inflightData.Errored = true;
					Exception ex = inflightData.Exception ?? createExceptionForNSError(error ?? error2);
					inflightData.CompletionSource.TrySetException(ex);
					inflightData.Stream.TrySetException(ex);
				}
				else
				{
					inflightData.Completed = true;
					SetResponse(inflightData);
				}
				sessionHandler.RemoveInflightData(task, cancel: false);
			}
		}

		private void SetResponse(InflightData inflight)
		{
			lock (inflight.Lock)
			{
				if (!inflight.ResponseSent && !inflight.CancellationTokenSource.Token.IsCancellationRequested && !inflight.CompletionSource.Task.IsCompleted)
				{
					HttpResponseMessage httpResponse = inflight.Response;
					inflight.ResponseSent = true;
					Task.Run(() => inflight.CompletionSource.TrySetResult(httpResponse));
				}
			}
		}

		[Preserve(Conditional = true)]
		public override void WillCacheResponse(NSUrlSession session, NSUrlSessionDataTask dataTask, NSCachedUrlResponse proposedResponse, Action<NSCachedUrlResponse> completionHandler)
		{
			completionHandler(sessionHandler.DisableCaching ? null : proposedResponse);
		}

		[Preserve(Conditional = true)]
		public override void WillPerformHttpRedirection(NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest newRequest, Action<NSUrlRequest> completionHandler)
		{
			completionHandler(sessionHandler.AllowAutoRedirect ? newRequest : null);
		}

		[Preserve(Conditional = true)]
		public override void DidReceiveChallenge(NSUrlSession session, NSUrlSessionTask task, NSUrlAuthenticationChallenge challenge, Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			InflightData inflightData = GetInflightData(task);
			if (inflightData == null)
			{
				return;
			}
			NSUrlSessionHandlerTrustOverrideCallback trustOverride = sessionHandler.TrustOverride;
			NSUrlSessionHandlerTrustOverrideForUrlCallback trustOverrideForUrl = sessionHandler.TrustOverrideForUrl;
			if ((trustOverride != null || trustOverrideForUrl != null) && challenge.ProtectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodServerTrust)
			{
				if ((trustOverrideForUrl != null && trustOverrideForUrl(sessionHandler, inflightData.RequestUrl, challenge.ProtectionSpace.ServerSecTrust)) || (trustOverride != null && trustOverride(sessionHandler, challenge.ProtectionSpace.ServerSecTrust)))
				{
					NSUrlCredential arg = new NSUrlCredential(challenge.ProtectionSpace.ServerSecTrust);
					completionHandler(NSUrlSessionAuthChallengeDisposition.UseCredential, arg);
					return;
				}
				lock (inflightData.Lock)
				{
					inflightData.Exception = new HttpRequestException("An error occurred while sending the request.", new WebException("Error: TrustFailure"));
				}
				completionHandler(NSUrlSessionAuthChallengeDisposition.CancelAuthenticationChallenge, null);
				return;
			}
			if (challenge.PreviousFailureCount == 0)
			{
				AuthenticationHeaderValue authenticationHeaderValue = inflightData.Request?.Headers?.Authorization;
				if (!string.IsNullOrEmpty(authenticationHeaderValue?.Scheme) || !string.IsNullOrEmpty(authenticationHeaderValue?.Parameter))
				{
					completionHandler(NSUrlSessionAuthChallengeDisposition.RejectProtectionSpace, null);
					return;
				}
			}
			if (sessionHandler.Credentials != null && TryGetAuthenticationType(challenge.ProtectionSpace, out var authenticationType))
			{
				NetworkCredential networkCredential = null;
				if (authenticationType != RejectProtectionSpaceAuthType && (!(challenge.FailureResponse is NSHttpUrlResponse nSHttpUrlResponse) || !(nSHttpUrlResponse.StatusCode == 401) || !(challenge.PreviousFailureCount > 0)))
				{
					Uri requestUri = inflightData.Request.RequestUri;
					networkCredential = sessionHandler.Credentials.GetCredential(requestUri, authenticationType);
				}
				if (networkCredential != null)
				{
					NSUrlCredential arg2 = new NSUrlCredential(networkCredential.UserName, networkCredential.Password, NSUrlCredentialPersistence.ForSession);
					completionHandler(NSUrlSessionAuthChallengeDisposition.UseCredential, arg2);
				}
				else
				{
					completionHandler(NSUrlSessionAuthChallengeDisposition.RejectProtectionSpace, null);
				}
			}
			else
			{
				completionHandler(NSUrlSessionAuthChallengeDisposition.PerformDefaultHandling, challenge.ProposedCredential);
			}
		}

		private static bool TryGetAuthenticationType(NSUrlProtectionSpace protectionSpace, out string authenticationType)
		{
			if (protectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodNTLM)
			{
				authenticationType = "NTLM";
			}
			else if (protectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodHTTPBasic)
			{
				authenticationType = "basic";
			}
			else
			{
				if (!(protectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodNegotiate) && !(protectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodHTMLForm) && !(protectionSpace.AuthenticationMethod == NSUrlProtectionSpace.AuthenticationMethodHTTPDigest))
				{
					authenticationType = null;
					return false;
				}
				authenticationType = RejectProtectionSpaceAuthType;
			}
			return true;
		}
	}

	private class InflightData : IDisposable
	{
		public readonly object Lock = new object();

		public string RequestUrl { get; set; }

		public TaskCompletionSource<HttpResponseMessage> CompletionSource { get; set; }

		public CancellationToken CancellationToken { get; set; }

		public CancellationTokenSource CancellationTokenSource { get; set; }

		public NSUrlSessionDataTaskStream Stream { get; set; }

		public HttpRequestMessage Request { get; set; }

		public HttpResponseMessage Response { get; set; }

		public Exception Exception { get; set; }

		public bool ResponseSent { get; set; }

		public bool Errored { get; set; }

		public bool Disposed { get; set; }

		public bool Completed { get; set; }

		public bool Done => Errored || Disposed || Completed || CancellationToken.IsCancellationRequested;

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && CancellationTokenSource != null)
			{
				CancellationTokenSource.Dispose();
				CancellationTokenSource = null;
			}
		}
	}

	private class NSUrlSessionDataTaskStreamContent : MonoStreamContent
	{
		private Action disposed;

		public NSUrlSessionDataTaskStreamContent(NSUrlSessionDataTaskStream source, Action onDisposed, CancellationToken token)
			: base(source, token)
		{
			disposed = onDisposed;
		}

		protected override void Dispose(bool disposing)
		{
			Interlocked.Exchange(ref disposed, null)?.Invoke();
			base.Dispose(disposing);
		}
	}

	private class MonoStreamContent : HttpContent
	{
		private readonly Stream content;

		private readonly int bufferSize;

		private readonly CancellationToken cancellationToken;

		private readonly long startPosition;

		private bool contentCopied;

		public MonoStreamContent(Stream content)
			: this(content, 16384)
		{
		}

		public MonoStreamContent(Stream content, int bufferSize)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.content = content;
			this.bufferSize = bufferSize;
			if (content.CanSeek)
			{
				startPosition = content.Position;
			}
		}

		internal MonoStreamContent(Stream content, CancellationToken cancellationToken)
			: this(content)
		{
			this.cancellationToken = cancellationToken;
		}

		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			return Task.FromResult(content);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				content.Dispose();
			}
			base.Dispose(disposing);
		}

		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			if (contentCopied)
			{
				if (!content.CanSeek)
				{
					throw new InvalidOperationException("The stream was already consumed. It cannot be read again.");
				}
				content.Seek(startPosition, SeekOrigin.Begin);
			}
			else
			{
				contentCopied = true;
			}
			return content.CopyToAsync(stream, bufferSize, cancellationToken);
		}

        protected override bool TryComputeLength(out long length)
        {
            if (!content.CanSeek)
            {
                length = 0L;
                return false;
            }
            length = content.Length - startPosition;
            return true;
        }
		 
    }

	private class NSUrlSessionDataTaskStream : Stream
	{
		private readonly Queue<NSData> data;

		private readonly object dataLock = new object();

		private long position;

		private long length;

		private bool receivedAllData;

		private Exception exc;

		private NSData current;

		private Stream currentStream;

		public override bool CanRead => true;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override bool CanTimeout => false;

		public override long Length => length;

		public override long Position
		{
			get
			{
				return position;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		public NSUrlSessionDataTaskStream()
		{
			data = new Queue<NSData>();
		}

		public void Add(NSData d)
		{
			lock (dataLock)
			{
				data.Enqueue(d);
				length += (int)d.Length;
			}
		}

		public void TrySetReceivedAllData()
		{
			receivedAllData = true;
		}

		public void TrySetException(Exception e)
		{
			exc = e;
			TrySetReceivedAllData();
		}

		private void ThrowIfNeeded(CancellationToken cancellationToken)
		{
			if (exc != null)
			{
				throw exc;
			}
			cancellationToken.ThrowIfCancellationRequested();
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return ReadAsync(buffer, offset, count).Result;
		}

		public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			ThrowIfNeeded(cancellationToken);
			while (current == null)
			{
				lock (dataLock)
				{
					if (data.Count == 0 && receivedAllData && position == length)
					{
						return 0;
					}
					if (data.Count > 0 && current == null)
					{
						current = data.Peek();
						currentStream = current.AsStream();
						break;
					}
				}
				try
				{
					await Task.Delay(50, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				catch (TaskCanceledException ex)
				{
					throw new TimeoutException("The request timed out.", ex);
				}
			}
			ThrowIfNeeded(cancellationToken);
			Stream d = currentStream;
			int bufferCount = Math.Min(count, (int)(d.Length - d.Position));
			int bytesRead = await d.ReadAsync(buffer, offset, bufferCount, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			position += bytesRead;
			if (d.Position == d.Length)
			{
				lock (dataLock)
				{
					data.Dequeue();
					currentStream?.Dispose();
					current = null;
					currentStream = null;
				}
			}
			return bytesRead;
		}

		public override void SetLength(long value)
		{
			throw new InvalidOperationException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new InvalidOperationException();
		}

		public override void Flush()
		{
			throw new InvalidOperationException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new InvalidOperationException();
		}
	}

	private class WrappedNSInputStream : NSInputStream
	{
		private NSStreamStatus status;

		private CFRunLoopSource source;

		private readonly Stream stream;

		private bool notifying;

		public override NSStreamStatus Status => status;

		public WrappedNSInputStream(Stream inputStream)
		{
			status = NSStreamStatus.NotOpen;
			stream = inputStream;
			source = new CFRunLoopSource(base.Handle);
		}

		public override void Open()
		{
			status = NSStreamStatus.Open;
			Notify(CFStreamEventType.OpenCompleted);
		}

		public override void Close()
		{
			status = NSStreamStatus.Closed;
		}

		public override nint Read(IntPtr buffer, nuint len)
		{
			byte[] buffer2 = new byte[(ulong)len];
			int num = stream.Read(buffer2, 0, (int)len);
			Marshal.Copy(buffer2, 0, buffer, (int)len);
			if (notifying)
			{
				return num;
			}
			notifying = true;
			if (stream.CanSeek && stream.Position == stream.Length)
			{
				Notify(CFStreamEventType.EndEncountered);
				status = NSStreamStatus.AtEnd;
			}
			notifying = false;
			return num;
		}

		public override bool HasBytesAvailable()
		{
			return true;
		}

		protected override bool GetBuffer(out IntPtr buffer, out nuint len)
		{
			return base.GetBuffer(out buffer, out len);
		}

		protected override NSObject GetProperty(NSString key)
		{
			return null;
		}

		protected override bool SetProperty(NSObject property, NSString key)
		{
			return false;
		}

		protected override bool SetCFClientFlags(CFStreamEventType inFlags, IntPtr inCallback, IntPtr inContextPtr)
		{
			return base.SetCFClientFlags(inFlags, inCallback, inContextPtr);
		}

		public override void Schedule(NSRunLoop aRunLoop, string mode)
		{
			CFRunLoop cFRunLoop = aRunLoop.GetCFRunLoop();
			NSString mode2 = new NSString(mode);
			cFRunLoop.AddSource(source, mode2);
			if (!notifying)
			{
				notifying = true;
				Notify(CFStreamEventType.HasBytesAvailable);
				notifying = false;
			}
		}

		public override void Unschedule(NSRunLoop aRunLoop, string mode)
		{
			CFRunLoop cFRunLoop = aRunLoop.GetCFRunLoop();
			NSString mode2 = new NSString(mode);
			cFRunLoop.RemoveSource(source, mode2);
		}

		protected override void Dispose(bool disposing)
		{
			stream?.Dispose();
		}
	}

	private const string SetCookie = "Set-Cookie";

	private const string Cookie = "Cookie";

	private CookieContainer cookieContainer;

	private readonly Dictionary<string, string> headerSeparators = new Dictionary<string, string>
	{
		["User-Agent"] = " ",
		["Server"] = " "
	};

	private NSUrlSession session;

	private readonly Dictionary<NSUrlSessionTask, InflightData> inflightRequests;

	private readonly object inflightRequestsLock = new object();

	private readonly NSUrlSessionConfiguration.SessionConfigurationType sessionType;

	private bool disableCaching;

	private bool allowAutoRedirect;

	private bool allowsCellularAccess = true;

	private ICredentials credentials;

	private NSUrlSessionHandlerTrustOverrideCallback trustOverride;

	private NSUrlSessionHandlerTrustOverrideForUrlCallback trustOverrideForUrl;

	private bool bypassBackgroundCheck;

	private bool sentRequest;

	public long MaxInputInMemory { get; set; } = long.MaxValue;

	public uint Tls13 = 12288;

    public bool DisableCaching
	{
		get
		{
			return disableCaching;
		}
		set
		{
			EnsureModifiability();
			disableCaching = value;
		}
	}

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

	public bool AllowsCellularAccess
	{
		get
		{
			return allowsCellularAccess;
		}
		set
		{
			EnsureModifiability();
			allowsCellularAccess = value;
		}
	}

	public ICredentials Credentials
	{
		get
		{
			return credentials;
		}
		set
		{
			EnsureModifiability();
			credentials = value;
		}
	}

	[Obsolete("Use the 'TrustOverrideForUrl' property instead.")]
	public NSUrlSessionHandlerTrustOverrideCallback TrustOverride
	{
		get
		{
			return trustOverride;
		}
		set
		{
			EnsureModifiability();
			trustOverride = value;
		}
	}

	public NSUrlSessionHandlerTrustOverrideForUrlCallback TrustOverrideForUrl
	{
		get
		{
			return trustOverrideForUrl;
		}
		set
		{
			EnsureModifiability();
			trustOverrideForUrl = value;
		}
	}

	public bool BypassBackgroundSessionCheck
	{
		get
		{
			return bypassBackgroundCheck;
		}
		set
		{
			EnsureModifiability();
			bypassBackgroundCheck = value;
		}
	}

	public CookieContainer CookieContainer
	{
		get
		{
			return cookieContainer;
		}
		set
		{
			EnsureModifiability();
			cookieContainer = value;
		}
	}

	public bool UseCookies
	{
		get
		{
			return session.Configuration.HttpCookieStorage != null;
		}
		set
		{
			EnsureModifiability();
			if (sessionType == NSUrlSessionConfiguration.SessionConfigurationType.Ephemeral)
			{
				throw new InvalidOperationException("Cannot set the use of cookies in Ephemeral sessions.");
			}
			NSUrlSession nSUrlSession = session;
			NSUrlSessionConfiguration configuration = session.Configuration;
			if (value && configuration.HttpCookieStorage == null)
			{
				configuration.HttpCookieStorage = NSHttpCookieStorage.SharedStorage;
			}
			if (!value && configuration.HttpCookieStorage != null)
			{
				configuration.HttpCookieStorage = null;
			}
			session = NSUrlSession.FromConfiguration(configuration, (INSUrlSessionDelegate)new NSUrlSessionHandlerDelegate(this), (NSOperationQueue)null);
			nSUrlSession.Dispose();
		}
	}

	private static NSUrlSessionConfiguration CreateConfig()
	{
		NSUrlSessionConfiguration defaultSessionConfiguration = NSUrlSessionConfiguration.DefaultSessionConfiguration;
		defaultSessionConfiguration.TimeoutIntervalForRequest = 86400.0;
		defaultSessionConfiguration.TimeoutIntervalForResource = 86400.0;
		return defaultSessionConfiguration;
	}

	public NSUrlSessionHandler()
		: this(CreateConfig())
	{
	}

	[CLSCompliant(false)]
	public NSUrlSessionHandler(NSUrlSessionConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		sessionType = configuration.SessionType;
		allowsCellularAccess = configuration.AllowsCellularAccess;
		AllowAutoRedirect = true;
		SecurityProtocolType securityProtocol = ServicePointManager.SecurityProtocol;
		if ((securityProtocol & SecurityProtocolType.Ssl3) != 0)
		{
			configuration.TLSMinimumSupportedProtocol = SslProtocol.Ssl_3_0;
		}
		else if ((securityProtocol & SecurityProtocolType.Tls) != 0)
		{
			configuration.TLSMinimumSupportedProtocol = SslProtocol.Tls_1_0;
		}
		else if ((securityProtocol & SecurityProtocolType.Tls11) != 0)
		{
			configuration.TLSMinimumSupportedProtocol = SslProtocol.Tls_1_1;
		}
		else if ((securityProtocol & SecurityProtocolType.Tls12) != 0)
		{
			configuration.TLSMinimumSupportedProtocol = SslProtocol.Tls_1_2;
		}
		else if ((securityProtocol & (SecurityProtocolType)Tls13) != 0)
		{
			configuration.TLSMinimumSupportedProtocol = SslProtocol.Tls_1_3;
		}
		session = NSUrlSession.FromConfiguration(configuration, (INSUrlSessionDelegate)new NSUrlSessionHandlerDelegate(this), (NSOperationQueue)null);
		inflightRequests = new Dictionary<NSUrlSessionTask, InflightData>();
	}

	private void RemoveInflightData(NSUrlSessionTask task, bool cancel = true)
	{
		lock (inflightRequestsLock)
		{
			if (inflightRequests.TryGetValue(task, out var value))
			{
				if (cancel)
				{
					value.CancellationTokenSource.Cancel();
				}
				value.Dispose();
				inflightRequests.Remove(task);
			}
		}
		if (cancel)
		{
			task?.Cancel();
		}
		task?.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		lock (inflightRequestsLock)
		{
			foreach (KeyValuePair<NSUrlSessionTask, InflightData> inflightRequest in inflightRequests)
			{
				inflightRequest.Key?.Cancel();
				inflightRequest.Key?.Dispose();
				inflightRequest.Value?.Dispose();
			}
			inflightRequests.Clear();
		}
		base.Dispose(disposing);
	}

	internal void EnsureModifiability()
	{
		if (sentRequest)
		{
			throw new InvalidOperationException("This instance has already started one or more requests. Properties can only be modified before sending the first request.");
		}
	}

	private static Exception createExceptionForNSError(NSError error)
	{
		NSErrorException ex = new NSErrorException(error);
		if (error.Domain == NSError.NSUrlErrorDomain || error.Domain == NSError.CFNetworkErrorDomain)
		{
			NSUrlError nSUrlError = (NSUrlError)(long)error.Code;
			NSUrlError nSUrlError2 = nSUrlError;
			if (nSUrlError2 == (NSUrlError)(-72005) || nSUrlError2 == NSUrlError.UserCancelledAuthentication || nSUrlError2 == NSUrlError.Cancelled)
			{
				return new OperationCanceledException(error.LocalizedDescription, ex);
			}
		}
		return new HttpRequestException(error.LocalizedDescription, ex);
	}

	private string GetHeaderSeparator(string name)
	{
		if (!headerSeparators.TryGetValue(name, out var value))
		{
			return ",";
		}
		return value;
	}

	private void AddManagedHeaders(NSMutableDictionary nativeHeaders, IEnumerable<KeyValuePair<string, IEnumerable<string>>> managedHeaders)
	{
		foreach (KeyValuePair<string, IEnumerable<string>> managedHeader in managedHeaders)
		{
			IntPtr intPtr = NSString.CreateNative(managedHeader.Key);
			IntPtr intPtr2 = NSString.CreateNative(string.Join(GetHeaderSeparator(managedHeader.Key), managedHeader.Value));
			nativeHeaders.LowlevelSetObject(intPtr2, intPtr);
			NSString.ReleaseNative(intPtr);
			NSString.ReleaseNative(intPtr2);
		}
	}

	private async Task<NSUrlRequest> CreateRequest(HttpRequestMessage request)
	{
		Stream stream = Stream.Null;
		NSMutableDictionary nativeHeaders = new NSMutableDictionary();
		if (session.Configuration.HttpCookieStorage != null)
		{
			string cookies = cookieContainer?.GetCookieHeader(request.RequestUri);
			if (!string.IsNullOrEmpty(cookies))
			{
				IntPtr cookiePtr = NSString.CreateNative("Cookie");
				IntPtr cookiesPtr = NSString.CreateNative(cookies);
				nativeHeaders.LowlevelSetObject(cookiesPtr, cookiePtr);
				NSString.ReleaseNative(cookiePtr);
				NSString.ReleaseNative(cookiesPtr);
			}
		}
		AddManagedHeaders(nativeHeaders, request.Headers);
		if (request.Content != null)
		{
			stream = await request.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			AddManagedHeaders(nativeHeaders, request.Content.Headers);
		}
		NSMutableUrlRequest nsrequest = new NSMutableUrlRequest
		{
			AllowsCellularAccess = allowsCellularAccess,
			CachePolicy = (NSUrlRequestCachePolicy)(DisableCaching ? 1 : 0),
			HttpMethod = request.Method.ToString().ToUpperInvariant(),
			Url = NSUrl.FromString(request.RequestUri.AbsoluteUri),
			Headers = nativeHeaders
		};
		if (stream != Stream.Null)
		{
			long? length = request.Content.Headers.ContentLength;
			if (length.HasValue && length <= MaxInputInMemory)
			{
				nsrequest.Body = NSData.FromStream(stream);
			}
			else
			{
				nsrequest.BodyStream = new WrappedNSInputStream(stream);
			}
		}
		return nsrequest;
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		Volatile.Write(ref sentRequest, value: true);
		NSUrlRequest nsrequest = await CreateRequest(request).ConfigureAwait(continueOnCapturedContext: false);
		NSUrlSessionDataTask dataTask = session.CreateDataTask(nsrequest);
		TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
		lock (inflightRequestsLock)
		{
			inflightRequests.Add(dataTask, new InflightData
			{
				RequestUrl = request.RequestUri.AbsoluteUri,
				CompletionSource = tcs,
				CancellationToken = cancellationToken,
				CancellationTokenSource = new CancellationTokenSource(),
				Stream = new NSUrlSessionDataTaskStream(),
				Request = request
			});
		}
		if (dataTask.State == NSUrlSessionTaskState.Suspended)
		{
			dataTask.Resume();
		}
		cancellationToken.Register(delegate
		{
			RemoveInflightData(dataTask);
			tcs.TrySetCanceled();
		});
		return await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
	}
}
