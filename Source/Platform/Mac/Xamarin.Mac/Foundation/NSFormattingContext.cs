using ObjCRuntime;

namespace Foundation;

[Native]
[Mac(10, 10)]
[iOS(8, 0)]
public enum NSFormattingContext : long
{
	Unknown,
	Dynamic,
	Standalone,
	ListItem,
	BeginningOfSentence,
	MiddleOfSentence
}
