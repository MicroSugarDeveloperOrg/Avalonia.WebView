using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

internal sealed class MDLTransformOpWrapper : BaseWrapper, IMDLTransformOp, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsInverseOp
	{
		[Export("IsInverseOp")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("IsInverseOp"));
		}
	}

	[Preserve(Conditional = true)]
	public MDLTransformOpWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("float4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 GetNMatrix4(double atTime)
	{
		Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double(out var retval, base.Handle, Selector.GetHandle("float4x4AtTime:"), atTime);
		return retval;
	}

	[Export("double4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4d GetNMatrix4d(double atTime)
	{
		Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double(out var retval, base.Handle, Selector.GetHandle("double4x4AtTime:"), atTime);
		return retval;
	}
}
