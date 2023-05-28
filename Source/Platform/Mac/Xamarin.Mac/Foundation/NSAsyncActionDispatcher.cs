using System;

namespace Foundation;

[Register("__MonoMac_NSAsyncActionDispatcher")]
internal sealed class NSAsyncActionDispatcher : NSAsyncDispatcher
{
	private Action action;

	public NSAsyncActionDispatcher(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.action = action;
	}

	public override void Apply()
	{
		try
		{
			action();
		}
		finally
		{
			action = null;
			base.Apply();
		}
	}
}
