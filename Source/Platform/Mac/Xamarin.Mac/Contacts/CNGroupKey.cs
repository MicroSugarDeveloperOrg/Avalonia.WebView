using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNGroupKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[Field("CNGroupIdentifierKey", "Contacts")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNGroupIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("CNGroupNameKey", "Contacts")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNGroupNameKey");
			}
			return _Name;
		}
	}
}
