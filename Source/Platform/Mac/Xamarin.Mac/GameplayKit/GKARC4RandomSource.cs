using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKARC4RandomSource", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKARC4RandomSource : GKRandomSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDropValuesWithCount_ = "dropValuesWithCount:";

	private static readonly IntPtr selDropValuesWithCount_Handle = Selector.GetHandle("dropValuesWithCount:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKARC4RandomSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Seed
	{
		[Export("seed", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSeedHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSeedHandle));
		}
		[Export("setSeed:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSeed_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSeed_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKARC4RandomSource()
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
	public GKARC4RandomSource(NSCoder coder)
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
	protected GKARC4RandomSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKARC4RandomSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSeed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKARC4RandomSource(NSData seed)
		: base(NSObjectFlag.Empty)
	{
		if (seed == null)
		{
			throw new ArgumentNullException("seed");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSeed_Handle, seed.Handle), "initWithSeed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSeed_Handle, seed.Handle), "initWithSeed:");
		}
	}

	[Export("dropValuesWithCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DropValues(nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selDropValuesWithCount_Handle, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selDropValuesWithCount_Handle, count);
		}
	}
}
