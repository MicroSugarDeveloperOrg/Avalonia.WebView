using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNBoundingVolume", WrapperType = typeof(SCNBoundingVolumeWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBoundingBox", Selector = "getBoundingBoxMin:max:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SCNVector3),
	typeof(SCNVector3)
}, ParameterByRef = new bool[] { true, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBoundingBox", Selector = "setBoundingBoxMin:max:", ParameterType = new Type[]
{
	typeof(SCNVector3),
	typeof(SCNVector3)
}, ParameterByRef = new bool[] { true, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBoundingSphere", Selector = "getBoundingSphereCenter:radius:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SCNVector3),
	typeof(nfloat)
}, ParameterByRef = new bool[] { true, true })]
public interface ISCNBoundingVolume : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("getBoundingBoxMin:max:")]
	[Preserve(Conditional = true)]
	bool GetBoundingBox(ref SCNVector3 min, ref SCNVector3 max);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBoundingBoxMin:max:")]
	[Preserve(Conditional = true)]
	void SetBoundingBox(ref SCNVector3 min, ref SCNVector3 max);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("getBoundingSphereCenter:radius:")]
	[Preserve(Conditional = true)]
	bool GetBoundingSphere(ref SCNVector3 center, ref nfloat radius);
}
