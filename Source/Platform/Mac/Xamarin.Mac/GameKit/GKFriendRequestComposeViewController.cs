using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKFriendRequestComposeViewController", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
public class GKFriendRequestComposeViewController : NSViewController, IGKViewController, INativeObject, IDisposable
{
	[Register]
	internal class _GKFriendRequestComposeViewControllerDelegate : NSObject, IGKFriendRequestComposeViewControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? didFinish;

		public _GKFriendRequestComposeViewControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("friendRequestComposeViewControllerDidFinish:")]
		public void DidFinish(GKFriendRequestComposeViewController viewController)
		{
			didFinish?.Invoke(viewController, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRecipientPlayers_ = "addRecipientPlayers:";

	private static readonly IntPtr selAddRecipientPlayers_Handle = Selector.GetHandle("addRecipientPlayers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRecipientsWithEmailAddresses_ = "addRecipientsWithEmailAddresses:";

	private static readonly IntPtr selAddRecipientsWithEmailAddresses_Handle = Selector.GetHandle("addRecipientsWithEmailAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRecipientsWithPlayerIDs_ = "addRecipientsWithPlayerIDs:";

	private static readonly IntPtr selAddRecipientsWithPlayerIDs_Handle = Selector.GetHandle("addRecipientsWithPlayerIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComposeViewDelegate = "composeViewDelegate";

	private static readonly IntPtr selComposeViewDelegateHandle = Selector.GetHandle("composeViewDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxNumberOfRecipients = "maxNumberOfRecipients";

	private static readonly IntPtr selMaxNumberOfRecipientsHandle = Selector.GetHandle("maxNumberOfRecipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetComposeViewDelegate_ = "setComposeViewDelegate:";

	private static readonly IntPtr selSetComposeViewDelegate_Handle = Selector.GetHandle("setComposeViewDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMessage_ = "setMessage:";

	private static readonly IntPtr selSetMessage_Handle = Selector.GetHandle("setMessage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKFriendRequestComposeViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakComposeViewDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	public IGKFriendRequestComposeViewControllerDelegate ComposeViewDelegate
	{
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		get
		{
			return WeakComposeViewDelegate as IGKFriendRequestComposeViewControllerDelegate;
		}
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakComposeViewDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint MaxNumberOfRecipients
	{
		[Export("maxNumberOfRecipients")]
		get
		{
			return Messaging.nint_objc_msgSend(class_ptr, selMaxNumberOfRecipientsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	public virtual NSObject? WeakComposeViewDelegate
	{
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("composeViewDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComposeViewDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selComposeViewDelegateHandle)));
			MarkDirty();
			__mt_WeakComposeViewDelegate_var = nSObject;
			return nSObject;
		}
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setComposeViewDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakComposeViewDelegate_var, value, GetInternalEventComposeViewDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetComposeViewDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetComposeViewDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakComposeViewDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventComposeViewDelegateType => typeof(_GKFriendRequestComposeViewControllerDelegate);

	public event EventHandler DidFinish
	{
		add
		{
			_GKFriendRequestComposeViewControllerDelegate gKFriendRequestComposeViewControllerDelegate = EnsureGKFriendRequestComposeViewControllerDelegate();
			gKFriendRequestComposeViewControllerDelegate.didFinish = (EventHandler)Delegate.Combine(gKFriendRequestComposeViewControllerDelegate.didFinish, value);
		}
		remove
		{
			_GKFriendRequestComposeViewControllerDelegate gKFriendRequestComposeViewControllerDelegate = EnsureGKFriendRequestComposeViewControllerDelegate();
			gKFriendRequestComposeViewControllerDelegate.didFinish = (EventHandler)Delegate.Remove(gKFriendRequestComposeViewControllerDelegate.didFinish, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKFriendRequestComposeViewController()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKFriendRequestComposeViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKFriendRequestComposeViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKFriendRequestComposeViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKFriendRequestComposeViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addRecipientPlayers:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRecipientPlayers(GKPlayer[]? players)
	{
		NSArray nSArray = ((players == null) ? null : NSArray.FromNSObjects(players));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRecipientPlayers_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRecipientPlayers_Handle, nSArray?.Handle ?? IntPtr.Zero);
		}
		nSArray?.Dispose();
	}

	[Export("addRecipientsWithEmailAddresses:")]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'AddRecipientPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'AddRecipientPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRecipientsFromEmails(string[] emailAddresses)
	{
		if (emailAddresses == null)
		{
			throw new ArgumentNullException("emailAddresses");
		}
		NSArray nSArray = NSArray.FromStrings(emailAddresses);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRecipientsWithEmailAddresses_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRecipientsWithEmailAddresses_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("addRecipientsWithPlayerIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRecipientsFromPlayerIDs(string[] playerIDs)
	{
		if (playerIDs == null)
		{
			throw new ArgumentNullException("playerIDs");
		}
		NSArray nSArray = NSArray.FromStrings(playerIDs);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRecipientsWithPlayerIDs_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRecipientsWithPlayerIDs_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setMessage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMessage(string? message)
	{
		IntPtr arg = NSString.CreateNative(message);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMessage_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMessage_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	internal virtual _GKFriendRequestComposeViewControllerDelegate CreateInternalEventComposeViewDelegateType()
	{
		return new _GKFriendRequestComposeViewControllerDelegate();
	}

	internal _GKFriendRequestComposeViewControllerDelegate EnsureGKFriendRequestComposeViewControllerDelegate()
	{
		if (WeakComposeViewDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakComposeViewDelegate, GetInternalEventComposeViewDelegateType);
		}
		_GKFriendRequestComposeViewControllerDelegate gKFriendRequestComposeViewControllerDelegate = ComposeViewDelegate as _GKFriendRequestComposeViewControllerDelegate;
		if (gKFriendRequestComposeViewControllerDelegate == null)
		{
			gKFriendRequestComposeViewControllerDelegate = (_GKFriendRequestComposeViewControllerDelegate)(ComposeViewDelegate = CreateInternalEventComposeViewDelegateType());
		}
		return gKFriendRequestComposeViewControllerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakComposeViewDelegate_var = null;
		}
	}
}
