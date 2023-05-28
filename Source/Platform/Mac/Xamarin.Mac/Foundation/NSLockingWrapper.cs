using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSLockingWrapper : BaseWrapper, INSLocking, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSLockingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("lock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Lock()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("lock"));
	}

	[Export("unlock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Unlock()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("unlock"));
	}
}
