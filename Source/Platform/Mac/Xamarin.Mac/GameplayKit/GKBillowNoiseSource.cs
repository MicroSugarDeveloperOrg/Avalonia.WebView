using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKBillowNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKBillowNoiseSource : GKCoherentNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBillowNoiseSourceWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_ = "billowNoiseSourceWithFrequency:octaveCount:persistence:lacunarity:seed:";

	private static readonly IntPtr selBillowNoiseSourceWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_Handle = Selector.GetHandle("billowNoiseSourceWithFrequency:octaveCount:persistence:lacunarity:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_ = "initWithFrequency:octaveCount:persistence:lacunarity:seed:";

	private static readonly IntPtr selInitWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_Handle = Selector.GetHandle("initWithFrequency:octaveCount:persistence:lacunarity:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistence = "persistence";

	private static readonly IntPtr selPersistenceHandle = Selector.GetHandle("persistence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPersistence_ = "setPersistence:";

	private static readonly IntPtr selSetPersistence_Handle = Selector.GetHandle("setPersistence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKBillowNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Persistence
	{
		[Export("persistence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPersistenceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPersistenceHandle);
		}
		[Export("setPersistence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPersistence_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPersistence_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKBillowNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKBillowNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrequency:octaveCount:persistence:lacunarity:seed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKBillowNoiseSource(double frequency, nint octaveCount, double persistence, double lacunarity, int seed)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_nint_Double_Double_int(base.Handle, selInitWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_Handle, frequency, octaveCount, persistence, lacunarity, seed), "initWithFrequency:octaveCount:persistence:lacunarity:seed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_nint_Double_Double_int(base.SuperHandle, selInitWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_Handle, frequency, octaveCount, persistence, lacunarity, seed), "initWithFrequency:octaveCount:persistence:lacunarity:seed:");
		}
	}

	[Export("billowNoiseSourceWithFrequency:octaveCount:persistence:lacunarity:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKBillowNoiseSource Create(double frequency, nint octaveCount, double persistence, double lacunarity, int seed)
	{
		return Runtime.GetNSObject<GKBillowNoiseSource>(Messaging.IntPtr_objc_msgSend_Double_nint_Double_Double_int(class_ptr, selBillowNoiseSourceWithFrequency_OctaveCount_Persistence_Lacunarity_Seed_Handle, frequency, octaveCount, persistence, lacunarity, seed));
	}
}
