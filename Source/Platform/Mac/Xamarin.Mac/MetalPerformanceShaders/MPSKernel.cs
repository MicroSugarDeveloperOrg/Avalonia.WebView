using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSKernel", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public class MPSKernel : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOptions_ = "setOptions:";

	private static readonly IntPtr selSetOptions_Handle = Selector.GetHandle("setOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSKernel");

	[Field("MPSRectNoClip", "MetalPerformanceShaders")]
	public unsafe static MTLRegion RectNoClip
	{
		get
		{
			IntPtr intPtr = Dlfcn.dlsym(Libraries.MetalPerformanceShaders.Handle, "MPSRectNoClip");
			if (intPtr == IntPtr.Zero)
			{
				return default(MTLRegion);
			}
			nint* ptr = (nint*)(void*)intPtr;
			return MTLRegion.Create3D(*ptr, ptr[1], ptr[2], ptr[3], ptr[4], ptr[5]);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice Device
	{
		[Export("device", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSKernelOptions Options
	{
		[Export("options", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSKernelOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (MPSKernelOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
		[Export("setOptions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOptions_Handle, (ulong)value);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	private static extern bool MPSSupportsMTLDevice(IntPtr device);

	public static bool Supports(IMTLDevice device)
	{
		return MPSSupportsMTLDevice(device?.Handle ?? IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr MPSGetPreferredDevice(nuint options);

	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static IMTLDevice GetPreferredDevice(MPSDeviceOptions options)
	{
		IntPtr ptr = MPSGetPreferredDevice((nuint)(ulong)options);
		return Runtime.GetINativeObject<IMTLDevice>(ptr, owns: false);
	}

	internal unsafe static float[] GetTransform(IntPtr transform)
	{
		float* ptr = (float*)(void*)transform;
		if (ptr == null)
		{
			return null;
		}
		return new float[3]
		{
			*ptr,
			ptr[1],
			ptr[2]
		};
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	private static extern void MPSHintTemporaryMemoryHighWaterMark(IntPtr commandBuffer, nuint bytes);

	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public static void HintTemporaryMemoryHighWaterMark(IMTLCommandBuffer commandBuffer, nuint sizeInBytes)
	{
		MPSHintTemporaryMemoryHighWaterMark(commandBuffer?.Handle ?? IntPtr.Zero, sizeInBytes);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	private static extern void MPSSetHeapCacheDuration(IntPtr commandBuffer, double seconds);

	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public static void SetHeapCacheDuration(IMTLCommandBuffer commandBuffer, double seconds)
	{
		MPSSetHeapCacheDuration(commandBuffer?.Handle ?? IntPtr.Zero, seconds);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSKernel(NSCoder coder)
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
	protected MPSKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSKernel(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSKernel(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSKernel CopyWithZone(NSZone? zone, IMTLDevice? device)
	{
		MPSKernel mPSKernel = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSKernel>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSKernel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSKernel != null)
		{
			Messaging.void_objc_msgSend(mPSKernel.Handle, Selector.GetHandle("release"));
		}
		return mPSKernel;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
