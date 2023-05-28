using ObjCRuntime;

namespace Foundation;

[Watch(4, 0)]
[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
[Native]
public enum NSLinguisticTaggerUnit : long
{
	Word,
	Sentence,
	Paragraph,
	Document
}
