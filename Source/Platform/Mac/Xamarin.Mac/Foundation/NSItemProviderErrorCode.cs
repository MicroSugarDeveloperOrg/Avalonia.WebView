using ObjCRuntime;

namespace Foundation;

[iOS(8, 0)]
[Mac(10, 10)]
[Native]
public enum NSItemProviderErrorCode : long
{
	Unknown = -1L,
	None = 0L,
	ItemUnavailable = -1000L,
	UnexpectedValueClass = -1100L,
	UnavailableCoercion = -1200L
}
