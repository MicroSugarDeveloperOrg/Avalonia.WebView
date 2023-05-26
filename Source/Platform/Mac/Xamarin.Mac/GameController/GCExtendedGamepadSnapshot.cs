using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCExtendedGamepadSnapshot", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
public class GCExtendedGamepadSnapshot : GCExtendedGamepad
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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCExtendedGamepadSnapshot");

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

	[Field("GCCurrentExtendedGamepadSnapshotDataVersion", "GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	public static GCExtendedGamepadSnapshotDataVersion DataVersion
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		get
		{
			return (GCExtendedGamepadSnapshotDataVersion)(long)Dlfcn.GetNInt(Libraries.GameController.Handle, "GCCurrentExtendedGamepadSnapshotDataVersion");
		}
	}

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	private static extern bool GCExtendedGamepadSnapShotDataV100FromNSData(out GCExtendedGamepadSnapShotDataV100 snapshotData, IntPtr data);

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetExtendedGamepadController()' instead.")]
	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private static extern bool GCExtendedGamepadSnapshotDataFromNSData(out GCExtendedGamepadSnapshotData snapshotData, IntPtr data);

	[Deprecated(PlatformName.iOS, 12, 2, PlatformArchitecture.None, "Use 'TryGetExtendedSnapShotData' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.None, "Use 'TryGetExtendedSnapShotData' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 2, PlatformArchitecture.None, "Use 'TryGetExtendedSnapShotData' instead.")]
	public static bool TryGetSnapShotData(NSData data, out GCExtendedGamepadSnapShotDataV100 snapshotData)
	{
		return GCExtendedGamepadSnapShotDataV100FromNSData(out snapshotData, data?.Handle ?? IntPtr.Zero);
	}

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	public static bool TryGetExtendedSnapShotData(NSData data, out GCExtendedGamepadSnapshotData snapshotData)
	{
		return GCExtendedGamepadSnapshotDataFromNSData(out snapshotData, data?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GCExtendedGamepadSnapshot(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCExtendedGamepadSnapshot(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSnapshotData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GCExtendedGamepadSnapshot(NSData data)
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
	public GCExtendedGamepadSnapshot(GCController controller, NSData data)
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
