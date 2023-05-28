using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSButton", true)]
public class NSButton : NSControl, INSAccessibilityButton, INativeObject, IDisposable, INSAccessibilityElementProtocol, INSUserInterfaceCompression, INSUserInterfaceValidations
{
	private NSActionDispatcher dispatcher;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformPress = "accessibilityPerformPress";

	private static readonly IntPtr selAccessibilityPerformPressHandle = Selector.GetHandle("accessibilityPerformPress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveCompressionOptions = "activeCompressionOptions";

	private static readonly IntPtr selActiveCompressionOptionsHandle = Selector.GetHandle("activeCompressionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMixedState = "allowsMixedState";

	private static readonly IntPtr selAllowsMixedStateHandle = Selector.GetHandle("allowsMixedState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateImage = "alternateImage";

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateTitle = "alternateTitle";

	private static readonly IntPtr selAlternateTitleHandle = Selector.GetHandle("alternateTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedAlternateTitle = "attributedAlternateTitle";

	private static readonly IntPtr selAttributedAlternateTitleHandle = Selector.GetHandle("attributedAlternateTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedTitle = "attributedTitle";

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezelColor = "bezelColor";

	private static readonly IntPtr selBezelColorHandle = Selector.GetHandle("bezelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezelStyle = "bezelStyle";

	private static readonly IntPtr selBezelStyleHandle = Selector.GetHandle("bezelStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonWithImage_Target_Action_ = "buttonWithImage:target:action:";

	private static readonly IntPtr selButtonWithImage_Target_Action_Handle = Selector.GetHandle("buttonWithImage:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonWithTitle_Image_Target_Action_ = "buttonWithTitle:image:target:action:";

	private static readonly IntPtr selButtonWithTitle_Image_Target_Action_Handle = Selector.GetHandle("buttonWithTitle:image:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonWithTitle_Target_Action_ = "buttonWithTitle:target:action:";

	private static readonly IntPtr selButtonWithTitle_Target_Action_Handle = Selector.GetHandle("buttonWithTitle:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckboxWithTitle_Target_Action_ = "checkboxWithTitle:target:action:";

	private static readonly IntPtr selCheckboxWithTitle_Target_Action_Handle = Selector.GetHandle("checkboxWithTitle:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressWithPrioritizedCompressionOptions_ = "compressWithPrioritizedCompressionOptions:";

	private static readonly IntPtr selCompressWithPrioritizedCompressionOptions_Handle = Selector.GetHandle("compressWithPrioritizedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentTintColor = "contentTintColor";

	private static readonly IntPtr selContentTintColorHandle = Selector.GetHandle("contentTintColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPeriodicDelay_Interval_ = "getPeriodicDelay:interval:";

	private static readonly IntPtr selGetPeriodicDelay_Interval_Handle = Selector.GetHandle("getPeriodicDelay:interval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlight_ = "highlight:";

	private static readonly IntPtr selHighlight_Handle = Selector.GetHandle("highlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageHugsTitle = "imageHugsTitle";

	private static readonly IntPtr selImageHugsTitleHandle = Selector.GetHandle("imageHugsTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImagePosition = "imagePosition";

	private static readonly IntPtr selImagePositionHandle = Selector.GetHandle("imagePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageScaling = "imageScaling";

	private static readonly IntPtr selImageScalingHandle = Selector.GetHandle("imageScaling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBordered = "isBordered";

	private static readonly IntPtr selIsBorderedHandle = Selector.GetHandle("isBordered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSpringLoaded = "isSpringLoaded";

	private static readonly IntPtr selIsSpringLoadedHandle = Selector.GetHandle("isSpringLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTransparent = "isTransparent";

	private static readonly IntPtr selIsTransparentHandle = Selector.GetHandle("isTransparent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalent = "keyEquivalent";

	private static readonly IntPtr selKeyEquivalentHandle = Selector.GetHandle("keyEquivalent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentModifierMask = "keyEquivalentModifierMask";

	private static readonly IntPtr selKeyEquivalentModifierMaskHandle = Selector.GetHandle("keyEquivalentModifierMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxAcceleratorLevel = "maxAcceleratorLevel";

	private static readonly IntPtr selMaxAcceleratorLevelHandle = Selector.GetHandle("maxAcceleratorLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSizeWithPrioritizedCompressionOptions_ = "minimumSizeWithPrioritizedCompressionOptions:";

	private static readonly IntPtr selMinimumSizeWithPrioritizedCompressionOptions_Handle = Selector.GetHandle("minimumSizeWithPrioritizedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadioButtonWithTitle_Target_Action_ = "radioButtonWithTitle:target:action:";

	private static readonly IntPtr selRadioButtonWithTitle_Target_Action_Handle = Selector.GetHandle("radioButtonWithTitle:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMixedState_ = "setAllowsMixedState:";

	private static readonly IntPtr selSetAllowsMixedState_Handle = Selector.GetHandle("setAllowsMixedState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateImage_ = "setAlternateImage:";

	private static readonly IntPtr selSetAlternateImage_Handle = Selector.GetHandle("setAlternateImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateTitle_ = "setAlternateTitle:";

	private static readonly IntPtr selSetAlternateTitle_Handle = Selector.GetHandle("setAlternateTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedAlternateTitle_ = "setAttributedAlternateTitle:";

	private static readonly IntPtr selSetAttributedAlternateTitle_Handle = Selector.GetHandle("setAttributedAlternateTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedTitle_ = "setAttributedTitle:";

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezelColor_ = "setBezelColor:";

	private static readonly IntPtr selSetBezelColor_Handle = Selector.GetHandle("setBezelColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezelStyle_ = "setBezelStyle:";

	private static readonly IntPtr selSetBezelStyle_Handle = Selector.GetHandle("setBezelStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBordered_ = "setBordered:";

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetButtonType_ = "setButtonType:";

	private static readonly IntPtr selSetButtonType_Handle = Selector.GetHandle("setButtonType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentTintColor_ = "setContentTintColor:";

	private static readonly IntPtr selSetContentTintColor_Handle = Selector.GetHandle("setContentTintColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageHugsTitle_ = "setImageHugsTitle:";

	private static readonly IntPtr selSetImageHugsTitle_Handle = Selector.GetHandle("setImageHugsTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImagePosition_ = "setImagePosition:";

	private static readonly IntPtr selSetImagePosition_Handle = Selector.GetHandle("setImagePosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageScaling_ = "setImageScaling:";

	private static readonly IntPtr selSetImageScaling_Handle = Selector.GetHandle("setImageScaling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalent_ = "setKeyEquivalent:";

	private static readonly IntPtr selSetKeyEquivalent_Handle = Selector.GetHandle("setKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalentModifierMask_ = "setKeyEquivalentModifierMask:";

	private static readonly IntPtr selSetKeyEquivalentModifierMask_Handle = Selector.GetHandle("setKeyEquivalentModifierMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxAcceleratorLevel_ = "setMaxAcceleratorLevel:";

	private static readonly IntPtr selSetMaxAcceleratorLevel_Handle = Selector.GetHandle("setMaxAcceleratorLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNextState = "setNextState";

	private static readonly IntPtr selSetNextStateHandle = Selector.GetHandle("setNextState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPeriodicDelay_Interval_ = "setPeriodicDelay:interval:";

	private static readonly IntPtr selSetPeriodicDelay_Interval_Handle = Selector.GetHandle("setPeriodicDelay:interval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsBorderOnlyWhileMouseInside_ = "setShowsBorderOnlyWhileMouseInside:";

	private static readonly IntPtr selSetShowsBorderOnlyWhileMouseInside_Handle = Selector.GetHandle("setShowsBorderOnlyWhileMouseInside:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSound_ = "setSound:";

	private static readonly IntPtr selSetSound_Handle = Selector.GetHandle("setSound:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpringLoaded_ = "setSpringLoaded:";

	private static readonly IntPtr selSetSpringLoaded_Handle = Selector.GetHandle("setSpringLoaded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetState_ = "setState:";

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleWithMnemonic_ = "setTitleWithMnemonic:";

	private static readonly IntPtr selSetTitleWithMnemonic_Handle = Selector.GetHandle("setTitleWithMnemonic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransparent_ = "setTransparent:";

	private static readonly IntPtr selSetTransparent_Handle = Selector.GetHandle("setTransparent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsBorderOnlyWhileMouseInside = "showsBorderOnlyWhileMouseInside";

	private static readonly IntPtr selShowsBorderOnlyWhileMouseInsideHandle = Selector.GetHandle("showsBorderOnlyWhileMouseInside");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSound = "sound";

	private static readonly IntPtr selSoundHandle = Selector.GetHandle("sound");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSButton");

	public new NSButtonCell Cell
	{
		get
		{
			return (NSButtonCell)base.Cell;
		}
		set
		{
			base.Cell = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceCompressionOptions ActiveCompressionOptions
	{
		[Export("activeCompressionOptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveCompressionOptionsHandle));
			}
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveCompressionOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMixedState
	{
		[Export("allowsMixedState")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMixedStateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMixedStateHandle);
		}
		[Export("setAllowsMixedState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMixedState_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMixedState_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? AlternateImage
	{
		[Export("alternateImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle));
		}
		[Export("setAlternateImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AlternateTitle
	{
		[Export("alternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateTitleHandle));
		}
		[Export("setAlternateTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedAlternateTitle
	{
		[Export("attributedAlternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedAlternateTitleHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedAlternateTitleHandle));
		}
		[Export("setAttributedAlternateTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedTitle
	{
		[Export("attributedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedTitleHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedTitleHandle));
		}
		[Export("setAttributedTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedTitle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSColor? BezelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("bezelColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBezelColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBezelColorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("setBezelColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBezelColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBezelColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezelStyle BezelStyle
	{
		[Export("bezelStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBezelStyle)Messaging.UInt64_objc_msgSend(base.Handle, selBezelStyleHandle);
			}
			return (NSBezelStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBezelStyleHandle);
		}
		[Export("setBezelStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBezelStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBezelStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bordered
	{
		[Export("isBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBorderedHandle);
		}
		[Export("setBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSColor? ContentTintColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("contentTintColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentTintColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentTintColorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setContentTintColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentTintColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentTintColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? Image
	{
		[Export("image", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
		[Export("setImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool ImageHugsTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("imageHugsTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImageHugsTitleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImageHugsTitleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setImageHugsTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImageHugsTitle_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImageHugsTitle_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCellImagePosition ImagePosition
	{
		[Export("imagePosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCellImagePosition)Messaging.UInt64_objc_msgSend(base.Handle, selImagePositionHandle);
			}
			return (NSCellImagePosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImagePositionHandle);
		}
		[Export("setImagePosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImagePosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImagePosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageScale ImageScaling
	{
		[Export("imageScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSImageScale)Messaging.UInt64_objc_msgSend(base.Handle, selImageScalingHandle);
			}
			return (NSImageScale)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageScalingHandle);
		}
		[Export("setImageScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageScaling_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	public virtual bool IsSpringLoaded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("isSpringLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpringLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpringLoadedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("setSpringLoaded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSpringLoaded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSpringLoaded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string KeyEquivalent
	{
		[Export("keyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentHandle));
		}
		[Export("setKeyEquivalent:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyEquivalent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyEquivalent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEventModifierMask KeyEquivalentModifierMask
	{
		[Export("keyEquivalentModifierMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selKeyEquivalentModifierMaskHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentModifierMaskHandle);
		}
		[Export("setKeyEquivalentModifierMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	public virtual nint MaxAcceleratorLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("maxAcceleratorLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxAcceleratorLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxAcceleratorLevelHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("setMaxAcceleratorLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxAcceleratorLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxAcceleratorLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsBorderOnlyWhileMouseInside
	{
		[Export("showsBorderOnlyWhileMouseInside")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBorderOnlyWhileMouseInsideHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBorderOnlyWhileMouseInsideHandle);
		}
		[Export("setShowsBorderOnlyWhileMouseInside:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSound Sound
	{
		[Export("sound")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSound>(Messaging.IntPtr_objc_msgSend(base.Handle, selSoundHandle));
			}
			return Runtime.GetNSObject<NSSound>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSoundHandle));
		}
		[Export("setSound:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSound_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSound_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCellStateValue State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCellStateValue)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSCellStateValue)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
		[Export("setState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetState_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Transparent
	{
		[Export("isTransparent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTransparentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTransparentHandle);
		}
		[Export("setTransparent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTransparent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTransparent_Handle, value);
			}
		}
	}

	[Mac(10, 12)]
	public static NSButton CreateButton(string title, NSImage image, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSButton nSButton = _CreateButton(title, image, nSActionDispatcher, NSDispatcher.Selector);
		nSButton.dispatcher = nSActionDispatcher;
		return nSButton;
	}

	[Mac(10, 12)]
	public static NSButton CreateButton(string title, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSButton nSButton = _CreateButton(title, nSActionDispatcher, NSDispatcher.Selector);
		nSButton.dispatcher = nSActionDispatcher;
		return nSButton;
	}

	[Mac(10, 12)]
	public static NSButton CreateButton(NSImage image, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSButton nSButton = _CreateButton(image, nSActionDispatcher, NSDispatcher.Selector);
		nSButton.dispatcher = nSActionDispatcher;
		return nSButton;
	}

	[Mac(10, 12)]
	public static NSButton CreateCheckbox(string title, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSButton nSButton = _CreateCheckbox(title, nSActionDispatcher, NSDispatcher.Selector);
		nSButton.dispatcher = nSActionDispatcher;
		return nSButton;
	}

	[Mac(10, 12)]
	public static NSButton CreateRadioButton(string title, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSButton nSButton = _CreateRadioButton(title, nSActionDispatcher, NSDispatcher.Selector);
		nSButton.dispatcher = nSActionDispatcher;
		return nSButton;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSButton()
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
	public NSButton(NSCoder coder)
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
	protected NSButton(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSButton(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSButton(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("accessibilityPerformPress")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AccessibilityPerformPress()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPressHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPressHandle);
	}

	[Export("compressWithPrioritizedCompressionOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Compress(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCompressWithPrioritizedCompressionOptions_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompressWithPrioritizedCompressionOptions_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("minimumSizeWithPrioritizedCompressionOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetMinimumSize(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		CGSize result = ((!base.IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinimumSizeWithPrioritizedCompressionOptions_Handle, nSArray.Handle) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selMinimumSizeWithPrioritizedCompressionOptions_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("getPeriodicDelay:interval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetPeriodicDelay(ref float delay, ref float interval)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_ref_Single_ref_Single(base.Handle, selGetPeriodicDelay_Interval_Handle, ref delay, ref interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_ref_Single_ref_Single(base.SuperHandle, selGetPeriodicDelay_Interval_Handle, ref delay, ref interval);
		}
	}

	[Export("highlight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Highlight(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selHighlight_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selHighlight_Handle, flag);
		}
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool PerformKeyEquivalent(NSEvent key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, key.Handle);
	}

	[Export("setButtonType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetButtonType(NSButtonType aType)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetButtonType_Handle, (ulong)aType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetButtonType_Handle, (ulong)aType);
		}
	}

	[Export("setNextState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetNextState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetNextStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetNextStateHandle);
		}
	}

	[Export("setPeriodicDelay:interval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPeriodicDelay(float delay, float interval)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float(base.Handle, selSetPeriodicDelay_Interval_Handle, delay, interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float(base.SuperHandle, selSetPeriodicDelay_Interval_Handle, delay, interval);
		}
	}

	[Export("setTitleWithMnemonic:")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "On 10.8, this method still will set the Title with the ampersand stripped from stringWithAmpersand, but does nothing else. Set the Title directly.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTitleWithMnemonic(string mnemonic)
	{
		NSApplication.EnsureUIThread();
		if (mnemonic == null)
		{
			throw new ArgumentNullException("mnemonic");
		}
		IntPtr arg = NSString.CreateNative(mnemonic);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithMnemonic_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithMnemonic_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("validateUserInterfaceItem:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, item.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, item.Handle);
	}

	[Export("buttonWithTitle:image:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSButton _CreateButton(string title, NSImage image, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton nSObject = Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selButtonWithTitle_Image_Target_Action_Handle, arg, image.Handle, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("buttonWithTitle:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSButton _CreateButton(string title, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton nSObject = Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selButtonWithTitle_Target_Action_Handle, arg, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("buttonWithImage:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSButton _CreateButton(NSImage image, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selButtonWithImage_Target_Action_Handle, image.Handle, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
	}

	[Export("checkboxWithTitle:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSButton _CreateCheckbox(string title, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton nSObject = Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selCheckboxWithTitle_Target_Action_Handle, arg, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("radioButtonWithTitle:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSButton _CreateRadioButton(string title, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton nSObject = Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRadioButtonWithTitle_Target_Action_Handle, arg, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
