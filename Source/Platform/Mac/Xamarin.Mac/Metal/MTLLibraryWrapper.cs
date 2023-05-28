using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLLibraryWrapper : BaseWrapper, IMTLLibrary, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string[] FunctionNames
	{
		[Export("functionNames")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("functionNames")));
		}
	}

	[Preserve(Conditional = true)]
	public MTLLibraryWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("newFunctionWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLFunction CreateFunction(string functionName)
	{
		if (functionName == null)
		{
			throw new ArgumentNullException("functionName");
		}
		IntPtr intPtr = NSString.CreateNative(functionName);
		IMTLFunction iNativeObject = Runtime.GetINativeObject<IMTLFunction>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newFunctionWithName:"), intPtr), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		NSString.ReleaseNative(intPtr);
		return iNativeObject;
	}
}
