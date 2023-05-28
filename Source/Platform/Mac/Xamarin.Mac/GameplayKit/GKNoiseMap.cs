using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKNoiseMap", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKNoiseMap : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNoise_ = "initWithNoise:";

	private static readonly IntPtr selInitWithNoise_Handle = Selector.GetHandle("initWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNoise_Size_Origin_SampleCount_Seamless_ = "initWithNoise:size:origin:sampleCount:seamless:";

	private static readonly IntPtr selInitWithNoise_Size_Origin_SampleCount_Seamless_Handle = Selector.GetHandle("initWithNoise:size:origin:sampleCount:seamless:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpolatedValueAtPosition_ = "interpolatedValueAtPosition:";

	private static readonly IntPtr selInterpolatedValueAtPosition_Handle = Selector.GetHandle("interpolatedValueAtPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSeamless = "isSeamless";

	private static readonly IntPtr selIsSeamlessHandle = Selector.GetHandle("isSeamless");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseMapWithNoise_ = "noiseMapWithNoise:";

	private static readonly IntPtr selNoiseMapWithNoise_Handle = Selector.GetHandle("noiseMapWithNoise:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoiseMapWithNoise_Size_Origin_SampleCount_Seamless_ = "noiseMapWithNoise:size:origin:sampleCount:seamless:";

	private static readonly IntPtr selNoiseMapWithNoise_Size_Origin_SampleCount_Seamless_Handle = Selector.GetHandle("noiseMapWithNoise:size:origin:sampleCount:seamless:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrigin = "origin";

	private static readonly IntPtr selOriginHandle = Selector.GetHandle("origin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleCount = "sampleCount";

	private static readonly IntPtr selSampleCountHandle = Selector.GetHandle("sampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_AtPosition_ = "setValue:atPosition:";

	private static readonly IntPtr selSetValue_AtPosition_Handle = Selector.GetHandle("setValue:atPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueAtPosition_ = "valueAtPosition:";

	private static readonly IntPtr selValueAtPosition_Handle = Selector.GetHandle("valueAtPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKNoiseMap");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2d Origin
	{
		[Export("origin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2d_objc_msgSend(base.Handle, selOriginHandle);
			}
			return Messaging.xamarin_simd__Vector2d_objc_msgSendSuper(base.SuperHandle, selOriginHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2i SampleCount
	{
		[Export("sampleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2i_objc_msgSend(base.Handle, selSampleCountHandle);
			}
			return Messaging.xamarin_simd__Vector2i_objc_msgSendSuper(base.SuperHandle, selSampleCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Seamless
	{
		[Export("isSeamless")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSeamlessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSeamlessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2d Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2d_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.xamarin_simd__Vector2d_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKNoiseMap()
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
	protected GKNoiseMap(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKNoiseMap(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKNoiseMap(GKNoise noise)
		: base(NSObjectFlag.Empty)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNoise_Handle, noise.Handle), "initWithNoise:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNoise_Handle, noise.Handle), "initWithNoise:");
		}
	}

	[Export("initWithNoise:size:origin:sampleCount:seamless:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKNoiseMap(GKNoise noise, Vector2d size, Vector2d origin, Vector2i sampleCount, bool seamless)
		: base(NSObjectFlag.Empty)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2d_Vector2d_Vector2i_bool(base.Handle, selInitWithNoise_Size_Origin_SampleCount_Seamless_Handle, noise.Handle, size, origin, sampleCount, seamless), "initWithNoise:size:origin:sampleCount:seamless:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector2d_Vector2d_Vector2i_bool(base.SuperHandle, selInitWithNoise_Size_Origin_SampleCount_Seamless_Handle, noise.Handle, size, origin, sampleCount, seamless), "initWithNoise:size:origin:sampleCount:seamless:");
		}
	}

	[Export("noiseMapWithNoise:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoiseMap FromNoise(GKNoise noise)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		return Runtime.GetNSObject<GKNoiseMap>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNoiseMapWithNoise_Handle, noise.Handle));
	}

	[Export("noiseMapWithNoise:size:origin:sampleCount:seamless:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKNoiseMap FromNoise(GKNoise noise, Vector2d size, Vector2d origin, Vector2i sampleCount, bool seamless)
	{
		if (noise == null)
		{
			throw new ArgumentNullException("noise");
		}
		return Runtime.GetNSObject<GKNoiseMap>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2d_Vector2d_Vector2i_bool(class_ptr, selNoiseMapWithNoise_Size_Origin_SampleCount_Seamless_Handle, noise.Handle, size, origin, sampleCount, seamless));
	}

	[Export("interpolatedValueAtPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetInterpolatedValue(Vector2 position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__float_objc_msgSend_Vector2(base.Handle, selInterpolatedValueAtPosition_Handle, position);
		}
		return Messaging.xamarin_simd__float_objc_msgSendSuper_Vector2(base.SuperHandle, selInterpolatedValueAtPosition_Handle, position);
	}

	[Export("valueAtPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetValue(Vector2i position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__float_objc_msgSend_Vector2i(base.Handle, selValueAtPosition_Handle, position);
		}
		return Messaging.xamarin_simd__float_objc_msgSendSuper_Vector2i(base.SuperHandle, selValueAtPosition_Handle, position);
	}

	[Export("setValue:atPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(float value, Vector2i position)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_float_Vector2i(base.Handle, selSetValue_AtPosition_Handle, value, position);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_float_Vector2i(base.SuperHandle, selSetValue_AtPosition_Handle, value, position);
		}
	}
}
