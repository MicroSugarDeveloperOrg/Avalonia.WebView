using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
using MapKit;
using ObjCRuntime;
using SceneKit;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSValue", true)]
public class NSValue : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCATransform3DValue = "CATransform3DValue";

	private static readonly IntPtr selCATransform3DValueHandle = Selector.GetHandle("CATransform3DValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCMTimeMappingValue = "CMTimeMappingValue";

	private static readonly IntPtr selCMTimeMappingValueHandle = Selector.GetHandle("CMTimeMappingValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCMTimeRangeValue = "CMTimeRangeValue";

	private static readonly IntPtr selCMTimeRangeValueHandle = Selector.GetHandle("CMTimeRangeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCMTimeValue = "CMTimeValue";

	private static readonly IntPtr selCMTimeValueHandle = Selector.GetHandle("CMTimeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMKCoordinateSpanValue = "MKCoordinateSpanValue";

	private static readonly IntPtr selMKCoordinateSpanValueHandle = Selector.GetHandle("MKCoordinateSpanValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMKCoordinateValue = "MKCoordinateValue";

	private static readonly IntPtr selMKCoordinateValueHandle = Selector.GetHandle("MKCoordinateValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSCNMatrix4Value = "SCNMatrix4Value";

	private static readonly IntPtr selSCNMatrix4ValueHandle = Selector.GetHandle("SCNMatrix4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSCNVector3Value = "SCNVector3Value";

	private static readonly IntPtr selSCNVector3ValueHandle = Selector.GetHandle("SCNVector3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSCNVector4Value = "SCNVector4Value";

	private static readonly IntPtr selSCNVector4ValueHandle = Selector.GetHandle("SCNVector4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetValue_ = "getValue:";

	private static readonly IntPtr selGetValue_Handle = Selector.GetHandle("getValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetValue_Size_ = "getValue:size:";

	private static readonly IntPtr selGetValue_Size_Handle = Selector.GetHandle("getValue:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToValue_ = "isEqualToValue:";

	private static readonly IntPtr selIsEqualToValue_Handle = Selector.GetHandle("isEqualToValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonretainedObjectValue = "nonretainedObjectValue";

	private static readonly IntPtr selNonretainedObjectValueHandle = Selector.GetHandle("nonretainedObjectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjCType = "objCType";

	private static readonly IntPtr selObjCTypeHandle = Selector.GetHandle("objCType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointValue = "pointValue";

	private static readonly IntPtr selPointValueHandle = Selector.GetHandle("pointValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointerValue = "pointerValue";

	private static readonly IntPtr selPointerValueHandle = Selector.GetHandle("pointerValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeValue = "rangeValue";

	private static readonly IntPtr selRangeValueHandle = Selector.GetHandle("rangeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectValue = "rectValue";

	private static readonly IntPtr selRectValueHandle = Selector.GetHandle("rectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeValue = "sizeValue";

	private static readonly IntPtr selSizeValueHandle = Selector.GetHandle("sizeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithBytes_ObjCType_ = "valueWithBytes:objCType:";

	private static readonly IntPtr selValueWithBytes_ObjCType_Handle = Selector.GetHandle("valueWithBytes:objCType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithCATransform3D_ = "valueWithCATransform3D:";

	private static readonly IntPtr selValueWithCATransform3D_Handle = Selector.GetHandle("valueWithCATransform3D:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithCMTime_ = "valueWithCMTime:";

	private static readonly IntPtr selValueWithCMTime_Handle = Selector.GetHandle("valueWithCMTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithCMTimeMapping_ = "valueWithCMTimeMapping:";

	private static readonly IntPtr selValueWithCMTimeMapping_Handle = Selector.GetHandle("valueWithCMTimeMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithCMTimeRange_ = "valueWithCMTimeRange:";

	private static readonly IntPtr selValueWithCMTimeRange_Handle = Selector.GetHandle("valueWithCMTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithMKCoordinate_ = "valueWithMKCoordinate:";

	private static readonly IntPtr selValueWithMKCoordinate_Handle = Selector.GetHandle("valueWithMKCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithMKCoordinateSpan_ = "valueWithMKCoordinateSpan:";

	private static readonly IntPtr selValueWithMKCoordinateSpan_Handle = Selector.GetHandle("valueWithMKCoordinateSpan:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithNonretainedObject_ = "valueWithNonretainedObject:";

	private static readonly IntPtr selValueWithNonretainedObject_Handle = Selector.GetHandle("valueWithNonretainedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithPoint_ = "valueWithPoint:";

	private static readonly IntPtr selValueWithPoint_Handle = Selector.GetHandle("valueWithPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithPointer_ = "valueWithPointer:";

	private static readonly IntPtr selValueWithPointer_Handle = Selector.GetHandle("valueWithPointer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithRange_ = "valueWithRange:";

	private static readonly IntPtr selValueWithRange_Handle = Selector.GetHandle("valueWithRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithRect_ = "valueWithRect:";

	private static readonly IntPtr selValueWithRect_Handle = Selector.GetHandle("valueWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithSCNMatrix4_ = "valueWithSCNMatrix4:";

	private static readonly IntPtr selValueWithSCNMatrix4_Handle = Selector.GetHandle("valueWithSCNMatrix4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithSCNVector3_ = "valueWithSCNVector3:";

	private static readonly IntPtr selValueWithSCNVector3_Handle = Selector.GetHandle("valueWithSCNVector3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithSCNVector4_ = "valueWithSCNVector4:";

	private static readonly IntPtr selValueWithSCNVector4_Handle = Selector.GetHandle("valueWithSCNVector4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithSize_ = "valueWithSize:";

	private static readonly IntPtr selValueWithSize_Handle = Selector.GetHandle("valueWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSValue");

	public string ObjCType => Marshal.PtrToStringAnsi(ObjCTypePtr());

	public unsafe virtual CGAffineTransform CGAffineTransformValue
	{
		get
		{
			CGAffineTransform result = default(CGAffineTransform);
			if (ObjCType == "{CGAffineTransform=dddddd}")
			{
				StoreValueAtAddress((IntPtr)(&result));
			}
			return result;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CATransform3D CATransform3DValue
	{
		[Export("CATransform3DValue")]
		get
		{
			CATransform3D retval;
			if (base.IsDirectBinding)
			{
				Messaging.CATransform3D_objc_msgSend_stret(out retval, base.Handle, selCATransform3DValueHandle);
			}
			else
			{
				Messaging.CATransform3D_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCATransform3DValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CGPointValue
	{
		[Export("pointValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPointValueHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPointValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CGRectValue
	{
		[Export("rectValue")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectValueHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize CGSizeValue
	{
		[Export("sizeValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeValueHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual CMTimeMapping CMTimeMappingValue
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("CMTimeMappingValue")]
		get
		{
			CMTimeMapping retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeMapping_objc_msgSend_stret(out retval, base.Handle, selCMTimeMappingValueHandle);
			}
			else
			{
				Messaging.CMTimeMapping_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCMTimeMappingValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual CMTimeRange CMTimeRangeValue
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("CMTimeRangeValue")]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selCMTimeRangeValueHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCMTimeRangeValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual CMTime CMTimeValue
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("CMTimeValue")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCMTimeValueHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCMTimeValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual MKCoordinateSpan CoordinateSpanValue
	{
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("MKCoordinateSpanValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.MKCoordinateSpan_objc_msgSend(base.Handle, selMKCoordinateSpanValueHandle);
			}
			return Messaging.MKCoordinateSpan_objc_msgSendSuper(base.SuperHandle, selMKCoordinateSpanValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CLLocationCoordinate2D CoordinateValue
	{
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("MKCoordinateValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CLLocationCoordinate2D_objc_msgSend(base.Handle, selMKCoordinateValueHandle);
			}
			return Messaging.CLLocationCoordinate2D_objc_msgSendSuper(base.SuperHandle, selMKCoordinateValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject NonretainedObjectValue
	{
		[Export("nonretainedObjectValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNonretainedObjectValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNonretainedObjectValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr PointerValue
	{
		[Export("pointerValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selPointerValueHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointerValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeValue
	{
		[Export("rangeValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selRangeValueHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SCNMatrix4 SCNMatrix4Value
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("SCNMatrix4Value")]
		get
		{
			SCNMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNMatrix4_objc_msgSend_stret(out retval, base.Handle, selSCNMatrix4ValueHandle);
			}
			else
			{
				Messaging.SCNMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSCNMatrix4ValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual SCNVector3 Vector3Value
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("SCNVector3Value")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selSCNVector3ValueHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSCNVector3ValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual SCNVector4 Vector4Value
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("SCNVector4Value")]
		get
		{
			SCNVector4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector4_objc_msgSend_stret(out retval, base.Handle, selSCNVector4ValueHandle);
			}
			else
			{
				Messaging.SCNVector4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSCNVector4ValueHandle);
			}
			return retval;
		}
	}

	[DllImport("__Internal")]
	private static extern IntPtr xamarin_encode_CGAffineTransform();

	public unsafe static NSValue FromCGAffineTransform(CGAffineTransform tran)
	{
		return Create((IntPtr)(&tran), xamarin_encode_CGAffineTransform());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSValue(NSCoder coder)
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
	protected NSValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSValue(IntPtr handle)
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

	[Export("valueWithBytes:objCType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSValue Create(IntPtr bytes, IntPtr objCType)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selValueWithBytes_ObjCType_Handle, bytes, objCType));
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

	[Export("valueWithCATransform3D:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCATransform3D(CATransform3D transform)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CATransform3D(class_ptr, selValueWithCATransform3D_Handle, transform));
	}

	[Export("valueWithPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCGPoint(CGPoint point)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CGPoint(class_ptr, selValueWithPoint_Handle, point));
	}

	[Export("valueWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCGRect(CGRect rect)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selValueWithRect_Handle, rect));
	}

	[Export("valueWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCGSize(CGSize size)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selValueWithSize_Handle, size));
	}

	[Export("valueWithCMTime:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCMTime(CMTime time)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CMTime(class_ptr, selValueWithCMTime_Handle, time));
	}

	[Export("valueWithCMTimeMapping:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCMTimeMapping(CMTimeMapping timeMapping)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CMTimeMapping(class_ptr, selValueWithCMTimeMapping_Handle, timeMapping));
	}

	[Export("valueWithCMTimeRange:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromCMTimeRange(CMTimeRange timeRange)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CMTimeRange(class_ptr, selValueWithCMTimeRange_Handle, timeRange));
	}

	[Export("valueWithMKCoordinate:")]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromMKCoordinate(CLLocationCoordinate2D coordinate)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D(class_ptr, selValueWithMKCoordinate_Handle, coordinate));
	}

	[Export("valueWithMKCoordinateSpan:")]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromMKCoordinateSpan(MKCoordinateSpan coordinateSpan)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_MKCoordinateSpan(class_ptr, selValueWithMKCoordinateSpan_Handle, coordinateSpan));
	}

	[Export("valueWithRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromRange(NSRange range)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selValueWithRange_Handle, range));
	}

	[Export("valueWithSCNMatrix4:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromSCNMatrix4(SCNMatrix4 matrix)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_SCNMatrix4(class_ptr, selValueWithSCNMatrix4_Handle, matrix));
	}

	[Export("valueWithSCNVector3:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromVector(SCNVector3 vector)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_SCNVector3(class_ptr, selValueWithSCNVector3_Handle, vector));
	}

	[Export("valueWithSCNVector4:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue FromVector(SCNVector4 vector)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_SCNVector4(class_ptr, selValueWithSCNVector4_Handle, vector));
	}

	[Export("isEqualToValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualTo(NSValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToValue_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToValue_Handle, value.Handle);
	}

	[Export("objCType")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr ObjCTypePtr()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selObjCTypeHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjCTypeHandle);
	}

	[Export("getValue:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Potential for buffer overruns. Use 'StoreValueAtAddress (IntPtr, nuint)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StoreValueAtAddress(IntPtr value)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetValue_Handle, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetValue_Handle, value);
		}
	}

	[Export("getValue:size:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StoreValueAtAddress(IntPtr value, nuint size)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selGetValue_Size_Handle, value, size);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetValue_Size_Handle, value, size);
		}
	}

	[Export("valueWithNonretainedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue ValueFromNonretainedObject(NSObject anObject)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithNonretainedObject_Handle, anObject.Handle));
	}

	[Export("valueWithPointer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue ValueFromPointer(IntPtr pointer)
	{
		return Runtime.GetNSObject<NSValue>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithPointer_Handle, pointer));
	}
}
