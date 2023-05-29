using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingImageComponent", true)]
public class NSDraggingImageComponent : NSObject
{
	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	private static readonly IntPtr selSetKey_Handle = Selector.GetHandle("setKey:");

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	private static readonly IntPtr selSetContents_Handle = Selector.GetHandle("setContents:");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	private static readonly IntPtr selDraggingImageComponentWithKey_Handle = Selector.GetHandle("draggingImageComponentWithKey:");

	private static readonly IntPtr selInitWithKey_Handle = Selector.GetHandle("initWithKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDraggingImageComponent");

	private object __mt_Contents_var;

	private static NSString _IconKey;

	private static NSString _LabelKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Key
	{
		[Export("key")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle));
		}
		[Export("setKey:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKey_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKey_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject Contents
	{
		[Export("contents")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Contents_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle))));
		}
		[Export("setContents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContents_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContents_Handle, value.Handle);
			}
			__mt_Contents_var = value;
		}
	}

	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
		[Export("setFrame:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrame_Handle, value);
			}
		}
	}

	[Field("NSDraggingImageComponentIconKey", "AppKit")]
	public static NSString IconKey
	{
		get
		{
			if (_IconKey == null)
			{
				_IconKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDraggingImageComponentIconKey");
			}
			return _IconKey;
		}
	}

	[Field("NSDraggingImageComponentLabelKey", "AppKit")]
	public static NSString LabelKey
	{
		get
		{
			if (_LabelKey == null)
			{
				_LabelKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDraggingImageComponentLabelKey");
			}
			return _LabelKey;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDraggingImageComponent()
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
	public NSDraggingImageComponent(NSCoder coder)
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
	public NSDraggingImageComponent(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingImageComponent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("draggingImageComponentWithKey:")]
	public static NSDraggingImageComponent FromKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSDraggingImageComponent result = (NSDraggingImageComponent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDraggingImageComponentWithKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithKey:")]
	public NSDraggingImageComponent(string key)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithKey_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Contents_var = null;
		}
	}
}
