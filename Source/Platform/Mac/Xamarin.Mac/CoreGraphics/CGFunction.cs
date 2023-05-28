using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGFunction : INativeObject, IDisposable
{
	private unsafe delegate void CGFunctionEvaluateCallback(IntPtr info, nfloat* data, nfloat* outData);

	private delegate void CGFunctionReleaseCallback(IntPtr info);

	private struct CGFunctionCallbacks
	{
		public uint version;

		public CGFunctionEvaluateCallback evaluate;

		public CGFunctionReleaseCallback release;
	}

	public unsafe delegate void CGFunctionEvaluate(nfloat* data, nfloat* outData);

	private IntPtr handle;

	private CGFunctionEvaluate evaluate;

	private static CGFunctionCallbacks cbacks;

	public IntPtr Handle => handle;

	public CGFunctionEvaluate EvaluateFunction
	{
		get
		{
			return evaluate;
		}
		set
		{
			evaluate = value;
		}
	}

	unsafe static CGFunction()
	{
		cbacks.version = 0u;
		cbacks.evaluate = EvaluateCallback;
		cbacks.release = ReleaseCallback;
	}

	internal CGFunction(IntPtr handle)
		: this(handle, owns: false)
	{
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
	private static extern void CGFunctionRelease(IntPtr function);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFunctionRetain(IntPtr function);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGFunctionRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGFunctionCreate(IntPtr data, nint domainDimension, nfloat[] domain, nint rangeDimension, nfloat[] range, ref CGFunctionCallbacks callbacks);

	public CGFunction(nfloat[] domain, nfloat[] range, CGFunctionEvaluate callback)
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
		GCHandle value = GCHandle.Alloc(this);
		handle = CGFunctionCreate(GCHandle.ToIntPtr(value), (domain != null) ? (domain.Length / 2) : 0, domain, (range != null) ? (range.Length / 2) : 0, range, ref cbacks);
	}

	private static void ReleaseCallback(IntPtr info)
	{
		GCHandle.FromIntPtr(info).Free();
	}

	private unsafe static void EvaluateCallback(IntPtr info, nfloat* input, nfloat* output)
	{
		CGFunction cGFunction = (CGFunction)GCHandle.FromIntPtr(info).Target;
		cGFunction.evaluate?.Invoke(input, output);
	}
}
