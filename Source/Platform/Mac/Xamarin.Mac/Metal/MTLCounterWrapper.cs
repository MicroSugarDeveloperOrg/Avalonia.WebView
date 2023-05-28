using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLCounterWrapper : BaseWrapper, IMTLCounter, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
	}

	[Preserve(Conditional = true)]
	public MTLCounterWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
