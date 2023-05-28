using System;
using System.Threading.Tasks;
using AVFoundation;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;
using SpriteKit;

namespace SceneKit;

public static class SCNSceneRenderer_Extensions
{
	public static SCNHitTestResult[] HitTest(ISCNSceneRenderer This, CGPoint thePoint, SCNHitTestOptions options)
	{
		return This.HitTest(thePoint, options?.Dictionary);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void PresentScene(this ISCNSceneRenderer This, SCNScene scene, SKTransition transition, SCNNode? pointOfView, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("presentScene:withTransition:incomingPointOfView:completionHandler:"), scene.Handle, transition.Handle, pointOfView?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task PresentSceneAsync(this ISCNSceneRenderer This, SCNScene scene, SKTransition transition, SCNNode? pointOfView)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		This.PresentScene(scene, transition, pointOfView, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNNode[] GetNodesInsideFrustum(this ISCNSceneRenderer This, SCNNode pointOfView)
	{
		if (pointOfView == null)
		{
			throw new ArgumentNullException("pointOfView");
		}
		return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("nodesInsideFrustumWithPointOfView:"), pointOfView.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<bool> PrepareAsync(this ISCNSceneRenderer This, NSObject[] objects)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		This.Prepare(objects, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetCurrentTime(this ISCNSceneRenderer This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("currentTime"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetCurrentTime(this ISCNSceneRenderer This, double value)
	{
		Messaging.void_objc_msgSend_Double(This.Handle, Selector.GetHandle("setCurrentTime:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNDebugOptions GetDebugOptions(this ISCNSceneRenderer This)
	{
		return (SCNDebugOptions)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("debugOptions"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDebugOptions(this ISCNSceneRenderer This, SCNDebugOptions value)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDebugOptions:"), (ulong)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNRenderingApi GetRenderingApi(this ISCNSceneRenderer This)
	{
		return (SCNRenderingApi)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("renderingAPI"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLRenderCommandEncoder GetCurrentRenderCommandEncoder(this ISCNSceneRenderer This)
	{
		return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("currentRenderCommandEncoder")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLDevice GetDevice(this ISCNSceneRenderer This)
	{
		return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("device")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLPixelFormat GetColorPixelFormat(this ISCNSceneRenderer This)
	{
		return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("colorPixelFormat"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLPixelFormat GetDepthPixelFormat(this ISCNSceneRenderer This)
	{
		return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("depthPixelFormat"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLPixelFormat GetStencilPixelFormat(this ISCNSceneRenderer This)
	{
		return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("stencilPixelFormat"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLCommandQueue GetCommandQueue(this ISCNSceneRenderer This)
	{
		return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("commandQueue")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudioEngine GetAudioEngine(this ISCNSceneRenderer This)
	{
		return Runtime.GetNSObject<AVAudioEngine>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("audioEngine")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudioEnvironmentNode GetAudioEnvironmentNode(this ISCNSceneRenderer This)
	{
		return Runtime.GetNSObject<AVAudioEnvironmentNode>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("audioEnvironmentNode")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNNode GetAudioListener(this ISCNSceneRenderer This)
	{
		return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("audioListener")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAudioListener(this ISCNSceneRenderer This, SCNNode value)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setAudioListener:"), value?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetTemporalAntialiasingEnabled(this ISCNSceneRenderer This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("temporalAntialiasingEnabled"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTemporalAntialiasingEnabled(this ISCNSceneRenderer This, bool value)
	{
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setTemporalAntialiasingEnabled:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetCurrentViewport(this ISCNSceneRenderer This)
	{
		Messaging.CGRect_objc_msgSend_stret(out var retval, This.Handle, Selector.GetHandle("currentViewport"));
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetUsesReverseZ(this ISCNSceneRenderer This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("usesReverseZ"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetUsesReverseZ(this ISCNSceneRenderer This, bool value)
	{
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setUsesReverseZ:"), value);
	}
}
