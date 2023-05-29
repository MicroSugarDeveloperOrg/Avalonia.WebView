using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAMediaTimingFunction", true)]
public class CAMediaTimingFunction : NSObject
{
	private static readonly IntPtr selFunctionWithName_Handle = Selector.GetHandle("functionWithName:");

	private static readonly IntPtr selFunctionWithControlPoints_Handle = Selector.GetHandle("functionWithControlPoints::::");

	private static readonly IntPtr selInitWithControlPoints_Handle = Selector.GetHandle("initWithControlPoints::::");

	private static readonly IntPtr selGetControlPointAtIndexValues_Handle = Selector.GetHandle("getControlPointAtIndex:values:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAMediaTimingFunction");

	private static NSString _Linear;

	private static NSString _EaseIn;

	private static NSString _EaseOut;

	private static NSString _EaseInEaseOut;

	private static NSString _Default;

	public override IntPtr ClassHandle => class_ptr;

	[Field("kCAMediaTimingFunctionLinear", "CoreAnimation")]
	public static NSString Linear
	{
		get
		{
			if (_Linear == null)
			{
				_Linear = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAMediaTimingFunctionLinear");
			}
			return _Linear;
		}
	}

	[Field("kCAMediaTimingFunctionEaseIn", "CoreAnimation")]
	public static NSString EaseIn
	{
		get
		{
			if (_EaseIn == null)
			{
				_EaseIn = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAMediaTimingFunctionEaseIn");
			}
			return _EaseIn;
		}
	}

	[Field("kCAMediaTimingFunctionEaseOut", "CoreAnimation")]
	public static NSString EaseOut
	{
		get
		{
			if (_EaseOut == null)
			{
				_EaseOut = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAMediaTimingFunctionEaseOut");
			}
			return _EaseOut;
		}
	}

	[Field("kCAMediaTimingFunctionEaseInEaseOut", "CoreAnimation")]
	public static NSString EaseInEaseOut
	{
		get
		{
			if (_EaseInEaseOut == null)
			{
				_EaseInEaseOut = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAMediaTimingFunctionEaseInEaseOut");
			}
			return _EaseInEaseOut;
		}
	}

	[Field("kCAMediaTimingFunctionDefault", "CoreAnimation")]
	public static NSString Default
	{
		get
		{
			if (_Default == null)
			{
				_Default = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAMediaTimingFunctionDefault");
			}
			return _Default;
		}
	}

	[Advice("Use FromName(NSString) with one of the CAMediaTimingFunction fields")]
	public static CAMediaTimingFunction FromName(string name)
	{
		using NSString name2 = new NSString(name);
		return FromName(name2);
	}

	public unsafe CGPoint GetControlPoint(int index)
	{
		if (index < 0 || index > 3)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		float[] array = new float[2];
		fixed (float* ptr = &array[0])
		{
			GetControlPointAtIndex(index, (IntPtr)ptr);
		}
		return new CGPoint(array[0], array[1]);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAMediaTimingFunction(NSCoder coder)
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
	public CAMediaTimingFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAMediaTimingFunction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("functionWithName:")]
	public static CAMediaTimingFunction FromName(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return (CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFunctionWithName_Handle, name.Handle));
	}

	[Export("functionWithControlPoints::::")]
	public static CAMediaTimingFunction FromControlPoints(float c1x, float c1y, float c2x, float c2y)
	{
		return (CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_float_float_float_float(class_ptr, selFunctionWithControlPoints_Handle, c1x, c1y, c2x, c2y));
	}

	[Export("initWithControlPoints::::")]
	public CAMediaTimingFunction(float c1x, float c1y, float c2x, float c2y)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_float_float_float_float(base.Handle, selInitWithControlPoints_Handle, c1x, c1y, c2x, c2y);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_float_float_float_float(base.SuperHandle, selInitWithControlPoints_Handle, c1x, c1y, c2x, c2y);
		}
	}

	[Export("getControlPointAtIndex:values:")]
	internal virtual void GetControlPointAtIndex(int idx, IntPtr point)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selGetControlPointAtIndexValues_Handle, idx, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selGetControlPointAtIndexValues_Handle, idx, point);
		}
	}
}
