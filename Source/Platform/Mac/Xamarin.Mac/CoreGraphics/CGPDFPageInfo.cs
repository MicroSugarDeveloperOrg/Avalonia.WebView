using System;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFPageInfo
{
	private static IntPtr kCGPDFContextMediaBox;

	private static IntPtr kCGPDFContextCropBox;

	private static IntPtr kCGPDFContextBleedBox;

	private static IntPtr kCGPDFContextTrimBox;

	private static IntPtr kCGPDFContextArtBox;

	public CGRect? MediaBox { get; set; }

	public CGRect? CropBox { get; set; }

	public CGRect? BleedBox { get; set; }

	public CGRect? TrimBox { get; set; }

	public CGRect? ArtBox { get; set; }

	static CGPDFPageInfo()
	{
		IntPtr handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", 0);
		try
		{
			kCGPDFContextMediaBox = Dlfcn.GetIndirect(handle, "kCGPDFContextMediaBox");
			kCGPDFContextCropBox = Dlfcn.GetIndirect(handle, "kCGPDFContextCropBox");
			kCGPDFContextBleedBox = Dlfcn.GetIndirect(handle, "kCGPDFContextBleedBox");
			kCGPDFContextTrimBox = Dlfcn.GetIndirect(handle, "kCGPDFContextTrimBox");
			kCGPDFContextArtBox = Dlfcn.GetIndirect(handle, "kCGPDFContextArtBox");
		}
		finally
		{
			Dlfcn.dlclose(handle);
		}
	}

	private unsafe static void Add(NSMutableDictionary dict, IntPtr key, CGRect? val)
	{
		if (val.HasValue)
		{
			CGRect value = val.Value;
			NSData obj = NSData.FromBytes((IntPtr)(&value), 16uL);
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
