using System;
using System.ComponentModel;
using AppKit;
using AVFoundation;
using CoreGraphics;
using Foundation;
using GameplayKit;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKScene", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKScene : SKEffectNode, IGKSceneRootNodeType, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPoint = "anchorPoint";

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioEngine = "audioEngine";

	private static readonly IntPtr selAudioEngineHandle = Selector.GetHandle("audioEngine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCamera = "camera";

	private static readonly IntPtr selCameraHandle = Selector.GetHandle("camera");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointFromView_ = "convertPointFromView:";

	private static readonly IntPtr selConvertPointFromView_Handle = Selector.GetHandle("convertPointFromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPointToView_ = "convertPointToView:";

	private static readonly IntPtr selConvertPointToView_Handle = Selector.GetHandle("convertPointToView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidApplyConstraints = "didApplyConstraints";

	private static readonly IntPtr selDidApplyConstraintsHandle = Selector.GetHandle("didApplyConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeSize_ = "didChangeSize:";

	private static readonly IntPtr selDidChangeSize_Handle = Selector.GetHandle("didChangeSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidEvaluateActions = "didEvaluateActions";

	private static readonly IntPtr selDidEvaluateActionsHandle = Selector.GetHandle("didEvaluateActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidFinishUpdate = "didFinishUpdate";

	private static readonly IntPtr selDidFinishUpdateHandle = Selector.GetHandle("didFinishUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidMoveToView_ = "didMoveToView:";

	private static readonly IntPtr selDidMoveToView_Handle = Selector.GetHandle("didMoveToView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidSimulatePhysics = "didSimulatePhysics";

	private static readonly IntPtr selDidSimulatePhysicsHandle = Selector.GetHandle("didSimulatePhysics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_ = "initWithSize:";

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selListener = "listener";

	private static readonly IntPtr selListenerHandle = Selector.GetHandle("listener");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicsWorld = "physicsWorld";

	private static readonly IntPtr selPhysicsWorldHandle = Selector.GetHandle("physicsWorld");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleMode = "scaleMode";

	private static readonly IntPtr selScaleModeHandle = Selector.GetHandle("scaleMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneDidLoad = "sceneDidLoad";

	private static readonly IntPtr selSceneDidLoadHandle = Selector.GetHandle("sceneDidLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithSize_ = "sceneWithSize:";

	private static readonly IntPtr selSceneWithSize_Handle = Selector.GetHandle("sceneWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPoint_ = "setAnchorPoint:";

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCamera_ = "setCamera:";

	private static readonly IntPtr selSetCamera_Handle = Selector.GetHandle("setCamera:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetListener_ = "setListener:";

	private static readonly IntPtr selSetListener_Handle = Selector.GetHandle("setListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleMode_ = "setScaleMode:";

	private static readonly IntPtr selSetScaleMode_Handle = Selector.GetHandle("setScaleMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdate_ = "update:";

	private static readonly IntPtr selUpdate_Handle = Selector.GetHandle("update:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillMoveFromView_ = "willMoveFromView:";

	private static readonly IntPtr selWillMoveFromView_Handle = Selector.GetHandle("willMoveFromView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Camera_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Listener_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_View_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVAudioEngine AudioEngine
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("audioEngine", ArgumentSemantic.Retain)]
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
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SKCameraNode? Camera
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("camera", ArgumentSemantic.Weak)]
		get
		{
			SKCameraNode sKCameraNode = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKCameraNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraHandle)) : Runtime.GetNSObject<SKCameraNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraHandle)));
			MarkDirty();
			__mt_Camera_var = sKCameraNode;
			return sKCameraNode;
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setCamera:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCamera_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCamera_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Camera_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public ISKSceneDelegate Delegate
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			return WeakDelegate as ISKSceneDelegate;
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SKNode? Listener
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("listener", ArgumentSemantic.Weak)]
		get
		{
			SKNode sKNode = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selListenerHandle)) : Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selListenerHandle)));
			MarkDirty();
			__mt_Listener_var = sKNode;
			return sKNode;
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setListener:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetListener_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetListener_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Listener_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsWorld PhysicsWorld
	{
		[Export("physicsWorld")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPhysicsWorld>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhysicsWorldHandle));
			}
			return Runtime.GetNSObject<SKPhysicsWorld>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhysicsWorldHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKSceneScaleMode ScaleMode
	{
		[Export("scaleMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKSceneScaleMode)Messaging.Int64_objc_msgSend(base.Handle, selScaleModeHandle);
			}
			return (SKSceneScaleMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScaleModeHandle);
		}
		[Export("setScaleMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScaleMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScaleMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual SKView View
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("view", ArgumentSemantic.Weak)]
		get
		{
			SKView sKView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle)) : Runtime.GetNSObject<SKView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle)));
			MarkDirty();
			__mt_View_var = sKView;
			return sKView;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSObject? WeakDelegate
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKScene()
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
	public SKScene(NSCoder coder)
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
	protected SKScene(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKScene(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKScene(CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, size), "initWithSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithSize_Handle, size), "initWithSize:");
		}
	}

	[Export("convertPointFromView:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromView(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointFromView_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointFromView_Handle, point);
	}

	[Export("convertPointToView:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToView(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selConvertPointToView_Handle, point);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selConvertPointToView_Handle, point);
	}

	[Export("didApplyConstraints")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidApplyConstraints()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidApplyConstraintsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidApplyConstraintsHandle);
		}
	}

	[Export("didChangeSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeSize(CGSize oldSize)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selDidChangeSize_Handle, oldSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selDidChangeSize_Handle, oldSize);
		}
	}

	[Export("didEvaluateActions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEvaluateActions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidEvaluateActionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidEvaluateActionsHandle);
		}
	}

	[Export("didFinishUpdate")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishUpdate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidFinishUpdateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidFinishUpdateHandle);
		}
	}

	[Export("didMoveToView:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidMoveToView(SKView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidMoveToView_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidMoveToView_Handle, view.Handle);
		}
	}

	[Export("didSimulatePhysics")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSimulatePhysics()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidSimulatePhysicsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidSimulatePhysicsHandle);
		}
	}

	[Export("sceneWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKScene FromSize(CGSize size)
	{
		return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selSceneWithSize_Handle, size));
	}

	[Export("sceneDidLoad")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SceneDidLoad()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSceneDidLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSceneDidLoadHandle);
		}
	}

	[Export("update:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double currentTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selUpdate_Handle, currentTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selUpdate_Handle, currentTime);
		}
	}

	[Export("willMoveFromView:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillMoveFromView(SKView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillMoveFromView_Handle, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillMoveFromView_Handle, view.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Camera_var = null;
			__mt_Listener_var = null;
			__mt_View_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
