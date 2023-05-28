using ObjCRuntime;

namespace Foundation;

[iOS(9, 0)]
[Mac(10, 11)]
[Native]
public enum NSDecodingFailurePolicy : long
{
	RaiseException,
	SetErrorAndReturn
}
