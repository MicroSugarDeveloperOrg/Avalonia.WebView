using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

[iOS(7, 0)]
public class CGImageMetadataEnumerateOptions
{
	public bool Recursive { get; set; }

	[Field("kCGImageMetadataEnumerateRecursively", "ImageIO")]
	internal static IntPtr kCGImageMetadataEnumerateRecursively => Dlfcn.GetIntPtr(Libraries.ImageIO.Handle, "kCGImageMetadataEnumerateRecursively");

	internal NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (Recursive)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, kCGImageMetadataEnumerateRecursively);
		}
		return nSMutableDictionary;
	}
}
