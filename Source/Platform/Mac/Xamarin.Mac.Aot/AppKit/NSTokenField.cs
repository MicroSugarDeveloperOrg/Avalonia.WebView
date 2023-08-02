using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTokenField", true)]
public class NSTokenField : NSTextField
{
	private static readonly IntPtr selTokenStyleHandle = Selector.GetHandle("tokenStyle");

	private static readonly IntPtr selSetTokenStyle_Handle = Selector.GetHandle("setTokenStyle:");

	private static readonly IntPtr selCompletionDelayHandle = Selector.GetHandle("completionDelay");

	private static readonly IntPtr selSetCompletionDelay_Handle = Selector.GetHandle("setCompletionDelay:");

	private static readonly IntPtr selDefaultCompletionDelayHandle = Selector.GetHandle("defaultCompletionDelay");

	private static readonly IntPtr selDefaultTokenizingCharacterSetHandle = Selector.GetHandle("defaultTokenizingCharacterSet");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selTokenizingCharacterSetHandle = Selector.GetHandle("tokenizingCharacterSet");

	private static readonly IntPtr selSetTokenizingCharacterSet_Handle = Selector.GetHandle("setTokenizingCharacterSet:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTokenField");

	private static object __mt_DefaultCharacterSet_var_static;

	private object __mt_WeakDelegate_var;

	private object __mt_CharacterSet_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSTokenStyle TokenStyle
	{
		[Export("tokenStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTokenStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTokenStyleHandle);
			}
			return (NSTokenStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTokenStyleHandle);
		}
		[Export("setTokenStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTokenStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTokenStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual double CompletionDelay
	{
		[Export("completionDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCompletionDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCompletionDelayHandle);
		}
		[Export("setCompletionDelay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCompletionDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCompletionDelay_Handle, value);
			}
		}
	}

	public static double DefaultCompletionDelay
	{
		[Export("defaultCompletionDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDefaultCompletionDelayHandle);
		}
	}

	public static NSCharacterSet DefaultCharacterSet
	{
		[Export("defaultTokenizingCharacterSet")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCharacterSet)(__mt_DefaultCharacterSet_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultTokenizingCharacterSetHandle)));
		}
	}

	public new virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public new NSTokenFieldDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSTokenFieldDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSCharacterSet CharacterSet
	{
		[Export("tokenizingCharacterSet")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCharacterSet)(__mt_CharacterSet_var = ((!IsDirectBinding) ? ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTokenizingCharacterSetHandle))) : ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTokenizingCharacterSetHandle)))));
		}
		[Export("setTokenizingCharacterSet:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTokenizingCharacterSet_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTokenizingCharacterSet_Handle, value.Handle);
			}
			__mt_CharacterSet_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTokenField()
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
	public NSTokenField(NSCoder coder)
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
	public NSTokenField(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTokenField(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSTokenField(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_CharacterSet_var = null;
		}
	}
}
