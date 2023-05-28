using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class INIntentIdentifierExtensions
{
	private static IntPtr[] values = new IntPtr[0];

	public static NSString? GetConstant(this INIntentIdentifier self)
	{
		IntPtr zero = IntPtr.Zero;
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static INIntentIdentifier GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return INIntentIdentifier.None;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
