using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAReplicatorLayer", true)]
public class CAReplicatorLayer : CALayer
{
	private static readonly IntPtr selInstanceCountHandle = Selector.GetHandle("instanceCount");

	private static readonly IntPtr selSetInstanceCount_Handle = Selector.GetHandle("setInstanceCount:");

	private static readonly IntPtr selInstanceDelayHandle = Selector.GetHandle("instanceDelay");

	private static readonly IntPtr selSetInstanceDelay_Handle = Selector.GetHandle("setInstanceDelay:");

	private static readonly IntPtr selInstanceTransformHandle = Selector.GetHandle("instanceTransform");

	private static readonly IntPtr selSetInstanceTransform_Handle = Selector.GetHandle("setInstanceTransform:");

	private static readonly IntPtr selPreservesDepthHandle = Selector.GetHandle("preservesDepth");

	private static readonly IntPtr selSetPreservesDepth_Handle = Selector.GetHandle("setPreservesDepth:");

	private static readonly IntPtr selInstanceColorHandle = Selector.GetHandle("instanceColor");

	private static readonly IntPtr selSetInstanceColor_Handle = Selector.GetHandle("setInstanceColor:");

	private static readonly IntPtr selInstanceRedOffsetHandle = Selector.GetHandle("instanceRedOffset");

	private static readonly IntPtr selSetInstanceRedOffset_Handle = Selector.GetHandle("setInstanceRedOffset:");

	private static readonly IntPtr selInstanceGreenOffsetHandle = Selector.GetHandle("instanceGreenOffset");

	private static readonly IntPtr selSetInstanceGreenOffset_Handle = Selector.GetHandle("setInstanceGreenOffset:");

	private static readonly IntPtr selInstanceBlueOffsetHandle = Selector.GetHandle("instanceBlueOffset");

	private static readonly IntPtr selSetInstanceBlueOffset_Handle = Selector.GetHandle("setInstanceBlueOffset:");

	private static readonly IntPtr selInstanceAlphaOffsetHandle = Selector.GetHandle("instanceAlphaOffset");

	private static readonly IntPtr selSetInstanceAlphaOffset_Handle = Selector.GetHandle("setInstanceAlphaOffset:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAReplicatorLayer");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int InstanceCount
	{
		[Export("instanceCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selInstanceCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selInstanceCountHandle);
		}
		[Export("setInstanceCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetInstanceCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetInstanceCount_Handle, value);
			}
		}
	}

	public virtual double InstanceDelay
	{
		[Export("instanceDelay")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selInstanceDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selInstanceDelayHandle);
		}
		[Export("setInstanceDelay:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetInstanceDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetInstanceDelay_Handle, value);
			}
		}
	}

	public virtual CATransform3D InstanceTransform
	{
		[Export("instanceTransform")]
		get
		{
			CATransform3D retval;
			if (IsDirectBinding)
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CATransform3D(base.Handle, selSetInstanceTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CATransform3D(base.SuperHandle, selSetInstanceTransform_Handle, value);
			}
		}
	}

	public virtual bool PreservesDepth
	{
		[Export("preservesDepth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesDepthHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesDepthHandle);
		}
		[Export("setPreservesDepth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesDepth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesDepth_Handle, value);
			}
		}
	}

	public virtual CGColor InstanceColor
	{
		[Export("instanceColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selInstanceColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstanceColorHandle));
		}
		[Export("setInstanceColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstanceColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstanceColor_Handle, value.Handle);
			}
		}
	}

	public virtual float InstanceRedOffset
	{
		[Export("instanceRedOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceRedOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceRedOffsetHandle);
		}
		[Export("setInstanceRedOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceRedOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceRedOffset_Handle, value);
			}
		}
	}

	public virtual float InstanceGreenOffset
	{
		[Export("instanceGreenOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceGreenOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceGreenOffsetHandle);
		}
		[Export("setInstanceGreenOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceGreenOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceGreenOffset_Handle, value);
			}
		}
	}

	public virtual float InstanceBlueOffset
	{
		[Export("instanceBlueOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceBlueOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceBlueOffsetHandle);
		}
		[Export("setInstanceBlueOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceBlueOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceBlueOffset_Handle, value);
			}
		}
	}

	public virtual float InstanceAlphaOffset
	{
		[Export("instanceAlphaOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInstanceAlphaOffsetHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInstanceAlphaOffsetHandle);
		}
		[Export("setInstanceAlphaOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInstanceAlphaOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInstanceAlphaOffset_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAReplicatorLayer()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAReplicatorLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAReplicatorLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAReplicatorLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}
