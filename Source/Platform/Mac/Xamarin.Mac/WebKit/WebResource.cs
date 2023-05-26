using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebResource", true)]
public class WebResource : NSObject
{
	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selMIMETypeHandle = Selector.GetHandle("MIMEType");

	private static readonly IntPtr selTextEncodingNameHandle = Selector.GetHandle("textEncodingName");

	private static readonly IntPtr selFrameNameHandle = Selector.GetHandle("frameName");

	private static readonly IntPtr selInitWithDataURLMIMETypeTextEncodingNameFrameName_Handle = Selector.GetHandle("initWithData:URL:MIMEType:textEncodingName:frameName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebResource");

	private object __mt_Data_var;

	private object __mt_Url_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

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

	public virtual string FrameName
	{
		[Export("frameName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFrameNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameNameHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebResource()
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
	public WebResource(NSCoder coder)
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
	public WebResource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebResource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:URL:MIMEType:textEncodingName:frameName:")]
	public WebResource(NSData data, NSUrl url, string mimeType, string textEncodingName, string frameName)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		if (textEncodingName == null)
		{
			throw new ArgumentNullException("textEncodingName");
		}
		if (frameName == null)
		{
			throw new ArgumentNullException("frameName");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		IntPtr arg2 = NSString.CreateNative(textEncodingName);
		IntPtr arg3 = NSString.CreateNative(frameName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDataURLMIMETypeTextEncodingNameFrameName_Handle, data.Handle, url.Handle, arg, arg2, arg3);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDataURLMIMETypeTextEncodingNameFrameName_Handle, data.Handle, url.Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Data_var = null;
			__mt_Url_var = null;
		}
	}
}
