using System;
using System.Threading;

namespace Foundation;

[Register("__MonoMac_NSSynchronizationContextDispatcher")]
internal sealed class NSSynchronizationContextDispatcher : NSDispatcher
{
	private readonly SendOrPostCallback d;

	private readonly object state;

	public NSSynchronizationContextDispatcher(SendOrPostCallback d, object state)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		this.d = d;
		this.state = state;
	}

	public override void Apply()
	{
		d(state);
	}
}
