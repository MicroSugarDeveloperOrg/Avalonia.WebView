using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNProgramDelegate_Extensions
{
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool BindValue(this ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
	{
		if (program == null)
		{
			throw new ArgumentNullException("program");
		}
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (renderer == null)
		{
			throw new ArgumentNullException("renderer");
		}
		IntPtr intPtr = NSString.CreateNative(symbol);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_IntPtr(This.Handle, Selector.GetHandle("program:bindValueForSymbol:atLocation:programID:renderer:"), program.Handle, intPtr, location, programID, renderer.Handle);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnbindValue(this ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
	{
		if (program == null)
		{
			throw new ArgumentNullException("program");
		}
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		if (renderer == null)
		{
			throw new ArgumentNullException("renderer");
		}
		IntPtr intPtr = NSString.CreateNative(symbol);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_IntPtr(This.Handle, Selector.GetHandle("program:unbindValueForSymbol:atLocation:programID:renderer:"), program.Handle, intPtr, location, programID, renderer.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HandleError(this ISCNProgramDelegate This, SCNProgram program, NSError error)
	{
		if (program == null)
		{
			throw new ArgumentNullException("program");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("program:handleError:"), program.Handle, error.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use the SCNProgram's Opaque property instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public static bool IsProgramOpaque(this ISCNProgramDelegate This, SCNProgram program)
	{
		if (program == null)
		{
			throw new ArgumentNullException("program");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("programIsOpaque:"), program.Handle);
	}
}
