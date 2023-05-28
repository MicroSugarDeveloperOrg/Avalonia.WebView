using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLCounterSetWrapper : BaseWrapper, IMTLCounterSet, INativeObject, IDisposable
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLCounter[] Counters
	{
		[Export("counters", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<IMTLCounter>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("counters")));
		}
	}

	[Preserve(Conditional = true)]
	public MTLCounterSetWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
