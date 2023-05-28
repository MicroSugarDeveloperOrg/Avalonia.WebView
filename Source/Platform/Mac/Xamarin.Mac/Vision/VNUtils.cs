using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace Vision;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
public static class VNUtils
{
	[Field("VNNormalizedIdentityRect", "/System/Library/Frameworks/Vision.framework/Vision")]
	public static CGRect NormalizedIdentityRect { get; } = Dlfcn.GetCGRect(Libraries.Vision.Handle, "VNNormalizedIdentityRect");


	[DllImport("/System/Library/Frameworks/Vision.framework/Vision", EntryPoint = "VNNormalizedRectIsIdentityRect")]
	public static extern bool IsIdentityRect(CGRect rect);

	[DllImport("/System/Library/Frameworks/Vision.framework/Vision", EntryPoint = "VNImagePointForNormalizedPoint")]
	public static extern CGPoint GetImagePoint(CGPoint normalizedPoint, nuint imageWidth, nuint imageHeight);

	[DllImport("/System/Library/Frameworks/Vision.framework/Vision", EntryPoint = "VNImageRectForNormalizedRect")]
	public static extern CGRect GetImageRect(CGRect normalizedRect, nuint imageWidth, nuint imageHeight);

	[DllImport("/System/Library/Frameworks/Vision.framework/Vision", EntryPoint = "VNNormalizedRectForImageRect")]
	public static extern CGRect GetNormalizedRect(CGRect imageRect, nuint imageWidth, nuint imageHeight);

	[DllImport("__Internal", EntryPoint = "xamarin_CGPoint__VNNormalizedFaceBoundingBoxPointForLandmarkPoint_Vector2_CGRect_nuint_nuint_string")]
	private static extern CGPoint VNNormalizedFaceBoundingBoxPointForLandmarkPoint(Vector2 faceLandmarkPoint, CGRect faceBoundingBox, nuint imageWidth, nuint imageHeight, out IntPtr error);

	public static CGPoint GetNormalizedFaceBoundingBoxPoint(Vector2 faceLandmarkPoint, CGRect faceBoundingBox, nuint imageWidth, nuint imageHeight)
	{
		IntPtr error;
		CGPoint result = VNNormalizedFaceBoundingBoxPointForLandmarkPoint(faceLandmarkPoint, faceBoundingBox, imageWidth, imageHeight, out error);
		if (error != IntPtr.Zero)
		{
			throw new InvalidOperationException(Marshal.PtrToStringAuto(error));
		}
		return result;
	}

	[DllImport("__Internal", EntryPoint = "xamarin_CGPoint__VNImagePointForFaceLandmarkPoint_Vector2_CGRect_nuint_nuint_string")]
	private static extern CGPoint VNImagePointForFaceLandmarkPoint(Vector2 faceLandmarkPoint, CGRect faceBoundingBox, nuint imageWidth, nuint imageHeight, out IntPtr error);

	public static CGPoint GetImagePoint(Vector2 faceLandmarkPoint, CGRect faceBoundingBox, nuint imageWidth, nuint imageHeight)
	{
		IntPtr error;
		CGPoint result = VNImagePointForFaceLandmarkPoint(faceLandmarkPoint, faceBoundingBox, imageWidth, imageHeight, out error);
		if (error != IntPtr.Zero)
		{
			throw new InvalidOperationException(Marshal.PtrToStringAuto(error));
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Vision.framework/Vision")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern nuint VNElementTypeSize(nuint elementType);

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static nuint GetElementTypeSize(VNElementType elementType)
	{
		return VNElementTypeSize((nuint)(ulong)elementType);
	}
}
