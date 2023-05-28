using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSDiscardableContentWrapper : BaseWrapper, INSDiscardableContent, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsContentDiscarded
	{
		[Export("isContentDiscarded")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isContentDiscarded"));
		}
	}

	[Preserve(Conditional = true)]
	public NSDiscardableContentWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginContentAccess")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool BeginContentAccess()
	{
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("beginContentAccess"));
	}

	[Export("endContentAccess")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EndContentAccess()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("endContentAccess"));
	}

	[Export("discardContentIfPossible")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DiscardContentIfPossible()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("discardContentIfPossible"));
	}
}
