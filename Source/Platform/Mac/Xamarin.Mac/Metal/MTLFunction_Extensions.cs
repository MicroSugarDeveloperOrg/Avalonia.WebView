using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

public static class MTLFunction_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLArgumentEncoder CreateArgumentEncoder(this IMTLFunction This, nuint bufferIndex)
	{
		IMTLArgumentEncoder iNativeObject = Runtime.GetINativeObject<IMTLArgumentEncoder>(Messaging.IntPtr_objc_msgSend_nuint(This.Handle, Selector.GetHandle("newArgumentEncoderWithBufferIndex:"), bufferIndex), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLArgumentEncoder CreateArgumentEncoder(this IMTLFunction This, nuint bufferIndex, out MTLArgument? reflection)
	{
		IntPtr arg = IntPtr.Zero;
		IMTLArgumentEncoder iNativeObject = Runtime.GetINativeObject<IMTLArgumentEncoder>(Messaging.IntPtr_objc_msgSend_nuint_ref_IntPtr(This.Handle, Selector.GetHandle("newArgumentEncoderWithBufferIndex:reflection:"), bufferIndex, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		reflection = Runtime.GetNSObject<MTLArgument>(arg);
		return iNativeObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetLabel(this IMTLFunction This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("label")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetLabel(this IMTLFunction This, string value)
	{
		IntPtr intPtr = NSString.CreateNative(value);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setLabel:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLPatchType GetPatchType(this IMTLFunction This)
	{
		return (MTLPatchType)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("patchType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetPatchControlPointCount(this IMTLFunction This)
	{
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("patchControlPointCount"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLAttribute[] GetStageInputAttributes(this IMTLFunction This)
	{
		return NSArray.ArrayFromHandle<MTLAttribute>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("stageInputAttributes")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary<NSString, MTLFunctionConstant> GetFunctionConstants(this IMTLFunction This)
	{
		return Runtime.GetNSObject<NSDictionary<NSString, MTLFunctionConstant>>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("functionConstantsDictionary")));
	}
}
