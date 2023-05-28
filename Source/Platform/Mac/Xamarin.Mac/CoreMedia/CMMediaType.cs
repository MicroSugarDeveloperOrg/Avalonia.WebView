using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMMediaType : uint
{
	Video = 1986618469u,
	Audio = 1936684398u,
	Muxed = 1836415096u,
	Text = 1952807028u,
	ClosedCaption = 1668047728u,
	Subtitle = 1935832172u,
	TimeCode = 1953325924u,
	Metadata = 1835365473u
}
