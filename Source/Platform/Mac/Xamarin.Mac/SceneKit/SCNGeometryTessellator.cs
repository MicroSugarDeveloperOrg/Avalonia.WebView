using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNGeometryTessellator", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
public class SCNGeometryTessellator : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeTessellationFactor = "edgeTessellationFactor";

	private static readonly IntPtr selEdgeTessellationFactorHandle = Selector.GetHandle("edgeTessellationFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsideTessellationFactor = "insideTessellationFactor";

	private static readonly IntPtr selInsideTessellationFactorHandle = Selector.GetHandle("insideTessellationFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdaptive = "isAdaptive";

	private static readonly IntPtr selIsAdaptiveHandle = Selector.GetHandle("isAdaptive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsScreenSpace = "isScreenSpace";

	private static readonly IntPtr selIsScreenSpaceHandle = Selector.GetHandle("isScreenSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumEdgeLength = "maximumEdgeLength";

	private static readonly IntPtr selMaximumEdgeLengthHandle = Selector.GetHandle("maximumEdgeLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdaptive_ = "setAdaptive:";

	private static readonly IntPtr selSetAdaptive_Handle = Selector.GetHandle("setAdaptive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeTessellationFactor_ = "setEdgeTessellationFactor:";

	private static readonly IntPtr selSetEdgeTessellationFactor_Handle = Selector.GetHandle("setEdgeTessellationFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInsideTessellationFactor_ = "setInsideTessellationFactor:";

	private static readonly IntPtr selSetInsideTessellationFactor_Handle = Selector.GetHandle("setInsideTessellationFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumEdgeLength_ = "setMaximumEdgeLength:";

	private static readonly IntPtr selSetMaximumEdgeLength_Handle = Selector.GetHandle("setMaximumEdgeLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScreenSpace_ = "setScreenSpace:";

	private static readonly IntPtr selSetScreenSpace_Handle = Selector.GetHandle("setScreenSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSmoothingMode_ = "setSmoothingMode:";

	private static readonly IntPtr selSetSmoothingMode_Handle = Selector.GetHandle("setSmoothingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTessellationFactorScale_ = "setTessellationFactorScale:";

	private static readonly IntPtr selSetTessellationFactorScale_Handle = Selector.GetHandle("setTessellationFactorScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTessellationPartitionMode_ = "setTessellationPartitionMode:";

	private static readonly IntPtr selSetTessellationPartitionMode_Handle = Selector.GetHandle("setTessellationPartitionMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmoothingMode = "smoothingMode";

	private static readonly IntPtr selSmoothingModeHandle = Selector.GetHandle("smoothingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTessellationFactorScale = "tessellationFactorScale";

	private static readonly IntPtr selTessellationFactorScaleHandle = Selector.GetHandle("tessellationFactorScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTessellationPartitionMode = "tessellationPartitionMode";

	private static readonly IntPtr selTessellationPartitionModeHandle = Selector.GetHandle("tessellationPartitionMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNGeometryTessellator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Adaptive
	{
		[Export("isAdaptive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdaptiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdaptiveHandle);
		}
		[Export("setAdaptive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdaptive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdaptive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat EdgeTessellationFactor
	{
		[Export("edgeTessellationFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selEdgeTessellationFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selEdgeTessellationFactorHandle);
		}
		[Export("setEdgeTessellationFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetEdgeTessellationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetEdgeTessellationFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat InsideTessellationFactor
	{
		[Export("insideTessellationFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selInsideTessellationFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selInsideTessellationFactorHandle);
		}
		[Export("setInsideTessellationFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInsideTessellationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInsideTessellationFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaximumEdgeLength
	{
		[Export("maximumEdgeLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumEdgeLengthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumEdgeLengthHandle);
		}
		[Export("setMaximumEdgeLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumEdgeLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumEdgeLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ScreenSpace
	{
		[Export("isScreenSpace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsScreenSpaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsScreenSpaceHandle);
		}
		[Export("setScreenSpace:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetScreenSpace_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetScreenSpace_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNTessellationSmoothingMode SmoothingMode
	{
		[Export("smoothingMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNTessellationSmoothingMode)Messaging.Int64_objc_msgSend(base.Handle, selSmoothingModeHandle);
			}
			return (SCNTessellationSmoothingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSmoothingModeHandle);
		}
		[Export("setSmoothingMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSmoothingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSmoothingMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TessellationFactorScale
	{
		[Export("tessellationFactorScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTessellationFactorScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTessellationFactorScaleHandle);
		}
		[Export("setTessellationFactorScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTessellationFactorScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTessellationFactorScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLTessellationPartitionMode TessellationPartitionMode
	{
		[Export("tessellationPartitionMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTessellationPartitionMode)Messaging.UInt64_objc_msgSend(base.Handle, selTessellationPartitionModeHandle);
			}
			return (MTLTessellationPartitionMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTessellationPartitionModeHandle);
		}
		[Export("setTessellationPartitionMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTessellationPartitionMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTessellationPartitionMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNGeometryTessellator(NSCoder coder)
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
	protected SCNGeometryTessellator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNGeometryTessellator(IntPtr handle)
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
