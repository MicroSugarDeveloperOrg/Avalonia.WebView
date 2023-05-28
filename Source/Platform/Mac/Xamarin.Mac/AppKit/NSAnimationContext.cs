using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAnimationContext", true)]
public class NSAnimationContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsImplicitAnimation = "allowsImplicitAnimation";

	private static readonly IntPtr selAllowsImplicitAnimationHandle = Selector.GetHandle("allowsImplicitAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginGrouping = "beginGrouping";

	private static readonly IntPtr selBeginGroupingHandle = Selector.GetHandle("beginGrouping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionHandler = "completionHandler";

	private static readonly IntPtr selCompletionHandlerHandle = Selector.GetHandle("completionHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentContext = "currentContext";

	private static readonly IntPtr selCurrentContextHandle = Selector.GetHandle("currentContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndGrouping = "endGrouping";

	private static readonly IntPtr selEndGroupingHandle = Selector.GetHandle("endGrouping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAnimationGroup_ = "runAnimationGroup:";

	private static readonly IntPtr selRunAnimationGroup_Handle = Selector.GetHandle("runAnimationGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAnimationGroup_CompletionHandler_ = "runAnimationGroup:completionHandler:";

	private static readonly IntPtr selRunAnimationGroup_CompletionHandler_Handle = Selector.GetHandle("runAnimationGroup:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsImplicitAnimation_ = "setAllowsImplicitAnimation:";

	private static readonly IntPtr selSetAllowsImplicitAnimation_Handle = Selector.GetHandle("setAllowsImplicitAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletionHandler_ = "setCompletionHandler:";

	private static readonly IntPtr selSetCompletionHandler_Handle = Selector.GetHandle("setCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingFunction_ = "setTimingFunction:";

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingFunction = "timingFunction";

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAnimationContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsImplicitAnimation
	{
		[Export("allowsImplicitAnimation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsImplicitAnimationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsImplicitAnimationHandle);
		}
		[Export("setAllowsImplicitAnimation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsImplicitAnimation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsImplicitAnimation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action CompletionHandler
	{
		[Export("completionHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletionHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCompletionHandlerHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Export("setCompletionHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAnimationContext CurrentContext
	{
		[Export("currentContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSAnimationContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAMediaTimingFunction TimingFunction
	{
		[Export("timingFunction", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle));
			}
			return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle));
		}
		[Export("setTimingFunction:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimationContext()
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
	protected NSAnimationContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAnimationContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginGrouping")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BeginGrouping()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selBeginGroupingHandle);
	}

	[Export("endGrouping")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EndGrouping()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selEndGroupingHandle);
	}

	[Export("runAnimationGroup:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunAnimation([BlockProxy(typeof(Trampolines.NIDActionArity1V9))] Action<NSAnimationContext> changes, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (changes == null)
		{
			throw new ArgumentNullException("changes");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V9.Handler, changes);
		BlockLiteral* ptr2;
		if (completionHandler == null)
		{
			ptr2 = null;
		}
		else
		{
			BlockLiteral blockLiteral2 = default(BlockLiteral);
			ptr2 = &blockLiteral2;
			blockLiteral2.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRunAnimationGroup_CompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		ptr->CleanupBlock();
		if (ptr2 != null)
		{
			ptr2->CleanupBlock();
		}
	}

	[Export("runAnimationGroup:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RunAnimation([BlockProxy(typeof(Trampolines.NIDActionArity1V9))] Action<NSAnimationContext> changes)
	{
		NSApplication.EnsureUIThread();
		if (changes == null)
		{
			throw new ArgumentNullException("changes");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V9.Handler, changes);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRunAnimationGroup_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
