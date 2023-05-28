using ObjCRuntime;

namespace AudioToolbox;

public enum AudioFileType
{
	AIFF = 1095321158,
	AIFC = 1095321155,
	WAVE = 1463899717,
	[NoWatch]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	RF64 = 1380333108,
	SoundDesigner2 = 1399075430,
	Next = 1315264596,
	MP3 = 1297106739,
	MP2 = 1297106738,
	MP1 = 1297106737,
	AC3 = 1633889587,
	AAC_ADTS = 1633973363,
	MPEG4 = 1836069990,
	M4A = 1832149350,
	M4B = 1832149606,
	CAF = 1667327590,
	ThreeGP = 862417008,
	ThreeGP2 = 862416946,
	AMR = 1634562662,
	[NoWatch]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	FLAC = 1718378851,
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[NoWatch]
	[iOS(13, 0)]
	[Mac(10, 15)]
	[TV(13, 0)]
	LatmInLoas = 1819238771
}
