using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSFormatter", true)]
public class NSFormatter : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringForObjectValue_WithDefaultAttributes_ = "attributedStringForObjectValue:withDefaultAttributes:";

	private static readonly IntPtr selAttributedStringForObjectValue_WithDefaultAttributes_Handle = Selector.GetHandle("attributedStringForObjectValue:withDefaultAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditingStringForObjectValue_ = "editingStringForObjectValue:";

	private static readonly IntPtr selEditingStringForObjectValue_Handle = Selector.GetHandle("editingStringForObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetObjectValue_ForString_ErrorDescription_ = "getObjectValue:forString:errorDescription:";

	private static readonly IntPtr selGetObjectValue_ForString_ErrorDescription_Handle = Selector.GetHandle("getObjectValue:forString:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPartialStringValid_NewEditingString_ErrorDescription_ = "isPartialStringValid:newEditingString:errorDescription:";

	private static readonly IntPtr selIsPartialStringValid_NewEditingString_ErrorDescription_Handle = Selector.GetHandle("isPartialStringValid:newEditingString:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_ = "isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:";

	private static readonly IntPtr selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_Handle = Selector.GetHandle("isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForObjectValue_ = "stringForObjectValue:";

	private static readonly IntPtr selStringForObjectValue_Handle = Selector.GetHandle("stringForObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[Obsolete("Use 'IsPartialStringValid (ref string partialString, out NSRange proposedSelRange, string origString, NSRange origSelRange, out string error)' instead.")]
	public virtual bool IsPartialStringValid(out string partialString, out NSRange proposedSelRange, string origString, NSRange origSelRange, out NSString error)
	{
		partialString = origString;
		proposedSelRange = origSelRange;
		error = null;
		return true;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFormatter()
		: base(NSObjectFlag.Empty)
	{
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFormatter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("editingStringForObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string EditingStringFor(NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEditingStringForObjectValue_Handle, value.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEditingStringForObjectValue_Handle, value.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSAttributedString GetAttributedString(NSObject obj, NSDictionary defaultAttributes)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (defaultAttributes == null)
		{
			throw new ArgumentNullException("defaultAttributes");
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributedStringForObjectValue_WithDefaultAttributes_Handle, obj.Handle, defaultAttributes.Handle));
	}

	[Export("attributedStringForObjectValue:withDefaultAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAttributedString(NSObject obj, NSDictionary<NSString, NSObject> defaultAttributes)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (defaultAttributes == null)
		{
			throw new ArgumentNullException("defaultAttributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributedStringForObjectValue_WithDefaultAttributes_Handle, obj.Handle, defaultAttributes.Handle));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAttributedStringForObjectValue_WithDefaultAttributes_Handle, obj.Handle, defaultAttributes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString GetAttributedString(NSObject obj, NSStringAttributes defaultAttributes)
	{
		return GetAttributedString(obj, defaultAttributes.GetDictionary());
	}

	[Export("getObjectValue:forString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetObjectValue(out NSObject obj, string str, out NSString error)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(str);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2));
		NSString.ReleaseNative(arg3);
		obj = Runtime.GetNSObject<NSObject>(arg);
		error = Runtime.GetNSObject<NSString>(arg2);
		return result;
	}

	[Export("isPartialStringValid:newEditingString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPartialStringValid(string partialString, out string newString, out NSString error)
	{
		if (partialString == null)
		{
			throw new ArgumentNullException("partialString");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(partialString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selIsPartialStringValid_NewEditingString_ErrorDescription_Handle, arg3, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selIsPartialStringValid_NewEditingString_ErrorDescription_Handle, arg3, ref arg, ref arg2));
		NSString.ReleaseNative(arg3);
		newString = NSString.FromHandle(arg);
		error = Runtime.GetNSObject<NSString>(arg2);
		return result;
	}

	[Export("isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPartialStringValid(ref string partialString, out NSRange proposedSelRange, string origString, NSRange origSelRange, out string error)
	{
		if (origString == null)
		{
			throw new ArgumentNullException("origString");
		}
		IntPtr arg = NSString.CreateNative(partialString, autorelease: true);
		IntPtr intPtr = arg;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(origString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_out_NSRange_IntPtr_NSRange_ref_IntPtr(base.SuperHandle, selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_Handle, ref arg, out proposedSelRange, arg3, origSelRange, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_out_NSRange_IntPtr_NSRange_ref_IntPtr(base.Handle, selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_Handle, ref arg, out proposedSelRange, arg3, origSelRange, ref arg2));
		NSString.ReleaseNative(arg3);
		if (arg != intPtr)
		{
			partialString = NSString.FromHandle(arg);
		}
		error = NSString.FromHandle(arg2);
		return result;
	}

	[Export("stringForObjectValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFor(NSObject? value)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForObjectValue_Handle, value?.Handle ?? IntPtr.Zero));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForObjectValue_Handle, value?.Handle ?? IntPtr.Zero));
	}
}
