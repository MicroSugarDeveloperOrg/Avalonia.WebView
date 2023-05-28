using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKRegion", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class SKRegion : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsPoint_ = "containsPoint:";

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInfiniteRegion = "infiniteRegion";

	private static readonly IntPtr selInfiniteRegionHandle = Selector.GetHandle("infiniteRegion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPath_ = "initWithPath:";

	private static readonly IntPtr selInitWithPath_Handle = Selector.GetHandle("initWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRadius_ = "initWithRadius:";

	private static readonly IntPtr selInitWithRadius_Handle = Selector.GetHandle("initWithRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_ = "initWithSize:";

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInverseRegion = "inverseRegion";

	private static readonly IntPtr selInverseRegionHandle = Selector.GetHandle("inverseRegion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionByDifferenceFromRegion_ = "regionByDifferenceFromRegion:";

	private static readonly IntPtr selRegionByDifferenceFromRegion_Handle = Selector.GetHandle("regionByDifferenceFromRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionByIntersectionWithRegion_ = "regionByIntersectionWithRegion:";

	private static readonly IntPtr selRegionByIntersectionWithRegion_Handle = Selector.GetHandle("regionByIntersectionWithRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionByUnionWithRegion_ = "regionByUnionWithRegion:";

	private static readonly IntPtr selRegionByUnionWithRegion_Handle = Selector.GetHandle("regionByUnionWithRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKRegion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRegion InfiniteRegion
	{
		[Export("infiniteRegion")]
		get
		{
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend(class_ptr, selInfiniteRegionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPath Path
	{
		[Export("path")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPath(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKRegion()
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
	public SKRegion(NSCoder coder)
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
	protected SKRegion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKRegion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRadius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKRegion(float radius)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float(base.Handle, selInitWithRadius_Handle, radius), "initWithRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float(base.SuperHandle, selInitWithRadius_Handle, radius), "initWithRadius:");
		}
	}

	[Export("initWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKRegion(CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, size), "initWithSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithSize_Handle, size), "initWithSize:");
		}
	}

	[Export("initWithPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKRegion(CGPath path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPath_Handle, path.Handle), "initWithPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPath_Handle, path.Handle), "initWithPath:");
		}
	}

	[Export("containsPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsPoint(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
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

	[Export("regionByDifferenceFromRegion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRegion CreateDifference(SKRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRegionByDifferenceFromRegion_Handle, region.Handle));
		}
		return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegionByDifferenceFromRegion_Handle, region.Handle));
	}

	[Export("regionByIntersectionWithRegion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRegion CreateIntersection(SKRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRegionByIntersectionWithRegion_Handle, region.Handle));
		}
		return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegionByIntersectionWithRegion_Handle, region.Handle));
	}

	[Export("regionByUnionWithRegion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRegion CreateUnion(SKRegion region)
	{
		if (region == null)
		{
			throw new ArgumentNullException("region");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRegionByUnionWithRegion_Handle, region.Handle));
		}
		return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegionByUnionWithRegion_Handle, region.Handle));
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

	[Export("inverseRegion")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRegion InverseRegion()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSend(base.Handle, selInverseRegionHandle));
		}
		return Runtime.GetNSObject<SKRegion>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInverseRegionHandle));
	}
}
