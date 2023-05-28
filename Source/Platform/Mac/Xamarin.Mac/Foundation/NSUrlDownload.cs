using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLDownload", true)]
public class NSUrlDownload : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanResumeDownloadDecodedWithEncodingMIMEType_ = "canResumeDownloadDecodedWithEncodingMIMEType:";

	private static readonly IntPtr selCanResumeDownloadDecodedWithEncodingMIMEType_Handle = Selector.GetHandle("canResumeDownloadDecodedWithEncodingMIMEType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeletesFileUponFailure = "deletesFileUponFailure";

	private static readonly IntPtr selDeletesFileUponFailureHandle = Selector.GetHandle("deletesFileUponFailure");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_Delegate_ = "initWithRequest:delegate:";

	private static readonly IntPtr selInitWithRequest_Delegate_Handle = Selector.GetHandle("initWithRequest:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithResumeData_Delegate_Path_ = "initWithResumeData:delegate:path:";

	private static readonly IntPtr selInitWithResumeData_Delegate_Path_Handle = Selector.GetHandle("initWithResumeData:delegate:path:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequest = "request";

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeData = "resumeData";

	private static readonly IntPtr selResumeDataHandle = Selector.GetHandle("resumeData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeletesFileUponFailure_ = "setDeletesFileUponFailure:";

	private static readonly IntPtr selSetDeletesFileUponFailure_Handle = Selector.GetHandle("setDeletesFileUponFailure:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestination_AllowOverwrite_ = "setDestination:allowOverwrite:";

	private static readonly IntPtr selSetDestination_AllowOverwrite_Handle = Selector.GetHandle("setDestination:allowOverwrite:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLDownload");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeletesFileUponFailure
	{
		[Export("deletesFileUponFailure")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDeletesFileUponFailureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDeletesFileUponFailureHandle);
		}
		[Export("setDeletesFileUponFailure:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDeletesFileUponFailure_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDeletesFileUponFailure_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest Request
	{
		[Export("request")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ResumeData
	{
		[Export("resumeData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selResumeDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResumeDataHandle));
		}
	}

	public override string ToString()
	{
		return GetType().ToString();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlDownload()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlDownload(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlDownload(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:delegate:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSURLSession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRequest_Delegate_Handle, request.Handle, delegate1.Handle), "initWithRequest:delegate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRequest_Delegate_Handle, request.Handle, delegate1.Handle), "initWithRequest:delegate:");
		}
	}

	[Export("initWithResumeData:delegate:path:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSURLSession' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithResumeData_Delegate_Path_Handle, resumeData.Handle, delegate1.Handle, arg), "initWithResumeData:delegate:path:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithResumeData_Delegate_Path_Handle, resumeData.Handle, delegate1.Handle, arg), "initWithResumeData:delegate:path:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("canResumeDownloadDecodedWithEncodingMIMEType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("setDestination:allowOverwrite:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDestination(string path, bool allowOverwrite)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetDestination_AllowOverwrite_Handle, arg, allowOverwrite);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetDestination_AllowOverwrite_Handle, arg, allowOverwrite);
		}
		NSString.ReleaseNative(arg);
	}
}
