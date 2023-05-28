using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Native]
public enum VNErrorCode : long
{
	Ok,
	RequestCancelled,
	InvalidFormat,
	OperationFailed,
	OutOfBoundsError,
	InvalidOption,
	IOError,
	MissingOption,
	NotImplemented,
	InternalError,
	OutOfMemory,
	UnknownError,
	InvalidOperation,
	InvalidImage,
	InvalidArgument,
	InvalidModel,
	UnsupportedRevision,
	DataUnavailable
}
