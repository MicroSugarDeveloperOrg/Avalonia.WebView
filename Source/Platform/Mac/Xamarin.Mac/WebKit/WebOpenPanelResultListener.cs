using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebOpenPanelResultListener", true)]
public class WebOpenPanelResultListener : NSObject
{
	private static readonly IntPtr selChooseFilename_Handle = Selector.GetHandle("chooseFilename:");

	private static readonly IntPtr selChooseFilenames_Handle = Selector.GetHandle("chooseFilenames:");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebOpenPanelResultListener");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebOpenPanelResultListener()
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
	public WebOpenPanelResultListener(NSCoder coder)
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
	public WebOpenPanelResultListener(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebOpenPanelResultListener(IntPtr handle)
		: base(handle)
	{
	}

	[Export("chooseFilename:")]
	public virtual void ChooseFilename(string filename)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChooseFilename_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChooseFilename_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("chooseFilenames:")]
	public virtual void ChooseFilenames(string[] filenames)
	{
		if (filenames == null)
		{
			throw new ArgumentNullException("filenames");
		}
		NSArray nSArray = NSArray.FromStrings(filenames);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChooseFilenames_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChooseFilenames_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
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
}
