using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreVideo;

[Since(4, 0)]
public class CVPixelBufferPool : INativeObject, IDisposable
{
	public static readonly NSString MinimumBufferCountKey;

	public static readonly NSString MaximumBufferAgeKey;

	private IntPtr handle;

	public IntPtr Handle => handle;

	public int TypeID => CVPixelBufferPoolGetTypeID();

	public NSDictionary PixelBufferAttributes => (NSDictionary)Runtime.GetNSObject(CVPixelBufferPoolGetPixelBufferAttributes(handle));

	public NSDictionary Attributes => (NSDictionary)Runtime.GetNSObject(CVPixelBufferPoolGetAttributes(handle));

	public CVPixelBufferPoolSettings Settings
	{
		get
		{
			NSDictionary attributes = Attributes;
			if (attributes != null)
			{
				return new CVPixelBufferPoolSettings(attributes);
			}
			return null;
		}
	}

	static CVPixelBufferPool()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			MinimumBufferCountKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferPoolMinimumBufferCountKey");
			MaximumBufferAgeKey = Dlfcn.GetStringConstant(intPtr, "kCVPixelBufferPoolMaximumBufferAgeKey");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	internal CVPixelBufferPool(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("Invalid parameters to context creation");
		}
		CVPixelBufferPoolRetain(handle);
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CVPixelBufferPool(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CVPixelBufferPoolRetain(handle);
		}
		this.handle = handle;
	}

	~CVPixelBufferPool()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelBufferPoolRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelBufferPoolRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CVPixelBufferPoolRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern int CVPixelBufferPoolGetTypeID();

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferPoolGetPixelBufferAttributes(IntPtr pool);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferPoolGetAttributes(IntPtr pool);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreatePixelBuffer(IntPtr allocator, IntPtr pixelBufferPool, IntPtr pixelBufferOut);

	public CVPixelBuffer CreatePixelBuffer()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		CVReturn cVReturn = CVPixelBufferPoolCreatePixelBuffer(IntPtr.Zero, handle, intPtr);
		if (cVReturn != 0)
		{
			Marshal.FreeHGlobal(intPtr);
			throw new Exception("CVPixelBufferPoolCreatePixelBuffer returned " + cVReturn);
		}
		CVPixelBuffer result = new CVPixelBuffer(Marshal.ReadIntPtr(intPtr));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreatePixelBufferWithAuxAttributes(IntPtr allocator, IntPtr pixelBufferPool, IntPtr auxAttributes, out IntPtr pixelBufferOut);

	public CVPixelBuffer CreatePixelBuffer(CVPixelBufferPoolAllocationSettings allocationSettings, out CVReturn error)
	{
		error = CVPixelBufferPoolCreatePixelBufferWithAuxAttributes(IntPtr.Zero, handle, allocationSettings?.Dictionary.Handle ?? IntPtr.Zero, out var pixelBufferOut);
		if (error != 0)
		{
			return null;
		}
		return new CVPixelBuffer(pixelBufferOut);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferPoolCreate(IntPtr allocator, IntPtr poolAttributes, IntPtr pixelBufferAttributes, IntPtr poolOut);

	[Advice("Use overload with CVPixelBufferPoolSettings")]
	public CVPixelBufferPool(NSDictionary poolAttributes, NSDictionary pixelBufferAttributes)
	{
		if (pixelBufferAttributes == null)
		{
			throw new ArgumentNullException("pixelBufferAttributes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		CVReturn cVReturn = CVPixelBufferPoolCreate(IntPtr.Zero, poolAttributes?.Handle ?? IntPtr.Zero, pixelBufferAttributes.Handle, intPtr);
		if (cVReturn != 0)
		{
			Marshal.FreeHGlobal(intPtr);
			throw new Exception("CVPixelBufferPoolCreate returned " + cVReturn);
		}
		handle = Marshal.ReadIntPtr(intPtr);
		Marshal.FreeHGlobal(intPtr);
	}

	public CVPixelBufferPool(CVPixelBufferPoolSettings settings, CVPixelBufferAttributes pixelBufferAttributes)
		: this(settings?.Dictionary, pixelBufferAttributes?.Dictionary)
	{
	}
}
