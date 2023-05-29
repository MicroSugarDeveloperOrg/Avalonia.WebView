using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableMetadataItem", true)]
public class AVMutableMetadataItem : AVMetadataItem
{
	private static readonly IntPtr selKeySpaceHandle = Selector.GetHandle("keySpace");

	private static readonly IntPtr selSetKeySpace_Handle = Selector.GetHandle("setKeySpace:");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selSetLocale_Handle = Selector.GetHandle("setLocale:");

	private static readonly IntPtr selTimeHandle = Selector.GetHandle("time");

	private static readonly IntPtr selSetTime_Handle = Selector.GetHandle("setTime:");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	private static readonly IntPtr selExtraAttributesHandle = Selector.GetHandle("extraAttributes");

	private static readonly IntPtr selSetExtraAttributes_Handle = Selector.GetHandle("setExtraAttributes:");

	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	private static readonly IntPtr selSetKey_Handle = Selector.GetHandle("setKey:");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	private static readonly IntPtr selMetadataItemHandle = Selector.GetHandle("metadataItem");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableMetadataItem");

	private object __mt_Locale_var;

	private object __mt_Value_var;

	private object __mt_ExtraAttributes_var;

	private object __mt_Key_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual string KeySpace
	{
		[Export("keySpace", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeySpaceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeySpaceHandle));
		}
		[Export("setKeySpace:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeySpace_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeySpace_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			return (NSLocale)(__mt_Locale_var = ((!IsDirectBinding) ? ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle))) : ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle)))));
		}
		[Export("setLocale:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocale_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocale_Handle, value.Handle);
			}
			__mt_Locale_var = value;
		}
	}

	public new virtual CMTime Time
	{
		[Export("time")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeHandle);
			}
			return retval;
		}
		[Export("setTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetTime_Handle, value);
			}
		}
	}

	public new virtual NSObject Value
	{
		[Export("value", ArgumentSemantic.Copy)]
		get
		{
			return (NSObject)(__mt_Value_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle))));
		}
		[Export("setValue:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValue_Handle, value.Handle);
			}
			__mt_Value_var = value;
		}
	}

	public new virtual NSDictionary ExtraAttributes
	{
		[Export("extraAttributes", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_ExtraAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtraAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExtraAttributesHandle)))));
		}
		[Export("setExtraAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExtraAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExtraAttributes_Handle, value.Handle);
			}
			__mt_ExtraAttributes_var = value;
		}
	}

	public new virtual NSObject Key
	{
		[Export("key", ArgumentSemantic.Copy)]
		get
		{
			return (NSObject)(__mt_Key_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle))));
		}
		[Export("setKey:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKey_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKey_Handle, value.Handle);
			}
			__mt_Key_var = value;
		}
	}

	[Since(4, 2)]
	public new virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
		[Export("setDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableMetadataItem()
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
	public AVMutableMetadataItem(NSCoder coder)
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
	public AVMutableMetadataItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableMetadataItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("metadataItem")]
	public static AVMutableMetadataItem Create()
	{
		return (AVMutableMetadataItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMetadataItemHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Locale_var = null;
			__mt_Value_var = null;
			__mt_ExtraAttributes_var = null;
			__mt_Key_var = null;
		}
	}
}
