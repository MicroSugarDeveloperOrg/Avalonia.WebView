using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAKeyframeAnimation", true)]
public class CAKeyFrameAnimation : CAPropertyAnimation
{
	private static readonly IntPtr selValuesHandle = Selector.GetHandle("values");

	private static readonly IntPtr selSetValues_Handle = Selector.GetHandle("setValues:");

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	private static readonly IntPtr selKeyTimesHandle = Selector.GetHandle("keyTimes");

	private static readonly IntPtr selSetKeyTimes_Handle = Selector.GetHandle("setKeyTimes:");

	private static readonly IntPtr selTimingFunctionsHandle = Selector.GetHandle("timingFunctions");

	private static readonly IntPtr selSetTimingFunctions_Handle = Selector.GetHandle("setTimingFunctions:");

	private static readonly IntPtr selCalculationModeHandle = Selector.GetHandle("calculationMode");

	private static readonly IntPtr selSetCalculationMode_Handle = Selector.GetHandle("setCalculationMode:");

	private static readonly IntPtr selRotationModeHandle = Selector.GetHandle("rotationMode");

	private static readonly IntPtr selSetRotationMode_Handle = Selector.GetHandle("setRotationMode:");

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAKeyframeAnimation");

	private object __mt_Values_var;

	private object __mt_KeyTimes_var;

	private object __mt_TimingFunctions_var;

	private static NSString _CalculationLinear;

	private static NSString _CalculationDiscrete;

	private static NSString _CalculationPaced;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject[] Values
	{
		[Export("values", ArgumentSemantic.Copy)]
		get
		{
			return (NSObject[])(__mt_Values_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValuesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selValuesHandle))));
		}
		[Export("setValues:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValues_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValues_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Values_var = value;
		}
	}

	public virtual CGPath Path
	{
		[Export("path")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGPath(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return new CGPath(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
		[Export("setPath:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, value.Handle);
			}
		}
	}

	public virtual NSNumber[] KeyTimes
	{
		[Export("keyTimes", ArgumentSemantic.Copy)]
		get
		{
			return (NSNumber[])(__mt_KeyTimes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyTimesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyTimesHandle))));
		}
		[Export("setKeyTimes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyTimes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyTimes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_KeyTimes_var = value;
		}
	}

	public virtual CAMediaTimingFunction[] TimingFunctions
	{
		[Export("timingFunctions", ArgumentSemantic.Copy)]
		get
		{
			return (CAMediaTimingFunction[])(__mt_TimingFunctions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionsHandle)) : NSArray.ArrayFromHandle<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionsHandle))));
		}
		[Export("setTimingFunctions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunctions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunctions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_TimingFunctions_var = value;
		}
	}

	public virtual string CalculationMode
	{
		[Export("calculationMode", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalculationModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalculationModeHandle));
		}
		[Export("setCalculationMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalculationMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalculationMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string RotationMode
	{
		[Export("rotationMode", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRotationModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRotationModeHandle));
		}
		[Export("setRotationMode:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	[Field("kCAAnimationLinear", "CoreAnimation")]
	public static NSString CalculationLinear
	{
		get
		{
			if (_CalculationLinear == null)
			{
				_CalculationLinear = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationLinear");
			}
			return _CalculationLinear;
		}
	}

	[Field("kCAAnimationDiscrete", "CoreAnimation")]
	public static NSString CalculationDiscrete
	{
		get
		{
			if (_CalculationDiscrete == null)
			{
				_CalculationDiscrete = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationDiscrete");
			}
			return _CalculationDiscrete;
		}
	}

	[Field("kCAAnimationDiscrete", "CoreAnimation")]
	public static NSString CalculationPaced
	{
		get
		{
			if (_CalculationPaced == null)
			{
				_CalculationPaced = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationDiscrete");
			}
			return _CalculationPaced;
		}
	}

	[Obsolete("This method in the future will return a CAKeyFrameAnimation, update your source, or use GetFromKeyPath to avoid this warning for now")]
	public new static CAPropertyAnimation FromKeyPath(string path)
	{
		return GetFromKeyPath(path);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAKeyFrameAnimation()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAKeyFrameAnimation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAKeyFrameAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAKeyFrameAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	public static CAKeyFrameAnimation GetFromKeyPath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		CAKeyFrameAnimation result = (CAKeyFrameAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Values_var = null;
			__mt_KeyTimes_var = null;
			__mt_TimingFunctions_var = null;
		}
	}
}
