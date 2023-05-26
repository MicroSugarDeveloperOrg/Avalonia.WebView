using System;

namespace AudioToolbox;

[Flags]
public enum AudioFilePermission
{
	Read = 1,
	Write = 2,
	ReadWrite = 3
}
