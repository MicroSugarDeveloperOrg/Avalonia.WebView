using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLook;

public static class QLThumbnailImage
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionIconModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OptionScaleFactorKey;

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

	[DllImport("/System/Library/Frameworks/QuickLook.framework/QuickLook")]
	private static extern IntPtr QLThumbnailImageCreate(IntPtr allocator, IntPtr url, CGSize maxThumbnailSize, IntPtr options);

	public static CGImage Create(NSUrl url, CGSize maxThumbnailSize, float scaleFactor = 1f, bool iconMode = false)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		NSMutableDictionary nSMutableDictionary = null;
		if (scaleFactor != 1f && iconMode)
		{
			nSMutableDictionary = new NSMutableDictionary();
			nSMutableDictionary.LowlevelSetObject((NSNumber)scaleFactor, OptionScaleFactorKey.Handle);
			nSMutableDictionary.LowlevelSetObject(iconMode ? CFBoolean.TrueHandle : CFBoolean.FalseHandle, OptionIconModeKey.Handle);
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
