using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

public static class MDLObjectContainerComponent_Extensions
{
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLObject GetObject(this IMDLObjectContainerComponent This, nuint index)
	{
		return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_nuint(This.Handle, Selector.GetHandle("objectAtIndexedSubscript:"), index));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCount(this IMDLObjectContainerComponent This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("count"));
	}
}
