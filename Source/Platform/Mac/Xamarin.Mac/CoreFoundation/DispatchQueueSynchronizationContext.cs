using System;
using System.Threading;

namespace CoreFoundation;

internal sealed class DispatchQueueSynchronizationContext : SynchronizationContext
{
	private readonly DispatchQueue queue;

	public DispatchQueueSynchronizationContext(DispatchQueue dispatchQueue)
	{
		if (dispatchQueue == null)
		{
			throw new ArgumentNullException("dispatchQueue");
		}
		queue = dispatchQueue;
	}

	public override SynchronizationContext CreateCopy()
	{
		return new DispatchQueueSynchronizationContext(queue);
	}

	public override void Post(SendOrPostCallback d, object state)
	{
		queue.DispatchAsync(delegate
		{
			d(state);
		});
	}

	public override void Send(SendOrPostCallback d, object state)
	{
		queue.DispatchSync(delegate
		{
			d(state);
		});
	}
}
