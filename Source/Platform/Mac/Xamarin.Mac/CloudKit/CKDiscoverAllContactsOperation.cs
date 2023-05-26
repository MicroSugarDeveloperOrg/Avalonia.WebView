using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKDiscoverAllContactsOperation", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKDiscoverAllUserIdentitiesOperation' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKDiscoverAllUserIdentitiesOperation' instead.")]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKDiscoverAllContactsOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverAllContactsCompletionBlock = "discoverAllContactsCompletionBlock";

	private static readonly IntPtr selDiscoverAllContactsCompletionBlockHandle = Selector.GetHandle("discoverAllContactsCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiscoverAllContactsCompletionBlock_ = "setDiscoverAllContactsCompletionBlock:";

	private static readonly IntPtr selSetDiscoverAllContactsCompletionBlock_Handle = Selector.GetHandle("setDiscoverAllContactsCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKDiscoverAllContactsOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<CKDiscoveredUserInfo[], NSError>? DiscoverAllContactsHandler
	{
		[Export("discoverAllContactsCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V15))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiscoverAllContactsCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDiscoverAllContactsCompletionBlockHandle));
			return Trampolines.NIDActionArity2V15.Create(block);
		}
		[Export("setDiscoverAllContactsCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V15))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V15.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDiscoverAllContactsCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDiscoverAllContactsCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKDiscoverAllContactsOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKDiscoverAllContactsOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKDiscoverAllContactsOperation()
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
}
