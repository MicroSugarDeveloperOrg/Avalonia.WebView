using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ContactsUI;

[Register("CNContactPicker", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactPicker : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayedKeys = "displayedKeys";

	private static readonly IntPtr selDisplayedKeysHandle = Selector.GetHandle("displayedKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayedKeys_ = "setDisplayedKeys:";

	private static readonly IntPtr selSetDisplayedKeys_Handle = Selector.GetHandle("setDisplayedKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowRelativeToRect_OfView_PreferredEdge_ = "showRelativeToRect:ofView:preferredEdge:";

	private static readonly IntPtr selShowRelativeToRect_OfView_PreferredEdge_Handle = Selector.GetHandle("showRelativeToRect:ofView:preferredEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactPicker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICNContactPickerDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			ICNContactPickerDelegate iCNContactPickerDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ICNContactPickerDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<ICNContactPickerDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iCNContactPickerDelegate;
			return iCNContactPickerDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] DisplayedKeys
	{
		[Export("displayedKeys", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayedKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayedKeysHandle));
		}
		[Export("setDisplayedKeys:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayedKeys_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayedKeys_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactPicker()
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
	protected CNContactPicker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactPicker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("showRelativeToRect:ofView:preferredEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Show(CGRect positioningRect, NSView positioningView, NSRectEdge preferredEdge)
	{
		if (positioningView == null)
		{
			throw new ArgumentNullException("positioningView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_UInt64(base.Handle, selShowRelativeToRect_OfView_PreferredEdge_Handle, positioningRect, positioningView.Handle, (ulong)preferredEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_UInt64(base.SuperHandle, selShowRelativeToRect_OfView_PreferredEdge_Handle, positioningRect, positioningView.Handle, (ulong)preferredEdge);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
