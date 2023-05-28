using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKFilterCustomUIProviderWrapper : BaseWrapper, IIKFilterCustomUIProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKFilterCustomUIProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("provideViewForUIConfiguration:excludedKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKFilterUIView ProvideFilterUIView(NSDictionary configurationOptions, NSArray? excludedKeys)
	{
		if (configurationOptions == null)
		{
			throw new ArgumentNullException("configurationOptions");
		}
		return Runtime.GetNSObject<IKFilterUIView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("provideViewForUIConfiguration:excludedKeys:"), configurationOptions.Handle, excludedKeys?.Handle ?? IntPtr.Zero));
	}
}
