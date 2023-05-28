using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using AppKit;
using AVFoundation;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;
using OpenGL;
using SpriteKit;

namespace SceneKit;

[Register("SCNRenderer", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class SCNRenderer : NSObject, ISCNSceneRenderer, INativeObject, IDisposable, ISCNTechniqueSupport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioEngine = "audioEngine";

	private static readonly IntPtr selAudioEngineHandle = Selector.GetHandle("audioEngine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioEnvironmentNode = "audioEnvironmentNode";

	private static readonly IntPtr selAudioEnvironmentNodeHandle = Selector.GetHandle("audioEnvironmentNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioListener = "audioListener";

	private static readonly IntPtr selAudioListenerHandle = Selector.GetHandle("audioListener");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoenablesDefaultLighting = "autoenablesDefaultLighting";

	private static readonly IntPtr selAutoenablesDefaultLightingHandle = Selector.GetHandle("autoenablesDefaultLighting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPixelFormat = "colorPixelFormat";

	private static readonly IntPtr selColorPixelFormatHandle = Selector.GetHandle("colorPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandQueue = "commandQueue";

	private static readonly IntPtr selCommandQueueHandle = Selector.GetHandle("commandQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContext = "context";

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRenderCommandEncoder = "currentRenderCommandEncoder";

	private static readonly IntPtr selCurrentRenderCommandEncoderHandle = Selector.GetHandle("currentRenderCommandEncoder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentViewport = "currentViewport";

	private static readonly IntPtr selCurrentViewportHandle = Selector.GetHandle("currentViewport");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDebugOptions = "debugOptions";

	private static readonly IntPtr selDebugOptionsHandle = Selector.GetHandle("debugOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthPixelFormat = "depthPixelFormat";

	private static readonly IntPtr selDepthPixelFormatHandle = Selector.GetHandle("depthPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitTest_Options_ = "hitTest:options:";

	private static readonly IntPtr selHitTest_Options_Handle = Selector.GetHandle("hitTest:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsJitteringEnabled = "isJitteringEnabled";

	private static readonly IntPtr selIsJitteringEnabledHandle = Selector.GetHandle("isJitteringEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNodeInsideFrustum_WithPointOfView_ = "isNodeInsideFrustum:withPointOfView:";

	private static readonly IntPtr selIsNodeInsideFrustum_WithPointOfView_Handle = Selector.GetHandle("isNodeInsideFrustum:withPointOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTemporalAntialiasingEnabled = "isTemporalAntialiasingEnabled";

	private static readonly IntPtr selIsTemporalAntialiasingEnabledHandle = Selector.GetHandle("isTemporalAntialiasingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoops = "loops";

	private static readonly IntPtr selLoopsHandle = Selector.GetHandle("loops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextFrameTime = "nextFrameTime";

	private static readonly IntPtr selNextFrameTimeHandle = Selector.GetHandle("nextFrameTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodesInsideFrustumWithPointOfView_ = "nodesInsideFrustumWithPointOfView:";

	private static readonly IntPtr selNodesInsideFrustumWithPointOfView_Handle = Selector.GetHandle("nodesInsideFrustumWithPointOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlaySKScene = "overlaySKScene";

	private static readonly IntPtr selOverlaySKSceneHandle = Selector.GetHandle("overlaySKScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfView = "pointOfView";

	private static readonly IntPtr selPointOfViewHandle = Selector.GetHandle("pointOfView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareObject_ShouldAbortBlock_ = "prepareObject:shouldAbortBlock:";

	private static readonly IntPtr selPrepareObject_ShouldAbortBlock_Handle = Selector.GetHandle("prepareObject:shouldAbortBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareObjects_WithCompletionHandler_ = "prepareObjects:withCompletionHandler:";

	private static readonly IntPtr selPrepareObjects_WithCompletionHandler_Handle = Selector.GetHandle("prepareObjects:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_ = "presentScene:withTransition:incomingPointOfView:completionHandler:";

	private static readonly IntPtr selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_Handle = Selector.GetHandle("presentScene:withTransition:incomingPointOfView:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjectPoint_ = "projectPoint:";

	private static readonly IntPtr selProjectPoint_Handle = Selector.GetHandle("projectPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender = "render";

	private static readonly IntPtr selRenderHandle = Selector.GetHandle("render");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderAtTime_ = "renderAtTime:";

	private static readonly IntPtr selRenderAtTime_Handle = Selector.GetHandle("renderAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_ = "renderAtTime:viewport:commandBuffer:passDescriptor:";

	private static readonly IntPtr selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_Handle = Selector.GetHandle("renderAtTime:viewport:commandBuffer:passDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderWithViewport_CommandBuffer_PassDescriptor_ = "renderWithViewport:commandBuffer:passDescriptor:";

	private static readonly IntPtr selRenderWithViewport_CommandBuffer_PassDescriptor_Handle = Selector.GetHandle("renderWithViewport:commandBuffer:passDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRendererWithContext_Options_ = "rendererWithContext:options:";

	private static readonly IntPtr selRendererWithContext_Options_Handle = Selector.GetHandle("rendererWithContext:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRendererWithDevice_Options_ = "rendererWithDevice:options:";

	private static readonly IntPtr selRendererWithDevice_Options_Handle = Selector.GetHandle("rendererWithDevice:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderingAPI = "renderingAPI";

	private static readonly IntPtr selRenderingAPIHandle = Selector.GetHandle("renderingAPI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScene = "scene";

	private static readonly IntPtr selSceneHandle = Selector.GetHandle("scene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneTime = "sceneTime";

	private static readonly IntPtr selSceneTimeHandle = Selector.GetHandle("sceneTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioListener_ = "setAudioListener:";

	private static readonly IntPtr selSetAudioListener_Handle = Selector.GetHandle("setAudioListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoenablesDefaultLighting_ = "setAutoenablesDefaultLighting:";

	private static readonly IntPtr selSetAutoenablesDefaultLighting_Handle = Selector.GetHandle("setAutoenablesDefaultLighting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentTime_ = "setCurrentTime:";

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDebugOptions_ = "setDebugOptions:";

	private static readonly IntPtr selSetDebugOptions_Handle = Selector.GetHandle("setDebugOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetJitteringEnabled_ = "setJitteringEnabled:";

	private static readonly IntPtr selSetJitteringEnabled_Handle = Selector.GetHandle("setJitteringEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoops_ = "setLoops:";

	private static readonly IntPtr selSetLoops_Handle = Selector.GetHandle("setLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverlaySKScene_ = "setOverlaySKScene:";

	private static readonly IntPtr selSetOverlaySKScene_Handle = Selector.GetHandle("setOverlaySKScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaying_ = "setPlaying:";

	private static readonly IntPtr selSetPlaying_Handle = Selector.GetHandle("setPlaying:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfView_ = "setPointOfView:";

	private static readonly IntPtr selSetPointOfView_Handle = Selector.GetHandle("setPointOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScene_ = "setScene:";

	private static readonly IntPtr selSetScene_Handle = Selector.GetHandle("setScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSceneTime_ = "setSceneTime:";

	private static readonly IntPtr selSetSceneTime_Handle = Selector.GetHandle("setSceneTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsStatistics_ = "setShowsStatistics:";

	private static readonly IntPtr selSetShowsStatistics_Handle = Selector.GetHandle("setShowsStatistics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTechnique_ = "setTechnique:";

	private static readonly IntPtr selSetTechnique_Handle = Selector.GetHandle("setTechnique:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTemporalAntialiasingEnabled_ = "setTemporalAntialiasingEnabled:";

	private static readonly IntPtr selSetTemporalAntialiasingEnabled_Handle = Selector.GetHandle("setTemporalAntialiasingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesReverseZ_ = "setUsesReverseZ:";

	private static readonly IntPtr selSetUsesReverseZ_Handle = Selector.GetHandle("setUsesReverseZ:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsStatistics = "showsStatistics";

	private static readonly IntPtr selShowsStatisticsHandle = Selector.GetHandle("showsStatistics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSnapshotAtTime_WithSize_AntialiasingMode_ = "snapshotAtTime:withSize:antialiasingMode:";

	private static readonly IntPtr selSnapshotAtTime_WithSize_AntialiasingMode_Handle = Selector.GetHandle("snapshotAtTime:withSize:antialiasingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStencilPixelFormat = "stencilPixelFormat";

	private static readonly IntPtr selStencilPixelFormatHandle = Selector.GetHandle("stencilPixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTechnique = "technique";

	private static readonly IntPtr selTechniqueHandle = Selector.GetHandle("technique");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnprojectPoint_ = "unprojectPoint:";

	private static readonly IntPtr selUnprojectPoint_Handle = Selector.GetHandle("unprojectPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateAtTime_ = "updateAtTime:";

	private static readonly IntPtr selUpdateAtTime_Handle = Selector.GetHandle("updateAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateProbes_AtTime_ = "updateProbes:atTime:";

	private static readonly IntPtr selUpdateProbes_AtTime_Handle = Selector.GetHandle("updateProbes:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesReverseZ = "usesReverseZ";

	private static readonly IntPtr selUsesReverseZHandle = Selector.GetHandle("usesReverseZ");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNRenderer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakSceneRendererDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVAudioEngine AudioEngine
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("audioEngine")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioEngine>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioEngineHandle));
			}
			return Runtime.GetNSObject<AVAudioEngine>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioEngineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVAudioEnvironmentNode AudioEnvironmentNode
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("audioEnvironmentNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioEnvironmentNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioEnvironmentNodeHandle));
			}
			return Runtime.GetNSObject<AVAudioEnvironmentNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioEnvironmentNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNNode? AudioListener
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("audioListener", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioListenerHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioListenerHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAudioListener:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioListener_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioListener_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool AutoenablesDefaultLighting
	{
		[Export("autoenablesDefaultLighting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoenablesDefaultLightingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoenablesDefaultLightingHandle);
		}
		[Export("setAutoenablesDefaultLighting:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoenablesDefaultLighting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoenablesDefaultLighting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual MTLPixelFormat ColorPixelFormat
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("colorPixelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selColorPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selColorPixelFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLCommandQueue? CommandQueue
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("commandQueue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandQueueHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandQueueHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "API removed, please do not use.")]
	public virtual IntPtr Context
	{
		[Obsoleted(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "API removed, please do not use.")]
		[Export("context")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLRenderCommandEncoder? CurrentRenderCommandEncoder
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("currentRenderCommandEncoder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentRenderCommandEncoderHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentRenderCommandEncoderHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual double CurrentTime
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("currentTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("setCurrentTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual CGRect CurrentViewport
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("currentViewport")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selCurrentViewportHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentViewportHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNDebugOptions DebugOptions
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("debugOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNDebugOptions)Messaging.UInt64_objc_msgSend(base.Handle, selDebugOptionsHandle);
			}
			return (SCNDebugOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDebugOptionsHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setDebugOptions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDebugOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDebugOptions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual MTLPixelFormat DepthPixelFormat
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("depthPixelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selDepthPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthPixelFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLDevice? Device
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool JitteringEnabled
	{
		[Export("isJitteringEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsJitteringEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsJitteringEnabledHandle);
		}
		[Export("setJitteringEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetJitteringEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetJitteringEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool Loops
	{
		[Export("loops")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLoopsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoopsHandle);
		}
		[Export("setLoops:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoops_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual double NextFrameTimeInSeconds
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("nextFrameTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selNextFrameTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selNextFrameTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKScene? OverlayScene
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("overlaySKScene", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSend(base.Handle, selOverlaySKSceneHandle));
			}
			return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOverlaySKSceneHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setOverlaySKScene:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOverlaySKScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOverlaySKScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual bool Playing
	{
		[Export("isPlaying")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
		}
		[Export("setPlaying:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPlaying_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPlaying_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual SCNNode PointOfView
	{
		[Export("pointOfView", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfViewHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfViewHandle));
		}
		[Export("setPointOfView:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfView_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SCNRenderingApi RenderingApi
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("renderingAPI")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNRenderingApi)Messaging.UInt64_objc_msgSend(base.Handle, selRenderingAPIHandle);
			}
			return (SCNRenderingApi)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRenderingAPIHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNScene? Scene
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("scene", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend(base.Handle, selSceneHandle));
			}
			return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSceneHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setScene:", ArgumentSemantic.Retain)]
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
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISCNSceneRendererDelegate SceneRendererDelegate
	{
		get
		{
			return WeakSceneRendererDelegate as ISCNSceneRendererDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakSceneRendererDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual double SceneTimeInSeconds
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sceneTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSceneTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSceneTimeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSceneTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetSceneTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetSceneTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool ShowsStatistics
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("showsStatistics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsStatisticsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsStatisticsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setShowsStatistics:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsStatistics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsStatistics_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual MTLPixelFormat StencilPixelFormat
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("stencilPixelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selStencilPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStencilPixelFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual SCNTechnique? Technique
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("technique", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNTechnique>(Messaging.IntPtr_objc_msgSend(base.Handle, selTechniqueHandle));
			}
			return Runtime.GetNSObject<SCNTechnique>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTechniqueHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setTechnique:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTechnique_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTechnique_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool TemporalAntialiasingEnabled
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isTemporalAntialiasingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemporalAntialiasingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemporalAntialiasingEnabledHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setTemporalAntialiasingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTemporalAntialiasingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTemporalAntialiasingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool UsesReverseZ
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("usesReverseZ")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesReverseZHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesReverseZHandle);
		}
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setUsesReverseZ:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesReverseZ_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesReverseZ_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual NSObject? WeakSceneRendererDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakSceneRendererDelegate_var = nSObject;
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
			__mt_WeakSceneRendererDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNRenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNRenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("rendererWithContext:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNRenderer FromContext(IntPtr context, NSDictionary? options)
	{
		return Runtime.GetNSObject<SCNRenderer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRendererWithContext_Options_Handle, context, options?.Handle ?? IntPtr.Zero));
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNRenderer FromContext(CGLContext context, NSDictionary? options)
	{
		return FromContext(context.GetHandle(), options);
	}

	[Export("rendererWithDevice:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNRenderer FromDevice(IMTLDevice? device, NSDictionary? options)
	{
		return Runtime.GetNSObject<SCNRenderer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRendererWithDevice_Options_Handle, device?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero));
	}

	[Export("nodesInsideFrustumWithPointOfView:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode[] GetNodesInsideFrustum(SCNNode pointOfView)
	{
		if (pointOfView == null)
		{
			throw new ArgumentNullException("pointOfView");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNodesInsideFrustumWithPointOfView_Handle, pointOfView.Handle));
		}
		return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNodesInsideFrustumWithPointOfView_Handle, pointOfView.Handle));
	}

	[Export("snapshotAtTime:withSize:antialiasingMode:")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetSnapshot(double time, CGSize size, SCNAntialiasingMode antialiasingMode)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_Double_CGSize_UInt64(base.Handle, selSnapshotAtTime_WithSize_AntialiasingMode_Handle, time, size, (ulong)antialiasingMode));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_Double_CGSize_UInt64(base.SuperHandle, selSnapshotAtTime_WithSize_AntialiasingMode_Handle, time, size, (ulong)antialiasingMode));
	}

	[Export("hitTest:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNHitTestResult[] HitTest(CGPoint thePoint, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr(base.Handle, selHitTest_Options_Handle, thePoint, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selHitTest_Options_Handle, thePoint, options?.Handle ?? IntPtr.Zero));
	}

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNHitTestResult[] HitTest(CGPoint thePoint, SCNHitTestOptions options)
	{
		return HitTest(thePoint, options.GetDictionary());
	}

	[Export("isNodeInsideFrustum:withPointOfView:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsNodeInsideFrustum(SCNNode node, SCNNode pointOfView)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (pointOfView == null)
		{
			throw new ArgumentNullException("pointOfView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsNodeInsideFrustum_WithPointOfView_Handle, node.Handle, pointOfView.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsNodeInsideFrustum_WithPointOfView_Handle, node.Handle, pointOfView.Handle);
	}

	[Export("prepareObject:shouldAbortBlock:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool Prepare(NSObject obj, [BlockProxy(typeof(Trampolines.NIDFuncArity1V0))] Func<bool>? abortHandler)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		BlockLiteral* ptr;
		if (abortHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity1V0.Handler, abortHandler);
		}
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrepareObject_ShouldAbortBlock_Handle, obj.Handle, (IntPtr)ptr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrepareObject_ShouldAbortBlock_Handle, obj.Handle, (IntPtr)ptr));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Export("prepareObjects:withCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Prepare(NSObject[] objects, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrepareObjects_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrepareObjects_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> PrepareAsync(NSObject[] objects)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Prepare(objects, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("presentScene:withTransition:incomingPointOfView:completionHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PresentScene(SCNScene scene, SKTransition transition, SCNNode? pointOfView, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		if (transition == null)
		{
			throw new ArgumentNullException("transition");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_Handle, scene.Handle, transition.Handle, pointOfView?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPresentScene_WithTransition_IncomingPointOfView_CompletionHandler_Handle, scene.Handle, transition.Handle, pointOfView?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task PresentSceneAsync(SCNScene scene, SKTransition transition, SCNNode? pointOfView)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PresentScene(scene, transition, pointOfView, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("projectPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 ProjectPoint(SCNVector3 point)
	{
		SCNVector3 retval;
		if (base.IsDirectBinding)
		{
			Messaging.SCNVector3_objc_msgSend_stret_SCNVector3(out retval, base.Handle, selProjectPoint_Handle, point);
		}
		else
		{
			Messaging.SCNVector3_objc_msgSendSuper_stret_SCNVector3(out retval, base.SuperHandle, selProjectPoint_Handle, point);
		}
		return retval;
	}

	[Export("render")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public virtual void Render()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRenderHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRenderHandle);
		}
	}

	[Export("renderAtTime:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(double timeInSeconds)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRenderAtTime_Handle, timeInSeconds);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRenderAtTime_Handle, timeInSeconds);
		}
	}

	[Export("renderAtTime:viewport:commandBuffer:passDescriptor:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render(double timeInSeconds, CGRect viewport, IMTLCommandBuffer commandBuffer, MTLRenderPassDescriptor renderPassDescriptor)
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
			Messaging.void_objc_msgSend_Double_CGRect_IntPtr_IntPtr(base.Handle, selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_Handle, timeInSeconds, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_CGRect_IntPtr_IntPtr(base.SuperHandle, selRenderAtTime_Viewport_CommandBuffer_PassDescriptor_Handle, timeInSeconds, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
	}

	[Export("renderWithViewport:commandBuffer:passDescriptor:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
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
			Messaging.void_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selRenderWithViewport_CommandBuffer_PassDescriptor_Handle, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selRenderWithViewport_CommandBuffer_PassDescriptor_Handle, viewport, commandBuffer.Handle, renderPassDescriptor.Handle);
		}
	}

	[Export("unprojectPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 UnprojectPoint(SCNVector3 point)
	{
		SCNVector3 retval;
		if (base.IsDirectBinding)
		{
			Messaging.SCNVector3_objc_msgSend_stret_SCNVector3(out retval, base.Handle, selUnprojectPoint_Handle, point);
		}
		else
		{
			Messaging.SCNVector3_objc_msgSendSuper_stret_SCNVector3(out retval, base.SuperHandle, selUnprojectPoint_Handle, point);
		}
		return retval;
	}

	[Export("updateProbes:atTime:")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(SCNNode[] lightProbes, double time)
	{
		if (lightProbes == null)
		{
			throw new ArgumentNullException("lightProbes");
		}
		NSArray nSArray = NSArray.FromNSObjects(lightProbes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selUpdateProbes_AtTime_Handle, nSArray.Handle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selUpdateProbes_AtTime_Handle, nSArray.Handle, time);
		}
		nSArray.Dispose();
	}

	[Export("updateAtTime:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selUpdateAtTime_Handle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selUpdateAtTime_Handle, time);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakSceneRendererDelegate_var = null;
		}
	}
}
