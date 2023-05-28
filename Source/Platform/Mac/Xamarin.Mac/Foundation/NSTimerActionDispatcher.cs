using System;
using ObjCRuntime;

namespace Foundation;

[Register("__Xamarin_NSTimerActionDispatcher")]
internal sealed class NSTimerActionDispatcher : NSObject
{
	public const string SelectorName = "xamarinFireSelector:";

	public static readonly Selector Selector = new Selector("xamarinFireSelector:");

	private readonly Action<NSTimer> action;

	public NSTimerActionDispatcher(Action<NSTimer> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.action = action;
		base.IsDirectBinding = false;
	}

	[Export("xamarinFireSelector:")]
	[Preserve(Conditional = true)]
	public void Fire(NSTimer timer)
	{
		action(timer);
	}
}
