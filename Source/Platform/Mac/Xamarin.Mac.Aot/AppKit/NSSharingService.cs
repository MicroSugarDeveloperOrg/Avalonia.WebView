using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingService", true)]
[MountainLion]
public class NSSharingService : NSObject
{
	[Register]
	private sealed class _NSSharingServiceDelegate : NSSharingServiceDelegate
	{
		internal EventHandler<NSSharingServiceItemsEventArgs> willShareItems;

		internal EventHandler<NSSharingServiceDidFailToShareItemsEventArgs> didFailToShareItems;

		internal EventHandler<NSSharingServiceItemsEventArgs> didShareItems;

		internal NSSharingServiceSourceFrameOnScreenForShareItem sourceFrameOnScreenForShareItem;

		internal NSSharingServiceTransitionImageForShareItem transitionImageForShareItem;

		internal NSSharingServiceSourceWindowForShareItems sourceWindowForShareItems;

		[Preserve(Conditional = true)]
		public override void WillShareItems(NSSharingService sharingService, NSObject[] items)
		{
			EventHandler<NSSharingServiceItemsEventArgs> eventHandler = willShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceItemsEventArgs e = new NSSharingServiceItemsEventArgs(items);
				eventHandler(sharingService, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidFailToShareItems(NSSharingService sharingService, NSObject[] items, NSError error)
		{
			EventHandler<NSSharingServiceDidFailToShareItemsEventArgs> eventHandler = didFailToShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceDidFailToShareItemsEventArgs e = new NSSharingServiceDidFailToShareItemsEventArgs(items, error);
				eventHandler(sharingService, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidShareItems(NSSharingService sharingService, NSObject[] items)
		{
			EventHandler<NSSharingServiceItemsEventArgs> eventHandler = didShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceItemsEventArgs e = new NSSharingServiceItemsEventArgs(items);
				eventHandler(sharingService, e);
			}
		}

		[Preserve(Conditional = true)]
		public override CGRect SourceFrameOnScreenForShareItem(NSSharingService sharingService, NSPasteboardWriting item)
		{
			NSSharingServiceSourceFrameOnScreenForShareItem nSSharingServiceSourceFrameOnScreenForShareItem = sourceFrameOnScreenForShareItem;
			if (nSSharingServiceSourceFrameOnScreenForShareItem != null)
			{
				return nSSharingServiceSourceFrameOnScreenForShareItem(sharingService, item);
			}
			throw new Exception("No event handler has been added to the SourceFrameOnScreenForShareItem event.");
		}

		[Preserve(Conditional = true)]
		public override NSImage TransitionImageForShareItem(NSSharingService sharingService, NSPasteboardWriting item, CGRect contentRect)
		{
			return transitionImageForShareItem?.Invoke(sharingService, item, contentRect);
		}

		[Preserve(Conditional = true)]
		public override NSWindow SourceWindowForShareItems(NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			return sourceWindowForShareItems?.Invoke(sharingService, items, sharingContentScope);
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	private static readonly IntPtr selSharingServicesForItems_Handle = Selector.GetHandle("sharingServicesForItems:");

	private static readonly IntPtr selSharingServiceNamed_Handle = Selector.GetHandle("sharingServiceNamed:");

	private static readonly IntPtr selInitWithTitleImageAlternateImageHandler_Handle = Selector.GetHandle("initWithTitle:image:alternateImage:handler:");

	private static readonly IntPtr selCanPerformWithItems_Handle = Selector.GetHandle("canPerformWithItems:");

	private static readonly IntPtr selPerformWithItems_Handle = Selector.GetHandle("performWithItems:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSharingService");

	private object __mt_WeakDelegate_var;

	private object __mt_Image_var;

	private object __mt_AlternateImage_var;

	private static NSString _NSSharingServiceNamePostOnFacebook;

	private static NSString _NSSharingServiceNamePostOnTwitter;

	private static NSString _NSSharingServiceNamePostOnSinaWeibo;

	private static NSString _NSSharingServiceNameComposeEmail;

	private static NSString _NSSharingServiceNameComposeMessage;

	private static NSString _NSSharingServiceNameSendViaAirDrop;

	private static NSString _NSSharingServiceNameAddToSafariReadingList;

	private static NSString _NSSharingServiceNameAddToIPhoto;

	private static NSString _NSSharingServiceNameAddToAperture;

	private static NSString _NSSharingServiceNameUseAsTwitterProfileImage;

	private static NSString _NSSharingServiceNameUseAsDesktopPicture;

	private static NSString _NSSharingServiceNamePostImageOnFlickr;

	private static NSString _NSSharingServiceNamePostVideoOnVimeo;

	private static NSString _NSSharingServiceNamePostVideoOnYouku;

	private static NSString _NSSharingServiceNamePostVideoOnTudou;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSSharingServiceDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSharingServiceDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	public virtual NSImage Image
	{
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Image_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle)))));
		}
	}

	public virtual NSImage AlternateImage
	{
		[Export("alternateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_AlternateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle)))));
		}
	}

	[Field("NSSharingServiceNamePostOnFacebook", "AppKit")]
	internal static NSString NSSharingServiceNamePostOnFacebook
	{
		get
		{
			if (_NSSharingServiceNamePostOnFacebook == null)
			{
				_NSSharingServiceNamePostOnFacebook = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnFacebook");
			}
			return _NSSharingServiceNamePostOnFacebook;
		}
	}

	[Field("NSSharingServiceNamePostOnTwitter", "AppKit")]
	internal static NSString NSSharingServiceNamePostOnTwitter
	{
		get
		{
			if (_NSSharingServiceNamePostOnTwitter == null)
			{
				_NSSharingServiceNamePostOnTwitter = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnTwitter");
			}
			return _NSSharingServiceNamePostOnTwitter;
		}
	}

	[Field("NSSharingServiceNamePostOnSinaWeibo", "AppKit")]
	internal static NSString NSSharingServiceNamePostOnSinaWeibo
	{
		get
		{
			if (_NSSharingServiceNamePostOnSinaWeibo == null)
			{
				_NSSharingServiceNamePostOnSinaWeibo = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostOnSinaWeibo");
			}
			return _NSSharingServiceNamePostOnSinaWeibo;
		}
	}

	[Field("NSSharingServiceNameComposeEmail", "AppKit")]
	internal static NSString NSSharingServiceNameComposeEmail
	{
		get
		{
			if (_NSSharingServiceNameComposeEmail == null)
			{
				_NSSharingServiceNameComposeEmail = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameComposeEmail");
			}
			return _NSSharingServiceNameComposeEmail;
		}
	}

	[Field("NSSharingServiceNameComposeMessage", "AppKit")]
	internal static NSString NSSharingServiceNameComposeMessage
	{
		get
		{
			if (_NSSharingServiceNameComposeMessage == null)
			{
				_NSSharingServiceNameComposeMessage = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameComposeMessage");
			}
			return _NSSharingServiceNameComposeMessage;
		}
	}

	[Field("NSSharingServiceNameSendViaAirDrop", "AppKit")]
	internal static NSString NSSharingServiceNameSendViaAirDrop
	{
		get
		{
			if (_NSSharingServiceNameSendViaAirDrop == null)
			{
				_NSSharingServiceNameSendViaAirDrop = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameSendViaAirDrop");
			}
			return _NSSharingServiceNameSendViaAirDrop;
		}
	}

	[Field("NSSharingServiceNameAddToSafariReadingList", "AppKit")]
	internal static NSString NSSharingServiceNameAddToSafariReadingList
	{
		get
		{
			if (_NSSharingServiceNameAddToSafariReadingList == null)
			{
				_NSSharingServiceNameAddToSafariReadingList = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToSafariReadingList");
			}
			return _NSSharingServiceNameAddToSafariReadingList;
		}
	}

	[Field("NSSharingServiceNameAddToIPhoto", "AppKit")]
	internal static NSString NSSharingServiceNameAddToIPhoto
	{
		get
		{
			if (_NSSharingServiceNameAddToIPhoto == null)
			{
				_NSSharingServiceNameAddToIPhoto = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToIPhoto");
			}
			return _NSSharingServiceNameAddToIPhoto;
		}
	}

	[Field("NSSharingServiceNameAddToAperture", "AppKit")]
	internal static NSString NSSharingServiceNameAddToAperture
	{
		get
		{
			if (_NSSharingServiceNameAddToAperture == null)
			{
				_NSSharingServiceNameAddToAperture = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameAddToAperture");
			}
			return _NSSharingServiceNameAddToAperture;
		}
	}

	[Field("NSSharingServiceNameUseAsTwitterProfileImage", "AppKit")]
	internal static NSString NSSharingServiceNameUseAsTwitterProfileImage
	{
		get
		{
			if (_NSSharingServiceNameUseAsTwitterProfileImage == null)
			{
				_NSSharingServiceNameUseAsTwitterProfileImage = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameUseAsTwitterProfileImage");
			}
			return _NSSharingServiceNameUseAsTwitterProfileImage;
		}
	}

	[Field("NSSharingServiceNameUseAsDesktopPicture", "AppKit")]
	internal static NSString NSSharingServiceNameUseAsDesktopPicture
	{
		get
		{
			if (_NSSharingServiceNameUseAsDesktopPicture == null)
			{
				_NSSharingServiceNameUseAsDesktopPicture = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNameUseAsDesktopPicture");
			}
			return _NSSharingServiceNameUseAsDesktopPicture;
		}
	}

	[Field("NSSharingServiceNamePostImageOnFlickr", "AppKit")]
	internal static NSString NSSharingServiceNamePostImageOnFlickr
	{
		get
		{
			if (_NSSharingServiceNamePostImageOnFlickr == null)
			{
				_NSSharingServiceNamePostImageOnFlickr = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostImageOnFlickr");
			}
			return _NSSharingServiceNamePostImageOnFlickr;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnVimeo", "AppKit")]
	internal static NSString NSSharingServiceNamePostVideoOnVimeo
	{
		get
		{
			if (_NSSharingServiceNamePostVideoOnVimeo == null)
			{
				_NSSharingServiceNamePostVideoOnVimeo = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnVimeo");
			}
			return _NSSharingServiceNamePostVideoOnVimeo;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnYouku", "AppKit")]
	internal static NSString NSSharingServiceNamePostVideoOnYouku
	{
		get
		{
			if (_NSSharingServiceNamePostVideoOnYouku == null)
			{
				_NSSharingServiceNamePostVideoOnYouku = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnYouku");
			}
			return _NSSharingServiceNamePostVideoOnYouku;
		}
	}

	[Field("NSSharingServiceNamePostVideoOnTudou", "AppKit")]
	internal static NSString NSSharingServiceNamePostVideoOnTudou
	{
		get
		{
			if (_NSSharingServiceNamePostVideoOnTudou == null)
			{
				_NSSharingServiceNamePostVideoOnTudou = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSharingServiceNamePostVideoOnTudou");
			}
			return _NSSharingServiceNamePostVideoOnTudou;
		}
	}

	public NSSharingServiceSourceFrameOnScreenForShareItem SourceFrameOnScreenForShareItem
	{
		get
		{
			return EnsureNSSharingServiceDelegate().sourceFrameOnScreenForShareItem;
		}
		set
		{
			EnsureNSSharingServiceDelegate().sourceFrameOnScreenForShareItem = value;
		}
	}

	public NSSharingServiceTransitionImageForShareItem TransitionImageForShareItem
	{
		get
		{
			return EnsureNSSharingServiceDelegate().transitionImageForShareItem;
		}
		set
		{
			EnsureNSSharingServiceDelegate().transitionImageForShareItem = value;
		}
	}

	public NSSharingServiceSourceWindowForShareItems SourceWindowForShareItems
	{
		get
		{
			return EnsureNSSharingServiceDelegate().sourceWindowForShareItems;
		}
		set
		{
			EnsureNSSharingServiceDelegate().sourceWindowForShareItems = value;
		}
	}

	public event EventHandler<NSSharingServiceItemsEventArgs> WillShareItems
	{
		add
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.willShareItems = (EventHandler<NSSharingServiceItemsEventArgs>)System.Delegate.Combine(nSSharingServiceDelegate.willShareItems, value);
		}
		remove
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.willShareItems = (EventHandler<NSSharingServiceItemsEventArgs>)System.Delegate.Remove(nSSharingServiceDelegate.willShareItems, value);
		}
	}

	public event EventHandler<NSSharingServiceDidFailToShareItemsEventArgs> DidFailToShareItems
	{
		add
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.didFailToShareItems = (EventHandler<NSSharingServiceDidFailToShareItemsEventArgs>)System.Delegate.Combine(nSSharingServiceDelegate.didFailToShareItems, value);
		}
		remove
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.didFailToShareItems = (EventHandler<NSSharingServiceDidFailToShareItemsEventArgs>)System.Delegate.Remove(nSSharingServiceDelegate.didFailToShareItems, value);
		}
	}

	public event EventHandler<NSSharingServiceItemsEventArgs> DidShareItems
	{
		add
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.didShareItems = (EventHandler<NSSharingServiceItemsEventArgs>)System.Delegate.Combine(nSSharingServiceDelegate.didShareItems, value);
		}
		remove
		{
			_NSSharingServiceDelegate nSSharingServiceDelegate = EnsureNSSharingServiceDelegate();
			nSSharingServiceDelegate.didShareItems = (EventHandler<NSSharingServiceItemsEventArgs>)System.Delegate.Remove(nSSharingServiceDelegate.didShareItems, value);
		}
	}

	public static NSSharingService GetSharingService(NSSharingServiceName service)
	{
		return service switch
		{
			NSSharingServiceName.PostOnFacebook => GetSharingService(NSSharingServiceNamePostOnFacebook), 
			NSSharingServiceName.PostOnTwitter => GetSharingService(NSSharingServiceNamePostOnTwitter), 
			NSSharingServiceName.PostOnSinaWeibo => GetSharingService(NSSharingServiceNamePostOnSinaWeibo), 
			NSSharingServiceName.ComposeEmail => GetSharingService(NSSharingServiceNameComposeEmail), 
			NSSharingServiceName.ComposeMessage => GetSharingService(NSSharingServiceNameComposeMessage), 
			NSSharingServiceName.SendViaAirDrop => GetSharingService(NSSharingServiceNameSendViaAirDrop), 
			NSSharingServiceName.AddToSafariReadingList => GetSharingService(NSSharingServiceNameAddToSafariReadingList), 
			NSSharingServiceName.AddToIPhoto => GetSharingService(NSSharingServiceNameAddToIPhoto), 
			NSSharingServiceName.AddToAperture => GetSharingService(NSSharingServiceNameAddToAperture), 
			NSSharingServiceName.UseAsTwitterProfileImage => GetSharingService(NSSharingServiceNameUseAsTwitterProfileImage), 
			NSSharingServiceName.UseAsDesktopPicture => GetSharingService(NSSharingServiceNameUseAsDesktopPicture), 
			NSSharingServiceName.PostImageOnFlickr => GetSharingService(NSSharingServiceNamePostImageOnFlickr), 
			NSSharingServiceName.PostVideoOnVimeo => GetSharingService(NSSharingServiceNamePostVideoOnVimeo), 
			NSSharingServiceName.PostVideoOnYouku => GetSharingService(NSSharingServiceNamePostVideoOnYouku), 
			NSSharingServiceName.PostVideoOnTudou => GetSharingService(NSSharingServiceNamePostVideoOnTudou), 
			_ => null, 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingService()
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
	public NSSharingService(NSCoder coder)
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
	public NSSharingService(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSharingService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sharingServicesForItems:")]
	public static NSSharingService[] SharingServicesForItems(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		NSSharingService[] result = NSArray.ArrayFromHandle<NSSharingService>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSharingServicesForItems_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("sharingServiceNamed:")]
	public static NSSharingService GetSharingService(NSString serviceName)
	{
		NSApplication.EnsureUIThread();
		if (serviceName == null)
		{
			throw new ArgumentNullException("serviceName");
		}
		return (NSSharingService)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSharingServiceNamed_Handle, serviceName.Handle));
	}

	[Export("initWithTitle:image:alternateImage:handler:")]
	public unsafe NSSharingService(string title, NSImage image, NSImage alternateImage, NSSharingServiceHandler handler)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (alternateImage == null)
		{
			throw new ArgumentNullException("alternateImage");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(title);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSSharingServiceHandler.Handler, handler);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTitleImageAlternateImageHandler_Handle, arg, image.Handle, alternateImage.Handle, (IntPtr)ptr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTitleImageAlternateImageHandler_Handle, arg, image.Handle, alternateImage.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("canPerformWithItems:")]
	public virtual bool CanPerformWithItems(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((items == null) ? null : NSArray.FromNSObjects(items));
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanPerformWithItems_Handle, nSArray?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanPerformWithItems_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}

	[Export("performWithItems:")]
	public virtual void PerformWithItems(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformWithItems_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformWithItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	private _NSSharingServiceDelegate EnsureNSSharingServiceDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSSharingServiceDelegate))
		{
			nSObject = (WeakDelegate = new _NSSharingServiceDelegate());
		}
		return (_NSSharingServiceDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_Image_var = null;
			__mt_AlternateImage_var = null;
		}
	}
}
