using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIColor", true)]
public class CIColor : NSObject
{
	private static readonly IntPtr selNumberOfComponentsHandle = Selector.GetHandle("numberOfComponents");

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selRedHandle = Selector.GetHandle("red");

	private static readonly IntPtr selGreenHandle = Selector.GetHandle("green");

	private static readonly IntPtr selBlueHandle = Selector.GetHandle("blue");

	private static readonly IntPtr selColorWithCGColor_Handle = Selector.GetHandle("colorWithCGColor:");

	private static readonly IntPtr selColorWithRedGreenBlueAlpha_Handle = Selector.GetHandle("colorWithRed:green:blue:alpha:");

	private static readonly IntPtr selColorWithRedGreenBlue_Handle = Selector.GetHandle("colorWithRed:green:blue:");

	private static readonly IntPtr selColorWithString_Handle = Selector.GetHandle("colorWithString:");

	private static readonly IntPtr selInitWithCGColor_Handle = Selector.GetHandle("initWithCGColor:");

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIColor");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int NumberOfComponents
	{
		[Export("numberOfComponents")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfComponentsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfComponentsHandle);
		}
	}

	public virtual double Alpha
	{
		[Export("alpha")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
	}

	public virtual CGColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColorSpace(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return new CGColorSpace(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
	}

	public virtual double Red
	{
		[Export("red")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRedHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRedHandle);
		}
	}

	public virtual double Green
	{
		[Export("green")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selGreenHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selGreenHandle);
		}
	}

	public virtual double Blue
	{
		[Export("blue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBlueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBlueHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColor(NSCoder coder)
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
	public CIColor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIColor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("colorWithCGColor:")]
	public static CIColor FromCGColor(CGColor c)
	{
		return (CIColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCGColor_Handle, c.Handle));
	}

	[Export("colorWithRed:green:blue:alpha:")]
	public static CIColor FromRgba(double red, double green, double blue, double alpha)
	{
		return (CIColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selColorWithRedGreenBlueAlpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithRed:green:blue:")]
	public static CIColor FromRgb(double red, double green, double blue)
	{
		return (CIColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double(class_ptr, selColorWithRedGreenBlue_Handle, red, green, blue));
	}

	[Export("colorWithString:")]
	public static CIColor FromString(string representation)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		CIColor result = (CIColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithCGColor:")]
	public CIColor(CGColor c)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGColor_Handle, c.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGColor_Handle, c.Handle);
		}
	}

	[Export("stringRepresentation")]
	public virtual string StringRepresentation()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
	}
}
