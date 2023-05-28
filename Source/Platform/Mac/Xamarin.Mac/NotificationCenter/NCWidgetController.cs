using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Register("NCWidgetController", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NCWidgetController : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasContent_ForWidgetWithBundleIdentifier_ = "setHasContent:forWidgetWithBundleIdentifier:";

	private static readonly IntPtr selSetHasContent_ForWidgetWithBundleIdentifier_Handle = Selector.GetHandle("setHasContent:forWidgetWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidgetController = "widgetController";

	private static readonly IntPtr selWidgetControllerHandle = Selector.GetHandle("widgetController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NCWidgetController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NCWidgetController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NCWidgetController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("widgetController")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NCWidgetController GetWidgetController()
	{
		return Runtime.GetNSObject<NCWidgetController>(Messaging.IntPtr_objc_msgSend(class_ptr, selWidgetControllerHandle));
	}

	[Export("setHasContent:forWidgetWithBundleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHasContent(bool flag, string bundleID)
	{
		if (bundleID == null)
		{
			throw new ArgumentNullException("bundleID");
		}
		IntPtr arg = NSString.CreateNative(bundleID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selSetHasContent_ForWidgetWithBundleIdentifier_Handle, flag, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetHasContent_ForWidgetWithBundleIdentifier_Handle, flag, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
