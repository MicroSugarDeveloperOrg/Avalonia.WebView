using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNHitTestResult", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNHitTestResult : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoneNode = "boneNode";

	private static readonly IntPtr selBoneNodeHandle = Selector.GetHandle("boneNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceIndex = "faceIndex";

	private static readonly IntPtr selFaceIndexHandle = Selector.GetHandle("faceIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometryIndex = "geometryIndex";

	private static readonly IntPtr selGeometryIndexHandle = Selector.GetHandle("geometryIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalCoordinates = "localCoordinates";

	private static readonly IntPtr selLocalCoordinatesHandle = Selector.GetHandle("localCoordinates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalNormal = "localNormal";

	private static readonly IntPtr selLocalNormalHandle = Selector.GetHandle("localNormal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelTransform = "modelTransform";

	private static readonly IntPtr selModelTransformHandle = Selector.GetHandle("modelTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNode = "node";

	private static readonly IntPtr selNodeHandle = Selector.GetHandle("node");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureCoordinatesWithMappingChannel_ = "textureCoordinatesWithMappingChannel:";

	private static readonly IntPtr selTextureCoordinatesWithMappingChannel_Handle = Selector.GetHandle("textureCoordinatesWithMappingChannel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorldCoordinates = "worldCoordinates";

	private static readonly IntPtr selWorldCoordinatesHandle = Selector.GetHandle("worldCoordinates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorldNormal = "worldNormal";

	private static readonly IntPtr selWorldNormalHandle = Selector.GetHandle("worldNormal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNHitTestResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SCNNode BoneNode
	{
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("boneNode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoneNodeHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoneNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint FaceIndex
	{
		[Export("faceIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selFaceIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selFaceIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GeometryIndex
	{
		[Export("geometryIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selGeometryIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selGeometryIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 LocalCoordinates
	{
		[Export("localCoordinates")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selLocalCoordinatesHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLocalCoordinatesHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 LocalNormal
	{
		[Export("localNormal")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selLocalNormalHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLocalNormalHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMatrix4 ModelTransform
	{
		[Export("modelTransform")]
		get
		{
			SCNMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNMatrix4_objc_msgSend_stret(out retval, base.Handle, selModelTransformHandle);
			}
			else
			{
				Messaging.SCNMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selModelTransformHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNNode Node
	{
		[Export("node")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeHandle));
			}
			return Runtime.GetNSObject<SCNNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 WorldCoordinates
	{
		[Export("worldCoordinates")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selWorldCoordinatesHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selWorldCoordinatesHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 WorldNormal
	{
		[Export("worldNormal")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selWorldNormalHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selWorldNormalHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNHitTestResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNHitTestResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("textureCoordinatesWithMappingChannel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetTextureCoordinatesWithMappingChannel(nint channel)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_nint(base.Handle, selTextureCoordinatesWithMappingChannel_Handle, channel);
		}
		return Messaging.CGPoint_objc_msgSendSuper_nint(base.SuperHandle, selTextureCoordinatesWithMappingChannel_Handle, channel);
	}
}
