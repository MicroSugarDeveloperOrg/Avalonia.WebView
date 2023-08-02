using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLDownload", true)]
public class NSUrlDownload : NSObject
{
	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	private static readonly IntPtr selResumeDataHandle = Selector.GetHandle("resumeData");

	private static readonly IntPtr selDeletesFileUponFailureHandle = Selector.GetHandle("deletesFileUponFailure");

	private static readonly IntPtr selSetDeletesFileUponFailure_Handle = Selector.GetHandle("setDeletesFileUponFailure:");

	private static readonly IntPtr selCanResumeDownloadDecodedWithEncodingMIMEType_Handle = Selector.GetHandle("canResumeDownloadDecodedWithEncodingMIMEType:");

	private static readonly IntPtr selInitWithRequestDelegate_Handle = Selector.GetHandle("initWithRequest:delegate:");

	private static readonly IntPtr selInitWithResumeDataDelegatePath_Handle = Selector.GetHandle("initWithResumeData:delegate:path:");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr selSetDestinationAllowOverwrite_Handle = Selector.GetHandle("setDestination:allowOverwrite:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLDownload");

	private object __mt_Request_var;

	private object __mt_ResumeData_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrlRequest Request
	{
		[Export("request")]
		get
		{
			return (NSUrlRequest)(__mt_Request_var = ((!IsDirectBinding) ? ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle))) : ((NSUrlRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle)))));
		}
	}

	public virtual NSData ResumeData
	{
		[Export("resumeData")]
		get
		{
			return (NSData)(__mt_ResumeData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResumeDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResumeDataHandle)))));
		}
	}

	public virtual bool DeletesFileUponFailure
	{
		[Export("deletesFileUponFailure")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDeletesFileUponFailureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeletesFileUponFailureHandle);
		}
		[Export("setDeletesFileUponFailure:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDeletesFileUponFailure_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDeletesFileUponFailure_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlDownload()
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
	public NSUrlDownload(NSCoder coder)
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
	public NSUrlDownload(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlDownload(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canResumeDownloadDecodedWithEncodingMIMEType:")]
	public static bool CanResumeDownloadDecodedWithEncodingMimeType(string mimeType)
	{
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		IntPtr arg = NSString.CreateNative(mimeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanResumeDownloadDecodedWithEncodingMIMEType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithRequest:delegate:")]
	public NSUrlDownload(NSUrlRequest request, NSObject delegate1)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (delegate1 == null)
		{
			throw new ArgumentNullException("delegate1");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRequestDelegate_Handle, request.Handle, delegate1.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRequestDelegate_Handle, request.Handle, delegate1.Handle);
		}
	}

	[Export("initWithResumeData:delegate:path:")]
	public NSUrlDownload(NSData resumeData, NSObject delegate1, string path)
		: base(NSObjectFlag.Empty)
	{
		if (resumeData == null)
		{
			throw new ArgumentNullException("resumeData");
		}
		if (delegate1 == null)
		{
			throw new ArgumentNullException("delegate1");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithResumeDataDelegatePath_Handle, resumeData.Handle, delegate1.Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithResumeDataDelegatePath_Handle, resumeData.Handle, delegate1.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cancel")]
	public virtual void Cancel()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("setDestination:allowOverwrite:")]
	public virtual void SetDestination(string path, bool allowOverwrite)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetDestinationAllowOverwrite_Handle, arg, allowOverwrite);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetDestinationAllowOverwrite_Handle, arg, allowOverwrite);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Request_var = null;
			__mt_ResumeData_var = null;
		}
	}
}
