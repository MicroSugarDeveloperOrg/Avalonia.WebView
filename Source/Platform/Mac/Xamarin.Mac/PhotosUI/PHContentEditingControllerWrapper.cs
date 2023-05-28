using System;
using AppKit;
using Foundation;
using ObjCRuntime;
using Photos;

namespace PhotosUI;

internal sealed class PHContentEditingControllerWrapper : BaseWrapper, IPHContentEditingController, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ShouldShowCancelConfirmation
	{
		[Export("shouldShowCancelConfirmation")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("shouldShowCancelConfirmation"));
		}
	}

	[Preserve(Conditional = true)]
	public PHContentEditingControllerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("canHandleAdjustmentData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CanHandleAdjustmentData(PHAdjustmentData adjustmentData)
	{
		NSApplication.EnsureUIThread();
		if (adjustmentData == null)
		{
			throw new ArgumentNullException("adjustmentData");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("canHandleAdjustmentData:"), adjustmentData.Handle);
	}

	[Export("startContentEditingWithInput:placeholderImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StartContentEditing(PHContentEditingInput contentEditingInput, NSImage placeholderImage)
	{
		NSApplication.EnsureUIThread();
		if (contentEditingInput == null)
		{
			throw new ArgumentNullException("contentEditingInput");
		}
		if (placeholderImage == null)
		{
			throw new ArgumentNullException("placeholderImage");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("startContentEditingWithInput:placeholderImage:"), contentEditingInput.Handle, placeholderImage.Handle);
	}

	[Export("finishContentEditingWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void FinishContentEditing([BlockProxy(typeof(Trampolines.NIDActionArity1V72))] Action<PHContentEditingOutput> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V72.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("finishContentEditingWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("cancelContentEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CancelContentEditing()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("cancelContentEditing"));
	}
}
