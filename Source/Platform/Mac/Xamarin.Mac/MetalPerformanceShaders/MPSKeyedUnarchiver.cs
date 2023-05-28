using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSKeyedUnarchiver", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
public class MPSKeyedUnarchiver : NSKeyedUnarchiver, IMPSDeviceProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForReadingFromData_Device_Error_ = "initForReadingFromData:device:error:";

	private static readonly IntPtr selInitForReadingFromData_Device_Error_Handle = Selector.GetHandle("initForReadingFromData:device:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMpsMTLDevice = "mpsMTLDevice";

	private static readonly IntPtr selMpsMTLDeviceHandle = Selector.GetHandle("mpsMTLDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchivedObjectOfClass_FromData_Device_Error_ = "unarchivedObjectOfClass:fromData:device:error:";

	private static readonly IntPtr selUnarchivedObjectOfClass_FromData_Device_Error_Handle = Selector.GetHandle("unarchivedObjectOfClass:fromData:device:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchivedObjectOfClasses_FromData_Device_Error_ = "unarchivedObjectOfClasses:fromData:device:error:";

	private static readonly IntPtr selUnarchivedObjectOfClasses_FromData_Device_Error_Handle = Selector.GetHandle("unarchivedObjectOfClasses:fromData:device:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSKeyedUnarchiver");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSKeyedUnarchiver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSKeyedUnarchiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForReadingFromData:device:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSKeyedUnarchiver(NSData data, IMTLDevice device, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitForReadingFromData_Device_Error_Handle, data.Handle, device.Handle, ref arg), "initForReadingFromData:device:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitForReadingFromData_Device_Error_Handle, data.Handle, device.Handle, ref arg), "initForReadingFromData:device:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("mpsMTLDevice")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice GetMTLDevice()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selMpsMTLDeviceHandle), owns: false);
		}
		return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMpsMTLDeviceHandle), owns: false);
	}

	[Export("unarchivedObjectOfClasses:fromData:device:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(NSSet<Class> classes, NSData data, IMTLDevice device, out NSError? error)
	{
		if (classes == null)
		{
			throw new ArgumentNullException("classes");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUnarchivedObjectOfClasses_FromData_Device_Error_Handle, classes.Handle, data.Handle, device.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("unarchivedObjectOfClass:fromData:device:error:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(Class @class, NSData data, IMTLDevice device, out NSError? error)
	{
		if (@class == null)
		{
			throw new ArgumentNullException("@class");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUnarchivedObjectOfClass_FromData_Device_Error_Handle, @class.Handle, data.Handle, device.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
