using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSHTTPURLResponse", true)]
public class NSHttpUrlResponse : NSUrlResponse
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllHeaderFields = "allHeaderFields";

	private static readonly IntPtr selAllHeaderFieldsHandle = Selector.GetHandle("allHeaderFields");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_MIMEType_ExpectedContentLength_TextEncodingName_ = "initWithURL:MIMEType:expectedContentLength:textEncodingName:";

	private static readonly IntPtr selInitWithURL_MIMEType_ExpectedContentLength_TextEncodingName_Handle = Selector.GetHandle("initWithURL:MIMEType:expectedContentLength:textEncodingName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_StatusCode_HTTPVersion_HeaderFields_ = "initWithURL:statusCode:HTTPVersion:headerFields:";

	private static readonly IntPtr selInitWithURL_StatusCode_HTTPVersion_HeaderFields_Handle = Selector.GetHandle("initWithURL:statusCode:HTTPVersion:headerFields:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForStatusCode_ = "localizedStringForStatusCode:";

	private static readonly IntPtr selLocalizedStringForStatusCode_Handle = Selector.GetHandle("localizedStringForStatusCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusCode = "statusCode";

	private static readonly IntPtr selStatusCodeHandle = Selector.GetHandle("statusCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForHTTPHeaderField_ = "valueForHTTPHeaderField:";

	private static readonly IntPtr selValueForHTTPHeaderField_Handle = Selector.GetHandle("valueForHTTPHeaderField:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSHTTPURLResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary AllHeaderFields
	{
		[Export("allHeaderFields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllHeaderFieldsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllHeaderFieldsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint StatusCode
	{
		[Export("statusCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selStatusCodeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selStatusCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSHttpUrlResponse()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSHttpUrlResponse(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSHttpUrlResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSHttpUrlResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:MIMEType:expectedContentLength:textEncodingName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSHttpUrlResponse(NSUrl url, string mimetype, nint expectedContentLength, string? textEncodingName)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (mimetype == null)
		{
			throw new ArgumentNullException("mimetype");
		}
		IntPtr arg = NSString.CreateNative(mimetype);
		IntPtr arg2 = NSString.CreateNative(textEncodingName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(base.Handle, selInitWithURL_MIMEType_ExpectedContentLength_TextEncodingName_Handle, url.Handle, arg, expectedContentLength, arg2), "initWithURL:MIMEType:expectedContentLength:textEncodingName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr(base.SuperHandle, selInitWithURL_MIMEType_ExpectedContentLength_TextEncodingName_Handle, url.Handle, arg, expectedContentLength, arg2), "initWithURL:MIMEType:expectedContentLength:textEncodingName:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithURL:statusCode:HTTPVersion:headerFields:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSHttpUrlResponse(NSUrl url, nint statusCode, string httpVersion, NSDictionary headerFields)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (httpVersion == null)
		{
			throw new ArgumentNullException("httpVersion");
		}
		if (headerFields == null)
		{
			throw new ArgumentNullException("headerFields");
		}
		IntPtr arg = NSString.CreateNative(httpVersion);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr(base.Handle, selInitWithURL_StatusCode_HTTPVersion_HeaderFields_Handle, url.Handle, statusCode, arg, headerFields.Handle), "initWithURL:statusCode:HTTPVersion:headerFields:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_StatusCode_HTTPVersion_HeaderFields_Handle, url.Handle, statusCode, arg, headerFields.Handle), "initWithURL:statusCode:HTTPVersion:headerFields:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("valueForHTTPHeaderField:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetHttpHeaderValue(string headerField)
	{
		if (headerField == null)
		{
			throw new ArgumentNullException("headerField");
		}
		IntPtr arg = NSString.CreateNative(headerField);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForHTTPHeaderField_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForHTTPHeaderField_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringForStatusCode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizedStringForStatusCode(nint statusCode)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selLocalizedStringForStatusCode_Handle, statusCode));
	}
}
