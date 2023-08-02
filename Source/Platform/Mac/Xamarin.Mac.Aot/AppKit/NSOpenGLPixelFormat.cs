using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace AppKit;

[Register("NSOpenGLPixelFormat", true)]
public class NSOpenGLPixelFormat : NSObject
{
	private static IntPtr selInitWithAttributes = Selector.GetHandle("initWithAttributes:");

	private static readonly IntPtr selNumberOfVirtualScreensHandle = Selector.GetHandle("numberOfVirtualScreens");

	private static readonly IntPtr selCGLPixelFormatObjHandle = Selector.GetHandle("CGLPixelFormatObj");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selGetValuesForAttributeForVirtualScreen_Handle = Selector.GetHandle("getValues:forAttribute:forVirtualScreen:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOpenGLPixelFormat");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int NumberOfVirtualScreens
	{
		[Export("numberOfVirtualScreens")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfVirtualScreensHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfVirtualScreensHandle);
		}
	}

	public virtual CGLPixelFormat CGLPixelFormat
	{
		[Export("CGLPixelFormatObj")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new CGLPixelFormat(Messaging.IntPtr_objc_msgSend(base.Handle, selCGLPixelFormatObjHandle));
			}
			return new CGLPixelFormat(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLPixelFormatObjHandle));
		}
	}

	public unsafe NSOpenGLPixelFormat(NSOpenGLPixelFormatAttribute[] attribs)
		: base(NSObjectFlag.Empty)
	{
		if (attribs == null)
		{
			throw new ArgumentNullException("attribs");
		}
		NSOpenGLPixelFormatAttribute[] array = new NSOpenGLPixelFormatAttribute[attribs.Length + 1];
		Array.Copy(attribs, 0, array, 0, attribs.Length);
		fixed (NSOpenGLPixelFormatAttribute* value = array)
		{
			if (IsDirectBinding)
			{
				base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributes, new IntPtr(value));
			}
			else
			{
				base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributes, new IntPtr(value));
			}
		}
	}

	private static NSOpenGLPixelFormatAttribute[] ConvertToAttributes(object[] args)
	{
		List<NSOpenGLPixelFormatAttribute> list = new List<NSOpenGLPixelFormatAttribute>();
		for (int i = 0; i < args.Length; i++)
		{
			NSOpenGLPixelFormatAttribute nSOpenGLPixelFormatAttribute = (NSOpenGLPixelFormatAttribute)args[i];
			switch (nSOpenGLPixelFormatAttribute)
			{
			case NSOpenGLPixelFormatAttribute.AllRenderers:
			case NSOpenGLPixelFormatAttribute.DoubleBuffer:
			case NSOpenGLPixelFormatAttribute.Stereo:
			case NSOpenGLPixelFormatAttribute.MinimumPolicy:
			case NSOpenGLPixelFormatAttribute.MaximumPolicy:
			case NSOpenGLPixelFormatAttribute.OffScreen:
			case NSOpenGLPixelFormatAttribute.FullScreen:
			case NSOpenGLPixelFormatAttribute.AuxDepthStencil:
			case NSOpenGLPixelFormatAttribute.ColorFloat:
			case NSOpenGLPixelFormatAttribute.Multisample:
			case NSOpenGLPixelFormatAttribute.Supersample:
			case NSOpenGLPixelFormatAttribute.SampleAlpha:
			case NSOpenGLPixelFormatAttribute.SingleRenderer:
			case NSOpenGLPixelFormatAttribute.NoRecovery:
			case NSOpenGLPixelFormatAttribute.Accelerated:
			case NSOpenGLPixelFormatAttribute.ClosestPolicy:
			case NSOpenGLPixelFormatAttribute.Robust:
			case NSOpenGLPixelFormatAttribute.BackingStore:
			case NSOpenGLPixelFormatAttribute.MPSafe:
			case NSOpenGLPixelFormatAttribute.Window:
			case NSOpenGLPixelFormatAttribute.MultiScreen:
			case NSOpenGLPixelFormatAttribute.Compliant:
			case NSOpenGLPixelFormatAttribute.PixelBuffer:
			case NSOpenGLPixelFormatAttribute.RemotePixelBuffer:
			case NSOpenGLPixelFormatAttribute.AllowOfflineRenderers:
			case NSOpenGLPixelFormatAttribute.AcceleratedCompute:
				list.Add(nSOpenGLPixelFormatAttribute);
				break;
			case NSOpenGLPixelFormatAttribute.AuxBuffers:
			case NSOpenGLPixelFormatAttribute.ColorSize:
			case NSOpenGLPixelFormatAttribute.AlphaSize:
			case NSOpenGLPixelFormatAttribute.DepthSize:
			case NSOpenGLPixelFormatAttribute.StencilSize:
			case NSOpenGLPixelFormatAttribute.AccumSize:
			case NSOpenGLPixelFormatAttribute.SampleBuffers:
			case NSOpenGLPixelFormatAttribute.Samples:
			case NSOpenGLPixelFormatAttribute.RendererID:
			case NSOpenGLPixelFormatAttribute.ScreenMask:
			case NSOpenGLPixelFormatAttribute.VirtualScreenCount:
				list.Add(nSOpenGLPixelFormatAttribute);
				i++;
				if (i >= args.Length)
				{
					throw new ArgumentException(string.Concat("Attribute ", nSOpenGLPixelFormatAttribute, " needs a value"));
				}
				list.Add((NSOpenGLPixelFormatAttribute)args[i]);
				break;
			}
		}
		return list.ToArray();
	}

	public unsafe NSOpenGLPixelFormat(params object[] attribs)
		: this(ConvertToAttributes(attribs))
	{
		if (attribs == null)
		{
			throw new ArgumentNullException("attribs");
		}
		NSOpenGLPixelFormatAttribute[] array = new NSOpenGLPixelFormatAttribute[attribs.Length + 1];
		Array.Copy(attribs, 0, array, 0, attribs.Length);
		fixed (NSOpenGLPixelFormatAttribute* value = array)
		{
			if (IsDirectBinding)
			{
				base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributes, new IntPtr(value));
			}
			else
			{
				base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributes, new IntPtr(value));
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLPixelFormat()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOpenGLPixelFormat(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenGLPixelFormat(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenGLPixelFormat(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:")]
	public NSOpenGLPixelFormat(NSData attribs)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (attribs == null)
		{
			throw new ArgumentNullException("attribs");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, attribs.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, attribs.Handle);
		}
	}

	[Export("getValues:forAttribute:forVirtualScreen:")]
	public virtual void GetValue(ref int vals, NSOpenGLPixelFormatAttribute attrib, int screen)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Int32_int_int(base.Handle, selGetValuesForAttributeForVirtualScreen_Handle, out vals, (int)attrib, screen);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Int32_int_int(base.SuperHandle, selGetValuesForAttributeForVirtualScreen_Handle, out vals, (int)attrib, screen);
		}
	}
}
