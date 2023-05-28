using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using SceneKit;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLCamera", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLCamera : MDLObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApertureBladeCount = "apertureBladeCount";

	private static readonly IntPtr selApertureBladeCountHandle = Selector.GetHandle("apertureBladeCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBarrelDistortion = "barrelDistortion";

	private static readonly IntPtr selBarrelDistortionHandle = Selector.GetHandle("barrelDistortion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBokehKernelWithSize_ = "bokehKernelWithSize:";

	private static readonly IntPtr selBokehKernelWithSize_Handle = Selector.GetHandle("bokehKernelWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraWithSCNCamera_ = "cameraWithSCNCamera:";

	private static readonly IntPtr selCameraWithSCNCamera_Handle = Selector.GetHandle("cameraWithSCNCamera:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChromaticAberration = "chromaticAberration";

	private static readonly IntPtr selChromaticAberrationHandle = Selector.GetHandle("chromaticAberration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposure = "exposure";

	private static readonly IntPtr selExposureHandle = Selector.GetHandle("exposure");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExposureCompression = "exposureCompression";

	private static readonly IntPtr selExposureCompressionHandle = Selector.GetHandle("exposureCompression");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFStop = "fStop";

	private static readonly IntPtr selFStopHandle = Selector.GetHandle("fStop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFarVisibilityDistance = "farVisibilityDistance";

	private static readonly IntPtr selFarVisibilityDistanceHandle = Selector.GetHandle("farVisibilityDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldOfView = "fieldOfView";

	private static readonly IntPtr selFieldOfViewHandle = Selector.GetHandle("fieldOfView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFisheyeDistortion = "fisheyeDistortion";

	private static readonly IntPtr selFisheyeDistortionHandle = Selector.GetHandle("fisheyeDistortion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlash = "flash";

	private static readonly IntPtr selFlashHandle = Selector.GetHandle("flash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocalLength = "focalLength";

	private static readonly IntPtr selFocalLengthHandle = Selector.GetHandle("focalLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocusDistance = "focusDistance";

	private static readonly IntPtr selFocusDistanceHandle = Selector.GetHandle("focusDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameBoundingBox_SetNearAndFar_ = "frameBoundingBox:setNearAndFar:";

	private static readonly IntPtr selFrameBoundingBox_SetNearAndFar_Handle = Selector.GetHandle("frameBoundingBox:setNearAndFar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookAt_ = "lookAt:";

	private static readonly IntPtr selLookAt_Handle = Selector.GetHandle("lookAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookAt_From_ = "lookAt:from:";

	private static readonly IntPtr selLookAt_From_Handle = Selector.GetHandle("lookAt:from:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumCircleOfConfusion = "maximumCircleOfConfusion";

	private static readonly IntPtr selMaximumCircleOfConfusionHandle = Selector.GetHandle("maximumCircleOfConfusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNearVisibilityDistance = "nearVisibilityDistance";

	private static readonly IntPtr selNearVisibilityDistanceHandle = Selector.GetHandle("nearVisibilityDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpticalVignetting = "opticalVignetting";

	private static readonly IntPtr selOpticalVignettingHandle = Selector.GetHandle("opticalVignetting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjection = "projection";

	private static readonly IntPtr selProjectionHandle = Selector.GetHandle("projection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjectionMatrix = "projectionMatrix";

	private static readonly IntPtr selProjectionMatrixHandle = Selector.GetHandle("projectionMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRayTo_ForViewPort_ = "rayTo:forViewPort:";

	private static readonly IntPtr selRayTo_ForViewPort_Handle = Selector.GetHandle("rayTo:forViewPort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSensorAspect = "sensorAspect";

	private static readonly IntPtr selSensorAspectHandle = Selector.GetHandle("sensorAspect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSensorEnlargement = "sensorEnlargement";

	private static readonly IntPtr selSensorEnlargementHandle = Selector.GetHandle("sensorEnlargement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSensorShift = "sensorShift";

	private static readonly IntPtr selSensorShiftHandle = Selector.GetHandle("sensorShift");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSensorVerticalAperture = "sensorVerticalAperture";

	private static readonly IntPtr selSensorVerticalApertureHandle = Selector.GetHandle("sensorVerticalAperture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApertureBladeCount_ = "setApertureBladeCount:";

	private static readonly IntPtr selSetApertureBladeCount_Handle = Selector.GetHandle("setApertureBladeCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBarrelDistortion_ = "setBarrelDistortion:";

	private static readonly IntPtr selSetBarrelDistortion_Handle = Selector.GetHandle("setBarrelDistortion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChromaticAberration_ = "setChromaticAberration:";

	private static readonly IntPtr selSetChromaticAberration_Handle = Selector.GetHandle("setChromaticAberration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExposure_ = "setExposure:";

	private static readonly IntPtr selSetExposure_Handle = Selector.GetHandle("setExposure:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExposureCompression_ = "setExposureCompression:";

	private static readonly IntPtr selSetExposureCompression_Handle = Selector.GetHandle("setExposureCompression:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFStop_ = "setFStop:";

	private static readonly IntPtr selSetFStop_Handle = Selector.GetHandle("setFStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFarVisibilityDistance_ = "setFarVisibilityDistance:";

	private static readonly IntPtr selSetFarVisibilityDistance_Handle = Selector.GetHandle("setFarVisibilityDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldOfView_ = "setFieldOfView:";

	private static readonly IntPtr selSetFieldOfView_Handle = Selector.GetHandle("setFieldOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFisheyeDistortion_ = "setFisheyeDistortion:";

	private static readonly IntPtr selSetFisheyeDistortion_Handle = Selector.GetHandle("setFisheyeDistortion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlash_ = "setFlash:";

	private static readonly IntPtr selSetFlash_Handle = Selector.GetHandle("setFlash:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocalLength_ = "setFocalLength:";

	private static readonly IntPtr selSetFocalLength_Handle = Selector.GetHandle("setFocalLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFocusDistance_ = "setFocusDistance:";

	private static readonly IntPtr selSetFocusDistance_Handle = Selector.GetHandle("setFocusDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumCircleOfConfusion_ = "setMaximumCircleOfConfusion:";

	private static readonly IntPtr selSetMaximumCircleOfConfusion_Handle = Selector.GetHandle("setMaximumCircleOfConfusion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNearVisibilityDistance_ = "setNearVisibilityDistance:";

	private static readonly IntPtr selSetNearVisibilityDistance_Handle = Selector.GetHandle("setNearVisibilityDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpticalVignetting_ = "setOpticalVignetting:";

	private static readonly IntPtr selSetOpticalVignetting_Handle = Selector.GetHandle("setOpticalVignetting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProjection_ = "setProjection:";

	private static readonly IntPtr selSetProjection_Handle = Selector.GetHandle("setProjection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSensorAspect_ = "setSensorAspect:";

	private static readonly IntPtr selSetSensorAspect_Handle = Selector.GetHandle("setSensorAspect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSensorEnlargement_ = "setSensorEnlargement:";

	private static readonly IntPtr selSetSensorEnlargement_Handle = Selector.GetHandle("setSensorEnlargement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSensorShift_ = "setSensorShift:";

	private static readonly IntPtr selSetSensorShift_Handle = Selector.GetHandle("setSensorShift:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSensorVerticalAperture_ = "setSensorVerticalAperture:";

	private static readonly IntPtr selSetSensorVerticalAperture_Handle = Selector.GetHandle("setSensorVerticalAperture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShutterOpenInterval_ = "setShutterOpenInterval:";

	private static readonly IntPtr selSetShutterOpenInterval_Handle = Selector.GetHandle("setShutterOpenInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWorldToMetersConversionScale_ = "setWorldToMetersConversionScale:";

	private static readonly IntPtr selSetWorldToMetersConversionScale_Handle = Selector.GetHandle("setWorldToMetersConversionScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShutterOpenInterval = "shutterOpenInterval";

	private static readonly IntPtr selShutterOpenIntervalHandle = Selector.GetHandle("shutterOpenInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorldToMetersConversionScale = "worldToMetersConversionScale";

	private static readonly IntPtr selWorldToMetersConversionScaleHandle = Selector.GetHandle("worldToMetersConversionScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLCamera");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ApertureBladeCount
	{
		[Export("apertureBladeCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selApertureBladeCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selApertureBladeCountHandle);
		}
		[Export("setApertureBladeCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetApertureBladeCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetApertureBladeCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float BarrelDistortion
	{
		[Export("barrelDistortion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBarrelDistortionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBarrelDistortionHandle);
		}
		[Export("setBarrelDistortion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBarrelDistortion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBarrelDistortion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ChromaticAberration
	{
		[Export("chromaticAberration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selChromaticAberrationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selChromaticAberrationHandle);
		}
		[Export("setChromaticAberration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetChromaticAberration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetChromaticAberration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Exposure
	{
		[Export("exposure", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selExposureHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selExposureHandle);
		}
		[Export("setExposure:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetExposure_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetExposure_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 ExposureCompression
	{
		[Export("exposureCompression", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selExposureCompressionHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selExposureCompressionHandle);
		}
		[Export("setExposureCompression:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetExposureCompression_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetExposureCompression_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FStop
	{
		[Export("fStop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFStopHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFStopHandle);
		}
		[Export("setFStop:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFStop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFStop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FarVisibilityDistance
	{
		[Export("farVisibilityDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFarVisibilityDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFarVisibilityDistanceHandle);
		}
		[Export("setFarVisibilityDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFarVisibilityDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFarVisibilityDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FieldOfView
	{
		[Export("fieldOfView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFieldOfViewHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFieldOfViewHandle);
		}
		[Export("setFieldOfView:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFieldOfView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFieldOfView_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FisheyeDistortion
	{
		[Export("fisheyeDistortion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFisheyeDistortionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFisheyeDistortionHandle);
		}
		[Export("setFisheyeDistortion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFisheyeDistortion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFisheyeDistortion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Flash
	{
		[Export("flash", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selFlashHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selFlashHandle);
		}
		[Export("setFlash:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetFlash_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetFlash_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FocalLength
	{
		[Export("focalLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFocalLengthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFocalLengthHandle);
		}
		[Export("setFocalLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFocalLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFocalLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FocusDistance
	{
		[Export("focusDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFocusDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFocusDistanceHandle);
		}
		[Export("setFocusDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFocusDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFocusDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumCircleOfConfusion
	{
		[Export("maximumCircleOfConfusion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumCircleOfConfusionHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumCircleOfConfusionHandle);
		}
		[Export("setMaximumCircleOfConfusion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumCircleOfConfusion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumCircleOfConfusion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NearVisibilityDistance
	{
		[Export("nearVisibilityDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNearVisibilityDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNearVisibilityDistanceHandle);
		}
		[Export("setNearVisibilityDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetNearVisibilityDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetNearVisibilityDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float OpticalVignetting
	{
		[Export("opticalVignetting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOpticalVignettingHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOpticalVignettingHandle);
		}
		[Export("setOpticalVignetting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOpticalVignetting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOpticalVignetting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual MDLCameraProjection Projection
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("projection", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLCameraProjection)Messaging.UInt64_objc_msgSend(base.Handle, selProjectionHandle);
			}
			return (MDLCameraProjection)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selProjectionHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setProjection:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetProjection_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetProjection_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'ProjectionMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 ProjectionMatrix
	{
		[Export("projectionMatrix")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 ProjectionMatrix4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SensorAspect
	{
		[Export("sensorAspect")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSensorAspectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSensorAspectHandle);
		}
		[Export("setSensorAspect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSensorAspect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSensorAspect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 SensorEnlargement
	{
		[Export("sensorEnlargement", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selSensorEnlargementHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selSensorEnlargementHandle);
		}
		[Export("setSensorEnlargement:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetSensorEnlargement_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetSensorEnlargement_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 SensorShift
	{
		[Export("sensorShift", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selSensorShiftHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selSensorShiftHandle);
		}
		[Export("setSensorShift:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetSensorShift_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetSensorShift_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SensorVerticalAperture
	{
		[Export("sensorVerticalAperture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSensorVerticalApertureHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSensorVerticalApertureHandle);
		}
		[Export("setSensorVerticalAperture:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSensorVerticalAperture_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSensorVerticalAperture_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ShutterOpenInterval
	{
		[Export("shutterOpenInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selShutterOpenIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selShutterOpenIntervalHandle);
		}
		[Export("setShutterOpenInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetShutterOpenInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetShutterOpenInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float WorldToMetersConversionScale
	{
		[Export("worldToMetersConversionScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selWorldToMetersConversionScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selWorldToMetersConversionScaleHandle);
		}
		[Export("setWorldToMetersConversionScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetWorldToMetersConversionScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetWorldToMetersConversionScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLCamera()
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
	protected MDLCamera(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLCamera(IntPtr handle)
		: base(handle)
	{
	}

	[Export("bokehKernelWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTexture BokehKernelWithSize(Vector2i size)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLTexture>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i(base.Handle, selBokehKernelWithSize_Handle, size));
		}
		return Runtime.GetNSObject<MDLTexture>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i(base.SuperHandle, selBokehKernelWithSize_Handle, size));
	}

	[Export("frameBoundingBox:setNearAndFar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FrameBoundingBox(MDLAxisAlignedBoundingBox boundingBox, bool setNearAndFar)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_MDLAxisAlignedBoundingBox_bool(base.Handle, selFrameBoundingBox_SetNearAndFar_Handle, boundingBox, setNearAndFar);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_MDLAxisAlignedBoundingBox_bool(base.SuperHandle, selFrameBoundingBox_SetNearAndFar_Handle, boundingBox, setNearAndFar);
		}
	}

	[Export("cameraWithSCNCamera:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLCamera FromSceneCamera(SCNCamera sceneCamera)
	{
		if (sceneCamera == null)
		{
			throw new ArgumentNullException("sceneCamera");
		}
		return Runtime.GetNSObject<MDLCamera>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCameraWithSCNCamera_Handle, sceneCamera.Handle));
	}

	[Export("lookAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LookAt(Vector3 focusPosition)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selLookAt_Handle, focusPosition);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selLookAt_Handle, focusPosition);
		}
	}

	[Export("lookAt:from:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LookAt(Vector3 focusPosition, Vector3 cameraPosition)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector3_Vector3(base.Handle, selLookAt_From_Handle, focusPosition, cameraPosition);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3_Vector3(base.SuperHandle, selLookAt_From_Handle, focusPosition, cameraPosition);
		}
	}

	[Export("rayTo:forViewPort:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 RayTo(Vector2i pixel, Vector2i size)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Vector2i_Vector2i(base.Handle, selRayTo_ForViewPort_Handle, pixel, size);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector2i_Vector2i(base.SuperHandle, selRayTo_ForViewPort_Handle, pixel, size);
	}
}
