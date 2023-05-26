using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKDiscoverUserInfosOperation", true)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKDiscoverUserIdentitiesOperation' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKDiscoverUserIdentitiesOperation' instead.")]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class CKDiscoverUserInfosOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserInfosCompletionBlock = "discoverUserInfosCompletionBlock";

	private static readonly IntPtr selDiscoverUserInfosCompletionBlockHandle = Selector.GetHandle("discoverUserInfosCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmailAddresses = "emailAddresses";

	private static readonly IntPtr selEmailAddressesHandle = Selector.GetHandle("emailAddresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithEmailAddresses_UserRecordIDs_ = "initWithEmailAddresses:userRecordIDs:";

	private static readonly IntPtr selInitWithEmailAddresses_UserRecordIDs_Handle = Selector.GetHandle("initWithEmailAddresses:userRecordIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiscoverUserInfosCompletionBlock_ = "setDiscoverUserInfosCompletionBlock:";

	private static readonly IntPtr selSetDiscoverUserInfosCompletionBlock_Handle = Selector.GetHandle("setDiscoverUserInfosCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmailAddresses_ = "setEmailAddresses:";

	private static readonly IntPtr selSetEmailAddresses_Handle = Selector.GetHandle("setEmailAddresses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserRecordIDs_ = "setUserRecordIDs:";

	private static readonly IntPtr selSetUserRecordIDs_Handle = Selector.GetHandle("setUserRecordIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserRecordIDs = "userRecordIDs";

	private static readonly IntPtr selUserRecordIDsHandle = Selector.GetHandle("userRecordIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKDiscoverUserInfosOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKDiscoverUserInfosCompletionHandler? Completed
	{
		[Export("discoverUserInfosCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKDiscoverUserInfosCompletionHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiscoverUserInfosCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDiscoverUserInfosCompletionBlockHandle));
			return Trampolines.NIDCKDiscoverUserInfosCompletionHandler.Create(block);
		}
		[Export("setDiscoverUserInfosCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKDiscoverUserInfosCompletionHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKDiscoverUserInfosCompletionHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDiscoverUserInfosCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDiscoverUserInfosCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? EmailAddresses
	{
		[Export("emailAddresses", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selEmailAddressesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmailAddressesHandle));
		}
		[Export("setEmailAddresses:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEmailAddresses_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEmailAddresses_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKRecordID[]? UserRecordIds
	{
		[Export("userRecordIDs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserRecordIDsHandle));
			}
			return NSArray.ArrayFromHandle<CKRecordID>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserRecordIDsHandle));
		}
		[Export("setUserRecordIDs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKDiscoverUserInfosOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKDiscoverUserInfosOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKDiscoverUserInfosOperation()
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

	[Export("initWithEmailAddresses:userRecordIDs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKDiscoverUserInfosOperation(string[]? emailAddresses, CKRecordID[]? userRecordIDs)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((emailAddresses == null) ? null : NSArray.FromStrings(emailAddresses));
		NSArray nSArray2 = ((userRecordIDs == null) ? null : NSArray.FromNSObjects(userRecordIDs));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithEmailAddresses_UserRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithEmailAddresses:userRecordIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithEmailAddresses_UserRecordIDs_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithEmailAddresses:userRecordIDs:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}
}
