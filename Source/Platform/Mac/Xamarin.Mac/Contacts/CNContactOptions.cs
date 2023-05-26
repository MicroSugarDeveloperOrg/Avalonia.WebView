using System;

namespace Contacts;

[iOS(9, 0)]
[Mac(10, 11)]
[Flags]
public enum CNContactOptions : long
{
	None = 0L,
	Nickname = 1L,
	PhoneticGivenName = 2L,
	PhoneticMiddleName = 4L,
	PhoneticFamilyName = 8L,
	OrganizationName = 0x10L,
	DepartmentName = 0x20L,
	JobTitle = 0x40L,
	Birthday = 0x80L,
	NonGregorianBirthday = 0x100L,
	Note = 0x200L,
	ThumbnailImageData = 0x800L,
	Type = 0x2000L,
	PhoneNumbers = 0x4000L,
	EmailAddresses = 0x8000L,
	PostalAddresses = 0x10000L,
	Dates = 0x20000L,
	UrlAddresses = 0x40000L,
	Relations = 0x80000L,
	SocialProfiles = 0x100000L,
	InstantMessageAddresses = 0x200000L
}
