using System;
using ObjCRuntime;

namespace Foundation;

[Mac(10, 11)]
[iOS(9, 0)]
[Native]
[Flags]
public enum NSPersonNameComponentsFormatterOptions : ulong
{
	Phonetic = 2uL
}
