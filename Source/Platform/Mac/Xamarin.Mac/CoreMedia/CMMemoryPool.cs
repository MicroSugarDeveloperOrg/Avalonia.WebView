using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CMMemoryPool : IDisposable, INativeObject
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	[Field("kCMMemoryPoolOption_AgeOutPeriod", "CoreMedia")]
	internal static IntPtr AgeOutPeriodSelector => Dlfcn.GetIntPtr(Libraries.CoreMedia.Handle, "kCMMemoryPoolOption_AgeOutPeriod");

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMMemoryPoolCreate(IntPtr options);

	public CMMemoryPool()
	{
		handle = CMMemoryPoolCreate(IntPtr.Zero);
	}

	public CMMemoryPool(TimeSpan ageOutPeriod)
	{
		using NSNumber second = new NSNumber(ageOutPeriod.TotalSeconds);
		using NSDictionary nSDictionary = new NSDictionary(AgeOutPeriodSelector, second);
		handle = CMMemoryPoolCreate(nSDictionary.Handle);
	}

	~CMMemoryPool()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (Handle != IntPtr.Zero)
		{
			CFObject.CFRelease(Handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern IntPtr CMMemoryPoolGetAllocator(IntPtr pool);

	public CFAllocator GetAllocator()
	{
		return new CFAllocator(CMMemoryPoolGetAllocator(Handle), owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMMemoryPoolFlush(IntPtr pool);

	public void Flush()
	{
		CMMemoryPoolFlush(Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern void CMMemoryPoolInvalidate(IntPtr pool);

	public void Invalidate()
	{
		CMMemoryPoolInvalidate(Handle);
	}
}
