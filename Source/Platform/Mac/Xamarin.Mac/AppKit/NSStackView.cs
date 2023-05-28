using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSStackView", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSStackView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddArrangedSubview_ = "addArrangedSubview:";

	private static readonly IntPtr selAddArrangedSubview_Handle = Selector.GetHandle("addArrangedSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddView_InGravity_ = "addView:inGravity:";

	private static readonly IntPtr selAddView_InGravity_Handle = Selector.GetHandle("addView:inGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangedSubviews = "arrangedSubviews";

	private static readonly IntPtr selArrangedSubviewsHandle = Selector.GetHandle("arrangedSubviews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClippingResistancePriorityForOrientation_ = "clippingResistancePriorityForOrientation:";

	private static readonly IntPtr selClippingResistancePriorityForOrientation_Handle = Selector.GetHandle("clippingResistancePriorityForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomSpacingAfterView_ = "customSpacingAfterView:";

	private static readonly IntPtr selCustomSpacingAfterView_Handle = Selector.GetHandle("customSpacingAfterView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachedViews = "detachedViews";

	private static readonly IntPtr selDetachedViewsHandle = Selector.GetHandle("detachedViews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachesHiddenViews = "detachesHiddenViews";

	private static readonly IntPtr selDetachesHiddenViewsHandle = Selector.GetHandle("detachesHiddenViews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistribution = "distribution";

	private static readonly IntPtr selDistributionHandle = Selector.GetHandle("distribution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeInsets = "edgeInsets";

	private static readonly IntPtr selEdgeInsetsHandle = Selector.GetHandle("edgeInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasEqualSpacing = "hasEqualSpacing";

	private static readonly IntPtr selHasEqualSpacingHandle = Selector.GetHandle("hasEqualSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHuggingPriorityForOrientation_ = "huggingPriorityForOrientation:";

	private static readonly IntPtr selHuggingPriorityForOrientation_Handle = Selector.GetHandle("huggingPriorityForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertArrangedSubview_AtIndex_ = "insertArrangedSubview:atIndex:";

	private static readonly IntPtr selInsertArrangedSubview_AtIndex_Handle = Selector.GetHandle("insertArrangedSubview:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertView_AtIndex_InGravity_ = "insertView:atIndex:inGravity:";

	private static readonly IntPtr selInsertView_AtIndex_InGravity_Handle = Selector.GetHandle("insertView:atIndex:inGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientation = "orientation";

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveArrangedSubview_ = "removeArrangedSubview:";

	private static readonly IntPtr selRemoveArrangedSubview_Handle = Selector.GetHandle("removeArrangedSubview:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveView_ = "removeView:";

	private static readonly IntPtr selRemoveView_Handle = Selector.GetHandle("removeView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_ = "setAlignment:";

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClippingResistancePriority_ForOrientation_ = "setClippingResistancePriority:forOrientation:";

	private static readonly IntPtr selSetClippingResistancePriority_ForOrientation_Handle = Selector.GetHandle("setClippingResistancePriority:forOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomSpacing_AfterView_ = "setCustomSpacing:afterView:";

	private static readonly IntPtr selSetCustomSpacing_AfterView_Handle = Selector.GetHandle("setCustomSpacing:afterView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDetachesHiddenViews_ = "setDetachesHiddenViews:";

	private static readonly IntPtr selSetDetachesHiddenViews_Handle = Selector.GetHandle("setDetachesHiddenViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDistribution_ = "setDistribution:";

	private static readonly IntPtr selSetDistribution_Handle = Selector.GetHandle("setDistribution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeInsets_ = "setEdgeInsets:";

	private static readonly IntPtr selSetEdgeInsets_Handle = Selector.GetHandle("setEdgeInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasEqualSpacing_ = "setHasEqualSpacing:";

	private static readonly IntPtr selSetHasEqualSpacing_Handle = Selector.GetHandle("setHasEqualSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHuggingPriority_ForOrientation_ = "setHuggingPriority:forOrientation:";

	private static readonly IntPtr selSetHuggingPriority_ForOrientation_Handle = Selector.GetHandle("setHuggingPriority:forOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientation_ = "setOrientation:";

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpacing_ = "setSpacing:";

	private static readonly IntPtr selSetSpacing_Handle = Selector.GetHandle("setSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViews_InGravity_ = "setViews:inGravity:";

	private static readonly IntPtr selSetViews_InGravity_Handle = Selector.GetHandle("setViews:inGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibilityPriority_ForView_ = "setVisibilityPriority:forView:";

	private static readonly IntPtr selSetVisibilityPriority_ForView_Handle = Selector.GetHandle("setVisibilityPriority:forView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpacing = "spacing";

	private static readonly IntPtr selSpacingHandle = Selector.GetHandle("spacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStackViewWithViews_ = "stackViewWithViews:";

	private static readonly IntPtr selStackViewWithViews_Handle = Selector.GetHandle("stackViewWithViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViews = "views";

	private static readonly IntPtr selViewsHandle = Selector.GetHandle("views");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewsInGravity_ = "viewsInGravity:";

	private static readonly IntPtr selViewsInGravity_Handle = Selector.GetHandle("viewsInGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibilityPriorityForView_ = "visibilityPriorityForView:";

	private static readonly IntPtr selVisibilityPriorityForView_Handle = Selector.GetHandle("visibilityPriorityForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStackView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutAttribute Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
		[Export("setAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetAlignment_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetAlignment_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSView[] ArrangedSubviews
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("arrangedSubviews", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedSubviewsHandle));
			}
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedSubviewsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSStackViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSStackViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView[] DetachedViews
	{
		[Export("detachedViews", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selDetachedViewsHandle));
			}
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDetachedViewsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool DetachesHiddenViews
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("detachesHiddenViews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDetachesHiddenViewsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDetachesHiddenViewsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDetachesHiddenViews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDetachesHiddenViews_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDetachesHiddenViews_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSStackViewDistribution Distribution
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("distribution", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSStackViewDistribution)Messaging.Int64_objc_msgSend(base.Handle, selDistributionHandle);
			}
			return (NSStackViewDistribution)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDistributionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDistribution:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDistribution_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDistribution_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEdgeInsets EdgeInsets
	{
		[Export("edgeInsets")]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selEdgeInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selEdgeInsetsHandle);
			}
			return retval;
		}
		[Export("setEdgeInsets:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetEdgeInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetEdgeInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
	public virtual bool HasEqualSpacing
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
		[Export("hasEqualSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasEqualSpacingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasEqualSpacingHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Set Distribution to NSStackViewDistribution.EqualSpacing instead.")]
		[Export("setHasEqualSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasEqualSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasEqualSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserInterfaceLayoutOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUserInterfaceLayoutOrientation)Messaging.Int64_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (NSUserInterfaceLayoutOrientation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetOrientation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetOrientation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Spacing
	{
		[Export("spacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpacingHandle);
		}
		[Export("setSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView[] Views
	{
		[Export("views", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewsHandle));
			}
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStackView()
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
	public NSStackView(NSCoder coder)
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
	protected NSStackView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStackView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSStackView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("addArrangedSubview:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddArrangedSubview(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddArrangedSubview_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddArrangedSubview_Handle, view.Handle);
		}
	}

	[Export("addView:inGravity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddView(NSView aView, NSStackViewGravity gravity)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddView_InGravity_Handle, aView.Handle, (long)gravity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddView_InGravity_Handle, aView.Handle, (long)gravity);
		}
	}

	[Export("clippingResistancePriorityForOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ClippingResistancePriorityForOrientation(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selClippingResistancePriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selClippingResistancePriorityForOrientation_Handle, (long)orientation);
	}

	[Export("customSpacingAfterView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CustomSpacingAfterView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selCustomSpacingAfterView_Handle, aView.Handle);
		}
		return Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selCustomSpacingAfterView_Handle, aView.Handle);
	}

	[Export("stackViewWithViews:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSStackView FromViews(NSView[] views)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		NSStackView nSObject = Runtime.GetNSObject<NSStackView>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selStackViewWithViews_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("huggingPriorityForOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float HuggingPriority(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Int64(base.Handle, selHuggingPriorityForOrientation_Handle, (long)orientation);
		}
		return Messaging.float_objc_msgSendSuper_Int64(base.SuperHandle, selHuggingPriorityForOrientation_Handle, (long)orientation);
	}

	[Export("insertArrangedSubview:atIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertArrangedSubview(NSView view, nint index)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertArrangedSubview_AtIndex_Handle, view.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertArrangedSubview_AtIndex_Handle, view.Handle, index);
		}
	}

	[Export("insertView:atIndex:inGravity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertView(NSView aView, nuint index, NSStackViewGravity gravity)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Int64(base.Handle, selInsertView_AtIndex_InGravity_Handle, aView.Handle, index, (long)gravity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Int64(base.SuperHandle, selInsertView_AtIndex_InGravity_Handle, aView.Handle, index, (long)gravity);
		}
	}

	[Export("removeArrangedSubview:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveArrangedSubview(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveArrangedSubview_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveArrangedSubview_Handle, view.Handle);
		}
	}

	[Export("removeView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveView(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveView_Handle, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveView_Handle, aView.Handle);
		}
	}

	[Export("setClippingResistancePriority:forOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetClippingResistancePriority(float clippingResistancePriority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetClippingResistancePriority_ForOrientation_Handle, clippingResistancePriority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetClippingResistancePriority_ForOrientation_Handle, clippingResistancePriority, (long)orientation);
		}
	}

	[Export("setCustomSpacing:afterView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCustomSpacing(nfloat spacing, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetCustomSpacing_AfterView_Handle, spacing, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetCustomSpacing_AfterView_Handle, spacing, aView.Handle);
		}
	}

	[Export("setHuggingPriority:forOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHuggingPriority(float huggingPriority, NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Int64(base.Handle, selSetHuggingPriority_ForOrientation_Handle, huggingPriority, (long)orientation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Int64(base.SuperHandle, selSetHuggingPriority_ForOrientation_Handle, huggingPriority, (long)orientation);
		}
	}

	[Export("setViews:inGravity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetViews(NSView[] views, NSStackViewGravity gravity)
	{
		NSApplication.EnsureUIThread();
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		NSArray nSArray = NSArray.FromNSObjects(views);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetViews_InGravity_Handle, nSArray.Handle, (long)gravity);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetViews_InGravity_Handle, nSArray.Handle, (long)gravity);
		}
		nSArray.Dispose();
	}

	[Export("setVisibilityPriority:forView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVisibilityPriority(float priority, NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetVisibilityPriority_ForView_Handle, priority, aView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetVisibilityPriority_ForView_Handle, priority, aView.Handle);
		}
	}

	[Export("viewsInGravity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView[] ViewsInGravity(NSStackViewGravity gravity)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selViewsInGravity_Handle, (long)gravity));
		}
		return NSArray.ArrayFromHandle<NSView>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selViewsInGravity_Handle, (long)gravity));
	}

	[Export("visibilityPriorityForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float VisibilityPriority(NSView aView)
	{
		NSApplication.EnsureUIThread();
		if (aView == null)
		{
			throw new ArgumentNullException("aView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selVisibilityPriorityForView_Handle, aView.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selVisibilityPriorityForView_Handle, aView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
