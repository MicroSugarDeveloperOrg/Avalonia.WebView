using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextList", true)]
public class NSTextList : NSObject
{
	private static readonly IntPtr selMarkerFormatHandle = Selector.GetHandle("markerFormat");

	private static readonly IntPtr selListOptionsHandle = Selector.GetHandle("listOptions");

	private static readonly IntPtr selStartingItemNumberHandle = Selector.GetHandle("startingItemNumber");

	private static readonly IntPtr selSetStartingItemNumber_Handle = Selector.GetHandle("setStartingItemNumber:");

	private static readonly IntPtr selInitWithMarkerFormatOptions_Handle = Selector.GetHandle("initWithMarkerFormat:options:");

	private static readonly IntPtr selMarkerForItemNumber_Handle = Selector.GetHandle("markerForItemNumber:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextList");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MarkerFormat
	{
		[Export("markerFormat")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMarkerFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkerFormatHandle));
		}
	}

	public virtual NSTextListOptions ListOptions
	{
		[Export("listOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextListOptions)Messaging.UInt64_objc_msgSend(base.Handle, selListOptionsHandle);
			}
			return (NSTextListOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selListOptionsHandle);
		}
	}

	public virtual long StartingItemNumber
	{
		[Export("startingItemNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selStartingItemNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStartingItemNumberHandle);
		}
		[Export("setStartingItemNumber:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetStartingItemNumber_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetStartingItemNumber_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextList()
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
	public NSTextList(NSCoder coder)
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
	public NSTextList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMarkerFormat:options:")]
	public NSTextList(string format, NSTextListOptions mask)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = NSString.CreateNative(format);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithMarkerFormatOptions_Handle, arg, (ulong)mask);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithMarkerFormatOptions_Handle, arg, (ulong)mask);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("markerForItemNumber:")]
	public virtual string GetMarker(long itemNum)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selMarkerForItemNumber_Handle, itemNum));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selMarkerForItemNumber_Handle, itemNum));
	}
}
