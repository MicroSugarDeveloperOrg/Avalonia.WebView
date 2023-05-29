using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("__monomac_internal_ActionDispatcher")]
internal class ActionDispatcher : NSObject
{
	private const string skey = "__monomac_internal_ActionDispatcher_activated:";

	private const string dkey = "__monomac_internal_ActionDispatcher_doubleActivated:";

	public static Selector Action = new Selector("__monomac_internal_ActionDispatcher_activated:");

	public static Selector DoubleAction = new Selector("__monomac_internal_ActionDispatcher_doubleActivated:");

	public EventHandler Activated;

	public EventHandler DoubleActivated;

	[Preserve]
	[Export("__monomac_internal_ActionDispatcher_activated:")]
	public void OnActivated(NSObject sender)
	{
		Activated?.Invoke(sender, EventArgs.Empty);
	}

	[Preserve]
	[Export("__monomac_internal_ActionDispatcher_doubleActivated:")]
	public void OnActivated2(NSObject sender)
	{
		DoubleActivated?.Invoke(sender, EventArgs.Empty);
	}

	public ActionDispatcher(EventHandler handler)
	{
		Activated = handler;
	}

	public ActionDispatcher()
	{
	}

	public static NSObject SetupAction(NSObject target, EventHandler handler)
	{
		ActionDispatcher actionDispatcher = target as ActionDispatcher;
		if (actionDispatcher == null)
		{
			actionDispatcher = new ActionDispatcher();
			ActionDispatcher actionDispatcher2 = actionDispatcher;
			actionDispatcher2.Activated = (EventHandler)Delegate.Combine(actionDispatcher2.Activated, handler);
		}
		return actionDispatcher;
	}

	public static void RemoveAction(NSObject target, EventHandler handler)
	{
		if (target is ActionDispatcher actionDispatcher)
		{
			actionDispatcher.Activated = (EventHandler)Delegate.Remove(actionDispatcher.Activated, handler);
		}
	}

	public static NSObject SetupDoubleAction(NSObject target, EventHandler doubleHandler)
	{
		ActionDispatcher actionDispatcher = target as ActionDispatcher;
		if (actionDispatcher == null)
		{
			actionDispatcher = new ActionDispatcher();
			ActionDispatcher actionDispatcher2 = actionDispatcher;
			actionDispatcher2.DoubleActivated = (EventHandler)Delegate.Combine(actionDispatcher2.DoubleActivated, doubleHandler);
		}
		return actionDispatcher;
	}

	public static void RemoveDoubleAction(NSObject target, EventHandler doubleHandler)
	{
		if (target is ActionDispatcher actionDispatcher)
		{
			actionDispatcher.DoubleActivated = (EventHandler)Delegate.Remove(actionDispatcher.DoubleActivated, doubleHandler);
		}
	}
}
