using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

internal sealed class GKRandomWrapper : BaseWrapper, IGKRandom, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GKRandomWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("nextInt")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint GetNextInt()
	{
		return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("nextInt"));
	}

	[Export("nextIntWithUpperBound:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetNextInt(nuint upperBound)
	{
		return Messaging.nuint_objc_msgSend_nuint(base.Handle, Selector.GetHandle("nextIntWithUpperBound:"), upperBound);
	}

	[Export("nextUniform")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float GetNextUniform()
	{
		return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("nextUniform"));
	}

	[Export("nextBool")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool GetNextBool()
	{
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("nextBool"));
	}
}
