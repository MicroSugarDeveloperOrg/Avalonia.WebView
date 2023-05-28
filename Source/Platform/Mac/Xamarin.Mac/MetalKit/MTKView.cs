using System.ComponentModel;
using AppKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalKit;

[Register("MTKView", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTKView : NSView, INSCoding, INativeObject, IDisposable, ICALayerDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionForLayer_ForKey_ = "actionForLayer:forKey:";

	private static readonly IntPtr selActionForLayer_ForKey_Handle = Selector.GetHandle("actionForLayer:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoResizeDrawable = "autoResizeDrawable";

	private static readonly IntPtr selAutoResizeDrawableHandle = Selector.GetHandle("autoResizeDrawable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearColor = "clearColor";

	private static readonly IntPtr selClearColorHandle = Selector.GetHandle("clearColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearDepth = "clearDepth";

	private static readonly IntPtr selClearDepthHandle = Selector.GetHandle("clearDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearStencil = "clearStencil";

	private static readonly IntPtr selClearStencilHandle = Selector.GetHandle("clearStencil");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPixelFormat = "colorPixelFormat";

	private static readonly IntPtr selColorPixelFormatHandle = Selector.GetHandle("colorPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorspace = "colorspace";

	private static readonly IntPtr selColorspaceHandle = Selector.GetHandle("colorspace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDrawable = "currentDrawable";

	private static readonly IntPtr selCurrentDrawableHandle = Selector.GetHandle("currentDrawable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRenderPassDescriptor = "currentRenderPassDescriptor";

	private static readonly IntPtr selCurrentRenderPassDescriptorHandle = Selector.GetHandle("currentRenderPassDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthStencilAttachmentTextureUsage = "depthStencilAttachmentTextureUsage";

	private static readonly IntPtr selDepthStencilAttachmentTextureUsageHandle = Selector.GetHandle("depthStencilAttachmentTextureUsage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthStencilPixelFormat = "depthStencilPixelFormat";

	private static readonly IntPtr selDepthStencilPixelFormatHandle = Selector.GetHandle("depthStencilPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthStencilTexture = "depthStencilTexture";

	private static readonly IntPtr selDepthStencilTextureHandle = Selector.GetHandle("depthStencilTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayLayer_ = "displayLayer:";

	private static readonly IntPtr selDisplayLayer_Handle = Selector.GetHandle("displayLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraw = "draw";

	private static readonly IntPtr selDrawHandle = Selector.GetHandle("draw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawLayer_InContext_ = "drawLayer:inContext:";

	private static readonly IntPtr selDrawLayer_InContext_Handle = Selector.GetHandle("drawLayer:inContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawableSize = "drawableSize";

	private static readonly IntPtr selDrawableSizeHandle = Selector.GetHandle("drawableSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableSetNeedsDisplay = "enableSetNeedsDisplay";

	private static readonly IntPtr selEnableSetNeedsDisplayHandle = Selector.GetHandle("enableSetNeedsDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFramebufferOnly = "framebufferOnly";

	private static readonly IntPtr selFramebufferOnlyHandle = Selector.GetHandle("framebufferOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Device_ = "initWithFrame:device:";

	private static readonly IntPtr selInitWithFrame_Device_Handle = Selector.GetHandle("initWithFrame:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerWillDraw_ = "layerWillDraw:";

	private static readonly IntPtr selLayerWillDraw_Handle = Selector.GetHandle("layerWillDraw:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutSublayersOfLayer_ = "layoutSublayersOfLayer:";

	private static readonly IntPtr selLayoutSublayersOfLayer_Handle = Selector.GetHandle("layoutSublayersOfLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultisampleColorAttachmentTextureUsage = "multisampleColorAttachmentTextureUsage";

	private static readonly IntPtr selMultisampleColorAttachmentTextureUsageHandle = Selector.GetHandle("multisampleColorAttachmentTextureUsage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultisampleColorTexture = "multisampleColorTexture";

	private static readonly IntPtr selMultisampleColorTextureHandle = Selector.GetHandle("multisampleColorTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredDevice = "preferredDevice";

	private static readonly IntPtr selPreferredDeviceHandle = Selector.GetHandle("preferredDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredDrawableSize = "preferredDrawableSize";

	private static readonly IntPtr selPreferredDrawableSizeHandle = Selector.GetHandle("preferredDrawableSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredFramesPerSecond = "preferredFramesPerSecond";

	private static readonly IntPtr selPreferredFramesPerSecondHandle = Selector.GetHandle("preferredFramesPerSecond");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentsWithTransaction = "presentsWithTransaction";

	private static readonly IntPtr selPresentsWithTransactionHandle = Selector.GetHandle("presentsWithTransaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseDrawables = "releaseDrawables";

	private static readonly IntPtr selReleaseDrawablesHandle = Selector.GetHandle("releaseDrawables");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleCount = "sampleCount";

	private static readonly IntPtr selSampleCountHandle = Selector.GetHandle("sampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoResizeDrawable_ = "setAutoResizeDrawable:";

	private static readonly IntPtr selSetAutoResizeDrawable_Handle = Selector.GetHandle("setAutoResizeDrawable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearColor_ = "setClearColor:";

	private static readonly IntPtr selSetClearColor_Handle = Selector.GetHandle("setClearColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearDepth_ = "setClearDepth:";

	private static readonly IntPtr selSetClearDepth_Handle = Selector.GetHandle("setClearDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClearStencil_ = "setClearStencil:";

	private static readonly IntPtr selSetClearStencil_Handle = Selector.GetHandle("setClearStencil:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorPixelFormat_ = "setColorPixelFormat:";

	private static readonly IntPtr selSetColorPixelFormat_Handle = Selector.GetHandle("setColorPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorspace_ = "setColorspace:";

	private static readonly IntPtr selSetColorspace_Handle = Selector.GetHandle("setColorspace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthStencilAttachmentTextureUsage_ = "setDepthStencilAttachmentTextureUsage:";

	private static readonly IntPtr selSetDepthStencilAttachmentTextureUsage_Handle = Selector.GetHandle("setDepthStencilAttachmentTextureUsage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthStencilPixelFormat_ = "setDepthStencilPixelFormat:";

	private static readonly IntPtr selSetDepthStencilPixelFormat_Handle = Selector.GetHandle("setDepthStencilPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDevice_ = "setDevice:";

	private static readonly IntPtr selSetDevice_Handle = Selector.GetHandle("setDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDrawableSize_ = "setDrawableSize:";

	private static readonly IntPtr selSetDrawableSize_Handle = Selector.GetHandle("setDrawableSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnableSetNeedsDisplay_ = "setEnableSetNeedsDisplay:";

	private static readonly IntPtr selSetEnableSetNeedsDisplay_Handle = Selector.GetHandle("setEnableSetNeedsDisplay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFramebufferOnly_ = "setFramebufferOnly:";

	private static readonly IntPtr selSetFramebufferOnly_Handle = Selector.GetHandle("setFramebufferOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMultisampleColorAttachmentTextureUsage_ = "setMultisampleColorAttachmentTextureUsage:";

	private static readonly IntPtr selSetMultisampleColorAttachmentTextureUsage_Handle = Selector.GetHandle("setMultisampleColorAttachmentTextureUsage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaused_ = "setPaused:";

	private static readonly IntPtr selSetPaused_Handle = Selector.GetHandle("setPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredFramesPerSecond_ = "setPreferredFramesPerSecond:";

	private static readonly IntPtr selSetPreferredFramesPerSecond_Handle = Selector.GetHandle("setPreferredFramesPerSecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPresentsWithTransaction_ = "setPresentsWithTransaction:";

	private static readonly IntPtr selSetPresentsWithTransaction_Handle = Selector.GetHandle("setPresentsWithTransaction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleCount_ = "setSampleCount:";

	private static readonly IntPtr selSetSampleCount_Handle = Selector.GetHandle("setSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTKView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Device_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoResizeDrawable
	{
		[Export("autoResizeDrawable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoResizeDrawableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoResizeDrawableHandle);
		}
		[Export("setAutoResizeDrawable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoResizeDrawable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoResizeDrawable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLClearColor ClearColor
	{
		[Export("clearColor", ArgumentSemantic.Assign)]
		get
		{
			MTLClearColor retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLClearColor_objc_msgSend_stret(out retval, base.Handle, selClearColorHandle);
			}
			else
			{
				Messaging.MTLClearColor_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClearColorHandle);
			}
			return retval;
		}
		[Export("setClearColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLClearColor(base.Handle, selSetClearColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLClearColor(base.SuperHandle, selSetClearColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ClearDepth
	{
		[Export("clearDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selClearDepthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selClearDepthHandle);
		}
		[Export("setClearDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetClearDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetClearDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ClearStencil
	{
		[Export("clearStencil")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selClearStencilHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selClearStencilHandle);
		}
		[Export("setClearStencil:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetClearStencil_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetClearStencil_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLPixelFormat ColorPixelFormat
	{
		[Export("colorPixelFormat", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selColorPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColorPixelFormatHandle);
		}
		[Export("setColorPixelFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetColorPixelFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetColorPixelFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual CGColorSpace? ColorSpace
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("colorspace", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorspaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorspaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setColorspace:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorspace_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorspace_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICAMetalDrawable? CurrentDrawable
	{
		[Export("currentDrawable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<ICAMetalDrawable>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDrawableHandle), owns: false);
			}
			return Runtime.GetINativeObject<ICAMetalDrawable>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDrawableHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRenderPassDescriptor? CurrentRenderPassDescriptor
	{
		[Export("currentRenderPassDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLRenderPassDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentRenderPassDescriptorHandle));
			}
			return Runtime.GetNSObject<MTLRenderPassDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentRenderPassDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTKViewDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IMTKViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual MTLTextureUsage DepthStencilAttachmentTextureUsage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("depthStencilAttachmentTextureUsage", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selDepthStencilAttachmentTextureUsageHandle);
			}
			return (MTLTextureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthStencilAttachmentTextureUsageHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setDepthStencilAttachmentTextureUsage:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDepthStencilAttachmentTextureUsage_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDepthStencilAttachmentTextureUsage_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLPixelFormat DepthStencilPixelFormat
	{
		[Export("depthStencilPixelFormat", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selDepthStencilPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthStencilPixelFormatHandle);
		}
		[Export("setDepthStencilPixelFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDepthStencilPixelFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDepthStencilPixelFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? DepthStencilTexture
	{
		[Export("depthStencilTexture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selDepthStencilTextureHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepthStencilTextureHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice? Device
	{
		[Export("device", ArgumentSemantic.Assign)]
		get
		{
			IMTLDevice iMTLDevice = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false) : Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false));
			MarkDirty();
			__mt_Device_var = iMTLDevice;
			return iMTLDevice;
		}
		[Export("setDevice:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDevice_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDevice_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Device_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize DrawableSize
	{
		[Export("drawableSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selDrawableSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selDrawableSizeHandle);
		}
		[Export("setDrawableSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetDrawableSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetDrawableSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnableSetNeedsDisplay
	{
		[Export("enableSetNeedsDisplay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnableSetNeedsDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnableSetNeedsDisplayHandle);
		}
		[Export("setEnableSetNeedsDisplay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnableSetNeedsDisplay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnableSetNeedsDisplay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FramebufferOnly
	{
		[Export("framebufferOnly")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFramebufferOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFramebufferOnlyHandle);
		}
		[Export("setFramebufferOnly:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFramebufferOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFramebufferOnly_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual MTLTextureUsage MultisampleColorAttachmentTextureUsage
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("multisampleColorAttachmentTextureUsage", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selMultisampleColorAttachmentTextureUsageHandle);
			}
			return (MTLTextureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMultisampleColorAttachmentTextureUsageHandle);
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setMultisampleColorAttachmentTextureUsage:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMultisampleColorAttachmentTextureUsage_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMultisampleColorAttachmentTextureUsage_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? MultisampleColorTexture
	{
		[Export("multisampleColorTexture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultisampleColorTextureHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultisampleColorTextureHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Paused
	{
		[Export("isPaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPausedHandle);
		}
		[Export("setPaused:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPaused_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPaused_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual IMTLDevice? PreferredDevice
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("preferredDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredDrawableSize
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("preferredDrawableSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredDrawableSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredDrawableSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PreferredFramesPerSecond
	{
		[Export("preferredFramesPerSecond", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredFramesPerSecondHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredFramesPerSecondHandle);
		}
		[Export("setPreferredFramesPerSecond:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPreferredFramesPerSecond_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPreferredFramesPerSecond_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PresentsWithTransaction
	{
		[Export("presentsWithTransaction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPresentsWithTransactionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPresentsWithTransactionHandle);
		}
		[Export("setPresentsWithTransaction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPresentsWithTransaction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPresentsWithTransaction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SampleCount
	{
		[Export("sampleCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSampleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSampleCountHandle);
		}
		[Export("setSampleCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MTKView(NSCoder coder)
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
	protected MTKView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTKView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTKView(CGRect frameRect, IMTLDevice? device)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrame_Device_Handle, frameRect, device?.Handle ?? IntPtr.Zero), "initWithFrame:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrame_Device_Handle, frameRect, device?.Handle ?? IntPtr.Zero), "initWithFrame:device:");
		}
	}

	[Export("actionForLayer:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ActionForLayer(CALayer layer, string eventKey)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		IntPtr arg = NSString.CreateNative(eventKey);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selActionForLayer_ForKey_Handle, layer.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selActionForLayer_ForKey_Handle, layer.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("displayLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayLayer(CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDisplayLayer_Handle, layer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayLayer_Handle, layer.Handle);
		}
	}

	[Export("draw")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawHandle);
		}
	}

	[Export("drawLayer:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawLayer(CALayer layer, CGContext context)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDrawLayer_InContext_Handle, layer.Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDrawLayer_InContext_Handle, layer.Handle, context.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("layoutSublayersOfLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutSublayersOfLayer(CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLayoutSublayersOfLayer_Handle, layer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayoutSublayersOfLayer_Handle, layer.Handle);
		}
	}

	[Export("releaseDrawables")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReleaseDrawables()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseDrawablesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseDrawablesHandle);
		}
	}

	[Export("layerWillDraw:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDrawLayer(CALayer layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLayerWillDraw_Handle, layer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayerWillDraw_Handle, layer.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Device_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
