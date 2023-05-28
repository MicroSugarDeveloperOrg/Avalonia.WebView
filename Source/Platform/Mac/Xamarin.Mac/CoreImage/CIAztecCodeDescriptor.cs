using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIAztecCodeDescriptor", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIAztecCodeDescriptor : CIBarcodeDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataCodewordCount = "dataCodewordCount";

	private static readonly IntPtr selDataCodewordCountHandle = Selector.GetHandle("dataCodewordCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithPayload_IsCompact_LayerCount_DataCodewordCount_ = "descriptorWithPayload:isCompact:layerCount:dataCodewordCount:";

	private static readonly IntPtr selDescriptorWithPayload_IsCompact_LayerCount_DataCodewordCount_Handle = Selector.GetHandle("descriptorWithPayload:isCompact:layerCount:dataCodewordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorCorrectedPayload = "errorCorrectedPayload";

	private static readonly IntPtr selErrorCorrectedPayloadHandle = Selector.GetHandle("errorCorrectedPayload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPayload_IsCompact_LayerCount_DataCodewordCount_ = "initWithPayload:isCompact:layerCount:dataCodewordCount:";

	private static readonly IntPtr selInitWithPayload_IsCompact_LayerCount_DataCodewordCount_Handle = Selector.GetHandle("initWithPayload:isCompact:layerCount:dataCodewordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompact = "isCompact";

	private static readonly IntPtr selIsCompactHandle = Selector.GetHandle("isCompact");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerCount = "layerCount";

	private static readonly IntPtr selLayerCountHandle = Selector.GetHandle("layerCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIAztecCodeDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DataCodewordCount
	{
		[Export("dataCodewordCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDataCodewordCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDataCodewordCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ErrorCorrectedPayload
	{
		[Export("errorCorrectedPayload")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorCorrectedPayloadHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorCorrectedPayloadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCompact
	{
		[Export("isCompact")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompactHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompactHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LayerCount
	{
		[Export("layerCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLayerCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLayerCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIAztecCodeDescriptor()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIAztecCodeDescriptor(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIAztecCodeDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIAztecCodeDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPayload:isCompact:layerCount:dataCodewordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIAztecCodeDescriptor(NSData errorCorrectedPayload, bool isCompact, nint layerCount, nint dataCodewordCount)
		: base(NSObjectFlag.Empty)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_nint_nint(base.Handle, selInitWithPayload_IsCompact_LayerCount_DataCodewordCount_Handle, errorCorrectedPayload.Handle, isCompact, layerCount, dataCodewordCount), "initWithPayload:isCompact:layerCount:dataCodewordCount:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_nint_nint(base.SuperHandle, selInitWithPayload_IsCompact_LayerCount_DataCodewordCount_Handle, errorCorrectedPayload.Handle, isCompact, layerCount, dataCodewordCount), "initWithPayload:isCompact:layerCount:dataCodewordCount:");
		}
	}

	[Export("descriptorWithPayload:isCompact:layerCount:dataCodewordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIAztecCodeDescriptor? CreateDescriptor(NSData errorCorrectedPayload, bool isCompact, nint layerCount, nint dataCodewordCount)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		return Runtime.GetNSObject<CIAztecCodeDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_nint_nint(class_ptr, selDescriptorWithPayload_IsCompact_LayerCount_DataCodewordCount_Handle, errorCorrectedPayload.Handle, isCompact, layerCount, dataCodewordCount));
	}
}
