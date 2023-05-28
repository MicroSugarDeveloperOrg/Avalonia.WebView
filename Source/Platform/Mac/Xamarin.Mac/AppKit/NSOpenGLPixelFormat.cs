using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenGL;

namespace AppKit;

[Register("NSOpenGLPixelFormat", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' Framework instead.")]
public class NSOpenGLPixelFormat : NSObject, INSCoding, INativeObject, IDisposable
{
	private static IntPtr selInitWithAttributes = Selector.GetHandle("initWithAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGLPixelFormatObj = "CGLPixelFormatObj";

	private static readonly IntPtr selCGLPixelFormatObjHandle = Selector.GetHandle("CGLPixelFormatObj");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetValues_ForAttribute_ForVirtualScreen_ = "getValues:forAttribute:forVirtualScreen:";

	private static readonly IntPtr selGetValues_ForAttribute_ForVirtualScreen_Handle = Selector.GetHandle("getValues:forAttribute:forVirtualScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfVirtualScreens = "numberOfVirtualScreens";

	private static readonly IntPtr selNumberOfVirtualScreensHandle = Selector.GetHandle("numberOfVirtualScreens");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenGLPixelFormat");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGLPixelFormat CGLPixelFormat
	{
		[Export("CGLPixelFormatObj")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGLPixelFormatObjHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGLPixelFormatObjHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGLPixelFormat(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int NumberOfVirtualScreens
	{
		[Export("numberOfVirtualScreens")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfVirtualScreensHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfVirtualScreensHandle);
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
			if (base.IsDirectBinding)
			{
				base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributes, new IntPtr(value));
			}
			else
			{
				base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributes, new IntPtr(value));
			}
		}
	}

	public unsafe NSOpenGLPixelFormat(uint[] attribs)
		: base(NSObjectFlag.Empty)
	{
		if (attribs == null)
		{
			throw new ArgumentNullException("attribs");
		}
		uint[] array = new uint[attribs.Length + 1];
		Array.Copy(attribs, 0, array, 0, attribs.Length);
		fixed (uint* value = array)
		{
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributes, new IntPtr(value)));
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributes, new IntPtr(value)));
			}
		}
	}

	private static uint[] ConvertToAttributes(object[] args)
	{
		List<uint> list = new List<uint>();
		for (int i = 0; i < args.Length; i++)
		{
			if (args[i] is NSOpenGLPixelFormatAttribute)
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
					list.Add((uint)nSOpenGLPixelFormatAttribute);
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
				case NSOpenGLPixelFormatAttribute.OpenGLProfile:
				case NSOpenGLPixelFormatAttribute.VirtualScreenCount:
					list.Add((uint)nSOpenGLPixelFormatAttribute);
					i++;
					if (i >= args.Length)
					{
						throw new ArgumentException("Attribute " + nSOpenGLPixelFormatAttribute.ToString() + " needs a value");
					}
					list.Add((uint)(int)args[i]);
					break;
				}
			}
			else
			{
				if (!(args[i] is int) || (int)args[i] != 0 || i != args.Length - 1)
				{
					throw new ArgumentException($"The specified attribute is not of type NSOpenGLPixelFormatAttribute: {args[i]}");
				}
				list.Add(0u);
			}
		}
		if (args.Length == 0 || !(args[args.Length - 1] is int) || (int)args[args.Length - 1] != 0)
		{
			list.Add(0u);
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
		for (int i = 0; i < attribs.Length; i++)
		{
			object obj = attribs[i];
			if (obj is NSOpenGLPixelFormatAttribute)
			{
				array[i] = (NSOpenGLPixelFormatAttribute)obj;
			}
			else
			{
				array[i] = (NSOpenGLPixelFormatAttribute)(int)obj;
			}
		}
		fixed (NSOpenGLPixelFormatAttribute* value = array)
		{
			if (base.IsDirectBinding)
			{
				base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributes, new IntPtr(value));
			}
			else
			{
				base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributes, new IntPtr(value));
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenGLPixelFormat()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOpenGLPixelFormat(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOpenGLPixelFormat(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenGLPixelFormat(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOpenGLPixelFormat(NSData attribs)
		: base(NSObjectFlag.Empty)
	{
		if (attribs == null)
		{
			throw new ArgumentNullException("attribs");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, attribs.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, attribs.Handle), "initWithData:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("getValues:forAttribute:forVirtualScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetValue(ref int vals, NSOpenGLPixelFormatAttribute attrib, int screen)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_Int32_UInt32_int(base.Handle, selGetValues_ForAttribute_ForVirtualScreen_Handle, ref vals, (uint)attrib, screen);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_Int32_UInt32_int(base.SuperHandle, selGetValues_ForAttribute_ForVirtualScreen_Handle, ref vals, (uint)attrib, screen);
		}
	}
}
