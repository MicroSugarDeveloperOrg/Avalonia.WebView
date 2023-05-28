using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSImageRep", true)]
public class NSImageRep : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	public static class Notifications
	{
		public static NSObject ObserveRegistryDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RegistryDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRegistryDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RegistryDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImageForProposedRect_Context_Hints_ = "CGImageForProposedRect:context:hints:";

	private static readonly IntPtr selCGImageForProposedRect_Context_Hints_Handle = Selector.GetHandle("CGImageForProposedRect:context:hints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitsPerSample = "bitsPerSample";

	private static readonly IntPtr selBitsPerSampleHandle = Selector.GetHandle("bitsPerSample");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithData_ = "canInitWithData:";

	private static readonly IntPtr selCanInitWithData_Handle = Selector.GetHandle("canInitWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithPasteboard_ = "canInitWithPasteboard:";

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpaceName = "colorSpaceName";

	private static readonly IntPtr selColorSpaceNameHandle = Selector.GetHandle("colorSpaceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraw = "draw";

	private static readonly IntPtr selDrawHandle = Selector.GetHandle("draw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_ = "drawAtPoint:";

	private static readonly IntPtr selDrawAtPoint_Handle = Selector.GetHandle("drawAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_ = "drawInRect:";

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_ = "drawInRect:fromRect:operation:fraction:respectFlipped:hints:";

	private static readonly IntPtr selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:respectFlipped:hints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAlpha = "hasAlpha";

	private static readonly IntPtr selHasAlphaHandle = Selector.GetHandle("hasAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageFileTypes = "imageFileTypes";

	private static readonly IntPtr selImageFileTypesHandle = Selector.GetHandle("imageFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImagePasteboardTypes = "imagePasteboardTypes";

	private static readonly IntPtr selImagePasteboardTypesHandle = Selector.GetHandle("imagePasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepClassForData_ = "imageRepClassForData:";

	private static readonly IntPtr selImageRepClassForData_Handle = Selector.GetHandle("imageRepClassForData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepClassForFileType_ = "imageRepClassForFileType:";

	private static readonly IntPtr selImageRepClassForFileType_Handle = Selector.GetHandle("imageRepClassForFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepClassForPasteboardType_ = "imageRepClassForPasteboardType:";

	private static readonly IntPtr selImageRepClassForPasteboardType_Handle = Selector.GetHandle("imageRepClassForPasteboardType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepClassForType_ = "imageRepClassForType:";

	private static readonly IntPtr selImageRepClassForType_Handle = Selector.GetHandle("imageRepClassForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepWithContentsOfFile_ = "imageRepWithContentsOfFile:";

	private static readonly IntPtr selImageRepWithContentsOfFile_Handle = Selector.GetHandle("imageRepWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepWithContentsOfURL_ = "imageRepWithContentsOfURL:";

	private static readonly IntPtr selImageRepWithContentsOfURL_Handle = Selector.GetHandle("imageRepWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepWithPasteboard_ = "imageRepWithPasteboard:";

	private static readonly IntPtr selImageRepWithPasteboard_Handle = Selector.GetHandle("imageRepWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepsWithContentsOfFile_ = "imageRepsWithContentsOfFile:";

	private static readonly IntPtr selImageRepsWithContentsOfFile_Handle = Selector.GetHandle("imageRepsWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepsWithContentsOfURL_ = "imageRepsWithContentsOfURL:";

	private static readonly IntPtr selImageRepsWithContentsOfURL_Handle = Selector.GetHandle("imageRepsWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageRepsWithPasteboard_ = "imageRepsWithPasteboard:";

	private static readonly IntPtr selImageRepsWithPasteboard_Handle = Selector.GetHandle("imageRepsWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageTypes = "imageTypes";

	private static readonly IntPtr selImageTypesHandle = Selector.GetHandle("imageTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredFileTypes = "imageUnfilteredFileTypes";

	private static readonly IntPtr selImageUnfilteredFileTypesHandle = Selector.GetHandle("imageUnfilteredFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredPasteboardTypes = "imageUnfilteredPasteboardTypes";

	private static readonly IntPtr selImageUnfilteredPasteboardTypesHandle = Selector.GetHandle("imageUnfilteredPasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredTypes = "imageUnfilteredTypes";

	private static readonly IntPtr selImageUnfilteredTypesHandle = Selector.GetHandle("imageUnfilteredTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutDirection = "layoutDirection";

	private static readonly IntPtr selLayoutDirectionHandle = Selector.GetHandle("layoutDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelsHigh = "pixelsHigh";

	private static readonly IntPtr selPixelsHighHandle = Selector.GetHandle("pixelsHigh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelsWide = "pixelsWide";

	private static readonly IntPtr selPixelsWideHandle = Selector.GetHandle("pixelsWide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterImageRepClass_ = "registerImageRepClass:";

	private static readonly IntPtr selRegisterImageRepClass_Handle = Selector.GetHandle("registerImageRepClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredImageRepClasses = "registeredImageRepClasses";

	private static readonly IntPtr selRegisteredImageRepClassesHandle = Selector.GetHandle("registeredImageRepClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBitsPerSample_ = "setBitsPerSample:";

	private static readonly IntPtr selSetBitsPerSample_Handle = Selector.GetHandle("setBitsPerSample:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorSpaceName_ = "setColorSpaceName:";

	private static readonly IntPtr selSetColorSpaceName_Handle = Selector.GetHandle("setColorSpaceName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutDirection_ = "setLayoutDirection:";

	private static readonly IntPtr selSetLayoutDirection_Handle = Selector.GetHandle("setLayoutDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpaque_ = "setOpaque:";

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelsHigh_ = "setPixelsHigh:";

	private static readonly IntPtr selSetPixelsHigh_Handle = Selector.GetHandle("setPixelsHigh:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelsWide_ = "setPixelsWide:";

	private static readonly IntPtr selSetPixelsWide_Handle = Selector.GetHandle("setPixelsWide:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterImageRepClass_ = "unregisterImageRepClass:";

	private static readonly IntPtr selUnregisterImageRepClass_Handle = Selector.GetHandle("unregisterImageRepClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSImageRep");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RegistryDidChangeNotification;

	public CGImage CGImage
	{
		get
		{
			CGRect proposedDestRect = CGRect.Empty;
			return AsCGImage(ref proposedDestRect, null, null);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BitsPerSample
	{
		[Export("bitsPerSample")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBitsPerSampleHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBitsPerSampleHandle);
		}
		[Export("setBitsPerSample:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetBitsPerSample_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetBitsPerSample_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Type' and 'NSColorType' instead.")]
	public virtual string ColorSpaceName
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Type' and 'NSColorType' instead.")]
		[Export("colorSpaceName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceNameHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Type' and 'NSColorType' instead.")]
		[Export("setColorSpaceName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasAlpha
	{
		[Export("hasAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAlphaHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAlphaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImageFileTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imageFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImagePasteboardTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imagePasteboardTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImagePasteboardTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ImageTypes
	{
		[Export("imageTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImageUnfilteredFileTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imageUnfilteredFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImageUnfilteredPasteboardTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imageUnfilteredPasteboardTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredPasteboardTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ImageUnfilteredTypes
	{
		[Export("imageUnfilteredTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSImageLayoutDirection LayoutDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("layoutDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSImageLayoutDirection)Messaging.Int64_objc_msgSend(base.Handle, selLayoutDirectionHandle);
			}
			return (NSImageLayoutDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayoutDirectionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setLayoutDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayoutDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayoutDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Opaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Export("setOpaque:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PixelsHigh
	{
		[Export("pixelsHigh")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPixelsHighHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPixelsHighHandle);
		}
		[Export("setPixelsHigh:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPixelsHigh_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPixelsHigh_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PixelsWide
	{
		[Export("pixelsWide")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPixelsWideHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPixelsWideHandle);
		}
		[Export("setPixelsWide:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPixelsWide_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPixelsWide_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[Field("NSImageRepRegistryDidChangeNotification", "AppKit")]
	[Advice("Use NSImageRep.Notifications.ObserveRegistryDidChange helper method instead.")]
	public static NSString RegistryDidChangeNotification
	{
		get
		{
			if (_RegistryDidChangeNotification == null)
			{
				_RegistryDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageRepRegistryDidChangeNotification");
			}
			return _RegistryDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImageRep()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSImageRep(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("CGImageForProposedRect:context:hints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage AsCGImage(ref CGRect proposedDestRect, NSGraphicsContext? context, NSDictionary? hints)
	{
		NSApplication.EnsureUIThread();
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_ref_CGRect_IntPtr_IntPtr(base.SuperHandle, selCGImageForProposedRect_Context_Hints_Handle, ref proposedDestRect, context?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_ref_CGRect_IntPtr_IntPtr(base.Handle, selCGImageForProposedRect_Context_Hints_Handle, ref proposedDestRect, context?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
	}

	[Export("canInitWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("draw")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Draw()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selDrawHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawHandle);
	}

	[Export("drawAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawAtPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selDrawAtPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selDrawAtPoint_Handle, point);
	}

	[Export("drawInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
	}

	[Export("drawInRect:fromRect:operation:fraction:respectFlipped:hints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawInRect(CGRect dstSpacePortionRect, CGRect srcSpacePortionRect, NSCompositingOperation op, nfloat requestedAlpha, bool respectContextIsFlipped, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (hints == null)
		{
			throw new ArgumentNullException("hints");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect_CGRect_UInt64_nfloat_bool_IntPtr(base.Handle, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect_CGRect_UInt64_nfloat_bool_IntPtr(base.SuperHandle, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints.Handle);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("registeredImageRepClasses")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class[] GetRegisteredImageRepClasses()
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<Class>(Messaging.IntPtr_objc_msgSend(class_ptr, selRegisteredImageRepClassesHandle));
	}

	[Export("imageRepClassForData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class ImageRepClassForData(NSData data)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForData_Handle, data.Handle);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("imageRepClassForFileType:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class ImageRepClassForFileType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForFileType_Handle, arg);
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("imageRepClassForPasteboardType:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class ImageRepClassForPasteboardType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForPasteboardType_Handle, arg);
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("imageRepClassForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class ImageRepClassForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		IntPtr intPtr = Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepClassForType_Handle, arg);
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("imageRepWithContentsOfFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep ImageRepFromFile(string filename)
	{
		NSApplication.EnsureUIThread();
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		NSImageRep nSObject = Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("imageRepWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep ImageRepFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithPasteboard_Handle, pasteboard.Handle));
	}

	[Export("imageRepWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep ImageRepFromUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithContentsOfURL_Handle, url.Handle));
	}

	[Export("imageRepsWithContentsOfFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("imageRepsWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep[] ImageRepsFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithPasteboard_Handle, pasteboard.Handle));
	}

	[Export("imageRepsWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImageRep[] ImageRepsFromUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepsWithContentsOfURL_Handle, url.Handle));
	}

	[Export("registerImageRepClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterImageRepClass(Class imageRepClass)
	{
		NSApplication.EnsureUIThread();
		if (imageRepClass == null)
		{
			throw new ArgumentNullException("imageRepClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRegisterImageRepClass_Handle, imageRepClass.Handle);
	}

	[Export("setAlpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAlpha(bool alpha)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetAlpha_Handle, alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlpha_Handle, alpha);
		}
	}

	[Export("unregisterImageRepClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnregisterImageRepClass(Class imageRepClass)
	{
		NSApplication.EnsureUIThread();
		if (imageRepClass == null)
		{
			throw new ArgumentNullException("imageRepClass");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selUnregisterImageRepClass_Handle, imageRepClass.Handle);
	}
}
