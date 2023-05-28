using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRasterizationRateLayerDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MTLRasterizationRateLayerDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSampleCount_ = "initWithSampleCount:";

	private static readonly IntPtr selInitWithSampleCount_Handle = Selector.GetHandle("initWithSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSampleCount_Horizontal_Vertical_ = "initWithSampleCount:horizontal:vertical:";

	private static readonly IntPtr selInitWithSampleCount_Horizontal_Vertical_Handle = Selector.GetHandle("initWithSampleCount:horizontal:vertical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRasterizationRateLayerDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLRasterizationRateLayerDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRasterizationRateLayerDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSampleCount:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLRasterizationRateLayerDescriptor(MTLSize sampleCount)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_MTLSize(base.Handle, selInitWithSampleCount_Handle, sampleCount), "initWithSampleCount:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_MTLSize(base.SuperHandle, selInitWithSampleCount_Handle, sampleCount), "initWithSampleCount:");
		}
	}

	[Export("initWithSampleCount:horizontal:vertical:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal MTLRasterizationRateLayerDescriptor(MTLSize sampleCount, IntPtr horizontal, IntPtr vertical)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_MTLSize_IntPtr_IntPtr(base.Handle, selInitWithSampleCount_Horizontal_Vertical_Handle, sampleCount, horizontal, vertical), "initWithSampleCount:horizontal:vertical:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_MTLSize_IntPtr_IntPtr(base.SuperHandle, selInitWithSampleCount_Horizontal_Vertical_Handle, sampleCount, horizontal, vertical), "initWithSampleCount:horizontal:vertical:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
