using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNContainerKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Name;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Type;

	[Field("CNContainerIdentifierKey", "Contacts")]
	public static NSString Identifier
	{
		get
		{
			if (_Identifier == null)
			{
				_Identifier = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContainerIdentifierKey");
			}
			return _Identifier;
		}
	}

	[Field("CNContainerNameKey", "Contacts")]
	public static NSString Name
	{
		get
		{
			if (_Name == null)
			{
				_Name = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContainerNameKey");
			}
			return _Name;
		}
	}

	[Field("CNContainerTypeKey", "Contacts")]
	public static NSString Type
	{
		get
		{
			if (_Type == null)
			{
				_Type = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContainerTypeKey");
			}
			return _Type;
		}
	}
}
