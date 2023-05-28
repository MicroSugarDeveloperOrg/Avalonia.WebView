using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SpriteKit;

namespace SceneKit;

internal sealed class SCNSceneRendererWrapper : BaseWrapper, ISCNSceneRenderer, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject? WeakSceneRendererDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("delegate")));
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setDelegate:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Playing
	{
		[Export("isPlaying")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isPlaying"));
		}
		[Export("setPlaying:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setPlaying:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Loops
	{
		[Export("loops")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("loops"));
		}
		[Export("setLoops:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setLoops:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNNode PointOfView
	{
		[Export("pointOfView", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("pointOfView")));
		}
		[Export("setPointOfView:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setPointOfView:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AutoenablesDefaultLighting
	{
		[Export("autoenablesDefaultLighting")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("autoenablesDefaultLighting"));
		}
		[Export("setAutoenablesDefaultLighting:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAutoenablesDefaultLighting:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool JitteringEnabled
	{
		[Export("isJitteringEnabled")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isJitteringEnabled"));
		}
		[Export("setJitteringEnabled:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setJitteringEnabled:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsoleted(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "API removed, please do not use.")]
	public IntPtr Context
	{
		[Obsoleted(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "API removed, please do not use.")]
		[Export("context")]
		get
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("context"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public bool ShowsStatistics
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("showsStatistics")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("showsStatistics"));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setShowsStatistics:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setShowsStatistics:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double SceneTimeInSeconds
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sceneTime")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("sceneTime"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSceneTime:")]
		set
		{
			Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("setSceneTime:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public SCNScene? Scene
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("scene", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("scene")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setScene:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setScene:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public SKScene? OverlayScene
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("overlaySKScene", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<SKScene>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("overlaySKScene")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setOverlaySKScene:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setOverlaySKScene:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[Preserve(Conditional = true)]
	public SCNSceneRendererWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("hitTest:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNHitTestResult[] HitTest(CGPoint thePoint, NSDictionary? options)
	{
		return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr(base.Handle, Selector.GetHandle("hitTest:options:"), thePoint, options?.Handle ?? IntPtr.Zero));
	}

	[Export("isNodeInsideFrustum:withPointOfView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsNodeInsideFrustum(SCNNode node, SCNNode pointOfView)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (pointOfView == null)
		{
			throw new ArgumentNullException("pointOfView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("isNodeInsideFrustum:withPointOfView:"), node.Handle, pointOfView.Handle);
	}

	[Export("projectPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNVector3 ProjectPoint(SCNVector3 point)
	{
		Messaging.SCNVector3_objc_msgSend_stret_SCNVector3(out var retval, base.Handle, Selector.GetHandle("projectPoint:"), point);
		return retval;
	}

	[Export("unprojectPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNVector3 UnprojectPoint(SCNVector3 point)
	{
		Messaging.SCNVector3_objc_msgSend_stret_SCNVector3(out var retval, base.Handle, Selector.GetHandle("unprojectPoint:"), point);
		return retval;
	}

	[Export("prepareObject:shouldAbortBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe bool Prepare(NSObject obj, [BlockProxy(typeof(Trampolines.NIDFuncArity1V0))] Func<bool>? abortHandler)
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
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("prepareObject:shouldAbortBlock:"), obj.Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Export("prepareObjects:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void Prepare(NSObject[] objects, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("prepareObjects:withCompletionHandler:"), nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
