using System;
using ObjCRuntime;

namespace CoreMedia;

[iOS(7, 1)]
[Watch(6, 0)]
public delegate nint CMBufferGetSize(INativeObject buffer);
