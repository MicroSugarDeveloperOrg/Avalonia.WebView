using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNNotificationServiceExtension", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class UNNotificationServiceExtension : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidReceiveNotificationRequest_WithContentHandler_ = "didReceiveNotificationRequest:withContentHandler:";

	private static readonly IntPtr selDidReceiveNotificationRequest_WithContentHandler_Handle = Selector.GetHandle("didReceiveNotificationRequest:withContentHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceExtensionTimeWillExpire = "serviceExtensionTimeWillExpire";

	private static readonly IntPtr selServiceExtensionTimeWillExpireHandle = Selector.GetHandle("serviceExtensionTimeWillExpire");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNNotificationServiceExtension");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected UNNotificationServiceExtension(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNNotificationServiceExtension(IntPtr handle)
		: base(handle)
	{
	}

	[Export("didReceiveNotificationRequest:withContentHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DidReceiveNotificationRequest(UNNotificationRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity1V87))] Action<UNNotificationContent> contentHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (contentHandler == null)
		{
			throw new ArgumentNullException("contentHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V87.Handler, contentHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDidReceiveNotificationRequest_WithContentHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDidReceiveNotificationRequest_WithContentHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("serviceExtensionTimeWillExpire")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TimeWillExpire()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selServiceExtensionTimeWillExpireHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selServiceExtensionTimeWillExpireHandle);
		}
	}
}
