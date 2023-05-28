using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Metal;

[iOS(8, 0)]
[Mac(10, 11)]
public static class MTLDevice
{
	internal delegate void InnerNotification(IntPtr block, IntPtr device, IntPtr notifyName);

	private static IMTLDevice system_default;

	private static readonly InnerNotification static_notificationHandler = TrampolineNotificationHandler;

	public static IMTLDevice SystemDefault
	{
		get
		{
			if (system_default == null || system_default.Handle == IntPtr.Zero)
			{
				try
				{
					IntPtr intPtr = MTLCreateSystemDefaultDevice();
					if (intPtr != IntPtr.Zero)
					{
						system_default = new MTLDeviceWrapper(intPtr, owns: false);
					}
				}
				catch (EntryPointNotFoundException)
				{
				}
				catch (DllNotFoundException)
				{
				}
			}
			return system_default;
		}
	}

	[DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
	private static extern IntPtr MTLCreateSystemDefaultDevice();

	[DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
	[Mac(10, 11)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	private static extern IntPtr MTLCopyAllDevices();

	[Mac(10, 11)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	public static IMTLDevice[] GetAllDevices()
	{
		IntPtr handle = MTLCopyAllDevices();
		return NSArray.ArrayFromHandle<IMTLDevice>(handle);
	}

	[DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
	[Mac(10, 13)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	private unsafe static extern IntPtr MTLCopyAllDevicesWithObserver(ref IntPtr observer, void* handler);

	[Mac(10, 13)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static IMTLDevice[] GetAllDevices(ref NSObject observer, MTLDeviceNotificationHandler handler)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr observer2 = observer.Handle;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* handler2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_notificationHandler, handler);
		IntPtr handle = MTLCopyAllDevicesWithObserver(ref observer2, handler2);
		IMTLDevice[] result = NSArray.ArrayFromHandle<IMTLDevice>(handle);
		if (observer2 != observer.Handle)
		{
			observer = Runtime.GetNSObject(observer2);
		}
		return result;
	}

	[MonoPInvokeCallback(typeof(InnerNotification))]
	public unsafe static void TrampolineNotificationHandler(IntPtr block, IntPtr device, IntPtr notifyName)
	{
		BlockLiteral* ptr = (BlockLiteral*)(void*)block;
		((MTLDeviceNotificationHandler)ptr->Target)?.Invoke((IMTLDevice)Runtime.GetNSObject(device), (NSString)Runtime.GetNSObject(notifyName));
	}

	[DllImport("/System/Library/Frameworks/Metal.framework/Metal")]
	[Mac(10, 13)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	private static extern void MTLRemoveDeviceObserver(IntPtr observer);

	[Mac(10, 13)]
	[NoiOS]
	[NoWatch]
	[NoTV]
	public static void RemoveObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		MTLRemoveDeviceObserver(observer.Handle);
	}
}
