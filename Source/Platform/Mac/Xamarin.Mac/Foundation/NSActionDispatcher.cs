using System;
using ObjCRuntime;

namespace Foundation;

[Register("__MonoMac_NSActionDispatcher")]
internal sealed class NSActionDispatcher : NSObject
{
	public const string SelectorName = "xamarinApplySelector";

	public static readonly Selector Selector = new Selector("xamarinApplySelector");

	private readonly NSAction action;

	public NSActionDispatcher(NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		this.action = action;
	}

	[Export("xamarinApplySelector")]
	[Preserve(Conditional = true)]
	public void Apply()
	{
		action();
	}
}
