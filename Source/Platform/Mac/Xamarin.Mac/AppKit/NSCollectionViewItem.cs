using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewItem", true)]
public class NSCollectionViewItem : NSViewController
{
	private static readonly IntPtr selCollectionViewHandle = Selector.GetHandle("collectionView");

	private static readonly IntPtr selIsSelectedHandle = Selector.GetHandle("isSelected");

	private static readonly IntPtr selSetSelected_Handle = Selector.GetHandle("setSelected:");

	private static readonly IntPtr selImageViewHandle = Selector.GetHandle("imageView");

	private static readonly IntPtr selSetImageView_Handle = Selector.GetHandle("setImageView:");

	private static readonly IntPtr selTextFieldHandle = Selector.GetHandle("textField");

	private static readonly IntPtr selSetTextField_Handle = Selector.GetHandle("setTextField:");

	private static readonly IntPtr selDraggingImageComponentsHandle = Selector.GetHandle("draggingImageComponents");

	private static readonly IntPtr selInitWithNibNameBundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCollectionViewItem");

	private object __mt_CollectionView_var;

	private object __mt_ImageView_var;

	private object __mt_TextField_var;

	private object __mt_DraggingImageComponents_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSCollectionView CollectionView
	{
		[Export("collectionView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCollectionView)(__mt_CollectionView_var = ((!IsDirectBinding) ? ((NSCollectionView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionViewHandle))) : ((NSCollectionView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionViewHandle)))));
		}
	}

	public virtual bool Selected
	{
		[Export("isSelected")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectedHandle);
		}
		[Export("setSelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelected_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelected_Handle, value);
			}
		}
	}

	public virtual NSImageView ImageView
	{
		[Export("imageView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImageView)(__mt_ImageView_var = ((!IsDirectBinding) ? ((NSImageView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageViewHandle))) : ((NSImageView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageViewHandle)))));
		}
		[Export("setImageView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageView_Handle, value.Handle);
			}
			__mt_ImageView_var = value;
		}
	}

	public virtual NSTextField TextField
	{
		[Export("textField")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextField)(__mt_TextField_var = ((!IsDirectBinding) ? ((NSTextField)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextFieldHandle))) : ((NSTextField)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextFieldHandle)))));
		}
		[Export("setTextField:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextField_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextField_Handle, value.Handle);
			}
			__mt_TextField_var = value;
		}
	}

	public virtual NSDraggingImageComponent[] DraggingImageComponents
	{
		[Export("draggingImageComponents")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDraggingImageComponent[])(__mt_DraggingImageComponents_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingImageComponentsHandle)) : NSArray.ArrayFromHandle<NSDraggingImageComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingImageComponentsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewItem()
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
	public NSCollectionViewItem(NSCoder coder)
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
	public NSCollectionViewItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCollectionViewItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	public NSCollectionViewItem(string nibNameOrNull, NSBundle nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibNameBundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibNameBundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CollectionView_var = null;
			__mt_ImageView_var = null;
			__mt_TextField_var = null;
			__mt_DraggingImageComponents_var = null;
		}
	}
}
