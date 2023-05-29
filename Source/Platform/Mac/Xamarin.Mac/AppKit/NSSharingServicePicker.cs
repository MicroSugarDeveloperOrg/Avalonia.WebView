using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingServicePicker", true)]
[MountainLion]
public class NSSharingServicePicker : NSObject
{
	[Register]
	private sealed class _NSSharingServicePickerDelegate : NSSharingServicePickerDelegate
	{
		internal NSSharingServicePickerSharingServicesForItems sharingServicesForItems;

		internal NSSharingServicePickerDelegateForSharingService delegateForSharingService;

		internal EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs> didChooseSharingService;

		[Preserve(Conditional = true)]
		public override NSSharingService[] SharingServicesForItems(NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			NSSharingServicePickerSharingServicesForItems nSSharingServicePickerSharingServicesForItems = sharingServicesForItems;
			if (nSSharingServicePickerSharingServicesForItems != null)
			{
				return nSSharingServicePickerSharingServicesForItems(sharingServicePicker, items, proposedServices);
			}
			return proposedServices;
		}

		[Preserve(Conditional = true)]
		public override NSSharingServiceDelegate DelegateForSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			return delegateForSharingService?.Invoke(sharingServicePicker, sharingService);
		}

		[Preserve(Conditional = true)]
		public override void DidChooseSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs> eventHandler = didChooseSharingService;
			if (eventHandler != null)
			{
				NSSharingServicePickerDidChooseSharingServiceEventArgs e = new NSSharingServicePickerDidChooseSharingServiceEventArgs(service);
				eventHandler(sharingServicePicker, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitWithItems_Handle = Selector.GetHandle("initWithItems:");

	private static readonly IntPtr selShowRelativeToRectOfViewPreferredEdge_Handle = Selector.GetHandle("showRelativeToRect:ofView:preferredEdge:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSharingServicePicker");

	private object __mt_WeakDelegate_var;

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

	public NSSharingServicePickerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSharingServicePickerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public NSSharingServicePickerSharingServicesForItems SharingServicesForItems
	{
		get
		{
			return EnsureNSSharingServicePickerDelegate().sharingServicesForItems;
		}
		set
		{
			EnsureNSSharingServicePickerDelegate().sharingServicesForItems = value;
		}
	}

	public NSSharingServicePickerDelegateForSharingService DelegateForSharingService
	{
		get
		{
			return EnsureNSSharingServicePickerDelegate().delegateForSharingService;
		}
		set
		{
			EnsureNSSharingServicePickerDelegate().delegateForSharingService = value;
		}
	}

	public event EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs> DidChooseSharingService
	{
		add
		{
			_NSSharingServicePickerDelegate nSSharingServicePickerDelegate = EnsureNSSharingServicePickerDelegate();
			nSSharingServicePickerDelegate.didChooseSharingService = (EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs>)System.Delegate.Combine(nSSharingServicePickerDelegate.didChooseSharingService, value);
		}
		remove
		{
			_NSSharingServicePickerDelegate nSSharingServicePickerDelegate = EnsureNSSharingServicePickerDelegate();
			nSSharingServicePickerDelegate.didChooseSharingService = (EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs>)System.Delegate.Remove(nSSharingServicePickerDelegate.didChooseSharingService, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServicePicker()
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
	public NSSharingServicePicker(NSCoder coder)
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
	public NSSharingServicePicker(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSharingServicePicker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItems:")]
	public NSSharingServicePicker(NSObject[] items)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItems_Handle, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItems_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("showRelativeToRect:ofView:preferredEdge:")]
	public virtual void ShowRelativeToRect(CGRect rect, NSView view, NSRectEdge preferredEdge)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_int(base.Handle, selShowRelativeToRectOfViewPreferredEdge_Handle, rect, view.Handle, (int)preferredEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_int(base.SuperHandle, selShowRelativeToRectOfViewPreferredEdge_Handle, rect, view.Handle, (int)preferredEdge);
		}
	}

	private _NSSharingServicePickerDelegate EnsureNSSharingServicePickerDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSSharingServicePickerDelegate))
		{
			nSObject = (WeakDelegate = new _NSSharingServicePickerDelegate());
		}
		return (_NSSharingServicePickerDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
