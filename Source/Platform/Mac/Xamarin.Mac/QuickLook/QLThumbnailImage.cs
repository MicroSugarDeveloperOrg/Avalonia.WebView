using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLook;

public static class QLThumbnailImage
{
	private static NSString _OptionScaleFactorKey;

	private static NSString _OptionIconModeKey;

	[Field("kQLThumbnailOptionScaleFactorKey", "QuickLook")]
	internal static NSString OptionScaleFactorKey
	{
		get
		{
			if (_OptionScaleFactorKey == null)
			{
				_OptionScaleFactorKey = Dlfcn.GetStringConstant(Libraries.QuickLook.Handle, "kQLThumbnailOptionScaleFactorKey");
			}
			return _OptionScaleFactorKey;
		}
	}

	[Field("kQLThumbnailOptionIconModeKey", "QuickLook")]
	internal static NSString OptionIconModeKey
	{
		get
		{
			if (_OptionIconModeKey == null)
			{
				_OptionIconModeKey = Dlfcn.GetStringConstant(Libraries.QuickLook.Handle, "kQLThumbnailOptionIconModeKey");
			}
			return _OptionIconModeKey;
		}
	}

	[DllImport("/System/Library/Frameworks/QuickLook.framework/QuickLook")]
	private static extern IntPtr QLThumbnailImageCreate(IntPtr allocator, IntPtr url, CGSize maxThumbnailSize, IntPtr options);

	public static CGImage Create(NSUrl url, CGSize maxThumbnailSize, double scaleFactor = 1.0, bool iconMode = false)
	{
		NSMutableDictionary nSMutableDictionary = null;
		if (scaleFactor != 1.0 && iconMode)
		{
			nSMutableDictionary = new NSMutableDictionary();
			nSMutableDictionary.LowlevelSetObject((NSNumber)scaleFactor, OptionScaleFactorKey.Handle);
			nSMutableDictionary.LowlevelSetObject(iconMode ? CFBoolean.True.Handle : CFBoolean.False.Handle, OptionIconModeKey.Handle);
		}
		IntPtr intPtr = QLThumbnailImageCreate(IntPtr.Zero, url.Handle, maxThumbnailSize, nSMutableDictionary?.Handle ?? IntPtr.Zero);
		GC.KeepAlive(nSMutableDictionary);
		if (intPtr != IntPtr.Zero)
		{
			return new CGImage(intPtr, owns: true);
		}
		return null;
	}
}
