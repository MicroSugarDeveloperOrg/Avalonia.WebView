using Foundation;
using ObjCRuntime;

namespace IOSurface;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
internal static class IOSurfacePropertyKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BytesPerElementKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BytesPerRowKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CacheModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ElementHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ElementWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelFormatKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelSizeCastingAllowedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneBaseKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneBytesPerElementKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneBytesPerRowKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneElementHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneElementWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneInfoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __DeprecatedAllocSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __NewAllocSizeKey;

	public static NSString AllocSizeKey
	{
		get
		{
			if (CheckSystemVersion())
			{
				return _NewAllocSizeKey;
			}
			return _DeprecatedAllocSizeKey;
		}
	}

	[Field("IOSurfacePropertyKeyBytesPerElement", "IOSurface")]
	public static NSString BytesPerElementKey
	{
		get
		{
			if (_BytesPerElementKey == null)
			{
				_BytesPerElementKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyBytesPerElement");
			}
			return _BytesPerElementKey;
		}
	}

	[Field("IOSurfacePropertyKeyBytesPerRow", "IOSurface")]
	public static NSString BytesPerRowKey
	{
		get
		{
			if (_BytesPerRowKey == null)
			{
				_BytesPerRowKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyBytesPerRow");
			}
			return _BytesPerRowKey;
		}
	}

	[Field("IOSurfacePropertyKeyCacheMode", "IOSurface")]
	public static NSString CacheModeKey
	{
		get
		{
			if (_CacheModeKey == null)
			{
				_CacheModeKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyCacheMode");
			}
			return _CacheModeKey;
		}
	}

	[Field("IOSurfacePropertyKeyElementHeight", "IOSurface")]
	public static NSString ElementHeightKey
	{
		get
		{
			if (_ElementHeightKey == null)
			{
				_ElementHeightKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyElementHeight");
			}
			return _ElementHeightKey;
		}
	}

	[Field("IOSurfacePropertyKeyElementWidth", "IOSurface")]
	public static NSString ElementWidthKey
	{
		get
		{
			if (_ElementWidthKey == null)
			{
				_ElementWidthKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyElementWidth");
			}
			return _ElementWidthKey;
		}
	}

	[Field("IOSurfacePropertyKeyHeight", "IOSurface")]
	public static NSString HeightKey
	{
		get
		{
			if (_HeightKey == null)
			{
				_HeightKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyHeight");
			}
			return _HeightKey;
		}
	}

	[Field("IOSurfacePropertyKeyOffset", "IOSurface")]
	public static NSString OffsetKey
	{
		get
		{
			if (_OffsetKey == null)
			{
				_OffsetKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyOffset");
			}
			return _OffsetKey;
		}
	}

	[Field("IOSurfacePropertyKeyPixelFormat", "IOSurface")]
	public static NSString PixelFormatKey
	{
		get
		{
			if (_PixelFormatKey == null)
			{
				_PixelFormatKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPixelFormat");
			}
			return _PixelFormatKey;
		}
	}

	[Field("IOSurfacePropertyKeyPixelSizeCastingAllowed", "IOSurface")]
	public static NSString PixelSizeCastingAllowedKey
	{
		get
		{
			if (_PixelSizeCastingAllowedKey == null)
			{
				_PixelSizeCastingAllowedKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPixelSizeCastingAllowed");
			}
			return _PixelSizeCastingAllowedKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneBase", "IOSurface")]
	public static NSString PlaneBaseKey
	{
		get
		{
			if (_PlaneBaseKey == null)
			{
				_PlaneBaseKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBase");
			}
			return _PlaneBaseKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneBytesPerElement", "IOSurface")]
	public static NSString PlaneBytesPerElementKey
	{
		get
		{
			if (_PlaneBytesPerElementKey == null)
			{
				_PlaneBytesPerElementKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBytesPerElement");
			}
			return _PlaneBytesPerElementKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneBytesPerRow", "IOSurface")]
	public static NSString PlaneBytesPerRowKey
	{
		get
		{
			if (_PlaneBytesPerRowKey == null)
			{
				_PlaneBytesPerRowKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneBytesPerRow");
			}
			return _PlaneBytesPerRowKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneElementHeight", "IOSurface")]
	public static NSString PlaneElementHeightKey
	{
		get
		{
			if (_PlaneElementHeightKey == null)
			{
				_PlaneElementHeightKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneElementHeight");
			}
			return _PlaneElementHeightKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneElementWidth", "IOSurface")]
	public static NSString PlaneElementWidthKey
	{
		get
		{
			if (_PlaneElementWidthKey == null)
			{
				_PlaneElementWidthKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneElementWidth");
			}
			return _PlaneElementWidthKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneHeight", "IOSurface")]
	public static NSString PlaneHeightKey
	{
		get
		{
			if (_PlaneHeightKey == null)
			{
				_PlaneHeightKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneHeight");
			}
			return _PlaneHeightKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneInfo", "IOSurface")]
	public static NSString PlaneInfoKey
	{
		get
		{
			if (_PlaneInfoKey == null)
			{
				_PlaneInfoKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneInfo");
			}
			return _PlaneInfoKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneOffset", "IOSurface")]
	public static NSString PlaneOffsetKey
	{
		get
		{
			if (_PlaneOffsetKey == null)
			{
				_PlaneOffsetKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneOffset");
			}
			return _PlaneOffsetKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneSize", "IOSurface")]
	public static NSString PlaneSizeKey
	{
		get
		{
			if (_PlaneSizeKey == null)
			{
				_PlaneSizeKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneSize");
			}
			return _PlaneSizeKey;
		}
	}

	[Field("IOSurfacePropertyKeyPlaneWidth", "IOSurface")]
	public static NSString PlaneWidthKey
	{
		get
		{
			if (_PlaneWidthKey == null)
			{
				_PlaneWidthKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyPlaneWidth");
			}
			return _PlaneWidthKey;
		}
	}

	[Field("IOSurfacePropertyKeyWidth", "IOSurface")]
	public static NSString WidthKey
	{
		get
		{
			if (_WidthKey == null)
			{
				_WidthKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyWidth");
			}
			return _WidthKey;
		}
	}

	[Field("IOSurfacePropertyAllocSizeKey", "IOSurface")]
	internal static NSString _DeprecatedAllocSizeKey
	{
		get
		{
			if (__DeprecatedAllocSizeKey == null)
			{
				__DeprecatedAllocSizeKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyAllocSizeKey");
			}
			return __DeprecatedAllocSizeKey;
		}
	}

	[Field("IOSurfacePropertyKeyAllocSize", "IOSurface")]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	internal static NSString _NewAllocSizeKey
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (__NewAllocSizeKey == null)
			{
				__NewAllocSizeKey = Dlfcn.GetStringConstant(Libraries.IOSurface.Handle, "IOSurfacePropertyKeyAllocSize");
			}
			return __NewAllocSizeKey;
		}
	}

	private static bool CheckSystemVersion()
	{
		return PlatformHelper.CheckSystemVersion(10, 14);
	}
}
