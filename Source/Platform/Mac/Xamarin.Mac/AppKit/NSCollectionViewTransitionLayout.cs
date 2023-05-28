using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewTransitionLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewTransitionLayout : NSCollectionViewLayout
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentLayout = "currentLayout";

	private static readonly IntPtr selCurrentLayoutHandle = Selector.GetHandle("currentLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCurrentLayout_NextLayout_ = "initWithCurrentLayout:nextLayout:";

	private static readonly IntPtr selInitWithCurrentLayout_NextLayout_Handle = Selector.GetHandle("initWithCurrentLayout:nextLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextLayout = "nextLayout";

	private static readonly IntPtr selNextLayoutHandle = Selector.GetHandle("nextLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransitionProgress_ = "setTransitionProgress:";

	private static readonly IntPtr selSetTransitionProgress_Handle = Selector.GetHandle("setTransitionProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitionProgress = "transitionProgress";

	private static readonly IntPtr selTransitionProgressHandle = Selector.GetHandle("transitionProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateValue_ForAnimatedKey_ = "updateValue:forAnimatedKey:";

	private static readonly IntPtr selUpdateValue_ForAnimatedKey_Handle = Selector.GetHandle("updateValue:forAnimatedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAnimatedKey_ = "valueForAnimatedKey:";

	private static readonly IntPtr selValueForAnimatedKey_Handle = Selector.GetHandle("valueForAnimatedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewTransitionLayout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayout CurrentLayout
	{
		[Export("currentLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentLayoutHandle));
			}
			return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentLayoutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayout NextLayout
	{
		[Export("nextLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextLayoutHandle));
			}
			return Runtime.GetNSObject<NSCollectionViewLayout>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextLayoutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TransitionProgress
	{
		[Export("transitionProgress", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTransitionProgressHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTransitionProgressHandle);
		}
		[Export("setTransitionProgress:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTransitionProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTransitionProgress_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCollectionViewTransitionLayout(NSCoder coder)
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
	protected NSCollectionViewTransitionLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewTransitionLayout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Obsolete("Use the constructor that allows you to set currentLayout and newLayout.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionViewTransitionLayout()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithCurrentLayout:nextLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionViewTransitionLayout(NSCollectionViewLayout currentLayout, NSCollectionViewLayout newLayout)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (currentLayout == null)
		{
			throw new ArgumentNullException("currentLayout");
		}
		if (newLayout == null)
		{
			throw new ArgumentNullException("newLayout");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCurrentLayout_NextLayout_Handle, currentLayout.Handle, newLayout.Handle), "initWithCurrentLayout:nextLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCurrentLayout_NextLayout_Handle, currentLayout.Handle, newLayout.Handle), "initWithCurrentLayout:nextLayout:");
		}
	}

	[Export("valueForAnimatedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetValue(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		nfloat result = ((!base.IsDirectBinding) ? Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAnimatedKey_Handle, arg) : Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selValueForAnimatedKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("updateValue:forAnimatedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateValue(nfloat value, string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selUpdateValue_ForAnimatedKey_Handle, value, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selUpdateValue_ForAnimatedKey_Handle, value, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
