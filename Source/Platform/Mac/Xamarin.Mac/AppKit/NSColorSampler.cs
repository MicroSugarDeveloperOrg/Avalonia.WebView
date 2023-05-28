using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorSampler", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSColorSampler : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowSamplerWithSelectionHandler_ = "showSamplerWithSelectionHandler:";

	private static readonly IntPtr selShowSamplerWithSelectionHandler_Handle = Selector.GetHandle("showSamplerWithSelectionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColorSampler");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorSampler()
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
	protected NSColorSampler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColorSampler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("showSamplerWithSelectionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ShowSampler([BlockProxy(typeof(Trampolines.NIDActionArity1V10))] Action<NSColor> selectionHandler)
	{
		NSApplication.EnsureUIThread();
		if (selectionHandler == null)
		{
			throw new ArgumentNullException("selectionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V10.Handler, selectionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowSamplerWithSelectionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowSamplerWithSelectionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
