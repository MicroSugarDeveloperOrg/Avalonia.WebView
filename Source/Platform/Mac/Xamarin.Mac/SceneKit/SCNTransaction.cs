using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNTransaction", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNTransaction : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDuration = "animationDuration";

	private static readonly IntPtr selAnimationDurationHandle = Selector.GetHandle("animationDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationTimingFunction = "animationTimingFunction";

	private static readonly IntPtr selAnimationTimingFunctionHandle = Selector.GetHandle("animationTimingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBegin = "begin";

	private static readonly IntPtr selBeginHandle = Selector.GetHandle("begin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommit = "commit";

	private static readonly IntPtr selCommitHandle = Selector.GetHandle("commit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableActions = "disableActions";

	private static readonly IntPtr selDisableActionsHandle = Selector.GetHandle("disableActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlush = "flush";

	private static readonly IntPtr selFlushHandle = Selector.GetHandle("flush");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLock = "lock";

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationDuration_ = "setAnimationDuration:";

	private static readonly IntPtr selSetAnimationDuration_Handle = Selector.GetHandle("setAnimationDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationTimingFunction_ = "setAnimationTimingFunction:";

	private static readonly IntPtr selSetAnimationTimingFunction_Handle = Selector.GetHandle("setAnimationTimingFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletionBlock_ = "setCompletionBlock:";

	private static readonly IntPtr selSetCompletionBlock_Handle = Selector.GetHandle("setCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisableActions_ = "setDisableActions:";

	private static readonly IntPtr selSetDisableActions_Handle = Selector.GetHandle("setDisableActions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlock = "unlock";

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNTransaction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double AnimationDuration
	{
		[Export("animationDuration")]
		get
		{
			return Messaging.Double_objc_msgSend(class_ptr, selAnimationDurationHandle);
		}
		[Export("setAnimationDuration:")]
		set
		{
			Messaging.void_objc_msgSend_Double(class_ptr, selSetAnimationDuration_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static CAMediaTimingFunction? AnimationTimingFunction
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("animationTimingFunction")]
		get
		{
			return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationTimingFunctionHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setAnimationTimingFunction:")]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetAnimationTimingFunction_Handle, value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DisableActions
	{
		[Export("disableActions")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selDisableActionsHandle);
		}
		[Export("setDisableActions:")]
		set
		{
			Messaging.void_objc_msgSend_bool(class_ptr, selSetDisableActions_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNTransaction()
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
	protected SCNTransaction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNTransaction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("begin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Begin()
	{
		Messaging.void_objc_msgSend(class_ptr, selBeginHandle);
	}

	[Export("commit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Commit()
	{
		Messaging.void_objc_msgSend(class_ptr, selCommitHandle);
	}

	[Export("flush")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Flush()
	{
		Messaging.void_objc_msgSend(class_ptr, selFlushHandle);
	}

	[Export("lock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Lock()
	{
		Messaging.void_objc_msgSend(class_ptr, selLockHandle);
	}

	[Export("setCompletionBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SetCompletionBlock([BlockProxy(typeof(Trampolines.NIDAction))] Action? completion)
	{
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCompletionBlock_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static void SetValueForKey(NSObject value, NSString key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetValue_ForKey_Handle, value.Handle, key.Handle);
	}

	[Export("unlock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Unlock()
	{
		Messaging.void_objc_msgSend(class_ptr, selUnlockHandle);
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, key.Handle));
	}
}
