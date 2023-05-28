using System;

namespace Foundation;

public enum NSCalendarType
{
	Gregorian = 0,
	Buddhist = 1,
	Chinese = 2,
	Hebrew = 3,
	Islamic = 4,
	IslamicCivil = 5,
	Japanese = 6,
	[Obsolete]
	RepublicOfChina = 7,
	Persian = 8,
	Indian = 9,
	ISO8601 = 10,
	Coptic = 11,
	EthiopicAmeteAlem = 12,
	EthiopicAmeteMihret = 13,
	[Mac(10, 10)]
	[iOS(8, 0)]
	IslamicTabular = 14,
	[Mac(10, 10)]
	[iOS(8, 0)]
	IslamicUmmAlQura = 15,
	Taiwan = 7
}
