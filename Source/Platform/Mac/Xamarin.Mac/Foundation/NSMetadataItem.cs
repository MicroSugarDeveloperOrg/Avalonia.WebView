using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMetadataItem", true)]
public class NSMetadataItem : NSObject
{
	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	private static readonly IntPtr selValueForAttribute_Handle = Selector.GetHandle("valueForAttribute:");

	private static readonly IntPtr selValuesForAttributes_Handle = Selector.GetHandle("valuesForAttributes:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMetadataItem");

	private object __mt_Attributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject[] Attributes
	{
		[Export("attributes")]
		get
		{
			return (NSObject[])(__mt_Attributes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataItem()
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
	public NSMetadataItem(NSCoder coder)
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
	public NSMetadataItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("valueForAttribute:")]
	public virtual NSObject ValueForAttribute(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttribute_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttribute_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("valuesForAttributes:")]
	public virtual NSDictionary ValuesForAttributes(NSArray keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValuesForAttributes_Handle, keys.Handle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValuesForAttributes_Handle, keys.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Attributes_var = null;
		}
	}
}
