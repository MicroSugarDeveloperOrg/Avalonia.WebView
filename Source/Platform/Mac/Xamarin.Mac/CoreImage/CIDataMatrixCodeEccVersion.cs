using ObjCRuntime;

namespace CoreImage;

[iOS(11, 0)]
[Mac(10, 13)]
[TV(11, 0)]
[Native]
public enum CIDataMatrixCodeEccVersion : long
{
	V000 = 0L,
	V050 = 50L,
	V080 = 80L,
	V100 = 100L,
	V140 = 140L,
	V200 = 200L
}
