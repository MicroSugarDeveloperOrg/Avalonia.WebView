using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Protocol]
[Register("SCNShadable", false)]
[Model]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNShadable : NSObject, ISCNShadable, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual SCNProgram? Program
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("program", ArgumentSemantic.Retain)]
		get
		{
			throw new ModelNotImplementedException();
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setProgram:", ArgumentSemantic.Retain)]
		set
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public SCNShaderModifiers? ShaderModifiers
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakShaderModifiers != null) ? new NSMutableDictionary(WeakShaderModifiers) : null);
			return (nSMutableDictionary == null) ? null : new SCNShaderModifiers(nSMutableDictionary);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		set
		{
			WeakShaderModifiers = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSDictionary? WeakShaderModifiers
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("shaderModifiers", ArgumentSemantic.Copy)]
		get
		{
			throw new ModelNotImplementedException();
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setShaderModifiers:", ArgumentSemantic.Copy)]
		set
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNShadable()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNShadable(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNShadable(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("handleBindingOfSymbol:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleBinding(string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("handleUnbindingOfSymbol:usingBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleUnbinding(string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
