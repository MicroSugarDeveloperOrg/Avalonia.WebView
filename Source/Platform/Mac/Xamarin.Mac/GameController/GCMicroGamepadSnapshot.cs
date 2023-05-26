using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace GameController;

[Register("GCMicroGamepadSnapshot", true)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.Capture()' instead.")]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
public class GCMicroGamepadSnapshot : GCMicroGamepad
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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCMicroGamepadSnapshot");

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

	[Field("GCCurrentMicroGamepadSnapshotDataVersion", "GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCControler.GetMicroGamepadController()' instead.")]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	public static GCMicroGamepadSnapshotDataVersion DataVersion
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCControler.GetMicroGamepadController()' instead.")]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		get
		{
			return (GCMicroGamepadSnapshotDataVersion)(long)Dlfcn.GetNInt(Libraries.GameController.Handle, "GCCurrentMicroGamepadSnapshotDataVersion");
		}
	}

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Mac(10, 12)]
	private static extern bool GCMicroGamepadSnapShotDataV100FromNSData(out GCMicroGamepadSnapShotDataV100 snapshotData, IntPtr data);

	[Mac(10, 12)]
	[Deprecated(PlatformName.iOS, 12, 2, PlatformArchitecture.None, "Use 'TryGetSnapshotData (NSData, out GCMicroGamepadSnapshotData)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.None, "Use 'TryGetSnapshotData (NSData, out GCMicroGamepadSnapshotData)' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 2, PlatformArchitecture.None, "Use 'TryGetSnapshotData (NSData, out GCMicroGamepadSnapshotData)' instead.")]
	public static bool TryGetSnapshotData(NSData data, out GCMicroGamepadSnapShotDataV100 snapshotData)
	{
		return GCMicroGamepadSnapShotDataV100FromNSData(out snapshotData, data?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/GameController.framework/GameController")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GCController.GetMicroGamepadController()' instead.")]
	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	private static extern bool GCMicroGamepadSnapshotDataFromNSData(out GCMicroGamepadSnapshotData snapshotData, IntPtr data);

	[TV(12, 2)]
	[Mac(10, 14, 4)]
	[iOS(12, 2)]
	public static bool TryGetSnapshotData(NSData data, out GCMicroGamepadSnapshotData snapshotData)
	{
		return GCMicroGamepadSnapshotDataFromNSData(out snapshotData, data?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GCMicroGamepadSnapshot()
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
	protected GCMicroGamepadSnapshot(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCMicroGamepadSnapshot(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSnapshotData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GCMicroGamepadSnapshot(NSData data)
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
	public GCMicroGamepadSnapshot(GCController controller, NSData data)
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
