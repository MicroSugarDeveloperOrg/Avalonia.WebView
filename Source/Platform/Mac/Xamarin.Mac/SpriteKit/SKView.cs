using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

[Register("SKView", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKView : NSView, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsTransparency = "allowsTransparency";

	private static readonly IntPtr selAllowsTransparencyHandle = Selector.GetHandle("allowsTransparency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_FromScene_ = "convertPoint:fromScene:";

	private static readonly IntPtr selConvertPoint_FromScene_Handle = Selector.GetHandle("convertPoint:fromScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToScene_ = "convertPoint:toScene:";

	private static readonly IntPtr selConvertPoint_ToScene_Handle = Selector.GetHandle("convertPoint:toScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameInterval = "frameInterval";

	private static readonly IntPtr selFrameIntervalHandle = Selector.GetHandle("frameInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoresSiblingOrder = "ignoresSiblingOrder";

	private static readonly IntPtr selIgnoresSiblingOrderHandle = Selector.GetHandle("ignoresSiblingOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAsynchronous = "isAsynchronous";

	private static readonly IntPtr selIsAsynchronousHandle = Selector.GetHandle("isAsynchronous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredFramesPerSecond = "preferredFramesPerSecond";

	private static readonly IntPtr selPreferredFramesPerSecondHandle = Selector.GetHandle("preferredFramesPerSecond");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentScene_ = "presentScene:";

	private static readonly IntPtr selPresentScene_Handle = Selector.GetHandle("presentScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentScene_Transition_ = "presentScene:transition:";

	private static readonly IntPtr selPresentScene_Transition_Handle = Selector.GetHandle("presentScene:transition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScene = "scene";

	private static readonly IntPtr selSceneHandle = Selector.GetHandle("scene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsTransparency_ = "setAllowsTransparency:";

	private static readonly IntPtr selSetAllowsTransparency_Handle = Selector.GetHandle("setAllowsTransparency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAsynchronous_ = "setAsynchronous:";

	private static readonly IntPtr selSetAsynchronous_Handle = Selector.GetHandle("setAsynchronous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameInterval_ = "setFrameInterval:";

	private static readonly IntPtr selSetFrameInterval_Handle = Selector.GetHandle("setFrameInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoresSiblingOrder_ = "setIgnoresSiblingOrder:";

	private static readonly IntPtr selSetIgnoresSiblingOrder_Handle = Selector.GetHandle("setIgnoresSiblingOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaused_ = "setPaused:";

	private static readonly IntPtr selSetPaused_Handle = Selector.GetHandle("setPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredFramesPerSecond_ = "setPreferredFramesPerSecond:";

	private static readonly IntPtr selSetPreferredFramesPerSecond_Handle = Selector.GetHandle("setPreferredFramesPerSecond:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCullNonVisibleNodes_ = "setShouldCullNonVisibleNodes:";

	private static readonly IntPtr selSetShouldCullNonVisibleNodes_Handle = Selector.GetHandle("setShouldCullNonVisibleNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsDrawCount_ = "setShowsDrawCount:";

	private static readonly IntPtr selSetShowsDrawCount_Handle = Selector.GetHandle("setShowsDrawCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsFPS_ = "setShowsFPS:";

	private static readonly IntPtr selSetShowsFPS_Handle = Selector.GetHandle("setShowsFPS:");

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
	private const string selShowsFPS = "showsFPS";

	private static readonly IntPtr selShowsFPSHandle = Selector.GetHandle("showsFPS");

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
	private const string selTextureFromNode_ = "textureFromNode:";

	private static readonly IntPtr selTextureFromNode_Handle = Selector.GetHandle("textureFromNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureFromNode_Crop_ = "textureFromNode:crop:";

	private static readonly IntPtr selTextureFromNode_Crop_Handle = Selector.GetHandle("textureFromNode:crop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool AllowsTransparency
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allowsTransparency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTransparencyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTransparencyHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAllowsTransparency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTransparency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTransparency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Asynchronous
	{
		[Export("isAsynchronous")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAsynchronousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAsynchronousHandle);
		}
		[Export("setAsynchronous:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAsynchronous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAsynchronous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual ISKViewDelegate? Delegate
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			ISKViewDelegate iSKViewDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ISKViewDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<ISKViewDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iSKViewDelegate;
			return iSKViewDelegate;
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
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
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	public virtual nint FrameInterval
	{
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("frameInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFrameIntervalHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFrameIntervalHandle);
		}
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFrameInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetFrameInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetFrameInterval_Handle, value);
			}
		}
	}

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
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual nint PreferredFramesPerSecond
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("preferredFramesPerSecond")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredFramesPerSecondHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredFramesPerSecondHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setPreferredFramesPerSecond:")]
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
	public virtual SKScene Scene
	{
		[Export("scene")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSend(base.Handle, selSceneHandle));
			}
			return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSceneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ShouldCullNonVisibleNodes
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shouldCullNonVisibleNodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCullNonVisibleNodesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCullNonVisibleNodesHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	public virtual bool ShowsFPS
	{
		[Export("showsFPS")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsFPSHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsFPSHandle);
		}
		[Export("setShowsFPS:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsFPS_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsFPS_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ShowsFields
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("showsFields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsFieldsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsFieldsHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ShowsPhysics
	{
		[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("showsPhysics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsPhysicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsPhysicsHandle);
		}
		[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool ShowsQuadCount
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("showsQuadCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsQuadCountHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsQuadCountHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Export("init")]
	public SKView()
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
	public SKView(NSCoder coder)
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
	protected SKView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("convertPoint:fromScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromScene(CGPoint point, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_FromScene_Handle, point, scene.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_FromScene_Handle, point, scene.Handle);
	}

	[Export("convertPoint:toScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToScene(CGPoint point, SKScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToScene_Handle, point, scene.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToScene_Handle, point, scene.Handle);
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

	[Export("presentScene:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentScene(SKScene? scene)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentScene_Handle, scene?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentScene_Handle, scene?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("presentScene:transition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentScene(SKScene scene, SKTransition transition)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		if (transition == null)
		{
			throw new ArgumentNullException("transition");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentScene_Transition_Handle, scene.Handle, transition.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentScene_Transition_Handle, scene.Handle, transition.Handle);
		}
	}

	[Export("textureFromNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture TextureFromNode(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTextureFromNode_Handle, node.Handle));
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextureFromNode_Handle, node.Handle));
	}

	[Export("textureFromNode:crop:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture TextureFromNode(SKNode node, CGRect crop)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(base.Handle, selTextureFromNode_Crop_Handle, node.Handle, crop));
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selTextureFromNode_Crop_Handle, node.Handle, crop));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
