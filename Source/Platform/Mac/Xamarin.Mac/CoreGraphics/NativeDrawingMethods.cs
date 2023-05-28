using System;
using System.Runtime.InteropServices;

namespace CoreGraphics;

internal static class NativeDrawingMethods
{
	internal const string CG = "/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics";

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern bool CGRectMakeWithDictionaryRepresentation(IntPtr dict, out CGRect rect);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern bool CGPointMakeWithDictionaryRepresentation(IntPtr dict, out CGPoint point);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern bool CGSizeMakeWithDictionaryRepresentation(IntPtr dict, out CGSize point);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern IntPtr CGRectCreateDictionaryRepresentation(CGRect rect);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern IntPtr CGSizeCreateDictionaryRepresentation(CGSize size);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreGraphics.framework/CoreGraphics")]
	internal static extern IntPtr CGPointCreateDictionaryRepresentation(CGPoint point);
}
