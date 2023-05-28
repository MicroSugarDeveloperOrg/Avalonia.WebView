using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNClassifyImageRequest", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class VNClassifyImageRequest : VNImageBasedRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRevision = "currentRevision";

	private static readonly IntPtr selCurrentRevisionHandle = Selector.GetHandle("currentRevision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultRevision = "defaultRevision";

	private static readonly IntPtr selDefaultRevisionHandle = Selector.GetHandle("defaultRevision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompletionHandler_ = "initWithCompletionHandler:";

	private static readonly IntPtr selInitWithCompletionHandler_Handle = Selector.GetHandle("initWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnownClassificationsForRevision_Error_ = "knownClassificationsForRevision:error:";

	private static readonly IntPtr selKnownClassificationsForRevision_Error_Handle = Selector.GetHandle("knownClassificationsForRevision:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevision = "revision";

	private static readonly IntPtr selRevisionHandle = Selector.GetHandle("revision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRevision_ = "setRevision:";

	private static readonly IntPtr selSetRevision_Handle = Selector.GetHandle("setRevision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedRevisions = "supportedRevisions";

	private static readonly IntPtr selSupportedRevisionsHandle = Selector.GetHandle("supportedRevisions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNClassifyImageRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNClassifyImageRequestRevision CurrentRevision
	{
		[Export("currentRevision")]
		get
		{
			return (VNClassifyImageRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNClassifyImageRequestRevision DefaultRevision
	{
		[Export("defaultRevision")]
		get
		{
			return (VNClassifyImageRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNClassifyImageRequestRevision Revision
	{
		[Export("revision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNClassifyImageRequestRevision)Messaging.UInt64_objc_msgSend(base.Handle, selRevisionHandle);
			}
			return (VNClassifyImageRequestRevision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRevisionHandle);
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
	public static VNClassifyImageRequestRevision[] SupportedRevisions => VNRequest.GetSupportedVersions<VNClassifyImageRequestRevision>(WeakSupportedRevisions);

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
	protected VNClassifyImageRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNClassifyImageRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNClassifyImageRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
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

	[Export("knownClassificationsForRevision:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNClassificationObservation[]? GetKnownClassifications(VNClassifyImageRequestRevision revision, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		VNClassificationObservation[] result = NSArray.ArrayFromHandle<VNClassificationObservation>(Messaging.IntPtr_objc_msgSend_UInt64_ref_IntPtr(class_ptr, selKnownClassificationsForRevision_Error_Handle, (ulong)revision, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
