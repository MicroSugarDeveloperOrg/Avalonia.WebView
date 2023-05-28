using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSNNTrainableNodeWrapper : BaseWrapper, IMPSNNTrainableNode, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNTrainingStyle TrainingStyle
	{
		[Export("trainingStyle", ArgumentSemantic.Assign)]
		get
		{
			return (MPSNNTrainingStyle)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("trainingStyle"));
		}
		[Export("setTrainingStyle:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setTrainingStyle:"), (ulong)value);
		}
	}

	[Preserve(Conditional = true)]
	public MPSNNTrainableNodeWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
