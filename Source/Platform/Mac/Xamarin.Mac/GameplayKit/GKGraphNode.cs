using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKGraphNode", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGraphNode : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddConnectionsToNodes_Bidirectional_ = "addConnectionsToNodes:bidirectional:";

	private static readonly IntPtr selAddConnectionsToNodes_Bidirectional_Handle = Selector.GetHandle("addConnectionsToNodes:bidirectional:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectedNodes = "connectedNodes";

	private static readonly IntPtr selConnectedNodesHandle = Selector.GetHandle("connectedNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCostToNode_ = "costToNode:";

	private static readonly IntPtr selCostToNode_Handle = Selector.GetHandle("costToNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedCostToNode_ = "estimatedCostToNode:";

	private static readonly IntPtr selEstimatedCostToNode_Handle = Selector.GetHandle("estimatedCostToNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindPathFromNode_ = "findPathFromNode:";

	private static readonly IntPtr selFindPathFromNode_Handle = Selector.GetHandle("findPathFromNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindPathToNode_ = "findPathToNode:";

	private static readonly IntPtr selFindPathToNode_Handle = Selector.GetHandle("findPathToNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveConnectionsToNodes_Bidirectional_ = "removeConnectionsToNodes:bidirectional:";

	private static readonly IntPtr selRemoveConnectionsToNodes_Bidirectional_Handle = Selector.GetHandle("removeConnectionsToNodes:bidirectional:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGraphNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKGraphNode[] ConnectedNodes
	{
		[Export("connectedNodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectedNodesHandle));
			}
			return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectedNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGraphNode()
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
	public GKGraphNode(NSCoder coder)
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
	protected GKGraphNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGraphNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addConnectionsToNodes:bidirectional:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddConnections(GKGraphNode[] nodes, bool bidirectional)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selAddConnectionsToNodes_Bidirectional_Handle, nSArray.Handle, bidirectional);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selAddConnectionsToNodes_Bidirectional_Handle, nSArray.Handle, bidirectional);
		}
		nSArray.Dispose();
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

	[Export("findPathFromNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKGraphNode[] FindPathFrom(GKGraphNode startNode)
	{
		if (startNode == null)
		{
			throw new ArgumentNullException("startNode");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFindPathFromNode_Handle, startNode.Handle));
		}
		return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFindPathFromNode_Handle, startNode.Handle));
	}

	[Export("findPathToNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKGraphNode[] FindPathTo(GKGraphNode goalNode)
	{
		if (goalNode == null)
		{
			throw new ArgumentNullException("goalNode");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFindPathToNode_Handle, goalNode.Handle));
		}
		return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFindPathToNode_Handle, goalNode.Handle));
	}

	[Export("costToNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetCost(GKGraphNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selCostToNode_Handle, node.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selCostToNode_Handle, node.Handle);
	}

	[Export("estimatedCostToNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetEstimatedCost(GKGraphNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selEstimatedCostToNode_Handle, node.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selEstimatedCostToNode_Handle, node.Handle);
	}

	[Export("removeConnectionsToNodes:bidirectional:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveConnections(GKGraphNode[] nodes, bool bidirectional)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selRemoveConnectionsToNodes_Bidirectional_Handle, nSArray.Handle, bidirectional);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selRemoveConnectionsToNodes_Bidirectional_Handle, nSArray.Handle, bidirectional);
		}
		nSArray.Dispose();
	}
}
