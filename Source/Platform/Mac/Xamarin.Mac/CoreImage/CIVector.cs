using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIVector", true)]
public class CIVector : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGAffineTransformValue = "CGAffineTransformValue";

	private static readonly IntPtr selCGAffineTransformValueHandle = Selector.GetHandle("CGAffineTransformValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGPointValue = "CGPointValue";

	private static readonly IntPtr selCGPointValueHandle = Selector.GetHandle("CGPointValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGRectValue = "CGRectValue";

	private static readonly IntPtr selCGRectValueHandle = Selector.GetHandle("CGRectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selW = "W";

	private static readonly IntPtr selWHandle = Selector.GetHandle("W");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selX = "X";

	private static readonly IntPtr selXHandle = Selector.GetHandle("X");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selY = "Y";

	private static readonly IntPtr selYHandle = Selector.GetHandle("Y");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZ = "Z";

	private static readonly IntPtr selZHandle = Selector.GetHandle("Z");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGAffineTransform_ = "initWithCGAffineTransform:";

	private static readonly IntPtr selInitWithCGAffineTransform_Handle = Selector.GetHandle("initWithCGAffineTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGPoint_ = "initWithCGPoint:";

	private static readonly IntPtr selInitWithCGPoint_Handle = Selector.GetHandle("initWithCGPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGRect_ = "initWithCGRect:";

	private static readonly IntPtr selInitWithCGRect_Handle = Selector.GetHandle("initWithCGRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithX_ = "initWithX:";

	private static readonly IntPtr selInitWithX_Handle = Selector.GetHandle("initWithX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithX_Y_ = "initWithX:Y:";

	private static readonly IntPtr selInitWithX_Y_Handle = Selector.GetHandle("initWithX:Y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithX_Y_Z_ = "initWithX:Y:Z:";

	private static readonly IntPtr selInitWithX_Y_Z_Handle = Selector.GetHandle("initWithX:Y:Z:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithX_Y_Z_W_ = "initWithX:Y:Z:W:";

	private static readonly IntPtr selInitWithX_Y_Z_W_Handle = Selector.GetHandle("initWithX:Y:Z:W:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringRepresentation = "stringRepresentation";

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueAtIndex_ = "valueAtIndex:";

	private static readonly IntPtr selValueAtIndex_Handle = Selector.GetHandle("valueAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithString_ = "vectorWithString:";

	private static readonly IntPtr selVectorWithString_Handle = Selector.GetHandle("vectorWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithValues_Count_ = "vectorWithValues:count:";

	private static readonly IntPtr selVectorWithValues_Count_Handle = Selector.GetHandle("vectorWithValues:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithX_ = "vectorWithX:";

	private static readonly IntPtr selVectorWithX_Handle = Selector.GetHandle("vectorWithX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithX_Y_ = "vectorWithX:Y:";

	private static readonly IntPtr selVectorWithX_Y_Handle = Selector.GetHandle("vectorWithX:Y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithX_Y_Z_ = "vectorWithX:Y:Z:";

	private static readonly IntPtr selVectorWithX_Y_Z_Handle = Selector.GetHandle("vectorWithX:Y:Z:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorWithX_Y_Z_W_ = "vectorWithX:Y:Z:W:";

	private static readonly IntPtr selVectorWithX_Y_Z_W_Handle = Selector.GetHandle("vectorWithX:Y:Z:W:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIVector");

	private nfloat this[nint index] => ValueAtIndex(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGAffineTransform AffineTransform
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("CGAffineTransformValue")]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selCGAffineTransformValueHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCGAffineTransformValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGPoint Point
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("CGPointValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCGPointValueHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCGPointValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGRect Rectangle
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("CGRectValue")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selCGRectValueHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCGRectValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat W
	{
		[Export("W")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selWHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selWHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat X
	{
		[Export("X")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selXHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Y
	{
		[Export("Y")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selYHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Z
	{
		[Export("Z")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selZHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selZHandle);
		}
	}

	public CIVector(nfloat[] values)
		: this(values, (values != null) ? values.Length : 0)
	{
	}

	[DesignatedInitializer]
	[Export("initWithValues:count:")]
	public unsafe CIVector(nfloat[] values, nint count)
		: base(NSObjectFlag.Empty)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (count > values.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		fixed (nfloat* ptr = values)
		{
			IntPtr zero = IntPtr.Zero;
			zero = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, Selector.GetHandle("initWithValues:count:"), (IntPtr)ptr, count) : Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, Selector.GetHandle("initWithValues:count:"), (IntPtr)ptr, count));
			InitializeHandle(zero, "initWithValues:count:");
		}
	}

	public unsafe static CIVector FromValues(nfloat[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		fixed (nfloat* ptr = values)
		{
			return _FromValues((IntPtr)ptr, values.Length);
		}
	}

	public override string ToString()
	{
		return StringRepresentation();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIVector(NSCoder coder)
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
	protected CIVector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIVector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCGPoint:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(CGPoint p)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selInitWithCGPoint_Handle, p), "initWithCGPoint:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selInitWithCGPoint_Handle, p), "initWithCGPoint:");
		}
	}

	[Export("initWithCGRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(CGRect r)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithCGRect_Handle, r), "initWithCGRect:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithCGRect_Handle, r), "initWithCGRect:");
		}
	}

	[Export("initWithCGAffineTransform:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(CGAffineTransform r)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGAffineTransform(base.Handle, selInitWithCGAffineTransform_Handle, r), "initWithCGAffineTransform:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selInitWithCGAffineTransform_Handle, r), "initWithCGAffineTransform:");
		}
	}

	[Export("initWithX:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(nfloat x)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selInitWithX_Handle, x), "initWithX:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selInitWithX_Handle, x), "initWithX:");
		}
	}

	[Export("initWithX:Y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(nfloat x, nfloat y)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(base.Handle, selInitWithX_Y_Handle, x, y), "initWithX:Y:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selInitWithX_Y_Handle, x, y), "initWithX:Y:");
		}
	}

	[Export("initWithX:Y:Z:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(nfloat x, nfloat y, nfloat z)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(base.Handle, selInitWithX_Y_Z_Handle, x, y, z), "initWithX:Y:Z:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat(base.SuperHandle, selInitWithX_Y_Z_Handle, x, y, z), "initWithX:Y:Z:");
		}
	}

	[Export("initWithX:Y:Z:W:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(nfloat x, nfloat y, nfloat z, nfloat w)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(base.Handle, selInitWithX_Y_Z_W_Handle, x, y, z, w), "initWithX:Y:Z:W:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat(base.SuperHandle, selInitWithX_Y_Z_W_Handle, x, y, z, w), "initWithX:Y:Z:W:");
		}
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector(string representation)
		: base(NSObjectFlag.Empty)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("vectorWithX:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIVector Create(nfloat x)
	{
		return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selVectorWithX_Handle, x));
	}

	[Export("vectorWithX:Y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIVector Create(nfloat x, nfloat y)
	{
		return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selVectorWithX_Y_Handle, x, y));
	}

	[Export("vectorWithX:Y:Z:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIVector Create(nfloat x, nfloat y, nfloat z)
	{
		return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(class_ptr, selVectorWithX_Y_Z_Handle, x, y, z));
	}

	[Export("vectorWithX:Y:Z:W:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIVector Create(nfloat x, nfloat y, nfloat z, nfloat w)
	{
		return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selVectorWithX_Y_Z_W_Handle, x, y, z, w));
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

	[Export("vectorWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIVector FromString(string representation)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		CIVector nSObject = Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVectorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("stringRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual string StringRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
	}

	[Export("valueAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nfloat ValueAtIndex(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selValueAtIndex_Handle, index);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selValueAtIndex_Handle, index);
	}

	[Export("vectorWithValues:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CIVector _FromValues(IntPtr values, nint count)
	{
		return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selVectorWithValues_Count_Handle, values, count));
	}
}
