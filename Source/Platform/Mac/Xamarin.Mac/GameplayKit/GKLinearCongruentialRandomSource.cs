using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKLinearCongruentialRandomSource", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKLinearCongruentialRandomSource : GKRandomSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSeed_ = "initWithSeed:";

	private static readonly IntPtr selInitWithSeed_Handle = Selector.GetHandle("initWithSeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSeed_ = "setSeed:";

	private static readonly IntPtr selSetSeed_Handle = Selector.GetHandle("setSeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKLinearCongruentialRandomSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
		[Export("setSeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKLinearCongruentialRandomSource()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKLinearCongruentialRandomSource(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKLinearCongruentialRandomSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKLinearCongruentialRandomSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSeed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKLinearCongruentialRandomSource(ulong seed)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithSeed_Handle, seed), "initWithSeed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithSeed_Handle, seed), "initWithSeed:");
		}
	}
}
