using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLMaterialPropertyGraph", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class MDLMaterialPropertyGraph : MDLMaterialPropertyNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnections = "connections";

	private static readonly IntPtr selConnectionsHandle = Selector.GetHandle("connections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluate = "evaluate";

	private static readonly IntPtr selEvaluateHandle = Selector.GetHandle("evaluate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNodes_Connections_ = "initWithNodes:connections:";

	private static readonly IntPtr selInitWithNodes_Connections_Handle = Selector.GetHandle("initWithNodes:connections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodes = "nodes";

	private static readonly IntPtr selNodesHandle = Selector.GetHandle("nodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMaterialPropertyGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialPropertyConnection[] Connections
	{
		[Export("connections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MDLMaterialPropertyConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionsHandle));
			}
			return NSArray.ArrayFromHandle<MDLMaterialPropertyConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialPropertyNode[] Nodes
	{
		[Export("nodes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MDLMaterialPropertyNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodesHandle));
			}
			return NSArray.ArrayFromHandle<MDLMaterialPropertyNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLMaterialPropertyGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMaterialPropertyGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNodes:connections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialPropertyGraph(MDLMaterialPropertyNode[] nodes, MDLMaterialPropertyConnection[] connections)
		: base(NSObjectFlag.Empty)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		NSArray nSArray2 = NSArray.FromNSObjects(connections);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNodes_Connections_Handle, nSArray.Handle, nSArray2.Handle), "initWithNodes:connections:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNodes_Connections_Handle, nSArray.Handle, nSArray2.Handle), "initWithNodes:connections:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("evaluate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Evaluate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEvaluateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEvaluateHandle);
		}
	}
}
