using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSConnectionDelegate", false)]
[Model]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
public class NSConnectionDelegate : NSObject, INSConnectionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSConnectionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSConnectionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSConnectionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("makeNewConnection:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowNewConnection(NSConnection newConnection, NSConnection parentConnection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("authenticateComponents:withData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AuthenticateComponents(NSArray components, NSData authenticationData)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("createConversationForConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CreateConversation(NSConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("authenticationDataForComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetAuthenticationData(NSArray components)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:handleRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandleRequest(NSConnection connection, NSDistantObjectRequest request)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:shouldMakeNewConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldMakeNewConnection(NSConnection parentConnection, NSConnection newConnection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
