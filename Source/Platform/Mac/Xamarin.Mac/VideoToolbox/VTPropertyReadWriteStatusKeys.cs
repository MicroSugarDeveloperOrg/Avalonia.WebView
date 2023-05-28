using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTPropertyReadWriteStatusKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadWrite;

	[Field("kVTPropertyReadWriteStatus_ReadOnly", "VideoToolbox")]
	public static NSString ReadOnly
	{
		get
		{
			if (_ReadOnly == null)
			{
				_ReadOnly = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatus_ReadOnly");
			}
			return _ReadOnly;
		}
	}

	[Field("kVTPropertyReadWriteStatus_ReadWrite", "VideoToolbox")]
	public static NSString ReadWrite
	{
		get
		{
			if (_ReadWrite == null)
			{
				_ReadWrite = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTPropertyReadWriteStatus_ReadWrite");
			}
			return _ReadWrite;
		}
	}
}
