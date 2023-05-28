using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioConnectionPoint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVAudioConnectionPoint : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBus = "bus";

	private static readonly IntPtr selBusHandle = Selector.GetHandle("bus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNode_Bus_ = "initWithNode:bus:";

	private static readonly IntPtr selInitWithNode_Bus_Handle = Selector.GetHandle("initWithNode:bus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNode = "node";

	private static readonly IntPtr selNodeHandle = Selector.GetHandle("node");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioConnectionPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Node_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Bus
	{
		[Export("bus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBusHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioNode? Node
	{
		[Export("node", ArgumentSemantic.Weak)]
		get
		{
			AVAudioNode aVAudioNode = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVAudioNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeHandle)) : Runtime.GetNSObject<AVAudioNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeHandle)));
			MarkDirty();
			__mt_Node_var = aVAudioNode;
			return aVAudioNode;
		}
	}

	[Obsolete("Valid instance of this type cannot be directly created.")]
	public AVAudioConnectionPoint()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioConnectionPoint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioConnectionPoint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNode:bus:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioConnectionPoint(AVAudioNode node, nuint bus)
		: base(NSObjectFlag.Empty)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithNode_Bus_Handle, node.Handle, bus), "initWithNode:bus:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithNode_Bus_Handle, node.Handle, bus), "initWithNode:bus:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Node_var = null;
		}
	}
}
