using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLOptionsCollection", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlOptionsCollection : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdd_Index_ = "add:index:";

	private static readonly IntPtr selAdd_Index_Handle = Selector.GetHandle("add:index:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamedItem_ = "namedItem:";

	private static readonly IntPtr selNamedItem_Handle = Selector.GetHandle("namedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemove_ = "remove:";

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLength_ = "setLength:";

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLOptionsCollection");

	public DomNode this[string name] => NamedItem(name);

	public DomNode this[uint index] => GetItem(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		[Export("setLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int SelectedIndex
	{
		[Export("selectedIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSelectedIndexHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSelectedIndexHandle);
		}
		[Export("setSelectedIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSelectedIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSelectedIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlOptionsCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlOptionsCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("add:index:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(DomHtmlOptionElement option, uint index)
	{
		if (option == null)
		{
			throw new ArgumentNullException("option");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selAdd_Index_Handle, option.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selAdd_Index_Handle, option.Handle, index);
		}
	}

	[Export("item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode GetItem(uint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selItem_Handle, index));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selItem_Handle, index));
	}

	[Export("namedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode NamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamedItem_Handle, arg)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamedItem_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("remove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(uint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemove_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemove_Handle, index);
		}
	}
}
