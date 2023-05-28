using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAccessibilityCustomRotorItemResult", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSAccessibilityCustomRotorItemResult : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomLabel = "customLabel";

	private static readonly IntPtr selCustomLabelHandle = Selector.GetHandle("customLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItemLoadingToken_CustomLabel_ = "initWithItemLoadingToken:customLabel:";

	private static readonly IntPtr selInitWithItemLoadingToken_CustomLabel_Handle = Selector.GetHandle("initWithItemLoadingToken:customLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTargetElement_ = "initWithTargetElement:";

	private static readonly IntPtr selInitWithTargetElement_Handle = Selector.GetHandle("initWithTargetElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemLoadingToken = "itemLoadingToken";

	private static readonly IntPtr selItemLoadingTokenHandle = Selector.GetHandle("itemLoadingToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomLabel_ = "setCustomLabel:";

	private static readonly IntPtr selSetCustomLabel_Handle = Selector.GetHandle("setCustomLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTargetRange_ = "setTargetRange:";

	private static readonly IntPtr selSetTargetRange_Handle = Selector.GetHandle("setTargetRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetElement = "targetElement";

	private static readonly IntPtr selTargetElementHandle = Selector.GetHandle("targetElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetRange = "targetRange";

	private static readonly IntPtr selTargetRangeHandle = Selector.GetHandle("targetRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAccessibilityCustomRotorItemResult");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TargetElement_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? CustomLabel
	{
		[Export("customLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomLabelHandle));
		}
		[Export("setCustomLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSSecureCoding? ItemLoadingToken
	{
		[Export("itemLoadingToken", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<INSSecureCoding>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemLoadingTokenHandle), owns: false);
			}
			return Runtime.GetINativeObject<INSSecureCoding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemLoadingTokenHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAccessibilityElement? TargetElement
	{
		[Export("targetElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSAccessibilityElement nSAccessibilityElement = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetElementHandle)) : Runtime.GetNSObject<NSAccessibilityElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetElementHandle)));
			MarkDirty();
			__mt_TargetElement_var = nSAccessibilityElement;
			return nSAccessibilityElement;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange TargetRange
	{
		[Export("targetRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selTargetRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selTargetRangeHandle);
		}
		[Export("setTargetRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetTargetRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetTargetRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAccessibilityCustomRotorItemResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAccessibilityCustomRotorItemResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTargetElement:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomRotorItemResult(NSAccessibilityElement targetElement)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (targetElement == null)
		{
			throw new ArgumentNullException("targetElement");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTargetElement_Handle, targetElement.Handle), "initWithTargetElement:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTargetElement_Handle, targetElement.Handle), "initWithTargetElement:");
		}
	}

	[Export("initWithItemLoadingToken:customLabel:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomRotorItemResult(INSSecureCoding itemLoadingToken, string customLabel)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (itemLoadingToken == null)
		{
			throw new ArgumentNullException("itemLoadingToken");
		}
		if (customLabel == null)
		{
			throw new ArgumentNullException("customLabel");
		}
		IntPtr arg = NSString.CreateNative(customLabel);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithItemLoadingToken_CustomLabel_Handle, itemLoadingToken.Handle, arg), "initWithItemLoadingToken:customLabel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithItemLoadingToken_CustomLabel_Handle, itemLoadingToken.Handle, arg), "initWithItemLoadingToken:customLabel:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TargetElement_var = null;
		}
	}
}
