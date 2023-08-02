using System;

namespace ObjCRuntime;

public class SinceAttribute : Attribute
{
	public byte Major;

	public byte Minor;

	public SinceAttribute(byte major, byte minor)
	{
		Major = major;
		Minor = minor;
	}
}
