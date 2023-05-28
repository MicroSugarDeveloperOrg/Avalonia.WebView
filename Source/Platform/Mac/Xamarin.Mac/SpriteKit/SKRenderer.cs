using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKRenderer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SKRenderer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoresSiblingOrder = "ignoresSiblingOrder";

	private static readonly IntPtr selIgnoresSiblingOrderHandle = Selector.GetHandle("ignoresSiblingOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderWithViewport_CommandBuffer_RenderPassDescriptor_ = "renderWithViewport:commandBuffer:renderPassDescriptor:";

	private static readonly IntPtr selRenderWithViewport_CommandBuffer_RenderPassDescriptor_Handle = Selector.GetHandle("renderWithViewport:commandBuffer:renderPassDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_ = "renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:";

	private static readonly IntPtr selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_Handle = Selector.GetHandle("renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRendererWithDevice_ = "rendererWithDevice:";

	private static readonly IntPtr selRendererWithDevice_Handle = Selector.GetHandle("rendererWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScene = "scene";

	private static readonly IntPtr selSceneHandle = Selector.GetHandle("scene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoresSiblingOrder_ = "setIgnoresSiblingOrder:";

	private static readonly IntPtr selSetIgnoresSiblingOrder_Handle = Selector.GetHandle("setIgnoresSiblingOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScene_ = "setScene:";

	private static readonly IntPtr selSetScene_Handle = Selector.GetHandle("setScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCullNonVisibleNodes_ = "setShouldCullNonVisibleNodes:";

	private static readonly IntPtr selSetShouldCullNonVisibleNodes_Handle = Selector.GetHandle("setShouldCullNonVisibleNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsDrawCount_ = "setShowsDrawCount:";

	private static readonly IntPtr selSetShowsDrawCount_Handle = Selector.GetHandle("setShowsDrawCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsFields_ = "setShowsFields:";

	private static readonly IntPtr selSetShowsFields_Handle = Selector.GetHandle("setShowsFields:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsNodeCount_ = "setShowsNodeCount:";

	private static readonly IntPtr selSetShowsNodeCount_Handle = Selector.GetHandle("setShowsNodeCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsPhysics_ = "setShowsPhysics:";

	private static readonly IntPtr selSetShowsPhysics_Handle = Selector.GetHandle("setShowsPhysics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsQuadCount_ = "setShowsQuadCount:";

	private static readonly IntPtr selSetShowsQuadCount_Handle = Selector.GetHandle("setShowsQuadCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCullNonVisibleNodes = "shouldCullNonVisibleNodes";

	private static readonly IntPtr selShouldCullNonVisibleNodesHandle = Selector.GetHandle("shouldCullNonVisibleNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsDrawCount = "showsDrawCount";

	private static readonly IntPtr selShowsDrawCountHandle = Selector.GetHandle("showsDrawCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsFields = "showsFields";

	private static readonly IntPtr selShowsFieldsHandle = Selector.GetHandle("showsFields");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsNodeCount = "showsNodeCount";

	private static readonly IntPtr selShowsNodeCountHandle = Selector.GetHandle("showsNodeCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsPhysics = "showsPhysics";

	private static readonly IntPtr selShowsPhysicsHandle = Selector.GetHandle("showsPhysics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsQuadCount = "showsQuadCount";

	private static readonly IntPtr selShowsQuadCountHandle = Selector.GetHandle("showsQuadCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateAtTime_ = "updateAtTime:";

	private static readonly IntPtr selUpdateAtTime_Handle = Selector.GetHandle("updateAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKRenderer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Scene_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IgnoresSiblingOrder
	{
		[Export("ignoresSiblingOrder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIgnoresSiblingOrderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIgnoresSiblingOrderHandle);
		}
		[Export("setIgnoresSiblingOrder:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIgnoresSiblingOrder_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIgnoresSiblingOrder_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKScene? Scene
	{
		[Export("scene", ArgumentSemantic.Assign)]
		get
		{
			SKScene sKScene = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSceneHandle)) : Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSend(base.Handle, selSceneHandle)));
			MarkDirty();
			__mt_Scene_var = sKScene;
			return sKScene;
		}
		[Export("setScene:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Scene_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCullNonVisibleNodes
	{
		[Export("shouldCullNonVisibleNodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCullNonVisibleNodesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCullNonVisibleNodesHandle);
		}
		[Export("setShouldCullNonVisibleNodes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCullNonVisibleNodes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCullNonVisibleNodes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsDrawCount
	{
		[Export("showsDrawCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsDrawCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsDrawCountHandle);
		}
		[Export("setShowsDrawCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsDrawCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsDrawCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsFields
	{
		[Export("showsFields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsFieldsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsFieldsHandle);
		}
		[Export("setShowsFields:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsFields_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsFields_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsNodeCount
	{
		[Export("showsNodeCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsNodeCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsNodeCountHandle);
		}
		[Export("setShowsNodeCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsNodeCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsNodeCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsPhysics
	{
		[Export("showsPhysics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPhysicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPhysicsHandle);
		}
		[Export("setShowsPhysics:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsPhysics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsPhysics_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsQuadCount
	{
		[Export("showsQuadCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsQuadCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsQuadCountHandle);
		}
		[Export("setShowsQuadCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsQuadCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsQuadCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("rendererWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRenderer FromDevice(IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetNSObject<SKRenderer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRendererWithDevice_Handle, device.Handle));
	}

	[Export("renderWithViewport:commandBuffer:renderPassDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CGRect viewport, IMTLCommandBuffer commandBuffer, MTLRenderPassDescriptor renderPassDescriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selRenderWithViewport_CommandBuffer_RenderPassDescriptor_Handle, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selRenderWithViewport_CommandBuffer_RenderPassDescriptor_Handle, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
	}

	[Export("renderWithViewport:renderCommandEncoder:renderPassDescriptor:commandQueue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(CGRect viewport, IMTLRenderCommandEncoder renderCommandEncoder, MTLRenderPassDescriptor renderPassDescriptor, IMTLCommandQueue commandQueue)
	{
		if (renderCommandEncoder == null)
		{
			throw new ArgumentNullException("renderCommandEncoder");
		}
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr(base.Handle, selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_Handle, viewport, renderCommandEncoder.Handle, renderPassDescriptor.Handle, commandQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRenderWithViewport_RenderCommandEncoder_RenderPassDescriptor_CommandQueue_Handle, viewport, renderCommandEncoder.Handle, renderPassDescriptor.Handle, commandQueue.Handle);
		}
	}

	[Export("updateAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double currentTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selUpdateAtTime_Handle, currentTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selUpdateAtTime_Handle, currentTime);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Scene_var = null;
		}
	}
}
