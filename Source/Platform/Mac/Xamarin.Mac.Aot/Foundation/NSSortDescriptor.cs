using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSSortDescriptor", true)]
public class NSSortDescriptor : NSObject
{
	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	private static readonly IntPtr selAscendingHandle = Selector.GetHandle("ascending");

	private static readonly IntPtr selSelectorHandle = Selector.GetHandle("selector");

	private static readonly IntPtr selReversedSortDescriptorHandle = Selector.GetHandle("reversedSortDescriptor");

	private static readonly IntPtr selInitWithKeyAscending_Handle = Selector.GetHandle("initWithKey:ascending:");

	private static readonly IntPtr selInitWithKeyAscendingSelector_Handle = Selector.GetHandle("initWithKey:ascending:selector:");

	private static readonly IntPtr selCompareObjectToObject_Handle = Selector.GetHandle("compareObject:toObject:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSortDescriptor");

	private object __mt_ReversedSortDescriptor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Key
	{
		[Export("key")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle));
		}
	}

	public virtual bool Ascending
	{
		[Export("ascending")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAscendingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAscendingHandle);
		}
	}

	public virtual Selector Selector
	{
		[Export("selector")]
		get
		{
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectorHandle));
		}
	}

	public virtual NSObject ReversedSortDescriptor
	{
		[Export("reversedSortDescriptor")]
		get
		{
			return (NSObject)(__mt_ReversedSortDescriptor_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedSortDescriptorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedSortDescriptorHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSortDescriptor()
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
	public NSSortDescriptor(NSCoder coder)
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
	public NSSortDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSortDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithKey:ascending:")]
	public NSSortDescriptor(string key, bool ascending)
		: base(NSObjectFlag.Empty)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithKeyAscending_Handle, arg, ascending);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithKeyAscending_Handle, arg, ascending);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithKey:ascending:selector:")]
	public NSSortDescriptor(string key, bool ascending, Selector selector)
		: base(NSObjectFlag.Empty)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selInitWithKeyAscendingSelector_Handle, arg, ascending, selector.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selInitWithKeyAscendingSelector_Handle, arg, ascending, selector.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("compareObject:toObject:")]
	public virtual NSComparisonResult Compare(NSObject object1, NSObject object2)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (object2 == null)
		{
			throw new ArgumentNullException("object2");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompareObjectToObject_Handle, object1.Handle, object2.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompareObjectToObject_Handle, object1.Handle, object2.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ReversedSortDescriptor_var = null;
		}
	}
}
