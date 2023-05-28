using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSCnnConvolutionDataSourceWrapper : BaseWrapper, IMPSCnnConvolutionDataSource, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSDataType DataType
	{
		[Export("dataType")]
		get
		{
			return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, Selector.GetHandle("dataType"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionDescriptor Descriptor
	{
		[Export("descriptor")]
		get
		{
			return Runtime.GetNSObject<MPSCnnConvolutionDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("descriptor")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IntPtr Weights
	{
		[Export("weights")]
		get
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("weights"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IntPtr BiasTerms
	{
		[Export("biasTerms")]
		get
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("biasTerms"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Load
	{
		[Export("load")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("load"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
	}

	[Preserve(Conditional = true)]
	public MPSCnnConvolutionDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("purge")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Purge()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("purge"));
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
