using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKEmitterNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKEmitterNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvanceSimulationTime_ = "advanceSimulationTime:";

	private static readonly IntPtr selAdvanceSimulationTime_Handle = Selector.GetHandle("advanceSimulationTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmissionAngle = "emissionAngle";

	private static readonly IntPtr selEmissionAngleHandle = Selector.GetHandle("emissionAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmissionAngleRange = "emissionAngleRange";

	private static readonly IntPtr selEmissionAngleRangeHandle = Selector.GetHandle("emissionAngleRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldBitMask = "fieldBitMask";

	private static readonly IntPtr selFieldBitMaskHandle = Selector.GetHandle("fieldBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumParticlesToEmit = "numParticlesToEmit";

	private static readonly IntPtr selNumParticlesToEmitHandle = Selector.GetHandle("numParticlesToEmit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAction = "particleAction";

	private static readonly IntPtr selParticleActionHandle = Selector.GetHandle("particleAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAlpha = "particleAlpha";

	private static readonly IntPtr selParticleAlphaHandle = Selector.GetHandle("particleAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAlphaRange = "particleAlphaRange";

	private static readonly IntPtr selParticleAlphaRangeHandle = Selector.GetHandle("particleAlphaRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAlphaSequence = "particleAlphaSequence";

	private static readonly IntPtr selParticleAlphaSequenceHandle = Selector.GetHandle("particleAlphaSequence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleAlphaSpeed = "particleAlphaSpeed";

	private static readonly IntPtr selParticleAlphaSpeedHandle = Selector.GetHandle("particleAlphaSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleBirthRate = "particleBirthRate";

	private static readonly IntPtr selParticleBirthRateHandle = Selector.GetHandle("particleBirthRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleBlendMode = "particleBlendMode";

	private static readonly IntPtr selParticleBlendModeHandle = Selector.GetHandle("particleBlendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColor = "particleColor";

	private static readonly IntPtr selParticleColorHandle = Selector.GetHandle("particleColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorAlphaRange = "particleColorAlphaRange";

	private static readonly IntPtr selParticleColorAlphaRangeHandle = Selector.GetHandle("particleColorAlphaRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorAlphaSpeed = "particleColorAlphaSpeed";

	private static readonly IntPtr selParticleColorAlphaSpeedHandle = Selector.GetHandle("particleColorAlphaSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlendFactor = "particleColorBlendFactor";

	private static readonly IntPtr selParticleColorBlendFactorHandle = Selector.GetHandle("particleColorBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlendFactorRange = "particleColorBlendFactorRange";

	private static readonly IntPtr selParticleColorBlendFactorRangeHandle = Selector.GetHandle("particleColorBlendFactorRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlendFactorSequence = "particleColorBlendFactorSequence";

	private static readonly IntPtr selParticleColorBlendFactorSequenceHandle = Selector.GetHandle("particleColorBlendFactorSequence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlendFactorSpeed = "particleColorBlendFactorSpeed";

	private static readonly IntPtr selParticleColorBlendFactorSpeedHandle = Selector.GetHandle("particleColorBlendFactorSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlueRange = "particleColorBlueRange";

	private static readonly IntPtr selParticleColorBlueRangeHandle = Selector.GetHandle("particleColorBlueRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorBlueSpeed = "particleColorBlueSpeed";

	private static readonly IntPtr selParticleColorBlueSpeedHandle = Selector.GetHandle("particleColorBlueSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorGreenRange = "particleColorGreenRange";

	private static readonly IntPtr selParticleColorGreenRangeHandle = Selector.GetHandle("particleColorGreenRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorGreenSpeed = "particleColorGreenSpeed";

	private static readonly IntPtr selParticleColorGreenSpeedHandle = Selector.GetHandle("particleColorGreenSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorRedRange = "particleColorRedRange";

	private static readonly IntPtr selParticleColorRedRangeHandle = Selector.GetHandle("particleColorRedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorRedSpeed = "particleColorRedSpeed";

	private static readonly IntPtr selParticleColorRedSpeedHandle = Selector.GetHandle("particleColorRedSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleColorSequence = "particleColorSequence";

	private static readonly IntPtr selParticleColorSequenceHandle = Selector.GetHandle("particleColorSequence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleLifetime = "particleLifetime";

	private static readonly IntPtr selParticleLifetimeHandle = Selector.GetHandle("particleLifetime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleLifetimeRange = "particleLifetimeRange";

	private static readonly IntPtr selParticleLifetimeRangeHandle = Selector.GetHandle("particleLifetimeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticlePosition = "particlePosition";

	private static readonly IntPtr selParticlePositionHandle = Selector.GetHandle("particlePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticlePositionRange = "particlePositionRange";

	private static readonly IntPtr selParticlePositionRangeHandle = Selector.GetHandle("particlePositionRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleRenderOrder = "particleRenderOrder";

	private static readonly IntPtr selParticleRenderOrderHandle = Selector.GetHandle("particleRenderOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleRotation = "particleRotation";

	private static readonly IntPtr selParticleRotationHandle = Selector.GetHandle("particleRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleRotationRange = "particleRotationRange";

	private static readonly IntPtr selParticleRotationRangeHandle = Selector.GetHandle("particleRotationRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleRotationSpeed = "particleRotationSpeed";

	private static readonly IntPtr selParticleRotationSpeedHandle = Selector.GetHandle("particleRotationSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleScale = "particleScale";

	private static readonly IntPtr selParticleScaleHandle = Selector.GetHandle("particleScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleScaleRange = "particleScaleRange";

	private static readonly IntPtr selParticleScaleRangeHandle = Selector.GetHandle("particleScaleRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleScaleSequence = "particleScaleSequence";

	private static readonly IntPtr selParticleScaleSequenceHandle = Selector.GetHandle("particleScaleSequence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleScaleSpeed = "particleScaleSpeed";

	private static readonly IntPtr selParticleScaleSpeedHandle = Selector.GetHandle("particleScaleSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSize = "particleSize";

	private static readonly IntPtr selParticleSizeHandle = Selector.GetHandle("particleSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSpeed = "particleSpeed";

	private static readonly IntPtr selParticleSpeedHandle = Selector.GetHandle("particleSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleSpeedRange = "particleSpeedRange";

	private static readonly IntPtr selParticleSpeedRangeHandle = Selector.GetHandle("particleSpeedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleTexture = "particleTexture";

	private static readonly IntPtr selParticleTextureHandle = Selector.GetHandle("particleTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleZPosition = "particleZPosition";

	private static readonly IntPtr selParticleZPositionHandle = Selector.GetHandle("particleZPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleZPositionRange = "particleZPositionRange";

	private static readonly IntPtr selParticleZPositionRangeHandle = Selector.GetHandle("particleZPositionRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticleZPositionSpeed = "particleZPositionSpeed";

	private static readonly IntPtr selParticleZPositionSpeedHandle = Selector.GetHandle("particleZPositionSpeed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetSimulation = "resetSimulation";

	private static readonly IntPtr selResetSimulationHandle = Selector.GetHandle("resetSimulation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmissionAngle_ = "setEmissionAngle:";

	private static readonly IntPtr selSetEmissionAngle_Handle = Selector.GetHandle("setEmissionAngle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmissionAngleRange_ = "setEmissionAngleRange:";

	private static readonly IntPtr selSetEmissionAngleRange_Handle = Selector.GetHandle("setEmissionAngleRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldBitMask_ = "setFieldBitMask:";

	private static readonly IntPtr selSetFieldBitMask_Handle = Selector.GetHandle("setFieldBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumParticlesToEmit_ = "setNumParticlesToEmit:";

	private static readonly IntPtr selSetNumParticlesToEmit_Handle = Selector.GetHandle("setNumParticlesToEmit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAction_ = "setParticleAction:";

	private static readonly IntPtr selSetParticleAction_Handle = Selector.GetHandle("setParticleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAlpha_ = "setParticleAlpha:";

	private static readonly IntPtr selSetParticleAlpha_Handle = Selector.GetHandle("setParticleAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAlphaRange_ = "setParticleAlphaRange:";

	private static readonly IntPtr selSetParticleAlphaRange_Handle = Selector.GetHandle("setParticleAlphaRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAlphaSequence_ = "setParticleAlphaSequence:";

	private static readonly IntPtr selSetParticleAlphaSequence_Handle = Selector.GetHandle("setParticleAlphaSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleAlphaSpeed_ = "setParticleAlphaSpeed:";

	private static readonly IntPtr selSetParticleAlphaSpeed_Handle = Selector.GetHandle("setParticleAlphaSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleBirthRate_ = "setParticleBirthRate:";

	private static readonly IntPtr selSetParticleBirthRate_Handle = Selector.GetHandle("setParticleBirthRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleBlendMode_ = "setParticleBlendMode:";

	private static readonly IntPtr selSetParticleBlendMode_Handle = Selector.GetHandle("setParticleBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColor_ = "setParticleColor:";

	private static readonly IntPtr selSetParticleColor_Handle = Selector.GetHandle("setParticleColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorAlphaRange_ = "setParticleColorAlphaRange:";

	private static readonly IntPtr selSetParticleColorAlphaRange_Handle = Selector.GetHandle("setParticleColorAlphaRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorAlphaSpeed_ = "setParticleColorAlphaSpeed:";

	private static readonly IntPtr selSetParticleColorAlphaSpeed_Handle = Selector.GetHandle("setParticleColorAlphaSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlendFactor_ = "setParticleColorBlendFactor:";

	private static readonly IntPtr selSetParticleColorBlendFactor_Handle = Selector.GetHandle("setParticleColorBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlendFactorRange_ = "setParticleColorBlendFactorRange:";

	private static readonly IntPtr selSetParticleColorBlendFactorRange_Handle = Selector.GetHandle("setParticleColorBlendFactorRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlendFactorSequence_ = "setParticleColorBlendFactorSequence:";

	private static readonly IntPtr selSetParticleColorBlendFactorSequence_Handle = Selector.GetHandle("setParticleColorBlendFactorSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlendFactorSpeed_ = "setParticleColorBlendFactorSpeed:";

	private static readonly IntPtr selSetParticleColorBlendFactorSpeed_Handle = Selector.GetHandle("setParticleColorBlendFactorSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlueRange_ = "setParticleColorBlueRange:";

	private static readonly IntPtr selSetParticleColorBlueRange_Handle = Selector.GetHandle("setParticleColorBlueRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorBlueSpeed_ = "setParticleColorBlueSpeed:";

	private static readonly IntPtr selSetParticleColorBlueSpeed_Handle = Selector.GetHandle("setParticleColorBlueSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorGreenRange_ = "setParticleColorGreenRange:";

	private static readonly IntPtr selSetParticleColorGreenRange_Handle = Selector.GetHandle("setParticleColorGreenRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorGreenSpeed_ = "setParticleColorGreenSpeed:";

	private static readonly IntPtr selSetParticleColorGreenSpeed_Handle = Selector.GetHandle("setParticleColorGreenSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorRedRange_ = "setParticleColorRedRange:";

	private static readonly IntPtr selSetParticleColorRedRange_Handle = Selector.GetHandle("setParticleColorRedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorRedSpeed_ = "setParticleColorRedSpeed:";

	private static readonly IntPtr selSetParticleColorRedSpeed_Handle = Selector.GetHandle("setParticleColorRedSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleColorSequence_ = "setParticleColorSequence:";

	private static readonly IntPtr selSetParticleColorSequence_Handle = Selector.GetHandle("setParticleColorSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleLifetime_ = "setParticleLifetime:";

	private static readonly IntPtr selSetParticleLifetime_Handle = Selector.GetHandle("setParticleLifetime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleLifetimeRange_ = "setParticleLifetimeRange:";

	private static readonly IntPtr selSetParticleLifetimeRange_Handle = Selector.GetHandle("setParticleLifetimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticlePosition_ = "setParticlePosition:";

	private static readonly IntPtr selSetParticlePosition_Handle = Selector.GetHandle("setParticlePosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticlePositionRange_ = "setParticlePositionRange:";

	private static readonly IntPtr selSetParticlePositionRange_Handle = Selector.GetHandle("setParticlePositionRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleRenderOrder_ = "setParticleRenderOrder:";

	private static readonly IntPtr selSetParticleRenderOrder_Handle = Selector.GetHandle("setParticleRenderOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleRotation_ = "setParticleRotation:";

	private static readonly IntPtr selSetParticleRotation_Handle = Selector.GetHandle("setParticleRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleRotationRange_ = "setParticleRotationRange:";

	private static readonly IntPtr selSetParticleRotationRange_Handle = Selector.GetHandle("setParticleRotationRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleRotationSpeed_ = "setParticleRotationSpeed:";

	private static readonly IntPtr selSetParticleRotationSpeed_Handle = Selector.GetHandle("setParticleRotationSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleScale_ = "setParticleScale:";

	private static readonly IntPtr selSetParticleScale_Handle = Selector.GetHandle("setParticleScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleScaleRange_ = "setParticleScaleRange:";

	private static readonly IntPtr selSetParticleScaleRange_Handle = Selector.GetHandle("setParticleScaleRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleScaleSequence_ = "setParticleScaleSequence:";

	private static readonly IntPtr selSetParticleScaleSequence_Handle = Selector.GetHandle("setParticleScaleSequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleScaleSpeed_ = "setParticleScaleSpeed:";

	private static readonly IntPtr selSetParticleScaleSpeed_Handle = Selector.GetHandle("setParticleScaleSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleSize_ = "setParticleSize:";

	private static readonly IntPtr selSetParticleSize_Handle = Selector.GetHandle("setParticleSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleSpeed_ = "setParticleSpeed:";

	private static readonly IntPtr selSetParticleSpeed_Handle = Selector.GetHandle("setParticleSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleSpeedRange_ = "setParticleSpeedRange:";

	private static readonly IntPtr selSetParticleSpeedRange_Handle = Selector.GetHandle("setParticleSpeedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleTexture_ = "setParticleTexture:";

	private static readonly IntPtr selSetParticleTexture_Handle = Selector.GetHandle("setParticleTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleZPosition_ = "setParticleZPosition:";

	private static readonly IntPtr selSetParticleZPosition_Handle = Selector.GetHandle("setParticleZPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleZPositionRange_ = "setParticleZPositionRange:";

	private static readonly IntPtr selSetParticleZPositionRange_Handle = Selector.GetHandle("setParticleZPositionRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParticleZPositionSpeed_ = "setParticleZPositionSpeed:";

	private static readonly IntPtr selSetParticleZPositionSpeed_Handle = Selector.GetHandle("setParticleZPositionSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShader_ = "setShader:";

	private static readonly IntPtr selSetShader_Handle = Selector.GetHandle("setShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTargetNode_ = "setTargetNode:";

	private static readonly IntPtr selSetTargetNode_Handle = Selector.GetHandle("setTargetNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXAcceleration_ = "setXAcceleration:";

	private static readonly IntPtr selSetXAcceleration_Handle = Selector.GetHandle("setXAcceleration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYAcceleration_ = "setYAcceleration:";

	private static readonly IntPtr selSetYAcceleration_Handle = Selector.GetHandle("setYAcceleration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShader = "shader";

	private static readonly IntPtr selShaderHandle = Selector.GetHandle("shader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetNode = "targetNode";

	private static readonly IntPtr selTargetNodeHandle = Selector.GetHandle("targetNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXAcceleration = "xAcceleration";

	private static readonly IntPtr selXAccelerationHandle = Selector.GetHandle("xAcceleration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYAcceleration = "yAcceleration";

	private static readonly IntPtr selYAccelerationHandle = Selector.GetHandle("yAcceleration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKEmitterNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TargetNode_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual NSDictionary<NSString, SKAttributeValue> AttributeValues
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("attributeValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeValuesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAttributeValues:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeValues_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat EmissionAngle
	{
		[Export("emissionAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmissionAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmissionAngleHandle);
		}
		[Export("setEmissionAngle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmissionAngle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmissionAngle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat EmissionAngleRange
	{
		[Export("emissionAngleRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEmissionAngleRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEmissionAngleRangeHandle);
		}
		[Export("setEmissionAngleRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEmissionAngleRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEmissionAngleRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual uint FieldBitMask
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("fieldBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFieldBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFieldBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setFieldBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetFieldBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetFieldBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumParticlesToEmit
	{
		[Export("numParticlesToEmit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumParticlesToEmitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumParticlesToEmitHandle);
		}
		[Export("setNumParticlesToEmit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumParticlesToEmit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumParticlesToEmit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKAction? ParticleAction
	{
		[Export("particleAction", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleActionHandle));
			}
			return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleActionHandle));
		}
		[Export("setParticleAction:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleAction_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleAction_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAlpha
	{
		[Export("particleAlpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAlphaHandle);
		}
		[Export("setParticleAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAlphaRange
	{
		[Export("particleAlphaRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAlphaRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAlphaRangeHandle);
		}
		[Export("setParticleAlphaRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAlphaRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAlphaRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKKeyframeSequence? ParticleAlphaSequence
	{
		[Export("particleAlphaSequence", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleAlphaSequenceHandle));
			}
			return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleAlphaSequenceHandle));
		}
		[Export("setParticleAlphaSequence:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleAlphaSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleAlphaSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleAlphaSpeed
	{
		[Export("particleAlphaSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleAlphaSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleAlphaSpeedHandle);
		}
		[Export("setParticleAlphaSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleAlphaSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleAlphaSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleBirthRate
	{
		[Export("particleBirthRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleBirthRateHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleBirthRateHandle);
		}
		[Export("setParticleBirthRate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleBirthRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleBirthRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKBlendMode ParticleBlendMode
	{
		[Export("particleBlendMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selParticleBlendModeHandle);
			}
			return (SKBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selParticleBlendModeHandle);
		}
		[Export("setParticleBlendMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetParticleBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetParticleBlendMode_Handle, (long)value);
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
	public virtual nfloat ParticleColorAlphaRange
	{
		[Export("particleColorAlphaRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorAlphaRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorAlphaRangeHandle);
		}
		[Export("setParticleColorAlphaRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorAlphaRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorAlphaRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorAlphaSpeed
	{
		[Export("particleColorAlphaSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorAlphaSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorAlphaSpeedHandle);
		}
		[Export("setParticleColorAlphaSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorAlphaSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorAlphaSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorBlendFactor
	{
		[Export("particleColorBlendFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorBlendFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorBlendFactorHandle);
		}
		[Export("setParticleColorBlendFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorBlendFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorBlendFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorBlendFactorRange
	{
		[Export("particleColorBlendFactorRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorBlendFactorRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorBlendFactorRangeHandle);
		}
		[Export("setParticleColorBlendFactorRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorBlendFactorRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorBlendFactorRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKKeyframeSequence? ParticleColorBlendFactorSequence
	{
		[Export("particleColorBlendFactorSequence", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleColorBlendFactorSequenceHandle));
			}
			return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleColorBlendFactorSequenceHandle));
		}
		[Export("setParticleColorBlendFactorSequence:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleColorBlendFactorSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleColorBlendFactorSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorBlendFactorSpeed
	{
		[Export("particleColorBlendFactorSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorBlendFactorSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorBlendFactorSpeedHandle);
		}
		[Export("setParticleColorBlendFactorSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorBlendFactorSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorBlendFactorSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorBlueRange
	{
		[Export("particleColorBlueRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorBlueRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorBlueRangeHandle);
		}
		[Export("setParticleColorBlueRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorBlueRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorBlueRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorBlueSpeed
	{
		[Export("particleColorBlueSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorBlueSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorBlueSpeedHandle);
		}
		[Export("setParticleColorBlueSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorBlueSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorBlueSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorGreenRange
	{
		[Export("particleColorGreenRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorGreenRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorGreenRangeHandle);
		}
		[Export("setParticleColorGreenRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorGreenRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorGreenRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorGreenSpeed
	{
		[Export("particleColorGreenSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorGreenSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorGreenSpeedHandle);
		}
		[Export("setParticleColorGreenSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorGreenSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorGreenSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorRedRange
	{
		[Export("particleColorRedRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorRedRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorRedRangeHandle);
		}
		[Export("setParticleColorRedRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorRedRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorRedRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleColorRedSpeed
	{
		[Export("particleColorRedSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleColorRedSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleColorRedSpeedHandle);
		}
		[Export("setParticleColorRedSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleColorRedSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleColorRedSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKKeyframeSequence? ParticleColorSequence
	{
		[Export("particleColorSequence", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleColorSequenceHandle));
			}
			return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleColorSequenceHandle));
		}
		[Export("setParticleColorSequence:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleColorSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleColorSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleLifetime
	{
		[Export("particleLifetime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleLifetimeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleLifetimeHandle);
		}
		[Export("setParticleLifetime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleLifetime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleLifetime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleLifetimeRange
	{
		[Export("particleLifetimeRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleLifetimeRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleLifetimeRangeHandle);
		}
		[Export("setParticleLifetimeRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleLifetimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleLifetimeRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ParticlePosition
	{
		[Export("particlePosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selParticlePositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selParticlePositionHandle);
		}
		[Export("setParticlePosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetParticlePosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetParticlePosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGVector ParticlePositionRange
	{
		[Export("particlePositionRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGVector_objc_msgSend(base.Handle, selParticlePositionRangeHandle);
			}
			return Messaging.CGVector_objc_msgSendSuper(base.SuperHandle, selParticlePositionRangeHandle);
		}
		[Export("setParticlePositionRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGVector(base.Handle, selSetParticlePositionRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGVector(base.SuperHandle, selSetParticlePositionRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SKParticleRenderOrder ParticleRenderOrder
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("particleRenderOrder", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKParticleRenderOrder)Messaging.UInt64_objc_msgSend(base.Handle, selParticleRenderOrderHandle);
			}
			return (SKParticleRenderOrder)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selParticleRenderOrderHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setParticleRenderOrder:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetParticleRenderOrder_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetParticleRenderOrder_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleRotation
	{
		[Export("particleRotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleRotationHandle);
		}
		[Export("setParticleRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleRotationRange
	{
		[Export("particleRotationRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleRotationRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleRotationRangeHandle);
		}
		[Export("setParticleRotationRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleRotationRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleRotationRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleRotationSpeed
	{
		[Export("particleRotationSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleRotationSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleRotationSpeedHandle);
		}
		[Export("setParticleRotationSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleRotationSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleRotationSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleScale
	{
		[Export("particleScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleScaleHandle);
		}
		[Export("setParticleScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleScaleRange
	{
		[Export("particleScaleRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleScaleRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleScaleRangeHandle);
		}
		[Export("setParticleScaleRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleScaleRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleScaleRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKKeyframeSequence? ParticleScaleSequence
	{
		[Export("particleScaleSequence", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleScaleSequenceHandle));
			}
			return Runtime.GetNSObject<SKKeyframeSequence>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleScaleSequenceHandle));
		}
		[Export("setParticleScaleSequence:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleScaleSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleScaleSequence_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleScaleSpeed
	{
		[Export("particleScaleSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleScaleSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleScaleSpeedHandle);
		}
		[Export("setParticleScaleSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleScaleSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleScaleSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ParticleSize
	{
		[Export("particleSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selParticleSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selParticleSizeHandle);
		}
		[Export("setParticleSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetParticleSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetParticleSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleSpeed
	{
		[Export("particleSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleSpeedHandle);
		}
		[Export("setParticleSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleSpeedRange
	{
		[Export("particleSpeedRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleSpeedRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleSpeedRangeHandle);
		}
		[Export("setParticleSpeedRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleSpeedRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleSpeedRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture? ParticleTexture
	{
		[Export("particleTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticleTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticleTextureHandle));
		}
		[Export("setParticleTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParticleTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParticleTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ParticleZPosition
	{
		[Export("particleZPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleZPositionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleZPositionHandle);
		}
		[Export("setParticleZPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleZPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public virtual nfloat ParticleZPositionRange
	{
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("particleZPositionRange")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleZPositionRangeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleZPositionRangeHandle);
		}
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("setParticleZPositionRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleZPositionRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleZPositionRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public virtual nfloat ParticleZPositionSpeed
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("particleZPositionSpeed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParticleZPositionSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParticleZPositionSpeedHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 8, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("setParticleZPositionSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParticleZPositionSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParticleZPositionSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKShader? Shader
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShaderHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode? TargetNode
	{
		[Export("targetNode", ArgumentSemantic.Weak)]
		get
		{
			SKNode sKNode = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetNodeHandle)) : Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetNodeHandle)));
			MarkDirty();
			__mt_TargetNode_var = sKNode;
			return sKNode;
		}
		[Export("setTargetNode:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTargetNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTargetNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_TargetNode_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat XAcceleration
	{
		[Export("xAcceleration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selXAccelerationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selXAccelerationHandle);
		}
		[Export("setXAcceleration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetXAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetXAcceleration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat YAcceleration
	{
		[Export("yAcceleration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selYAccelerationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selYAccelerationHandle);
		}
		[Export("setYAcceleration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetYAcceleration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetYAcceleration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKEmitterNode()
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
	public SKEmitterNode(NSCoder coder)
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
	protected SKEmitterNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKEmitterNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("advanceSimulationTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AdvanceSimulationTime(double sec)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selAdvanceSimulationTime_Handle, sec);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selAdvanceSimulationTime_Handle, sec);
		}
	}

	[Export("valueForAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual SKAttributeValue? GetValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		SKAttributeValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttributeNamed_Handle, arg)) : Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("resetSimulation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResetSimulation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetSimulationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetSimulationHandle);
		}
	}

	[Export("setValue:forAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SetValue(SKAttributeValue value, string key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TargetNode_var = null;
		}
	}
}
