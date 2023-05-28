using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKNoise", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKNoise : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddWithNoise_ = "addWithNoise:";

	private static readonly IntPtr selAddWithNoise_Handle = Selector.GetHandle("addWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyAbsoluteValue = "applyAbsoluteValue";

	private static readonly IntPtr selApplyAbsoluteValueHandle = Selector.GetHandle("applyAbsoluteValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyTurbulenceWithFrequency_Power_Roughness_Seed_ = "applyTurbulenceWithFrequency:power:roughness:seed:";

	private static readonly IntPtr selApplyTurbulenceWithFrequency_Power_Roughness_Seed_Handle = Selector.GetHandle("applyTurbulenceWithFrequency:power:roughness:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClampWithLowerBound_UpperBound_ = "clampWithLowerBound:upperBound:";

	private static readonly IntPtr selClampWithLowerBound_UpperBound_Handle = Selector.GetHandle("clampWithLowerBound:upperBound:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaceXWithNoise_YWithNoise_ZWithNoise_ = "displaceXWithNoise:yWithNoise:zWithNoise:";

	private static readonly IntPtr selDisplaceXWithNoise_YWithNoise_ZWithNoise_Handle = Selector.GetHandle("displaceXWithNoise:yWithNoise:zWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientColors = "gradientColors";

	private static readonly IntPtr selGradientColorsHandle = Selector.GetHandle("gradientColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNoiseSource_ = "initWithNoiseSource:";

	private static readonly IntPtr selInitWithNoiseSource_Handle = Selector.GetHandle("initWithNoiseSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNoiseSource_GradientColors_ = "initWithNoiseSource:gradientColors:";

	private static readonly IntPtr selInitWithNoiseSource_GradientColors_Handle = Selector.GetHandle("initWithNoiseSource:gradientColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvert = "invert";

	private static readonly IntPtr selInvertHandle = Selector.GetHandle("invert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumWithNoise_ = "maximumWithNoise:";

	private static readonly IntPtr selMaximumWithNoise_Handle = Selector.GetHandle("maximumWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumWithNoise_ = "minimumWithNoise:";

	private static readonly IntPtr selMinimumWithNoise_Handle = Selector.GetHandle("minimumWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveBy_ = "moveBy:";

	private static readonly IntPtr selMoveBy_Handle = Selector.GetHandle("moveBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiplyWithNoise_ = "multiplyWithNoise:";

	private static readonly IntPtr selMultiplyWithNoise_Handle = Selector.GetHandle("multiplyWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseWithComponentNoises_SelectionNoise_ = "noiseWithComponentNoises:selectionNoise:";

	private static readonly IntPtr selNoiseWithComponentNoises_SelectionNoise_Handle = Selector.GetHandle("noiseWithComponentNoises:selectionNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_ = "noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:";

	private static readonly IntPtr selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_Handle = Selector.GetHandle("noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseWithNoiseSource_ = "noiseWithNoiseSource:";

	private static readonly IntPtr selNoiseWithNoiseSource_Handle = Selector.GetHandle("noiseWithNoiseSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseWithNoiseSource_GradientColors_ = "noiseWithNoiseSource:gradientColors:";

	private static readonly IntPtr selNoiseWithNoiseSource_GradientColors_Handle = Selector.GetHandle("noiseWithNoiseSource:gradientColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRaiseToPower_ = "raiseToPower:";

	private static readonly IntPtr selRaiseToPower_Handle = Selector.GetHandle("raiseToPower:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRaiseToPowerWithNoise_ = "raiseToPowerWithNoise:";

	private static readonly IntPtr selRaiseToPowerWithNoise_Handle = Selector.GetHandle("raiseToPowerWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemapValuesToCurveWithControlPoints_ = "remapValuesToCurveWithControlPoints:";

	private static readonly IntPtr selRemapValuesToCurveWithControlPoints_Handle = Selector.GetHandle("remapValuesToCurveWithControlPoints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemapValuesToTerracesWithPeaks_TerracesInverted_ = "remapValuesToTerracesWithPeaks:terracesInverted:";

	private static readonly IntPtr selRemapValuesToTerracesWithPeaks_TerracesInverted_Handle = Selector.GetHandle("remapValuesToTerracesWithPeaks:terracesInverted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateBy_ = "rotateBy:";

	private static readonly IntPtr selRotateBy_Handle = Selector.GetHandle("rotateBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleBy_ = "scaleBy:";

	private static readonly IntPtr selScaleBy_Handle = Selector.GetHandle("scaleBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGradientColors_ = "setGradientColors:";

	private static readonly IntPtr selSetGradientColors_Handle = Selector.GetHandle("setGradientColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueAtPosition_ = "valueAtPosition:";

	private static readonly IntPtr selValueAtPosition_Handle = Selector.GetHandle("valueAtPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKNoise");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSNumber, NSColor> GradientColors
	{
		[Export("gradientColors", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSNumber, NSColor>>(Messaging.IntPtr_objc_msgSend(base.Handle, selGradientColorsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSNumber, NSColor>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientColorsHandle));
		}
		[Export("setGradientColors:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGradientColors_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGradientColors_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKNoise()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKNoise(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKNoise(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNoiseSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKNoise(GKNoiseSource noiseSource)
		: base(NSObjectFlag.Empty)
	{
		if (noiseSource == null)
		{
			throw new ArgumentNullException("noiseSource");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNoiseSource_Handle, noiseSource.Handle), "initWithNoiseSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNoiseSource_Handle, noiseSource.Handle), "initWithNoiseSource:");
		}
	}

	[Export("initWithNoiseSource:gradientColors:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKNoise(GKNoiseSource noiseSource, NSDictionary<NSNumber, NSColor> gradientColors)
		: base(NSObjectFlag.Empty)
	{
		if (noiseSource == null)
		{
			throw new ArgumentNullException("noiseSource");
		}
		if (gradientColors == null)
		{
			throw new ArgumentNullException("gradientColors");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNoiseSource_GradientColors_Handle, noiseSource.Handle, gradientColors.Handle), "initWithNoiseSource:gradientColors:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNoiseSource_GradientColors_Handle, noiseSource.Handle, gradientColors.Handle), "initWithNoiseSource:gradientColors:");
		}
	}

	[Export("addWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddWithNoise_Handle, noise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddWithNoise_Handle, noise.Handle);
		}
	}

	[Export("applyAbsoluteValue")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyAbsoluteValue()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selApplyAbsoluteValueHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selApplyAbsoluteValueHandle);
		}
	}

	[Export("applyTurbulenceWithFrequency:power:roughness:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyTurbulence(double frequency, double power, int roughness, int seed)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double_int_int(base.Handle, selApplyTurbulenceWithFrequency_Power_Roughness_Seed_Handle, frequency, power, roughness, seed);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double_int_int(base.SuperHandle, selApplyTurbulenceWithFrequency_Power_Roughness_Seed_Handle, frequency, power, roughness, seed);
		}
	}

	[Export("clampWithLowerBound:upperBound:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Clamp(double lowerBound, double upperBound)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double(base.Handle, selClampWithLowerBound_UpperBound_Handle, lowerBound, upperBound);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double(base.SuperHandle, selClampWithLowerBound_UpperBound_Handle, lowerBound, upperBound);
		}
	}

	[Export("displaceXWithNoise:yWithNoise:zWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Displace(GKNoise xDisplacementNoise, GKNoise yDisplacementNoise, GKNoise zDisplacementNoise)
	{
		if (xDisplacementNoise == null)
		{
			throw new ArgumentNullException("xDisplacementNoise");
		}
		if (yDisplacementNoise == null)
		{
			throw new ArgumentNullException("yDisplacementNoise");
		}
		if (zDisplacementNoise == null)
		{
			throw new ArgumentNullException("zDisplacementNoise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selDisplaceXWithNoise_YWithNoise_ZWithNoise_Handle, xDisplacementNoise.Handle, yDisplacementNoise.Handle, zDisplacementNoise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDisplaceXWithNoise_YWithNoise_ZWithNoise_Handle, xDisplacementNoise.Handle, yDisplacementNoise.Handle, zDisplacementNoise.Handle);
		}
	}

	[Obsolete("Use 'GKNoise.Displace' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplaceX(GKNoise xDisplacementNoise, GKNoise yDisplacementNoise, GKNoise zDisplacementNoise)
	{
		Displace(xDisplacementNoise, yDisplacementNoise, zDisplacementNoise);
	}

	[Export("noiseWithComponentNoises:selectionNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoise FromComponentNoises(GKNoise[] noises, GKNoise selectionNoise)
	{
		if (noises == null)
		{
			throw new ArgumentNullException("noises");
		}
		if (selectionNoise == null)
		{
			throw new ArgumentNullException("selectionNoise");
		}
		NSArray nSArray = NSArray.FromNSObjects(noises);
		GKNoise nSObject = Runtime.GetNSObject<GKNoise>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNoiseWithComponentNoises_SelectionNoise_Handle, nSArray.Handle, selectionNoise.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("noiseWithComponentNoises:selectionNoise:componentBoundaries:boundaryBlendDistances:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoise FromComponentNoises(GKNoise[] noises, GKNoise selectionNoise, NSNumber[] componentBoundaries, NSNumber[] blendDistances)
	{
		if (noises == null)
		{
			throw new ArgumentNullException("noises");
		}
		if (selectionNoise == null)
		{
			throw new ArgumentNullException("selectionNoise");
		}
		if (componentBoundaries == null)
		{
			throw new ArgumentNullException("componentBoundaries");
		}
		if (blendDistances == null)
		{
			throw new ArgumentNullException("blendDistances");
		}
		NSArray nSArray = NSArray.FromNSObjects(noises);
		NSArray nSArray2 = NSArray.FromNSObjects(componentBoundaries);
		NSArray nSArray3 = NSArray.FromNSObjects(blendDistances);
		GKNoise nSObject = Runtime.GetNSObject<GKNoise>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selNoiseWithComponentNoises_SelectionNoise_ComponentBoundaries_BoundaryBlendDistances_Handle, nSArray.Handle, selectionNoise.Handle, nSArray2.Handle, nSArray3.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		nSArray3.Dispose();
		return nSObject;
	}

	[Export("noiseWithNoiseSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoise FromNoiseSource(GKNoiseSource noiseSource)
	{
		if (noiseSource == null)
		{
			throw new ArgumentNullException("noiseSource");
		}
		return Runtime.GetNSObject<GKNoise>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNoiseWithNoiseSource_Handle, noiseSource.Handle));
	}

	[Export("noiseWithNoiseSource:gradientColors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoise FromNoiseSource(GKNoiseSource noiseSource, NSDictionary<NSNumber, NSColor> gradientColors)
	{
		if (noiseSource == null)
		{
			throw new ArgumentNullException("noiseSource");
		}
		if (gradientColors == null)
		{
			throw new ArgumentNullException("gradientColors");
		}
		return Runtime.GetNSObject<GKNoise>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNoiseWithNoiseSource_GradientColors_Handle, noiseSource.Handle, gradientColors.Handle));
	}

	[Export("maximumWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetMaximum(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMaximumWithNoise_Handle, noise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMaximumWithNoise_Handle, noise.Handle);
		}
	}

	[Export("minimumWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetMinimum(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMinimumWithNoise_Handle, noise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinimumWithNoise_Handle, noise.Handle);
		}
	}

	[Export("valueAtPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetValue(Vector2 position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__float_objc_msgSend_Vector2(base.Handle, selValueAtPosition_Handle, position);
		}
		return Messaging.xamarin_simd__float_objc_msgSendSuper_Vector2(base.SuperHandle, selValueAtPosition_Handle, position);
	}

	[Export("invert")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invert()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvertHandle);
		}
	}

	[Export("moveBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Move(Vector3d delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3d(base.Handle, selMoveBy_Handle, delta);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3d(base.SuperHandle, selMoveBy_Handle, delta);
		}
	}

	[Export("multiplyWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Multiply(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMultiplyWithNoise_Handle, noise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMultiplyWithNoise_Handle, noise.Handle);
		}
	}

	[Export("raiseToPower:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RaiseToPower(double power)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRaiseToPower_Handle, power);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRaiseToPower_Handle, power);
		}
	}

	[Export("raiseToPowerWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RaiseToPower(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRaiseToPowerWithNoise_Handle, noise.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRaiseToPowerWithNoise_Handle, noise.Handle);
		}
	}

	[Export("remapValuesToCurveWithControlPoints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemapValuesToCurve(NSDictionary<NSNumber, NSNumber> controlPoints)
	{
		if (controlPoints == null)
		{
			throw new ArgumentNullException("controlPoints");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemapValuesToCurveWithControlPoints_Handle, controlPoints.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemapValuesToCurveWithControlPoints_Handle, controlPoints.Handle);
		}
	}

	[Export("remapValuesToTerracesWithPeaks:terracesInverted:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemapValuesToTerraces(NSNumber[] peakInputValues, bool inverted)
	{
		if (peakInputValues == null)
		{
			throw new ArgumentNullException("peakInputValues");
		}
		NSArray nSArray = NSArray.FromNSObjects(peakInputValues);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRemapValuesToTerracesWithPeaks_TerracesInverted_Handle, nSArray.Handle, inverted);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRemapValuesToTerracesWithPeaks_TerracesInverted_Handle, nSArray.Handle, inverted);
		}
		nSArray.Dispose();
	}

	[Export("rotateBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Rotate(Vector3d radians)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3d(base.Handle, selRotateBy_Handle, radians);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3d(base.SuperHandle, selRotateBy_Handle, radians);
		}
	}

	[Export("scaleBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Scale(Vector3d factor)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3d(base.Handle, selScaleBy_Handle, factor);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3d(base.SuperHandle, selScaleBy_Handle, factor);
		}
	}
}
