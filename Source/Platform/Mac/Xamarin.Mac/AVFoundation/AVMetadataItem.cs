using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMetadataItem", true)]
public class AVMetadataItem : NSObject
{
	private static readonly IntPtr selCommonKeyHandle = Selector.GetHandle("commonKey");

	private static readonly IntPtr selKeySpaceHandle = Selector.GetHandle("keySpace");

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	private static readonly IntPtr selTimeHandle = Selector.GetHandle("time");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selExtraAttributesHandle = Selector.GetHandle("extraAttributes");

	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	private static readonly IntPtr selNumberValueHandle = Selector.GetHandle("numberValue");

	private static readonly IntPtr selDateValueHandle = Selector.GetHandle("dateValue");

	private static readonly IntPtr selDataValueHandle = Selector.GetHandle("dataValue");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selMetadataItemsFromArrayWithLocale_Handle = Selector.GetHandle("metadataItemsFromArray:withLocale:");

	private static readonly IntPtr selMetadataItemsFromArrayWithKeyKeySpace_Handle = Selector.GetHandle("metadataItemsFromArray:withKey:keySpace:");

	private static readonly IntPtr selStatusOfValueForKeyError_Handle = Selector.GetHandle("statusOfValueForKey:error:");

	private static readonly IntPtr selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle = Selector.GetHandle("loadValuesAsynchronouslyForKeys:completionHandler:");

	private static readonly IntPtr selMetadataItemsFromArrayFilteredAndSortedAccordingToPreferredLanguages_Handle = Selector.GetHandle("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMetadataItem");

	private object __mt_Locale_var;

	private object __mt_Value_var;

	private object __mt_ExtraAttributes_var;

	private object __mt_Key_var;

	private object __mt_NumberValue_var;

	private object __mt_DateValue_var;

	private object __mt_DataValue_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string CommonKey
	{
		[Export("commonKey", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonKeyHandle));
		}
	}

	public virtual string KeySpace
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
	}

	public virtual NSLocale Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			return (NSLocale)(__mt_Locale_var = ((!IsDirectBinding) ? ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle))) : ((NSLocale)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle)))));
		}
	}

	public virtual CMTime Time
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
	}

	public virtual NSObject Value
	{
		[Export("value", ArgumentSemantic.Copy)]
		get
		{
			return (NSObject)(__mt_Value_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle))));
		}
	}

	public virtual NSDictionary ExtraAttributes
	{
		[Export("extraAttributes", ArgumentSemantic.Copy)]
		get
		{
			return (NSDictionary)(__mt_ExtraAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtraAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExtraAttributesHandle)))));
		}
	}

	public virtual NSObject Key
	{
		[Export("key", ArgumentSemantic.Copy)]
		get
		{
			return (NSObject)(__mt_Key_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle))));
		}
	}

	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	public virtual NSNumber NumberValue
	{
		[Export("numberValue")]
		get
		{
			return (NSNumber)(__mt_NumberValue_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNumberValueHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNumberValueHandle)))));
		}
	}

	public virtual NSDate DateValue
	{
		[Export("dateValue")]
		get
		{
			return (NSDate)(__mt_DateValue_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateValueHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDateValueHandle)))));
		}
	}

	public virtual NSData DataValue
	{
		[Export("dataValue")]
		get
		{
			return (NSData)(__mt_DataValue_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataValueHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataValueHandle)))));
		}
	}

	[Since(4, 2)]
	public virtual CMTime Duration
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
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMetadataItem()
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
	public AVMetadataItem(NSCoder coder)
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
	public AVMetadataItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMetadataItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("metadataItemsFromArray:withLocale:")]
	public static AVMetadataItem[] FilterWithLocale(AVMetadataItem[] arrayToFilter, NSLocale locale)
	{
		if (arrayToFilter == null)
		{
			throw new ArgumentNullException("arrayToFilter");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		NSArray nSArray = NSArray.FromNSObjects(arrayToFilter);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArrayWithLocale_Handle, nSArray.Handle, locale.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("metadataItemsFromArray:withKey:keySpace:")]
	public static AVMetadataItem[] FilterWithKey(AVMetadataItem[] metadataItems, NSObject key, string keySpace)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (keySpace == null)
		{
			throw new ArgumentNullException("keySpace");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		IntPtr arg = NSString.CreateNative(keySpace);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArrayWithKeyKeySpace_Handle, nSArray.Handle, key.Handle, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("statusOfValueForKey:error:")]
	public virtual AVKeyValueStatus StatusOfValueForKeyerror(string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(key);
		AVKeyValueStatus result = (AVKeyValueStatus)((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStatusOfValueForKeyError_Handle, arg, intPtr) : Messaging.int_objc_msgSend_IntPtr_IntPtr(base.Handle, selStatusOfValueForKeyError_Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	public unsafe virtual void LoadValuesAsynchronously(string[] keys, NSAction handler)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, handler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadValuesAsynchronouslyForKeysCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	public virtual Task LoadValuesTaskAsync(string[] keys)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		LoadValuesAsynchronously(keys, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:")]
	public static AVMetadataItem[] FilterFromPreferredLanguages(AVMetadataItem[] metadataItems, string[] preferredLanguages)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		if (preferredLanguages == null)
		{
			throw new ArgumentNullException("preferredLanguages");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		NSArray nSArray2 = NSArray.FromStrings(preferredLanguages);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArrayFilteredAndSortedAccordingToPreferredLanguages_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
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
			__mt_NumberValue_var = null;
			__mt_DateValue_var = null;
			__mt_DataValue_var = null;
		}
	}
}
