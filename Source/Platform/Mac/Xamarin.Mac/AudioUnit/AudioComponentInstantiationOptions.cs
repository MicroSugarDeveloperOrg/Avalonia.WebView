namespace AudioUnit;

[iOS(9, 0)]
[Mac(10, 11)]
public enum AudioComponentInstantiationOptions : uint
{
	OutOfProcess = 1u,
	InProcess
}
