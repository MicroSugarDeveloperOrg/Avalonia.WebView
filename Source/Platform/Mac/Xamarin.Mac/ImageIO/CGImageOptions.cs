using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageOptions
{
	private static IntPtr kTypeIdentifierHint;

	private static IntPtr kShouldCache;

	private static IntPtr kShouldAllowFloat;

	public string BestGuessTypeIdentifier { get; set; }

	public bool ShouldCache { get; set; }

	public bool ShouldAllowFloat { get; set; }

	private static void Init()
	{
		if (!(kTypeIdentifierHint != IntPtr.Zero))
		{
			IntPtr handle = Libraries.ImageIO.Handle;
			kTypeIdentifierHint = Dlfcn.GetIntPtr(handle, "kCGImageSourceTypeIdentifierHint");
			kShouldCache = Dlfcn.GetIntPtr(handle, "kCGImageSourceShouldCache");
			kShouldAllowFloat = Dlfcn.GetIntPtr(handle, "kCGImageSourceShouldAllowFloat");
		}
	}

	public CGImageOptions()
	{
		ShouldCache = true;
	}

	internal virtual NSMutableDictionary ToDictionary()
	{
		Init();
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (BestGuessTypeIdentifier != null)
		{
			nSMutableDictionary.LowlevelSetObject(new NSString(BestGuessTypeIdentifier), kTypeIdentifierHint);
		}
		if (!ShouldCache)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.False.Handle, kShouldCache);
		}
		if (ShouldAllowFloat)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, kShouldAllowFloat);
		}
		return nSMutableDictionary;
	}
}
