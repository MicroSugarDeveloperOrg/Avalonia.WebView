using ObjCRuntime;

namespace VideoToolbox;

public enum VTProfileLevel
{
	Unset,
	H264Baseline13,
	H264Baseline30,
	H264Baseline31,
	H264Baseline32,
	H264Baseline40,
	H264Baseline41,
	H264Baseline42,
	H264Baseline50,
	H264Baseline51,
	H264Baseline52,
	H264BaselineAutoLevel,
	H264Main30,
	H264Main31,
	H264Main32,
	H264Main40,
	H264Main41,
	H264Main42,
	H264Main50,
	H264Main51,
	H264Main52,
	H264MainAutoLevel,
	H264Extended50,
	H264ExtendedAutoLevel,
	H264High30,
	H264High31,
	H264High32,
	H264High40,
	H264High41,
	H264High42,
	H264High50,
	H264High51,
	H264High52,
	H264HighAutoLevel,
	MP4VSimpleL0,
	MP4VSimpleL1,
	MP4VSimpleL2,
	MP4VSimpleL3,
	MP4VMainL2,
	MP4VMainL3,
	MP4VMainL4,
	MP4VAdvancedSimpleL0,
	MP4VAdvancedSimpleL1,
	MP4VAdvancedSimpleL2,
	MP4VAdvancedSimpleL3,
	MP4VAdvancedSimpleL4,
	H263Profile0Level10,
	H263Profile0Level45,
	H263Profile3Level45,
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	HevcMainAutoLevel,
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	HevcMain10AutoLevel
}
