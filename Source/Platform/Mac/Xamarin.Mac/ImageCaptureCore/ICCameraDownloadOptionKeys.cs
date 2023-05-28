using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICCameraDownloadOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeleteAfterSuccessfulDownload;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownloadSidecarFiles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DownloadsDirectoryUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Overwrite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SaveAsFilename;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SavedAncillaryFiles;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SavedFilename;

	[Field("ICDeleteAfterSuccessfulDownload", "ImageCaptureCore")]
	public static NSString DeleteAfterSuccessfulDownload
	{
		get
		{
			if (_DeleteAfterSuccessfulDownload == null)
			{
				_DeleteAfterSuccessfulDownload = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDeleteAfterSuccessfulDownload");
			}
			return _DeleteAfterSuccessfulDownload;
		}
	}

	[Field("ICDownloadSidecarFiles", "ImageCaptureCore")]
	public static NSString DownloadSidecarFiles
	{
		get
		{
			if (_DownloadSidecarFiles == null)
			{
				_DownloadSidecarFiles = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDownloadSidecarFiles");
			}
			return _DownloadSidecarFiles;
		}
	}

	[Field("ICDownloadsDirectoryURL", "ImageCaptureCore")]
	public static NSString DownloadsDirectoryUrl
	{
		get
		{
			if (_DownloadsDirectoryUrl == null)
			{
				_DownloadsDirectoryUrl = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICDownloadsDirectoryURL");
			}
			return _DownloadsDirectoryUrl;
		}
	}

	[Field("ICOverwrite", "ImageCaptureCore")]
	public static NSString Overwrite
	{
		get
		{
			if (_Overwrite == null)
			{
				_Overwrite = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICOverwrite");
			}
			return _Overwrite;
		}
	}

	[Field("ICSaveAsFilename", "ImageCaptureCore")]
	public static NSString SaveAsFilename
	{
		get
		{
			if (_SaveAsFilename == null)
			{
				_SaveAsFilename = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICSaveAsFilename");
			}
			return _SaveAsFilename;
		}
	}

	[Field("ICSavedAncillaryFiles", "ImageCaptureCore")]
	public static NSString SavedAncillaryFiles
	{
		get
		{
			if (_SavedAncillaryFiles == null)
			{
				_SavedAncillaryFiles = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICSavedAncillaryFiles");
			}
			return _SavedAncillaryFiles;
		}
	}

	[Field("ICSavedFilename", "ImageCaptureCore")]
	public static NSString SavedFilename
	{
		get
		{
			if (_SavedFilename == null)
			{
				_SavedFilename = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICSavedFilename");
			}
			return _SavedFilename;
		}
	}
}
