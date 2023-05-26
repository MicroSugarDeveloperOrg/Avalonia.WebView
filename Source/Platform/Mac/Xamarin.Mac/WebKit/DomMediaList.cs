using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMMediaList", true)]
public class DomMediaList : DomObject, IIndexedContainer<string>, IEnumerable<string>, IEnumerable
{
	private static readonly IntPtr selMediaTextHandle = Selector.GetHandle("mediaText");

	private static readonly IntPtr selSetMediaText_Handle = Selector.GetHandle("setMediaText:");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr selDeleteMedium_Handle = Selector.GetHandle("deleteMedium:");

	private static readonly IntPtr selAppendMedium_Handle = Selector.GetHandle("appendMedium:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMMediaList");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MediaText
	{
		[Export("mediaText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTextHandle));
		}
		[Export("setMediaText:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMediaText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMediaText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	public string this[int index] => GetItem(index);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomMediaList(NSCoder coder)
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
	public DomMediaList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomMediaList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	public virtual string GetItem(int index)
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	[Export("deleteMedium:")]
	public virtual void DeleteMedium(string oldMedium)
	{
		if (oldMedium == null)
		{
			throw new ArgumentNullException("oldMedium");
		}
		IntPtr arg = NSString.CreateNative(oldMedium);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteMedium_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteMedium_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("appendMedium:")]
	public virtual void AppendMedium(string newMedium)
	{
		if (newMedium == null)
		{
			throw new ArgumentNullException("newMedium");
		}
		IntPtr arg = NSString.CreateNative(newMedium);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendMedium_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendMedium_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	public IEnumerator<string> GetEnumerator()
	{
		return new IndexedContainerEnumerator<string>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<string>)this).GetEnumerator();
	}
}
