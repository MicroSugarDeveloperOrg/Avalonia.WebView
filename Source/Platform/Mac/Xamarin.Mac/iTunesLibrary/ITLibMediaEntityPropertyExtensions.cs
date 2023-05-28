using System;
using Foundation;
using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ITLibMediaEntityPropertyExtensions
{
	private static IntPtr[] values = new IntPtr[1];

	[Field("ITLibMediaEntityPropertyPersistentID", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaEntityPropertyPersistentID
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaEntityPropertyPersistentID", storage);
			}
		}
	}

	public static NSString? GetConstant(this ITLibMediaEntityProperty self)
	{
		IntPtr ptr = IntPtr.Zero;
		if (self == ITLibMediaEntityProperty.PersistentId)
		{
			ptr = ITLibMediaEntityPropertyPersistentID;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static ITLibMediaEntityProperty GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ITLibMediaEntityPropertyPersistentID))
		{
			return ITLibMediaEntityProperty.PersistentId;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
