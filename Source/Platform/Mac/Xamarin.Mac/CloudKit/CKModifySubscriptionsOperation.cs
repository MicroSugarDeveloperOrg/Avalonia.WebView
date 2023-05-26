using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKModifySubscriptionsOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CKModifySubscriptionsOperation : CKDatabaseOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSubscriptionsToSave_SubscriptionIDsToDelete_ = "initWithSubscriptionsToSave:subscriptionIDsToDelete:";

	private static readonly IntPtr selInitWithSubscriptionsToSave_SubscriptionIDsToDelete_Handle = Selector.GetHandle("initWithSubscriptionsToSave:subscriptionIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifySubscriptionsCompletionBlock = "modifySubscriptionsCompletionBlock";

	private static readonly IntPtr selModifySubscriptionsCompletionBlockHandle = Selector.GetHandle("modifySubscriptionsCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModifySubscriptionsCompletionBlock_ = "setModifySubscriptionsCompletionBlock:";

	private static readonly IntPtr selSetModifySubscriptionsCompletionBlock_Handle = Selector.GetHandle("setModifySubscriptionsCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubscriptionIDsToDelete_ = "setSubscriptionIDsToDelete:";

	private static readonly IntPtr selSetSubscriptionIDsToDelete_Handle = Selector.GetHandle("setSubscriptionIDsToDelete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubscriptionsToSave_ = "setSubscriptionsToSave:";

	private static readonly IntPtr selSetSubscriptionsToSave_Handle = Selector.GetHandle("setSubscriptionsToSave:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionIDsToDelete = "subscriptionIDsToDelete";

	private static readonly IntPtr selSubscriptionIDsToDeleteHandle = Selector.GetHandle("subscriptionIDsToDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionsToSave = "subscriptionsToSave";

	private static readonly IntPtr selSubscriptionsToSaveHandle = Selector.GetHandle("subscriptionsToSave");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKModifySubscriptionsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKModifySubscriptionsHandler? Completed
	{
		[Export("modifySubscriptionsCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKModifySubscriptionsHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModifySubscriptionsCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selModifySubscriptionsCompletionBlockHandle));
			return Trampolines.NIDCKModifySubscriptionsHandler.Create(block);
		}
		[Export("setModifySubscriptionsCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKModifySubscriptionsHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKModifySubscriptionsHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetModifySubscriptionsCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetModifySubscriptionsCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? SubscriptionIdsToDelete
	{
		[Export("subscriptionIDsToDelete", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionIDsToDeleteHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionIDsToDeleteHandle));
		}
		[Export("setSubscriptionIDsToDelete:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubscriptionIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubscriptionIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKSubscription[]? SubscriptionsToSave
	{
		[Export("subscriptionsToSave", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKSubscription>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionsToSaveHandle));
			}
			return NSArray.ArrayFromHandle<CKSubscription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionsToSaveHandle));
		}
		[Export("setSubscriptionsToSave:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubscriptionsToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubscriptionsToSave_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKModifySubscriptionsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKModifySubscriptionsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKModifySubscriptionsOperation()
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

	[Export("initWithSubscriptionsToSave:subscriptionIDsToDelete:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKModifySubscriptionsOperation(CKSubscription[]? subscriptionsToSave, string[]? subscriptionIdsToDelete)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((subscriptionsToSave == null) ? null : NSArray.FromNSObjects(subscriptionsToSave));
		NSArray nSArray2 = ((subscriptionIdsToDelete == null) ? null : NSArray.FromStrings(subscriptionIdsToDelete));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSubscriptionsToSave_SubscriptionIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithSubscriptionsToSave:subscriptionIDsToDelete:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSubscriptionsToSave_SubscriptionIDsToDelete_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithSubscriptionsToSave:subscriptionIDsToDelete:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}
}
