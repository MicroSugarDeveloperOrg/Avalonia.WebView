namespace AudioToolbox;

public enum AudioFileMarkerType : uint
{
	Generic = 0u,
	CAFProgramStart = 1885496679u,
	CAFProgramEnd = 1885695588u,
	CAFTrackStart = 1952605543u,
	CAFTrackEnd = 1952804436u,
	CAFIndex = 1768842360u,
	CAFRegionStart = 1919051111u,
	CAFRegionEnd = 1919051111u,
	CAFRegionSyncPoint = 1920170339u,
	CAFSelectionStart = 1935828327u,
	CAFSelectionEnd = 1935828327u,
	CAFEditSourceBegin = 1667392871u,
	CAFEditSourceEnd = 1667392871u,
	CAFEditDestinationBegin = 1684170087u,
	CAFEditDestinationEnd = 1684170087u,
	CAFSustainLoopStart = 1936482919u,
	CAFSustainLoopEnd = 1936482917u,
	CAFReleaseLoopStart = 1919705703u,
	CAFReleaseLoopEnd = 1919705701u,
	CAFSavedPlayPosition = 1936747641u,
	CAFTempo = 1953329263u,
	CAFTimeSignature = 1953720679u,
	CAFKeySignature = 1802725735u
}
