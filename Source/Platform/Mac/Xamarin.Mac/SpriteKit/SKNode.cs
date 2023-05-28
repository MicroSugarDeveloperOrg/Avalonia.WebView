using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreGraphics;
using Foundation;
using GameplayKit;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKNode", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class SKNode : NSResponder, IEnumerable, IEnumerable<SKNode>, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionForKey_ = "actionForKey:";

	private static readonly IntPtr selActionForKey_Handle = Selector.GetHandle("actionForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChild_ = "addChild:";

	private static readonly IntPtr selAddChild_Handle = Selector.GetHandle("addChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalculateAccumulatedFrame = "calculateAccumulatedFrame";

	private static readonly IntPtr selCalculateAccumulatedFrameHandle = Selector.GetHandle("calculateAccumulatedFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildNodeWithName_ = "childNodeWithName:";

	private static readonly IntPtr selChildNodeWithName_Handle = Selector.GetHandle("childNodeWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildren = "children";

	private static readonly IntPtr selChildrenHandle = Selector.GetHandle("children");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraints = "constraints";

	private static readonly IntPtr selConstraintsHandle = Selector.GetHandle("constraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsPoint_ = "containsPoint:";

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_FromNode_ = "convertPoint:fromNode:";

	private static readonly IntPtr selConvertPoint_FromNode_Handle = Selector.GetHandle("convertPoint:fromNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertPoint_ToNode_ = "convertPoint:toNode:";

	private static readonly IntPtr selConvertPoint_ToNode_Handle = Selector.GetHandle("convertPoint:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateChildNodesWithName_UsingBlock_ = "enumerateChildNodesWithName:usingBlock:";

	private static readonly IntPtr selEnumerateChildNodesWithName_UsingBlock_Handle = Selector.GetHandle("enumerateChildNodesWithName:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasActions = "hasActions";

	private static readonly IntPtr selHasActionsHandle = Selector.GetHandle("hasActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInParentHierarchy_ = "inParentHierarchy:";

	private static readonly IntPtr selInParentHierarchy_Handle = Selector.GetHandle("inParentHierarchy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertChild_AtIndex_ = "insertChild:atIndex:";

	private static readonly IntPtr selInsertChild_AtIndex_Handle = Selector.GetHandle("insertChild:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsNode_ = "intersectsNode:";

	private static readonly IntPtr selIntersectsNode_Handle = Selector.GetHandle("intersectsNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToNode_ = "isEqualToNode:";

	private static readonly IntPtr selIsEqualToNode_Handle = Selector.GetHandle("isEqualToNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUserInteractionEnabled = "isUserInteractionEnabled";

	private static readonly IntPtr selIsUserInteractionEnabledHandle = Selector.GetHandle("isUserInteractionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToParent_ = "moveToParent:";

	private static readonly IntPtr selMoveToParent_Handle = Selector.GetHandle("moveToParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNode = "node";

	private static readonly IntPtr selNodeHandle = Selector.GetHandle("node");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeAtPoint_ = "nodeAtPoint:";

	private static readonly IntPtr selNodeAtPoint_Handle = Selector.GetHandle("nodeAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithFileNamed_ = "nodeWithFileNamed:";

	private static readonly IntPtr selNodeWithFileNamed_Handle = Selector.GetHandle("nodeWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithFileNamed_SecurelyWithClasses_AndError_ = "nodeWithFileNamed:securelyWithClasses:andError:";

	private static readonly IntPtr selNodeWithFileNamed_SecurelyWithClasses_AndError_Handle = Selector.GetHandle("nodeWithFileNamed:securelyWithClasses:andError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodesAtPoint_ = "nodesAtPoint:";

	private static readonly IntPtr selNodesAtPoint_Handle = Selector.GetHandle("nodesAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstaclesFromNodeBounds_ = "obstaclesFromNodeBounds:";

	private static readonly IntPtr selObstaclesFromNodeBounds_Handle = Selector.GetHandle("obstaclesFromNodeBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstaclesFromNodePhysicsBodies_ = "obstaclesFromNodePhysicsBodies:";

	private static readonly IntPtr selObstaclesFromNodePhysicsBodies_Handle = Selector.GetHandle("obstaclesFromNodePhysicsBodies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstaclesFromSpriteTextures_Accuracy_ = "obstaclesFromSpriteTextures:accuracy:";

	private static readonly IntPtr selObstaclesFromSpriteTextures_Accuracy_Handle = Selector.GetHandle("obstaclesFromSpriteTextures:accuracy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParent = "parent";

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhysicsBody = "physicsBody";

	private static readonly IntPtr selPhysicsBodyHandle = Selector.GetHandle("physicsBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReachConstraints = "reachConstraints";

	private static readonly IntPtr selReachConstraintsHandle = Selector.GetHandle("reachConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveActionForKey_ = "removeActionForKey:";

	private static readonly IntPtr selRemoveActionForKey_Handle = Selector.GetHandle("removeActionForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllActions = "removeAllActions";

	private static readonly IntPtr selRemoveAllActionsHandle = Selector.GetHandle("removeAllActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllChildren = "removeAllChildren";

	private static readonly IntPtr selRemoveAllChildrenHandle = Selector.GetHandle("removeAllChildren");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChildrenInArray_ = "removeChildrenInArray:";

	private static readonly IntPtr selRemoveChildrenInArray_Handle = Selector.GetHandle("removeChildrenInArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromParent = "removeFromParent";

	private static readonly IntPtr selRemoveFromParentHandle = Selector.GetHandle("removeFromParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAction_ = "runAction:";

	private static readonly IntPtr selRunAction_Handle = Selector.GetHandle("runAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAction_Completion_ = "runAction:completion:";

	private static readonly IntPtr selRunAction_Completion_Handle = Selector.GetHandle("runAction:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunAction_WithKey_ = "runAction:withKey:";

	private static readonly IntPtr selRunAction_WithKey_Handle = Selector.GetHandle("runAction:withKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScene = "scene";

	private static readonly IntPtr selSceneHandle = Selector.GetHandle("scene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstraints_ = "setConstraints:";

	private static readonly IntPtr selSetConstraints_Handle = Selector.GetHandle("setConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaused_ = "setPaused:";

	private static readonly IntPtr selSetPaused_Handle = Selector.GetHandle("setPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhysicsBody_ = "setPhysicsBody:";

	private static readonly IntPtr selSetPhysicsBody_Handle = Selector.GetHandle("setPhysicsBody:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReachConstraints_ = "setReachConstraints:";

	private static readonly IntPtr selSetReachConstraints_Handle = Selector.GetHandle("setReachConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScale_ = "setScale:";

	private static readonly IntPtr selSetScale_Handle = Selector.GetHandle("setScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserData_ = "setUserData:";

	private static readonly IntPtr selSetUserData_Handle = Selector.GetHandle("setUserData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInteractionEnabled_ = "setUserInteractionEnabled:";

	private static readonly IntPtr selSetUserInteractionEnabled_Handle = Selector.GetHandle("setUserInteractionEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXScale_ = "setXScale:";

	private static readonly IntPtr selSetXScale_Handle = Selector.GetHandle("setXScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYScale_ = "setYScale:";

	private static readonly IntPtr selSetYScale_Handle = Selector.GetHandle("setYScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZPosition_ = "setZPosition:";

	private static readonly IntPtr selSetZPosition_Handle = Selector.GetHandle("setZPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZRotation_ = "setZRotation:";

	private static readonly IntPtr selSetZRotation_Handle = Selector.GetHandle("setZRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserData = "userData";

	private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXScale = "xScale";

	private static readonly IntPtr selXScaleHandle = Selector.GetHandle("xScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYScale = "yScale";

	private static readonly IntPtr selYScaleHandle = Selector.GetHandle("yScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZPosition = "zPosition";

	private static readonly IntPtr selZPositionHandle = Selector.GetHandle("zPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZRotation = "zRotation";

	private static readonly IntPtr selZRotationHandle = Selector.GetHandle("zRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDictionary<NSString, SKAttributeValue> AttributeValues
	{
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
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
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
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
	public virtual SKNode[] Children
	{
		[Export("children")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildrenHandle));
			}
			return NSArray.ArrayFromHandle<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildrenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKConstraint[]? Constraints
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("constraints", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsHandle));
			}
			return NSArray.ArrayFromHandle<SKConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setConstraints:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConstraints_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConstraints_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasActions
	{
		[Export("hasActions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasActionsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasActionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode Parent
	{
		[Export("parent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle));
			}
			return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle));
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
	public virtual SKPhysicsBody? PhysicsBody
	{
		[Export("physicsBody", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhysicsBodyHandle));
			}
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhysicsBodyHandle));
		}
		[Export("setPhysicsBody:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhysicsBody_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhysicsBody_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint Position
	{
		[Export("position")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPositionHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPositionHandle);
		}
		[Export("setPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKReachConstraints? ReachConstraints
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("reachConstraints", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKReachConstraints>(Messaging.IntPtr_objc_msgSend(base.Handle, selReachConstraintsHandle));
			}
			return Runtime.GetNSObject<SKReachConstraints>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReachConstraintsHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setReachConstraints:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReachConstraints_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReachConstraints_Handle, value?.Handle ?? IntPtr.Zero);
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
	public virtual NSMutableDictionary? UserData
	{
		[Export("userData", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle));
		}
		[Export("setUserData:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UserInteractionEnabled
	{
		[Export("isUserInteractionEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUserInteractionEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUserInteractionEnabledHandle);
		}
		[Export("setUserInteractionEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUserInteractionEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUserInteractionEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat XScale
	{
		[Export("xScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selXScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selXScaleHandle);
		}
		[Export("setXScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetXScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetXScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat YScale
	{
		[Export("yScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selYScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selYScaleHandle);
		}
		[Export("setYScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetYScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetYScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ZPosition
	{
		[Export("zPosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZPositionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZPositionHandle);
		}
		[Export("setZPosition:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetZPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetZPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ZRotation
	{
		[Export("zRotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZRotationHandle);
		}
		[Export("setZRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetZRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetZRotation_Handle, value);
			}
		}
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static T FromFile<T>(string file) where T : SKNode
	{
		IntPtr ptr;
		using (NSString nSString = new NSString(file))
		{
			ptr = Messaging.IntPtr_objc_msgSend_IntPtr(ObjCRuntime.Class.GetHandle(typeof(T)), Selector.GetHandle("nodeWithFileNamed:"), nSString.Handle);
		}
		return Runtime.GetNSObject<T>(ptr);
	}

	public void Add(SKNode node)
	{
		AddChild(node);
	}

	public void AddNodes(params SKNode[] nodes)
	{
		if (nodes != null)
		{
			foreach (SKNode node in nodes)
			{
				AddChild(node);
			}
		}
	}

	public IEnumerator<SKNode> GetEnumerator()
	{
		SKNode[] children = Children;
		for (int i = 0; i < children.Length; i++)
		{
			yield return children[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[Watch(5, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public static SKNode Create(string filename, Type[] types, out NSError error)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (types == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (types.Length == 0)
		{
			throw new InvalidOperationException("'filename' length must be greater than zero.");
		}
		using NSMutableSet<Class> nSMutableSet = new NSMutableSet<Class>(types.Length);
		foreach (Type type in types)
		{
			nSMutableSet.Add(new Class(type));
		}
		return Create(filename, nSMutableSet.Handle, out error);
	}

	[Watch(5, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	[iOS(12, 0)]
	public static SKNode Create(string filename, NSSet<Class> classes, out NSError error)
	{
		return Create(filename, classes.Handle, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKNode(NSCoder coder)
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
	protected SKNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKNode()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("addChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChild(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChild_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChild_Handle, node.Handle);
		}
	}

	[Export("calculateAccumulatedFrame")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CalculateAccumulatedFrame()
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selCalculateAccumulatedFrameHandle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCalculateAccumulatedFrameHandle);
		}
		return retval;
	}

	[Export("containsPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
	}

	[Export("convertPoint:fromNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointFromNode(CGPoint point, SKNode sourceNode)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_FromNode_Handle, point, sourceNode.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_FromNode_Handle, point, sourceNode.Handle);
	}

	[Export("convertPoint:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ConvertPointToNode(CGPoint point, SKNode sourceNode)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_IntPtr(base.Handle, selConvertPoint_ToNode_Handle, point, sourceNode.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selConvertPoint_ToNode_Handle, point, sourceNode.Handle);
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

	[Export("node")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKNode Create()
	{
		return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(class_ptr, selNodeHandle));
	}

	[Export("nodeWithFileNamed:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKNode? Create(string filename)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		SKNode nSObject = Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("nodeWithFileNamed:securelyWithClasses:andError:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKNode? Create(string filename, IntPtr classesPtr, out NSError error)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(filename);
		SKNode nSObject = Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selNodeWithFileNamed_SecurelyWithClasses_AndError_Handle, arg2, classesPtr, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
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

	[Export("enumerateChildNodesWithName:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateChildNodes(string name, [BlockProxy(typeof(Trampolines.NIDSKNodeChildEnumeratorHandler))] SKNodeChildEnumeratorHandler enumerationHandler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (enumerationHandler == null)
		{
			throw new ArgumentNullException("enumerationHandler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKNodeChildEnumeratorHandler.Handler, enumerationHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnumerateChildNodesWithName_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnumerateChildNodesWithName_UsingBlock_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("actionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKAction GetActionForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		SKAction result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selActionForKey_Handle, arg)) : Runtime.GetNSObject<SKAction>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selActionForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("childNodeWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode GetChildNode(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChildNodeWithName_Handle, arg)) : Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChildNodeWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("nodeAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode GetNodeAtPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selNodeAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selNodeAtPoint_Handle, point));
	}

	[Export("nodesAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode[] GetNodesAtPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SKNode>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selNodesAtPoint_Handle, point));
		}
		return NSArray.ArrayFromHandle<SKNode>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selNodesAtPoint_Handle, point));
	}

	[Export("objectForKeyedSubscript:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode GetObjectsMatching(string nameExpression)
	{
		if (nameExpression == null)
		{
			throw new ArgumentNullException("nameExpression");
		}
		IntPtr arg = NSString.CreateNative(nameExpression);
		SKNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, arg)) : Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("obstaclesFromNodeBounds:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] GetObstaclesFromNodeBounds(SKNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selObstaclesFromNodeBounds_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("obstaclesFromNodePhysicsBodies:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] GetObstaclesFromNodePhysicsBodies(SKNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selObstaclesFromNodePhysicsBodies_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("obstaclesFromSpriteTextures:accuracy:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] GetObstaclesFromSpriteTextures(SKNode[] sprites, float accuracy)
	{
		if (sprites == null)
		{
			throw new ArgumentNullException("sprites");
		}
		NSArray nSArray = NSArray.FromNSObjects(sprites);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selObstaclesFromSpriteTextures_Accuracy_Handle, nSArray.Handle, accuracy));
		nSArray.Dispose();
		return result;
	}

	[Export("valueForAttributeNamed:")]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKAttributeValue? GetValue(string key)
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

	[Export("inParentHierarchy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InParentHierarchy(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selInParentHierarchy_Handle, node.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selInParentHierarchy_Handle, node.Handle);
	}

	[Export("insertChild:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertChild(SKNode node, nint index)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertChild_AtIndex_Handle, node.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertChild_AtIndex_Handle, node.Handle, index);
		}
	}

	[Export("intersectsNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IntersectsNode(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsNode_Handle, node.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsNode_Handle, node.Handle);
	}

	[Export("isEqualToNode:")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqual(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToNode_Handle, node.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToNode_Handle, node.Handle);
	}

	[Export("moveToParent:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveToParent(SKNode parent)
	{
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveToParent_Handle, parent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveToParent_Handle, parent.Handle);
		}
	}

	[Export("obstaclesFromNodeBounds:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] ObstaclesFromNodeBounds(SKNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selObstaclesFromNodeBounds_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("obstaclesFromNodePhysicsBodies:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] ObstaclesFromNodePhysicsBodies(SKNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selObstaclesFromNodePhysicsBodies_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("obstaclesFromSpriteTextures:accuracy:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPolygonObstacle[] ObstaclesFromSpriteTextures(SKNode[] sprites, float accuracy)
	{
		if (sprites == null)
		{
			throw new ArgumentNullException("sprites");
		}
		NSArray nSArray = NSArray.FromNSObjects(sprites);
		GKPolygonObstacle[] result = NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selObstaclesFromSpriteTextures_Accuracy_Handle, nSArray.Handle, accuracy));
		nSArray.Dispose();
		return result;
	}

	[Export("removeActionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveActionForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveActionForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveActionForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeAllActions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllActions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllActionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllActionsHandle);
		}
	}

	[Export("removeAllChildren")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllChildren()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllChildrenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllChildrenHandle);
		}
	}

	[Export("removeChildrenInArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveChildren(SKNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveChildrenInArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChildrenInArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeFromParent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFromParent()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromParentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromParentHandle);
		}
	}

	[Export("runAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunAction(SKAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunAction_Handle, action.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunAction_Handle, action.Handle);
		}
	}

	[Export("runAction:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RunAction(SKAction action, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunAction_Completion_Handle, action.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunAction_Completion_Handle, action.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RunActionAsync(SKAction action)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RunAction(action, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("runAction:withKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunAction(SKAction action, string key)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunAction_WithKey_Handle, action.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunAction_WithKey_Handle, action.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetScale(nfloat scale)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selSetScale_Handle, scale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetScale_Handle, scale);
		}
	}

	[Export("setValue:forAttributeNamed:")]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Attributes are only available for node classes supporting SKShader (see SKSpriteNode etc.).")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(SKAttributeValue value, string key)
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
}
