using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchShareParticipantsOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKFetchShareParticipantsOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareParticipantsCompletionBlock = "fetchShareParticipantsCompletionBlock";

	private static readonly IntPtr selFetchShareParticipantsCompletionBlockHandle = Selector.GetHandle("fetchShareParticipantsCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUserIdentityLookupInfos_ = "initWithUserIdentityLookupInfos:";

	private static readonly IntPtr selInitWithUserIdentityLookupInfos_Handle = Selector.GetHandle("initWithUserIdentityLookupInfos:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchShareParticipantsCompletionBlock_ = "setFetchShareParticipantsCompletionBlock:";

	private static readonly IntPtr selSetFetchShareParticipantsCompletionBlock_Handle = Selector.GetHandle("setFetchShareParticipantsCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShareParticipantFetchedBlock_ = "setShareParticipantFetchedBlock:";

	private static readonly IntPtr selSetShareParticipantFetchedBlock_Handle = Selector.GetHandle("setShareParticipantFetchedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserIdentityLookupInfos_ = "setUserIdentityLookupInfos:";

	private static readonly IntPtr selSetUserIdentityLookupInfos_Handle = Selector.GetHandle("setUserIdentityLookupInfos:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShareParticipantFetchedBlock = "shareParticipantFetchedBlock";

	private static readonly IntPtr selShareParticipantFetchedBlockHandle = Selector.GetHandle("shareParticipantFetchedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserIdentityLookupInfos = "userIdentityLookupInfos";

	private static readonly IntPtr selUserIdentityLookupInfosHandle = Selector.GetHandle("userIdentityLookupInfos");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchShareParticipantsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? Completed
	{
		[Export("fetchShareParticipantsCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchShareParticipantsCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchShareParticipantsCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setFetchShareParticipantsCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchShareParticipantsCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchShareParticipantsCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKShareParticipant>? Fetched
	{
		[Export("shareParticipantFetchedBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V21))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShareParticipantFetchedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selShareParticipantFetchedBlockHandle));
			return Trampolines.NIDActionArity1V21.Create(block);
		}
		[Export("setShareParticipantFetchedBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V21))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V21.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShareParticipantFetchedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShareParticipantFetchedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKUserIdentityLookupInfo[]? UserIdentityLookupInfos
	{
		[Export("userIdentityLookupInfos", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKUserIdentityLookupInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserIdentityLookupInfosHandle));
			}
			return NSArray.ArrayFromHandle<CKUserIdentityLookupInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserIdentityLookupInfosHandle));
		}
		[Export("setUserIdentityLookupInfos:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserIdentityLookupInfos_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserIdentityLookupInfos_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchShareParticipantsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchShareParticipantsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchShareParticipantsOperation()
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

	[Export("initWithUserIdentityLookupInfos:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchShareParticipantsOperation(CKUserIdentityLookupInfo[] userIdentityLookupInfos)
		: base(NSObjectFlag.Empty)
	{
		if (userIdentityLookupInfos == null)
		{
			throw new ArgumentNullException("userIdentityLookupInfos");
		}
		NSArray nSArray = NSArray.FromNSObjects(userIdentityLookupInfos);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUserIdentityLookupInfos_Handle, nSArray.Handle), "initWithUserIdentityLookupInfos:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUserIdentityLookupInfos_Handle, nSArray.Handle), "initWithUserIdentityLookupInfos:");
		}
		nSArray.Dispose();
	}
}
