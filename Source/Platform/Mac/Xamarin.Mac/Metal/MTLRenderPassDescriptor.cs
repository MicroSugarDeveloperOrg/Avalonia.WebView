using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Register("MTLRenderPassDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPassDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorAttachments = "colorAttachments";

	private static readonly IntPtr selColorAttachmentsHandle = Selector.GetHandle("colorAttachments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultRasterSampleCount = "defaultRasterSampleCount";

	private static readonly IntPtr selDefaultRasterSampleCountHandle = Selector.GetHandle("defaultRasterSampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthAttachment = "depthAttachment";

	private static readonly IntPtr selDepthAttachmentHandle = Selector.GetHandle("depthAttachment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetSamplePositions_Count_ = "getSamplePositions:count:";

	private static readonly IntPtr selGetSamplePositions_Count_Handle = Selector.GetHandle("getSamplePositions:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRasterizationRateMap = "rasterizationRateMap";

	private static readonly IntPtr selRasterizationRateMapHandle = Selector.GetHandle("rasterizationRateMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderPassDescriptor = "renderPassDescriptor";

	private static readonly IntPtr selRenderPassDescriptorHandle = Selector.GetHandle("renderPassDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderTargetArrayLength = "renderTargetArrayLength";

	private static readonly IntPtr selRenderTargetArrayLengthHandle = Selector.GetHandle("renderTargetArrayLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderTargetHeight = "renderTargetHeight";

	private static readonly IntPtr selRenderTargetHeightHandle = Selector.GetHandle("renderTargetHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderTargetWidth = "renderTargetWidth";

	private static readonly IntPtr selRenderTargetWidthHandle = Selector.GetHandle("renderTargetWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultRasterSampleCount_ = "setDefaultRasterSampleCount:";

	private static readonly IntPtr selSetDefaultRasterSampleCount_Handle = Selector.GetHandle("setDefaultRasterSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthAttachment_ = "setDepthAttachment:";

	private static readonly IntPtr selSetDepthAttachment_Handle = Selector.GetHandle("setDepthAttachment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRasterizationRateMap_ = "setRasterizationRateMap:";

	private static readonly IntPtr selSetRasterizationRateMap_Handle = Selector.GetHandle("setRasterizationRateMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderTargetArrayLength_ = "setRenderTargetArrayLength:";

	private static readonly IntPtr selSetRenderTargetArrayLength_Handle = Selector.GetHandle("setRenderTargetArrayLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderTargetHeight_ = "setRenderTargetHeight:";

	private static readonly IntPtr selSetRenderTargetHeight_Handle = Selector.GetHandle("setRenderTargetHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderTargetWidth_ = "setRenderTargetWidth:";

	private static readonly IntPtr selSetRenderTargetWidth_Handle = Selector.GetHandle("setRenderTargetWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSamplePositions_Count_ = "setSamplePositions:count:";

	private static readonly IntPtr selSetSamplePositions_Count_Handle = Selector.GetHandle("setSamplePositions:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStencilAttachment_ = "setStencilAttachment:";

	private static readonly IntPtr selSetStencilAttachment_Handle = Selector.GetHandle("setStencilAttachment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibilityResultBuffer_ = "setVisibilityResultBuffer:";

	private static readonly IntPtr selSetVisibilityResultBuffer_Handle = Selector.GetHandle("setVisibilityResultBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStencilAttachment = "stencilAttachment";

	private static readonly IntPtr selStencilAttachmentHandle = Selector.GetHandle("stencilAttachment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibilityResultBuffer = "visibilityResultBuffer";

	private static readonly IntPtr selVisibilityResultBufferHandle = Selector.GetHandle("visibilityResultBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPassDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRenderPassColorAttachmentDescriptorArray ColorAttachments
	{
		[Export("colorAttachments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLRenderPassColorAttachmentDescriptorArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorAttachmentsHandle));
			}
			return Runtime.GetNSObject<MTLRenderPassColorAttachmentDescriptorArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorAttachmentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nuint DefaultRasterSampleCount
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("defaultRasterSampleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDefaultRasterSampleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDefaultRasterSampleCountHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setDefaultRasterSampleCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDefaultRasterSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDefaultRasterSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRenderPassDepthAttachmentDescriptor DepthAttachment
	{
		[Export("depthAttachment", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLRenderPassDepthAttachmentDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDepthAttachmentHandle));
			}
			return Runtime.GetNSObject<MTLRenderPassDepthAttachmentDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDepthAttachmentHandle));
		}
		[Export("setDepthAttachment:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDepthAttachment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDepthAttachment_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual IMTLRasterizationRateMap? RasterizationRateMap
	{
		[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("rasterizationRateMap", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLRasterizationRateMap>(Messaging.IntPtr_objc_msgSend(base.Handle, selRasterizationRateMapHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLRasterizationRateMap>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRasterizationRateMapHandle), owns: false);
		}
		[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setRasterizationRateMap:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRasterizationRateMap_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRasterizationRateMap_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual nuint RenderTargetArrayLength
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("renderTargetArrayLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRenderTargetArrayLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRenderTargetArrayLengthHandle);
		}
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setRenderTargetArrayLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRenderTargetArrayLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRenderTargetArrayLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nuint RenderTargetHeight
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("renderTargetHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRenderTargetHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRenderTargetHeightHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setRenderTargetHeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRenderTargetHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRenderTargetHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nuint RenderTargetWidth
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("renderTargetWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRenderTargetWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRenderTargetWidthHandle);
		}
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setRenderTargetWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRenderTargetWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRenderTargetWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRenderPassStencilAttachmentDescriptor StencilAttachment
	{
		[Export("stencilAttachment", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLRenderPassStencilAttachmentDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selStencilAttachmentHandle));
			}
			return Runtime.GetNSObject<MTLRenderPassStencilAttachmentDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStencilAttachmentHandle));
		}
		[Export("setStencilAttachment:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStencilAttachment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStencilAttachment_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer? VisibilityResultBuffer
	{
		[Export("visibilityResultBuffer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVisibilityResultBufferHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibilityResultBufferHandle), owns: false);
		}
		[Export("setVisibilityResultBuffer:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVisibilityResultBuffer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVisibilityResultBuffer_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	public unsafe void SetSamplePositions(MTLSamplePosition[] positions)
	{
		fixed (MTLSamplePosition* ptr = positions)
		{
			void* ptr2 = ptr;
			SetSamplePositions((IntPtr)ptr2, (nuint)((positions != null) ? positions.Length : 0));
		}
	}

	public unsafe nuint GetSamplePositions(MTLSamplePosition[] positions)
	{
		fixed (MTLSamplePosition* ptr = positions)
		{
			void* ptr2 = ptr;
			return GetSamplePositions((IntPtr)ptr2, (nuint)((positions != null) ? positions.Length : 0));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPassDescriptor()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLRenderPassDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPassDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("renderPassDescriptor")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLRenderPassDescriptor CreateRenderPassDescriptor()
	{
		using (new NSAutoreleasePool())
		{
			return Runtime.GetNSObject<MTLRenderPassDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selRenderPassDescriptorHandle));
		}
	}

	[Export("getSamplePositions:count:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetSamplePositions(IntPtr positions, nuint count)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetSamplePositions_Count_Handle, positions, count);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetSamplePositions_Count_Handle, positions, count);
	}

	[Export("setSamplePositions:count:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSamplePositions(IntPtr positions, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetSamplePositions_Count_Handle, positions, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetSamplePositions_Count_Handle, positions, count);
		}
	}
}
