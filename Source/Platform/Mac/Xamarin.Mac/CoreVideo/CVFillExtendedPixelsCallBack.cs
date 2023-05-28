using System;
using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public delegate bool CVFillExtendedPixelsCallBack(IntPtr pixelBuffer, IntPtr refCon);
