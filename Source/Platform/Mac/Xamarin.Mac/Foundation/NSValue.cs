using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreMedia;
using ObjCRuntime;

namespace Foundation;

[Register("NSValue", true)]
public class NSValue : NSObject
{
	private static readonly IntPtr selNonretainedObjectValueHandle = Selector.GetHandle("nonretainedObjectValue");

	private static readonly IntPtr selPointerValueHandle = Selector.GetHandle("pointerValue");

	private static readonly IntPtr selCMTimeValueHandle = Selector.GetHandle("CMTimeValue");

	private static readonly IntPtr selCMTimeMappingValueHandle = Selector.GetHandle("CMTimeMappingValue");

	private static readonly IntPtr selCMTimeRangeValueHandle = Selector.GetHandle("CMTimeRangeValue");

	private static readonly IntPtr selRectValueHandle = Selector.GetHandle("rectValue");

	private static readonly IntPtr selSizeValueHandle = Selector.GetHandle("sizeValue");

	private static readonly IntPtr selPointValueHandle = Selector.GetHandle("pointValue");

	private static readonly IntPtr selRangeValueHandle = Selector.GetHandle("rangeValue");

	private static readonly IntPtr selGetValue_Handle = Selector.GetHandle("getValue:");

	private static readonly IntPtr selObjCTypeHandle = Selector.GetHandle("objCType");

	private static readonly IntPtr selValueWithNonretainedObject_Handle = Selector.GetHandle("valueWithNonretainedObject:");

	private static readonly IntPtr selValueWithPointer_Handle = Selector.GetHandle("valueWithPointer:");

	private static readonly IntPtr selIsEqualToValue_Handle = Selector.GetHandle("isEqualToValue:");

	private static readonly IntPtr selValueWithRange_Handle = Selector.GetHandle("valueWithRange:");

	private static readonly IntPtr selValueWithCMTime_Handle = Selector.GetHandle("valueWithCMTime:");

	private static readonly IntPtr selValueWithCMTimeMapping_Handle = Selector.GetHandle("valueWithCMTimeMapping:");

	private static readonly IntPtr selValueWithCMTimeRange_Handle = Selector.GetHandle("valueWithCMTimeRange:");

	private static readonly IntPtr selValueWithRect_Handle = Selector.GetHandle("valueWithRect:");

	private static readonly IntPtr selValueWithSize_Handle = Selector.GetHandle("valueWithSize:");

	private static readonly IntPtr selValueWithPoint_Handle = Selector.GetHandle("valueWithPoint:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSValue");

	private object __mt_NonretainedObjectValue_var;

	public string ObjCType => Marshal.PtrToStringAnsi(ObjCTypePtr());

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject NonretainedObjectValue
	{
		[Export("nonretainedObjectValue")]
		get
		{
			return (NSObject)(__mt_NonretainedObjectValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNonretainedObjectValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNonretainedObjectValueHandle))));
		}
	}

	public virtual IntPtr PointerValue
	{
		[Export("pointerValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selPointerValueHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointerValueHandle);
		}
	}

	public virtual CMTime CMTimeValue
	{
		[Export("CMTimeValue")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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

	public virtual CMTimeMapping CMTimeMappingValue
	{
		[Export("CMTimeMappingValue")]
		get
		{
			CMTimeMapping retval;
			if (IsDirectBinding)
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

	public virtual CMTimeRange CMTimeRangeValue
	{
		[Export("CMTimeRangeValue")]
		get
		{
			CMTimeRange retval;
			if (IsDirectBinding)
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

	public virtual CGRect RectangleValue
	{
		[Export("rectValue")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGSize SizeValue
	{
		[Export("sizeValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeValueHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeValueHandle);
		}
	}

	public virtual CGPoint PointValue
	{
		[Export("pointValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selPointValueHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selPointValueHandle);
		}
	}

	public virtual NSRange RangeValue
	{
		[Export("rangeValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selRangeValueHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeValueHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSValue(NSCoder coder)
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
	public NSValue(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getValue:")]
	public virtual void StoreValueAtAddress(IntPtr value)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetValue_Handle, value);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetValue_Handle, value);
		}
	}

	[Export("objCType")]
	internal virtual IntPtr ObjCTypePtr()
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selObjCTypeHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjCTypeHandle);
	}

	[Export("valueWithNonretainedObject:")]
	public static NSValue ValueFromNonretainedObject(NSObject anObject)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithNonretainedObject_Handle, anObject.Handle));
	}

	[Export("valueWithPointer:")]
	public static NSValue ValueFromPointer(IntPtr pointer)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueWithPointer_Handle, pointer));
	}

	[Export("isEqualToValue:")]
	public virtual bool IsEqualTo(NSValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToValue_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToValue_Handle, value.Handle);
	}

	[Export("valueWithRange:")]
	public static NSValue FromRange(NSRange range)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selValueWithRange_Handle, range));
	}

	[Export("valueWithCMTime:")]
	public static NSValue FromCMTime(CMTime time)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTime(class_ptr, selValueWithCMTime_Handle, time));
	}

	[Export("valueWithCMTimeMapping:")]
	public static NSValue FromCMTimeMapping(CMTimeMapping timeMapping)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTimeMapping(class_ptr, selValueWithCMTimeMapping_Handle, timeMapping));
	}

	[Export("valueWithCMTimeRange:")]
	public static NSValue FromCMTimeRange(CMTimeRange timeRange)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTimeRange(class_ptr, selValueWithCMTimeRange_Handle, timeRange));
	}

	[Export("valueWithRect:")]
	public static NSValue FromRectangle(CGRect rect)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selValueWithRect_Handle, rect));
	}

	[Export("valueWithSize:")]
	public static NSValue FromSize(CGSize size)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selValueWithSize_Handle, size));
	}

	[Export("valueWithPoint:")]
	public static NSValue FromPoint(CGPoint point)
	{
		return (NSValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(class_ptr, selValueWithPoint_Handle, point));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_NonretainedObjectValue_var = null;
		}
	}
}
