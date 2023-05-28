using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol]
[Register("CAAction", false)]
[Model]
public abstract class CAAction : NSObject, ICAAction, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CAAction(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAAction(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("runActionForKey:object:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void RunAction(string eventKey, NSObject obj, NSDictionary? arguments);
}
