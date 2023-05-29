using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterOutputKey
{
	private static NSString _Image;

	[Field("kCIOutputImageKey", "Quartz")]
	public static NSString Image
	{
		get
		{
			if (_Image == null)
			{
				_Image = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIOutputImageKey");
			}
			return _Image;
		}
	}
}
