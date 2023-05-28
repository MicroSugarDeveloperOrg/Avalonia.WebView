using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationAppleIDButton", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationAppleIdButton : NSControl, INSAccessibilityButton, INativeObject, IDisposable, INSAccessibilityElementProtocol
{
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
	private const string selButtonWithType_Style_ = "buttonWithType:style:";

	private static readonly IntPtr selButtonWithType_Style_Handle = Selector.GetHandle("buttonWithType:style:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCornerRadius = "cornerRadius";

	private static readonly IntPtr selCornerRadiusHandle = Selector.GetHandle("cornerRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAuthorizationButtonType_AuthorizationButtonStyle_ = "initWithAuthorizationButtonType:authorizationButtonStyle:";

	private static readonly IntPtr selInitWithAuthorizationButtonType_AuthorizationButtonStyle_Handle = Selector.GetHandle("initWithAuthorizationButtonType:authorizationButtonStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCornerRadius_ = "setCornerRadius:";

	private static readonly IntPtr selSetCornerRadius_Handle = Selector.GetHandle("setCornerRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationAppleIDButton");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
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
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual nfloat CornerRadius
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("cornerRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selCornerRadiusHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selCornerRadiusHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setCornerRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetCornerRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetCornerRadius_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public ASAuthorizationAppleIdButton(NSCoder coder)
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
	protected ASAuthorizationAppleIdButton(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationAppleIdButton(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAuthorizationButtonType:authorizationButtonStyle:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ASAuthorizationAppleIdButton(ASAuthorizationAppleIdButtonType type, ASAuthorizationAppleIdButtonStyle style)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selInitWithAuthorizationButtonType_AuthorizationButtonStyle_Handle, (long)type, (long)style), "initWithAuthorizationButtonType:authorizationButtonStyle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selInitWithAuthorizationButtonType_AuthorizationButtonStyle_Handle, (long)type, (long)style), "initWithAuthorizationButtonType:authorizationButtonStyle:");
		}
	}

	[Export("accessibilityPerformPress")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AccessibilityPerformPress()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformPressHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformPressHandle);
	}

	[Export("buttonWithType:style:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ASAuthorizationAppleIdButton Create(ASAuthorizationAppleIdButtonType type, ASAuthorizationAppleIdButtonStyle style)
	{
		return Runtime.GetNSObject<ASAuthorizationAppleIdButton>(Messaging.IntPtr_objc_msgSend_Int64_Int64(class_ptr, selButtonWithType_Style_Handle, (long)type, (long)style));
	}
}
