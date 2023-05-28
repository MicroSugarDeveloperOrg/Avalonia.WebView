using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMetadataObject", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVMetadataObject : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTime = "time";

	private static readonly IntPtr selTimeHandle = Selector.GetHandle("time");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMetadataObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeAztecCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCatBody;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCode128Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCode39Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCode39Mod43Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeCode93Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeDataMatrixCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeDogBody;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeEAN13Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeEAN8Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeFace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeHumanBody;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeITF14Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeInterleaved2of5Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypePDF417Code;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeQRCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeSalientObject;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeUPCECode;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Time
	{
		[Export("time")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString WeakType
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	[Field("AVMetadataObjectTypeAztecCode", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeAztecCode
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeAztecCode == null)
			{
				_TypeAztecCode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeAztecCode");
			}
			return _TypeAztecCode;
		}
	}

	[Field("AVMetadataObjectTypeCatBody", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeCatBody
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeCatBody == null)
			{
				_TypeCatBody = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCatBody");
			}
			return _TypeCatBody;
		}
	}

	[Field("AVMetadataObjectTypeCode128Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeCode128Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeCode128Code == null)
			{
				_TypeCode128Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode128Code");
			}
			return _TypeCode128Code;
		}
	}

	[Field("AVMetadataObjectTypeCode39Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeCode39Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeCode39Code == null)
			{
				_TypeCode39Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Code");
			}
			return _TypeCode39Code;
		}
	}

	[Field("AVMetadataObjectTypeCode39Mod43Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeCode39Mod43Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeCode39Mod43Code == null)
			{
				_TypeCode39Mod43Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode39Mod43Code");
			}
			return _TypeCode39Mod43Code;
		}
	}

	[Field("AVMetadataObjectTypeCode93Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeCode93Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeCode93Code == null)
			{
				_TypeCode93Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeCode93Code");
			}
			return _TypeCode93Code;
		}
	}

	[Field("AVMetadataObjectTypeDataMatrixCode", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeDataMatrixCode
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeDataMatrixCode == null)
			{
				_TypeDataMatrixCode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDataMatrixCode");
			}
			return _TypeDataMatrixCode;
		}
	}

	[Field("AVMetadataObjectTypeDogBody", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeDogBody
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeDogBody == null)
			{
				_TypeDogBody = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeDogBody");
			}
			return _TypeDogBody;
		}
	}

	[Field("AVMetadataObjectTypeEAN13Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeEAN13Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeEAN13Code == null)
			{
				_TypeEAN13Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN13Code");
			}
			return _TypeEAN13Code;
		}
	}

	[Field("AVMetadataObjectTypeEAN8Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeEAN8Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeEAN8Code == null)
			{
				_TypeEAN8Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeEAN8Code");
			}
			return _TypeEAN8Code;
		}
	}

	[Field("AVMetadataObjectTypeFace", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString TypeFace
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeFace == null)
			{
				_TypeFace = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeFace");
			}
			return _TypeFace;
		}
	}

	[Field("AVMetadataObjectTypeHumanBody", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeHumanBody
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeHumanBody == null)
			{
				_TypeHumanBody = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeHumanBody");
			}
			return _TypeHumanBody;
		}
	}

	[Field("AVMetadataObjectTypeITF14Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeITF14Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeITF14Code == null)
			{
				_TypeITF14Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeITF14Code");
			}
			return _TypeITF14Code;
		}
	}

	[Field("AVMetadataObjectTypeInterleaved2of5Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeInterleaved2of5Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeInterleaved2of5Code == null)
			{
				_TypeInterleaved2of5Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeInterleaved2of5Code");
			}
			return _TypeInterleaved2of5Code;
		}
	}

	[Field("AVMetadataObjectTypePDF417Code", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypePDF417Code
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypePDF417Code == null)
			{
				_TypePDF417Code = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypePDF417Code");
			}
			return _TypePDF417Code;
		}
	}

	[Field("AVMetadataObjectTypeQRCode", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeQRCode
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeQRCode == null)
			{
				_TypeQRCode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeQRCode");
			}
			return _TypeQRCode;
		}
	}

	[Field("AVMetadataObjectTypeSalientObject", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeSalientObject
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeSalientObject == null)
			{
				_TypeSalientObject = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeSalientObject");
			}
			return _TypeSalientObject;
		}
	}

	[Field("AVMetadataObjectTypeUPCECode", "AVFoundation")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TypeUPCECode
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TypeUPCECode == null)
			{
				_TypeUPCECode = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVMetadataObjectTypeUPCECode");
			}
			return _TypeUPCECode;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMetadataObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMetadataObject(IntPtr handle)
		: base(handle)
	{
	}
}
