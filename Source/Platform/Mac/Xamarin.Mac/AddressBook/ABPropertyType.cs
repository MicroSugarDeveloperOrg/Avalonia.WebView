namespace AddressBook;

public enum ABPropertyType : uint
{
	Invalid = 0u,
	String = 1u,
	Integer = 2u,
	Real = 3u,
	DateTime = 4u,
	Dictionary = 5u,
	MultiString = 257u,
	MultiInteger = 258u,
	MultiReal = 259u,
	MultiDateTime = 260u,
	MultiDictionary = 261u
}
