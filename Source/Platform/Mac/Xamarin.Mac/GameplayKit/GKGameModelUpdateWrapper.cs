using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKGameModelUpdateWrapper : BaseWrapper, IGKGameModelUpdate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint Value
	{
		[Export("value", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("value"));
		}
		[Export("setValue:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setValue:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public GKGameModelUpdateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
