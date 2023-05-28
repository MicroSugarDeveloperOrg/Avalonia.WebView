using IOSurface;
using ObjCRuntime;

namespace CoreImage;

public static class CIImageProcessorOutput_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static global::IOSurface.IOSurface GetSurface(this ICIImageProcessorOutput This)
	{
		return Runtime.GetNSObject<global::IOSurface.IOSurface>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("surface")));
	}
}
