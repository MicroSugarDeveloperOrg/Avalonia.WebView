using ObjCRuntime;

namespace CoreImage;

[iOS(11, 0)]
[Mac(10, 13)]
[TV(11, 0)]
[Native]
public enum CIQRCodeErrorCorrectionLevel : long
{
	L = 76L,
	M = 77L,
	Q = 81L,
	H = 72L
}
