using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNDetectBarcodesRequest", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNDetectBarcodesRequest : VNImageBasedRequest
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
	private const string selRevision = "revision";

	private static readonly IntPtr selRevisionHandle = Selector.GetHandle("revision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRevision_ = "setRevision:";

	private static readonly IntPtr selSetRevision_Handle = Selector.GetHandle("setRevision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSymbologies_ = "setSymbologies:";

	private static readonly IntPtr selSetSymbologies_Handle = Selector.GetHandle("setSymbologies:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedRevisions = "supportedRevisions";

	private static readonly IntPtr selSupportedRevisionsHandle = Selector.GetHandle("supportedRevisions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedSymbologies = "supportedSymbologies";

	private static readonly IntPtr selSupportedSymbologiesHandle = Selector.GetHandle("supportedSymbologies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbologies = "symbologies";

	private static readonly IntPtr selSymbologiesHandle = Selector.GetHandle("symbologies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNDetectBarcodesRequest");

	public VNBarcodeSymbology[] Symbologies
	{
		get
		{
			return VNBarcodeSymbologyExtensions.GetValues(WeakSymbologies);
		}
		set
		{
			WeakSymbologies = value.GetConstants();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static VNDetectBarcodesRequestRevision CurrentRevision
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("currentRevision")]
		get
		{
			return (VNDetectBarcodesRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static VNDetectBarcodesRequestRevision DefaultRevision
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("defaultRevision")]
		get
		{
			return (VNDetectBarcodesRequestRevision)Messaging.UInt64_objc_msgSend(class_ptr, selDefaultRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual VNDetectBarcodesRequestRevision Revision
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("revision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNDetectBarcodesRequestRevision)Messaging.UInt64_objc_msgSend(base.Handle, selRevisionHandle);
			}
			return (VNDetectBarcodesRequestRevision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRevisionHandle);
		}
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static VNDetectBarcodesRequestRevision[] SupportedRevisions
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			return VNRequest.GetSupportedVersions<VNDetectBarcodesRequestRevision>(WeakSupportedRevisions);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNBarcodeSymbology[] SupportedSymbologies => VNBarcodeSymbologyExtensions.GetValues(WeakSupportedSymbologies);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSIndexSet WeakSupportedRevisions
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("supportedRevisions", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedRevisionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected static NSString[] WeakSupportedSymbologies
	{
		[Export("supportedSymbologies", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(class_ptr, selSupportedSymbologiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString[] WeakSymbologies
	{
		[Export("symbologies", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSymbologiesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSymbologiesHandle));
		}
		[Export("setSymbologies:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSymbologies_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSymbologies_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNDetectBarcodesRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNDetectBarcodesRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNDetectBarcodesRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
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
