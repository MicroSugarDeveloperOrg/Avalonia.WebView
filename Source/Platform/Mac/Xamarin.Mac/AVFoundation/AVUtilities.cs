using System.Runtime.InteropServices;
using CoreGraphics;

namespace AVFoundation;

public static class AVUtilities
{
	[DllImport("/System/Library/Frameworks/AVFoundation.framework/AVFoundation")]
	private static extern CGRect AVMakeRectWithAspectRatioInsideRect(CGSize aspectRatio, CGRect boundingRect);

	public static CGRect WithAspectRatio(this CGRect self, CGSize aspectRatio)
	{
		return AVMakeRectWithAspectRatioInsideRect(aspectRatio, self);
	}
}
