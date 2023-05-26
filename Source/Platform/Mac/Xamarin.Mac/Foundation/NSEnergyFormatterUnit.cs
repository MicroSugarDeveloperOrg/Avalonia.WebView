using ObjCRuntime;

namespace Foundation;


[Mac(10, 10)]
[iOS(8, 0)]
[Native]
public enum NSEnergyFormatterUnit : long
{
    Joule = 11L,
    Kilojoule = 14L,
    Calorie = 1793L,
    Kilocalorie = 1794L
}
