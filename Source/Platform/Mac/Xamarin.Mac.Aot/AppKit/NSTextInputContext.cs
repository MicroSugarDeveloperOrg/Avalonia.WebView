using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextInputContext", true)]
public class NSTextInputContext : NSObject
{
	private static readonly IntPtr selCurrentInputContextHandle = Selector.GetHandle("currentInputContext");

	private static readonly IntPtr selActivateHandle = Selector.GetHandle("activate");

	private static readonly IntPtr selDeactivateHandle = Selector.GetHandle("deactivate");

	private static readonly IntPtr selHandleEvent_Handle = Selector.GetHandle("handleEvent:");

	private static readonly IntPtr selDiscardMarkedTextHandle = Selector.GetHandle("discardMarkedText");

	private static readonly IntPtr selInvalidateCharacterCoordinatesHandle = Selector.GetHandle("invalidateCharacterCoordinates");

	private static readonly IntPtr selLocalizedNameForInputSource_Handle = Selector.GetHandle("localizedNameForInputSource:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextInputContext");

	private static object __mt_CurrentInputContext_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSTextInputContext CurrentInputContext
	{
		[Export("currentInputContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextInputContext)(__mt_CurrentInputContext_var_static = (NSTextInputContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentInputContextHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextInputContext()
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
	public NSTextInputContext(NSCoder coder)
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
	public NSTextInputContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextInputContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("activate")]
	public virtual void Activate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selActivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selActivateHandle);
		}
	}

	[Export("deactivate")]
	public virtual void Deactivate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeactivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeactivateHandle);
		}
	}

	[Export("handleEvent:")]
	public virtual bool HandleEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHandleEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleEvent_Handle, theEvent.Handle);
	}

	[Export("discardMarkedText")]
	public virtual void DiscardMarkedText()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardMarkedTextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardMarkedTextHandle);
		}
	}

	[Export("invalidateCharacterCoordinates")]
	public virtual void InvalidateCharacterCoordinates()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateCharacterCoordinatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateCharacterCoordinatesHandle);
		}
	}

	[Export("localizedNameForInputSource:")]
	public static string LocalizedNameForInputSource(string inputSourceIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (inputSourceIdentifier == null)
		{
			throw new ArgumentNullException("inputSourceIdentifier");
		}
		IntPtr arg = NSString.CreateNative(inputSourceIdentifier);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedNameForInputSource_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}
