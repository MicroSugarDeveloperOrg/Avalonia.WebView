using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Protocol]
[Register("SCNSceneRendererDelegate", false)]
[Model]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNSceneRendererDelegate : NSObject, ISCNSceneRendererDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNSceneRendererDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNSceneRendererDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNSceneRendererDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("renderer:didApplyAnimationsAtTime:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidApplyAnimations(ISCNSceneRenderer renderer, double timeInSeconds)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("renderer:didApplyConstraintsAtTime:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidApplyConstraints(ISCNSceneRenderer renderer, double atTime)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("renderer:didRenderScene:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRenderScene(ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("renderer:didSimulatePhysicsAtTime:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSimulatePhysics(ISCNSceneRenderer renderer, double timeInSeconds)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("renderer:updateAtTime:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(ISCNSceneRenderer renderer, double timeInSeconds)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("renderer:willRenderScene:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillRenderScene(ISCNSceneRenderer renderer, SCNScene scene, double timeInSeconds)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
