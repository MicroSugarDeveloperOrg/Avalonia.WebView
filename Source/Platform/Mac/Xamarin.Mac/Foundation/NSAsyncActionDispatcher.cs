using System;
using System.Runtime.InteropServices;

namespace Foundation;

[Register("__MonoMac_NSAsyncActionDispatcher")]
internal class NSAsyncActionDispatcher : NSObject
{
	private GCHandle gch;

	private NSAction action;

	[Obsolete("Do not use, this method is only used internally")]
	public NSAsyncActionDispatcher(IntPtr handle)
		: base(handle)
	{
	}

	public NSAsyncActionDispatcher(NSAction action)
	{
		this.action = action;
		gch = GCHandle.Alloc(this);
	}

	[Export("xamarinApplySelector")]
	[Preserve(Conditional = true)]
	public void Apply()
	{
		try
		{
			action();
		}
		finally
		{
			action = null;
			gch.Free();
		}
	}
}
