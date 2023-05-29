using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLInputElement", true)]
public class DomHtmlInputElement : DomHtmlElement
{
	private static readonly IntPtr selAcceptHandle = Selector.GetHandle("accept");

	private static readonly IntPtr selSetAccept_Handle = Selector.GetHandle("setAccept:");

	private static readonly IntPtr selAltHandle = Selector.GetHandle("alt");

	private static readonly IntPtr selSetAlt_Handle = Selector.GetHandle("setAlt:");

	private static readonly IntPtr selAutofocusHandle = Selector.GetHandle("autofocus");

	private static readonly IntPtr selSetAutofocus_Handle = Selector.GetHandle("setAutofocus:");

	private static readonly IntPtr selDefaultCheckedHandle = Selector.GetHandle("defaultChecked");

	private static readonly IntPtr selSetDefaultChecked_Handle = Selector.GetHandle("setDefaultChecked:");

	private static readonly IntPtr selCheckedHandle = Selector.GetHandle("checked");

	private static readonly IntPtr selSetChecked_Handle = Selector.GetHandle("setChecked:");

	private static readonly IntPtr selDisabledHandle = Selector.GetHandle("disabled");

	private static readonly IntPtr selSetDisabled_Handle = Selector.GetHandle("setDisabled:");

	private static readonly IntPtr selIndeterminateHandle = Selector.GetHandle("indeterminate");

	private static readonly IntPtr selSetIndeterminate_Handle = Selector.GetHandle("setIndeterminate:");

	private static readonly IntPtr selMaxLengthHandle = Selector.GetHandle("maxLength");

	private static readonly IntPtr selSetMaxLength_Handle = Selector.GetHandle("setMaxLength:");

	private static readonly IntPtr selMultipleHandle = Selector.GetHandle("multiple");

	private static readonly IntPtr selSetMultiple_Handle = Selector.GetHandle("setMultiple:");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selReadOnlyHandle = Selector.GetHandle("readOnly");

	private static readonly IntPtr selSetReadOnly_Handle = Selector.GetHandle("setReadOnly:");

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	private static readonly IntPtr selSrcHandle = Selector.GetHandle("src");

	private static readonly IntPtr selSetSrc_Handle = Selector.GetHandle("setSrc:");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	private static readonly IntPtr selDefaultValueHandle = Selector.GetHandle("defaultValue");

	private static readonly IntPtr selSetDefaultValue_Handle = Selector.GetHandle("setDefaultValue:");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	private static readonly IntPtr selWillValidateHandle = Selector.GetHandle("willValidate");

	private static readonly IntPtr selSelectionStartHandle = Selector.GetHandle("selectionStart");

	private static readonly IntPtr selSetSelectionStart_Handle = Selector.GetHandle("setSelectionStart:");

	private static readonly IntPtr selSelectionEndHandle = Selector.GetHandle("selectionEnd");

	private static readonly IntPtr selSetSelectionEnd_Handle = Selector.GetHandle("setSelectionEnd:");

	private static readonly IntPtr selAlignHandle = Selector.GetHandle("align");

	private static readonly IntPtr selSetAlign_Handle = Selector.GetHandle("setAlign:");

	private static readonly IntPtr selUseMapHandle = Selector.GetHandle("useMap");

	private static readonly IntPtr selSetUseMap_Handle = Selector.GetHandle("setUseMap:");

	private static readonly IntPtr selAccessKeyHandle = Selector.GetHandle("accessKey");

	private static readonly IntPtr selSetAccessKey_Handle = Selector.GetHandle("setAccessKey:");

	private static readonly IntPtr selAltDisplayStringHandle = Selector.GetHandle("altDisplayString");

	private static readonly IntPtr selAbsoluteImageURLHandle = Selector.GetHandle("absoluteImageURL");

	private static readonly IntPtr selSelectHandle = Selector.GetHandle("select");

	private static readonly IntPtr selSetSelectionRangeEnd_Handle = Selector.GetHandle("setSelectionRange:end:");

	private static readonly IntPtr selClickHandle = Selector.GetHandle("click");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMHTMLInputElement");

	private object __mt_AbsoluteImageURL_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Accept
	{
		[Export("accept")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAcceptHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAcceptHandle));
		}
		[Export("setAccept:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccept_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccept_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Alt
	{
		[Export("alt")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAltHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAltHandle));
		}
		[Export("setAlt:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlt_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlt_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool Autofocus
	{
		[Export("autofocus")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutofocusHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutofocusHandle);
		}
		[Export("setAutofocus:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutofocus_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutofocus_Handle, value);
			}
		}
	}

	public virtual bool defaultChecked
	{
		[Export("defaultChecked")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDefaultCheckedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDefaultCheckedHandle);
		}
		[Export("setDefaultChecked:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDefaultChecked_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDefaultChecked_Handle, value);
			}
		}
	}

	public virtual bool Checked
	{
		[Export("checked")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCheckedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCheckedHandle);
		}
		[Export("setChecked:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetChecked_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetChecked_Handle, value);
			}
		}
	}

	public virtual bool Disabled
	{
		[Export("disabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisabledHandle);
		}
		[Export("setDisabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisabled_Handle, value);
			}
		}
	}

	public virtual bool Indeterminate
	{
		[Export("indeterminate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIndeterminateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIndeterminateHandle);
		}
		[Export("setIndeterminate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndeterminate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndeterminate_Handle, value);
			}
		}
	}

	public virtual int MaxLength
	{
		[Export("maxLength")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMaxLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMaxLengthHandle);
		}
		[Export("setMaxLength:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMaxLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMaxLength_Handle, value);
			}
		}
	}

	public virtual bool Multiple
	{
		[Export("multiple")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMultipleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMultipleHandle);
		}
		[Export("setMultiple:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMultiple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMultiple_Handle, value);
			}
		}
	}

	public new virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool ReadOnly
	{
		[Export("readOnly")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReadOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReadOnlyHandle);
		}
		[Export("setReadOnly:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReadOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReadOnly_Handle, value);
			}
		}
	}

	public virtual string Size
	{
		[Export("size")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSizeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSizeHandle));
		}
		[Export("setSize:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSize_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSize_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Src
	{
		[Export("src")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSrcHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSrcHandle));
		}
		[Export("setSrc:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSrc_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSrc_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
		[Export("setType:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string DefaultValue
	{
		[Export("defaultValue")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultValueHandle));
		}
		[Export("setDefaultValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Value
	{
		[Export("value")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool WillValidate
	{
		[Export("willValidate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWillValidateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWillValidateHandle);
		}
	}

	public virtual int SelectionStart
	{
		[Export("selectionStart")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSelectionStartHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSelectionStartHandle);
		}
		[Export("setSelectionStart:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSelectionStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSelectionStart_Handle, value);
			}
		}
	}

	public virtual int SelectionEnd
	{
		[Export("selectionEnd")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSelectionEndHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSelectionEndHandle);
		}
		[Export("setSelectionEnd:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSelectionEnd_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSelectionEnd_Handle, value);
			}
		}
	}

	public virtual string Align
	{
		[Export("align")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlignHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlignHandle));
		}
		[Export("setAlign:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlign_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlign_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string UseMap
	{
		[Export("useMap")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUseMapHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUseMapHandle));
		}
		[Export("setUseMap:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUseMap_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUseMap_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string AccessKey
	{
		[Export("accessKey")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessKeyHandle));
		}
		[Export("setAccessKey:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessKey_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessKey_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string AltDisplayString
	{
		[Export("altDisplayString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAltDisplayStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAltDisplayStringHandle));
		}
	}

	public virtual NSUrl AbsoluteImageURL
	{
		[Export("absoluteImageURL")]
		get
		{
			return (NSUrl)(__mt_AbsoluteImageURL_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteImageURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteImageURLHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomHtmlInputElement(NSCoder coder)
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
	public DomHtmlInputElement(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomHtmlInputElement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("select")]
	public virtual void Select()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSelectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSelectHandle);
		}
	}

	[Export("setSelectionRange:end:")]
	public virtual void SetSelectionRange(int start, int end)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_int(base.Handle, selSetSelectionRangeEnd_Handle, start, end);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_int(base.SuperHandle, selSetSelectionRangeEnd_Handle, start, end);
		}
	}

	[Export("click")]
	public virtual void Click()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClickHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClickHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AbsoluteImageURL_var = null;
		}
	}
}
