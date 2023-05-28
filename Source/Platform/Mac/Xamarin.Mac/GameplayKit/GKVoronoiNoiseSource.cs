using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKVoronoiNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKVoronoiNoiseSource : GKNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplacement = "displacement";

	private static readonly IntPtr selDisplacementHandle = Selector.GetHandle("displacement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrequency = "frequency";

	private static readonly IntPtr selFrequencyHandle = Selector.GetHandle("frequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrequency_Displacement_DistanceEnabled_Seed_ = "initWithFrequency:displacement:distanceEnabled:seed:";

	private static readonly IntPtr selInitWithFrequency_Displacement_DistanceEnabled_Seed_Handle = Selector.GetHandle("initWithFrequency:displacement:distanceEnabled:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDistanceEnabled = "isDistanceEnabled";

	private static readonly IntPtr selIsDistanceEnabledHandle = Selector.GetHandle("isDistanceEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplacement_ = "setDisplacement:";

	private static readonly IntPtr selSetDisplacement_Handle = Selector.GetHandle("setDisplacement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDistanceEnabled_ = "setDistanceEnabled:";

	private static readonly IntPtr selSetDistanceEnabled_Handle = Selector.GetHandle("setDistanceEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrequency_ = "setFrequency:";

	private static readonly IntPtr selSetFrequency_Handle = Selector.GetHandle("setFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSeed_ = "setSeed:";

	private static readonly IntPtr selSetSeed_Handle = Selector.GetHandle("setSeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoronoiNoiseWithFrequency_Displacement_DistanceEnabled_Seed_ = "voronoiNoiseWithFrequency:displacement:distanceEnabled:seed:";

	private static readonly IntPtr selVoronoiNoiseWithFrequency_Displacement_DistanceEnabled_Seed_Handle = Selector.GetHandle("voronoiNoiseWithFrequency:displacement:distanceEnabled:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKVoronoiNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Displacement
	{
		[Export("displacement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDisplacementHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDisplacementHandle);
		}
		[Export("setDisplacement:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDisplacement_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDisplacement_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DistanceEnabled
	{
		[Export("isDistanceEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDistanceEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDistanceEnabledHandle);
		}
		[Export("setDistanceEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDistanceEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDistanceEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Frequency
	{
		[Export("frequency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrequencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrequencyHandle);
		}
		[Export("setFrequency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrequency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrequency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
		[Export("setSeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKVoronoiNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKVoronoiNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrequency:displacement:distanceEnabled:seed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKVoronoiNoiseSource(double frequency, double displacement, bool distanceEnabled, int seed)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_Double_bool_int(base.Handle, selInitWithFrequency_Displacement_DistanceEnabled_Seed_Handle, frequency, displacement, distanceEnabled, seed), "initWithFrequency:displacement:distanceEnabled:seed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_Double_bool_int(base.SuperHandle, selInitWithFrequency_Displacement_DistanceEnabled_Seed_Handle, frequency, displacement, distanceEnabled, seed), "initWithFrequency:displacement:distanceEnabled:seed:");
		}
	}

	[Export("voronoiNoiseWithFrequency:displacement:distanceEnabled:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKVoronoiNoiseSource Create(double frequency, double displacement, bool distanceEnabled, int seed)
	{
		return Runtime.GetNSObject<GKVoronoiNoiseSource>(Messaging.IntPtr_objc_msgSend_Double_Double_bool_int(class_ptr, selVoronoiNoiseWithFrequency_Displacement_DistanceEnabled_Seed_Handle, frequency, displacement, distanceEnabled, seed));
	}
}
