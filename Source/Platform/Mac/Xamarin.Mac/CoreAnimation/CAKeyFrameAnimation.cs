using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAKeyframeAnimation", true)]
public class CAKeyFrameAnimation : CAPropertyAnimation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithKeyPath_ = "animationWithKeyPath:";

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBiasValues = "biasValues";

	private static readonly IntPtr selBiasValuesHandle = Selector.GetHandle("biasValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalculationMode = "calculationMode";

	private static readonly IntPtr selCalculationModeHandle = Selector.GetHandle("calculationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinuityValues = "continuityValues";

	private static readonly IntPtr selContinuityValuesHandle = Selector.GetHandle("continuityValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyTimes = "keyTimes";

	private static readonly IntPtr selKeyTimesHandle = Selector.GetHandle("keyTimes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationMode = "rotationMode";

	private static readonly IntPtr selRotationModeHandle = Selector.GetHandle("rotationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBiasValues_ = "setBiasValues:";

	private static readonly IntPtr selSetBiasValues_Handle = Selector.GetHandle("setBiasValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalculationMode_ = "setCalculationMode:";

	private static readonly IntPtr selSetCalculationMode_Handle = Selector.GetHandle("setCalculationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuityValues_ = "setContinuityValues:";

	private static readonly IntPtr selSetContinuityValues_Handle = Selector.GetHandle("setContinuityValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyTimes_ = "setKeyTimes:";

	private static readonly IntPtr selSetKeyTimes_Handle = Selector.GetHandle("setKeyTimes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationMode_ = "setRotationMode:";

	private static readonly IntPtr selSetRotationMode_Handle = Selector.GetHandle("setRotationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTensionValues_ = "setTensionValues:";

	private static readonly IntPtr selSetTensionValues_Handle = Selector.GetHandle("setTensionValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingFunctions_ = "setTimingFunctions:";

	private static readonly IntPtr selSetTimingFunctions_Handle = Selector.GetHandle("setTimingFunctions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValues_ = "setValues:";

	private static readonly IntPtr selSetValues_Handle = Selector.GetHandle("setValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTensionValues = "tensionValues";

	private static readonly IntPtr selTensionValuesHandle = Selector.GetHandle("tensionValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingFunctions = "timingFunctions";

	private static readonly IntPtr selTimingFunctionsHandle = Selector.GetHandle("timingFunctions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValues = "values";

	private static readonly IntPtr selValuesHandle = Selector.GetHandle("values");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAKeyframeAnimation");

	public virtual string CalculationMode
	{
		get
		{
			return _CalculationMode;
		}
		set
		{
			NSString calculationMode = ((value == CAAnimation.AnimationLinear) ? CAAnimation.AnimationLinear : ((value == CAAnimation.AnimationDescrete) ? CAAnimation.AnimationDescrete : ((value == CAAnimation.AnimationPaced) ? CAAnimation.AnimationPaced : ((value == CAAnimation.AnimationCubic) ? CAAnimation.AnimationCubic : ((!(value == CAAnimation.AnimationCubicPaced)) ? ((NSString)value) : CAAnimation.AnimationCubicPaced)))));
			_CalculationMode = calculationMode;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? BiasValues
	{
		[Export("biasValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selBiasValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBiasValuesHandle));
		}
		[Export("setBiasValues:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBiasValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBiasValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? ContinuityValues
	{
		[Export("continuityValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selContinuityValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContinuityValuesHandle));
		}
		[Export("setContinuityValues:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContinuityValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContinuityValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? KeyTimes
	{
		[Export("keyTimes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyTimesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyTimesHandle));
		}
		[Export("setKeyTimes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyTimes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyTimes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPath? Path
	{
		[Export("path")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPath(intPtr);
		}
		[Export("setPath:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? RotationMode
	{
		[Export("rotationMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRotationModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRotationModeHandle));
		}
		[Export("setRotationMode:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRotationMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRotationMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? TensionValues
	{
		[Export("tensionValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selTensionValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTensionValuesHandle));
		}
		[Export("setTensionValues:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTensionValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTensionValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAMediaTimingFunction[]? TimingFunctions
	{
		[Export("timingFunctions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionsHandle));
			}
			return NSArray.ArrayFromHandle<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionsHandle));
		}
		[Export("setTimingFunctions:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunctions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunctions_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? Values
	{
		[Export("values", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValuesHandle));
		}
		[Export("setValues:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValues_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString _CalculationMode
	{
		[Export("calculationMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selCalculationModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalculationModeHandle));
		}
		[Export("setCalculationMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalculationMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalculationMode_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSArray _Values
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selValuesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValuesHandle));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValues_Handle, value.Handle);
			}
		}
	}

	public static CAKeyFrameAnimation GetFromKeyPath(string path)
	{
		return FromKeyPath(path);
	}

	public T[] GetValuesAs<T>() where T : class, INativeObject
	{
		return NSArray.FromArrayNative<T>(_Values);
	}

	public void SetValues(INativeObject[] value)
	{
		_Values = NSArray.FromNSObjects(value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAKeyFrameAnimation()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAKeyFrameAnimation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CAKeyFrameAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAKeyFrameAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CAKeyFrameAnimation FromKeyPath(string? path)
	{
		IntPtr arg = NSString.CreateNative(path);
		CAKeyFrameAnimation nSObject = Runtime.GetNSObject<CAKeyFrameAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
