using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTokenFieldCell", true)]
public class NSTokenFieldCell : NSTextFieldCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionDelay = "completionDelay";

	private static readonly IntPtr selCompletionDelayHandle = Selector.GetHandle("completionDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCompletionDelay = "defaultCompletionDelay";

	private static readonly IntPtr selDefaultCompletionDelayHandle = Selector.GetHandle("defaultCompletionDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTokenizingCharacterSet = "defaultTokenizingCharacterSet";

	private static readonly IntPtr selDefaultTokenizingCharacterSetHandle = Selector.GetHandle("defaultTokenizingCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletionDelay_ = "setCompletionDelay:";

	private static readonly IntPtr selSetCompletionDelay_Handle = Selector.GetHandle("setCompletionDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTokenStyle_ = "setTokenStyle:";

	private static readonly IntPtr selSetTokenStyle_Handle = Selector.GetHandle("setTokenStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTokenizingCharacterSet_ = "setTokenizingCharacterSet:";

	private static readonly IntPtr selSetTokenizingCharacterSet_Handle = Selector.GetHandle("setTokenizingCharacterSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenStyle = "tokenStyle";

	private static readonly IntPtr selTokenStyleHandle = Selector.GetHandle("tokenStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenizingCharacterSet = "tokenizingCharacterSet";

	private static readonly IntPtr selTokenizingCharacterSetHandle = Selector.GetHandle("tokenizingCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTokenFieldCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCharacterSet? CharacterSet
	{
		[Export("tokenizingCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selTokenizingCharacterSetHandle));
			}
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTokenizingCharacterSetHandle));
		}
		[Export("setTokenizingCharacterSet:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTokenizingCharacterSet_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTokenizingCharacterSet_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CompletionDelay
	{
		[Export("completionDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCompletionDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCompletionDelayHandle);
		}
		[Export("setCompletionDelay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCompletionDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCompletionDelay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet DefaultCharacterSet
	{
		[Export("defaultTokenizingCharacterSet")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultTokenizingCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double DefaultCompletionDelay
	{
		[Export("defaultCompletionDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDefaultCompletionDelayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSTokenFieldCellDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTokenFieldCellDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTokenStyle TokenStyle
	{
		[Export("tokenStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTokenStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTokenStyleHandle);
			}
			return (NSTokenStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTokenStyleHandle);
		}
		[Export("setTokenStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTokenStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTokenStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTokenFieldCell(NSCoder coder)
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
	protected NSTokenFieldCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTokenFieldCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTokenFieldCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
