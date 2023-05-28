using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace WebKit;

[Register("WKNavigationAction", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKNavigationAction : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonNumber = "buttonNumber";

	private static readonly IntPtr selButtonNumberHandle = Selector.GetHandle("buttonNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifierFlags = "modifierFlags";

	private static readonly IntPtr selModifierFlagsHandle = Selector.GetHandle("modifierFlags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNavigationType = "navigationType";

	private static readonly IntPtr selNavigationTypeHandle = Selector.GetHandle("navigationType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequest = "request";

	private static readonly IntPtr selRequestHandle = Selector.GetHandle("request");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFrame = "sourceFrame";

	private static readonly IntPtr selSourceFrameHandle = Selector.GetHandle("sourceFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetFrame = "targetFrame";

	private static readonly IntPtr selTargetFrameHandle = Selector.GetHandle("targetFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKNavigationAction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ButtonNumber
	{
		[Export("buttonNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selButtonNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selButtonNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEventModifierMask ModifierFlags
	{
		[Export("modifierFlags")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selModifierFlagsHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModifierFlagsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKNavigationType NavigationType
	{
		[Export("navigationType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (WKNavigationType)Messaging.Int64_objc_msgSend(base.Handle, selNavigationTypeHandle);
			}
			return (WKNavigationType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNavigationTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest Request
	{
		[Export("request", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestHandle));
			}
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKFrameInfo SourceFrame
	{
		[Export("sourceFrame", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceFrameHandle));
			}
			return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKFrameInfo TargetFrame
	{
		[Export("targetFrame", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetFrameHandle));
			}
			return Runtime.GetNSObject<WKFrameInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetFrameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKNavigationAction()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKNavigationAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKNavigationAction(IntPtr handle)
		: base(handle)
	{
	}
}
