using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using SpriteKit;

namespace GameplayKit;

[Register("GKSKNodeComponent", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKSKNodeComponent : GKComponent, IGKAgentDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAgentDidUpdate_ = "agentDidUpdate:";

	private static readonly IntPtr selAgentDidUpdate_Handle = Selector.GetHandle("agentDidUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAgentWillUpdate_ = "agentWillUpdate:";

	private static readonly IntPtr selAgentWillUpdate_Handle = Selector.GetHandle("agentWillUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentWithNode_ = "componentWithNode:";

	private static readonly IntPtr selComponentWithNode_Handle = Selector.GetHandle("componentWithNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNode_ = "initWithNode:";

	private static readonly IntPtr selInitWithNode_Handle = Selector.GetHandle("initWithNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNode = "node";

	private static readonly IntPtr selNodeHandle = Selector.GetHandle("node");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNode_ = "setNode:";

	private static readonly IntPtr selSetNode_Handle = Selector.GetHandle("setNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKSKNodeComponent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKNode Node
	{
		[Export("node", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeHandle));
			}
			return Runtime.GetNSObject<SKNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeHandle));
		}
		[Export("setNode:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNode_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKSKNodeComponent()
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
	public GKSKNodeComponent(NSCoder coder)
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
	protected GKSKNodeComponent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKSKNodeComponent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKSKNodeComponent(SKNode node)
		: base(NSObjectFlag.Empty)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNode_Handle, node.Handle), "initWithNode:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNode_Handle, node.Handle), "initWithNode:");
		}
	}

	[Export("agentDidUpdate:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AgentDidUpdate(GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAgentDidUpdate_Handle, agent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAgentDidUpdate_Handle, agent.Handle);
		}
	}

	[Export("agentWillUpdate:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AgentWillUpdate(GKAgent agent)
	{
		if (agent == null)
		{
			throw new ArgumentNullException("agent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAgentWillUpdate_Handle, agent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAgentWillUpdate_Handle, agent.Handle);
		}
	}

	[Export("componentWithNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKSKNodeComponent FromNode(SKNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<GKSKNodeComponent>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selComponentWithNode_Handle, node.Handle));
	}
}
