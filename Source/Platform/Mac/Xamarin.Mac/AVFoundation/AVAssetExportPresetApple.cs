using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAssetExportPresetApple
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4V1080pHD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4V480pSD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4V720pHD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4VAppleTV;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4VCellular;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4VWiFi;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M4ViPod;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProRes422Lpcm;

	[Field("AVAssetExportPresetAppleM4V1080pHD", "AVFoundation")]
	public static NSString M4V1080pHD
	{
		get
		{
			if (_M4V1080pHD == null)
			{
				_M4V1080pHD = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4V1080pHD");
			}
			return _M4V1080pHD;
		}
	}

	[Field("AVAssetExportPresetAppleM4V480pSD", "AVFoundation")]
	public static NSString M4V480pSD
	{
		get
		{
			if (_M4V480pSD == null)
			{
				_M4V480pSD = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4V480pSD");
			}
			return _M4V480pSD;
		}
	}

	[Field("AVAssetExportPresetAppleM4V720pHD", "AVFoundation")]
	public static NSString M4V720pHD
	{
		get
		{
			if (_M4V720pHD == null)
			{
				_M4V720pHD = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4V720pHD");
			}
			return _M4V720pHD;
		}
	}

	[Field("AVAssetExportPresetAppleM4VAppleTV", "AVFoundation")]
	public static NSString M4VAppleTV
	{
		get
		{
			if (_M4VAppleTV == null)
			{
				_M4VAppleTV = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4VAppleTV");
			}
			return _M4VAppleTV;
		}
	}

	[Field("AVAssetExportPresetAppleM4VCellular", "AVFoundation")]
	public static NSString M4VCellular
	{
		get
		{
			if (_M4VCellular == null)
			{
				_M4VCellular = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4VCellular");
			}
			return _M4VCellular;
		}
	}

	[Field("AVAssetExportPresetAppleM4VWiFi", "AVFoundation")]
	public static NSString M4VWiFi
	{
		get
		{
			if (_M4VWiFi == null)
			{
				_M4VWiFi = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4VWiFi");
			}
			return _M4VWiFi;
		}
	}

	[Field("AVAssetExportPresetAppleM4ViPod", "AVFoundation")]
	public static NSString M4ViPod
	{
		get
		{
			if (_M4ViPod == null)
			{
				_M4ViPod = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleM4ViPod");
			}
			return _M4ViPod;
		}
	}

	[Field("AVAssetExportPresetAppleProRes422LPCM", "AVFoundation")]
	public static NSString ProRes422Lpcm
	{
		get
		{
			if (_ProRes422Lpcm == null)
			{
				_ProRes422Lpcm = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetExportPresetAppleProRes422LPCM");
			}
			return _ProRes422Lpcm;
		}
	}
}
