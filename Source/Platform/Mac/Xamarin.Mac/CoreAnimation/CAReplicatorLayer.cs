using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAReplicatorLayer", true)]
public class CAReplicatorLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceAlphaOffset = "instanceAlphaOffset";

	private static readonly IntPtr selInstanceAlphaOffsetHandle = Selector.GetHandle("instanceAlphaOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceBlueOffset = "instanceBlueOffset";

	private static readonly IntPtr selInstanceBlueOffsetHandle = Selector.GetHandle("instanceBlueOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceColor = "instanceColor";

	private static readonly IntPtr selInstanceColorHandle = Selector.GetHandle("instanceColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceCount = "instanceCount";

	private static readonly IntPtr selInstanceCountHandle = Selector.GetHandle("instanceCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceDelay = "instanceDelay";

	private static readonly IntPtr selInstanceDelayHandle = Selector.GetHandle("instanceDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceGreenOffset = "instanceGreenOffset";

	private static readonly IntPtr selInstanceGreenOffsetHandle = Selector.GetHandle("instanceGreenOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceRedOffset = "instanceRedOffset";

	private static readonly IntPtr selInstanceRedOffsetHandle = Selector.GetHandle("instanceRedOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstanceTransform = "instanceTransform";

	private static readonly IntPtr selInstanceTransformHandle = Selector.GetHandle("instanceTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesDepth = "preservesDepth";

	private static readonly IntPtr selPreservesDepthHandle = Selector.GetHandle("preservesDepth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceAlphaOffset_ = "setInstanceAlphaOffset:";

	private static readonly IntPtr selSetInstanceAlphaOffset_Handle = Selector.GetHandle("setInstanceAlphaOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceBlueOffset_ = "setInstanceBlueOffset:";

	private static readonly IntPtr selSetInstanceBlueOffset_Handle = Selector.GetHandle("setInstanceBlueOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceColor_ = "setInstanceColor:";

	private static readonly IntPtr selSetInstanceColor_Handle = Selector.GetHandle("setInstanceColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceCount_ = "setInstanceCount:";

	private static readonly IntPtr selSetInstanceCount_Handle = Selector.GetHandle("setInstanceCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceDelay_ = "setInstanceDelay:";

	private static readonly IntPtr selSetInstanceDelay_Handle = Selector.GetHandle("setInstanceDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceGreenOffset_ = "setInstanceGreenOffset:";

	private static readonly IntPtr selSetInstanceGreenOffset_Handle = Selector.GetHandle("setInstanceGreenOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceRedOffset_ = "setInstanceRedOffset:";

	private static readonly IntPtr selSetInstanceRedOffset_Handle = Selector.GetHandle("setInstanceRedOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstanceTransform_ = "setInstanceTransform:";

	private static readonly IntPtr selSetInstanceTransform_Handle = Selector.GetHandle("setInstanceTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesDepth_ = "setPreservesDepth:";

	private static readonly IntPtr selSetPreservesDepth_Handle = Selector.GetHandle("setPreservesDepth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAReplicatorLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InstanceAlphaOffset
	{
		[Export("instanceAlphaOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceAlphaOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceAlphaOffsetHandle);
		}
		[Export("setInstanceAlphaOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceAlphaOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceAlphaOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InstanceBlueOffset
	{
		[Export("instanceBlueOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceBlueOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceBlueOffsetHandle);
		}
		[Export("setInstanceBlueOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceBlueOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceBlueOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor InstanceColor
	{
		[Export("instanceColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstanceColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selInstanceColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setInstanceColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstanceColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstanceColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint InstanceCount
	{
		[Export("instanceCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selInstanceCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selInstanceCountHandle);
		}
		[Export("setInstanceCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetInstanceCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetInstanceCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double InstanceDelay
	{
		[Export("instanceDelay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selInstanceDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selInstanceDelayHandle);
		}
		[Export("setInstanceDelay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetInstanceDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetInstanceDelay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InstanceGreenOffset
	{
		[Export("instanceGreenOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceGreenOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceGreenOffsetHandle);
		}
		[Export("setInstanceGreenOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceGreenOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceGreenOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InstanceRedOffset
	{
		[Export("instanceRedOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceRedOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceRedOffsetHandle);
		}
		[Export("setInstanceRedOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceRedOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceRedOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CATransform3D InstanceTransform
	{
		[Export("instanceTransform")]
		get
		{
			CATransform3D retval;
			if (base.IsDirectBinding)
			{
				Messaging.CATransform3D_objc_msgSend_stret(out retval, base.Handle, selInstanceTransformHandle);
			}
			else
			{
				Messaging.CATransform3D_objc_msgSendSuper_stret(out retval, base.SuperHandle, selInstanceTransformHandle);
			}
			return retval;
		}
		[Export("setInstanceTransform:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetInstanceTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetInstanceTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesDepth
	{
		[Export("preservesDepth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesDepthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesDepthHandle);
		}
		[Export("setPreservesDepth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesDepth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAReplicatorLayer()
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
	public CAReplicatorLayer(NSCoder coder)
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
	protected CAReplicatorLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAReplicatorLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}
