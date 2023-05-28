using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLLightProbeIrradianceDataSourceWrapper : BaseWrapper, IMDLLightProbeIrradianceDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAxisAlignedBoundingBox BoundingBox
	{
		[Export("boundingBox", ArgumentSemantic.Assign)]
		get
		{
			Messaging.MDLAxisAlignedBoundingBox_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("boundingBox"));
			return retval;
		}
		[Export("setBoundingBox:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_MDLAxisAlignedBoundingBox(base.Handle, Selector.GetHandle("setBoundingBox:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public MDLLightProbeIrradianceDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
