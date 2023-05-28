using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNBoundingVolumeWrapper : BaseWrapper, ISCNBoundingVolume, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNBoundingVolumeWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("getBoundingBoxMin:max:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool GetBoundingBox(ref SCNVector3 min, ref SCNVector3 max)
	{
		return Messaging.bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3(base.Handle, Selector.GetHandle("getBoundingBoxMin:max:"), ref min, ref max);
	}

	[Export("setBoundingBoxMin:max:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetBoundingBox(ref SCNVector3 min, ref SCNVector3 max)
	{
		Messaging.void_objc_msgSend_ref_SCNVector3_ref_SCNVector3(base.Handle, Selector.GetHandle("setBoundingBoxMin:max:"), ref min, ref max);
	}

	[Export("getBoundingSphereCenter:radius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool GetBoundingSphere(ref SCNVector3 center, ref nfloat radius)
	{
		return Messaging.bool_objc_msgSend_ref_SCNVector3_ref_nfloat(base.Handle, Selector.GetHandle("getBoundingSphereCenter:radius:"), ref center, ref radius);
	}
}
