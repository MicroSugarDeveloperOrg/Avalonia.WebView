using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKRidgedNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKRidgedNoiseSource : GKCoherentNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrequency_OctaveCount_Lacunarity_Seed_ = "initWithFrequency:octaveCount:lacunarity:seed:";

	private static readonly IntPtr selInitWithFrequency_OctaveCount_Lacunarity_Seed_Handle = Selector.GetHandle("initWithFrequency:octaveCount:lacunarity:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRidgedNoiseSourceWithFrequency_OctaveCount_Lacunarity_Seed_ = "ridgedNoiseSourceWithFrequency:octaveCount:lacunarity:seed:";

	private static readonly IntPtr selRidgedNoiseSourceWithFrequency_OctaveCount_Lacunarity_Seed_Handle = Selector.GetHandle("ridgedNoiseSourceWithFrequency:octaveCount:lacunarity:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKRidgedNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKRidgedNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKRidgedNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrequency:octaveCount:lacunarity:seed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKRidgedNoiseSource(double frequency, nint octaveCount, double lacunarity, int seed)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_nint_Double_int(base.Handle, selInitWithFrequency_OctaveCount_Lacunarity_Seed_Handle, frequency, octaveCount, lacunarity, seed), "initWithFrequency:octaveCount:lacunarity:seed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_nint_Double_int(base.SuperHandle, selInitWithFrequency_OctaveCount_Lacunarity_Seed_Handle, frequency, octaveCount, lacunarity, seed), "initWithFrequency:octaveCount:lacunarity:seed:");
		}
	}

	[Export("ridgedNoiseSourceWithFrequency:octaveCount:lacunarity:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRidgedNoiseSource Create(double frequency, nint octaveCount, double lacunarity, int seed)
	{
		return Runtime.GetNSObject<GKRidgedNoiseSource>(Messaging.IntPtr_objc_msgSend_Double_nint_Double_int(class_ptr, selRidgedNoiseSourceWithFrequency_OctaveCount_Lacunarity_Seed_Handle, frequency, octaveCount, lacunarity, seed));
	}
}
