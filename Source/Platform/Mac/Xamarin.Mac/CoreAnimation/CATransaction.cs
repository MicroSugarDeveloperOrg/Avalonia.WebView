using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CATransaction", true)]
public class CATransaction : NSObject
{
	private static readonly IntPtr selAnimationDurationHandle = Selector.GetHandle("animationDuration");

	private static readonly IntPtr selSetAnimationDuration_Handle = Selector.GetHandle("setAnimationDuration:");

	private static readonly IntPtr selAnimationTimingFunctionHandle = Selector.GetHandle("animationTimingFunction");

	private static readonly IntPtr selSetAnimationTimingFunction_Handle = Selector.GetHandle("setAnimationTimingFunction:");

	private static readonly IntPtr selDisableActionsHandle = Selector.GetHandle("disableActions");

	private static readonly IntPtr selSetDisableActions_Handle = Selector.GetHandle("setDisableActions:");

	private static readonly IntPtr selCompletionBlockHandle = Selector.GetHandle("completionBlock");

	private static readonly IntPtr selSetCompletionBlock_Handle = Selector.GetHandle("setCompletionBlock:");

	private static readonly IntPtr selBeginHandle = Selector.GetHandle("begin");

	private static readonly IntPtr selCommitHandle = Selector.GetHandle("commit");

	private static readonly IntPtr selFlushHandle = Selector.GetHandle("flush");

	private static readonly IntPtr selLockHandle = Selector.GetHandle("lock");

	private static readonly IntPtr selUnlockHandle = Selector.GetHandle("unlock");

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CATransaction");

	private static object __mt_AnimationTimingFunction_var_static;

	private static NSString _AnimationDurationKey;

	private static NSString _DisableActionsKey;

	private static NSString _TimingFunctionKey;

	private static NSString _CompletionBlockKey;

	public override IntPtr ClassHandle => class_ptr;

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

	public static CAMediaTimingFunction AnimationTimingFunction
	{
		[Export("animationTimingFunction")]
		get
		{
			return (CAMediaTimingFunction)(__mt_AnimationTimingFunction_var_static = (CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationTimingFunctionHandle)));
		}
		[Export("setAnimationTimingFunction:")]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetAnimationTimingFunction_Handle, value?.Handle ?? IntPtr.Zero);
		}
	}

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

	[Since(4, 0)]
	public unsafe static NSAction CompletionBlock
	{
		[Export("completionBlock")]
		get
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)Messaging.IntPtr_objc_msgSend(class_ptr, selCompletionBlockHandle);
			if (ptr == null)
			{
				return null;
			}
			return (NSAction)((ptr->global_handle != IntPtr.Zero) ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target);
		}
		[Export("setCompletionBlock:")]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, value);
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetCompletionBlock_Handle, (IntPtr)ptr);
			ptr->CleanupBlock();
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATransaction()
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
	public CATransaction(NSCoder coder)
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
	public CATransaction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CATransaction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("begin")]
	public static void Begin()
	{
		Messaging.void_objc_msgSend(class_ptr, selBeginHandle);
	}

	[Export("commit")]
	public static void Commit()
	{
		Messaging.void_objc_msgSend(class_ptr, selCommitHandle);
	}

	[Export("flush")]
	public static void Flush()
	{
		Messaging.void_objc_msgSend(class_ptr, selFlushHandle);
	}

	[Export("lock")]
	public static void Lock()
	{
		Messaging.void_objc_msgSend(class_ptr, selLockHandle);
	}

	[Export("unlock")]
	public static void Unlock()
	{
		Messaging.void_objc_msgSend(class_ptr, selUnlockHandle);
	}

	[Export("valueForKey:")]
	public new static NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueForKey_Handle, key.Handle));
	}

	[Export("setValue:forKey:")]
	public new static void SetValueForKey(NSObject anObject, NSString key)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetValueForKey_Handle, anObject.Handle, key.Handle);
	}
}
