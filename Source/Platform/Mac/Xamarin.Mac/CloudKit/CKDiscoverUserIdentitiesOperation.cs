using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKDiscoverUserIdentitiesOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKDiscoverUserIdentitiesOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverUserIdentitiesCompletionBlock = "discoverUserIdentitiesCompletionBlock";

	private static readonly IntPtr selDiscoverUserIdentitiesCompletionBlockHandle = Selector.GetHandle("discoverUserIdentitiesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUserIdentityLookupInfos_ = "initWithUserIdentityLookupInfos:";

	private static readonly IntPtr selInitWithUserIdentityLookupInfos_Handle = Selector.GetHandle("initWithUserIdentityLookupInfos:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiscoverUserIdentitiesCompletionBlock_ = "setDiscoverUserIdentitiesCompletionBlock:";

	private static readonly IntPtr selSetDiscoverUserIdentitiesCompletionBlock_Handle = Selector.GetHandle("setDiscoverUserIdentitiesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserIdentityDiscoveredBlock_ = "setUserIdentityDiscoveredBlock:";

	private static readonly IntPtr selSetUserIdentityDiscoveredBlock_Handle = Selector.GetHandle("setUserIdentityDiscoveredBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserIdentityLookupInfos_ = "setUserIdentityLookupInfos:";

	private static readonly IntPtr selSetUserIdentityLookupInfos_Handle = Selector.GetHandle("setUserIdentityLookupInfos:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserIdentityDiscoveredBlock = "userIdentityDiscoveredBlock";

	private static readonly IntPtr selUserIdentityDiscoveredBlockHandle = Selector.GetHandle("userIdentityDiscoveredBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserIdentityLookupInfos = "userIdentityLookupInfos";

	private static readonly IntPtr selUserIdentityLookupInfosHandle = Selector.GetHandle("userIdentityLookupInfos");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKDiscoverUserIdentitiesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? Completed
	{
		[Export("discoverUserIdentitiesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiscoverUserIdentitiesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDiscoverUserIdentitiesCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setDiscoverUserIdentitiesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDiscoverUserIdentitiesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDiscoverUserIdentitiesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKUserIdentity, CKUserIdentityLookupInfo>? Discovered
	{
		[Export("userIdentityDiscoveredBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V32))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserIdentityDiscoveredBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selUserIdentityDiscoveredBlockHandle));
			return Trampolines.NIDActionArity2V32.Create(block);
		}
		[Export("setUserIdentityDiscoveredBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V32))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V32.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserIdentityDiscoveredBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserIdentityDiscoveredBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKUserIdentityLookupInfo[] UserIdentityLookupInfos
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
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserIdentityLookupInfos_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserIdentityLookupInfos_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKDiscoverUserIdentitiesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKDiscoverUserIdentitiesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKDiscoverUserIdentitiesOperation()
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
	public CKDiscoverUserIdentitiesOperation(CKUserIdentityLookupInfo[] userIdentityLookupInfos)
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
