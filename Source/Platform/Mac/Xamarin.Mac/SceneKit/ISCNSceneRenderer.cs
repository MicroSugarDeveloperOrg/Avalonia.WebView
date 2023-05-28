using System;
using System.ComponentModel;
using AVFoundation;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;
using SpriteKit;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNSceneRenderer", WrapperType = typeof(SCNSceneRendererWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HitTest", Selector = "hitTest:options:", ReturnType = typeof(SCNHitTestResult[]), ParameterType = new Type[]
{
	typeof(CGPoint),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsNodeInsideFrustum", Selector = "isNodeInsideFrustum:withPointOfView:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SCNNode),
	typeof(SCNNode)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProjectPoint", Selector = "projectPoint:", ReturnType = typeof(SCNVector3), ParameterType = new Type[] { typeof(SCNVector3) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnprojectPoint", Selector = "unprojectPoint:", ReturnType = typeof(SCNVector3), ParameterType = new Type[] { typeof(SCNVector3) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Prepare", Selector = "prepareObject:shouldAbortBlock:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(Func<bool>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDFuncArity1V0)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Prepare", Selector = "prepareObjects:withCompletionHandler:", ParameterType = new Type[]
{
	typeof(NSObject[]),
	typeof(Action<bool>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V0)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentScene", Selector = "presentScene:withTransition:incomingPointOfView:completionHandler:", ParameterType = new Type[]
{
	typeof(SCNScene),
	typeof(SKTransition),
	typeof(SCNNode),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetNodesInsideFrustum", Selector = "nodesInsideFrustumWithPointOfView:", ReturnType = typeof(SCNNode[]), ParameterType = new Type[] { typeof(SCNNode) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakSceneRendererDelegate", Selector = "delegate", PropertyType = typeof(NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Playing", Selector = "playing", PropertyType = typeof(bool), GetterSelector = "isPlaying", SetterSelector = "setPlaying:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Loops", Selector = "loops", PropertyType = typeof(bool), GetterSelector = "loops", SetterSelector = "setLoops:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PointOfView", Selector = "pointOfView", PropertyType = typeof(SCNNode), GetterSelector = "pointOfView", SetterSelector = "setPointOfView:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoenablesDefaultLighting", Selector = "autoenablesDefaultLighting", PropertyType = typeof(bool), GetterSelector = "autoenablesDefaultLighting", SetterSelector = "setAutoenablesDefaultLighting:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "JitteringEnabled", Selector = "jitteringEnabled", PropertyType = typeof(bool), GetterSelector = "isJitteringEnabled", SetterSelector = "setJitteringEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Context", Selector = "context", PropertyType = typeof(IntPtr), GetterSelector = "context", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentTime", Selector = "currentTime", PropertyType = typeof(double), GetterSelector = "currentTime", SetterSelector = "setCurrentTime:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShowsStatistics", Selector = "showsStatistics", PropertyType = typeof(bool), GetterSelector = "showsStatistics", SetterSelector = "setShowsStatistics:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SceneTimeInSeconds", Selector = "sceneTime", PropertyType = typeof(double), GetterSelector = "sceneTime", SetterSelector = "setSceneTime:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Scene", Selector = "scene", PropertyType = typeof(SCNScene), GetterSelector = "scene", SetterSelector = "setScene:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "OverlayScene", Selector = "overlaySKScene", PropertyType = typeof(SKScene), GetterSelector = "overlaySKScene", SetterSelector = "setOverlaySKScene:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DebugOptions", Selector = "debugOptions", PropertyType = typeof(SCNDebugOptions), GetterSelector = "debugOptions", SetterSelector = "setDebugOptions:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RenderingApi", Selector = "renderingAPI", PropertyType = typeof(SCNRenderingApi), GetterSelector = "renderingAPI", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentRenderCommandEncoder", Selector = "currentRenderCommandEncoder", PropertyType = typeof(IMTLRenderCommandEncoder), GetterSelector = "currentRenderCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ColorPixelFormat", Selector = "colorPixelFormat", PropertyType = typeof(MTLPixelFormat), GetterSelector = "colorPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DepthPixelFormat", Selector = "depthPixelFormat", PropertyType = typeof(MTLPixelFormat), GetterSelector = "depthPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "StencilPixelFormat", Selector = "stencilPixelFormat", PropertyType = typeof(MTLPixelFormat), GetterSelector = "stencilPixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CommandQueue", Selector = "commandQueue", PropertyType = typeof(IMTLCommandQueue), GetterSelector = "commandQueue", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AudioEngine", Selector = "audioEngine", PropertyType = typeof(AVAudioEngine), GetterSelector = "audioEngine", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AudioEnvironmentNode", Selector = "audioEnvironmentNode", PropertyType = typeof(AVAudioEnvironmentNode), GetterSelector = "audioEnvironmentNode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AudioListener", Selector = "audioListener", PropertyType = typeof(SCNNode), GetterSelector = "audioListener", SetterSelector = "setAudioListener:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "TemporalAntialiasingEnabled", Selector = "temporalAntialiasingEnabled", PropertyType = typeof(bool), GetterSelector = "isTemporalAntialiasingEnabled", SetterSelector = "setTemporalAntialiasingEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentViewport", Selector = "currentViewport", PropertyType = typeof(CGRect), GetterSelector = "currentViewport", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "UsesReverseZ", Selector = "usesReverseZ", PropertyType = typeof(bool), GetterSelector = "usesReverseZ", SetterSelector = "setUsesReverseZ:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISCNSceneRenderer : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSObject? WeakSceneRendererDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get;
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set;
	}

	[Preserve(Conditional = true)]
	bool Playing
	{
		[Export("isPlaying")]
		get;
		[Export("setPlaying:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool Loops
	{
		[Export("loops")]
		get;
		[Export("setLoops:")]
		set;
	}

	[Preserve(Conditional = true)]
	SCNNode PointOfView
	{
		[Export("pointOfView", ArgumentSemantic.Retain)]
		get;
		[Export("setPointOfView:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	bool AutoenablesDefaultLighting
	{
		[Export("autoenablesDefaultLighting")]
		get;
		[Export("setAutoenablesDefaultLighting:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool JitteringEnabled
	{
		[Export("isJitteringEnabled")]
		get;
		[Export("setJitteringEnabled:")]
		set;
	}

	[Preserve(Conditional = true)]
	IntPtr Context
	{
		[Export("context")]
		get;
	}

	[Preserve(Conditional = true)]
	bool ShowsStatistics
	{
		[Export("showsStatistics")]
		get;
		[Export("setShowsStatistics:")]
		set;
	}

	[Preserve(Conditional = true)]
	double SceneTimeInSeconds
	{
		[Export("sceneTime")]
		get;
		[Export("setSceneTime:")]
		set;
	}

	[Preserve(Conditional = true)]
	SCNScene? Scene
	{
		[Export("scene", ArgumentSemantic.Retain)]
		get;
		[Export("setScene:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	SKScene? OverlayScene
	{
		[Export("overlaySKScene", ArgumentSemantic.Retain)]
		get;
		[Export("setOverlaySKScene:", ArgumentSemantic.Retain)]
		set;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("hitTest:options:")]
	[Preserve(Conditional = true)]
	SCNHitTestResult[] HitTest(CGPoint thePoint, NSDictionary? options);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isNodeInsideFrustum:withPointOfView:")]
	[Preserve(Conditional = true)]
	bool IsNodeInsideFrustum(SCNNode node, SCNNode pointOfView);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("projectPoint:")]
	[Preserve(Conditional = true)]
	SCNVector3 ProjectPoint(SCNVector3 point);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("unprojectPoint:")]
	[Preserve(Conditional = true)]
	SCNVector3 UnprojectPoint(SCNVector3 point);

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("prepareObject:shouldAbortBlock:")]
	[Preserve(Conditional = true)]
	bool Prepare(NSObject obj, [BlockProxy(typeof(Trampolines.NIDFuncArity1V0))] Func<bool>? abortHandler);

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("prepareObjects:withCompletionHandler:")]
	[Preserve(Conditional = true)]
	void Prepare(NSObject[] objects, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler);
}
