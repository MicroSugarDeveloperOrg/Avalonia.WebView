using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

public class CGImageDestinationOptions
{
	private static IntPtr kLossyCompressionQuality;

	private static IntPtr kBackgroundColor;

	public float? LossyCompressionQuality { get; set; }

	public CGColor DestinationBackgroundColor { get; set; }

	private static void Init()
	{
		if (!(kLossyCompressionQuality != IntPtr.Zero))
		{
			IntPtr handle = Libraries.ImageIO.Handle;
			kLossyCompressionQuality = Dlfcn.GetIntPtr(handle, "kCGImageDestinationLossyCompressionQuality");
			kBackgroundColor = Dlfcn.GetIntPtr(handle, "kCGImageDestinationBackgroundColor");
		}
	}

	internal NSMutableDictionary ToDictionary()
	{
		Init();
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (LossyCompressionQuality.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(new NSNumber(LossyCompressionQuality.Value), kLossyCompressionQuality);
		}
		if (DestinationBackgroundColor != null)
		{
			nSMutableDictionary.LowlevelSetObject(DestinationBackgroundColor.Handle, kBackgroundColor);
		}
		return nSMutableDictionary;
	}
}
