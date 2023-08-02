using System;

namespace AudioToolbox;

[Flags]
public enum AudioFileStreamPropertyFlag
{
	PropertyIsCached = 1,
	CacheProperty = 2
}
