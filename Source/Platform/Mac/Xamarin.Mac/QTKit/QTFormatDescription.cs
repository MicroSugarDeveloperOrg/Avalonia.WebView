using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTFormatDescription", true)]
public class QTFormatDescription : NSObject
{
	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selFormatTypeHandle = Selector.GetHandle("formatType");

	private static readonly IntPtr selLocalizedFormatSummaryHandle = Selector.GetHandle("localizedFormatSummary");

	private static readonly IntPtr selQuickTimeSampleDescriptionHandle = Selector.GetHandle("quickTimeSampleDescription");

	private static readonly IntPtr selFormatDescriptionAttributesHandle = Selector.GetHandle("formatDescriptionAttributes");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selIsEqualToFormatDescription_Handle = Selector.GetHandle("isEqualToFormatDescription:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTFormatDescription");

	private object __mt_QuickTimeSampleDescription_var;

	private object __mt_FormatDescriptionAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual uint FormatType
	{
		[Export("formatType")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFormatTypeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFormatTypeHandle);
		}
	}

	public virtual string LocalizedFormatSummary
	{
		[Export("localizedFormatSummary")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedFormatSummaryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedFormatSummaryHandle));
		}
	}

	public virtual NSData QuickTimeSampleDescription
	{
		[Export("quickTimeSampleDescription")]
		get
		{
			return (NSData)(__mt_QuickTimeSampleDescription_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuickTimeSampleDescriptionHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selQuickTimeSampleDescriptionHandle)))));
		}
	}

	public virtual NSDictionary FormatDescriptionAttributes
	{
		[Export("formatDescriptionAttributes")]
		get
		{
			return (NSDictionary)(__mt_FormatDescriptionAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionAttributesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTFormatDescription()
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
	public QTFormatDescription(NSCoder coder)
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
	public QTFormatDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTFormatDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributeForKey:")]
	public virtual NSObject AttributeForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqualToFormatDescription:")]
	public virtual bool IsEqualToFormatDescription(QTFormatDescription formatDescription)
	{
		if (formatDescription == null)
		{
			throw new ArgumentNullException("formatDescription");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToFormatDescription_Handle, formatDescription.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToFormatDescription_Handle, formatDescription.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_QuickTimeSampleDescription_var = null;
			__mt_FormatDescriptionAttributes_var = null;
		}
	}
}
