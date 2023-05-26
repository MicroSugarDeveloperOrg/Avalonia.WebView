using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public static class CKShareKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailImageData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Title;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[Field("CKShareThumbnailImageDataKey", "CloudKit")]
	public static NSString ThumbnailImageData
	{
		get
		{
			if (_ThumbnailImageData == null)
			{
				_ThumbnailImageData = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKShareThumbnailImageDataKey");
			}
			return _ThumbnailImageData;
		}
	}

	[Field("CKShareTitleKey", "CloudKit")]
	public static NSString Title
	{
		get
		{
			if (_Title == null)
			{
				_Title = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKShareTitleKey");
			}
			return _Title;
		}
	}

	[Field("CKShareTypeKey", "CloudKit")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.CloudKit.Handle, "CKShareTypeKey");
			}
			return _Type;
		}
	}
}
