using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKGridGraphNode", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGridGraphNode : GKGraphNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridPosition = "gridPosition";

	private static readonly IntPtr selGridPositionHandle = Selector.GetHandle("gridPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGridPosition_ = "initWithGridPosition:";

	private static readonly IntPtr selInitWithGridPosition_Handle = Selector.GetHandle("initWithGridPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithGridPosition_ = "nodeWithGridPosition:";

	private static readonly IntPtr selNodeWithGridPosition_Handle = Selector.GetHandle("nodeWithGridPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGridGraphNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2i GridPosition
	{
		[Export("gridPosition", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2i_objc_msgSend(base.Handle, selGridPositionHandle);
			}
			return Messaging.xamarin_simd__Vector2i_objc_msgSendSuper(base.SuperHandle, selGridPositionHandle);
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKGridGraphNode(NSCoder coder)
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
	protected GKGridGraphNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGridGraphNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithGridPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGridGraphNode(Vector2i gridPosition)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i(base.Handle, selInitWithGridPosition_Handle, gridPosition), "initWithGridPosition:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i(base.SuperHandle, selInitWithGridPosition_Handle, gridPosition), "initWithGridPosition:");
		}
	}

	[Export("nodeWithGridPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGridGraphNode FromGridPosition(Vector2i gridPosition)
	{
		return Runtime.GetNSObject<GKGridGraphNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i(class_ptr, selNodeWithGridPosition_Handle, gridPosition));
	}
}
