using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAccessibilityCustomRotor", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSAccessibilityCustomRotor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLabel_ItemSearchDelegate_ = "initWithLabel:itemSearchDelegate:";

	private static readonly IntPtr selInitWithLabel_ItemSearchDelegate_Handle = Selector.GetHandle("initWithLabel:itemSearchDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRotorType_ItemSearchDelegate_ = "initWithRotorType:itemSearchDelegate:";

	private static readonly IntPtr selInitWithRotorType_ItemSearchDelegate_Handle = Selector.GetHandle("initWithRotorType:itemSearchDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemLoadingDelegate = "itemLoadingDelegate";

	private static readonly IntPtr selItemLoadingDelegateHandle = Selector.GetHandle("itemLoadingDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemSearchDelegate = "itemSearchDelegate";

	private static readonly IntPtr selItemSearchDelegateHandle = Selector.GetHandle("itemSearchDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemLoadingDelegate_ = "setItemLoadingDelegate:";

	private static readonly IntPtr selSetItemLoadingDelegate_Handle = Selector.GetHandle("setItemLoadingDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemSearchDelegate_ = "setItemSearchDelegate:";

	private static readonly IntPtr selSetItemSearchDelegate_Handle = Selector.GetHandle("setItemSearchDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetType_ = "setType:";

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAccessibilityCustomRotor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ItemLoadingDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ItemSearchDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSAccessibilityElementLoading? ItemLoadingDelegate
	{
		[Export("itemLoadingDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSAccessibilityElementLoading iNSAccessibilityElementLoading = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSAccessibilityElementLoading>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemLoadingDelegateHandle), owns: false) : Runtime.GetINativeObject<INSAccessibilityElementLoading>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemLoadingDelegateHandle), owns: false));
			MarkDirty();
			__mt_ItemLoadingDelegate_var = iNSAccessibilityElementLoading;
			return iNSAccessibilityElementLoading;
		}
		[Export("setItemLoadingDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItemLoadingDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItemLoadingDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_ItemLoadingDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSAccessibilityCustomRotorItemSearchDelegate? ItemSearchDelegate
	{
		[Export("itemSearchDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSAccessibilityCustomRotorItemSearchDelegate iNSAccessibilityCustomRotorItemSearchDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSAccessibilityCustomRotorItemSearchDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemSearchDelegateHandle), owns: false) : Runtime.GetINativeObject<INSAccessibilityCustomRotorItemSearchDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemSearchDelegateHandle), owns: false));
			MarkDirty();
			__mt_ItemSearchDelegate_var = iNSAccessibilityCustomRotorItemSearchDelegate;
			return iNSAccessibilityCustomRotorItemSearchDelegate;
		}
		[Export("setItemSearchDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItemSearchDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItemSearchDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_ItemSearchDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Label
	{
		[Export("label")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAccessibilityCustomRotorType Type
	{
		[Export("type", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAccessibilityCustomRotorType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (NSAccessibilityCustomRotorType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
		[Export("setType:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAccessibilityCustomRotor()
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
	protected NSAccessibilityCustomRotor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAccessibilityCustomRotor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLabel:itemSearchDelegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomRotor(string label, INSAccessibilityCustomRotorItemSearchDelegate itemSearchDelegate)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		if (itemSearchDelegate == null)
		{
			throw new ArgumentNullException("itemSearchDelegate");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLabel_ItemSearchDelegate_Handle, arg, itemSearchDelegate.Handle), "initWithLabel:itemSearchDelegate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLabel_ItemSearchDelegate_Handle, arg, itemSearchDelegate.Handle), "initWithLabel:itemSearchDelegate:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithRotorType:itemSearchDelegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomRotor(NSAccessibilityCustomRotorType rotorType, INSAccessibilityCustomRotorItemSearchDelegate itemSearchDelegate)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (itemSearchDelegate == null)
		{
			throw new ArgumentNullException("itemSearchDelegate");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(base.Handle, selInitWithRotorType_ItemSearchDelegate_Handle, (long)rotorType, itemSearchDelegate.Handle), "initWithRotorType:itemSearchDelegate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInitWithRotorType_ItemSearchDelegate_Handle, (long)rotorType, itemSearchDelegate.Handle), "initWithRotorType:itemSearchDelegate:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ItemLoadingDelegate_var = null;
			__mt_ItemSearchDelegate_var = null;
		}
	}
}
