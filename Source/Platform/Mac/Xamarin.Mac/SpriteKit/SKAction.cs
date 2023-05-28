using System.ComponentModel;
using AppKit;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

[Register("SKAction", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKAction : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionNamed_ = "actionNamed:";

	private static readonly IntPtr selActionNamed_Handle = Selector.GetHandle("actionNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionNamed_Duration_ = "actionNamed:duration:";

	private static readonly IntPtr selActionNamed_Duration_Handle = Selector.GetHandle("actionNamed:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionNamed_FromURL_ = "actionNamed:fromURL:";

	private static readonly IntPtr selActionNamed_FromURL_Handle = Selector.GetHandle("actionNamed:fromURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionNamed_FromURL_Duration_ = "actionNamed:fromURL:duration:";

	private static readonly IntPtr selActionNamed_FromURL_Duration_Handle = Selector.GetHandle("actionNamed:fromURL:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithNormalTextures_TimePerFrame_ = "animateWithNormalTextures:timePerFrame:";

	private static readonly IntPtr selAnimateWithNormalTextures_TimePerFrame_Handle = Selector.GetHandle("animateWithNormalTextures:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_ = "animateWithNormalTextures:timePerFrame:resize:restore:";

	private static readonly IntPtr selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_Handle = Selector.GetHandle("animateWithNormalTextures:timePerFrame:resize:restore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithTextures_TimePerFrame_ = "animateWithTextures:timePerFrame:";

	private static readonly IntPtr selAnimateWithTextures_TimePerFrame_Handle = Selector.GetHandle("animateWithTextures:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithTextures_TimePerFrame_Resize_Restore_ = "animateWithTextures:timePerFrame:resize:restore:";

	private static readonly IntPtr selAnimateWithTextures_TimePerFrame_Resize_Restore_Handle = Selector.GetHandle("animateWithTextures:timePerFrame:resize:restore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithWarps_Times_ = "animateWithWarps:times:";

	private static readonly IntPtr selAnimateWithWarps_Times_Handle = Selector.GetHandle("animateWithWarps:times:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimateWithWarps_Times_Restore_ = "animateWithWarps:times:restore:";

	private static readonly IntPtr selAnimateWithWarps_Times_Restore_Handle = Selector.GetHandle("animateWithWarps:times:restore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyAngularImpulse_Duration_ = "applyAngularImpulse:duration:";

	private static readonly IntPtr selApplyAngularImpulse_Duration_Handle = Selector.GetHandle("applyAngularImpulse:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_AtPoint_Duration_ = "applyForce:atPoint:duration:";

	private static readonly IntPtr selApplyForce_AtPoint_Duration_Handle = Selector.GetHandle("applyForce:atPoint:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyForce_Duration_ = "applyForce:duration:";

	private static readonly IntPtr selApplyForce_Duration_Handle = Selector.GetHandle("applyForce:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyImpulse_AtPoint_Duration_ = "applyImpulse:atPoint:duration:";

	private static readonly IntPtr selApplyImpulse_AtPoint_Duration_Handle = Selector.GetHandle("applyImpulse:atPoint:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyImpulse_Duration_ = "applyImpulse:duration:";

	private static readonly IntPtr selApplyImpulse_Duration_Handle = Selector.GetHandle("applyImpulse:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyTorque_Duration_ = "applyTorque:duration:";

	private static readonly IntPtr selApplyTorque_Duration_Handle = Selector.GetHandle("applyTorque:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeChargeBy_Duration_ = "changeChargeBy:duration:";

	private static readonly IntPtr selChangeChargeBy_Duration_Handle = Selector.GetHandle("changeChargeBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeChargeTo_Duration_ = "changeChargeTo:duration:";

	private static readonly IntPtr selChangeChargeTo_Duration_Handle = Selector.GetHandle("changeChargeTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeMassBy_Duration_ = "changeMassBy:duration:";

	private static readonly IntPtr selChangeMassBy_Duration_Handle = Selector.GetHandle("changeMassBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeMassTo_Duration_ = "changeMassTo:duration:";

	private static readonly IntPtr selChangeMassTo_Duration_Handle = Selector.GetHandle("changeMassTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeObstructionBy_Duration_ = "changeObstructionBy:duration:";

	private static readonly IntPtr selChangeObstructionBy_Duration_Handle = Selector.GetHandle("changeObstructionBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeObstructionTo_Duration_ = "changeObstructionTo:duration:";

	private static readonly IntPtr selChangeObstructionTo_Duration_Handle = Selector.GetHandle("changeObstructionTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeOcclusionBy_Duration_ = "changeOcclusionBy:duration:";

	private static readonly IntPtr selChangeOcclusionBy_Duration_Handle = Selector.GetHandle("changeOcclusionBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeOcclusionTo_Duration_ = "changeOcclusionTo:duration:";

	private static readonly IntPtr selChangeOcclusionTo_Duration_Handle = Selector.GetHandle("changeOcclusionTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangePlaybackRateBy_Duration_ = "changePlaybackRateBy:duration:";

	private static readonly IntPtr selChangePlaybackRateBy_Duration_Handle = Selector.GetHandle("changePlaybackRateBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangePlaybackRateTo_Duration_ = "changePlaybackRateTo:duration:";

	private static readonly IntPtr selChangePlaybackRateTo_Duration_Handle = Selector.GetHandle("changePlaybackRateTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeReverbBy_Duration_ = "changeReverbBy:duration:";

	private static readonly IntPtr selChangeReverbBy_Duration_Handle = Selector.GetHandle("changeReverbBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeReverbTo_Duration_ = "changeReverbTo:duration:";

	private static readonly IntPtr selChangeReverbTo_Duration_Handle = Selector.GetHandle("changeReverbTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeVolumeBy_Duration_ = "changeVolumeBy:duration:";

	private static readonly IntPtr selChangeVolumeBy_Duration_Handle = Selector.GetHandle("changeVolumeBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeVolumeTo_Duration_ = "changeVolumeTo:duration:";

	private static readonly IntPtr selChangeVolumeTo_Duration_Handle = Selector.GetHandle("changeVolumeTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorizeWithColor_ColorBlendFactor_Duration_ = "colorizeWithColor:colorBlendFactor:duration:";

	private static readonly IntPtr selColorizeWithColor_ColorBlendFactor_Duration_Handle = Selector.GetHandle("colorizeWithColor:colorBlendFactor:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorizeWithColorBlendFactor_Duration_ = "colorizeWithColorBlendFactor:duration:";

	private static readonly IntPtr selColorizeWithColorBlendFactor_Duration_Handle = Selector.GetHandle("colorizeWithColorBlendFactor:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomActionWithDuration_ActionBlock_ = "customActionWithDuration:actionBlock:";

	private static readonly IntPtr selCustomActionWithDuration_ActionBlock_Handle = Selector.GetHandle("customActionWithDuration:actionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeAlphaBy_Duration_ = "fadeAlphaBy:duration:";

	private static readonly IntPtr selFadeAlphaBy_Duration_Handle = Selector.GetHandle("fadeAlphaBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeAlphaTo_Duration_ = "fadeAlphaTo:duration:";

	private static readonly IntPtr selFadeAlphaTo_Duration_Handle = Selector.GetHandle("fadeAlphaTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeInWithDuration_ = "fadeInWithDuration:";

	private static readonly IntPtr selFadeInWithDuration_Handle = Selector.GetHandle("fadeInWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeOutWithDuration_ = "fadeOutWithDuration:";

	private static readonly IntPtr selFadeOutWithDuration_Handle = Selector.GetHandle("fadeOutWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFalloffBy_Duration_ = "falloffBy:duration:";

	private static readonly IntPtr selFalloffBy_Duration_Handle = Selector.GetHandle("falloffBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFalloffTo_Duration_ = "falloffTo:duration:";

	private static readonly IntPtr selFalloffTo_Duration_Handle = Selector.GetHandle("falloffTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFollowPath_AsOffset_OrientToPath_Duration_ = "followPath:asOffset:orientToPath:duration:";

	private static readonly IntPtr selFollowPath_AsOffset_OrientToPath_Duration_Handle = Selector.GetHandle("followPath:asOffset:orientToPath:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFollowPath_AsOffset_OrientToPath_Speed_ = "followPath:asOffset:orientToPath:speed:";

	private static readonly IntPtr selFollowPath_AsOffset_OrientToPath_Speed_Handle = Selector.GetHandle("followPath:asOffset:orientToPath:speed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFollowPath_Duration_ = "followPath:duration:";

	private static readonly IntPtr selFollowPath_Duration_Handle = Selector.GetHandle("followPath:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFollowPath_Speed_ = "followPath:speed:";

	private static readonly IntPtr selFollowPath_Speed_Handle = Selector.GetHandle("followPath:speed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroup_ = "group:";

	private static readonly IntPtr selGroup_Handle = Selector.GetHandle("group:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHide = "hide";

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveBy_Duration_ = "moveBy:duration:";

	private static readonly IntPtr selMoveBy_Duration_Handle = Selector.GetHandle("moveBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveByX_Y_Duration_ = "moveByX:y:duration:";

	private static readonly IntPtr selMoveByX_Y_Duration_Handle = Selector.GetHandle("moveByX:y:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveTo_Duration_ = "moveTo:duration:";

	private static readonly IntPtr selMoveTo_Duration_Handle = Selector.GetHandle("moveTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToX_Duration_ = "moveToX:duration:";

	private static readonly IntPtr selMoveToX_Duration_Handle = Selector.GetHandle("moveToX:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToY_Duration_ = "moveToY:duration:";

	private static readonly IntPtr selMoveToY_Duration_Handle = Selector.GetHandle("moveToY:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSelector_OnTarget_ = "performSelector:onTarget:";

	private static readonly IntPtr selPerformSelector_OnTarget_Handle = Selector.GetHandle("performSelector:onTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaySoundFileNamed_WaitForCompletion_ = "playSoundFileNamed:waitForCompletion:";

	private static readonly IntPtr selPlaySoundFileNamed_WaitForCompletion_Handle = Selector.GetHandle("playSoundFileNamed:waitForCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReachTo_RootNode_Duration_ = "reachTo:rootNode:duration:";

	private static readonly IntPtr selReachTo_RootNode_Duration_Handle = Selector.GetHandle("reachTo:rootNode:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReachTo_RootNode_Velocity_ = "reachTo:rootNode:velocity:";

	private static readonly IntPtr selReachTo_RootNode_Velocity_Handle = Selector.GetHandle("reachTo:rootNode:velocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReachToNode_RootNode_Duration_ = "reachToNode:rootNode:duration:";

	private static readonly IntPtr selReachToNode_RootNode_Duration_Handle = Selector.GetHandle("reachToNode:rootNode:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReachToNode_RootNode_Velocity_ = "reachToNode:rootNode:velocity:";

	private static readonly IntPtr selReachToNode_RootNode_Velocity_Handle = Selector.GetHandle("reachToNode:rootNode:velocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromParent = "removeFromParent";

	private static readonly IntPtr selRemoveFromParentHandle = Selector.GetHandle("removeFromParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatAction_Count_ = "repeatAction:count:";

	private static readonly IntPtr selRepeatAction_Count_Handle = Selector.GetHandle("repeatAction:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatActionForever_ = "repeatActionForever:";

	private static readonly IntPtr selRepeatActionForever_Handle = Selector.GetHandle("repeatActionForever:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeByWidth_Height_Duration_ = "resizeByWidth:height:duration:";

	private static readonly IntPtr selResizeByWidth_Height_Duration_Handle = Selector.GetHandle("resizeByWidth:height:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeToHeight_Duration_ = "resizeToHeight:duration:";

	private static readonly IntPtr selResizeToHeight_Duration_Handle = Selector.GetHandle("resizeToHeight:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeToWidth_Duration_ = "resizeToWidth:duration:";

	private static readonly IntPtr selResizeToWidth_Duration_Handle = Selector.GetHandle("resizeToWidth:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeToWidth_Height_Duration_ = "resizeToWidth:height:duration:";

	private static readonly IntPtr selResizeToWidth_Height_Duration_Handle = Selector.GetHandle("resizeToWidth:height:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReversedAction = "reversedAction";

	private static readonly IntPtr selReversedActionHandle = Selector.GetHandle("reversedAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByAngle_Duration_ = "rotateByAngle:duration:";

	private static readonly IntPtr selRotateByAngle_Duration_Handle = Selector.GetHandle("rotateByAngle:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateToAngle_Duration_ = "rotateToAngle:duration:";

	private static readonly IntPtr selRotateToAngle_Duration_Handle = Selector.GetHandle("rotateToAngle:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateToAngle_Duration_ShortestUnitArc_ = "rotateToAngle:duration:shortestUnitArc:";

	private static readonly IntPtr selRotateToAngle_Duration_ShortestUnitArc_Handle = Selector.GetHandle("rotateToAngle:duration:shortestUnitArc:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAction_OnChildWithName_ = "runAction:onChildWithName:";

	private static readonly IntPtr selRunAction_OnChildWithName_Handle = Selector.GetHandle("runAction:onChildWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunBlock_ = "runBlock:";

	private static readonly IntPtr selRunBlock_Handle = Selector.GetHandle("runBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunBlock_Queue_ = "runBlock:queue:";

	private static readonly IntPtr selRunBlock_Queue_Handle = Selector.GetHandle("runBlock:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleBy_Duration_ = "scaleBy:duration:";

	private static readonly IntPtr selScaleBy_Duration_Handle = Selector.GetHandle("scaleBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleTo_Duration_ = "scaleTo:duration:";

	private static readonly IntPtr selScaleTo_Duration_Handle = Selector.GetHandle("scaleTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleToSize_Duration_ = "scaleToSize:duration:";

	private static readonly IntPtr selScaleToSize_Duration_Handle = Selector.GetHandle("scaleToSize:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXBy_Y_Duration_ = "scaleXBy:y:duration:";

	private static readonly IntPtr selScaleXBy_Y_Duration_Handle = Selector.GetHandle("scaleXBy:y:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXTo_Duration_ = "scaleXTo:duration:";

	private static readonly IntPtr selScaleXTo_Duration_Handle = Selector.GetHandle("scaleXTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXTo_Y_Duration_ = "scaleXTo:y:duration:";

	private static readonly IntPtr selScaleXTo_Y_Duration_Handle = Selector.GetHandle("scaleXTo:y:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleYTo_Duration_ = "scaleYTo:duration:";

	private static readonly IntPtr selScaleYTo_Duration_Handle = Selector.GetHandle("scaleYTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequence_ = "sequence:";

	private static readonly IntPtr selSequence_Handle = Selector.GetHandle("sequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalTexture_ = "setNormalTexture:";

	private static readonly IntPtr selSetNormalTexture_Handle = Selector.GetHandle("setNormalTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalTexture_Resize_ = "setNormalTexture:resize:";

	private static readonly IntPtr selSetNormalTexture_Resize_Handle = Selector.GetHandle("setNormalTexture:resize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTexture_ = "setTexture:";

	private static readonly IntPtr selSetTexture_Handle = Selector.GetHandle("setTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTexture_Resize_ = "setTexture:resize:";

	private static readonly IntPtr selSetTexture_Resize_Handle = Selector.GetHandle("setTexture:resize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingFunction_ = "setTimingFunction:";

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingMode_ = "setTimingMode:";

	private static readonly IntPtr selSetTimingMode_Handle = Selector.GetHandle("setTimingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeedBy_Duration_ = "speedBy:duration:";

	private static readonly IntPtr selSpeedBy_Duration_Handle = Selector.GetHandle("speedBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeedTo_Duration_ = "speedTo:duration:";

	private static readonly IntPtr selSpeedTo_Duration_Handle = Selector.GetHandle("speedTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStereoPanBy_Duration_ = "stereoPanBy:duration:";

	private static readonly IntPtr selStereoPanBy_Duration_Handle = Selector.GetHandle("stereoPanBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStereoPanTo_Duration_ = "stereoPanTo:duration:";

	private static readonly IntPtr selStereoPanTo_Duration_Handle = Selector.GetHandle("stereoPanTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrengthBy_Duration_ = "strengthBy:duration:";

	private static readonly IntPtr selStrengthBy_Duration_Handle = Selector.GetHandle("strengthBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrengthTo_Duration_ = "strengthTo:duration:";

	private static readonly IntPtr selStrengthTo_Duration_Handle = Selector.GetHandle("strengthTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingFunction = "timingFunction";

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingMode = "timingMode";

	private static readonly IntPtr selTimingModeHandle = Selector.GetHandle("timingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnhide = "unhide";

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDuration_ = "waitForDuration:";

	private static readonly IntPtr selWaitForDuration_Handle = Selector.GetHandle("waitForDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDuration_WithRange_ = "waitForDuration:withRange:";

	private static readonly IntPtr selWaitForDuration_WithRange_Handle = Selector.GetHandle("waitForDuration:withRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWarpTo_Duration_ = "warpTo:duration:";

	private static readonly IntPtr selWarpTo_Duration_Handle = Selector.GetHandle("warpTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKAction");

	[Obsolete("Use 'TimingFunction2' instead.")]
	public virtual SKActionTimingFunction TimingFunction { get; set; }

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKAction ReversedAction
	{
		[Export("reversedAction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedActionHandle));
			}
			return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedActionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Speed
	{
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public unsafe virtual SKActionTimingFunction2? TimingFunction2
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("timingFunction", ArgumentSemantic.Assign)]
		[return: DelegateProxy(typeof(Trampolines.SDSKActionTimingFunction2))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle));
			return Trampolines.NIDSKActionTimingFunction2.Create(block);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setTimingFunction:", ArgumentSemantic.Assign)]
		[param: BlockProxy(typeof(Trampolines.NIDSKActionTimingFunction2))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSKActionTimingFunction2.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKActionTimingMode TimingMode
	{
		[Export("timingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKActionTimingMode)Messaging.Int64_objc_msgSend(base.Handle, selTimingModeHandle);
			}
			return (SKActionTimingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTimingModeHandle);
		}
		[Export("setTimingMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTimingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTimingMode_Handle, (long)value);
			}
		}
	}

	public static SKAction ResizeTo(CGSize size, double duration)
	{
		return ResizeTo(size.Width, size.Height, duration);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKAction(NSCoder coder)
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
	protected SKAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKAction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animateWithWarps:times:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Animate(SKWarpGeometry[] warps, NSNumber[] times)
	{
		if (warps == null)
		{
			throw new ArgumentNullException("warps");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		NSArray nSArray = NSArray.FromNSObjects(warps);
		NSArray nSArray2 = NSArray.FromNSObjects(times);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAnimateWithWarps_Times_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("animateWithWarps:times:restore:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Animate(SKWarpGeometry[] warps, NSNumber[] times, bool restore)
	{
		if (warps == null)
		{
			throw new ArgumentNullException("warps");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		NSArray nSArray = NSArray.FromNSObjects(warps);
		NSArray nSArray2 = NSArray.FromNSObjects(times);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(class_ptr, selAnimateWithWarps_Times_Restore_Handle, nSArray.Handle, nSArray2.Handle, restore));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("animateWithNormalTextures:timePerFrame:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction AnimateWithNormalTextures(SKTexture[] textures, double secondsPerFrame)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selAnimateWithNormalTextures_TimePerFrame_Handle, nSArray.Handle, secondsPerFrame));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("animateWithNormalTextures:timePerFrame:resize:restore:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction AnimateWithNormalTextures(SKTexture[] textures, double secondsPerFrame, bool resize, bool restore)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double_bool_bool(class_ptr, selAnimateWithNormalTextures_TimePerFrame_Resize_Restore_Handle, nSArray.Handle, secondsPerFrame, resize, restore));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("animateWithTextures:timePerFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction AnimateWithTextures(SKTexture[] textures, double sec)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selAnimateWithTextures_TimePerFrame_Handle, nSArray.Handle, sec));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("animateWithTextures:timePerFrame:resize:restore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction AnimateWithTextures(SKTexture[] textures, double sec, bool resize, bool restore)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double_bool_bool(class_ptr, selAnimateWithTextures_TimePerFrame_Resize_Restore_Handle, nSArray.Handle, sec, resize, restore));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("colorizeWithColor:colorBlendFactor:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ColorizeWithColor(NSColor color, nfloat colorBlendFactor, double sec)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_Double(class_ptr, selColorizeWithColor_ColorBlendFactor_Duration_Handle, color.Handle, colorBlendFactor, sec));
	}

	[Export("colorizeWithColorBlendFactor:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ColorizeWithColorBlendFactor(nfloat colorBlendFactor, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selColorizeWithColorBlendFactor_Duration_Handle, colorBlendFactor, sec));
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

	[Export("actionNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Create(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selActionNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("actionNamed:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Create(string name, double duration)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selActionNamed_Duration_Handle, arg, duration));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("actionNamed:fromURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Create(string name, NSUrl url)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selActionNamed_FromURL_Handle, arg, url.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("actionNamed:fromURL:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? Create(string name, NSUrl url, double duration)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double(class_ptr, selActionNamed_FromURL_Duration_Handle, arg, url.Handle, duration));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("applyAngularImpulse:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyAngularImpulse(nfloat impulse, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selApplyAngularImpulse_Duration_Handle, impulse, duration));
	}

	[Export("applyForce:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyForce(CGVector force, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGVector_Double(class_ptr, selApplyForce_Duration_Handle, force, duration));
	}

	[Export("applyForce:atPoint:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyForce(CGVector force, CGPoint point, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGVector_CGPoint_Double(class_ptr, selApplyForce_AtPoint_Duration_Handle, force, point, duration));
	}

	[Export("applyImpulse:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyImpulse(CGVector impulse, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGVector_Double(class_ptr, selApplyImpulse_Duration_Handle, impulse, duration));
	}

	[Export("applyImpulse:atPoint:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyImpulse(CGVector impulse, CGPoint point, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGVector_CGPoint_Double(class_ptr, selApplyImpulse_AtPoint_Duration_Handle, impulse, point, duration));
	}

	[Export("applyTorque:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateApplyTorque(nfloat torque, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selApplyTorque_Duration_Handle, torque, duration));
	}

	[Export("changeChargeBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeChargeBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeChargeBy_Duration_Handle, by, duration));
	}

	[Export("changeChargeTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeChargeTo(float newCharge, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeChargeTo_Duration_Handle, newCharge, duration));
	}

	[Export("changeMassBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeMassBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeMassBy_Duration_Handle, by, duration));
	}

	[Export("changeMassTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeMassTo(float newMass, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeMassTo_Duration_Handle, newMass, duration));
	}

	[Export("changeObstructionBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeObstructionBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeObstructionBy_Duration_Handle, by, duration));
	}

	[Export("changeObstructionTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeObstructionTo(float target, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeObstructionTo_Duration_Handle, target, duration));
	}

	[Export("changeOcclusionBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeOcclusionBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeOcclusionBy_Duration_Handle, by, duration));
	}

	[Export("changeOcclusionTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeOcclusionTo(float target, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeOcclusionTo_Duration_Handle, target, duration));
	}

	[Export("changePlaybackRateTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangePlaybackRate(float playbackRate, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangePlaybackRateTo_Duration_Handle, playbackRate, duration));
	}

	[Export("changePlaybackRateBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangePlaybackRateBy(float playbackRate, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangePlaybackRateBy_Duration_Handle, playbackRate, duration));
	}

	[Export("changeReverbBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeReverbBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeReverbBy_Duration_Handle, by, duration));
	}

	[Export("changeReverbTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeReverbTo(float target, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeReverbTo_Duration_Handle, target, duration));
	}

	[Export("changeVolumeTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeVolume(float newVolume, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeVolumeTo_Duration_Handle, newVolume, duration));
	}

	[Export("changeVolumeBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateChangeVolumeBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selChangeVolumeBy_Duration_Handle, by, duration));
	}

	[Export("pause")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreatePause()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selPauseHandle));
	}

	[Export("play")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreatePlay()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selPlayHandle));
	}

	[Export("stereoPanBy:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateStereoPanBy(float by, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selStereoPanBy_Duration_Handle, by, duration));
	}

	[Export("stereoPanTo:duration:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateStereoPanTo(float target, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selStereoPanTo_Duration_Handle, target, duration));
	}

	[Export("stop")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction CreateStop()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selStopHandle));
	}

	[Export("customActionWithDuration:actionBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SKAction CustomActionWithDuration(double seconds, [BlockProxy(typeof(Trampolines.NIDSKActionDurationHandler))] SKActionDurationHandler actionHandler)
	{
		if (actionHandler == null)
		{
			throw new ArgumentNullException("actionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKActionDurationHandler.Handler, actionHandler);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_Double_IntPtr(class_ptr, selCustomActionWithDuration_ActionBlock_Handle, seconds, (IntPtr)ptr));
		ptr->CleanupBlock();
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

	[Export("fadeAlphaBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FadeAlphaBy(nfloat factor, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selFadeAlphaBy_Duration_Handle, factor, sec));
	}

	[Export("fadeAlphaTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FadeAlphaTo(nfloat alpha, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selFadeAlphaTo_Duration_Handle, alpha, sec));
	}

	[Export("fadeInWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FadeInWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFadeInWithDuration_Handle, sec));
	}

	[Export("fadeOutWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FadeOutWithDuration(double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFadeOutWithDuration_Handle, sec));
	}

	[Export("falloffBy:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FalloffBy(float to, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selFalloffBy_Duration_Handle, to, duration));
	}

	[Export("falloffTo:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FalloffTo(float falloff, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selFalloffTo_Duration_Handle, falloff, sec));
	}

	[Export("followPath:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FollowPath(CGPath path, double sec)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFollowPath_Duration_Handle, path.Handle, sec));
	}

	[Export("followPath:asOffset:orientToPath:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FollowPath(CGPath path, bool offset, bool orient, double sec)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_Double(class_ptr, selFollowPath_AsOffset_OrientToPath_Duration_Handle, path.Handle, offset, orient, sec));
	}

	[Export("followPath:speed:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FollowPath(CGPath path, nfloat speed)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selFollowPath_Speed_Handle, path.Handle, speed));
	}

	[Export("followPath:asOffset:orientToPath:speed:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction FollowPath(CGPath path, bool offset, bool orient, nfloat speed)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_nfloat(class_ptr, selFollowPath_AsOffset_OrientToPath_Speed_Handle, path.Handle, offset, orient, speed));
	}

	[Export("group:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction Group(params SKAction[] actions)
	{
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		NSArray nSArray = NSArray.FromNSObjects(actions);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGroup_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("hide")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction Hide()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selHideHandle));
	}

	[Export("moveByX:y:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction MoveBy(nfloat deltaX, nfloat deltaY, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_Double(class_ptr, selMoveByX_Y_Duration_Handle, deltaX, deltaY, sec));
	}

	[Export("moveBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction MoveBy(CGVector delta, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGVector_Double(class_ptr, selMoveBy_Duration_Handle, delta, duration));
	}

	[Export("moveTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction MoveTo(CGPoint location, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGPoint_Double(class_ptr, selMoveTo_Duration_Handle, location, sec));
	}

	[Export("moveToX:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction MoveToX(nfloat x, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selMoveToX_Duration_Handle, x, sec));
	}

	[Export("moveToY:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction MoveToY(nfloat y, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selMoveToY_Duration_Handle, y, sec));
	}

	[Export("performSelector:onTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static SKAction PerformSelector(Selector selector, NSObject target)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPerformSelector_OnTarget_Handle, selector.Handle, target.Handle));
	}

	[Export("playSoundFileNamed:waitForCompletion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction PlaySoundFileNamed(string soundFile, bool wait)
	{
		if (soundFile == null)
		{
			throw new ArgumentNullException("soundFile");
		}
		IntPtr arg = NSString.CreateNative(soundFile);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selPlaySoundFileNamed_WaitForCompletion_Handle, arg, wait));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("reachTo:rootNode:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ReachTo(CGPoint position, SKNode rootNode, double secs)
	{
		if (rootNode == null)
		{
			throw new ArgumentNullException("rootNode");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr_Double(class_ptr, selReachTo_RootNode_Duration_Handle, position, rootNode.Handle, secs));
	}

	[Export("reachTo:rootNode:velocity:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ReachTo(CGPoint position, SKNode rootNode, nfloat velocity)
	{
		if (rootNode == null)
		{
			throw new ArgumentNullException("rootNode");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr_nfloat(class_ptr, selReachTo_RootNode_Velocity_Handle, position, rootNode.Handle, velocity));
	}

	[Export("reachToNode:rootNode:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ReachToNode(SKNode node, SKNode rootNode, double sec)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (rootNode == null)
		{
			throw new ArgumentNullException("rootNode");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double(class_ptr, selReachToNode_RootNode_Duration_Handle, node.Handle, rootNode.Handle, sec));
	}

	[Export("reachToNode:rootNode:velocity:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ReachToNode(SKNode node, SKNode rootNode, nfloat velocity)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (rootNode == null)
		{
			throw new ArgumentNullException("rootNode");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nfloat(class_ptr, selReachToNode_RootNode_Velocity_Handle, node.Handle, rootNode.Handle, velocity));
	}

	[Export("removeFromParent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RemoveFromParent()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selRemoveFromParentHandle));
	}

	[Export("repeatAction:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RepeatAction(SKAction action, nuint count)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selRepeatAction_Count_Handle, action.Handle, count));
	}

	[Export("repeatActionForever:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RepeatActionForever(SKAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRepeatActionForever_Handle, action.Handle));
	}

	[Export("resizeByWidth:height:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ResizeByWidth(nfloat width, nfloat height, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_Double(class_ptr, selResizeByWidth_Height_Duration_Handle, width, height, duration));
	}

	[Export("resizeToWidth:height:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ResizeTo(nfloat width, nfloat height, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_Double(class_ptr, selResizeToWidth_Height_Duration_Handle, width, height, duration));
	}

	[Export("resizeToHeight:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ResizeToHeight(nfloat height, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selResizeToHeight_Duration_Handle, height, duration));
	}

	[Export("resizeToWidth:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ResizeToWidth(nfloat width, double duration)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selResizeToWidth_Duration_Handle, width, duration));
	}

	[Export("rotateByAngle:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RotateByAngle(nfloat radians, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selRotateByAngle_Duration_Handle, radians, sec));
	}

	[Export("rotateToAngle:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RotateToAngle(nfloat radians, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selRotateToAngle_Duration_Handle, radians, sec));
	}

	[Export("rotateToAngle:duration:shortestUnitArc:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RotateToAngle(nfloat radians, double sec, bool shortedUnitArc)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double_bool(class_ptr, selRotateToAngle_Duration_ShortestUnitArc_Handle, radians, sec, shortedUnitArc));
	}

	[Export("runBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SKAction Run([BlockProxy(typeof(Trampolines.NIDAction))] Action block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRunBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("runBlock:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SKAction Run([BlockProxy(typeof(Trampolines.NIDAction))] Action block, DispatchQueue queue)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRunBlock_Queue_Handle, (IntPtr)ptr, queue.Handle));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("runAction:onChildWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction RunAction(SKAction action, string name)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRunAction_OnChildWithName_Handle, action.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("scaleBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleBy(nfloat scale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleBy_Duration_Handle, scale, sec));
	}

	[Export("scaleXBy:y:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleBy(nfloat xScale, nfloat yScale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_Double(class_ptr, selScaleXBy_Y_Duration_Handle, xScale, yScale, sec));
	}

	[Export("scaleTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleTo(nfloat scale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleTo_Duration_Handle, scale, sec));
	}

	[Export("scaleXTo:y:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleTo(nfloat xScale, nfloat yScale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_Double(class_ptr, selScaleXTo_Y_Duration_Handle, xScale, yScale, sec));
	}

	[Export("scaleToSize:duration:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleTo(CGSize size, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_CGSize_Double(class_ptr, selScaleToSize_Duration_Handle, size, sec));
	}

	[Export("scaleXTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleXTo(nfloat scale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleXTo_Duration_Handle, scale, sec));
	}

	[Export("scaleYTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction ScaleYTo(nfloat scale, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleYTo_Duration_Handle, scale, sec));
	}

	[Export("sequence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction Sequence(params SKAction[] actions)
	{
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		NSArray nSArray = NSArray.FromNSObjects(actions);
		SKAction nSObject = Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSequence_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("setNormalTexture:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SetNormalTexture(SKTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSetNormalTexture_Handle, texture.Handle));
	}

	[Export("setNormalTexture:resize:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SetNormalTexture(SKTexture texture, bool resize)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selSetNormalTexture_Resize_Handle, texture.Handle, resize));
	}

	[Export("setTexture:")]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SetTexture(SKTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSetTexture_Handle, texture.Handle));
	}

	[Export("setTexture:resize:")]
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SetTexture(SKTexture texture, bool resize)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selSetTexture_Resize_Handle, texture.Handle, resize));
	}

	[Export("speedBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SpeedBy(nfloat speed, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selSpeedBy_Duration_Handle, speed, sec));
	}

	[Export("speedTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction SpeedTo(nfloat speed, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selSpeedTo_Duration_Handle, speed, sec));
	}

	[Export("strengthBy:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction StrengthBy(float strength, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selStrengthBy_Duration_Handle, strength, sec));
	}

	[Export("strengthTo:duration:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction StrengthTo(float strength, double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_float_Double(class_ptr, selStrengthTo_Duration_Handle, strength, sec));
	}

	[Export("unhide")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction Unhide()
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnhideHandle));
	}

	[Export("waitForDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction WaitForDuration(double sec)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selWaitForDuration_Handle, sec));
	}

	[Export("waitForDuration:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction WaitForDuration(double sec, double durationRange)
	{
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_Double_Double(class_ptr, selWaitForDuration_WithRange_Handle, sec, durationRange));
	}

	[Export("warpTo:duration:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAction? WarpTo(SKWarpGeometry warp, double duration)
	{
		if (warp == null)
		{
			throw new ArgumentNullException("warp");
		}
		return Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selWarpTo_Duration_Handle, warp.Handle, duration));
	}
}
