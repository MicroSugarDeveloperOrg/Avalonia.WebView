using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;
using SceneKit;

namespace SpriteKit;

[Register("SK3DNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SK3DNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoenablesDefaultLighting = "autoenablesDefaultLighting";

	private static readonly IntPtr selAutoenablesDefaultLightingHandle = Selector.GetHandle("autoenablesDefaultLighting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitTest_Options_ = "hitTest:options:";

	private static readonly IntPtr selHitTest_Options_Handle = Selector.GetHandle("hitTest:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithViewportSize_ = "initWithViewportSize:";

	private static readonly IntPtr selInitWithViewportSize_Handle = Selector.GetHandle("initWithViewportSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoops = "loops";

	private static readonly IntPtr selLoopsHandle = Selector.GetHandle("loops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithViewportSize_ = "nodeWithViewportSize:";

	private static readonly IntPtr selNodeWithViewportSize_Handle = Selector.GetHandle("nodeWithViewportSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfView = "pointOfView";

	private static readonly IntPtr selPointOfViewHandle = Selector.GetHandle("pointOfView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjectPoint_ = "projectPoint:";

	private static readonly IntPtr selProjectPoint_Handle = Selector.GetHandle("projectPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneTime = "sceneTime";

	private static readonly IntPtr selSceneTimeHandle = Selector.GetHandle("sceneTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScnScene = "scnScene";

	private static readonly IntPtr selScnSceneHandle = Selector.GetHandle("scnScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoenablesDefaultLighting_ = "setAutoenablesDefaultLighting:";

	private static readonly IntPtr selSetAutoenablesDefaultLighting_Handle = Selector.GetHandle("setAutoenablesDefaultLighting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoops_ = "setLoops:";

	private static readonly IntPtr selSetLoops_Handle = Selector.GetHandle("setLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaying_ = "setPlaying:";

	private static readonly IntPtr selSetPlaying_Handle = Selector.GetHandle("setPlaying:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfView_ = "setPointOfView:";

	private static readonly IntPtr selSetPointOfView_Handle = Selector.GetHandle("setPointOfView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSceneTime_ = "setSceneTime:";

	private static readonly IntPtr selSetSceneTime_Handle = Selector.GetHandle("setSceneTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScnScene_ = "setScnScene:";

	private static readonly IntPtr selSetScnScene_Handle = Selector.GetHandle("setScnScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViewportSize_ = "setViewportSize:";

	private static readonly IntPtr selSetViewportSize_Handle = Selector.GetHandle("setViewportSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnprojectPoint_ = "unprojectPoint:";

	private static readonly IntPtr selUnprojectPoint_Handle = Selector.GetHandle("unprojectPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewportSize = "viewportSize";

	private static readonly IntPtr selViewportSizeHandle = Selector.GetHandle("viewportSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SK3DNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	public virtual SCNNode? PointOfView
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double SceneTime
	{
		[Export("sceneTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSceneTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSceneTimeHandle);
		}
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
	public virtual SCNScene? ScnScene
	{
		[Export("scnScene", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend(base.Handle, selScnSceneHandle));
			}
			return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScnSceneHandle));
		}
		[Export("setScnScene:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScnScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScnScene_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ViewportSize
	{
		[Export("viewportSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selViewportSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selViewportSizeHandle);
		}
		[Export("setViewportSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetViewportSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetViewportSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SK3DNode()
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
	public SK3DNode(NSCoder coder)
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
	protected SK3DNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SK3DNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithViewportSize:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SK3DNode(CGSize viewportSize)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithViewportSize_Handle, viewportSize), "initWithViewportSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithViewportSize_Handle, viewportSize), "initWithViewportSize:");
		}
	}

	[Export("nodeWithViewportSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SK3DNode FromViewportSize(CGSize viewportSize)
	{
		return Runtime.GetNSObject<SK3DNode>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selNodeWithViewportSize_Handle, viewportSize));
	}

	[Export("hitTest:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNHitTestResult[] HitTest(CGPoint thePoint, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr(base.Handle, selHitTest_Options_Handle, thePoint, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selHitTest_Options_Handle, thePoint, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNHitTestResult[] HitTest(CGPoint thePoint, SCNHitTestOptions options)
	{
		return HitTest(thePoint, options.GetDictionary());
	}

	[Export("projectPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 ProjectPoint(Vector3 point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Vector3(base.Handle, selProjectPoint_Handle, point);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector3(base.SuperHandle, selProjectPoint_Handle, point);
	}

	[Export("unprojectPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 UnprojectPoint(Vector3 point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Vector3(base.Handle, selUnprojectPoint_Handle, point);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector3(base.SuperHandle, selUnprojectPoint_Handle, point);
	}
}
