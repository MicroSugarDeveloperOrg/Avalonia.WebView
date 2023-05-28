using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKArcadeService", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class SKArcadeService : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArcadeSubscriptionStatusWithNonce_ResultHandler_ = "arcadeSubscriptionStatusWithNonce:resultHandler:";

	private static readonly IntPtr selArcadeSubscriptionStatusWithNonce_ResultHandler_Handle = Selector.GetHandle("arcadeSubscriptionStatusWithNonce:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterArcadeAppWithRandomFromLib_RandomFromLibLength_ResultHandler_ = "registerArcadeAppWithRandomFromLib:randomFromLibLength:resultHandler:";

	private static readonly IntPtr selRegisterArcadeAppWithRandomFromLib_RandomFromLibLength_ResultHandler_Handle = Selector.GetHandle("registerArcadeAppWithRandomFromLib:randomFromLibLength:resultHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepairArcadeApp = "repairArcadeApp";

	private static readonly IntPtr selRepairArcadeAppHandle = Selector.GetHandle("repairArcadeApp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKArcadeService");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKArcadeService(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKArcadeService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("arcadeSubscriptionStatusWithNonce:resultHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetSubscriptionStatus(ulong nonce, [BlockProxy(typeof(Trampolines.NIDSKArcadeServiceSubscriptionHandler))] SKArcadeServiceSubscriptionHandler resultHandler)
	{
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKArcadeServiceSubscriptionHandler.Handler, resultHandler);
		Messaging.void_objc_msgSend_UInt64_IntPtr(class_ptr, selArcadeSubscriptionStatusWithNonce_ResultHandler_Handle, nonce, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("registerArcadeAppWithRandomFromLib:randomFromLibLength:resultHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void Register(NSData randomFromLib, uint randomFromLibLength, [BlockProxy(typeof(Trampolines.NIDSKArcadeServiceRegisterHandler))] SKArcadeServiceRegisterHandler resultHandler)
	{
		if (randomFromLib == null)
		{
			throw new ArgumentNullException("randomFromLib");
		}
		if (resultHandler == null)
		{
			throw new ArgumentNullException("resultHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKArcadeServiceRegisterHandler.Handler, resultHandler);
		Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr(class_ptr, selRegisterArcadeAppWithRandomFromLib_RandomFromLibLength_ResultHandler_Handle, randomFromLib.Handle, randomFromLibLength, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("repairArcadeApp")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Repair()
	{
		Messaging.void_objc_msgSend(class_ptr, selRepairArcadeAppHandle);
	}
}
