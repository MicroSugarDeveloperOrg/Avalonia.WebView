using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Protocol]
[Register("SKSceneDelegate", false)]
[Model]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SKSceneDelegate : NSObject, ISKSceneDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKSceneDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKSceneDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKSceneDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("didApplyConstraintsForScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidApplyConstraints(SKScene scene)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didEvaluateActionsForScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEvaluateActions(SKScene scene)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didFinishUpdateForScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishUpdate(SKScene scene)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didSimulatePhysicsForScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSimulatePhysics(SKScene scene)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("update:forScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double currentTime, SKScene scene)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
