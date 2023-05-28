using System;
using ObjCRuntime;

namespace Metal;

public static class MTLDrawable_Extensions
{
	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentAfter(this IMTLDrawable This, double duration)
	{
		Messaging.void_objc_msgSend_Double(This.Handle, Selector.GetHandle("presentAfterMinimumDuration:"), duration);
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void AddPresentedHandler(this IMTLDrawable This, [BlockProxy(typeof(Trampolines.NIDActionArity1V65))] Action<IMTLDrawable> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V65.Handler, block);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("addPresentedHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetPresentedTime(this IMTLDrawable This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("presentedTime"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetDrawableID(this IMTLDrawable This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("drawableID"));
	}
}
