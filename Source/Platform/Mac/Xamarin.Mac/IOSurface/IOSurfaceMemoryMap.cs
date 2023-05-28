namespace IOSurface;

public enum IOSurfaceMemoryMap
{
	DefaultCache = 0,
	InhibitCache = 256,
	WriteThruCache = 512,
	CopybackCache = 768,
	WriteCombineCache = 1024,
	CopybackInnerCache = 1280
}
