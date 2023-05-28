using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreAnimation;

[Register("CAMediaTimingFunction", true)]
public class CAMediaTimingFunction : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFunctionWithControlPoints____ = "functionWithControlPoints::::";

	private static readonly IntPtr selFunctionWithControlPoints____Handle = Selector.GetHandle("functionWithControlPoints::::");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFunctionWithName_ = "functionWithName:";

	private static readonly IntPtr selFunctionWithName_Handle = Selector.GetHandle("functionWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetControlPointAtIndex_Values_ = "getControlPointAtIndex:values:";

	private static readonly IntPtr selGetControlPointAtIndex_Values_Handle = Selector.GetHandle("getControlPointAtIndex:values:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithControlPoints____ = "initWithControlPoints::::";

	private static readonly IntPtr selInitWithControlPoints____Handle = Selector.GetHandle("initWithControlPoints::::");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAMediaTimingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Default;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EaseIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EaseInEaseOut;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EaseOut;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Linear;

	public override IntPtr ClassHandle => class_ptr;

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

	public unsafe CGPoint GetControlPoint(nint index)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAMediaTimingFunction(NSCoder coder)
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
	protected CAMediaTimingFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAMediaTimingFunction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithControlPoints::::")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CAMediaTimingFunction(float c1x, float c1y, float c2x, float c2y)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float_float_float_float(base.Handle, selInitWithControlPoints____Handle, c1x, c1y, c2x, c2y), "initWithControlPoints::::");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float_float_float_float(base.SuperHandle, selInitWithControlPoints____Handle, c1x, c1y, c2x, c2y), "initWithControlPoints::::");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("functionWithControlPoints::::")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAMediaTimingFunction FromControlPoints(float c1x, float c1y, float c2x, float c2y)
	{
		return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend_float_float_float_float(class_ptr, selFunctionWithControlPoints____Handle, c1x, c1y, c2x, c2y));
	}

	[Export("functionWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAMediaTimingFunction FromName(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFunctionWithName_Handle, name.Handle));
	}

	[Export("getControlPointAtIndex:values:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void GetControlPointAtIndex(nint idx, IntPtr point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selGetControlPointAtIndex_Values_Handle, idx, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selGetControlPointAtIndex_Values_Handle, idx, point);
		}
	}
}
