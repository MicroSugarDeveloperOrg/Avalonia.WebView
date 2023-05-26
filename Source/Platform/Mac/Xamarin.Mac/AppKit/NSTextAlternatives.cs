using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextAlternatives", true)]
public class NSTextAlternatives : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveSelectedAlternativeString(EventHandler<NSTextAlternativesSelectedAlternativeStringEventArgs> handler)
		{
			EventHandler<NSTextAlternativesSelectedAlternativeStringEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedAlternativeStringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextAlternativesSelectedAlternativeStringEventArgs(notification));
			});
		}

		public static NSObject ObserveSelectedAlternativeString(NSObject objectToObserve, EventHandler<NSTextAlternativesSelectedAlternativeStringEventArgs> handler)
		{
			EventHandler<NSTextAlternativesSelectedAlternativeStringEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SelectedAlternativeStringNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSTextAlternativesSelectedAlternativeStringEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternativeStrings = "alternativeStrings";

	private static readonly IntPtr selAlternativeStringsHandle = Selector.GetHandle("alternativeStrings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPrimaryString_AlternativeStrings_ = "initWithPrimaryString:alternativeStrings:";

	private static readonly IntPtr selInitWithPrimaryString_AlternativeStrings_Handle = Selector.GetHandle("initWithPrimaryString:alternativeStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteSelectedAlternativeString_ = "noteSelectedAlternativeString:";

	private static readonly IntPtr selNoteSelectedAlternativeString_Handle = Selector.GetHandle("noteSelectedAlternativeString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryString = "primaryString";

	private static readonly IntPtr selPrimaryStringHandle = Selector.GetHandle("primaryString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextAlternatives");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SelectedAlternativeStringNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray AlternativeStrings
	{
		[Export("alternativeStrings", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternativeStringsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternativeStringsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PrimaryString
	{
		[Export("primaryString", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrimaryStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrimaryStringHandle));
		}
	}

	[Field("NSTextAlternativesSelectedAlternativeStringNotification", "AppKit")]
	[Advice("Use NSTextAlternatives.Notifications.ObserveSelectedAlternativeString helper method instead.")]
	public static NSString SelectedAlternativeStringNotification
	{
		get
		{
			if (_SelectedAlternativeStringNotification == null)
			{
				_SelectedAlternativeStringNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextAlternativesSelectedAlternativeStringNotification");
			}
			return _SelectedAlternativeStringNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextAlternatives()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSTextAlternatives(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSTextAlternatives(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextAlternatives(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPrimaryString:alternativeStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextAlternatives(string primaryString, NSArray alternativeStrings)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (primaryString == null)
		{
			throw new ArgumentNullException("primaryString");
		}
		if (alternativeStrings == null)
		{
			throw new ArgumentNullException("alternativeStrings");
		}
		IntPtr arg = NSString.CreateNative(primaryString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithPrimaryString_AlternativeStrings_Handle, arg, alternativeStrings.Handle), "initWithPrimaryString:alternativeStrings:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithPrimaryString_AlternativeStrings_Handle, arg, alternativeStrings.Handle), "initWithPrimaryString:alternativeStrings:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("noteSelectedAlternativeString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteSelectedAlternativeString(string alternativeString)
	{
		NSApplication.EnsureUIThread();
		if (alternativeString == null)
		{
			throw new ArgumentNullException("alternativeString");
		}
		IntPtr arg = NSString.CreateNative(alternativeString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteSelectedAlternativeString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteSelectedAlternativeString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
