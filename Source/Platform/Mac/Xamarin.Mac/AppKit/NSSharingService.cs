using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingService", true)]
public class NSSharingService : NSObject
{
	[Register]
	internal class _NSSharingServiceDelegate : NSObject, INSSharingServiceDelegate, INativeObject, IDisposable
	{
		internal NSSharingServiceAnchoringViewForSharingService? createAnchoringView;

		internal EventHandler<NSSharingServiceDidFailToShareItemsEventArgs>? didFailToShareItems;

		internal EventHandler<NSSharingServiceItemsEventArgs>? didShareItems;

		internal NSSharingServiceSourceFrameOnScreenForShareItem? sourceFrameOnScreenForShareItem;

		internal NSSharingServiceSourceWindowForShareItems? sourceWindowForShareItems;

		internal NSSharingServiceTransitionImageForShareItem? transitionImageForShareItem;

		internal EventHandler<NSSharingServiceItemsEventArgs>? willShareItems;

		public _NSSharingServiceDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("anchoringViewForSharingService:showRelativeToRect:preferredEdge:")]
		public NSView CreateAnchoringView(NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
		{
			return createAnchoringView?.Invoke(sharingService, ref positioningRect, ref preferredEdge);
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:didFailToShareItems:error:")]
		public void DidFailToShareItems(NSSharingService sharingService, NSObject[] items, NSError error)
		{
			EventHandler<NSSharingServiceDidFailToShareItemsEventArgs> eventHandler = didFailToShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceDidFailToShareItemsEventArgs e = new NSSharingServiceDidFailToShareItemsEventArgs(items, error);
				eventHandler(sharingService, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:didShareItems:")]
		public void DidShareItems(NSSharingService sharingService, NSObject[] items)
		{
			EventHandler<NSSharingServiceItemsEventArgs> eventHandler = didShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceItemsEventArgs e = new NSSharingServiceItemsEventArgs(items);
				eventHandler(sharingService, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:sourceFrameOnScreenForShareItem:")]
		public CGRect SourceFrameOnScreenForShareItem(NSSharingService sharingService, INSPasteboardWriting item)
		{
			NSSharingServiceSourceFrameOnScreenForShareItem nSSharingServiceSourceFrameOnScreenForShareItem = sourceFrameOnScreenForShareItem;
			if (nSSharingServiceSourceFrameOnScreenForShareItem != null)
			{
				return nSSharingServiceSourceFrameOnScreenForShareItem(sharingService, item);
			}
			throw new Exception("No event handler has been added to the SourceFrameOnScreenForShareItem event.");
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:sourceWindowForShareItems:sharingContentScope:")]
		public NSWindow SourceWindowForShareItems(NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
		{
			return sourceWindowForShareItems?.Invoke(sharingService, items, sharingContentScope);
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:transitionImageForShareItem:contentRect:")]
		public NSImage TransitionImageForShareItem(NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
		{
			return transitionImageForShareItem?.Invoke(sharingService, item, contentRect);
		}

		[Preserve(Conditional = true)]
		[Export("sharingService:willShareItems:")]
		public void WillShareItems(NSSharingService sharingService, NSObject[] items)
		{
			EventHandler<NSSharingServiceItemsEventArgs> eventHandler = willShareItems;
			if (eventHandler != null)
			{
				NSSharingServiceItemsEventArgs e = new NSSharingServiceItemsEventArgs(items);
				eventHandler(sharingService, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountName = "accountName";

	private static readonly IntPtr selAccountNameHandle = Selector.GetHandle("accountName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateImage = "alternateImage";

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachmentFileURLs = "attachmentFileURLs";

	private static readonly IntPtr selAttachmentFileURLsHandle = Selector.GetHandle("attachmentFileURLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformWithItems_ = "canPerformWithItems:";

	private static readonly IntPtr selCanPerformWithItems_Handle = Selector.GetHandle("canPerformWithItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTitle_Image_AlternateImage_Handler_ = "initWithTitle:image:alternateImage:handler:";

	private static readonly IntPtr selInitWithTitle_Image_AlternateImage_Handler_Handle = Selector.GetHandle("initWithTitle:image:alternateImage:handler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuItemTitle = "menuItemTitle";

	private static readonly IntPtr selMenuItemTitleHandle = Selector.GetHandle("menuItemTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageBody = "messageBody";

	private static readonly IntPtr selMessageBodyHandle = Selector.GetHandle("messageBody");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformWithItems_ = "performWithItems:";

	private static readonly IntPtr selPerformWithItems_Handle = Selector.GetHandle("performWithItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPermanentLink = "permanentLink";

	private static readonly IntPtr selPermanentLinkHandle = Selector.GetHandle("permanentLink");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipients = "recipients";

	private static readonly IntPtr selRecipientsHandle = Selector.GetHandle("recipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenuItemTitle_ = "setMenuItemTitle:";

	private static readonly IntPtr selSetMenuItemTitle_Handle = Selector.GetHandle("setMenuItemTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecipients_ = "setRecipients:";

	private static readonly IntPtr selSetRecipients_Handle = Selector.GetHandle("setRecipients:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubject_ = "setSubject:";

	private static readonly IntPtr selSetSubject_Handle = Selector.GetHandle("setSubject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharingServiceNamed_ = "sharingServiceNamed:";

	private static readonly IntPtr selSharingServiceNamed_Handle = Selector.GetHandle("sharingServiceNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharingServicesForItems_ = "sharingServicesForItems:";

	private static readonly IntPtr selSharingServicesForItems_Handle = Selector.GetHandle("sharingServicesForItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubject = "subject";

	private static readonly IntPtr selSubjectHandle = Selector.GetHandle("subject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSharingService");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string AccountName
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("accountName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage AlternateImage
	{
		[Export("alternateImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSUrl[] AttachmentFileUrls
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("attachmentFileURLs", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachmentFileURLsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachmentFileURLsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSSharingServiceDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSSharingServiceDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Image
	{
		[Export("image", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string MenuItemTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("menuItemTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuItemTitleHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setMenuItemTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenuItemTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenuItemTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string MessageBody
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("messageBody")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMessageBodyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessageBodyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSUrl PermanentLink
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("permanentLink", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPermanentLinkHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPermanentLinkHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSObject[] Recipients
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("recipients", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecipientsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecipientsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setRecipients:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecipients_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecipients_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string Subject
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("subject")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubjectHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubjectHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setSubject:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubject_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubject_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSSharingServiceDelegate);

	public NSSharingServiceAnchoringViewForSharingService? CreateAnchoringView
	{
		get
		{
			return EnsureNSSharingServiceDelegate().createAnchoringView;
		}
		set
		{
			EnsureNSSharingServiceDelegate().createAnchoringView = value;
		}
	}

	public NSSharingServiceSourceFrameOnScreenForShareItem? SourceFrameOnScreenForShareItem
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

	public NSSharingServiceSourceWindowForShareItems? SourceWindowForShareItems
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

	public NSSharingServiceTransitionImageForShareItem? TransitionImageForShareItem
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

	public static NSSharingService GetSharingService(NSSharingServiceName service)
	{
		NSString constant = service.GetConstant();
		if (constant == null)
		{
			return null;
		}
		return GetSharingService(constant);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingService()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSharingService(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTitle:image:alternateImage:handler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSSharingService(string title, NSImage image, NSImage alternateImage, [BlockProxy(typeof(Trampolines.NIDNSSharingServiceHandler))] NSSharingServiceHandler handler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSSharingServiceHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithTitle_Image_AlternateImage_Handler_Handle, arg, image.Handle, alternateImage.Handle, (IntPtr)ptr), "initWithTitle:image:alternateImage:handler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithTitle_Image_AlternateImage_Handler_Handle, arg, image.Handle, alternateImage.Handle, (IntPtr)ptr), "initWithTitle:image:alternateImage:handler:");
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("canPerformWithItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPerformWithItems(NSObject[]? items)
	{
		NSApplication.EnsureUIThread();
		NSArray nSArray = ((items == null) ? null : NSArray.FromNSObjects(items));
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanPerformWithItems_Handle, nSArray?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanPerformWithItems_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}

	[Export("sharingServiceNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSharingService GetSharingService(NSString serviceName)
	{
		NSApplication.EnsureUIThread();
		if (serviceName == null)
		{
			throw new ArgumentNullException("serviceName");
		}
		return Runtime.GetNSObject<NSSharingService>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSharingServiceNamed_Handle, serviceName.Handle));
	}

	[Export("performWithItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformWithItems(NSObject[] items)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformWithItems_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformWithItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("sharingServicesForItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	internal virtual _NSSharingServiceDelegate CreateInternalEventDelegateType()
	{
		return new _NSSharingServiceDelegate();
	}

	internal _NSSharingServiceDelegate EnsureNSSharingServiceDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSSharingServiceDelegate nSSharingServiceDelegate = Delegate as _NSSharingServiceDelegate;
		if (nSSharingServiceDelegate == null)
		{
			nSSharingServiceDelegate = (_NSSharingServiceDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSSharingServiceDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
