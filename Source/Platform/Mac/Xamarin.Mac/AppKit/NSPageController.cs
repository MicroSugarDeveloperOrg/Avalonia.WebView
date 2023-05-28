using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPageController", true)]
public class NSPageController : NSViewController
{
	[Register]
	internal class _NSPageControllerDelegate : NSObject, INSPageControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? didEndLiveTransition;

		internal EventHandler<NSPageControllerTransitionEventArgs>? didTransition;

		internal NSPageControllerGetFrame? getFrame;

		internal NSPageControllerGetIdentifier? getIdentifier;

		internal NSPageControllerGetViewController? getViewController;

		internal EventHandler<NSPageControllerPrepareViewControllerEventArgs>? prepareViewController;

		internal EventHandler? willStartLiveTransition;

		private static IntPtr selGetFrameHandle = Selector.GetHandle("pageController:frameForObject:");

		private static IntPtr selRespondsToSelector = Selector.GetHandle("respondsToSelector:");

		public _NSPageControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("pageControllerDidEndLiveTransition:")]
		public void DidEndLiveTransition(NSPageController pageController)
		{
			didEndLiveTransition?.Invoke(pageController, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("pageController:didTransitionToObject:")]
		public void DidTransition(NSPageController pageController, NSObject targetObject)
		{
			EventHandler<NSPageControllerTransitionEventArgs> eventHandler = didTransition;
			if (eventHandler != null)
			{
				NSPageControllerTransitionEventArgs e = new NSPageControllerTransitionEventArgs(targetObject);
				eventHandler(pageController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("pageController:frameForObject:")]
		public CGRect GetFrame(NSPageController pageController, NSObject targetObject)
		{
			NSPageControllerGetFrame nSPageControllerGetFrame = getFrame;
			if (nSPageControllerGetFrame != null)
			{
				return nSPageControllerGetFrame(pageController, targetObject);
			}
			throw new You_Should_Not_Call_base_In_This_Method();
		}

		[Preserve(Conditional = true)]
		[Export("pageController:identifierForObject:")]
		public string GetIdentifier(NSPageController pageController, NSObject targetObject)
		{
			NSPageControllerGetIdentifier nSPageControllerGetIdentifier = getIdentifier;
			if (nSPageControllerGetIdentifier != null)
			{
				return nSPageControllerGetIdentifier(pageController, targetObject);
			}
			return string.Empty;
		}

		[Preserve(Conditional = true)]
		[Export("pageController:viewControllerForIdentifier:")]
		public NSViewController GetViewController(NSPageController pageController, string identifier)
		{
			return getViewController?.Invoke(pageController, identifier);
		}

		[Preserve(Conditional = true)]
		[Export("pageController:prepareViewController:withObject:")]
		public void PrepareViewController(NSPageController pageController, NSViewController viewController, NSObject targetObject)
		{
			EventHandler<NSPageControllerPrepareViewControllerEventArgs> eventHandler = prepareViewController;
			if (eventHandler != null)
			{
				NSPageControllerPrepareViewControllerEventArgs e = new NSPageControllerPrepareViewControllerEventArgs(viewController, targetObject);
				eventHandler(pageController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("pageControllerWillStartLiveTransition:")]
		public void WillStartLiveTransition(NSPageController pageController)
		{
			willStartLiveTransition?.Invoke(pageController, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override bool RespondsToSelector(Selector? sel)
		{
			if (sel == null)
			{
				return false;
			}
			IntPtr arg = ((sel == null) ? IntPtr.Zero : sel.Handle);
			if (arg.Equals(selGetFrameHandle))
			{
				return getFrame != null;
			}
			return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRespondsToSelector, arg);
		}
	}

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
	private const string selArrangedObjects = "arrangedObjects";

	private static readonly IntPtr selArrangedObjectsHandle = Selector.GetHandle("arrangedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteTransition = "completeTransition";

	private static readonly IntPtr selCompleteTransitionHandle = Selector.GetHandle("completeTransition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNavigateBack_ = "navigateBack:";

	private static readonly IntPtr selNavigateBack_Handle = Selector.GetHandle("navigateBack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNavigateForward_ = "navigateForward:";

	private static readonly IntPtr selNavigateForward_Handle = Selector.GetHandle("navigateForward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNavigateForwardToObject_ = "navigateForwardToObject:";

	private static readonly IntPtr selNavigateForwardToObject_Handle = Selector.GetHandle("navigateForwardToObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedViewController = "selectedViewController";

	private static readonly IntPtr selSelectedViewControllerHandle = Selector.GetHandle("selectedViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrangedObjects_ = "setArrangedObjects:";

	private static readonly IntPtr selSetArrangedObjects_Handle = Selector.GetHandle("setArrangedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransitionStyle_ = "setTransitionStyle:";

	private static readonly IntPtr selSetTransitionStyle_Handle = Selector.GetHandle("setTransitionStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTakeSelectedIndexFrom_ = "takeSelectedIndexFrom:";

	private static readonly IntPtr selTakeSelectedIndexFrom_Handle = Selector.GetHandle("takeSelectedIndexFrom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitionStyle = "transitionStyle";

	private static readonly IntPtr selTransitionStyleHandle = Selector.GetHandle("transitionStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPageController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

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
	public virtual NSObject[] ArrangedObjects
	{
		[Export("arrangedObjects", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedObjectsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedObjectsHandle));
		}
		[Export("setArrangedObjects:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetArrangedObjects_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetArrangedObjects_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSPageControllerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSPageControllerDelegate;
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
	public virtual nint SelectedIndex
	{
		[Export("selectedIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedIndexHandle);
		}
		[Export("setSelectedIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSelectedIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSelectedIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController SelectedViewController
	{
		[Export("selectedViewController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedViewControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPageControllerTransitionStyle TransitionStyle
	{
		[Export("transitionStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSPageControllerTransitionStyle)Messaging.Int64_objc_msgSend(base.Handle, selTransitionStyleHandle);
			}
			return (NSPageControllerTransitionStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransitionStyleHandle);
		}
		[Export("setTransitionStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTransitionStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTransitionStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSPageControllerDelegate);

	public NSPageControllerGetFrame? GetFrame
	{
		get
		{
			return EnsureNSPageControllerDelegate().getFrame;
		}
		set
		{
			EnsureNSPageControllerDelegate().getFrame = value;
		}
	}

	public NSPageControllerGetIdentifier? GetIdentifier
	{
		get
		{
			return EnsureNSPageControllerDelegate().getIdentifier;
		}
		set
		{
			EnsureNSPageControllerDelegate().getIdentifier = value;
		}
	}

	public NSPageControllerGetViewController? GetViewController
	{
		get
		{
			return EnsureNSPageControllerDelegate().getViewController;
		}
		set
		{
			EnsureNSPageControllerDelegate().getViewController = value;
		}
	}

	public event EventHandler DidEndLiveTransition
	{
		add
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.didEndLiveTransition = (EventHandler)System.Delegate.Combine(nSPageControllerDelegate.didEndLiveTransition, value);
		}
		remove
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.didEndLiveTransition = (EventHandler)System.Delegate.Remove(nSPageControllerDelegate.didEndLiveTransition, value);
		}
	}

	public event EventHandler<NSPageControllerTransitionEventArgs> DidTransition
	{
		add
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.didTransition = (EventHandler<NSPageControllerTransitionEventArgs>)System.Delegate.Combine(nSPageControllerDelegate.didTransition, value);
		}
		remove
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.didTransition = (EventHandler<NSPageControllerTransitionEventArgs>)System.Delegate.Remove(nSPageControllerDelegate.didTransition, value);
		}
	}

	public event EventHandler<NSPageControllerPrepareViewControllerEventArgs> PrepareViewController
	{
		add
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.prepareViewController = (EventHandler<NSPageControllerPrepareViewControllerEventArgs>)System.Delegate.Combine(nSPageControllerDelegate.prepareViewController, value);
		}
		remove
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.prepareViewController = (EventHandler<NSPageControllerPrepareViewControllerEventArgs>)System.Delegate.Remove(nSPageControllerDelegate.prepareViewController, value);
		}
	}

	public event EventHandler WillStartLiveTransition
	{
		add
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.willStartLiveTransition = (EventHandler)System.Delegate.Combine(nSPageControllerDelegate.willStartLiveTransition, value);
		}
		remove
		{
			_NSPageControllerDelegate nSPageControllerDelegate = EnsureNSPageControllerDelegate();
			nSPageControllerDelegate.willStartLiveTransition = (EventHandler)System.Delegate.Remove(nSPageControllerDelegate.willStartLiveTransition, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPageController()
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
	public NSPageController(NSCoder coder)
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
	protected NSPageController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPageController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPageController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("completeTransition")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CompleteTransition()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCompleteTransitionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCompleteTransitionHandle);
		}
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

	[Export("navigateBack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NavigateBack(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNavigateBack_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNavigateBack_Handle, sender.Handle);
		}
	}

	[Export("navigateForward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NavigateForward(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNavigateForward_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNavigateForward_Handle, sender.Handle);
		}
	}

	[Export("navigateForwardToObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NavigateForwardTo(NSObject target)
	{
		NSApplication.EnsureUIThread();
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNavigateForwardToObject_Handle, target.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNavigateForwardToObject_Handle, target.Handle);
		}
	}

	[Export("takeSelectedIndexFrom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NavigateTo(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeSelectedIndexFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeSelectedIndexFrom_Handle, sender.Handle);
		}
	}

	internal virtual _NSPageControllerDelegate CreateInternalEventDelegateType()
	{
		return new _NSPageControllerDelegate();
	}

	internal _NSPageControllerDelegate EnsureNSPageControllerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSPageControllerDelegate nSPageControllerDelegate = Delegate as _NSPageControllerDelegate;
		if (nSPageControllerDelegate == null)
		{
			nSPageControllerDelegate = (_NSPageControllerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSPageControllerDelegate;
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
