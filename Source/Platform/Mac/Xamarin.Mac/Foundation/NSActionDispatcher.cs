using System;

namespace Foundation;

[Register("__MonoMac_NSActionDispatcher")]
internal sealed class NSActionDispatcher : NSDispatcher
{
	private readonly Action action;

	public NSActionDispatcher(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.action = action;
	}

	public override void Apply()
	{
		action();
	}
}
