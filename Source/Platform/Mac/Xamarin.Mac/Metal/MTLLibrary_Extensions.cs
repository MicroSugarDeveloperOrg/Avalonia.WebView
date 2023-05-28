using System;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLLibrary_Extensions
{
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLFunction? CreateFunction(this IMTLLibrary This, string name, MTLFunctionConstantValues constantValues, out NSError error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (constantValues == null)
		{
			throw new ArgumentNullException("constantValues");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(name);
		IMTLFunction iNativeObject = Runtime.GetINativeObject<IMTLFunction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newFunctionWithName:constantValues:error:"), intPtr, constantValues.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		NSString.ReleaseNative(intPtr);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void CreateFunction(this IMTLLibrary This, string name, MTLFunctionConstantValues constantValues, [BlockProxy(typeof(Trampolines.NIDActionArity2V70))] Action<IMTLFunction, NSError> completionHandler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (constantValues == null)
		{
			throw new ArgumentNullException("constantValues");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V70.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("newFunctionWithName:constantValues:completionHandler:"), intPtr, constantValues.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<IMTLFunction> CreateFunctionAsync(this IMTLLibrary This, string name, MTLFunctionConstantValues constantValues)
	{
		TaskCompletionSource<IMTLFunction> tcs = new TaskCompletionSource<IMTLFunction>();
		This.CreateFunction(name, constantValues, delegate(IMTLFunction arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}
}
