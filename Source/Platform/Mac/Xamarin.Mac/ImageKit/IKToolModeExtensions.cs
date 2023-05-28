using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class IKToolModeExtensions
{
	private static IntPtr[] values = new IntPtr[9];

	[Field("IKToolModeAnnotate", "ImageKit")]
	internal unsafe static IntPtr IKToolModeAnnotate
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeAnnotate", storage);
			}
		}
	}

	[Field("IKToolModeCrop", "ImageKit")]
	internal unsafe static IntPtr IKToolModeCrop
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeCrop", storage);
			}
		}
	}

	[Field("IKToolModeMove", "ImageKit")]
	internal unsafe static IntPtr IKToolModeMove
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeMove", storage);
			}
		}
	}

	[Field("IKToolModeNone", "ImageKit")]
	internal unsafe static IntPtr IKToolModeNone
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeNone", storage);
			}
		}
	}

	[Field("IKToolModeRotate", "ImageKit")]
	internal unsafe static IntPtr IKToolModeRotate
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeRotate", storage);
			}
		}
	}

	[Field("IKToolModeSelect", "ImageKit")]
	internal unsafe static IntPtr IKToolModeSelect
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeSelect", storage);
			}
		}
	}

	[Field("IKToolModeSelectEllipse", "ImageKit")]
	internal unsafe static IntPtr IKToolModeSelectEllipse
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeSelectEllipse", storage);
			}
		}
	}

	[Field("IKToolModeSelectLasso", "ImageKit")]
	internal unsafe static IntPtr IKToolModeSelectLasso
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeSelectLasso", storage);
			}
		}
	}

	[Field("IKToolModeSelectRect", "ImageKit")]
	internal unsafe static IntPtr IKToolModeSelectRect
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.ImageKit.Handle, "IKToolModeSelectRect", storage);
			}
		}
	}

	public static NSString? GetConstant(this IKToolMode self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = IKToolModeAnnotate;
			break;
		case 1:
			ptr = IKToolModeCrop;
			break;
		case 2:
			ptr = IKToolModeMove;
			break;
		case 3:
			ptr = IKToolModeNone;
			break;
		case 4:
			ptr = IKToolModeRotate;
			break;
		case 5:
			ptr = IKToolModeSelect;
			break;
		case 6:
			ptr = IKToolModeSelectEllipse;
			break;
		case 7:
			ptr = IKToolModeSelectLasso;
			break;
		case 8:
			ptr = IKToolModeSelectRect;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static IKToolMode GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(IKToolModeAnnotate))
		{
			return IKToolMode.Annotate;
		}
		if (constant.IsEqualTo(IKToolModeCrop))
		{
			return IKToolMode.Crop;
		}
		if (constant.IsEqualTo(IKToolModeMove))
		{
			return IKToolMode.Move;
		}
		if (constant.IsEqualTo(IKToolModeNone))
		{
			return IKToolMode.None;
		}
		if (constant.IsEqualTo(IKToolModeRotate))
		{
			return IKToolMode.Rotate;
		}
		if (constant.IsEqualTo(IKToolModeSelect))
		{
			return IKToolMode.Select;
		}
		if (constant.IsEqualTo(IKToolModeSelectEllipse))
		{
			return IKToolMode.SelectEllipse;
		}
		if (constant.IsEqualTo(IKToolModeSelectLasso))
		{
			return IKToolMode.SelectLasso;
		}
		if (constant.IsEqualTo(IKToolModeSelectRect))
		{
			return IKToolMode.SelectRect;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
