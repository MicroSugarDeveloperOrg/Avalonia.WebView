using ObjCRuntime;

namespace Foundation;

[iOS(8, 0)]
[Mac(10, 10)]
[Native]
public enum NSLengthFormatterUnit : long
{
    Millimeter = 8L,
    Centimeter = 9L,
    Meter = 11L,
    Kilometer = 14L,
    Inch = 1281L,
    Foot = 1282L,
    Yard = 1283L,
    Mile = 1284L
}
