using System;

namespace CoreVideo;

public struct CVFillExtendedPixelsCallBackData
{
	public int Version;

	public CVFillExtendedPixelsCallBack FillCallBack;

	public IntPtr UserInfo;
}
