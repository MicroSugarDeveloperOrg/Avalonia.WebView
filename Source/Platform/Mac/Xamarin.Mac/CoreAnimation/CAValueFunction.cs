using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAValueFunction", true)]
public class CAValueFunction : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFunctionWithName_ = "functionWithName:";

	private static readonly IntPtr selFunctionWithName_Handle = Selector.GetHandle("functionWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAValueFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotateX;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotateY;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotateZ;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Scale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScaleX;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScaleY;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScaleZ;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Translate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranslateX;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranslateY;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TranslateZ;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[Field("kCAValueFunctionRotateX", "CoreAnimation")]
	public static NSString RotateX
	{
		get
		{
			if (_RotateX == null)
			{
				_RotateX = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionRotateX");
			}
			return _RotateX;
		}
	}

	[Field("kCAValueFunctionRotateY", "CoreAnimation")]
	public static NSString RotateY
	{
		get
		{
			if (_RotateY == null)
			{
				_RotateY = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionRotateY");
			}
			return _RotateY;
		}
	}

	[Field("kCAValueFunctionRotateZ", "CoreAnimation")]
	public static NSString RotateZ
	{
		get
		{
			if (_RotateZ == null)
			{
				_RotateZ = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionRotateZ");
			}
			return _RotateZ;
		}
	}

	[Field("kCAValueFunctionScale", "CoreAnimation")]
	public static NSString Scale
	{
		get
		{
			if (_Scale == null)
			{
				_Scale = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionScale");
			}
			return _Scale;
		}
	}

	[Field("kCAValueFunctionScaleX", "CoreAnimation")]
	public static NSString ScaleX
	{
		get
		{
			if (_ScaleX == null)
			{
				_ScaleX = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionScaleX");
			}
			return _ScaleX;
		}
	}

	[Field("kCAValueFunctionScaleY", "CoreAnimation")]
	public static NSString ScaleY
	{
		get
		{
			if (_ScaleY == null)
			{
				_ScaleY = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionScaleY");
			}
			return _ScaleY;
		}
	}

	[Field("kCAValueFunctionScaleZ", "CoreAnimation")]
	public static NSString ScaleZ
	{
		get
		{
			if (_ScaleZ == null)
			{
				_ScaleZ = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionScaleZ");
			}
			return _ScaleZ;
		}
	}

	[Field("kCAValueFunctionTranslate", "CoreAnimation")]
	public static NSString Translate
	{
		get
		{
			if (_Translate == null)
			{
				_Translate = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionTranslate");
			}
			return _Translate;
		}
	}

	[Field("kCAValueFunctionTranslateX", "CoreAnimation")]
	public static NSString TranslateX
	{
		get
		{
			if (_TranslateX == null)
			{
				_TranslateX = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionTranslateX");
			}
			return _TranslateX;
		}
	}

	[Field("kCAValueFunctionTranslateY", "CoreAnimation")]
	public static NSString TranslateY
	{
		get
		{
			if (_TranslateY == null)
			{
				_TranslateY = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionTranslateY");
			}
			return _TranslateY;
		}
	}

	[Field("kCAValueFunctionTranslateZ", "CoreAnimation")]
	public static NSString TranslateZ
	{
		get
		{
			if (_TranslateZ == null)
			{
				_TranslateZ = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAValueFunctionTranslateZ");
			}
			return _TranslateZ;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAValueFunction()
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
	public CAValueFunction(NSCoder coder)
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
	protected CAValueFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAValueFunction(IntPtr handle)
		: base(handle)
	{
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

	[Export("functionWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAValueFunction FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CAValueFunction nSObject = Runtime.GetNSObject<CAValueFunction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFunctionWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
