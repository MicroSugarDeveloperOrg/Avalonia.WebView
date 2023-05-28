using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNAnimatable", WrapperType = typeof(SCNAnimatableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAnimation", Selector = "addAnimation:forKey:", ParameterType = new Type[]
{
	typeof(CAAnimation),
	typeof(NSString)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddAnimation", Selector = "addAnimationPlayer:forKey:", ParameterType = new Type[]
{
	typeof(SCNAnimationPlayer),
	typeof(NSString)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllAnimations", Selector = "removeAllAnimations")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnimation", Selector = "removeAnimationForKey:", ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnimationKeys", Selector = "animationKeys", ReturnType = typeof(NSString[]))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAnimationPlayer", Selector = "animationPlayerForKey:", ReturnType = typeof(SCNAnimationPlayer), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAnimation", Selector = "animationForKey:", ReturnType = typeof(CAAnimation), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PauseAnimation", Selector = "pauseAnimationForKey:", ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResumeAnimation", Selector = "resumeAnimationForKey:", ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsAnimationPaused", Selector = "isAnimationForKeyPaused:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAnimation", Selector = "removeAnimationForKey:fadeOutDuration:", ParameterType = new Type[]
{
	typeof(NSString),
	typeof(nfloat)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveAnimationUsingBlendOutDuration", Selector = "removeAnimationForKey:blendOutDuration:", ParameterType = new Type[]
{
	typeof(NSString),
	typeof(nfloat)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSpeed", Selector = "setSpeed:forAnimationKey:", ParameterType = new Type[]
{
	typeof(nfloat),
	typeof(NSString)
}, ParameterByRef = new bool[] { false, false })]
public interface ISCNAnimatable : INativeObject, IDisposable
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addAnimation:forKey:")]
	[Preserve(Conditional = true)]
	void AddAnimation(CAAnimation animation, NSString? key);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeAllAnimations")]
	[Preserve(Conditional = true)]
	void RemoveAllAnimations();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeAnimationForKey:")]
	[Preserve(Conditional = true)]
	void RemoveAnimation(NSString key);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("animationKeys")]
	[Preserve(Conditional = true)]
	NSString[] GetAnimationKeys();

	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("animationForKey:")]
	[Preserve(Conditional = true)]
	CAAnimation GetAnimation(NSString key);

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pauseAnimationForKey:")]
	[Preserve(Conditional = true)]
	void PauseAnimation(NSString key);

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resumeAnimationForKey:")]
	[Preserve(Conditional = true)]
	void ResumeAnimation(NSString key);

	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isAnimationForKeyPaused:")]
	[Preserve(Conditional = true)]
	bool IsAnimationPaused(NSString key);

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeAnimationForKey:fadeOutDuration:")]
	[Preserve(Conditional = true)]
	void RemoveAnimation(NSString key, nfloat duration);
}
