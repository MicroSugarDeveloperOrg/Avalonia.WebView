using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityWrapper : BaseWrapper, INSAccessibility, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public CGRect AccessibilityFrame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFrame", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("accessibilityFrame"));
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrame:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_CGRect(base.Handle, Selector.GetHandle("setAccessibilityFrame:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityIdentifier")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityIdentifier:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityParent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityParent", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityParent")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityParent:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityParent:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityFocused
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityFocused"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocused:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityFocused:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityElement")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityElement"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityElement:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityElement:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public CGPoint AccessibilityActivationPoint
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityActivationPoint"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityActivationPoint:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setAccessibilityActivationPoint:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityTopLevelUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTopLevelUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityTopLevelUIElement")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTopLevelUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityTopLevelUIElement:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSUrl? AccessibilityUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityURL")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityURL:"), (value == null) ? IntPtr.Zero : value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityValue:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityValueDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityValueDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityValueDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityValueDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityValueDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityVisibleChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVisibleChildren")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVisibleChildren:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilitySubrole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySubrole")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySubrole")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySubrole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySubrole:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityTitle")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityTitle:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityTitleUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTitleUIElement", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityTitleUIElement")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTitleUIElement:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityTitleUIElement:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityNextContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNextContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityNextContents")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNextContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityNextContents:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilityOrientation AccessibilityOrientation
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOrientation", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilityOrientation)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityOrientation"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrientation:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilityOrientation:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityOverflowButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityOverflowButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityOverflowButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOverflowButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityOverflowButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityPlaceholderValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPlaceholderValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPlaceholderValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPlaceholderValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityPlaceholderValue:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityPreviousContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityPreviousContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPreviousContents")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityPreviousContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityPreviousContents:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityRole
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRole")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRole")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRole:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityRole:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityRoleDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRoleDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRoleDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRoleDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityRoleDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilitySearchButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySearchButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySearchButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilitySearchMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySearchMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySearchMenu")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySearchMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySearchMenu:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilitySelected
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilitySelected")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilitySelected"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelected:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilitySelected:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySelectedChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedChildren")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedChildren:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityServesAsTitleForUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityServesAsTitleForUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityServesAsTitleForUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityServesAsTitleForUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityServesAsTitleForUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityShownMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityShownMenu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityShownMenu")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityShownMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityShownMenu:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMinValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMinValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMinValue:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMaxValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMaxValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMaxValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMaxValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMaxValue:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityLinkedUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLinkedUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityLinkedUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLinkedUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityLinkedUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityWindow")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityWindow:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityHelp
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHelp")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHelp")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHelp:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityHelp:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityFilename
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFilename")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityFilename")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFilename:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityFilename:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityExpanded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityExpanded")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityExpanded"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExpanded:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityExpanded:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityEdited
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityEdited"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEdited:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityEdited:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityEnabled"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityEnabled:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityChildren
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityChildren", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityChildren")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityChildren:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityChildren:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityClearButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityClearButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityClearButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityClearButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityClearButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityCancelButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCancelButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityCancelButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCancelButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityCancelButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityProtectedContent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityProtectedContent")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityProtectedContent"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProtectedContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityProtectedContent:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityContents
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityContents", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityContents")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityContents:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityContents:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityLabel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityLabel")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityAlternateUIVisible
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityAlternateUIVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityAlternateUIVisible"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAlternateUIVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityAlternateUIVisible:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySharedFocusElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedFocusElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySharedFocusElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedFocusElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySharedFocusElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityApplicationFocusedUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityApplicationFocusedUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityApplicationFocusedUIElement")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityApplicationFocusedUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityApplicationFocusedUIElement:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMainWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMainWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMainWindow")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMainWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMainWindow:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityHidden
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityHidden"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityHidden:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityFrontmost
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityFrontmost")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityFrontmost"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFrontmost:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityFrontmost:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityFocusedWindow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFocusedWindow", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityFocusedWindow")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFocusedWindow:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityFocusedWindow:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityWindows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWindows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityWindows")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWindows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityWindows:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityExtrasMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityExtrasMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityExtrasMenuBar")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityExtrasMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityExtrasMenuBar:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMenuBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMenuBar", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMenuBar")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMenuBar:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMenuBar:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityColumnTitles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnTitles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityColumnTitles")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnTitles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityColumnTitles:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityOrderedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityOrderedByRow")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityOrderedByRow"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityOrderedByRow:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityOrderedByRow:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilityUnits AccessibilityHorizontalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHorizontalUnits"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilityHorizontalUnits:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilityUnits AccessibilityVerticalUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVerticalUnits"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilityVerticalUnits:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityHorizontalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHorizontalUnitDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityHorizontalUnitDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityVerticalUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVerticalUnitDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVerticalUnitDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityHandles
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHandles", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHandles")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHandles:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityHandles:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityWarningValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityWarningValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityWarningValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityWarningValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityWarningValue:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityCriticalValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCriticalValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityCriticalValue")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCriticalValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityCriticalValue:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityDisclosed
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityDisclosed")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityDisclosed"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosed:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityDisclosed:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityDisclosedByRow
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedByRow", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDisclosedByRow")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedByRow:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityDisclosedByRow:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityDisclosedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosedRows", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDisclosedRows")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosedRows:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityDisclosedRows:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityDisclosureLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDisclosureLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDisclosureLevel"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDisclosureLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityDisclosureLevel:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityMarkerUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMarkerUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMarkerUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMarkerValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerValues", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMarkerValues")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerValues:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMarkerValues:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMarkerGroupUIElement
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerGroupUIElement", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMarkerGroupUIElement")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerGroupUIElement:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMarkerGroupUIElement:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilityUnits AccessibilityUnits
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnits", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilityUnits)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityUnits"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnits:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilityUnits:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityUnitDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityUnitDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityUnitDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityUnitDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityUnitDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilityRulerMarkerType AccessibilityRulerMarkerType
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRulerMarkerType", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilityRulerMarkerType)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRulerMarkerType"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRulerMarkerType:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilityRulerMarkerType:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityMarkerTypeDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMarkerTypeDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMarkerTypeDescription")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMarkerTypeDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMarkerTypeDescription:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityHorizontalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHorizontalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHorizontalScrollBar")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHorizontalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityHorizontalScrollBar:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityVerticalScrollBar
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVerticalScrollBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVerticalScrollBar")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVerticalScrollBar:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVerticalScrollBar:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSNumber[]? AccessibilityAllowedValues
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityAllowedValues", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityAllowedValues")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityAllowedValues:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityAllowedValues:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityLabelUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityLabelUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityLabelUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public float AccessibilityLabelValue
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityLabelValue")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityLabelValue"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityLabelValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setAccessibilityLabelValue:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySplitters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySplitters", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySplitters")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySplitters:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySplitters:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityDecrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDecrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDecrementButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDecrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityDecrementButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityIncrementButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIncrementButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityIncrementButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIncrementButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityIncrementButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityTabs
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityTabs", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityTabs")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityTabs:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityTabs:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityHeader
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityHeader", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityHeader")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityHeader:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityHeader:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityColumnCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnCount")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityColumnCount"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityColumnCount:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityRowCount
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowCount")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRowCount"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityRowCount:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityIndex
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityIndex"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityIndex:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityColumns")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityColumns:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRows")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityRows:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityVisibleRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVisibleRows")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVisibleRows:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySelectedRows
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedRows", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedRows")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedRows:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedRows:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityVisibleColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVisibleColumns")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVisibleColumns:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySelectedColumns
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedColumns", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedColumns")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedColumns:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedColumns:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSAccessibilitySortDirection AccessibilitySortDirection
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySortDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAccessibilitySortDirection)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySortDirection"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySortDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setAccessibilitySortDirection:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityRowHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRowHeaderUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityRowHeaderUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySelectedCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedCells")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedCells:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityVisibleCells
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCells", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVisibleCells")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCells:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityVisibleCells:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilityColumnHeaderUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnHeaderUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityColumnHeaderUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnHeaderUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityColumnHeaderUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSRange AccessibilityRowIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityRowIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityRowIndexRange"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityRowIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("setAccessibilityRowIndexRange:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSRange AccessibilityColumnIndexRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityColumnIndexRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityColumnIndexRange"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityColumnIndexRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("setAccessibilityColumnIndexRange:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityInsertionPointLineNumber
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityInsertionPointLineNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityInsertionPointLineNumber"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityInsertionPointLineNumber:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityInsertionPointLineNumber:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSRange AccessibilitySharedCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySharedCharacterRange"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("setAccessibilitySharedCharacterRange:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject[]? AccessibilitySharedTextUIElements
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySharedTextUIElements", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySharedTextUIElements")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySharedTextUIElements:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySharedTextUIElements:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSRange AccessibilityVisibleCharacterRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityVisibleCharacterRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityVisibleCharacterRange"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityVisibleCharacterRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("setAccessibilityVisibleCharacterRange:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public nint AccessibilityNumberOfCharacters
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityNumberOfCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityNumberOfCharacters"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityNumberOfCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setAccessibilityNumberOfCharacters:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilitySelectedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedText")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedText")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedText:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedText:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSRange AccessibilitySelectedTextRange
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRange", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedTextRange"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRange:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("setAccessibilitySelectedTextRange:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSValue[]? AccessibilitySelectedTextRanges
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilitySelectedTextRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilitySelectedTextRanges")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilitySelectedTextRanges:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilitySelectedTextRanges:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityToolbarButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityToolbarButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityToolbarButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityToolbarButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityToolbarButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityModal
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityModal")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityModal"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityModal:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityModal:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityProxy
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityProxy", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityProxy")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityProxy:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityProxy:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityMain
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMain")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityMain"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMain:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityMain:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityFullScreenButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityFullScreenButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityFullScreenButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityFullScreenButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityFullScreenButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityGrowArea
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityGrowArea", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityGrowArea")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityGrowArea:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityGrowArea:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public string? AccessibilityDocument
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDocument")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDocument:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityDocument:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityDefaultButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityDefaultButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityDefaultButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityDefaultButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityDefaultButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityCloseButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityCloseButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityCloseButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityCloseButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityCloseButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityZoomButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityZoomButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityZoomButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityZoomButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityZoomButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public NSObject? AccessibilityMinimizeButton
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("accessibilityMinimizeButton", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityMinimizeButton")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimizeButton:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAccessibilityMinimizeButton:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool AccessibilityMinimized
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isAccessibilityMinimized")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isAccessibilityMinimized"));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setAccessibilityMinimized:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAccessibilityMinimized:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public NSAccessibilityWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accessibilityLayoutPointForScreenPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint GetAccessibilityLayoutForScreen(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("accessibilityLayoutPointForScreenPoint:"), point);
	}

	[Export("accessibilityLayoutSizeForScreenSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGSize GetAccessibilityLayoutForScreen(CGSize size)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, Selector.GetHandle("accessibilityLayoutSizeForScreenSize:"), size);
	}

	[Export("accessibilityScreenPointForLayoutPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint GetAccessibilityScreenForLayout(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("accessibilityScreenPointForLayoutPoint:"), point);
	}

	[Export("accessibilityScreenSizeForLayoutSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGSize GetAccessibilityScreenForLayout(CGSize size)
	{
		NSApplication.EnsureUIThread();
		return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, Selector.GetHandle("accessibilityScreenSizeForLayoutSize:"), size);
	}

	[Export("accessibilityCellForColumn:row:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject? GetAccessibilityCellForColumn(nint column, nint row)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint_nint(base.Handle, Selector.GetHandle("accessibilityCellForColumn:row:"), column, row));
	}

	[Export("accessibilityAttributedStringForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString? GetAccessibilityAttributedString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("accessibilityAttributedStringForRange:"), range));
	}

	[Export("accessibilityRangeForLine:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetAccessibilityRangeForLine(nint line)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityRangeForLine:"), line);
	}

	[Export("accessibilityStringForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? GetAccessibilityString(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("accessibilityStringForRange:"), range));
	}

	[Export("accessibilityRangeForPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetAccessibilityRange(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("accessibilityRangeForPosition:"), point);
	}

	[Export("accessibilityRangeForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetAccessibilityRange(nint index)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityRangeForIndex:"), index);
	}

	[Export("accessibilityFrameForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetAccessibilityFrame(NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_NSRange(out var retval, base.Handle, Selector.GetHandle("accessibilityFrameForRange:"), range);
		return retval;
	}

	[Export("accessibilityRTFForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData? GetAccessibilityRtf(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("accessibilityRTFForRange:"), range));
	}

	[Export("accessibilityStyleRangeForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange GetAccessibilityStyleRange(nint index)
	{
		NSApplication.EnsureUIThread();
		return Messaging.NSRange_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityStyleRangeForIndex:"), index);
	}

	[Export("accessibilityLineForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint GetAccessibilityLine(nint index)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nint_objc_msgSend_nint(base.Handle, Selector.GetHandle("accessibilityLineForIndex:"), index);
	}

	[Export("accessibilityPerformCancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformCancel()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformCancel"));
	}

	[Export("accessibilityPerformConfirm")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformConfirm()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformConfirm"));
	}

	[Export("accessibilityPerformDecrement")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformDecrement()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformDecrement"));
	}

	[Export("accessibilityPerformDelete")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformDelete()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformDelete"));
	}

	[Export("accessibilityPerformIncrement")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformIncrement()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformIncrement"));
	}

	[Export("accessibilityPerformPick")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformPick()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformPick"));
	}

	[Export("accessibilityPerformPress")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformPress()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformPress"));
	}

	[Export("accessibilityPerformRaise")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformRaise()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformRaise"));
	}

	[Export("accessibilityPerformShowAlternateUI")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformShowAlternateUI()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformShowAlternateUI"));
	}

	[Export("accessibilityPerformShowDefaultUI")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformShowDefaultUI()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformShowDefaultUI"));
	}

	[Export("accessibilityPerformShowMenu")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AccessibilityPerformShowMenu()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("accessibilityPerformShowMenu"));
	}

	[Export("isAccessibilitySelectorAllowed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsAccessibilitySelectorAllowed(Selector selector)
	{
		NSApplication.EnsureUIThread();
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("isAccessibilitySelectorAllowed:"), selector.Handle);
	}
}
