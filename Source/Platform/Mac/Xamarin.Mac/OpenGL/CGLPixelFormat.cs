using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace OpenGL;

public class CGLPixelFormat : INativeObject, IDisposable
{
	internal IntPtr handle;

	private static int ignored;

	public IntPtr Handle => handle;

	public CGLPixelFormat(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to context creation");
		}
		CGLRetainPixelFormat(handle);
		this.handle = handle;
	}

	internal CGLPixelFormat()
	{
	}

	[Preserve(Conditional = true)]
	internal CGLPixelFormat(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGLRetainPixelFormat(handle);
		}
		this.handle = handle;
	}

	~CGLPixelFormat()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern void CGLRetainPixelFormat(IntPtr handle);

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern void CGLReleasePixelFormat(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGLReleasePixelFormat(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern CGLErrorCode CGLChoosePixelFormat(CGLPixelFormatAttribute[] attributes, IntPtr pix, IntPtr npix);

	public CGLPixelFormat(CGLPixelFormatAttribute[] attributes, out int npix)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		IntPtr intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
		CGLPixelFormatAttribute[] array = new CGLPixelFormatAttribute[attributes.Length + 1];
		Array.Copy(attributes, array, attributes.Length);
		CGLErrorCode cGLErrorCode = CGLChoosePixelFormat(array, intPtr, intPtr2);
		if (cGLErrorCode != 0)
		{
			Marshal.FreeHGlobal(intPtr);
			Marshal.FreeHGlobal(intPtr2);
			throw new Exception("CGLChoosePixelFormat returned: " + cGLErrorCode);
		}
		handle = Marshal.ReadIntPtr(intPtr);
		npix = Marshal.ReadInt32(intPtr2);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
	}

	public CGLPixelFormat(params object[] attributes)
		: this(ConvertToAttributes(attributes), out ignored)
	{
	}

	public CGLPixelFormat(out int npix, params object[] attributes)
		: this(ConvertToAttributes(attributes), out npix)
	{
	}

	private static CGLPixelFormatAttribute[] ConvertToAttributes(object[] args)
	{
		List<CGLPixelFormatAttribute> list = new List<CGLPixelFormatAttribute>();
		for (int i = 0; i < args.Length; i++)
		{
			CGLPixelFormatAttribute cGLPixelFormatAttribute = (CGLPixelFormatAttribute)args[i];
			switch (cGLPixelFormatAttribute)
			{
			case CGLPixelFormatAttribute.AllRenderers:
			case CGLPixelFormatAttribute.DoubleBuffer:
			case CGLPixelFormatAttribute.Stereo:
			case CGLPixelFormatAttribute.MinimumPolicy:
			case CGLPixelFormatAttribute.MaximumPolicy:
			case CGLPixelFormatAttribute.OffScreen:
			case CGLPixelFormatAttribute.FullScreen:
			case CGLPixelFormatAttribute.AuxDepthStencil:
			case CGLPixelFormatAttribute.ColorFloat:
			case CGLPixelFormatAttribute.Multisample:
			case CGLPixelFormatAttribute.Supersample:
			case CGLPixelFormatAttribute.SampleAlpha:
			case CGLPixelFormatAttribute.SingleRenderer:
			case CGLPixelFormatAttribute.NoRecovery:
			case CGLPixelFormatAttribute.Accelerated:
			case CGLPixelFormatAttribute.ClosestPolicy:
			case CGLPixelFormatAttribute.Robust:
			case CGLPixelFormatAttribute.BackingStore:
			case CGLPixelFormatAttribute.MPSafe:
			case CGLPixelFormatAttribute.Window:
			case CGLPixelFormatAttribute.MultiScreen:
			case CGLPixelFormatAttribute.Compliant:
			case CGLPixelFormatAttribute.PixelBuffer:
			case CGLPixelFormatAttribute.RemotePixelBuffer:
			case CGLPixelFormatAttribute.AllowOfflineRenderers:
			case CGLPixelFormatAttribute.AcceleratedCompute:
				list.Add(cGLPixelFormatAttribute);
				break;
			case CGLPixelFormatAttribute.AuxBuffers:
			case CGLPixelFormatAttribute.ColorSize:
			case CGLPixelFormatAttribute.AlphaSize:
			case CGLPixelFormatAttribute.DepthSize:
			case CGLPixelFormatAttribute.StencilSize:
			case CGLPixelFormatAttribute.AccumSize:
			case CGLPixelFormatAttribute.SampleBuffers:
			case CGLPixelFormatAttribute.Samples:
			case CGLPixelFormatAttribute.RendererID:
			case CGLPixelFormatAttribute.ScreenMask:
			case CGLPixelFormatAttribute.VirtualScreenCount:
				list.Add(cGLPixelFormatAttribute);
				i++;
				if (i >= args.Length)
				{
					throw new ArgumentException(string.Concat("Attribute ", cGLPixelFormatAttribute, " needs a value"));
				}
				list.Add((CGLPixelFormatAttribute)args[i]);
				break;
			}
		}
		return list.ToArray();
	}
}
