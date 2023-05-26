using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCGamepadSnapshot", true)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCGamepadSnapshot : GCGamepad
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithController_SnapshotData_ = "initWithController:snapshotData:";

	private static readonly IntPtr selInitWithController_SnapshotData_Handle = Selector.GetHandle("initWithController:snapshotData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSnapshotData_ = "initWithSnapshotData:";

	private static readonly IntPtr selInitWithSnapshotData_Handle = Selector.GetHandle("initWithSnapshotData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSnapshotData_ = "setSnapshotData:";

	private static readonly IntPtr selSetSnapshotData_Handle = Selector.GetHandle("setSnapshotData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSnapshotData = "snapshotData";

	private static readonly IntPtr selSnapshotDataHandle = Selector.GetHandle("snapshotData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCGamepadSnapshot");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData SnapshotData
	{
		[Export("snapshotData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selSnapshotDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSnapshotDataHandle));
		}
		[Export("setSnapshotData:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSnapshotData_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSnapshotData_Handle, value.Handle);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCExtendedGamepad' instead.")]
	private static extern bool GCGamepadSnapShotDataV100FromNSData(out GCGamepadSnapShotDataV100 snapshotData, IntPtr data);

	public static bool TryGetSnapshotData(NSData data, out GCGamepadSnapShotDataV100 snapshotData)
	{
		return GCGamepadSnapShotDataV100FromNSData(out snapshotData, data?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCGamepadSnapshot(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCGamepadSnapshot(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSnapshotData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GCGamepadSnapshot(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSnapshotData_Handle, data.Handle), "initWithSnapshotData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSnapshotData_Handle, data.Handle), "initWithSnapshotData:");
		}
	}

	[Export("initWithController:snapshotData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GCGamepadSnapshot(GCController controller, NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (controller == null)
		{
			throw new ArgumentNullException("controller");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithController_SnapshotData_Handle, controller.Handle, data.Handle), "initWithController:snapshotData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithController_SnapshotData_Handle, controller.Handle, data.Handle), "initWithController:snapshotData:");
		}
	}
}
