using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNShadable_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void HandleBinding(this ISCNShadable This, string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr intPtr = NSString.CreateNative(symbol);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBindingHandler.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("handleBindingOfSymbol:usingBlock:"), intPtr, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void HandleUnbinding(this ISCNShadable This, string symbol, [BlockProxy(typeof(Trampolines.NIDSCNBindingHandler))] SCNBindingHandler handler)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr intPtr = NSString.CreateNative(symbol);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBindingHandler.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("handleUnbindingOfSymbol:usingBlock:"), intPtr, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary GetWeakShaderModifiers(this ISCNShadable This)
	{
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("shaderModifiers")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetWeakShaderModifiers(this ISCNShadable This, NSDictionary value)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setShaderModifiers:"), value?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNProgram GetProgram(this ISCNShadable This)
	{
		return Runtime.GetNSObject<SCNProgram>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("program")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetProgram(this ISCNShadable This, SCNProgram value)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setProgram:"), value?.Handle ?? IntPtr.Zero);
	}
}
