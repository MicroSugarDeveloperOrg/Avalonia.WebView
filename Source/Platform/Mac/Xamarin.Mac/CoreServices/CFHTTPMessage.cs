using System.Net;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreServices;

public class CFHTTPMessage : CFType, INativeObject, IDisposable
{
	private struct CFStreamError
	{
		public nint domain;

		public int code;
	}

	private enum CFStreamErrorHTTPAuthentication
	{
		TypeUnsupported = -1000,
		BadUserName = -1001,
		BadPassword = -1002
	}

	public enum AuthenticationScheme
	{
		Default,
		Basic,
		Negotiate,
		NTLM,
		Digest,
		[Mac(10, 9)]
		[iOS(7, 0)]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Not available anymore.")]
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Not available anymore.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Not available anymore.")]
		OAuth1
	}

	internal IntPtr handle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AuthenticationAccountDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AuthenticationPassword;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AuthenticationUsername;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __HTTPVersion1_0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __HTTPVersion1_1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __HTTPVersion2_0;

	public IntPtr Handle
	{
		get
		{
			CheckHandle();
			return handle;
		}
	}

	public bool IsRequest
	{
		get
		{
			CheckHandle();
			return CFHTTPMessageIsRequest(Handle);
		}
	}

	public HttpStatusCode ResponseStatusCode
	{
		get
		{
			if (IsRequest)
			{
				throw new InvalidOperationException();
			}
			return (HttpStatusCode)(int)CFHTTPMessageGetResponseStatusCode(Handle);
		}
	}

	public string ResponseStatusLine
	{
		get
		{
			if (IsRequest)
			{
				throw new InvalidOperationException();
			}
			IntPtr intPtr = CFHTTPMessageCopyResponseStatusLine(Handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			using NSString nSString = new NSString(intPtr);
			return nSString.ToString();
		}
	}

	public Version Version
	{
		get
		{
			CheckHandle();
			IntPtr intPtr = CFHTTPMessageCopyVersion(handle);
			try
			{
				if (intPtr == _HTTPVersion1_0.Handle)
				{
					return HttpVersion.Version10;
				}
				return HttpVersion.Version11;
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					CFObject.CFRelease(intPtr);
				}
			}
		}
	}

	public bool IsHeaderComplete
	{
		get
		{
			CheckHandle();
			return CFHTTPMessageIsHeaderComplete(Handle);
		}
	}

	[Field("kCFHTTPAuthenticationAccountDomain", "CFNetwork")]
	internal static NSString _AuthenticationAccountDomain
	{
		get
		{
			if (__AuthenticationAccountDomain == null)
			{
				__AuthenticationAccountDomain = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationAccountDomain");
			}
			return __AuthenticationAccountDomain;
		}
	}

	[Field("kCFHTTPAuthenticationPassword", "CFNetwork")]
	internal static NSString _AuthenticationPassword
	{
		get
		{
			if (__AuthenticationPassword == null)
			{
				__AuthenticationPassword = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationPassword");
			}
			return __AuthenticationPassword;
		}
	}

	[Field("kCFHTTPAuthenticationSchemeBasic", "CFNetwork")]
	internal static IntPtr _AuthenticationSchemeBasic => Dlfcn.GetIntPtr(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeBasic");

	[Field("kCFHTTPAuthenticationSchemeDigest", "CFNetwork")]
	internal static IntPtr _AuthenticationSchemeDigest => Dlfcn.GetIntPtr(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeDigest");

	[Field("kCFHTTPAuthenticationSchemeNTLM", "CFNetwork")]
	internal static IntPtr _AuthenticationSchemeNTLM => Dlfcn.GetIntPtr(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeNTLM");

	[Field("kCFHTTPAuthenticationSchemeNegotiate", "CFNetwork")]
	internal static IntPtr _AuthenticationSchemeNegotiate => Dlfcn.GetIntPtr(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeNegotiate");

	[Field("kCFHTTPAuthenticationSchemeOAuth1", "CFNetwork")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	internal static IntPtr _AuthenticationSchemeOAuth1
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationSchemeOAuth1");
		}
	}

	[Field("kCFHTTPAuthenticationUsername", "CFNetwork")]
	internal static NSString _AuthenticationUsername
	{
		get
		{
			if (__AuthenticationUsername == null)
			{
				__AuthenticationUsername = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPAuthenticationUsername");
			}
			return __AuthenticationUsername;
		}
	}

	[Field("kCFHTTPVersion1_0", "CFNetwork")]
	internal static NSString _HTTPVersion1_0
	{
		get
		{
			if (__HTTPVersion1_0 == null)
			{
				__HTTPVersion1_0 = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPVersion1_0");
			}
			return __HTTPVersion1_0;
		}
	}

	[Field("kCFHTTPVersion1_1", "CFNetwork")]
	internal static NSString _HTTPVersion1_1
	{
		get
		{
			if (__HTTPVersion1_1 == null)
			{
				__HTTPVersion1_1 = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPVersion1_1");
			}
			return __HTTPVersion1_1;
		}
	}

	[Field("kCFHTTPVersion2_0", "CFNetwork")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	internal static NSString _HTTPVersion2_0
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (__HTTPVersion2_0 == null)
			{
				__HTTPVersion2_0 = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFHTTPVersion2_0");
			}
			return __HTTPVersion2_0;
		}
	}

	internal CFHTTPMessage(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal CFHTTPMessage(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork", EntryPoint = "CFHTTPMessageGetTypeID")]
	public static extern nint GetTypeID();

	~CFHTTPMessage()
	{
		Dispose(disposing: false);
	}

	protected void CheckHandle()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	private static IntPtr GetVersion(Version version)
	{
		if (version == null || version.Equals(HttpVersion.Version11))
		{
			return _HTTPVersion1_1.Handle;
		}
		if (version.Equals(HttpVersion.Version10))
		{
			return _HTTPVersion1_0.Handle;
		}
		if (version.Major == 2 && version.Minor == 0)
		{
			if (_HTTPVersion2_0 != null && _HTTPVersion2_0.Handle != IntPtr.Zero)
			{
				return _HTTPVersion2_0.Handle;
			}
			return _HTTPVersion1_1.Handle;
		}
		throw new ArgumentException();
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHTTPMessageCreateEmpty(IntPtr alloc, bool isRequest);

	public static CFHTTPMessage CreateEmpty(bool request)
	{
		IntPtr intPtr = CFHTTPMessageCreateEmpty(IntPtr.Zero, request);
		return new CFHTTPMessage(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHTTPMessageCreateRequest(IntPtr alloc, IntPtr requestMethod, IntPtr url, IntPtr httpVersion);

	public static CFHTTPMessage CreateRequest(CFUrl url, NSString method, Version version)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		IntPtr intPtr = CFHTTPMessageCreateRequest(IntPtr.Zero, method.Handle, url.Handle, GetVersion(version));
		return new CFHTTPMessage(intPtr, owns: true);
	}

	public static CFHTTPMessage CreateRequest(Uri uri, string method)
	{
		return CreateRequest(uri, method, null);
	}

	public static CFHTTPMessage CreateRequest(Uri uri, string method, Version version)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		CFUrl cFUrl = null;
		NSString nSString = null;
		string url = Uri.EscapeUriString(uri.ToString());
		try
		{
			cFUrl = CFUrl.FromUrlString(url, null);
			if (cFUrl == null)
			{
				throw new ArgumentException("Invalid URL.");
			}
			nSString = new NSString(method);
			return CreateRequest(cFUrl, nSString, version);
		}
		finally
		{
			cFUrl?.Dispose();
			if (nSString != null)
			{
				nSString.Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageIsRequest(IntPtr message);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern nint CFHTTPMessageGetResponseStatusCode(IntPtr response);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHTTPMessageCopyResponseStatusLine(IntPtr response);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHTTPMessageCopyVersion(IntPtr message);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageIsHeaderComplete(IntPtr message);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageAppendBytes(IntPtr message, byte[] newBytes, nint numBytes);

	public bool AppendBytes(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		return CFHTTPMessageAppendBytes(Handle, bytes, bytes.Length);
	}

	public bool AppendBytes(byte[] bytes, nint count)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		return CFHTTPMessageAppendBytes(Handle, bytes, count);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHTTPMessageCopyAllHeaderFields(IntPtr message);

	public NSDictionary GetAllHeaderFields()
	{
		CheckHandle();
		return Runtime.GetNSObject<NSDictionary>(CFHTTPMessageCopyAllHeaderFields(handle));
	}

	private AuthenticationException GetException(CFStreamErrorHTTPAuthentication code)
	{
		switch (code)
		{
		case CFStreamErrorHTTPAuthentication.BadUserName:
			throw new InvalidCredentialException("Bad username.");
		case CFStreamErrorHTTPAuthentication.BadPassword:
			throw new InvalidCredentialException("Bad password.");
		case CFStreamErrorHTTPAuthentication.TypeUnsupported:
			throw new AuthenticationException("Authentication type not supported.");
		default:
			throw new AuthenticationException("Unknown error.");
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageApplyCredentials(IntPtr request, IntPtr auth, IntPtr username, IntPtr password, out CFStreamError error);

	public void ApplyCredentials(CFHTTPAuthentication auth, NetworkCredential credential)
	{
		if (auth == null)
		{
			throw new ArgumentNullException("auth");
		}
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (auth.RequiresAccountDomain)
		{
			ApplyCredentialDictionary(auth, credential);
			return;
		}
		CFString cFString = new CFString(credential.UserName);
		CFString cFString2 = new CFString(credential.Password);
		try
		{
			if (!CFHTTPMessageApplyCredentials(Handle, auth.Handle, cFString.Handle, cFString2.Handle, out var error))
			{
				throw GetException((CFStreamErrorHTTPAuthentication)error.code);
			}
		}
		finally
		{
			cFString.Dispose();
			cFString2.Dispose();
		}
	}

	internal static IntPtr GetAuthScheme(AuthenticationScheme scheme)
	{
		switch (scheme)
		{
		case AuthenticationScheme.Default:
			return IntPtr.Zero;
		case AuthenticationScheme.Basic:
			return _AuthenticationSchemeBasic;
		case AuthenticationScheme.Negotiate:
			return _AuthenticationSchemeNegotiate;
		case AuthenticationScheme.NTLM:
			return _AuthenticationSchemeNTLM;
		case AuthenticationScheme.Digest:
			return _AuthenticationSchemeDigest;
		case AuthenticationScheme.OAuth1:
			if (_AuthenticationSchemeOAuth1 == IntPtr.Zero)
			{
				throw new NotSupportedException("Requires iOS 7.0 or macOS 10.9 and lower than iOS 12 or macOS 10.14");
			}
			return _AuthenticationSchemeOAuth1;
		default:
			throw new ArgumentException();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageAddAuthentication(IntPtr request, IntPtr authenticationFailureResponse, IntPtr username, IntPtr password, IntPtr authenticationScheme, bool forProxy);

	public bool AddAuthentication(CFHTTPMessage failureResponse, NSString username, NSString password, AuthenticationScheme scheme, bool forProxy)
	{
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		return CFHTTPMessageAddAuthentication(Handle, failureResponse.GetHandle(), username.Handle, password.Handle, GetAuthScheme(scheme), forProxy);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern bool CFHTTPMessageApplyCredentialDictionary(IntPtr request, IntPtr auth, IntPtr dict, out CFStreamError error);

	public void ApplyCredentialDictionary(CFHTTPAuthentication auth, NetworkCredential credential)
	{
		if (auth == null)
		{
			throw new ArgumentNullException("auth");
		}
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		NSString[] array = new NSString[3];
		CFString[] array2 = new CFString[3];
		array[0] = _AuthenticationUsername;
		array[1] = _AuthenticationPassword;
		array[2] = _AuthenticationAccountDomain;
		array2[0] = credential.UserName;
		array2[1] = credential.Password;
		array2[2] = ((credential.Domain != null) ? ((CFString)credential.Domain) : null);
		INativeObject[] array3 = array2;
		INativeObject[] objects = array3;
		array3 = array;
		CFDictionary cFDictionary = CFDictionary.FromObjectsAndKeys(objects, array3);
		try
		{
			if (CFHTTPMessageApplyCredentialDictionary(Handle, auth.Handle, cFDictionary.Handle, out var error))
			{
				return;
			}
			throw GetException((CFStreamErrorHTTPAuthentication)error.code);
		}
		finally
		{
			cFDictionary.Dispose();
			array2[0].Dispose();
			array2[1].Dispose();
			if (array2[2] != null)
			{
				array2[2].Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern void CFHTTPMessageSetHeaderFieldValue(IntPtr message, IntPtr headerField, IntPtr value);

	public void SetHeaderFieldValue(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		NSString nSString = (NSString)name;
		NSString nSString2 = ((value != null) ? ((NSString)value) : null);
		IntPtr value2 = ((nSString2 != null) ? nSString2.Handle : IntPtr.Zero);
		CFHTTPMessageSetHeaderFieldValue(Handle, nSString.Handle, value2);
		nSString.Dispose();
		if (nSString2 != null)
		{
			nSString2.Dispose();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern void CFHTTPMessageSetBody(IntPtr message, IntPtr data);

	public void SetBody(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		using CFDataBuffer cFDataBuffer = new CFDataBuffer(buffer);
		CFHTTPMessageSetBody(Handle, cFDataBuffer.Handle);
	}
}
