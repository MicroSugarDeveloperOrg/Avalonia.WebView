using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSHTTPURLResponse", true)]
public class NSHttpUrlResponse : NSUrlResponse
{
	private static readonly IntPtr selStatusCodeHandle = Selector.GetHandle("statusCode");

	private static readonly IntPtr selAllHeaderFieldsHandle = Selector.GetHandle("allHeaderFields");

	private static readonly IntPtr selInitWithURLStatusCodeHTTPVersionHeaderFields_Handle = Selector.GetHandle("initWithURL:statusCode:HTTPVersion:headerFields:");

	private static readonly IntPtr selLocalizedStringForStatusCode_Handle = Selector.GetHandle("localizedStringForStatusCode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSHTTPURLResponse");

	private object __mt_AllHeaderFields_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual long StatusCode
	{
		[Export("statusCode")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selStatusCodeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusCodeHandle);
		}
	}

	public virtual NSDictionary AllHeaderFields
	{
		[Export("allHeaderFields")]
		get
		{
			return (NSDictionary)(__mt_AllHeaderFields_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllHeaderFieldsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAllHeaderFieldsHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSHttpUrlResponse()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSHttpUrlResponse(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHttpUrlResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSHttpUrlResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:statusCode:HTTPVersion:headerFields:")]
	public NSHttpUrlResponse(NSUrl url, long statusCode, string httpVersion, NSDictionary headerFields)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr(base.Handle, selInitWithURLStatusCodeHTTPVersionHeaderFields_Handle, url.Handle, statusCode, arg, headerFields.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr(base.SuperHandle, selInitWithURLStatusCodeHTTPVersionHeaderFields_Handle, url.Handle, statusCode, arg, headerFields.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("localizedStringForStatusCode:")]
	public static string LocalizedStringForStatusCode(long statusCode)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selLocalizedStringForStatusCode_Handle, statusCode));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AllHeaderFields_var = null;
		}
	}
}
