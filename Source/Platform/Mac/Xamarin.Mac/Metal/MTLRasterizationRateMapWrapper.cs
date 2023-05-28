using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLRasterizationRateMapWrapper : BaseWrapper, IMTLRasterizationRateMap, INativeObject, IDisposable
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
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLSize ScreenSize
	{
		[Export("screenSize")]
		get
		{
			Messaging.MTLSize_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("screenSize"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLSize PhysicalGranularity
	{
		[Export("physicalGranularity")]
		get
		{
			Messaging.MTLSize_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("physicalGranularity"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint LayerCount
	{
		[Export("layerCount")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("layerCount"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLSizeAndAlign ParameterBufferSizeAndAlign
	{
		[Export("parameterBufferSizeAndAlign")]
		get
		{
			return Messaging.MTLSizeAndAlign_objc_msgSend(base.Handle, Selector.GetHandle("parameterBufferSizeAndAlign"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLRasterizationRateMapWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("copyParameterDataToBuffer:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CopyParameterData(IMTLBuffer buffer, nuint offset)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("copyParameterDataToBuffer:offset:"), buffer.Handle, offset);
	}

	[Export("physicalSizeForLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLSize GetPhysicalSize(nuint layerIndex)
	{
		Messaging.MTLSize_objc_msgSend_stret_nuint(out var retval, base.Handle, Selector.GetHandle("physicalSizeForLayer:"), layerIndex);
		return retval;
	}

	[Export("mapScreenToPhysicalCoordinates:forLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLCoordinate2D MapScreenToPhysicalCoordinates(MTLCoordinate2D screenCoordinates, nuint layerIndex)
	{
		return Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_nuint(base.Handle, Selector.GetHandle("mapScreenToPhysicalCoordinates:forLayer:"), screenCoordinates, layerIndex);
	}

	[Export("mapPhysicalToScreenCoordinates:forLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLCoordinate2D MapPhysicalToScreenCoordinates(MTLCoordinate2D physicalCoordinates, nuint layerIndex)
	{
		return Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_nuint(base.Handle, Selector.GetHandle("mapPhysicalToScreenCoordinates:forLayer:"), physicalCoordinates, layerIndex);
	}
}
