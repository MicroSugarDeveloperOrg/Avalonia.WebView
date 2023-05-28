using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLSelectElement", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlSelectElement : DomHtmlElement
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdd_Before_ = "add:before:";

	private static readonly IntPtr selAdd_Before_Handle = Selector.GetHandle("add:before:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutofocus = "autofocus";

	private static readonly IntPtr selAutofocusHandle = Selector.GetHandle("autofocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisabled = "disabled";

	private static readonly IntPtr selDisabledHandle = Selector.GetHandle("disabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForm = "form";

	private static readonly IntPtr selFormHandle = Selector.GetHandle("form");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiple = "multiple";

	private static readonly IntPtr selMultipleHandle = Selector.GetHandle("multiple");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamedItem_ = "namedItem:";

	private static readonly IntPtr selNamedItem_Handle = Selector.GetHandle("namedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemove_ = "remove:";

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutofocus_ = "setAutofocus:";

	private static readonly IntPtr selSetAutofocus_Handle = Selector.GetHandle("setAutofocus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisabled_ = "setDisabled:";

	private static readonly IntPtr selSetDisabled_Handle = Selector.GetHandle("setDisabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMultiple_ = "setMultiple:";

	private static readonly IntPtr selSetMultiple_Handle = Selector.GetHandle("setMultiple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillValidate = "willValidate";

	private static readonly IntPtr selWillValidateHandle = Selector.GetHandle("willValidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLSelectElement");

	public DomNode this[string name] => NamedItem(name);

	public DomNode this[uint index] => GetItem(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autofocus
	{
		[Export("autofocus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutofocusHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutofocusHandle);
		}
		[Export("setAutofocus:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutofocus_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutofocus_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Disabled
	{
		[Export("disabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisabledHandle);
		}
		[Export("setDisabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlFormElement Form
	{
		[Export("form", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlFormElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormHandle));
			}
			return Runtime.GetNSObject<DomHtmlFormElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Length
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
	public virtual bool Multiple
	{
		[Export("multiple")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMultipleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMultipleHandle);
		}
		[Export("setMultiple:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMultiple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMultiple_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlOptionsCollection Options
	{
		[Export("options", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlOptionsCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return Runtime.GetNSObject<DomHtmlOptionsCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
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
	public virtual int Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
		[Export("setValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WillValidate
	{
		[Export("willValidate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWillValidateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWillValidateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlSelectElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlSelectElement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("add:before:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(DomHtmlElement element, DomHtmlElement before)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (before == null)
		{
			throw new ArgumentNullException("before");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAdd_Before_Handle, element.Handle, before.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAdd_Before_Handle, element.Handle, before.Handle);
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
	public virtual void Remove(int index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selRemove_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selRemove_Handle, index);
		}
	}
}
