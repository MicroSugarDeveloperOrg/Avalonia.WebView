using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBAttribute", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CBAttribute : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUUID = "UUID";

	private static readonly IntPtr selUUIDHandle = Selector.GetHandle("UUID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBAttribute");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CBUUID UUID
	{
		[Export("UUID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CBUUID>(Messaging.IntPtr_objc_msgSend(base.Handle, selUUIDHandle));
			}
			return Runtime.GetNSObject<CBUUID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUUIDHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CBAttribute()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBAttribute(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBAttribute(IntPtr handle)
		: base(handle)
	{
	}
}
