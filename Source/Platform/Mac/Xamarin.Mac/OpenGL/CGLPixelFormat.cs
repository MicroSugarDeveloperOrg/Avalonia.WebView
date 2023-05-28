using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace OpenGL;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class CGLPixelFormat : INativeObject, IDisposable
{
	internal IntPtr handle;

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
	private static extern CGLErrorCode CGLChoosePixelFormat(CGLPixelFormatAttribute[] attributes, out IntPtr pix, out int npix);

	public CGLPixelFormat(CGLPixelFormatAttribute[] attributes, out int npix)
	{
		Initialize(attributes, out npix);
	}

	private void Initialize(CGLPixelFormatAttribute[] attributes, out int npix)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		CGLPixelFormatAttribute[] array = new CGLPixelFormatAttribute[attributes.Length + 1];
		Array.Copy(attributes, array, attributes.Length);
		IntPtr pix;
		CGLErrorCode cGLErrorCode = CGLChoosePixelFormat(array, out pix, out npix);
		if (cGLErrorCode != 0)
		{
			throw new Exception("CGLChoosePixelFormat returned: " + cGLErrorCode);
		}
		handle = pix;
	}

	public CGLPixelFormat(params object[] attributes)
	{
		Initialize(ConvertToAttributes(attributes), out var _);
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
			{
				list.Add(cGLPixelFormatAttribute);
				i++;
				if (i >= args.Length)
				{
					throw new ArgumentException("Attribute " + cGLPixelFormatAttribute.ToString() + " needs a value");
				}
				object obj = args[i];
				CGLPixelFormatAttribute item = ((!(obj is CGLPixelFormatAttribute)) ? ((CGLPixelFormatAttribute)Convert.ChangeType(obj, typeof(CGLPixelFormatAttribute).GetEnumUnderlyingType())) : ((CGLPixelFormatAttribute)obj));
				list.Add(item);
				break;
			}
			}
		}
		return list.ToArray();
	}
}
