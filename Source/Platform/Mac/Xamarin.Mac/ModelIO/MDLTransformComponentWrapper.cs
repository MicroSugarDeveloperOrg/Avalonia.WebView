using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

internal sealed class MDLTransformComponentWrapper : BaseWrapper, IMDLTransformComponent, INativeObject, IDisposable, IMDLComponent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Matrix4 Matrix
	{
		[Export("matrix", ArgumentSemantic.Assign)]
		get
		{
			Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("matrix"));
			return retval;
		}
		[Export("setMatrix:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.xamarin_simd__void_objc_msgSend_Matrix4(base.Handle, Selector.GetHandle("setMatrix:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double MinimumTime
	{
		[Export("minimumTime")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("minimumTime"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double MaximumTime
	{
		[Export("maximumTime")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("maximumTime"));
		}
	}

	[Preserve(Conditional = true)]
	public MDLTransformComponentWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
