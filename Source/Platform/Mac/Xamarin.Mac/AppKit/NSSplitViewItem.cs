using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSplitViewItem", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSSplitViewItem : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimator = "animator";

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticMaximumThickness = "automaticMaximumThickness";

	private static readonly IntPtr selAutomaticMaximumThicknessHandle = Selector.GetHandle("automaticMaximumThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehavior = "behavior";

	private static readonly IntPtr selBehaviorHandle = Selector.GetHandle("behavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanCollapse = "canCollapse";

	private static readonly IntPtr selCanCollapseHandle = Selector.GetHandle("canCollapse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentListWithViewController_ = "contentListWithViewController:";

	private static readonly IntPtr selContentListWithViewController_Handle = Selector.GetHandle("contentListWithViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHoldingPriority = "holdingPriority";

	private static readonly IntPtr selHoldingPriorityHandle = Selector.GetHandle("holdingPriority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCollapsed = "isCollapsed";

	private static readonly IntPtr selIsCollapsedHandle = Selector.GetHandle("isCollapsed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSpringLoaded = "isSpringLoaded";

	private static readonly IntPtr selIsSpringLoadedHandle = Selector.GetHandle("isSpringLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumThickness = "maximumThickness";

	private static readonly IntPtr selMaximumThicknessHandle = Selector.GetHandle("maximumThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumThickness = "minimumThickness";

	private static readonly IntPtr selMinimumThicknessHandle = Selector.GetHandle("minimumThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredThicknessFraction = "preferredThicknessFraction";

	private static readonly IntPtr selPreferredThicknessFractionHandle = Selector.GetHandle("preferredThicknessFraction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticMaximumThickness_ = "setAutomaticMaximumThickness:";

	private static readonly IntPtr selSetAutomaticMaximumThickness_Handle = Selector.GetHandle("setAutomaticMaximumThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanCollapse_ = "setCanCollapse:";

	private static readonly IntPtr selSetCanCollapse_Handle = Selector.GetHandle("setCanCollapse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsed_ = "setCollapsed:";

	private static readonly IntPtr selSetCollapsed_Handle = Selector.GetHandle("setCollapsed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHoldingPriority_ = "setHoldingPriority:";

	private static readonly IntPtr selSetHoldingPriority_Handle = Selector.GetHandle("setHoldingPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumThickness_ = "setMaximumThickness:";

	private static readonly IntPtr selSetMaximumThickness_Handle = Selector.GetHandle("setMaximumThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumThickness_ = "setMinimumThickness:";

	private static readonly IntPtr selSetMinimumThickness_Handle = Selector.GetHandle("setMinimumThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredThicknessFraction_ = "setPreferredThicknessFraction:";

	private static readonly IntPtr selSetPreferredThicknessFraction_Handle = Selector.GetHandle("setPreferredThicknessFraction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpringLoaded_ = "setSpringLoaded:";

	private static readonly IntPtr selSetSpringLoaded_Handle = Selector.GetHandle("setSpringLoaded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViewController_ = "setViewController:";

	private static readonly IntPtr selSetViewController_Handle = Selector.GetHandle("setViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSidebarWithViewController_ = "sidebarWithViewController:";

	private static readonly IntPtr selSidebarWithViewController_Handle = Selector.GetHandle("sidebarWithViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitViewItemWithViewController_ = "splitViewItemWithViewController:";

	private static readonly IntPtr selSplitViewItemWithViewController_Handle = Selector.GetHandle("splitViewItemWithViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewController = "viewController";

	private static readonly IntPtr selViewControllerHandle = Selector.GetHandle("viewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSplitViewItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle)));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat AutomaticMaximumThickness
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("automaticMaximumThickness", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAutomaticMaximumThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAutomaticMaximumThicknessHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAutomaticMaximumThickness:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAutomaticMaximumThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAutomaticMaximumThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSSplitViewItemBehavior Behavior
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("behavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSplitViewItemBehavior)Messaging.Int64_objc_msgSend(base.Handle, selBehaviorHandle);
			}
			return (NSSplitViewItemBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBehaviorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanCollapse
	{
		[Export("canCollapse")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanCollapseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanCollapseHandle);
		}
		[Export("setCanCollapse:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanCollapse_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanCollapse_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Collapsed
	{
		[Export("isCollapsed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCollapsedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCollapsedHandle);
		}
		[Export("setCollapsed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCollapsed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCollapsed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HoldingPriority
	{
		[Export("holdingPriority")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHoldingPriorityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHoldingPriorityHandle);
		}
		[Export("setHoldingPriority:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHoldingPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHoldingPriority_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat MaximumThickness
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("maximumThickness", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumThicknessHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMaximumThickness:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat MinimumThickness
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("minimumThickness", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumThicknessHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMinimumThickness:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat PreferredThicknessFraction
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("preferredThicknessFraction", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPreferredThicknessFractionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPreferredThicknessFractionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setPreferredThicknessFraction:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetPreferredThicknessFraction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetPreferredThicknessFraction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool SpringLoaded
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isSpringLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpringLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpringLoadedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setSpringLoaded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSpringLoaded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSpringLoaded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController ViewController
	{
		[Export("viewController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewControllerHandle));
		}
		[Export("setViewController:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetViewController_Handle, value.Handle);
			}
		}
	}

	[Field("NSSplitViewItemUnspecifiedDimension", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static nfloat UnspecifiedDimension
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNFloat(Libraries.AppKit.Handle, "NSSplitViewItemUnspecifiedDimension");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSplitViewItem()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSplitViewItem(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSplitViewItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSplitViewItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("contentListWithViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSplitViewItem CreateContentList(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		return Runtime.GetNSObject<NSSplitViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContentListWithViewController_Handle, viewController.Handle));
	}

	[Export("sidebarWithViewController:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSplitViewItem CreateSidebar(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		return Runtime.GetNSObject<NSSplitViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSidebarWithViewController_Handle, viewController.Handle));
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("splitViewItemWithViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSplitViewItem FromViewController(NSViewController viewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		return Runtime.GetNSObject<NSSplitViewItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSplitViewItemWithViewController_Handle, viewController.Handle));
	}
}
