using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIImageAccumulator", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CIImageAccumulator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClear = "clear";

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtent = "extent";

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAccumulatorWithExtent_Format_ = "imageAccumulatorWithExtent:format:";

	private static readonly IntPtr selImageAccumulatorWithExtent_Format_Handle = Selector.GetHandle("imageAccumulatorWithExtent:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAccumulatorWithExtent_Format_ColorSpace_ = "imageAccumulatorWithExtent:format:colorSpace:";

	private static readonly IntPtr selImageAccumulatorWithExtent_Format_ColorSpace_Handle = Selector.GetHandle("imageAccumulatorWithExtent:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithExtent_Format_ = "initWithExtent:format:";

	private static readonly IntPtr selInitWithExtent_Format_Handle = Selector.GetHandle("initWithExtent:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithExtent_Format_ColorSpace_ = "initWithExtent:format:colorSpace:";

	private static readonly IntPtr selInitWithExtent_Format_ColorSpace_Handle = Selector.GetHandle("initWithExtent:format:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_DirtyRect_ = "setImage:dirtyRect:";

	private static readonly IntPtr selSetImage_DirtyRect_Handle = Selector.GetHandle("setImage:dirtyRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIImageAccumulator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int CIImageFormat
	{
		[Export("format")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selFormatHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage Image
	{
		[Export("image")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
		[Export("setImage:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIImageAccumulator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIImageAccumulator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Obsolete("The default initializer does not work in recent iOS version (11b4).", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImageAccumulator()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithExtent:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImageAccumulator(CGRect rectangle, CIFormat format)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_int(base.Handle, selInitWithExtent_Format_Handle, rectangle, (int)format), "initWithExtent:format:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_int(base.SuperHandle, selInitWithExtent_Format_Handle, rectangle, (int)format), "initWithExtent:format:");
		}
	}

	[Obsolete("Use the overload acceping a 'CIFormat' enum instead of an 'int'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImageAccumulator(CGRect rectangle, int ciImageFormat)
		: this(rectangle, (CIFormat)ciImageFormat)
	{
	}

	[Export("initWithExtent:format:colorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImageAccumulator(CGRect extent, CIFormat format, CGColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr(base.Handle, selInitWithExtent_Format_ColorSpace_Handle, extent, (int)format, colorSpace.Handle), "initWithExtent:format:colorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_int_IntPtr(base.SuperHandle, selInitWithExtent_Format_ColorSpace_Handle, extent, (int)format, colorSpace.Handle), "initWithExtent:format:colorSpace:");
		}
	}

	[Export("clear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Clear()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearHandle);
		}
	}

	[Export("imageAccumulatorWithExtent:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImageAccumulator FromRectangle(CGRect rect, CIFormat format)
	{
		return Runtime.GetNSObject<CIImageAccumulator>(Messaging.IntPtr_objc_msgSend_CGRect_int(class_ptr, selImageAccumulatorWithExtent_Format_Handle, rect, (int)format));
	}

	[Obsolete("Use the overload acceping a 'CIFormat' enum instead of an 'int'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImageAccumulator FromRectangle(CGRect rect, int ciImageFormat)
	{
		return FromRectangle(rect, (CIFormat)ciImageFormat);
	}

	[Export("imageAccumulatorWithExtent:format:colorSpace:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImageAccumulator FromRectangle(CGRect extent, CIFormat format, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		return Runtime.GetNSObject<CIImageAccumulator>(Messaging.IntPtr_objc_msgSend_CGRect_int_IntPtr(class_ptr, selImageAccumulatorWithExtent_Format_ColorSpace_Handle, extent, (int)format, colorSpace.Handle));
	}

	[Export("setImage:dirtyRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageDirty(CIImage image, CGRect dirtyRect)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect(base.Handle, selSetImage_DirtyRect_Handle, image.Handle, dirtyRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selSetImage_DirtyRect_Handle, image.Handle, dirtyRect);
		}
	}
}
