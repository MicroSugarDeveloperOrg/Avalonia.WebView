using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebHistoryItem", true)]
public class WebHistoryItem : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selOriginalURLStringHandle = Selector.GetHandle("originalURLString");

	private static readonly IntPtr selURLStringHandle = Selector.GetHandle("URLString");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selLastVisitedTimeIntervalHandle = Selector.GetHandle("lastVisitedTimeInterval");

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	private static readonly IntPtr selAlternateTitleHandle = Selector.GetHandle("alternateTitle");

	private static readonly IntPtr selSetAlternateTitle_Handle = Selector.GetHandle("setAlternateTitle:");

	private static readonly IntPtr selInitWithURLStringTitleLastVisitedTimeInterval_Handle = Selector.GetHandle("initWithURLString:title:lastVisitedTimeInterval:");

	private static readonly IntPtr class_ptr = Class.GetHandle("WebHistoryItem");

	private object __mt_Icon_var;

	private static NSString _ChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string OriginalUrlString
	{
		[Export("originalURLString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginalURLStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginalURLStringHandle));
		}
	}

	public virtual string UrlString
	{
		[Export("URLString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURLStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLStringHandle));
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	public virtual double LastVisitedTimeInterval
	{
		[Export("lastVisitedTimeInterval")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLastVisitedTimeIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLastVisitedTimeIntervalHandle);
		}
	}

	public virtual NSImage Icon
	{
		[Export("icon")]
		get
		{
			return (NSImage)(__mt_Icon_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle)))));
		}
	}

	public virtual string AlternateTitle
	{
		[Export("alternateTitle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateTitleHandle));
		}
		[Export("setAlternateTitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("WebHistoryItemChangedNotification", "WebKit")]
	public static NSString ChangedNotification
	{
		get
		{
			if (_ChangedNotification == null)
			{
				_ChangedNotification = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WebHistoryItemChangedNotification");
			}
			return _ChangedNotification;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebHistoryItem()
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
	public WebHistoryItem(NSCoder coder)
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
	public WebHistoryItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebHistoryItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURLString:title:lastVisitedTimeInterval:")]
	public WebHistoryItem(string urlString, string title, double lastVisitedTimeInterval)
		: base(NSObjectFlag.Empty)
	{
		if (urlString == null)
		{
			throw new ArgumentNullException("urlString");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(urlString);
		IntPtr arg2 = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double(base.Handle, selInitWithURLStringTitleLastVisitedTimeInterval_Handle, arg, arg2, lastVisitedTimeInterval);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double(base.SuperHandle, selInitWithURLStringTitleLastVisitedTimeInterval_Handle, arg, arg2, lastVisitedTimeInterval);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Icon_var = null;
		}
	}
}
