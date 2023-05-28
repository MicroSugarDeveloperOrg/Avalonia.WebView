using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTFormatDescription", true)]
public class QTFormatDescription : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescriptionAttributes = "formatDescriptionAttributes";

	private static readonly IntPtr selFormatDescriptionAttributesHandle = Selector.GetHandle("formatDescriptionAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatType = "formatType";

	private static readonly IntPtr selFormatTypeHandle = Selector.GetHandle("formatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToFormatDescription_ = "isEqualToFormatDescription:";

	private static readonly IntPtr selIsEqualToFormatDescription_Handle = Selector.GetHandle("isEqualToFormatDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedFormatSummary = "localizedFormatSummary";

	private static readonly IntPtr selLocalizedFormatSummaryHandle = Selector.GetHandle("localizedFormatSummary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickTimeSampleDescription = "quickTimeSampleDescription";

	private static readonly IntPtr selQuickTimeSampleDescriptionHandle = Selector.GetHandle("quickTimeSampleDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTFormatDescription");

	public QTMediaType MediaTypeValue => QTMedia.QTMediaTypeFromNSString((NSString)MediaType);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FormatDescriptionAttributes
	{
		[Export("formatDescriptionAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint FormatType
	{
		[Export("formatType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFormatTypeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFormatTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedFormatSummary
	{
		[Export("localizedFormatSummary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedFormatSummaryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedFormatSummaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData QuickTimeSampleDescription
	{
		[Export("quickTimeSampleDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeSampleDescriptionHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeSampleDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTFormatDescription()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTFormatDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTFormatDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AttributeForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqualToFormatDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToFormatDescription(QTFormatDescription formatDescription)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToFormatDescription_Handle, formatDescription.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToFormatDescription_Handle, formatDescription.Handle);
	}
}
