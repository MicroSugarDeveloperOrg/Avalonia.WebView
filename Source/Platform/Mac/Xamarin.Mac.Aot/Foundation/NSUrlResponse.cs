using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLResponse", true)]
public class NSUrlResponse : NSObject
{
	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selMIMETypeHandle = Selector.GetHandle("MIMEType");

	private static readonly IntPtr selExpectedContentLengthHandle = Selector.GetHandle("expectedContentLength");

	private static readonly IntPtr selTextEncodingNameHandle = Selector.GetHandle("textEncodingName");

	private static readonly IntPtr selSuggestedFilenameHandle = Selector.GetHandle("suggestedFilename");

	private static readonly IntPtr selInitWithURLMIMETypeExpectedContentLengthTextEncodingName_Handle = Selector.GetHandle("initWithURL:MIMEType:expectedContentLength:textEncodingName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLResponse");

	private object __mt_Url_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
	}

	public virtual string MimeType
	{
		[Export("MIMEType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMIMETypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMIMETypeHandle));
		}
	}

	public virtual long ExpectedContentLength
	{
		[Export("expectedContentLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selExpectedContentLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selExpectedContentLengthHandle);
		}
	}

	public virtual string TextEncodingName
	{
		[Export("textEncodingName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextEncodingNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextEncodingNameHandle));
		}
	}

	public virtual string SuggestedFilename
	{
		[Export("suggestedFilename")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSuggestedFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuggestedFilenameHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlResponse()
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
	public NSUrlResponse(NSCoder coder)
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
	public NSUrlResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:MIMEType:expectedContentLength:textEncodingName:")]
	public NSUrlResponse(NSUrl url, string mimetype, long expectedContentLength, string textEncodingName)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr(base.Handle, selInitWithURLMIMETypeExpectedContentLengthTextEncodingName_Handle, url.Handle, arg, expectedContentLength, arg2);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr(base.SuperHandle, selInitWithURLMIMETypeExpectedContentLengthTextEncodingName_Handle, url.Handle, arg, expectedContentLength, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
		}
	}
}
