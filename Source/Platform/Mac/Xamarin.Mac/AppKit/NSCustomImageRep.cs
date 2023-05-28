using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCustomImageRep", true)]
public class NSCustomImageRep : NSImageRep
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSelector = "drawSelector";

	private static readonly IntPtr selDrawSelectorHandle = Selector.GetHandle("drawSelector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawingHandler = "drawingHandler";

	private static readonly IntPtr selDrawingHandlerHandle = Selector.GetHandle("drawingHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDrawSelector_Delegate_ = "initWithDrawSelector:delegate:";

	private static readonly IntPtr selInitWithDrawSelector_Delegate_Handle = Selector.GetHandle("initWithDrawSelector:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_Flipped_DrawingHandler_ = "initWithSize:flipped:drawingHandler:";

	private static readonly IntPtr selInitWithSize_Flipped_DrawingHandler_Handle = Selector.GetHandle("initWithSize:flipped:drawingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCustomImageRep");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_Delegate_var = nSObject;
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector DrawSelector
	{
		[Export("drawSelector")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDrawSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDrawSelectorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCustomImageRepDrawingHandler DrawingHandler
	{
		[Export("drawingHandler")]
		[return: DelegateProxy(typeof(Trampolines.SDNSCustomImageRepDrawingHandler))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDrawingHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDrawingHandlerHandle));
			return Trampolines.NIDNSCustomImageRepDrawingHandler.Create(block);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCustomImageRep(NSCoder coder)
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
	protected NSCustomImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCustomImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDrawSelector:delegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCustomImageRep(Selector drawSelectorMethod, NSObject delegateObject)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (drawSelectorMethod == null)
		{
			throw new ArgumentNullException("drawSelectorMethod");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDrawSelector_Delegate_Handle, drawSelectorMethod.Handle, delegateObject.Handle), "initWithDrawSelector:delegate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDrawSelector_Delegate_Handle, drawSelectorMethod.Handle, delegateObject.Handle), "initWithDrawSelector:delegate:");
		}
	}

	[Export("initWithSize:flipped:drawingHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSCustomImageRep(CGSize size, bool flipped, [BlockProxy(typeof(Trampolines.NIDNSCustomImageRepDrawingHandler))] NSCustomImageRepDrawingHandler drawingHandler)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (drawingHandler == null)
		{
			throw new ArgumentNullException("drawingHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCustomImageRepDrawingHandler.Handler, drawingHandler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize_bool_IntPtr(base.Handle, selInitWithSize_Flipped_DrawingHandler_Handle, size, flipped, (IntPtr)ptr), "initWithSize:flipped:drawingHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize_bool_IntPtr(base.SuperHandle, selInitWithSize_Flipped_DrawingHandler_Handle, size, flipped, (IntPtr)ptr), "initWithSize:flipped:drawingHandler:");
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
