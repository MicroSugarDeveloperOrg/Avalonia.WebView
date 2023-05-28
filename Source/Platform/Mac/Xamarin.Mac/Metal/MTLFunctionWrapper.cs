using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLFunctionWrapper : BaseWrapper, IMTLFunction, INativeObject, IDisposable
{
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
	public MTLFunctionType FunctionType
	{
		[Export("functionType")]
		get
		{
			return (MTLFunctionType)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("functionType"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLVertexAttribute[] VertexAttributes
	{
		[Export("vertexAttributes")]
		get
		{
			return NSArray.ArrayFromHandle<MTLVertexAttribute>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("vertexAttributes")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
	}

	[Preserve(Conditional = true)]
	public MTLFunctionWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
