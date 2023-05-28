using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPopoverTouchBarItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSPopoverTouchBarItem : NSTouchBarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsedRepresentation = "collapsedRepresentation";

	private static readonly IntPtr selCollapsedRepresentationHandle = Selector.GetHandle("collapsedRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsedRepresentationImage = "collapsedRepresentationImage";

	private static readonly IntPtr selCollapsedRepresentationImageHandle = Selector.GetHandle("collapsedRepresentationImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsedRepresentationLabel = "collapsedRepresentationLabel";

	private static readonly IntPtr selCollapsedRepresentationLabelHandle = Selector.GetHandle("collapsedRepresentationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationLabel = "customizationLabel";

	private static readonly IntPtr selCustomizationLabelHandle = Selector.GetHandle("customizationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissPopover_ = "dismissPopover:";

	private static readonly IntPtr selDismissPopover_Handle = Selector.GetHandle("dismissPopover:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeStandardActivatePopoverGestureRecognizer = "makeStandardActivatePopoverGestureRecognizer";

	private static readonly IntPtr selMakeStandardActivatePopoverGestureRecognizerHandle = Selector.GetHandle("makeStandardActivatePopoverGestureRecognizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPopoverTouchBar = "popoverTouchBar";

	private static readonly IntPtr selPopoverTouchBarHandle = Selector.GetHandle("popoverTouchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressAndHoldTouchBar = "pressAndHoldTouchBar";

	private static readonly IntPtr selPressAndHoldTouchBarHandle = Selector.GetHandle("pressAndHoldTouchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsedRepresentation_ = "setCollapsedRepresentation:";

	private static readonly IntPtr selSetCollapsedRepresentation_Handle = Selector.GetHandle("setCollapsedRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsedRepresentationImage_ = "setCollapsedRepresentationImage:";

	private static readonly IntPtr selSetCollapsedRepresentationImage_Handle = Selector.GetHandle("setCollapsedRepresentationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsedRepresentationLabel_ = "setCollapsedRepresentationLabel:";

	private static readonly IntPtr selSetCollapsedRepresentationLabel_Handle = Selector.GetHandle("setCollapsedRepresentationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationLabel_ = "setCustomizationLabel:";

	private static readonly IntPtr selSetCustomizationLabel_Handle = Selector.GetHandle("setCustomizationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPopoverTouchBar_ = "setPopoverTouchBar:";

	private static readonly IntPtr selSetPopoverTouchBar_Handle = Selector.GetHandle("setPopoverTouchBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPressAndHoldTouchBar_ = "setPressAndHoldTouchBar:";

	private static readonly IntPtr selSetPressAndHoldTouchBar_Handle = Selector.GetHandle("setPressAndHoldTouchBar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsCloseButton_ = "setShowsCloseButton:";

	private static readonly IntPtr selSetShowsCloseButton_Handle = Selector.GetHandle("setShowsCloseButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowPopover_ = "showPopover:";

	private static readonly IntPtr selShowPopover_Handle = Selector.GetHandle("showPopover:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsCloseButton = "showsCloseButton";

	private static readonly IntPtr selShowsCloseButtonHandle = Selector.GetHandle("showsCloseButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPopoverTouchBarItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView CollapsedRepresentation
	{
		[Export("collapsedRepresentation", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollapsedRepresentationHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollapsedRepresentationHandle));
		}
		[Export("setCollapsedRepresentation:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollapsedRepresentation_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollapsedRepresentation_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? CollapsedRepresentationImage
	{
		[Export("collapsedRepresentationImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollapsedRepresentationImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollapsedRepresentationImageHandle));
		}
		[Export("setCollapsedRepresentationImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollapsedRepresentationImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollapsedRepresentationImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CollapsedRepresentationLabel
	{
		[Export("collapsedRepresentationLabel", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCollapsedRepresentationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollapsedRepresentationLabelHandle));
		}
		[Export("setCollapsedRepresentationLabel:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCollapsedRepresentationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCollapsedRepresentationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string CustomizationLabel
	{
		[Export("customizationLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationLabelHandle));
		}
		[Export("setCustomizationLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTouchBar PopoverTouchBar
	{
		[Export("popoverTouchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selPopoverTouchBarHandle));
			}
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPopoverTouchBarHandle));
		}
		[Export("setPopoverTouchBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPopoverTouchBar_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPopoverTouchBar_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTouchBar? PressAndHoldTouchBar
	{
		[Export("pressAndHoldTouchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selPressAndHoldTouchBarHandle));
			}
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPressAndHoldTouchBarHandle));
		}
		[Export("setPressAndHoldTouchBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPressAndHoldTouchBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPressAndHoldTouchBar_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsCloseButton
	{
		[Export("showsCloseButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsCloseButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsCloseButtonHandle);
		}
		[Export("setShowsCloseButton:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsCloseButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsCloseButton_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPopoverTouchBarItem(NSCoder coder)
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
	protected NSPopoverTouchBarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPopoverTouchBarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPopoverTouchBarItem(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("dismissPopover:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissPopover(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismissPopover_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismissPopover_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("makeStandardActivatePopoverGestureRecognizer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGestureRecognizer MakeStandardActivatePopoverGestureRecognizer()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSGestureRecognizer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMakeStandardActivatePopoverGestureRecognizerHandle));
		}
		return Runtime.GetNSObject<NSGestureRecognizer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMakeStandardActivatePopoverGestureRecognizerHandle));
	}

	[Export("showPopover:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowPopover(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowPopover_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowPopover_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}
}
