using System.ComponentModel;
using AppKit;
using CoreAnimation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

[Register("SCNParticleSystem", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNParticleSystem : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding, ISCNAnimatable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceleration = "acceleration";

	private static readonly IntPtr selAccelerationHandle = Selector.GetHandle("acceleration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimation_ForKey_ = "addAnimation:forKey:";

	private static readonly IntPtr selAddAnimation_ForKey_Handle = Selector.GetHandle("addAnimation:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimationPlayer_ForKey_ = "addAnimationPlayer:forKey:";

	private static readonly IntPtr selAddAnimationPlayer_ForKey_Handle = Selector.GetHandle("addAnimationPlayer:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddModifierForProperties_AtStage_WithBlock_ = "addModifierForProperties:atStage:withBlock:";

	private static readonly IntPtr selAddModifierForProperties_AtStage_WithBlock_Handle = Selector.GetHandle("addModifierForProperties:atStage:withBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAffectedByGravity = "affectedByGravity";

	private static readonly IntPtr selAffectedByGravityHandle = Selector.GetHandle("affectedByGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAffectedByPhysicsFields = "affectedByPhysicsFields";

	private static readonly IntPtr selAffectedByPhysicsFieldsHandle = Selector.GetHandle("affectedByPhysicsFields");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationKeys = "animationKeys";

	private static readonly IntPtr selAnimationKeysHandle = Selector.GetHandle("animationKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationPlayerForKey_ = "animationPlayerForKey:";

	private static readonly IntPtr selAnimationPlayerForKey_Handle = Selector.GetHandle("animationPlayerForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthDirection = "birthDirection";

	private static readonly IntPtr selBirthDirectionHandle = Selector.GetHandle("birthDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthLocation = "birthLocation";

	private static readonly IntPtr selBirthLocationHandle = Selector.GetHandle("birthLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthRate = "birthRate";

	private static readonly IntPtr selBirthRateHandle = Selector.GetHandle("birthRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBirthRateVariation = "birthRateVariation";

	private static readonly IntPtr selBirthRateVariationHandle = Selector.GetHandle("birthRateVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColliderNodes = "colliderNodes";

	private static readonly IntPtr selColliderNodesHandle = Selector.GetHandle("colliderNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDampingFactor = "dampingFactor";

	private static readonly IntPtr selDampingFactorHandle = Selector.GetHandle("dampingFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmissionDuration = "emissionDuration";

	private static readonly IntPtr selEmissionDurationHandle = Selector.GetHandle("emissionDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmissionDurationVariation = "emissionDurationVariation";

	private static readonly IntPtr selEmissionDurationVariationHandle = Selector.GetHandle("emissionDurationVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmitterShape = "emitterShape";

	private static readonly IntPtr selEmitterShapeHandle = Selector.GetHandle("emitterShape");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmittingDirection = "emittingDirection";

	private static readonly IntPtr selEmittingDirectionHandle = Selector.GetHandle("emittingDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFresnelExponent = "fresnelExponent";

	private static readonly IntPtr selFresnelExponentHandle = Selector.GetHandle("fresnelExponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleEvent_ForProperties_WithBlock_ = "handleEvent:forProperties:withBlock:";

	private static readonly IntPtr selHandleEvent_ForProperties_WithBlock_Handle = Selector.GetHandle("handleEvent:forProperties:withBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdleDuration = "idleDuration";

	private static readonly IntPtr selIdleDurationHandle = Selector.GetHandle("idleDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdleDurationVariation = "idleDurationVariation";

	private static readonly IntPtr selIdleDurationVariationHandle = Selector.GetHandle("idleDurationVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceAnimationMode = "imageSequenceAnimationMode";

	private static readonly IntPtr selImageSequenceAnimationModeHandle = Selector.GetHandle("imageSequenceAnimationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceColumnCount = "imageSequenceColumnCount";

	private static readonly IntPtr selImageSequenceColumnCountHandle = Selector.GetHandle("imageSequenceColumnCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceFrameRate = "imageSequenceFrameRate";

	private static readonly IntPtr selImageSequenceFrameRateHandle = Selector.GetHandle("imageSequenceFrameRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceFrameRateVariation = "imageSequenceFrameRateVariation";

	private static readonly IntPtr selImageSequenceFrameRateVariationHandle = Selector.GetHandle("imageSequenceFrameRateVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceInitialFrame = "imageSequenceInitialFrame";

	private static readonly IntPtr selImageSequenceInitialFrameHandle = Selector.GetHandle("imageSequenceInitialFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceInitialFrameVariation = "imageSequenceInitialFrameVariation";

	private static readonly IntPtr selImageSequenceInitialFrameVariationHandle = Selector.GetHandle("imageSequenceInitialFrameVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageSequenceRowCount = "imageSequenceRowCount";

	private static readonly IntPtr selImageSequenceRowCountHandle = Selector.GetHandle("imageSequenceRowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnimationForKeyPaused_ = "isAnimationForKeyPaused:";

	private static readonly IntPtr selIsAnimationForKeyPaused_Handle = Selector.GetHandle("isAnimationForKeyPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBlackPassEnabled = "isBlackPassEnabled";

	private static readonly IntPtr selIsBlackPassEnabledHandle = Selector.GetHandle("isBlackPassEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLightingEnabled = "isLightingEnabled";

	private static readonly IntPtr selIsLightingEnabledHandle = Selector.GetHandle("isLightingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLocal = "isLocal";

	private static readonly IntPtr selIsLocalHandle = Selector.GetHandle("isLocal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoops = "loops";

	private static readonly IntPtr selLoopsHandle = Selector.GetHandle("loops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientationDirection = "orientationDirection";

	private static readonly IntPtr selOrientationDirectionHandle = Selector.GetHandle("orientationDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientationMode = "orientationMode";

	private static readonly IntPtr selOrientationModeHandle = Selector.GetHandle("orientationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAngle = "particleAngle";

	private static readonly IntPtr selParticleAngleHandle = Selector.GetHandle("particleAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAngleVariation = "particleAngleVariation";

	private static readonly IntPtr selParticleAngleVariationHandle = Selector.GetHandle("particleAngleVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAngularVelocity = "particleAngularVelocity";

	private static readonly IntPtr selParticleAngularVelocityHandle = Selector.GetHandle("particleAngularVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAngularVelocityVariation = "particleAngularVelocityVariation";

	private static readonly IntPtr selParticleAngularVelocityVariationHandle = Selector.GetHandle("particleAngularVelocityVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleBounce = "particleBounce";

	private static readonly IntPtr selParticleBounceHandle = Selector.GetHandle("particleBounce");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleBounceVariation = "particleBounceVariation";

	private static readonly IntPtr selParticleBounceVariationHandle = Selector.GetHandle("particleBounceVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleCharge = "particleCharge";

	private static readonly IntPtr selParticleChargeHandle = Selector.GetHandle("particleCharge");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleChargeVariation = "particleChargeVariation";

	private static readonly IntPtr selParticleChargeVariationHandle = Selector.GetHandle("particleChargeVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColor = "particleColor";

	private static readonly IntPtr selParticleColorHandle = Selector.GetHandle("particleColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorVariation = "particleColorVariation";

	private static readonly IntPtr selParticleColorVariationHandle = Selector.GetHandle("particleColorVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleDiesOnCollision = "particleDiesOnCollision";

	private static readonly IntPtr selParticleDiesOnCollisionHandle = Selector.GetHandle("particleDiesOnCollision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleFriction = "particleFriction";

	private static readonly IntPtr selParticleFrictionHandle = Selector.GetHandle("particleFriction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleFrictionVariation = "particleFrictionVariation";

	private static readonly IntPtr selParticleFrictionVariationHandle = Selector.GetHandle("particleFrictionVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleImage = "particleImage";

	private static readonly IntPtr selParticleImageHandle = Selector.GetHandle("particleImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleIntensity = "particleIntensity";

	private static readonly IntPtr selParticleIntensityHandle = Selector.GetHandle("particleIntensity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleIntensityVariation = "particleIntensityVariation";

	private static readonly IntPtr selParticleIntensityVariationHandle = Selector.GetHandle("particleIntensityVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleLifeSpan = "particleLifeSpan";

	private static readonly IntPtr selParticleLifeSpanHandle = Selector.GetHandle("particleLifeSpan");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleLifeSpanVariation = "particleLifeSpanVariation";

	private static readonly IntPtr selParticleLifeSpanVariationHandle = Selector.GetHandle("particleLifeSpanVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleMass = "particleMass";

	private static readonly IntPtr selParticleMassHandle = Selector.GetHandle("particleMass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleMassVariation = "particleMassVariation";

	private static readonly IntPtr selParticleMassVariationHandle = Selector.GetHandle("particleMassVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSize = "particleSize";

	private static readonly IntPtr selParticleSizeHandle = Selector.GetHandle("particleSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSizeVariation = "particleSizeVariation";

	private static readonly IntPtr selParticleSizeVariationHandle = Selector.GetHandle("particleSizeVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSystem = "particleSystem";

	private static readonly IntPtr selParticleSystemHandle = Selector.GetHandle("particleSystem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSystemNamed_InDirectory_ = "particleSystemNamed:inDirectory:";

	private static readonly IntPtr selParticleSystemNamed_InDirectory_Handle = Selector.GetHandle("particleSystemNamed:inDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleVelocity = "particleVelocity";

	private static readonly IntPtr selParticleVelocityHandle = Selector.GetHandle("particleVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleVelocityVariation = "particleVelocityVariation";

	private static readonly IntPtr selParticleVelocityVariationHandle = Selector.GetHandle("particleVelocityVariation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseAnimationForKey_ = "pauseAnimationForKey:";

	private static readonly IntPtr selPauseAnimationForKey_Handle = Selector.GetHandle("pauseAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyControllers = "propertyControllers";

	private static readonly IntPtr selPropertyControllersHandle = Selector.GetHandle("propertyControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllAnimations = "removeAllAnimations";

	private static readonly IntPtr selRemoveAllAnimationsHandle = Selector.GetHandle("removeAllAnimations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllModifiers = "removeAllModifiers";

	private static readonly IntPtr selRemoveAllModifiersHandle = Selector.GetHandle("removeAllModifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_ = "removeAnimationForKey:";

	private static readonly IntPtr selRemoveAnimationForKey_Handle = Selector.GetHandle("removeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_BlendOutDuration_ = "removeAnimationForKey:blendOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_BlendOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:blendOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_FadeOutDuration_ = "removeAnimationForKey:fadeOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_FadeOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:fadeOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveModifiersOfStage_ = "removeModifiersOfStage:";

	private static readonly IntPtr selRemoveModifiersOfStage_Handle = Selector.GetHandle("removeModifiersOfStage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeAnimationForKey_ = "resumeAnimationForKey:";

	private static readonly IntPtr selResumeAnimationForKey_Handle = Selector.GetHandle("resumeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceleration_ = "setAcceleration:";

	private static readonly IntPtr selSetAcceleration_Handle = Selector.GetHandle("setAcceleration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffectedByGravity_ = "setAffectedByGravity:";

	private static readonly IntPtr selSetAffectedByGravity_Handle = Selector.GetHandle("setAffectedByGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAffectedByPhysicsFields_ = "setAffectedByPhysicsFields:";

	private static readonly IntPtr selSetAffectedByPhysicsFields_Handle = Selector.GetHandle("setAffectedByPhysicsFields:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthDirection_ = "setBirthDirection:";

	private static readonly IntPtr selSetBirthDirection_Handle = Selector.GetHandle("setBirthDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthLocation_ = "setBirthLocation:";

	private static readonly IntPtr selSetBirthLocation_Handle = Selector.GetHandle("setBirthLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthRate_ = "setBirthRate:";

	private static readonly IntPtr selSetBirthRate_Handle = Selector.GetHandle("setBirthRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBirthRateVariation_ = "setBirthRateVariation:";

	private static readonly IntPtr selSetBirthRateVariation_Handle = Selector.GetHandle("setBirthRateVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlackPassEnabled_ = "setBlackPassEnabled:";

	private static readonly IntPtr selSetBlackPassEnabled_Handle = Selector.GetHandle("setBlackPassEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColliderNodes_ = "setColliderNodes:";

	private static readonly IntPtr selSetColliderNodes_Handle = Selector.GetHandle("setColliderNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDampingFactor_ = "setDampingFactor:";

	private static readonly IntPtr selSetDampingFactor_Handle = Selector.GetHandle("setDampingFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmissionDuration_ = "setEmissionDuration:";

	private static readonly IntPtr selSetEmissionDuration_Handle = Selector.GetHandle("setEmissionDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmissionDurationVariation_ = "setEmissionDurationVariation:";

	private static readonly IntPtr selSetEmissionDurationVariation_Handle = Selector.GetHandle("setEmissionDurationVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmitterShape_ = "setEmitterShape:";

	private static readonly IntPtr selSetEmitterShape_Handle = Selector.GetHandle("setEmitterShape:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmittingDirection_ = "setEmittingDirection:";

	private static readonly IntPtr selSetEmittingDirection_Handle = Selector.GetHandle("setEmittingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFresnelExponent_ = "setFresnelExponent:";

	private static readonly IntPtr selSetFresnelExponent_Handle = Selector.GetHandle("setFresnelExponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdleDuration_ = "setIdleDuration:";

	private static readonly IntPtr selSetIdleDuration_Handle = Selector.GetHandle("setIdleDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdleDurationVariation_ = "setIdleDurationVariation:";

	private static readonly IntPtr selSetIdleDurationVariation_Handle = Selector.GetHandle("setIdleDurationVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceAnimationMode_ = "setImageSequenceAnimationMode:";

	private static readonly IntPtr selSetImageSequenceAnimationMode_Handle = Selector.GetHandle("setImageSequenceAnimationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceColumnCount_ = "setImageSequenceColumnCount:";

	private static readonly IntPtr selSetImageSequenceColumnCount_Handle = Selector.GetHandle("setImageSequenceColumnCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceFrameRate_ = "setImageSequenceFrameRate:";

	private static readonly IntPtr selSetImageSequenceFrameRate_Handle = Selector.GetHandle("setImageSequenceFrameRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceFrameRateVariation_ = "setImageSequenceFrameRateVariation:";

	private static readonly IntPtr selSetImageSequenceFrameRateVariation_Handle = Selector.GetHandle("setImageSequenceFrameRateVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceInitialFrame_ = "setImageSequenceInitialFrame:";

	private static readonly IntPtr selSetImageSequenceInitialFrame_Handle = Selector.GetHandle("setImageSequenceInitialFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceInitialFrameVariation_ = "setImageSequenceInitialFrameVariation:";

	private static readonly IntPtr selSetImageSequenceInitialFrameVariation_Handle = Selector.GetHandle("setImageSequenceInitialFrameVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageSequenceRowCount_ = "setImageSequenceRowCount:";

	private static readonly IntPtr selSetImageSequenceRowCount_Handle = Selector.GetHandle("setImageSequenceRowCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightingEnabled_ = "setLightingEnabled:";

	private static readonly IntPtr selSetLightingEnabled_Handle = Selector.GetHandle("setLightingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocal_ = "setLocal:";

	private static readonly IntPtr selSetLocal_Handle = Selector.GetHandle("setLocal:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoops_ = "setLoops:";

	private static readonly IntPtr selSetLoops_Handle = Selector.GetHandle("setLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientationDirection_ = "setOrientationDirection:";

	private static readonly IntPtr selSetOrientationDirection_Handle = Selector.GetHandle("setOrientationDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientationMode_ = "setOrientationMode:";

	private static readonly IntPtr selSetOrientationMode_Handle = Selector.GetHandle("setOrientationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAngle_ = "setParticleAngle:";

	private static readonly IntPtr selSetParticleAngle_Handle = Selector.GetHandle("setParticleAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAngleVariation_ = "setParticleAngleVariation:";

	private static readonly IntPtr selSetParticleAngleVariation_Handle = Selector.GetHandle("setParticleAngleVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAngularVelocity_ = "setParticleAngularVelocity:";

	private static readonly IntPtr selSetParticleAngularVelocity_Handle = Selector.GetHandle("setParticleAngularVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAngularVelocityVariation_ = "setParticleAngularVelocityVariation:";

	private static readonly IntPtr selSetParticleAngularVelocityVariation_Handle = Selector.GetHandle("setParticleAngularVelocityVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleBounce_ = "setParticleBounce:";

	private static readonly IntPtr selSetParticleBounce_Handle = Selector.GetHandle("setParticleBounce:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleBounceVariation_ = "setParticleBounceVariation:";

	private static readonly IntPtr selSetParticleBounceVariation_Handle = Selector.GetHandle("setParticleBounceVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleCharge_ = "setParticleCharge:";

	private static readonly IntPtr selSetParticleCharge_Handle = Selector.GetHandle("setParticleCharge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleChargeVariation_ = "setParticleChargeVariation:";

	private static readonly IntPtr selSetParticleChargeVariation_Handle = Selector.GetHandle("setParticleChargeVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColor_ = "setParticleColor:";

	private static readonly IntPtr selSetParticleColor_Handle = Selector.GetHandle("setParticleColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorVariation_ = "setParticleColorVariation:";

	private static readonly IntPtr selSetParticleColorVariation_Handle = Selector.GetHandle("setParticleColorVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleDiesOnCollision_ = "setParticleDiesOnCollision:";

	private static readonly IntPtr selSetParticleDiesOnCollision_Handle = Selector.GetHandle("setParticleDiesOnCollision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleFriction_ = "setParticleFriction:";

	private static readonly IntPtr selSetParticleFriction_Handle = Selector.GetHandle("setParticleFriction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleFrictionVariation_ = "setParticleFrictionVariation:";

	private static readonly IntPtr selSetParticleFrictionVariation_Handle = Selector.GetHandle("setParticleFrictionVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleImage_ = "setParticleImage:";

	private static readonly IntPtr selSetParticleImage_Handle = Selector.GetHandle("setParticleImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleIntensity_ = "setParticleIntensity:";

	private static readonly IntPtr selSetParticleIntensity_Handle = Selector.GetHandle("setParticleIntensity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleIntensityVariation_ = "setParticleIntensityVariation:";

	private static readonly IntPtr selSetParticleIntensityVariation_Handle = Selector.GetHandle("setParticleIntensityVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleLifeSpan_ = "setParticleLifeSpan:";

	private static readonly IntPtr selSetParticleLifeSpan_Handle = Selector.GetHandle("setParticleLifeSpan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleLifeSpanVariation_ = "setParticleLifeSpanVariation:";

	private static readonly IntPtr selSetParticleLifeSpanVariation_Handle = Selector.GetHandle("setParticleLifeSpanVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleMass_ = "setParticleMass:";

	private static readonly IntPtr selSetParticleMass_Handle = Selector.GetHandle("setParticleMass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleMassVariation_ = "setParticleMassVariation:";

	private static readonly IntPtr selSetParticleMassVariation_Handle = Selector.GetHandle("setParticleMassVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleSize_ = "setParticleSize:";

	private static readonly IntPtr selSetParticleSize_Handle = Selector.GetHandle("setParticleSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleSizeVariation_ = "setParticleSizeVariation:";

	private static readonly IntPtr selSetParticleSizeVariation_Handle = Selector.GetHandle("setParticleSizeVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleVelocity_ = "setParticleVelocity:";

	private static readonly IntPtr selSetParticleVelocity_Handle = Selector.GetHandle("setParticleVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleVelocityVariation_ = "setParticleVelocityVariation:";

	private static readonly IntPtr selSetParticleVelocityVariation_Handle = Selector.GetHandle("setParticleVelocityVariation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertyControllers_ = "setPropertyControllers:";

	private static readonly IntPtr selSetPropertyControllers_Handle = Selector.GetHandle("setPropertyControllers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortingMode_ = "setSortingMode:";

	private static readonly IntPtr selSetSortingMode_Handle = Selector.GetHandle("setSortingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ForAnimationKey_ = "setSpeed:forAnimationKey:";

	private static readonly IntPtr selSetSpeed_ForAnimationKey_Handle = Selector.GetHandle("setSpeed:forAnimationKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeedFactor_ = "setSpeedFactor:";

	private static readonly IntPtr selSetSpeedFactor_Handle = Selector.GetHandle("setSpeedFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpreadingAngle_ = "setSpreadingAngle:";

	private static readonly IntPtr selSetSpreadingAngle_Handle = Selector.GetHandle("setSpreadingAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStretchFactor_ = "setStretchFactor:";

	private static readonly IntPtr selSetStretchFactor_Handle = Selector.GetHandle("setStretchFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSystemSpawnedOnCollision_ = "setSystemSpawnedOnCollision:";

	private static readonly IntPtr selSetSystemSpawnedOnCollision_Handle = Selector.GetHandle("setSystemSpawnedOnCollision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSystemSpawnedOnDying_ = "setSystemSpawnedOnDying:";

	private static readonly IntPtr selSetSystemSpawnedOnDying_Handle = Selector.GetHandle("setSystemSpawnedOnDying:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSystemSpawnedOnLiving_ = "setSystemSpawnedOnLiving:";

	private static readonly IntPtr selSetSystemSpawnedOnLiving_Handle = Selector.GetHandle("setSystemSpawnedOnLiving:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWarmupDuration_ = "setWarmupDuration:";

	private static readonly IntPtr selSetWarmupDuration_Handle = Selector.GetHandle("setWarmupDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortingMode = "sortingMode";

	private static readonly IntPtr selSortingModeHandle = Selector.GetHandle("sortingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeedFactor = "speedFactor";

	private static readonly IntPtr selSpeedFactorHandle = Selector.GetHandle("speedFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpreadingAngle = "spreadingAngle";

	private static readonly IntPtr selSpreadingAngleHandle = Selector.GetHandle("spreadingAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStretchFactor = "stretchFactor";

	private static readonly IntPtr selStretchFactorHandle = Selector.GetHandle("stretchFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemSpawnedOnCollision = "systemSpawnedOnCollision";

	private static readonly IntPtr selSystemSpawnedOnCollisionHandle = Selector.GetHandle("systemSpawnedOnCollision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemSpawnedOnDying = "systemSpawnedOnDying";

	private static readonly IntPtr selSystemSpawnedOnDyingHandle = Selector.GetHandle("systemSpawnedOnDying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemSpawnedOnLiving = "systemSpawnedOnLiving";

	private static readonly IntPtr selSystemSpawnedOnLivingHandle = Selector.GetHandle("systemSpawnedOnLiving");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWarmupDuration = "warmupDuration";

	private static readonly IntPtr selWarmupDurationHandle = Selector.GetHandle("warmupDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNParticleSystem");

	public SCNPropertyControllers PropertyControllers
	{
		get
		{
			return new SCNPropertyControllers(WeakPropertyControllers);
		}
		set
		{
			WeakPropertyControllers = value?.dict;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 Acceleration
	{
		[Export("acceleration")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selAccelerationHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccelerationHandle);
			}
			return retval;
		}
		[Export("setAcceleration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetAcceleration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AffectedByGravity
	{
		[Export("affectedByGravity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAffectedByGravityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAffectedByGravityHandle);
		}
		[Export("setAffectedByGravity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAffectedByGravity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAffectedByGravity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AffectedByPhysicsFields
	{
		[Export("affectedByPhysicsFields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAffectedByPhysicsFieldsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAffectedByPhysicsFieldsHandle);
		}
		[Export("setAffectedByPhysicsFields:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAffectedByPhysicsFields_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAffectedByPhysicsFields_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleBirthDirection BirthDirection
	{
		[Export("birthDirection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleBirthDirection)Messaging.Int64_objc_msgSend(base.Handle, selBirthDirectionHandle);
			}
			return (SCNParticleBirthDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBirthDirectionHandle);
		}
		[Export("setBirthDirection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBirthDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBirthDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleBirthLocation BirthLocation
	{
		[Export("birthLocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleBirthLocation)Messaging.Int64_objc_msgSend(base.Handle, selBirthLocationHandle);
			}
			return (SCNParticleBirthLocation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBirthLocationHandle);
		}
		[Export("setBirthLocation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBirthLocation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBirthLocation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BirthRate
	{
		[Export("birthRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBirthRateHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBirthRateHandle);
		}
		[Export("setBirthRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBirthRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBirthRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BirthRateVariation
	{
		[Export("birthRateVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBirthRateVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBirthRateVariationHandle);
		}
		[Export("setBirthRateVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetBirthRateVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetBirthRateVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BlackPassEnabled
	{
		[Export("isBlackPassEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBlackPassEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBlackPassEnabledHandle);
		}
		[Export("setBlackPassEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBlackPassEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBlackPassEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleBlendMode BlendMode
	{
		[Export("blendMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendModeHandle);
			}
			return (SCNParticleBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendModeHandle);
		}
		[Export("setBlendMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode[] ColliderNodes
	{
		[Export("colliderNodes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selColliderNodesHandle));
			}
			return NSArray.ArrayFromHandle<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColliderNodesHandle));
		}
		[Export("setColliderNodes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColliderNodes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColliderNodes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DampingFactor
	{
		[Export("dampingFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDampingFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDampingFactorHandle);
		}
		[Export("setDampingFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDampingFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDampingFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat EmissionDuration
	{
		[Export("emissionDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmissionDurationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmissionDurationHandle);
		}
		[Export("setEmissionDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmissionDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmissionDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat EmissionDurationVariation
	{
		[Export("emissionDurationVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmissionDurationVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmissionDurationVariationHandle);
		}
		[Export("setEmissionDurationVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmissionDurationVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmissionDurationVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNGeometry EmitterShape
	{
		[Export("emitterShape", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmitterShapeHandle));
			}
			return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmitterShapeHandle));
		}
		[Export("setEmitterShape:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmitterShape_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmitterShape_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 EmittingDirection
	{
		[Export("emittingDirection")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selEmittingDirectionHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selEmittingDirectionHandle);
			}
			return retval;
		}
		[Export("setEmittingDirection:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetEmittingDirection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetEmittingDirection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FresnelExponent
	{
		[Export("fresnelExponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFresnelExponentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFresnelExponentHandle);
		}
		[Export("setFresnelExponent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFresnelExponent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFresnelExponent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat IdleDuration
	{
		[Export("idleDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selIdleDurationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selIdleDurationHandle);
		}
		[Export("setIdleDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetIdleDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetIdleDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat IdleDurationVariation
	{
		[Export("idleDurationVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selIdleDurationVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selIdleDurationVariationHandle);
		}
		[Export("setIdleDurationVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetIdleDurationVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetIdleDurationVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleImageSequenceAnimationMode ImageSequenceAnimationMode
	{
		[Export("imageSequenceAnimationMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleImageSequenceAnimationMode)Messaging.Int64_objc_msgSend(base.Handle, selImageSequenceAnimationModeHandle);
			}
			return (SCNParticleImageSequenceAnimationMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selImageSequenceAnimationModeHandle);
		}
		[Export("setImageSequenceAnimationMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetImageSequenceAnimationMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetImageSequenceAnimationMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ImageSequenceColumnCount
	{
		[Export("imageSequenceColumnCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selImageSequenceColumnCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selImageSequenceColumnCountHandle);
		}
		[Export("setImageSequenceColumnCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetImageSequenceColumnCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetImageSequenceColumnCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageSequenceFrameRate
	{
		[Export("imageSequenceFrameRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageSequenceFrameRateHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageSequenceFrameRateHandle);
		}
		[Export("setImageSequenceFrameRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetImageSequenceFrameRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetImageSequenceFrameRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageSequenceFrameRateVariation
	{
		[Export("imageSequenceFrameRateVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageSequenceFrameRateVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageSequenceFrameRateVariationHandle);
		}
		[Export("setImageSequenceFrameRateVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetImageSequenceFrameRateVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetImageSequenceFrameRateVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageSequenceInitialFrame
	{
		[Export("imageSequenceInitialFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageSequenceInitialFrameHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageSequenceInitialFrameHandle);
		}
		[Export("setImageSequenceInitialFrame:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetImageSequenceInitialFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetImageSequenceInitialFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ImageSequenceInitialFrameVariation
	{
		[Export("imageSequenceInitialFrameVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selImageSequenceInitialFrameVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selImageSequenceInitialFrameVariationHandle);
		}
		[Export("setImageSequenceInitialFrameVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetImageSequenceInitialFrameVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetImageSequenceInitialFrameVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ImageSequenceRowCount
	{
		[Export("imageSequenceRowCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selImageSequenceRowCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selImageSequenceRowCountHandle);
		}
		[Export("setImageSequenceRowCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetImageSequenceRowCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetImageSequenceRowCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LightingEnabled
	{
		[Export("isLightingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLightingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLightingEnabledHandle);
		}
		[Export("setLightingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLightingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLightingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Local
	{
		[Export("isLocal")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLocalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLocalHandle);
		}
		[Export("setLocal:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLocal_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLocal_Handle, value);
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
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual SCNVector3 OrientationDirection
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("orientationDirection", ArgumentSemantic.Assign)]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selOrientationDirectionHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOrientationDirectionHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setOrientationDirection:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetOrientationDirection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetOrientationDirection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleOrientationMode OrientationMode
	{
		[Export("orientationMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleOrientationMode)Messaging.Int64_objc_msgSend(base.Handle, selOrientationModeHandle);
			}
			return (SCNParticleOrientationMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selOrientationModeHandle);
		}
		[Export("setOrientationMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetOrientationMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetOrientationMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAngle
	{
		[Export("particleAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAngleHandle);
		}
		[Export("setParticleAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAngleVariation
	{
		[Export("particleAngleVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAngleVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAngleVariationHandle);
		}
		[Export("setParticleAngleVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAngleVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAngleVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAngularVelocity
	{
		[Export("particleAngularVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAngularVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAngularVelocityHandle);
		}
		[Export("setParticleAngularVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAngularVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAngularVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAngularVelocityVariation
	{
		[Export("particleAngularVelocityVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAngularVelocityVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAngularVelocityVariationHandle);
		}
		[Export("setParticleAngularVelocityVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAngularVelocityVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAngularVelocityVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleBounce
	{
		[Export("particleBounce")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleBounceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleBounceHandle);
		}
		[Export("setParticleBounce:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleBounce_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleBounce_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleBounceVariation
	{
		[Export("particleBounceVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleBounceVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleBounceVariationHandle);
		}
		[Export("setParticleBounceVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleBounceVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleBounceVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleCharge
	{
		[Export("particleCharge")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleChargeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleChargeHandle);
		}
		[Export("setParticleCharge:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleCharge_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleCharge_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleChargeVariation
	{
		[Export("particleChargeVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleChargeVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleChargeVariationHandle);
		}
		[Export("setParticleChargeVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleChargeVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleChargeVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor ParticleColor
	{
		[Export("particleColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleColorHandle));
		}
		[Export("setParticleColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector4 ParticleColorVariation
	{
		[Export("particleColorVariation")]
		get
		{
			SCNVector4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector4_objc_msgSend_stret(out retval, base.Handle, selParticleColorVariationHandle);
			}
			else
			{
				Messaging.SCNVector4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selParticleColorVariationHandle);
			}
			return retval;
		}
		[Export("setParticleColorVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector4(base.Handle, selSetParticleColorVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector4(base.SuperHandle, selSetParticleColorVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ParticleDiesOnCollision
	{
		[Export("particleDiesOnCollision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selParticleDiesOnCollisionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selParticleDiesOnCollisionHandle);
		}
		[Export("setParticleDiesOnCollision:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetParticleDiesOnCollision_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetParticleDiesOnCollision_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleFriction
	{
		[Export("particleFriction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleFrictionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleFrictionHandle);
		}
		[Export("setParticleFriction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleFriction_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleFriction_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleFrictionVariation
	{
		[Export("particleFrictionVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleFrictionVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleFrictionVariationHandle);
		}
		[Export("setParticleFrictionVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleFrictionVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleFrictionVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ParticleImage
	{
		[Export("particleImage", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleImageHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleImageHandle));
		}
		[Export("setParticleImage:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nfloat ParticleIntensity
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("particleIntensity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleIntensityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleIntensityHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setParticleIntensity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleIntensity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleIntensity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nfloat ParticleIntensityVariation
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("particleIntensityVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleIntensityVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleIntensityVariationHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setParticleIntensityVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleIntensityVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleIntensityVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleLifeSpan
	{
		[Export("particleLifeSpan")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleLifeSpanHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleLifeSpanHandle);
		}
		[Export("setParticleLifeSpan:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleLifeSpan_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleLifeSpan_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleLifeSpanVariation
	{
		[Export("particleLifeSpanVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleLifeSpanVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleLifeSpanVariationHandle);
		}
		[Export("setParticleLifeSpanVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleLifeSpanVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleLifeSpanVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleMass
	{
		[Export("particleMass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleMassHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleMassHandle);
		}
		[Export("setParticleMass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleMass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleMass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleMassVariation
	{
		[Export("particleMassVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleMassVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleMassVariationHandle);
		}
		[Export("setParticleMassVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleMassVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleMassVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleSize
	{
		[Export("particleSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleSizeHandle);
		}
		[Export("setParticleSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleSizeVariation
	{
		[Export("particleSizeVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleSizeVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleSizeVariationHandle);
		}
		[Export("setParticleSizeVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleSizeVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleSizeVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleVelocity
	{
		[Export("particleVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleVelocityHandle);
		}
		[Export("setParticleVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleVelocityVariation
	{
		[Export("particleVelocityVariation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleVelocityVariationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleVelocityVariationHandle);
		}
		[Export("setParticleVelocityVariation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleVelocityVariation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleVelocityVariation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleSortingMode SortingMode
	{
		[Export("sortingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNParticleSortingMode)Messaging.Int64_objc_msgSend(base.Handle, selSortingModeHandle);
			}
			return (SCNParticleSortingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSortingModeHandle);
		}
		[Export("setSortingMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSortingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSortingMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SpeedFactor
	{
		[Export("speedFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpeedFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpeedFactorHandle);
		}
		[Export("setSpeedFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpeedFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpeedFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SpreadingAngle
	{
		[Export("spreadingAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpreadingAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpreadingAngleHandle);
		}
		[Export("setSpreadingAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpreadingAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpreadingAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StretchFactor
	{
		[Export("stretchFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStretchFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStretchFactorHandle);
		}
		[Export("setStretchFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetStretchFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetStretchFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleSystem SystemSpawnedOnCollision
	{
		[Export("systemSpawnedOnCollision", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSystemSpawnedOnCollisionHandle));
			}
			return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSystemSpawnedOnCollisionHandle));
		}
		[Export("setSystemSpawnedOnCollision:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSystemSpawnedOnCollision_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSystemSpawnedOnCollision_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleSystem SystemSpawnedOnDying
	{
		[Export("systemSpawnedOnDying", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSystemSpawnedOnDyingHandle));
			}
			return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSystemSpawnedOnDyingHandle));
		}
		[Export("setSystemSpawnedOnDying:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSystemSpawnedOnDying_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSystemSpawnedOnDying_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNParticleSystem SystemSpawnedOnLiving
	{
		[Export("systemSpawnedOnLiving", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSystemSpawnedOnLivingHandle));
			}
			return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSystemSpawnedOnLivingHandle));
		}
		[Export("setSystemSpawnedOnLiving:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSystemSpawnedOnLiving_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSystemSpawnedOnLiving_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat WarmupDuration
	{
		[Export("warmupDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selWarmupDurationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selWarmupDurationHandle);
		}
		[Export("setWarmupDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetWarmupDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetWarmupDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakPropertyControllers
	{
		[Export("propertyControllers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyControllersHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyControllersHandle));
		}
		[Export("setPropertyControllers:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPropertyControllers_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPropertyControllers_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNParticleSystem(NSCoder coder)
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
	protected SCNParticleSystem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNParticleSystem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addAnimation:forKey:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(CAAnimation animation, NSString? key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
	}

	[Export("addAnimationPlayer:forKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(SCNAnimationPlayer player, NSString? key)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
	}

	[Export("addModifierForProperties:atStage:withBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddModifier(NSString[] properties, SCNParticleModifierStage stage, [BlockProxy(typeof(Trampolines.NIDSCNParticleModifierHandler))] SCNParticleModifierHandler handler)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(properties);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNParticleModifierHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selAddModifierForProperties_AtStage_WithBlock_Handle, nSArray.Handle, (long)stage, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selAddModifierForProperties_AtStage_WithBlock_Handle, nSArray.Handle, (long)stage, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
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

	[Export("particleSystem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNParticleSystem Create()
	{
		return Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend(class_ptr, selParticleSystemHandle));
	}

	[Export("particleSystemNamed:inDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNParticleSystem Create(string name, string? directory)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(directory);
		SCNParticleSystem nSObject = Runtime.GetNSObject<SCNParticleSystem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selParticleSystemNamed_InDirectory_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
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

	[Export("animationForKey:")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAAnimation GetAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("animationKeys")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] GetAnimationKeys()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationKeysHandle));
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationKeysHandle));
	}

	[Export("animationPlayerForKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAnimationPlayer? GetAnimationPlayer(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationPlayerForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationPlayerForKey_Handle, key.Handle));
	}

	[Export("handleEvent:forProperties:withBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HandleEvent(SCNParticleEvent evnt, NSString[] particleProperties, [BlockProxy(typeof(Trampolines.NIDSCNParticleEventHandler))] SCNParticleEventHandler handler)
	{
		if (particleProperties == null)
		{
			throw new ArgumentNullException("particleProperties");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(particleProperties);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNParticleEventHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr(base.Handle, selHandleEvent_ForProperties_WithBlock_Handle, (long)evnt, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr(base.SuperHandle, selHandleEvent_ForProperties_WithBlock_Handle, (long)evnt, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Export("isAnimationForKeyPaused:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnimationPaused(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAnimationForKeyPaused_Handle, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAnimationForKeyPaused_Handle, key.Handle);
	}

	[Export("pauseAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPauseAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPauseAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAllAnimations")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllAnimations()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAnimationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAnimationsHandle);
		}
	}

	[Export("removeAllModifiers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllModifiers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllModifiersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllModifiersHandle);
		}
	}

	[Export("removeAnimationForKey:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAnimationForKey:fadeOutDuration:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key, nfloat duration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
	}

	[Export("removeAnimationForKey:blendOutDuration:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimationUsingBlendOutDuration(NSString key, nfloat blendOutDuration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
	}

	[Export("removeModifiersOfStage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveModifiers(SCNParticleModifierStage stage)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveModifiersOfStage_Handle, (long)stage);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveModifiersOfStage_Handle, (long)stage);
		}
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("resumeAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("setSpeed:forAnimationKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSpeed(nfloat speed, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
	}
}
