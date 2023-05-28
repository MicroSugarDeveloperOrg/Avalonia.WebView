using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Vision;

[Register("VNFeaturePrintObservation", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class VNFeaturePrintObservation : VNObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComputeDistance_ToFeaturePrintObservation_Error_ = "computeDistance:toFeaturePrintObservation:error:";

	private static readonly IntPtr selComputeDistance_ToFeaturePrintObservation_Error_Handle = Selector.GetHandle("computeDistance:toFeaturePrintObservation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementType = "elementType";

	private static readonly IntPtr selElementTypeHandle = Selector.GetHandle("elementType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNFeaturePrintObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ElementCount
	{
		[Export("elementCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selElementCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selElementCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNElementType ElementType
	{
		[Export("elementType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (VNElementType)Messaging.UInt64_objc_msgSend(base.Handle, selElementTypeHandle);
			}
			return (VNElementType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selElementTypeHandle);
		}
	}

	public unsafe bool ComputeDistance(out float[] distance, VNFeaturePrintObservation featurePrint, out NSError error)
	{
		distance = new float[(ulong)ElementCount];
		fixed (float* ptr = distance)
		{
			return _ComputeDistance((IntPtr)ptr, featurePrint, out error);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNFeaturePrintObservation(NSCoder coder)
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
	protected VNFeaturePrintObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNFeaturePrintObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("computeDistance:toFeaturePrintObservation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool _ComputeDistance(IntPtr outDistance, VNFeaturePrintObservation featurePrint, out NSError? error)
	{
		if (featurePrint == null)
		{
			throw new ArgumentNullException("featurePrint");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selComputeDistance_ToFeaturePrintObservation_Error_Handle, outDistance, featurePrint.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selComputeDistance_ToFeaturePrintObservation_Error_Handle, outDistance, featurePrint.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
