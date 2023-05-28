using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AdSupport;

[Register("ASIdentifierManager", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class ASIdentifierManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvertisingIdentifier = "advertisingIdentifier";

	private static readonly IntPtr selAdvertisingIdentifierHandle = Selector.GetHandle("advertisingIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearAdvertisingIdentifier = "clearAdvertisingIdentifier";

	private static readonly IntPtr selClearAdvertisingIdentifierHandle = Selector.GetHandle("clearAdvertisingIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdvertisingTrackingEnabled = "isAdvertisingTrackingEnabled";

	private static readonly IntPtr selIsAdvertisingTrackingEnabledHandle = Selector.GetHandle("isAdvertisingTrackingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedManager = "sharedManager";

	private static readonly IntPtr selSharedManagerHandle = Selector.GetHandle("sharedManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASIdentifierManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUuid AdvertisingIdentifier
	{
		[Export("advertisingIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUuid>(Messaging.IntPtr_objc_msgSend(base.Handle, selAdvertisingIdentifierHandle));
			}
			return Runtime.GetNSObject<NSUuid>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAdvertisingIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAdvertisingTrackingEnabled
	{
		[Export("isAdvertisingTrackingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdvertisingTrackingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdvertisingTrackingEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ASIdentifierManager SharedManager
	{
		[Export("sharedManager")]
		get
		{
			return Runtime.GetNSObject<ASIdentifierManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ASIdentifierManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASIdentifierManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("clearAdvertisingIdentifier")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearAdvertisingIdentifier()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearAdvertisingIdentifierHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearAdvertisingIdentifierHandle);
		}
	}
}
