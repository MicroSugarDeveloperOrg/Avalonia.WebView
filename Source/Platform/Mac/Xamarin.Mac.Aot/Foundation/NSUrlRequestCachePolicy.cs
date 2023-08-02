namespace Foundation;

public enum NSUrlRequestCachePolicy : ulong
{
	UseProtocolCachePolicy = 0uL,
	ReloadIgnoringLocalCacheData = 1uL,
	ReloadIgnoringLocalAndRemoteCacheData = 4uL,
	ReloadIgnoringCacheData = 1uL,
	ReturnCacheDataElseLoad = 2uL,
	ReturnCacheDataDoNotLoad = 3uL,
	ReloadRevalidatingCacheData = 5uL
}
