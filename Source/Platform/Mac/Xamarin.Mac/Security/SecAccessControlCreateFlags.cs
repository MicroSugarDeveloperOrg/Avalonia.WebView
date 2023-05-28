using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Flags]
[Native]
public enum SecAccessControlCreateFlags : long
{
	UserPresence = 1L,
	[Advice("'BiometryAny' is preferred over 'TouchIDAny' since Xcode 9.3. Touch ID and Face ID together are biometric authentication mechanisms.")]
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	TouchIDAny = 2L,
	[Advice("'BiometryCurrentSet' is preferred over 'TouchIDCurrentSet' since Xcode 9.3. Touch ID and Face ID together are biometric authentication mechanisms.")]
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	TouchIDCurrentSet = 8L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	BiometryAny = 2L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	BiometryCurrentSet = 8L,
	[iOS(9, 0)]
	[Mac(10, 11)]
	DevicePasscode = 0x10L,
	[Mac(10, 15)]
	[NoiOS]
	[NoTV]
	[NoWatch]
	Watch = 0x20L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	Or = 0x4000L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	And = 0x8000L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	PrivateKeyUsage = 0x40000000L,
	[iOS(9, 0)]
	[Mac(10, 12, 1)]
	ApplicationPassword = -2147483648L
}
