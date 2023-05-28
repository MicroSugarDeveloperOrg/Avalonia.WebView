using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CATransaction", true)]
public class CATransaction : NSObject
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
	private const string selCompletionBlock = "completionBlock";

	private static readonly IntPtr selCompletionBlockHandle = Selector.GetHandle("completionBlock");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CATransaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationDurationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompletionBlockKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisableActionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimingFunctionKey;

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
	public static CAMediaTimingFunction? AnimationTimingFunction
	{
		[Export("animationTimingFunction")]
		get
		{
			return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationTimingFunctionHandle));
		}
		[Export("setAnimationTimingFunction:")]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetAnimationTimingFunction_Handle, value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static Action? CompletionBlock
	{
		[Export("completionBlock")]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = Messaging.IntPtr_objc_msgSend(class_ptr, selCompletionBlockHandle);
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setCompletionBlock:")]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCompletionBlock_Handle, (IntPtr)ptr);
			ptr->CleanupBlock();
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

	[Field("kCATransactionAnimationDuration", "CoreAnimation")]
	public static NSString AnimationDurationKey
	{
		get
		{
			if (_AnimationDurationKey == null)
			{
				_AnimationDurationKey = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransactionAnimationDuration");
			}
			return _AnimationDurationKey;
		}
	}

	[Field("kCATransactionCompletionBlock", "CoreAnimation")]
	public static NSString CompletionBlockKey
	{
		get
		{
			if (_CompletionBlockKey == null)
			{
				_CompletionBlockKey = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransactionCompletionBlock");
			}
			return _CompletionBlockKey;
		}
	}

	[Field("kCATransactionDisableActions", "CoreAnimation")]
	public static NSString DisableActionsKey
	{
		get
		{
			if (_DisableActionsKey == null)
			{
				_DisableActionsKey = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransactionDisableActions");
			}
			return _DisableActionsKey;
		}
	}

	[Field("kCATransactionAnimationTimingFunction", "CoreAnimation")]
	public static NSString TimingFunctionKey
	{
		get
		{
			if (_TimingFunctionKey == null)
			{
				_TimingFunctionKey = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransactionAnimationTimingFunction");
			}
			return _TimingFunctionKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATransaction()
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
	protected CATransaction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CATransaction(IntPtr handle)
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

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static void SetValueForKey(NSObject? anObject, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetValue_ForKey_Handle, anObject?.Handle ?? IntPtr.Zero, key.Handle);
	}

	[Export("unlock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Unlock()
	{
		Messaging.void_objc_msgSend(class_ptr, selUnlockHandle);
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueForKey_Handle, key.Handle));
	}
}
