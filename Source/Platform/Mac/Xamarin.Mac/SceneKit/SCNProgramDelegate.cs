using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Protocol]
[Register("SCNProgramDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class SCNProgramDelegate : NSObject, ISCNProgramDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNProgramDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNProgramDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNProgramDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("program:bindValueForSymbol:atLocation:programID:renderer:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BindValue(SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("program:handleError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleError(SCNProgram program, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("programIsOpaque:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the SCNProgram's Opaque property instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public virtual bool IsProgramOpaque(SCNProgram program)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("program:unbindValueForSymbol:atLocation:programID:renderer:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnbindValue(SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
