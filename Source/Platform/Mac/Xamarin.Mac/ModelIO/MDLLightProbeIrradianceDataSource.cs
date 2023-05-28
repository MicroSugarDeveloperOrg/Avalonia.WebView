using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Protocol]
[Register("MDLLightProbeIrradianceDataSource", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public abstract class MDLLightProbeIrradianceDataSource : NSObject, IMDLLightProbeIrradianceDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract MDLAxisAlignedBoundingBox BoundingBox
	{
		[Export("boundingBox", ArgumentSemantic.Assign)]
		get;
		[Export("setBoundingBox:", ArgumentSemantic.Assign)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SphericalHarmonicsLevel
	{
		[Export("sphericalHarmonicsLevel")]
		get
		{
			throw new ModelNotImplementedException();
		}
		[Export("setSphericalHarmonicsLevel:")]
		set
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MDLLightProbeIrradianceDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLLightProbeIrradianceDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLLightProbeIrradianceDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("sphericalHarmonicsCoefficientsAtPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetSphericalHarmonicsCoefficients(Vector3 position)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
