using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGFunction : INativeObject, IDisposable
{
	private unsafe delegate void CGFunctionEvaluateCallback(IntPtr info, double* data, double* outData);

	private struct CGFunctionCallbacks
	{
		public uint version;

		public CGFunctionEvaluateCallback evaluate;

		public IntPtr release;
	}

	public unsafe delegate void CGFunctionEvaluate(double* data, double* outData);

	internal IntPtr handle;

	private GCHandle gch;

	private CGFunctionEvaluate evaluate;

	public IntPtr Handle => handle;

	internal CGFunction(IntPtr handle)
		: this(handle, owns: false)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGFunction(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CGFunctionRetain(handle);
		}
	}

	~CGFunction()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGFunctionRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGFunctionRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGFunctionRelease(handle);
			handle = IntPtr.Zero;
			gch.Free();
			evaluate = null;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFunctionCreate(IntPtr data, IntPtr domainCount, double[] domain, IntPtr rangeDomain, double[] range, ref CGFunctionCallbacks callbacks);

	public unsafe CGFunction(double[] domain, double[] range, CGFunctionEvaluate callback)
	{
		if (domain != null && domain.Length % 2 != 0)
		{
			throw new ArgumentException("The domain array must consist of pairs of values", "domain");
		}
		if (range != null && range.Length % 2 != 0)
		{
			throw new ArgumentException("The range array must consist of pairs of values", "range");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		evaluate = callback;
		CGFunctionCallbacks callbacks = default(CGFunctionCallbacks);
		callbacks.version = 0u;
		callbacks.evaluate = EvaluateCallback;
		callbacks.release = IntPtr.Zero;
		gch = GCHandle.Alloc(this);
		handle = CGFunctionCreate(GCHandle.ToIntPtr(gch), (domain != null) ? new IntPtr(domain.Length / 2) : IntPtr.Zero, domain, (range != null) ? new IntPtr(range.Length / 2) : IntPtr.Zero, range, ref callbacks);
	}

	private unsafe static void EvaluateCallback(IntPtr info, double* input, double* output)
	{
		((CGFunction)GCHandle.FromIntPtr(info).Target).evaluate(input, output);
	}
}
