using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSApplicationActivationPolicy : long
{
	Regular,
	Accessory,
	Prohibited
}
