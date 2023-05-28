using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVTextStyleRule", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class AVTextStyleRule : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextMarkupAttributes_ = "initWithTextMarkupAttributes:";

	private static readonly IntPtr selInitWithTextMarkupAttributes_Handle = Selector.GetHandle("initWithTextMarkupAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextMarkupAttributes_TextSelector_ = "initWithTextMarkupAttributes:textSelector:";

	private static readonly IntPtr selInitWithTextMarkupAttributes_TextSelector_Handle = Selector.GetHandle("initWithTextMarkupAttributes:textSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyListForTextStyleRules_ = "propertyListForTextStyleRules:";

	private static readonly IntPtr selPropertyListForTextStyleRules_Handle = Selector.GetHandle("propertyListForTextStyleRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextMarkupAttributes = "textMarkupAttributes";

	private static readonly IntPtr selTextMarkupAttributesHandle = Selector.GetHandle("textMarkupAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextSelector = "textSelector";

	private static readonly IntPtr selTextSelectorHandle = Selector.GetHandle("textSelector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStyleRuleWithTextMarkupAttributes_ = "textStyleRuleWithTextMarkupAttributes:";

	private static readonly IntPtr selTextStyleRuleWithTextMarkupAttributes_Handle = Selector.GetHandle("textStyleRuleWithTextMarkupAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStyleRuleWithTextMarkupAttributes_TextSelector_ = "textStyleRuleWithTextMarkupAttributes:textSelector:";

	private static readonly IntPtr selTextStyleRuleWithTextMarkupAttributes_TextSelector_Handle = Selector.GetHandle("textStyleRuleWithTextMarkupAttributes:textSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextStyleRulesFromPropertyList_ = "textStyleRulesFromPropertyList:";

	private static readonly IntPtr selTextStyleRulesFromPropertyList_Handle = Selector.GetHandle("textStyleRulesFromPropertyList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVTextStyleRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CMTextMarkupAttributes TextMarkupAttributes
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakTextMarkupAttributes != null) ? new NSMutableDictionary(WeakTextMarkupAttributes) : null);
			return (nSMutableDictionary == null) ? null : new CMTextMarkupAttributes(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? TextSelector
	{
		[Export("textSelector")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextSelectorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextSelectorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSDictionary WeakTextMarkupAttributes
	{
		[Export("textMarkupAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextMarkupAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextMarkupAttributesHandle));
		}
	}

	[Obsolete("iOS9 does not allow creating an empty instance")]
	public AVTextStyleRule()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVTextStyleRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVTextStyleRule(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTextMarkupAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected AVTextStyleRule(NSDictionary textMarkupAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (textMarkupAttributes == null)
		{
			throw new ArgumentNullException("textMarkupAttributes");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTextMarkupAttributes_Handle, textMarkupAttributes.Handle), "initWithTextMarkupAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTextMarkupAttributes_Handle, textMarkupAttributes.Handle), "initWithTextMarkupAttributes:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVTextStyleRule(CMTextMarkupAttributes attributes)
		: this(attributes.GetDictionary())
	{
	}

	[Export("initWithTextMarkupAttributes:textSelector:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected AVTextStyleRule(NSDictionary textMarkupAttributes, string? textSelector)
		: base(NSObjectFlag.Empty)
	{
		if (textMarkupAttributes == null)
		{
			throw new ArgumentNullException("textMarkupAttributes");
		}
		IntPtr arg = NSString.CreateNative(textSelector);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTextMarkupAttributes_TextSelector_Handle, textMarkupAttributes.Handle, arg), "initWithTextMarkupAttributes:textSelector:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTextMarkupAttributes_TextSelector_Handle, textMarkupAttributes.Handle, arg), "initWithTextMarkupAttributes:textSelector:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVTextStyleRule(CMTextMarkupAttributes attributes, string textSelector)
		: this(attributes.GetDictionary(), textSelector)
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

	[Export("textStyleRulesFromPropertyList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVTextStyleRule[]? FromPropertyList(NSObject plist)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		return NSArray.ArrayFromHandle<AVTextStyleRule>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextStyleRulesFromPropertyList_Handle, plist.Handle));
	}

	[Export("textStyleRuleWithTextMarkupAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVTextStyleRule? FromTextMarkupAttributes(NSDictionary textMarkupAttributes)
	{
		if (textMarkupAttributes == null)
		{
			throw new ArgumentNullException("textMarkupAttributes");
		}
		return Runtime.GetNSObject<AVTextStyleRule>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextStyleRuleWithTextMarkupAttributes_Handle, textMarkupAttributes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVTextStyleRule? FromTextMarkupAttributes(CMTextMarkupAttributes textMarkupAttributes)
	{
		return FromTextMarkupAttributes(textMarkupAttributes.GetDictionary());
	}

	[Export("textStyleRuleWithTextMarkupAttributes:textSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVTextStyleRule? FromTextMarkupAttributes(NSDictionary textMarkupAttributes, string? textSelector)
	{
		if (textMarkupAttributes == null)
		{
			throw new ArgumentNullException("textMarkupAttributes");
		}
		IntPtr arg = NSString.CreateNative(textSelector);
		AVTextStyleRule nSObject = Runtime.GetNSObject<AVTextStyleRule>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTextStyleRuleWithTextMarkupAttributes_TextSelector_Handle, textMarkupAttributes.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVTextStyleRule? FromTextMarkupAttributes(CMTextMarkupAttributes textMarkupAttributes, string? textSelector)
	{
		return FromTextMarkupAttributes(textMarkupAttributes.GetDictionary(), textSelector);
	}

	[Export("propertyListForTextStyleRules:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject ToPropertyList(AVTextStyleRule[] textStyleRules)
	{
		if (textStyleRules == null)
		{
			throw new ArgumentNullException("textStyleRules");
		}
		NSArray nSArray = NSArray.FromNSObjects(textStyleRules);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPropertyListForTextStyleRules_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
