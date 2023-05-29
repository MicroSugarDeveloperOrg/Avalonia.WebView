using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpeechRecognizer", true)]
public class NSSpeechRecognizer : NSObject
{
	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCommandsHandle = Selector.GetHandle("commands");

	private static readonly IntPtr selSetCommands_Handle = Selector.GetHandle("setCommands:");

	private static readonly IntPtr selDisplayedCommandsTitleHandle = Selector.GetHandle("displayedCommandsTitle");

	private static readonly IntPtr selSetDisplayedCommandsTitle_Handle = Selector.GetHandle("setDisplayedCommandsTitle:");

	private static readonly IntPtr selListensInForegroundOnlyHandle = Selector.GetHandle("listensInForegroundOnly");

	private static readonly IntPtr selSetListensInForegroundOnly_Handle = Selector.GetHandle("setListensInForegroundOnly:");

	private static readonly IntPtr selBlocksOtherRecognizersHandle = Selector.GetHandle("blocksOtherRecognizers");

	private static readonly IntPtr selSetBlocksOtherRecognizers_Handle = Selector.GetHandle("setBlocksOtherRecognizers:");

	private static readonly IntPtr selStartListeningHandle = Selector.GetHandle("startListening");

	private static readonly IntPtr selStopListeningHandle = Selector.GetHandle("stopListening");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSpeechRecognizer");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
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

	public NSSpeechRecognizerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSpeechRecognizerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual string[] Commands
	{
		[Export("commands")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandsHandle));
		}
		[Export("setCommands:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCommands_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCommands_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	public virtual string DisplayedCommandsTitle
	{
		[Export("displayedCommandsTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayedCommandsTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayedCommandsTitleHandle));
		}
		[Export("setDisplayedCommandsTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayedCommandsTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayedCommandsTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool ListensInForegroundOnly
	{
		[Export("listensInForegroundOnly")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selListensInForegroundOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selListensInForegroundOnlyHandle);
		}
		[Export("setListensInForegroundOnly:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetListensInForegroundOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetListensInForegroundOnly_Handle, value);
			}
		}
	}

	public virtual bool BlocksOtherRecognizers
	{
		[Export("blocksOtherRecognizers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBlocksOtherRecognizersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBlocksOtherRecognizersHandle);
		}
		[Export("setBlocksOtherRecognizers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBlocksOtherRecognizers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBlocksOtherRecognizers_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpeechRecognizer()
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
	public NSSpeechRecognizer(NSCoder coder)
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
	public NSSpeechRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSpeechRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("startListening")]
	public virtual void StartListening()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartListeningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartListeningHandle);
		}
	}

	[Export("stopListening")]
	public virtual void StopListening()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopListeningHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopListeningHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
