using System;
using Foundation;
using ObjCRuntime;
using SceneKit;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class SCNNode_GameplayKit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntity_ = "setEntity:";

	private static readonly IntPtr selSetEntity_Handle = Selector.GetHandle("setEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("SCNNode");

	[Export("entity")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKEntity? GetEntity(this SCNNode This)
	{
		return Runtime.GetNSObject<GKEntity>(Messaging.IntPtr_objc_msgSend(This.Handle, selEntityHandle));
	}

	[Export("setEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetEntity(this SCNNode This, GKEntity? entity)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetEntity_Handle, entity?.Handle ?? IntPtr.Zero);
	}
}
