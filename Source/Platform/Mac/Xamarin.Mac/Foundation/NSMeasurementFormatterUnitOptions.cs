using System;
using ObjCRuntime;

namespace Foundation;

[Watch(3, 0)]
[TV(10, 0)]
[Mac(10, 12)]
[iOS(10, 0)]
[Native]
[Flags]
public enum NSMeasurementFormatterUnitOptions : ulong
{
	ProvidedUnit = 1uL,
	NaturalScale = 2uL,
	TemperatureWithoutUnit = 4uL
}
