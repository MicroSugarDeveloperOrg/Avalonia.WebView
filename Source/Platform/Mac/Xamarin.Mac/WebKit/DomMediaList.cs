using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMMediaList", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomMediaList : DomObject, IIndexedContainer<string>, IEnumerable<string>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendMedium_ = "appendMedium:";

	private static readonly IntPtr selAppendMedium_Handle = Selector.GetHandle("appendMedium:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteMedium_ = "deleteMedium:";

	private static readonly IntPtr selDeleteMedium_Handle = Selector.GetHandle("deleteMedium:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaText = "mediaText";

	private static readonly IntPtr selMediaTextHandle = Selector.GetHandle("mediaText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMediaText_ = "setMediaText:";

	private static readonly IntPtr selSetMediaText_Handle = Selector.GetHandle("setMediaText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMMediaList");

	public string this[int index] => GetItem(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaText
	{
		[Export("mediaText", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTextHandle));
		}
		[Export("setMediaText:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	public IEnumerator<string> GetEnumerator()
	{
		return new IndexedContainerEnumerator<string>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<string>)this).GetEnumerator();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomMediaList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomMediaList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendMedium:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendMedium(string newMedium)
	{
		if (newMedium == null)
		{
			throw new ArgumentNullException("newMedium");
		}
		IntPtr arg = NSString.CreateNative(newMedium);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendMedium_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendMedium_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("deleteMedium:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteMedium(string oldMedium)
	{
		if (oldMedium == null)
		{
			throw new ArgumentNullException("oldMedium");
		}
		IntPtr arg = NSString.CreateNative(oldMedium);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteMedium_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteMedium_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetItem(int index)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}
}
