using System;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFPageInfo
{
	public CGRect? MediaBox { get; set; }

	public CGRect? CropBox { get; set; }

	public CGRect? BleedBox { get; set; }

	public CGRect? TrimBox { get; set; }

	public CGRect? ArtBox { get; set; }

	[Field("kCGPDFContextArtBox", "CoreGraphics")]
	internal static IntPtr kCGPDFContextArtBox => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextArtBox");

	[Field("kCGPDFContextBleedBox", "CoreGraphics")]
	internal static IntPtr kCGPDFContextBleedBox => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextBleedBox");

	[Field("kCGPDFContextCropBox", "CoreGraphics")]
	internal static IntPtr kCGPDFContextCropBox => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextCropBox");

	[Field("kCGPDFContextMediaBox", "CoreGraphics")]
	internal static IntPtr kCGPDFContextMediaBox => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextMediaBox");

	[Field("kCGPDFContextTrimBox", "CoreGraphics")]
	internal static IntPtr kCGPDFContextTrimBox => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextTrimBox");

	private unsafe static void Add(NSMutableDictionary dict, IntPtr key, CGRect? val)
	{
		if (val.HasValue)
		{
			CGRect value = val.Value;
			CGRect* ptr = &value;
			NSData obj = NSData.FromBytes((IntPtr)ptr, (byte)16);
			dict.LowlevelSetObject(obj, key);
		}
	}

	internal virtual NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		Add(nSMutableDictionary, kCGPDFContextMediaBox, MediaBox);
		Add(nSMutableDictionary, kCGPDFContextCropBox, CropBox);
		Add(nSMutableDictionary, kCGPDFContextBleedBox, BleedBox);
		Add(nSMutableDictionary, kCGPDFContextTrimBox, TrimBox);
		Add(nSMutableDictionary, kCGPDFContextArtBox, ArtBox);
		return nSMutableDictionary;
	}
}
