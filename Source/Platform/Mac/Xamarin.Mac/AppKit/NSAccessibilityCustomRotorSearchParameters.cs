using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAccessibilityCustomRotorSearchParameters", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSAccessibilityCustomRotorSearchParameters : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentItem = "currentItem";

	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterString = "filterString";

	private static readonly IntPtr selFilterStringHandle = Selector.GetHandle("filterString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchDirection = "searchDirection";

	private static readonly IntPtr selSearchDirectionHandle = Selector.GetHandle("searchDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentItem_ = "setCurrentItem:";

	private static readonly IntPtr selSetCurrentItem_Handle = Selector.GetHandle("setCurrentItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilterString_ = "setFilterString:";

	private static readonly IntPtr selSetFilterString_Handle = Selector.GetHandle("setFilterString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSearchDirection_ = "setSearchDirection:";

	private static readonly IntPtr selSetSearchDirection_Handle = Selector.GetHandle("setSearchDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAccessibilityCustomRotorSearchParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAccessibilityCustomRotorItemResult? CurrentItem
	{
		[Export("currentItem", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAccessibilityCustomRotorItemResult>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle));
			}
			return Runtime.GetNSObject<NSAccessibilityCustomRotorItemResult>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle));
		}
		[Export("setCurrentItem:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCurrentItem_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCurrentItem_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FilterString
	{
		[Export("filterString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterStringHandle));
		}
		[Export("setFilterString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFilterString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFilterString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAccessibilityCustomRotorSearchDirection SearchDirection
	{
		[Export("searchDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityCustomRotorSearchDirection)Messaging.Int64_objc_msgSend(base.Handle, selSearchDirectionHandle);
			}
			return (NSAccessibilityCustomRotorSearchDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSearchDirectionHandle);
		}
		[Export("setSearchDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSearchDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSearchDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAccessibilityCustomRotorSearchParameters()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSAccessibilityCustomRotorSearchParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAccessibilityCustomRotorSearchParameters(IntPtr handle)
		: base(handle)
	{
	}
}
