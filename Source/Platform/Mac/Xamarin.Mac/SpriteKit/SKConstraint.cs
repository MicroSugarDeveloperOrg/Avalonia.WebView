using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKConstraint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SKConstraint : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistance_ToNode_ = "distance:toNode:";

	private static readonly IntPtr selDistance_ToNode_Handle = Selector.GetHandle("distance:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistance_ToPoint_ = "distance:toPoint:";

	private static readonly IntPtr selDistance_ToPoint_Handle = Selector.GetHandle("distance:toPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistance_ToPoint_InNode_ = "distance:toPoint:inNode:";

	private static readonly IntPtr selDistance_ToPoint_InNode_Handle = Selector.GetHandle("distance:toPoint:inNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnabled = "enabled";

	private static readonly IntPtr selEnabledHandle = Selector.GetHandle("enabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientToNode_Offset_ = "orientToNode:offset:";

	private static readonly IntPtr selOrientToNode_Offset_Handle = Selector.GetHandle("orientToNode:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientToPoint_InNode_Offset_ = "orientToPoint:inNode:offset:";

	private static readonly IntPtr selOrientToPoint_InNode_Offset_Handle = Selector.GetHandle("orientToPoint:inNode:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientToPoint_Offset_ = "orientToPoint:offset:";

	private static readonly IntPtr selOrientToPoint_Offset_Handle = Selector.GetHandle("orientToPoint:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositionX_ = "positionX:";

	private static readonly IntPtr selPositionX_Handle = Selector.GetHandle("positionX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositionX_Y_ = "positionX:Y:";

	private static readonly IntPtr selPositionX_Y_Handle = Selector.GetHandle("positionX:Y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositionY_ = "positionY:";

	private static readonly IntPtr selPositionY_Handle = Selector.GetHandle("positionY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceNode = "referenceNode";

	private static readonly IntPtr selReferenceNodeHandle = Selector.GetHandle("referenceNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReferenceNode_ = "setReferenceNode:";

	private static readonly IntPtr selSetReferenceNode_Handle = Selector.GetHandle("setReferenceNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZRotation_ = "zRotation:";

	private static readonly IntPtr selZRotation_Handle = Selector.GetHandle("zRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKConstraint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("enabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode? ReferenceNode
	{
		[Export("referenceNode", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceNodeHandle));
			}
			return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceNodeHandle));
		}
		[Export("setReferenceNode:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReferenceNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReferenceNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKConstraint()
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
	public SKConstraint(NSCoder coder)
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
	protected SKConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKConstraint(IntPtr handle)
		: base(handle)
	{
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

	[Export("distance:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateDistance(SKRange range, SKNode node)
	{
		if (range == null)
		{
			throw new ArgumentNullException("range");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDistance_ToNode_Handle, range.Handle, node.Handle));
	}

	[Export("distance:toPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateDistance(SKRange range, CGPoint point)
	{
		if (range == null)
		{
			throw new ArgumentNullException("range");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint(class_ptr, selDistance_ToPoint_Handle, range.Handle, point));
	}

	[Export("distance:toPoint:inNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateDistance(SKRange range, CGPoint point, SKNode node)
	{
		if (range == null)
		{
			throw new ArgumentNullException("range");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr(class_ptr, selDistance_ToPoint_InNode_Handle, range.Handle, point, node.Handle));
	}

	[Export("orientToNode:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateOrientToNode(SKNode node, SKRange radians)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (radians == null)
		{
			throw new ArgumentNullException("radians");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selOrientToNode_Offset_Handle, node.Handle, radians.Handle));
	}

	[Export("orientToPoint:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateOrientToPoint(CGPoint point, SKRange radians)
	{
		if (radians == null)
		{
			throw new ArgumentNullException("radians");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr(class_ptr, selOrientToPoint_Offset_Handle, point, radians.Handle));
	}

	[Export("orientToPoint:inNode:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateOrientToPoint(CGPoint point, SKNode node, SKRange radians)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (radians == null)
		{
			throw new ArgumentNullException("radians");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_CGPoint_IntPtr_IntPtr(class_ptr, selOrientToPoint_InNode_Offset_Handle, point, node.Handle, radians.Handle));
	}

	[Export("positionX:Y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateRestriction(SKRange xRange, SKRange yRange)
	{
		if (xRange == null)
		{
			throw new ArgumentNullException("xRange");
		}
		if (yRange == null)
		{
			throw new ArgumentNullException("yRange");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPositionX_Y_Handle, xRange.Handle, yRange.Handle));
	}

	[Export("positionX:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateXRestriction(SKRange range)
	{
		if (range == null)
		{
			throw new ArgumentNullException("range");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPositionX_Handle, range.Handle));
	}

	[Export("positionY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateYRestriction(SKRange range)
	{
		if (range == null)
		{
			throw new ArgumentNullException("range");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPositionY_Handle, range.Handle));
	}

	[Export("zRotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKConstraint CreateZRotation(SKRange zRange)
	{
		if (zRange == null)
		{
			throw new ArgumentNullException("zRange");
		}
		return Runtime.GetNSObject<SKConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selZRotation_Handle, zRange.Handle));
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
}
