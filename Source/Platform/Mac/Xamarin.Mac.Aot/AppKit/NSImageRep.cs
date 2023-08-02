using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSImageRep", true)]
public class NSImageRep : NSObject
{
	private static readonly IntPtr selHasAlphaHandle = Selector.GetHandle("hasAlpha");

	private static readonly IntPtr selImageUnfilteredFileTypesHandle = Selector.GetHandle("imageUnfilteredFileTypes");

	private static readonly IntPtr selImageUnfilteredPasteboardTypesHandle = Selector.GetHandle("imageUnfilteredPasteboardTypes");

	private static readonly IntPtr selImageFileTypesHandle = Selector.GetHandle("imageFileTypes");

	private static readonly IntPtr selImagePasteboardTypesHandle = Selector.GetHandle("imagePasteboardTypes");

	private static readonly IntPtr selImageUnfilteredTypesHandle = Selector.GetHandle("imageUnfilteredTypes");

	private static readonly IntPtr selImageTypesHandle = Selector.GetHandle("imageTypes");

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	private static readonly IntPtr selColorSpaceNameHandle = Selector.GetHandle("colorSpaceName");

	private static readonly IntPtr selSetColorSpaceName_Handle = Selector.GetHandle("setColorSpaceName:");

	private static readonly IntPtr selBitsPerSampleHandle = Selector.GetHandle("bitsPerSample");

	private static readonly IntPtr selSetBitsPerSample_Handle = Selector.GetHandle("setBitsPerSample:");

	private static readonly IntPtr selPixelsWideHandle = Selector.GetHandle("pixelsWide");

	private static readonly IntPtr selSetPixelsWide_Handle = Selector.GetHandle("setPixelsWide:");

	private static readonly IntPtr selPixelsHighHandle = Selector.GetHandle("pixelsHigh");

	private static readonly IntPtr selSetPixelsHigh_Handle = Selector.GetHandle("setPixelsHigh:");

	private static readonly IntPtr selDrawHandle = Selector.GetHandle("draw");

	private static readonly IntPtr selDrawAtPoint_Handle = Selector.GetHandle("drawAtPoint:");

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	private static readonly IntPtr selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:respectFlipped:hints:");

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	private static readonly IntPtr selRegisterImageRepClass_Handle = Selector.GetHandle("registerImageRepClass:");

	private static readonly IntPtr selUnregisterImageRepClass_Handle = Selector.GetHandle("unregisterImageRepClass:");

	private static readonly IntPtr selImageRepClassForFileType_Handle = Selector.GetHandle("imageRepClassForFileType:");

	private static readonly IntPtr selImageRepClassForPasteboardType_Handle = Selector.GetHandle("imageRepClassForPasteboardType:");

	private static readonly IntPtr selImageRepClassForType_Handle = Selector.GetHandle("imageRepClassForType:");

	private static readonly IntPtr selImageRepClassForData_Handle = Selector.GetHandle("imageRepClassForData:");

	private static readonly IntPtr selCanInitWithData_Handle = Selector.GetHandle("canInitWithData:");

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	private static readonly IntPtr selImageRepsWithContentsOfFile_Handle = Selector.GetHandle("imageRepsWithContentsOfFile:");

	private static readonly IntPtr selImageRepWithContentsOfFile_Handle = Selector.GetHandle("imageRepWithContentsOfFile:");

	private static readonly IntPtr selImageRepsWithContentsOfURL_Handle = Selector.GetHandle("imageRepsWithContentsOfURL:");

	private static readonly IntPtr selImageRepWithContentsOfURL_Handle = Selector.GetHandle("imageRepWithContentsOfURL:");

	private static readonly IntPtr selImageRepsWithPasteboard_Handle = Selector.GetHandle("imageRepsWithPasteboard:");

	private static readonly IntPtr selImageRepWithPasteboard_Handle = Selector.GetHandle("imageRepWithPasteboard:");

	private static readonly IntPtr selCGImageForProposedRectContextHints_Handle = Selector.GetHandle("CGImageForProposedRect:context:hints:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSImageRep");

	public CGImage CGImage
	{
		get
		{
			CGRect proposedDestRect = CGRect.Empty;
			return AsCGImage(ref proposedDestRect, null, null);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool HasAlpha
	{
		[Export("hasAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAlphaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAlphaHandle);
		}
	}

	public static string[] ImageUnfilteredFileTypes
	{
		[Export("imageUnfilteredFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredFileTypesHandle));
		}
	}

	public static string[] ImageUnfilteredPasteboardTypes
	{
		[Export("imageUnfilteredPasteboardTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredPasteboardTypesHandle));
		}
	}

	public static string[] ImageFileTypes
	{
		[Export("imageFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageFileTypesHandle));
		}
	}

	public static string[] ImagePasteboardTypes
	{
		[Export("imagePasteboardTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImagePasteboardTypesHandle));
		}
	}

	public static string[] ImageUnfilteredTypes
	{
		[Export("imageUnfilteredTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredTypesHandle));
		}
	}

	public static string[] ImageTypes
	{
		[Export("imageTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageTypesHandle));
		}
	}

	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	public virtual bool Opaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Export("setOpaque:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	public virtual string ColorSpaceName
	{
		[Export("colorSpaceName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceNameHandle));
		}
		[Export("setColorSpaceName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorSpaceName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorSpaceName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual long BitsPerSample
	{
		[Export("bitsPerSample")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selBitsPerSampleHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBitsPerSampleHandle);
		}
		[Export("setBitsPerSample:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBitsPerSample_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBitsPerSample_Handle, value);
			}
		}
	}

	public virtual long PixelsWide
	{
		[Export("pixelsWide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selPixelsWideHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPixelsWideHandle);
		}
		[Export("setPixelsWide:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPixelsWide_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPixelsWide_Handle, value);
			}
		}
	}

	public virtual long PixelsHigh
	{
		[Export("pixelsHigh")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selPixelsHighHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPixelsHighHandle);
		}
		[Export("setPixelsHigh:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPixelsHigh_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPixelsHigh_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImageRep()
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
	public NSImageRep(NSCoder coder)
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
	public NSImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("draw")]
	public virtual bool Draw()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawHandle);
	}

	[Export("drawAtPoint:")]
	public virtual bool DrawAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selDrawAtPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selDrawAtPoint_Handle, point);
	}

	[Export("drawInRect:")]
	public virtual bool DrawInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
	}

	[Export("drawInRect:fromRect:operation:fraction:respectFlipped:hints:")]
	public virtual bool DrawInRect(CGRect dstSpacePortionRect, CGRect srcSpacePortionRect, NSCompositingOperation op, double requestedAlpha, bool respectContextIsFlipped, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect_CGRect_UInt64_Double_bool_IntPtr(base.Handle, selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect_CGRect_UInt64_Double_bool_IntPtr(base.SuperHandle, selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
	}

	[Export("setAlpha:")]
	public virtual void SetAlpha(bool alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetAlpha_Handle, alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlpha_Handle, alpha);
		}
	}

	[Export("registerImageRepClass:")]
	public static void RegisterImageRepClass(Class imageRepClass)
	{
		NSApplication.EnsureUIThread();
		if (imageRepClass == null)
		{
			throw new ArgumentNullException("imageRepClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRegisterImageRepClass_Handle, imageRepClass.Handle);
	}

	[Export("unregisterImageRepClass:")]
	public static void UnregisterImageRepClass(Class imageRepClass)
	{
		NSApplication.EnsureUIThread();
		if (imageRepClass == null)
		{
			throw new ArgumentNullException("imageRepClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selUnregisterImageRepClass_Handle, imageRepClass.Handle);
	}

	[Export("imageRepClassForFileType:")]
	public static Class ImageRepClassForFileType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		Class result = new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForFileType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageRepClassForPasteboardType:")]
	public static Class ImageRepClassForPasteboardType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		Class result = new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForPasteboardType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageRepClassForType:")]
	public static Class ImageRepClassForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		Class result = new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageRepClassForData:")]
	public static Class ImageRepClassForData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForData_Handle, data.Handle));
	}

	[Export("canInitWithData:")]
	public static bool CanInitWithData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithData_Handle, data.Handle);
	}

	[Export("canInitWithPasteboard:")]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("imageRepsWithContentsOfFile:")]
	public static NSImageRep[] ImageRepsFromFile(string filename)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		NSImageRep[] result = NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageRepWithContentsOfFile:")]
	public static NSImageRep ImageRepFromFile(string filename)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		NSImageRep result = (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("imageRepsWithContentsOfURL:")]
	public static NSImageRep[] ImageRepsFromUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithContentsOfURL_Handle, url.Handle));
	}

	[Export("imageRepWithContentsOfURL:")]
	public static NSImageRep ImageRepFromUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithContentsOfURL_Handle, url.Handle));
	}

	[Export("imageRepsWithPasteboard:")]
	public static NSImageRep[] ImageRepsFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithPasteboard_Handle, pasteboard.Handle));
	}

	[Export("imageRepWithPasteboard:")]
	public static NSImageRep ImageRepFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithPasteboard_Handle, pasteboard.Handle));
	}

	[Export("CGImageForProposedRect:context:hints:")]
	public virtual CGImage AsCGImage(ref CGRect proposedDestRect, NSGraphicsContext context, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return new CGImage(Messaging.IntPtr_objc_msgSend_out_CGRect_IntPtr_IntPtr(base.Handle, selCGImageForProposedRectContextHints_Handle, out proposedDestRect, context?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		}
		return new CGImage(Messaging.IntPtr_objc_msgSendSuper_out_CGRect_IntPtr_IntPtr(base.SuperHandle, selCGImageForProposedRectContextHints_Handle, out proposedDestRect, context?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
	}
}
