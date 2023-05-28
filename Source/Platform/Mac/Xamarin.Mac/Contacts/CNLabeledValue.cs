using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNLabeledValue", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNLabeledValue<ValueType> : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding where ValueType : NSObject, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLabel_Value_ = "initWithLabel:value:";

	private static readonly IntPtr selInitWithLabel_Value_Handle = Selector.GetHandle("initWithLabel:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabeledValueBySettingLabel_ = "labeledValueBySettingLabel:";

	private static readonly IntPtr selLabeledValueBySettingLabel_Handle = Selector.GetHandle("labeledValueBySettingLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabeledValueBySettingLabel_Value_ = "labeledValueBySettingLabel:value:";

	private static readonly IntPtr selLabeledValueBySettingLabel_Value_Handle = Selector.GetHandle("labeledValueBySettingLabel:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabeledValueBySettingValue_ = "labeledValueBySettingValue:";

	private static readonly IntPtr selLabeledValueBySettingValue_Handle = Selector.GetHandle("labeledValueBySettingValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabeledValueWithLabel_Value_ = "labeledValueWithLabel:value:";

	private static readonly IntPtr selLabeledValueWithLabel_Value_Handle = Selector.GetHandle("labeledValueWithLabel:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForLabel_ = "localizedStringForLabel:";

	private static readonly IntPtr selLocalizedStringForLabel_Handle = Selector.GetHandle("localizedStringForLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNLabeledValue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ValueType Value
	{
		[Export("value", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle), owns: false);
			}
			return Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNLabeledValue()
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
	public CNLabeledValue(NSCoder coder)
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
	protected CNLabeledValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNLabeledValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLabel:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CNLabeledValue(string? label, ValueType value)
		: base(NSObjectFlag.Empty)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLabel_Value_Handle, arg, value.Handle), "initWithLabel:value:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLabel_Value_Handle, arg, value.Handle), "initWithLabel:value:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("labeledValueWithLabel:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ValueType FromLabel(string? label, ValueType value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(label);
		ValueType iNativeObject = Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLabeledValueWithLabel_Value_Handle, arg, value.Handle), owns: false);
		NSString.ReleaseNative(arg);
		return iNativeObject;
	}

	[Export("labeledValueBySettingLabel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ValueType GetLabeledValue(string? label)
	{
		IntPtr arg = NSString.CreateNative(label);
		ValueType result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLabeledValueBySettingLabel_Handle, arg), owns: false) : Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLabeledValueBySettingLabel_Handle, arg), owns: false));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("labeledValueBySettingValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ValueType GetLabeledValue(ValueType value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLabeledValueBySettingValue_Handle, value.Handle), owns: false);
		}
		return Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLabeledValueBySettingValue_Handle, value.Handle), owns: false);
	}

	[Export("labeledValueBySettingLabel:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ValueType GetLabeledValue(string? label, ValueType value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(label);
		ValueType result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLabeledValueBySettingLabel_Value_Handle, arg, value.Handle), owns: false) : Runtime.GetINativeObject<ValueType>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLabeledValueBySettingLabel_Value_Handle, arg, value.Handle), owns: false));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringForLabel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeLabel(NSString labelKey)
	{
		if (labelKey == null)
		{
			throw new ArgumentNullException("labelKey");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedStringForLabel_Handle, labelKey.Handle));
	}
}
