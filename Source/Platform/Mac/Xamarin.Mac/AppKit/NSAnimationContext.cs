using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAnimationContext", true)]
public class NSAnimationContext : NSObject
{
	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	private static readonly IntPtr selCompletionHandlerHandle = Selector.GetHandle("completionHandler");

	private static readonly IntPtr selSetCompletionHandler_Handle = Selector.GetHandle("setCompletionHandler:");

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	private static readonly IntPtr selAllowsImplicitAnimationHandle = Selector.GetHandle("allowsImplicitAnimation");

	private static readonly IntPtr selSetAllowsImplicitAnimation_Handle = Selector.GetHandle("setAllowsImplicitAnimation:");

	private static readonly IntPtr selBeginGroupingHandle = Selector.GetHandle("beginGrouping");

	private static readonly IntPtr selEndGroupingHandle = Selector.GetHandle("endGrouping");

	private static readonly IntPtr selRunAnimationGroupCompletionHandler_Handle = Selector.GetHandle("runAnimationGroup:completionHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAnimationContext");

	private static object __mt_CurrentContext_var_static;

	private object __mt_TimingFunction_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSAnimationContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAnimationContext)(__mt_CurrentContext_var_static = (NSAnimationContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle)));
		}
	}

	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	public unsafe virtual NSAction CompletionHandler
	{
		[Export("completionHandler")]
		get
		{
			NSApplication.EnsureUIThread();
			BlockLiteral* ptr = (BlockLiteral*)((!IsDirectBinding) ? ((void*)Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletionHandlerHandle)) : ((void*)Messaging.IntPtr_objc_msgSend(base.Handle, selCompletionHandlerHandle)));
			if (ptr == null)
			{
				return null;
			}
			return (NSAction)((ptr->global_handle != IntPtr.Zero) ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target);
		}
		[Export("setCompletionHandler:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCompletionHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCompletionHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	public virtual CAMediaTimingFunction TimingFunction
	{
		[Export("timingFunction")]
		get
		{
			NSApplication.EnsureUIThread();
			return (CAMediaTimingFunction)(__mt_TimingFunction_var = ((!IsDirectBinding) ? ((CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle))) : ((CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle)))));
		}
		[Export("setTimingFunction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, value.Handle);
			}
			__mt_TimingFunction_var = value;
		}
	}

	[MountainLion]
	public virtual bool AllowsImplicitAnimation
	{
		[MountainLion]
		[Export("allowsImplicitAnimation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsImplicitAnimationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsImplicitAnimationHandle);
		}
		[MountainLion]
		[Export("setAllowsImplicitAnimation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsImplicitAnimation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsImplicitAnimation_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimationContext()
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
	public NSAnimationContext(NSCoder coder)
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
	public NSAnimationContext(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAnimationContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginGrouping")]
	public static void BeginGrouping()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selBeginGroupingHandle);
	}

	[Export("endGrouping")]
	public static void EndGrouping()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selEndGroupingHandle);
	}

	[Export("runAnimationGroup:completionHandler:")]
	public unsafe static void RunAnimation(Action<NSAnimationContext> changes, NSAction completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (changes == null)
		{
			throw new ArgumentNullException("changes");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDActionArity1V0.Handler, changes);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlock(Trampolines.SDNSAction.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRunAnimationGroupCompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		ptr->CleanupBlock();
		ptr2->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TimingFunction_var = null;
		}
	}
}
