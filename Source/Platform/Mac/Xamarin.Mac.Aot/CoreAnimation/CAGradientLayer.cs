using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAGradientLayer", true)]
public class CAGradientLayer : CALayer
{
	private static readonly IntPtr selColorsHandle = Selector.GetHandle("colors");

	private static readonly IntPtr selSetColors_Handle = Selector.GetHandle("setColors:");

	private static readonly IntPtr selLocationsHandle = Selector.GetHandle("locations");

	private static readonly IntPtr selSetLocations_Handle = Selector.GetHandle("setLocations:");

	private static readonly IntPtr selStartPointHandle = Selector.GetHandle("startPoint");

	private static readonly IntPtr selSetStartPoint_Handle = Selector.GetHandle("setStartPoint:");

	private static readonly IntPtr selEndPointHandle = Selector.GetHandle("endPoint");

	private static readonly IntPtr selSetEndPoint_Handle = Selector.GetHandle("setEndPoint:");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAGradientLayer");

	private object __mt_Locations_var;

	private static NSString _GradientLayerAxial;

	public CGColor[] Colors
	{
		get
		{
			return NSArray.ArrayFromHandle(_Colors, CreateColor);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr[] array = new IntPtr[value.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = value[i].Handle;
			}
			using NSArray nSArray = NSArray.FromIntPtrs(array);
			_Colors = nSArray.Handle;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	internal virtual IntPtr _Colors
	{
		[Export("colors", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selColorsHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorsHandle);
		}
		[Export("setColors:", ArgumentSemantic.Copy)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColors_Handle, value);
			}
		}
	}

	public virtual NSNumber[] Locations
	{
		[Export("locations", ArgumentSemantic.Copy)]
		get
		{
			return (NSNumber[])(__mt_Locations_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationsHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationsHandle))));
		}
		[Export("setLocations:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocations_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocations_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Locations_var = value;
		}
	}

	public virtual CGPoint StartPoint
	{
		[Export("startPoint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selStartPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selStartPointHandle);
		}
		[Export("setStartPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetStartPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetStartPoint_Handle, value);
			}
		}
	}

	public virtual CGPoint EndPoint
	{
		[Export("endPoint")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selEndPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selEndPointHandle);
		}
		[Export("setEndPoint:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetEndPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetEndPoint_Handle, value);
			}
		}
	}

	public virtual string Type
	{
		[Export("type", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
		[Export("setType:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("kCAGradientLayerAxial", "CoreAnimation")]
	public static NSString GradientLayerAxial
	{
		get
		{
			if (_GradientLayerAxial == null)
			{
				_GradientLayerAxial = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAGradientLayerAxial");
			}
			return _GradientLayerAxial;
		}
	}

	public CGColor CreateColor(IntPtr p)
	{
		return new CGColor(p);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAGradientLayer()
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
	public CAGradientLayer(NSCoder coder)
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
	public CAGradientLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAGradientLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Locations_var = null;
		}
	}
}
