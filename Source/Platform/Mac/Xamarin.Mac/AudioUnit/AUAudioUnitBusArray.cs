using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[Register("AUAudioUnitBusArray", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AUAudioUnitBusArray : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserverToAllBusses_ForKeyPath_Options_Context_ = "addObserverToAllBusses:forKeyPath:options:context:";

	private static readonly IntPtr selAddObserverToAllBusses_ForKeyPath_Options_Context_Handle = Selector.GetHandle("addObserverToAllBusses:forKeyPath:options:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBusType = "busType";

	private static readonly IntPtr selBusTypeHandle = Selector.GetHandle("busType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioUnit_BusType_ = "initWithAudioUnit:busType:";

	private static readonly IntPtr selInitWithAudioUnit_BusType_Handle = Selector.GetHandle("initWithAudioUnit:busType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAudioUnit_BusType_Busses_ = "initWithAudioUnit:busType:busses:";

	private static readonly IntPtr selInitWithAudioUnit_BusType_Busses_Handle = Selector.GetHandle("initWithAudioUnit:busType:busses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCountChangeable = "isCountChangeable";

	private static readonly IntPtr selIsCountChangeableHandle = Selector.GetHandle("isCountChangeable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwnerAudioUnit = "ownerAudioUnit";

	private static readonly IntPtr selOwnerAudioUnitHandle = Selector.GetHandle("ownerAudioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserverFromAllBusses_ForKeyPath_Context_ = "removeObserverFromAllBusses:forKeyPath:context:";

	private static readonly IntPtr selRemoveObserverFromAllBusses_ForKeyPath_Context_Handle = Selector.GetHandle("removeObserverFromAllBusses:forKeyPath:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceBusses_ = "replaceBusses:";

	private static readonly IntPtr selReplaceBusses_Handle = Selector.GetHandle("replaceBusses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBusCount_Error_ = "setBusCount:error:";

	private static readonly IntPtr selSetBusCount_Error_Handle = Selector.GetHandle("setBusCount:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUAudioUnitBusArray");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_OwnerAudioUnit_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitBusType BusType
	{
		[Export("busType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AUAudioUnitBusType)Messaging.Int64_objc_msgSend(base.Handle, selBusTypeHandle);
			}
			return (AUAudioUnitBusType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBusTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CountChangeable
	{
		[Export("isCountChangeable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCountChangeableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCountChangeableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnit OwnerAudioUnit
	{
		[Export("ownerAudioUnit", ArgumentSemantic.Assign)]
		get
		{
			AUAudioUnit aUAudioUnit = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerAudioUnitHandle)) : Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerAudioUnitHandle)));
			MarkDirty();
			__mt_OwnerAudioUnit_var = aUAudioUnit;
			return aUAudioUnit;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AUAudioUnitBusArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUAudioUnitBusArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAudioUnit:busType:busses:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUAudioUnitBusArray(AUAudioUnit owner, AUAudioUnitBusType busType, AUAudioUnitBus[] busArray)
		: base(NSObjectFlag.Empty)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (busArray == null)
		{
			throw new ArgumentNullException("busArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(busArray);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selInitWithAudioUnit_BusType_Busses_Handle, owner.Handle, (long)busType, nSArray.Handle), "initWithAudioUnit:busType:busses:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selInitWithAudioUnit_BusType_Busses_Handle, owner.Handle, (long)busType, nSArray.Handle), "initWithAudioUnit:busType:busses:");
		}
		nSArray.Dispose();
	}

	[Export("initWithAudioUnit:busType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUAudioUnitBusArray(AUAudioUnit owner, AUAudioUnitBusType busType)
		: base(NSObjectFlag.Empty)
	{
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selInitWithAudioUnit_BusType_Handle, owner.Handle, (long)busType), "initWithAudioUnit:busType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInitWithAudioUnit_BusType_Handle, owner.Handle, (long)busType), "initWithAudioUnit:busType:");
		}
	}

	[Export("addObserverToAllBusses:forKeyPath:options:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void AddObserver(NSObject observer, string keyPath, NSKeyValueObservingOptions options, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selAddObserverToAllBusses_ForKeyPath_Options_Context_Handle, observer.Handle, arg, (ulong)options, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selAddObserverToAllBusses_ForKeyPath_Options_Context_Handle, observer.Handle, arg, (ulong)options, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUAudioUnitBus GetObject(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AUAudioUnitBus>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, index));
		}
		return Runtime.GetNSObject<AUAudioUnitBus>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, index));
	}

	[Export("removeObserverFromAllBusses:forKeyPath:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void RemoveObserver(NSObject observer, string keyPath, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserverFromAllBusses_ForKeyPath_Context_Handle, observer.Handle, arg, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserverFromAllBusses_ForKeyPath_Context_Handle, observer.Handle, arg, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceBusses:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceBusses(AUAudioUnitBus[] busArray)
	{
		if (busArray == null)
		{
			throw new ArgumentNullException("busArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(busArray);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceBusses_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceBusses_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setBusCount:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetBusCount(nuint count, out NSError? outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_nuint_ref_IntPtr(base.SuperHandle, selSetBusCount_Error_Handle, count, ref arg) : Messaging.bool_objc_msgSend_nuint_ref_IntPtr(base.Handle, selSetBusCount_Error_Handle, count, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OwnerAudioUnit_var = null;
		}
	}
}
