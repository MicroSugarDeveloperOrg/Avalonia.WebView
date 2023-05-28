using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNLevelOfDetail", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNLevelOfDetail : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeometry = "geometry";

	private static readonly IntPtr selGeometryHandle = Selector.GetHandle("geometry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevelOfDetailWithGeometry_ScreenSpaceRadius_ = "levelOfDetailWithGeometry:screenSpaceRadius:";

	private static readonly IntPtr selLevelOfDetailWithGeometry_ScreenSpaceRadius_Handle = Selector.GetHandle("levelOfDetailWithGeometry:screenSpaceRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevelOfDetailWithGeometry_WorldSpaceDistance_ = "levelOfDetailWithGeometry:worldSpaceDistance:";

	private static readonly IntPtr selLevelOfDetailWithGeometry_WorldSpaceDistance_Handle = Selector.GetHandle("levelOfDetailWithGeometry:worldSpaceDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenSpaceRadius = "screenSpaceRadius";

	private static readonly IntPtr selScreenSpaceRadiusHandle = Selector.GetHandle("screenSpaceRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWorldSpaceDistance = "worldSpaceDistance";

	private static readonly IntPtr selWorldSpaceDistanceHandle = Selector.GetHandle("worldSpaceDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNLevelOfDetail");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNGeometry Geometry
	{
		[Export("geometry")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selGeometryHandle));
			}
			return Runtime.GetNSObject<SCNGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGeometryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ScreenSpaceRadius
	{
		[Export("screenSpaceRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScreenSpaceRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScreenSpaceRadiusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat WorldSpaceDistance
	{
		[Export("worldSpaceDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selWorldSpaceDistanceHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selWorldSpaceDistanceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNLevelOfDetail(NSCoder coder)
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
	protected SCNLevelOfDetail(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNLevelOfDetail(IntPtr handle)
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

	[Export("levelOfDetailWithGeometry:screenSpaceRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNLevelOfDetail CreateWithScreenSpaceRadius(SCNGeometry? geometry, nfloat screenSpaceRadius)
	{
		return Runtime.GetNSObject<SCNLevelOfDetail>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selLevelOfDetailWithGeometry_ScreenSpaceRadius_Handle, geometry?.Handle ?? IntPtr.Zero, screenSpaceRadius));
	}

	[Export("levelOfDetailWithGeometry:worldSpaceDistance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNLevelOfDetail CreateWithWorldSpaceDistance(SCNGeometry? geometry, nfloat worldSpaceDistance)
	{
		return Runtime.GetNSObject<SCNLevelOfDetail>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selLevelOfDetailWithGeometry_WorldSpaceDistance_Handle, geometry?.Handle ?? IntPtr.Zero, worldSpaceDistance));
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
