using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSHandleWrapper : BaseWrapper, IMPSHandle, INativeObject, IDisposable, INSCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
	}

	[Preserve(Conditional = true)]
	public MPSHandleWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("encodeWithCoder:"), encoder.Handle);
	}
}
