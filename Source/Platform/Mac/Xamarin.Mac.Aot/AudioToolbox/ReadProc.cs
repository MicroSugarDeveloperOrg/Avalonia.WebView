using System;

namespace AudioToolbox;

internal delegate int ReadProc(IntPtr clientData, long position, int requestCount, IntPtr buffer, out int actualCount);
