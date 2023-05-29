using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Since(6, 0)]
public class CMMemoryPool : IDisposable, INativeObject
{
	private IntPtr handle;

	private static readonly IntPtr AgeOutPeriodSelector;

	public IntPtr Handle => handle;

	static CMMemoryPool()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia", 0);
		try
		{
			AgeOutPeriodSelector = Dlfcn.GetIntPtr(intPtr, "kCMMemoryPoolOption_AgeOutPeriod");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMMemoryPoolCreate(IntPtr options);

	public CMMemoryPool()
	{
		handle = CMMemoryPoolCreate(IntPtr.Zero);
	}

	public CMMemoryPool(TimeSpan ageOutPeriod)
	{
		using NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		nSMutableDictionary.LowlevelSetObject(AgeOutPeriodSelector, new NSNumber(ageOutPeriod.TotalSeconds).Handle);
		handle = CMMemoryPoolCreate(nSMutableDictionary.Handle);
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

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern IntPtr CMMemoryPoolGetAllocator(IntPtr pool);

	public CFAllocator GetAllocator()
	{
		return new CFAllocator(CMMemoryPoolGetAllocator(Handle), owns: false);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern void CMMemoryPoolFlush(IntPtr pool);

	public void Flush()
	{
		CMMemoryPoolFlush(Handle);
	}

	[DllImport("/System/Library/PrivateFrameworks/CoreMedia.framework/Versions/A/CoreMedia")]
	private static extern void CMMemoryPoolInvalidate(IntPtr pool);

	public void Invalidate()
	{
		CMMemoryPoolInvalidate(Handle);
	}
}
