using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKGraph", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGraph : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddNodes_ = "addNodes:";

	private static readonly IntPtr selAddNodes_Handle = Selector.GetHandle("addNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeToLowestCostNode_Bidirectional_ = "connectNodeToLowestCostNode:bidirectional:";

	private static readonly IntPtr selConnectNodeToLowestCostNode_Bidirectional_Handle = Selector.GetHandle("connectNodeToLowestCostNode:bidirectional:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindPathFromNode_ToNode_ = "findPathFromNode:toNode:";

	private static readonly IntPtr selFindPathFromNode_ToNode_Handle = Selector.GetHandle("findPathFromNode:toNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithNodes_ = "graphWithNodes:";

	private static readonly IntPtr selGraphWithNodes_Handle = Selector.GetHandle("graphWithNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNodes_ = "initWithNodes:";

	private static readonly IntPtr selInitWithNodes_Handle = Selector.GetHandle("initWithNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodes = "nodes";

	private static readonly IntPtr selNodesHandle = Selector.GetHandle("nodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveNodes_ = "removeNodes:";

	private static readonly IntPtr selRemoveNodes_Handle = Selector.GetHandle("removeNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKGraphNode[]? Nodes
	{
		[Export("nodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodesHandle));
			}
			return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGraph()
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
	public GKGraph(NSCoder coder)
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
	protected GKGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGraph(GKGraphNode[] nodes)
		: base(NSObjectFlag.Empty)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNodes_Handle, nSArray.Handle), "initWithNodes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNodes_Handle, nSArray.Handle), "initWithNodes:");
		}
		nSArray.Dispose();
	}

	[Export("addNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddNodes(GKGraphNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddNodes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddNodes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("connectNodeToLowestCostNode:bidirectional:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeToLowestCostNode(GKGraphNode node, bool bidirectional)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selConnectNodeToLowestCostNode_Bidirectional_Handle, node.Handle, bidirectional);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selConnectNodeToLowestCostNode_Bidirectional_Handle, node.Handle, bidirectional);
		}
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

	[Export("findPathFromNode:toNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKGraphNode[] FindPath(GKGraphNode startNode, GKGraphNode endNode)
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
			return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindPathFromNode_ToNode_Handle, startNode.Handle, endNode.Handle));
		}
		return NSArray.ArrayFromHandle<GKGraphNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindPathFromNode_ToNode_Handle, startNode.Handle, endNode.Handle));
	}

	[Export("graphWithNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGraph FromNodes(GKGraphNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKGraph nSObject = Runtime.GetNSObject<GKGraph>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGraphWithNodes_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("removeNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveNodes(GKGraphNode[] nodes)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveNodes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveNodes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
