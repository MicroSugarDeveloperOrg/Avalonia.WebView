using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchSubscriptionsOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CKFetchSubscriptionsOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAllSubscriptionsOperation = "fetchAllSubscriptionsOperation";

	private static readonly IntPtr selFetchAllSubscriptionsOperationHandle = Selector.GetHandle("fetchAllSubscriptionsOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchSubscriptionCompletionBlock = "fetchSubscriptionCompletionBlock";

	private static readonly IntPtr selFetchSubscriptionCompletionBlockHandle = Selector.GetHandle("fetchSubscriptionCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSubscriptionIDs_ = "initWithSubscriptionIDs:";

	private static readonly IntPtr selInitWithSubscriptionIDs_Handle = Selector.GetHandle("initWithSubscriptionIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchSubscriptionCompletionBlock_ = "setFetchSubscriptionCompletionBlock:";

	private static readonly IntPtr selSetFetchSubscriptionCompletionBlock_Handle = Selector.GetHandle("setFetchSubscriptionCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubscriptionIDs_ = "setSubscriptionIDs:";

	private static readonly IntPtr selSetSubscriptionIDs_Handle = Selector.GetHandle("setSubscriptionIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionIDs = "subscriptionIDs";

	private static readonly IntPtr selSubscriptionIDsHandle = Selector.GetHandle("subscriptionIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchSubscriptionsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKFetchSubscriptionsCompleteHandler? Completed
	{
		[Export("fetchSubscriptionCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchSubscriptionsCompleteHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchSubscriptionCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchSubscriptionCompletionBlockHandle));
			return Trampolines.NIDCKFetchSubscriptionsCompleteHandler.Create(block);
		}
		[Export("setFetchSubscriptionCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchSubscriptionsCompleteHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchSubscriptionsCompleteHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchSubscriptionCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchSubscriptionCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? SubscriptionIds
	{
		[Export("subscriptionIDs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionIDsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionIDsHandle));
		}
		[Export("setSubscriptionIDs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubscriptionIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubscriptionIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchSubscriptionsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchSubscriptionsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchSubscriptionsOperation()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithSubscriptionIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchSubscriptionsOperation(string[] subscriptionIds)
		: base(NSObjectFlag.Empty)
	{
		if (subscriptionIds == null)
		{
			throw new ArgumentNullException("subscriptionIds");
		}
		NSArray nSArray = NSArray.FromStrings(subscriptionIds);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSubscriptionIDs_Handle, nSArray.Handle), "initWithSubscriptionIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSubscriptionIDs_Handle, nSArray.Handle), "initWithSubscriptionIDs:");
		}
		nSArray.Dispose();
	}

	[Export("fetchAllSubscriptionsOperation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CKFetchSubscriptionsOperation FetchAllSubscriptionsOperation()
	{
		return Runtime.GetNSObject<CKFetchSubscriptionsOperation>(Messaging.IntPtr_objc_msgSend(class_ptr, selFetchAllSubscriptionsOperationHandle));
	}
}
