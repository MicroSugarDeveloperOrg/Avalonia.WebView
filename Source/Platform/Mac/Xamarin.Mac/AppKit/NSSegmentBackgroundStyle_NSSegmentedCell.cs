using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSegmentBackgroundStyle_NSSegmentedCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSSegmentedCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameAddToAperture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameAddToIPhoto;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameAddToSafariReadingList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameComposeEmail;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameComposeMessage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostImageOnFlickr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostOnFacebook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostOnSinaWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostOnTwitter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostVideoOnTudou;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostVideoOnVimeo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNamePostVideoOnYouku;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameSendViaAirDrop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameUseAsDesktopPicture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SharingServiceNameUseAsTwitterProfileImage;

	[Field("NSSharingServiceNameAddToAperture", "AppKit")]
	public static NSString SharingServiceNameAddToAperture
	{
		get
		{
			if (_SharingServiceNameAddToAperture == null)
			{
				_SharingServiceNameAddToAperture = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToAperture");
			}
			return _SharingServiceNameAddToAperture;
		}
	}

	[Field("NSSharingServiceNameAddToIPhoto", "AppKit")]
	public static NSString SharingServiceNameAddToIPhoto
	{
		get
		{
			if (_SharingServiceNameAddToIPhoto == null)
			{
				_SharingServiceNameAddToIPhoto = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToIPhoto");
			}
			return _SharingServiceNameAddToIPhoto;
		}
	}

	[Field("NSSharingServiceNameAddToSafariReadingList", "AppKit")]
	public static NSString SharingServiceNameAddToSafariReadingList
	{
		get
		{
			if (_SharingServiceNameAddToSafariReadingList == null)
			{
				_SharingServiceNameAddToSafariReadingList = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToSafariReadingList");
			}
			return _SharingServiceNameAddToSafariReadingList;
		}
	}

	[Field("NSSharingServiceNameComposeEmail", "AppKit")]
	public static NSString SharingServiceNameComposeEmail
	{
		get
		{
			if (_SharingServiceNameComposeEmail == null)
			{
				_SharingServiceNameComposeEmail = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameComposeEmail");
			}
			return _SharingServiceNameComposeEmail;
		}
	}

	[Field("NSSharingServiceNameComposeMessage", "AppKit")]
	public static NSString SharingServiceNameComposeMessage
	{
		get
		{
			if (_SharingServiceNameComposeMessage == null)
			{
				_SharingServiceNameComposeMessage = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameComposeMessage");
			}
			return _SharingServiceNameComposeMessage;
		}
	}

	[Field("NSSharingServiceNamePostImageOnFlickr", "AppKit")]
	public static NSString SharingServiceNamePostImageOnFlickr
	{
		get
		{
			if (_SharingServiceNamePostImageOnFlickr == null)
			{
				_SharingServiceNamePostImageOnFlickr = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostImageOnFlickr");
			}
			return _SharingServiceNamePostImageOnFlickr;
		}
	}

	[Field("NSSharingServiceNamePostOnFacebook", "AppKit")]
	public static NSString SharingServiceNamePostOnFacebook
	{
		get
		{
			if (_SharingServiceNamePostOnFacebook == null)
			{
				_SharingServiceNamePostOnFacebook = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnFacebook");
			}
			return _SharingServiceNamePostOnFacebook;
		}
	}

	[Field("NSSharingServiceNamePostOnSinaWeibo", "AppKit")]
	public static NSString SharingServiceNamePostOnSinaWeibo
	{
		get
		{
			if (_SharingServiceNamePostOnSinaWeibo == null)
			{
				_SharingServiceNamePostOnSinaWeibo = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnSinaWeibo");
			}
			return _SharingServiceNamePostOnSinaWeibo;
		}
	}

	[Field("NSSharingServiceNamePostOnTwitter", "AppKit")]
	public static NSString SharingServiceNamePostOnTwitter
	{
		get
		{
			if (_SharingServiceNamePostOnTwitter == null)
			{
				_SharingServiceNamePostOnTwitter = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnTwitter");
			}
			return _SharingServiceNamePostOnTwitter;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnTudou", "AppKit")]
	public static NSString SharingServiceNamePostVideoOnTudou
	{
		get
		{
			if (_SharingServiceNamePostVideoOnTudou == null)
			{
				_SharingServiceNamePostVideoOnTudou = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnTudou");
			}
			return _SharingServiceNamePostVideoOnTudou;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnVimeo", "AppKit")]
	public static NSString SharingServiceNamePostVideoOnVimeo
	{
		get
		{
			if (_SharingServiceNamePostVideoOnVimeo == null)
			{
				_SharingServiceNamePostVideoOnVimeo = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnVimeo");
			}
			return _SharingServiceNamePostVideoOnVimeo;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnYouku", "AppKit")]
	public static NSString SharingServiceNamePostVideoOnYouku
	{
		get
		{
			if (_SharingServiceNamePostVideoOnYouku == null)
			{
				_SharingServiceNamePostVideoOnYouku = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnYouku");
			}
			return _SharingServiceNamePostVideoOnYouku;
		}
	}

	[Field("NSSharingServiceNameSendViaAirDrop", "AppKit")]
	public static NSString SharingServiceNameSendViaAirDrop
	{
		get
		{
			if (_SharingServiceNameSendViaAirDrop == null)
			{
				_SharingServiceNameSendViaAirDrop = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameSendViaAirDrop");
			}
			return _SharingServiceNameSendViaAirDrop;
		}
	}

	[Field("NSSharingServiceNameUseAsDesktopPicture", "AppKit")]
	public static NSString SharingServiceNameUseAsDesktopPicture
	{
		get
		{
			if (_SharingServiceNameUseAsDesktopPicture == null)
			{
				_SharingServiceNameUseAsDesktopPicture = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameUseAsDesktopPicture");
			}
			return _SharingServiceNameUseAsDesktopPicture;
		}
	}

	[Field("NSSharingServiceNameUseAsTwitterProfileImage", "AppKit")]
	public static NSString SharingServiceNameUseAsTwitterProfileImage
	{
		get
		{
			if (_SharingServiceNameUseAsTwitterProfileImage == null)
			{
				_SharingServiceNameUseAsTwitterProfileImage = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameUseAsTwitterProfileImage");
			}
			return _SharingServiceNameUseAsTwitterProfileImage;
		}
	}
}
