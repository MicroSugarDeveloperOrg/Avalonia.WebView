using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIVector", true)]
public class CIVector : NSObject
{
	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selXHandle = Selector.GetHandle("X");

	private static readonly IntPtr selYHandle = Selector.GetHandle("Y");

	private static readonly IntPtr selZHandle = Selector.GetHandle("Z");

	private static readonly IntPtr selWHandle = Selector.GetHandle("W");

	private static readonly IntPtr selVectorWithValuesCount_Handle = Selector.GetHandle("vectorWithValues:count:");

	private static readonly IntPtr selVectorWithX_Handle = Selector.GetHandle("vectorWithX:");

	private static readonly IntPtr selVectorWithXY_Handle = Selector.GetHandle("vectorWithX:Y:");

	private static readonly IntPtr selVectorWithXYZ_Handle = Selector.GetHandle("vectorWithX:Y:Z:");

	private static readonly IntPtr selVectorWithXYZW_Handle = Selector.GetHandle("vectorWithX:Y:Z:W:");

	private static readonly IntPtr selVectorWithString_Handle = Selector.GetHandle("vectorWithString:");

	private static readonly IntPtr selInitWithValuesCount_Handle = Selector.GetHandle("initWithValues:count:");

	private static readonly IntPtr selInitWithX_Handle = Selector.GetHandle("initWithX:");

	private static readonly IntPtr selInitWithXY_Handle = Selector.GetHandle("initWithX:Y:");

	private static readonly IntPtr selInitWithXYZ_Handle = Selector.GetHandle("initWithX:Y:Z:");

	private static readonly IntPtr selInitWithXYZW_Handle = Selector.GetHandle("initWithX:Y:Z:W:");

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	private static readonly IntPtr selValueAtIndex_Handle = Selector.GetHandle("valueAtIndex:");

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIVector");

	private double this[int index] => ValueAtIndex(index);

	public override IntPtr ClassHandle => class_ptr;

	public virtual int Count
	{
		[Export("count")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	public virtual double X
	{
		[Export("X")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selXHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selXHandle);
		}
	}

	public virtual double Y
	{
		[Export("Y")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selYHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selYHandle);
		}
	}

	public virtual double Z
	{
		[Export("Z")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selZHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selZHandle);
		}
	}

	public virtual double W
	{
		[Export("W")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selWHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selWHandle);
		}
	}

	private unsafe static IntPtr GetPtr(double[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		fixed (double* ptr = &values[0])
		{
			return (IntPtr)ptr;
		}
	}

	public CIVector(double[] values)
		: this(GetPtr(values), values.Length)
	{
	}

	public unsafe static CIVector FromValues(double[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		fixed (double* ptr = &values[0])
		{
			return _FromValues((IntPtr)ptr, values.Length);
		}
	}

	public override string ToString()
	{
		return StringRepresentation();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIVector(NSCoder coder)
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
	public CIVector(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIVector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("vectorWithValues:count:")]
	internal static CIVector _FromValues(IntPtr values, long count)
	{
		return (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(class_ptr, selVectorWithValuesCount_Handle, values, count));
	}

	[Export("vectorWithX:")]
	public static CIVector Create(double x)
	{
		return (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selVectorWithX_Handle, x));
	}

	[Export("vectorWithX:Y:")]
	public static CIVector Create(double x, double y)
	{
		return (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double(class_ptr, selVectorWithXY_Handle, x, y));
	}

	[Export("vectorWithX:Y:Z:")]
	public static CIVector Create(double x, double y, double z)
	{
		return (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double(class_ptr, selVectorWithXYZ_Handle, x, y, z));
	}

	[Export("vectorWithX:Y:Z:W:")]
	public static CIVector Create(double x, double y, double z, double w)
	{
		return (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selVectorWithXYZW_Handle, x, y, z, w));
	}

	[Export("vectorWithString:")]
	public static CIVector FromString(string representation)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		CIVector result = (CIVector)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVectorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithValues:count:")]
	internal CIVector(IntPtr values, long count)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64(base.Handle, selInitWithValuesCount_Handle, values, count);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInitWithValuesCount_Handle, values, count);
		}
	}

	[Export("initWithX:")]
	public CIVector(double x)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithX_Handle, x);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithX_Handle, x);
		}
	}

	[Export("initWithX:Y:")]
	public CIVector(double x, double y)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double_Double(base.Handle, selInitWithXY_Handle, x, y);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double_Double(base.SuperHandle, selInitWithXY_Handle, x, y);
		}
	}

	[Export("initWithX:Y:Z:")]
	public CIVector(double x, double y, double z)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double_Double_Double(base.Handle, selInitWithXYZ_Handle, x, y, z);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double_Double_Double(base.SuperHandle, selInitWithXYZ_Handle, x, y, z);
		}
	}

	[Export("initWithX:Y:Z:W:")]
	public CIVector(double x, double y, double z, double w)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(base.Handle, selInitWithXYZW_Handle, x, y, z, w);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double_Double_Double_Double(base.SuperHandle, selInitWithXYZW_Handle, x, y, z, w);
		}
	}

	[Export("initWithString:")]
	public CIVector(string representation)
		: base(NSObjectFlag.Empty)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("valueAtIndex:")]
	internal virtual double ValueAtIndex(long index)
	{
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selValueAtIndex_Handle, index);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selValueAtIndex_Handle, index);
	}

	[Export("stringRepresentation")]
	internal virtual string StringRepresentation()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
	}
}
