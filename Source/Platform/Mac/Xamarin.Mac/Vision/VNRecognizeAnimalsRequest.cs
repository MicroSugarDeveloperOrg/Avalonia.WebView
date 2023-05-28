using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNRecognizeAnimalsRequest", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class VNRecognizeAnimalsRequest : VNImageBasedRequest
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
	private const string selKnownAnimalIdentifiersForRevision_Error_ = "knownAnimalIdentifiersForRevision:error:";

	private static readonly IntPtr selKnownAnimalIdentifiersForRevision_Error_Handle = Selector.GetHandle("knownAnimalIdentifiersForRevision:error:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNRecognizeAnimalsRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNRecognizeAnimalsRequestRevision CurrentRevision
	{
		[Export("currentRevision")]
		get
		{
			return (VNRecognizeAnimalsRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNRecognizeAnimalsRequestRevision DefaultRevision
	{
		[Export("defaultRevision")]
		get
		{
			return (VNRecognizeAnimalsRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNRecognizeAnimalsRequestRevision Revision
	{
		[Export("revision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNRecognizeAnimalsRequestRevision)Messaging.UInt64_objc_msgSend(base.Handle, selRevisionHandle);
			}
			return (VNRecognizeAnimalsRequestRevision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRevisionHandle);
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
	public static VNRecognizeAnimalsRequestRevision[] SupportedRevisions => VNRequest.GetSupportedVersions<VNRecognizeAnimalsRequestRevision>(WeakSupportedRevisions);

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
	protected VNRecognizeAnimalsRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNRecognizeAnimalsRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNRecognizeAnimalsRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
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

	[Export("knownAnimalIdentifiersForRevision:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: BindAs(typeof(VNAnimalIdentifier[]), OriginalType = typeof(NSString[]))]
	public static VNAnimalIdentifier[]? GetKnownAnimalIdentifiers(VNRecognizeAnimalsRequestRevision revision, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr;
		VNAnimalIdentifier[] result = (((intPtr = Messaging.IntPtr_objc_msgSend_UInt64_ref_IntPtr(class_ptr, selKnownAnimalIdentifiersForRevision_Error_Handle, (ulong)revision, ref arg)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr, delegate(IntPtr ptr)
		{
			using NSString constant = Runtime.GetNSObject<NSString>(ptr);
			return VNAnimalIdentifierExtensions.GetValue(constant);
		}));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
