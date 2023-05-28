using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSharingServicePicker", true)]
public class NSSharingServicePicker : NSObject
{
	[Register]
	internal class _NSSharingServicePickerDelegate : NSObject, INSSharingServicePickerDelegate, INativeObject, IDisposable
	{
		internal NSSharingServicePickerDelegateForSharingService? delegateForSharingService;

		internal EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs>? didChooseSharingService;

		internal NSSharingServicePickerSharingServicesForItems? sharingServicesForItems;

		public _NSSharingServicePickerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("sharingServicePicker:delegateForSharingService:")]
		public INSSharingServiceDelegate DelegateForSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
		{
			return delegateForSharingService?.Invoke(sharingServicePicker, sharingService);
		}

		[Preserve(Conditional = true)]
		[Export("sharingServicePicker:didChooseSharingService:")]
		public void DidChooseSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService service)
		{
			EventHandler<NSSharingServicePickerDidChooseSharingServiceEventArgs> eventHandler = didChooseSharingService;
			if (eventHandler != null)
			{
				NSSharingServicePickerDidChooseSharingServiceEventArgs e = new NSSharingServicePickerDidChooseSharingServiceEventArgs(service);
				eventHandler(sharingServicePicker, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
		public NSSharingService[] SharingServicesForItems(NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
		{
			NSSharingServicePickerSharingServicesForItems nSSharingServicePickerSharingServicesForItems = sharingServicesForItems;
			if (nSSharingServicePickerSharingServicesForItems != null)
			{
				return nSSharingServicePickerSharingServicesForItems(sharingServicePicker, items, proposedServices);
			}
			return proposedServices;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItems_ = "initWithItems:";

	private static readonly IntPtr selInitWithItems_Handle = Selector.GetHandle("initWithItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowRelativeToRect_OfView_PreferredEdge_ = "showRelativeToRect:ofView:preferredEdge:";

	private static readonly IntPtr selShowRelativeToRect_OfView_PreferredEdge_Handle = Selector.GetHandle("showRelativeToRect:ofView:preferredEdge:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSharingServicePicker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSSharingServicePickerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as INSSharingServicePickerDelegate;
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSSharingServicePickerDelegate);

	public NSSharingServicePickerDelegateForSharingService? DelegateForSharingService
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

	public NSSharingServicePickerSharingServicesForItems? SharingServicesForItems
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServicePicker()
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
	protected NSSharingServicePicker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingServicePicker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItems:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSharingServicePicker(NSObject[] items)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithItems_Handle, nSArray.Handle), "initWithItems:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithItems_Handle, nSArray.Handle), "initWithItems:");
		}
		nSArray.Dispose();
	}

	[Export("showRelativeToRect:ofView:preferredEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowRelativeToRect(CGRect rect, NSView view, NSRectEdge preferredEdge)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_UInt64(base.Handle, selShowRelativeToRect_OfView_PreferredEdge_Handle, rect, view.Handle, (ulong)preferredEdge);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_UInt64(base.SuperHandle, selShowRelativeToRect_OfView_PreferredEdge_Handle, rect, view.Handle, (ulong)preferredEdge);
		}
	}

	internal virtual _NSSharingServicePickerDelegate CreateInternalEventDelegateType()
	{
		return new _NSSharingServicePickerDelegate();
	}

	internal _NSSharingServicePickerDelegate EnsureNSSharingServicePickerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSSharingServicePickerDelegate nSSharingServicePickerDelegate = Delegate as _NSSharingServicePickerDelegate;
		if (nSSharingServicePickerDelegate == null)
		{
			nSSharingServicePickerDelegate = (_NSSharingServicePickerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSSharingServicePickerDelegate;
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
