using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAValueFunction", true)]
public class CAValueFunction : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selFunctionWithName_Handle = Selector.GetHandle("functionWithName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAValueFunction");

	private static NSString _RotateX;

	private static NSString _RotateY;

	private static NSString _RotateZ;

	private static NSString _Scale;

	private static NSString _ScaleX;

	private static NSString _ScaleY;

	private static NSString _ScaleZ;

	private static NSString _Translate;

	private static NSString _TranslateX;

	private static NSString _TranslateY;

	private static NSString _TranslateZ;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAValueFunction()
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
	public CAValueFunction(NSCoder coder)
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
	public CAValueFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAValueFunction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("functionWithName:")]
	public static CAValueFunction FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CAValueFunction result = (CAValueFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFunctionWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}
