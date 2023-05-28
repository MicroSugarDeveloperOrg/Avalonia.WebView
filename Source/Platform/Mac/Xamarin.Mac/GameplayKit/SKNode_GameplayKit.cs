using System;
using Foundation;
using ObjCRuntime;
using SpriteKit;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public static class SKNode_GameplayKit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntity = "entity";

	private static readonly IntPtr selEntityHandle = Selector.GetHandle("entity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntity_ = "setEntity:";

	private static readonly IntPtr selSetEntity_Handle = Selector.GetHandle("setEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("SKNode");

	[Export("entity")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKEntity? GetEntity(this SKNode This)
	{
		return Runtime.GetNSObject<GKEntity>(Messaging.IntPtr_objc_msgSend(This.Handle, selEntityHandle));
	}

	[Export("setEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetEntity(this SKNode This, GKEntity? entity)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetEntity_Handle, entity?.Handle ?? IntPtr.Zero);
	}
}
