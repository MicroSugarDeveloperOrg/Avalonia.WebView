using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNGenerateImageFeaturePrintRequest", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class VNGenerateImageFeaturePrintRequest : VNImageBasedRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRevision = "currentRevision";

	private static readonly IntPtr selCurrentRevisionHandle = Selector.GetHandle("currentRevision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultRevision = "defaultRevision";

	private static readonly IntPtr selDefaultRevisionHandle = Selector.GetHandle("defaultRevision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageCropAndScaleOption = "imageCropAndScaleOption";

	private static readonly IntPtr selImageCropAndScaleOptionHandle = Selector.GetHandle("imageCropAndScaleOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompletionHandler_ = "initWithCompletionHandler:";

	private static readonly IntPtr selInitWithCompletionHandler_Handle = Selector.GetHandle("initWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevision = "revision";

	private static readonly IntPtr selRevisionHandle = Selector.GetHandle("revision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageCropAndScaleOption_ = "setImageCropAndScaleOption:";

	private static readonly IntPtr selSetImageCropAndScaleOption_Handle = Selector.GetHandle("setImageCropAndScaleOption:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRevision_ = "setRevision:";

	private static readonly IntPtr selSetRevision_Handle = Selector.GetHandle("setRevision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedRevisions = "supportedRevisions";

	private static readonly IntPtr selSupportedRevisionsHandle = Selector.GetHandle("supportedRevisions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNGenerateImageFeaturePrintRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNGenerateImageFeaturePrintRequestRevision CurrentRevision
	{
		[Export("currentRevision")]
		get
		{
			return (VNGenerateImageFeaturePrintRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNGenerateImageFeaturePrintRequestRevision DefaultRevision
	{
		[Export("defaultRevision")]
		get
		{
			return (VNGenerateImageFeaturePrintRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNImageCropAndScaleOption ImageCropAndScaleOption
	{
		[Export("imageCropAndScaleOption", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNImageCropAndScaleOption)Messaging.UInt64_objc_msgSend(base.Handle, selImageCropAndScaleOptionHandle);
			}
			return (VNImageCropAndScaleOption)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageCropAndScaleOptionHandle);
		}
		[Export("setImageCropAndScaleOption:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageCropAndScaleOption_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageCropAndScaleOption_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNGenerateImageFeaturePrintRequestRevision Revision
	{
		[Export("revision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNGenerateImageFeaturePrintRequestRevision)Messaging.UInt64_objc_msgSend(base.Handle, selRevisionHandle);
			}
			return (VNGenerateImageFeaturePrintRequestRevision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRevisionHandle);
		}
		[Export("setRevision:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRevision_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRevision_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNGenerateImageFeaturePrintRequestRevision[] SupportedRevisions => VNRequest.GetSupportedVersions<VNGenerateImageFeaturePrintRequestRevision>(WeakSupportedRevisions);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet WeakSupportedRevisions
	{
		[Export("supportedRevisions", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedRevisionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNGenerateImageFeaturePrintRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNGenerateImageFeaturePrintRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNGenerateImageFeaturePrintRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
