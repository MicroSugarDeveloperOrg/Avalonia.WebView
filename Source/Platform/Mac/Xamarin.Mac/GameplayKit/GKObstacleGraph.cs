using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKObstacleGraph", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKObstacleGraph : GKGraph
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObstacles_ = "addObstacles:";

	private static readonly IntPtr selAddObstacles_Handle = Selector.GetHandle("addObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferRadius = "bufferRadius";

	private static readonly IntPtr selBufferRadiusHandle = Selector.GetHandle("bufferRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForGenericArgumentAtIndex_ = "classForGenericArgumentAtIndex:";

	private static readonly IntPtr selClassForGenericArgumentAtIndex_Handle = Selector.GetHandle("classForGenericArgumentAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeUsingObstacles_ = "connectNodeUsingObstacles:";

	private static readonly IntPtr selConnectNodeUsingObstacles_Handle = Selector.GetHandle("connectNodeUsingObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_ = "connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:";

	private static readonly IntPtr selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_Handle = Selector.GetHandle("connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeUsingObstacles_IgnoringObstacles_ = "connectNodeUsingObstacles:ignoringObstacles:";

	private static readonly IntPtr selConnectNodeUsingObstacles_IgnoringObstacles_Handle = Selector.GetHandle("connectNodeUsingObstacles:ignoringObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithObstacles_BufferRadius_ = "graphWithObstacles:bufferRadius:";

	private static readonly IntPtr selGraphWithObstacles_BufferRadius_Handle = Selector.GetHandle("graphWithObstacles:bufferRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithObstacles_BufferRadius_NodeClass_ = "graphWithObstacles:bufferRadius:nodeClass:";

	private static readonly IntPtr selGraphWithObstacles_BufferRadius_NodeClass_Handle = Selector.GetHandle("graphWithObstacles:bufferRadius:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObstacles_BufferRadius_ = "initWithObstacles:bufferRadius:";

	private static readonly IntPtr selInitWithObstacles_BufferRadius_Handle = Selector.GetHandle("initWithObstacles:bufferRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObstacles_BufferRadius_NodeClass_ = "initWithObstacles:bufferRadius:nodeClass:";

	private static readonly IntPtr selInitWithObstacles_BufferRadius_NodeClass_Handle = Selector.GetHandle("initWithObstacles:bufferRadius:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConnectionLockedFromNode_ToNode_ = "isConnectionLockedFromNode:toNode:";

	private static readonly IntPtr selIsConnectionLockedFromNode_ToNode_Handle = Selector.GetHandle("isConnectionLockedFromNode:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockConnectionFromNode_ToNode_ = "lockConnectionFromNode:toNode:";

	private static readonly IntPtr selLockConnectionFromNode_ToNode_Handle = Selector.GetHandle("lockConnectionFromNode:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodesForObstacle_ = "nodesForObstacle:";

	private static readonly IntPtr selNodesForObstacle_Handle = Selector.GetHandle("nodesForObstacle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstacles = "obstacles";

	private static readonly IntPtr selObstaclesHandle = Selector.GetHandle("obstacles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllObstacles = "removeAllObstacles";

	private static readonly IntPtr selRemoveAllObstaclesHandle = Selector.GetHandle("removeAllObstacles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObstacles_ = "removeObstacles:";

	private static readonly IntPtr selRemoveObstacles_Handle = Selector.GetHandle("removeObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockConnectionFromNode_ToNode_ = "unlockConnectionFromNode:toNode:";

	private static readonly IntPtr selUnlockConnectionFromNode_ToNode_Handle = Selector.GetHandle("unlockConnectionFromNode:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKObstacleGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float BufferRadius
	{
		[Export("bufferRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBufferRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBufferRadiusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKPolygonObstacle[] Obstacles
	{
		[Export("obstacles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend(base.Handle, selObstaclesHandle));
			}
			return NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObstaclesHandle));
		}
	}

	public virtual GKGraphNode2D[] GetNodes(GKPolygonObstacle obstacle)
	{
		return NSArray.ArrayFromHandle<GKGraphNode2D>(_GetNodes(obstacle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKObstacleGraph()
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
	public GKObstacleGraph(NSCoder coder)
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
	protected GKObstacleGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKObstacleGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithObstacles:bufferRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKObstacleGraph(GKPolygonObstacle[] obstacles, float bufferRadius)
		: base(NSObjectFlag.Empty)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithObstacles_BufferRadius_Handle, nSArray.Handle, bufferRadius), "initWithObstacles:bufferRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithObstacles_BufferRadius_Handle, nSArray.Handle, bufferRadius), "initWithObstacles:bufferRadius:");
		}
		nSArray.Dispose();
	}

	[Export("initWithObstacles:bufferRadius:nodeClass:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal GKObstacleGraph(GKPolygonObstacle[] obstacles, float bufferRadius, Class nodeClass)
		: base(NSObjectFlag.Empty)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		if (nodeClass == null)
		{
			throw new ArgumentNullException("nodeClass");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_IntPtr(base.Handle, selInitWithObstacles_BufferRadius_NodeClass_Handle, nSArray.Handle, bufferRadius, nodeClass.Handle), "initWithObstacles:bufferRadius:nodeClass:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_IntPtr(base.SuperHandle, selInitWithObstacles_BufferRadius_NodeClass_Handle, nSArray.Handle, bufferRadius, nodeClass.Handle), "initWithObstacles:bufferRadius:nodeClass:");
		}
		nSArray.Dispose();
	}

	[Export("addObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObstacles(GKPolygonObstacle[] obstacles)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObstacles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObstacles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("connectNodeUsingObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeUsingObstacles(GKGraphNode2D node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConnectNodeUsingObstacles_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConnectNodeUsingObstacles_Handle, node.Handle);
		}
	}

	[Export("connectNodeUsingObstacles:ignoringObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeUsingObstacles(GKGraphNode2D node, GKPolygonObstacle[] obstaclesToIgnore)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (obstaclesToIgnore == null)
		{
			throw new ArgumentNullException("obstaclesToIgnore");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstaclesToIgnore);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selConnectNodeUsingObstacles_IgnoringObstacles_Handle, node.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConnectNodeUsingObstacles_IgnoringObstacles_Handle, node.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("connectNodeUsingObstacles:ignoringBufferRadiusOfObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeUsingObstaclesIgnoringBufferRadius(GKGraphNode2D node, GKPolygonObstacle[] obstaclesBufferRadiusToIgnore)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (obstaclesBufferRadiusToIgnore == null)
		{
			throw new ArgumentNullException("obstaclesBufferRadiusToIgnore");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstaclesBufferRadiusToIgnore);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_Handle, node.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConnectNodeUsingObstacles_IgnoringBufferRadiusOfObstacles_Handle, node.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("graphWithObstacles:bufferRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKObstacleGraph FromObstacles(GKPolygonObstacle[] obstacles, float bufferRadius)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		GKObstacleGraph nSObject = Runtime.GetNSObject<GKObstacleGraph>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selGraphWithObstacles_BufferRadius_Handle, nSArray.Handle, bufferRadius));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("classForGenericArgumentAtIndex:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class GetClassForGenericArgument(nuint index)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selClassForGenericArgumentAtIndex_Handle, index) : Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selClassForGenericArgumentAtIndex_Handle, index));
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type GetTypeForGenericArgument(nuint index)
	{
		return ObjCRuntime.Class.Lookup(GetClassForGenericArgument(index));
	}

	[Export("graphWithObstacles:bufferRadius:nodeClass:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr GraphWithObstacles(GKPolygonObstacle[] obstacles, float bufferRadius, Class nodeClass)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		if (nodeClass == null)
		{
			throw new ArgumentNullException("nodeClass");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_float_IntPtr(class_ptr, selGraphWithObstacles_BufferRadius_NodeClass_Handle, nSArray.Handle, bufferRadius, nodeClass.Handle);
		nSArray.Dispose();
		return result;
	}

	[Export("isConnectionLockedFromNode:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsConnectionLocked(GKGraphNode2D startNode, GKGraphNode2D endNode)
	{
		if (startNode == null)
		{
			throw new ArgumentNullException("startNode");
		}
		if (endNode == null)
		{
			throw new ArgumentNullException("endNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsConnectionLockedFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsConnectionLockedFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
	}

	[Export("lockConnectionFromNode:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockConnection(GKGraphNode2D startNode, GKGraphNode2D endNode)
	{
		if (startNode == null)
		{
			throw new ArgumentNullException("startNode");
		}
		if (endNode == null)
		{
			throw new ArgumentNullException("endNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLockConnectionFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLockConnectionFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
		}
	}

	[Export("removeAllObstacles")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllObstacles()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllObstaclesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllObstaclesHandle);
		}
	}

	[Export("removeObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObstacles(GKPolygonObstacle[] obstacles)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObstacles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObstacles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("unlockConnectionFromNode:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockConnection(GKGraphNode2D startNode, GKGraphNode2D endNode)
	{
		if (startNode == null)
		{
			throw new ArgumentNullException("startNode");
		}
		if (endNode == null)
		{
			throw new ArgumentNullException("endNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUnlockConnectionFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUnlockConnectionFromNode_ToNode_Handle, startNode.Handle, endNode.Handle);
		}
	}

	[Export("nodesForObstacle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetNodes(GKPolygonObstacle obstacle)
	{
		if (obstacle == null)
		{
			throw new ArgumentNullException("obstacle");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNodesForObstacle_Handle, obstacle.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNodesForObstacle_Handle, obstacle.Handle);
	}
}
[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 12)]
[Register("GKObstacleGraph", SkipRegistration = true)]
public class GKObstacleGraph<NodeType> : GKObstacleGraph where NodeType : GKGraphNode2D
{
	[Preserve(Conditional = true)]
	internal GKObstacleGraph(IntPtr handle)
		: base(handle)
	{
	}

	public GKObstacleGraph(NSCoder coder)
		: base(coder)
	{
	}

	public GKObstacleGraph(GKPolygonObstacle[] obstacles, float bufferRadius)
		: base(obstacles, bufferRadius, new Class(typeof(NodeType)))
	{
	}

	public new static GKObstacleGraph<NodeType> FromObstacles(GKPolygonObstacle[] obstacles, float bufferRadius)
	{
		return Runtime.GetNSObject<GKObstacleGraph<NodeType>>(GKObstacleGraph.GraphWithObstacles(obstacles, bufferRadius, new Class(typeof(NodeType))));
	}

	public new NodeType[] GetNodes(GKPolygonObstacle obstacle)
	{
		return NSArray.ArrayFromHandle<NodeType>(_GetNodes(obstacle));
	}
}
