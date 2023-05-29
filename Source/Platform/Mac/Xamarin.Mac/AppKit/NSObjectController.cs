using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSObjectController", true)]
public class NSObjectController : NSController
{
	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	private static readonly IntPtr selSetContent_Handle = Selector.GetHandle("setContent:");

	private static readonly IntPtr selSelectionHandle = Selector.GetHandle("selection");

	private static readonly IntPtr selSelectedObjectsHandle = Selector.GetHandle("selectedObjects");

	private static readonly IntPtr selSetSelectedObjects_Handle = Selector.GetHandle("setSelectedObjects:");

	private static readonly IntPtr selAutomaticallyPreparesContentHandle = Selector.GetHandle("automaticallyPreparesContent");

	private static readonly IntPtr selSetAutomaticallyPreparesContent_Handle = Selector.GetHandle("setAutomaticallyPreparesContent:");

	private static readonly IntPtr selObjectClassHandle = Selector.GetHandle("objectClass");

	private static readonly IntPtr selSetObjectClass_Handle = Selector.GetHandle("setObjectClass:");

	private static readonly IntPtr selNewObjectHandle = Selector.GetHandle("newObject");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selCanAddHandle = Selector.GetHandle("canAdd");

	private static readonly IntPtr selCanRemoveHandle = Selector.GetHandle("canRemove");

	private static readonly IntPtr selEntityNameHandle = Selector.GetHandle("entityName");

	private static readonly IntPtr selSetEntityName_Handle = Selector.GetHandle("setEntityName:");

	private static readonly IntPtr selFetchPredicateHandle = Selector.GetHandle("fetchPredicate");

	private static readonly IntPtr selSetFetchPredicate_Handle = Selector.GetHandle("setFetchPredicate:");

	private static readonly IntPtr selUsesLazyFetchingHandle = Selector.GetHandle("usesLazyFetching");

	private static readonly IntPtr selSetUsesLazyFetching_Handle = Selector.GetHandle("setUsesLazyFetching:");

	private static readonly IntPtr selInitWithContent_Handle = Selector.GetHandle("initWithContent:");

	private static readonly IntPtr selPrepareContentHandle = Selector.GetHandle("prepareContent");

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	private static readonly IntPtr selFetch_Handle = Selector.GetHandle("fetch:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSObjectController");

	private object __mt_Content_var;

	private object __mt_Selection_var;

	private object __mt_SelectedObjects_var;

	private object __mt_NewObject_var;

	private object __mt_FetchPredicate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject Content
	{
		[Export("content")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Content_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle))));
		}
		[Export("setContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContent_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContent_Handle, value.Handle);
			}
			__mt_Content_var = value;
		}
	}

	public virtual NSObjectController Selection
	{
		[Export("selection")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObjectController)(__mt_Selection_var = ((!IsDirectBinding) ? ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionHandle))) : ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionHandle)))));
		}
	}

	public virtual NSObject[] SelectedObjects
	{
		[Export("selectedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_SelectedObjects_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedObjectsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedObjectsHandle))));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool AutomaticallyPreparesContent
	{
		[Export("automaticallyPreparesContent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyPreparesContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyPreparesContentHandle);
		}
		[Export("setAutomaticallyPreparesContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyPreparesContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyPreparesContent_Handle, value);
			}
		}
	}

	public virtual Class ObjectClass
	{
		[Export("objectClass")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectClassHandle));
		}
		[Export("setObjectClass:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectClass_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectClass_Handle, value.Handle);
			}
		}
	}

	public virtual NSObjectController NewObject
	{
		[Export("newObject")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObjectController)(__mt_NewObject_var = ((!IsDirectBinding) ? ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNewObjectHandle))) : ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNewObjectHandle)))));
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual bool CanAdd
	{
		[Export("canAdd")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanAddHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanAddHandle);
		}
	}

	public virtual bool CanRemove
	{
		[Export("canRemove")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRemoveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRemoveHandle);
		}
	}

	public virtual string EntityName
	{
		[Export("entityName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityNameHandle));
		}
		[Export("setEntityName:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntityName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntityName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSPredicate FetchPredicate
	{
		[Export("fetchPredicate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPredicate)(__mt_FetchPredicate_var = ((!IsDirectBinding) ? ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchPredicateHandle))) : ((NSPredicate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchPredicateHandle)))));
		}
		[Export("setFetchPredicate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchPredicate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchPredicate_Handle, value.Handle);
			}
			__mt_FetchPredicate_var = value;
		}
	}

	public virtual bool UsesLazyFetching
	{
		[Export("usesLazyFetching")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesLazyFetchingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesLazyFetchingHandle);
		}
		[Export("setUsesLazyFetching:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesLazyFetching_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesLazyFetching_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSObjectController()
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
	public NSObjectController(NSCoder coder)
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
	public NSObjectController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSObjectController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContent:")]
	public NSObjectController(NSObject content)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContent_Handle, content.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContent_Handle, content.Handle);
		}
	}

	[Export("prepareContent")]
	public virtual void PrepareContent()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareContentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareContentHandle);
		}
	}

	[Export("addObject:")]
	public virtual void AddObject(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, object1.Handle);
		}
	}

	[Export("removeObject:")]
	public virtual void RemoveObject(NSObject object1)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, object1.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, object1.Handle);
		}
	}

	[Export("setEditable:")]
	public virtual void SetEditable(bool editable)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, editable);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, editable);
		}
	}

	[Export("add:")]
	public virtual void Add(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("remove:")]
	public virtual void Remove(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemove_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemove_Handle, sender.Handle);
		}
	}

	[Export("validateUserInterfaceItem:")]
	public virtual bool ValidateUserInterfaceItem(NSObject item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	[Export("fetch:")]
	public virtual void Fetch(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetch_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetch_Handle, sender.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Content_var = null;
			__mt_Selection_var = null;
			__mt_SelectedObjects_var = null;
			__mt_NewObject_var = null;
			__mt_FetchPredicate_var = null;
		}
	}
}
