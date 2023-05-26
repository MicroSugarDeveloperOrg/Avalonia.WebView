using Foundation;

namespace AudioToolbox;

public class AudioFileInfoDictionary : DictionaryContainer
{
	public string Album => GetStringValue("album");

	public string ApproximateDurationInSeconds => GetStringValue("approximate duration in seconds");

	public string Artist => GetStringValue("artist");

	public string ChannelLayout => GetStringValue("channel layout");

	public string Composer => GetStringValue("composer");

	public string Comments => GetStringValue("comments");

	public string Copyright => GetStringValue("copyright");

	public string EncodingApplication => GetStringValue("encoding application");

	public string Genre => GetStringValue("genre");

	public string ISRC => GetStringValue("ISRC");

	public string KeySignature => GetStringValue("key signature");

	public string Lyricist => GetStringValue("lyricist");

	public string NominalBitRate => GetStringValue("nominal bit rate");

	public string RecordedDate => GetStringValue("recorded date");

	public string SourceBitDepth => GetStringValue("source bit depth");

	public string SourceEncoder => GetStringValue("source encoder");

	public string SubTitle => GetStringValue("subtitle");

	public string Tempo => GetStringValue("tempo");

	public string TimeSignature => GetStringValue("time signature");

	public string Title => GetStringValue("title");

	public string TrackNumber => GetStringValue("track number");

	public string Year => GetStringValue("year");

	internal AudioFileInfoDictionary(NSDictionary dict)
		: base(dict)
	{
	}
}
