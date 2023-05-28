using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CloudKit;

[Register("CKModifyBadgeOperation", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
public class CKModifyBadgeOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBadgeValue = "badgeValue";

	private static readonly IntPtr selBadgeValueHandle = Selector.GetHandle("badgeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBadgeValue_ = "initWithBadgeValue:";

	private static readonly IntPtr selInitWithBadgeValue_Handle = Selector.GetHandle("initWithBadgeValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyBadgeCompletionBlock = "modifyBadgeCompletionBlock";

	private static readonly IntPtr selModifyBadgeCompletionBlockHandle = Selector.GetHandle("modifyBadgeCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBadgeValue_ = "setBadgeValue:";

	private static readonly IntPtr selSetBadgeValue_Handle = Selector.GetHandle("setBadgeValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModifyBadgeCompletionBlock_ = "setModifyBadgeCompletionBlock:";

	private static readonly IntPtr selSetModifyBadgeCompletionBlock_Handle = Selector.GetHandle("setModifyBadgeCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKModifyBadgeOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BadgeValue
	{
		[Export("badgeValue", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBadgeValueHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBadgeValueHandle);
		}
		[Export("setBadgeValue:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBadgeValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBadgeValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? Completed
	{
		[Export("modifyBadgeCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModifyBadgeCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selModifyBadgeCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setModifyBadgeCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetModifyBadgeCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetModifyBadgeCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CKModifyBadgeOperation()
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
	protected CKModifyBadgeOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKModifyBadgeOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBadgeValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKModifyBadgeOperation(nuint badgeValue)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithBadgeValue_Handle, badgeValue), "initWithBadgeValue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithBadgeValue_Handle, badgeValue), "initWithBadgeValue:");
		}
	}
}
