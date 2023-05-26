using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGLayer : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public CGSize Size => CGLayerGetSize(handle);

	public CGContext Context => new CGContext(CGLayerGetContext(handle));

	internal CGLayer(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to layer creation");
		}
		this.handle = handle;
		CGLayerRetain(handle);
	}

	[Preserve(Conditional = true)]
	internal CGLayer(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGLayerRetain(handle);
		}
		this.handle = handle;
	}

	~CGLayer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGLayerRelease(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGLayerRetain(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGLayerRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGSize CGLayerGetSize(IntPtr layer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGLayerGetContext(IntPtr layer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGLayerCreateWithContext(IntPtr context, CGSize size, IntPtr dictionary);

	public static CGLayer Create(CGContext context, CGSize size)
	{
		return new CGLayer(CGLayerCreateWithContext(context.Handle, size, IntPtr.Zero), owns: true);
	}
}
