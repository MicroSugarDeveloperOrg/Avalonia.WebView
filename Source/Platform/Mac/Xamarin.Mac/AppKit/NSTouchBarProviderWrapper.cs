using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTouchBarProviderWrapper : BaseWrapper, INSTouchBarProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTouchBar? TouchBar
	{
		[Export("touchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("touchBar")));
		}
	}

	[Preserve(Conditional = true)]
	public NSTouchBarProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
