using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

internal sealed class VNRequestRevisionProvidingWrapper : BaseWrapper, IVNRequestRevisionProviding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNRequestRevision RequestRevision
	{
		[Export("requestRevision")]
		get
		{
			return (VNRequestRevision)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("requestRevision"));
		}
	}

	[Preserve(Conditional = true)]
	public VNRequestRevisionProvidingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
