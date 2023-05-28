using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNUpsamplingBilinearNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnUpsamplingBilinearNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignCorners = "alignCorners";

	private static readonly IntPtr selAlignCornersHandle = Selector.GetHandle("alignCorners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_ = "initWithSource:integerScaleFactorX:integerScaleFactorY:";

	private static readonly IntPtr selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_Handle = Selector.GetHandle("initWithSource:integerScaleFactorX:integerScaleFactorY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_ = "initWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:";

	private static readonly IntPtr selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle = Selector.GetHandle("initWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_ = "nodeWithSource:integerScaleFactorX:integerScaleFactorY:";

	private static readonly IntPtr selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_Handle = Selector.GetHandle("nodeWithSource:integerScaleFactorX:integerScaleFactorY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_ = "nodeWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:";

	private static readonly IntPtr selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle = Selector.GetHandle("nodeWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactorX = "scaleFactorX";

	private static readonly IntPtr selScaleFactorXHandle = Selector.GetHandle("scaleFactorX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactorY = "scaleFactorY";

	private static readonly IntPtr selScaleFactorYHandle = Selector.GetHandle("scaleFactorY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNUpsamplingBilinearNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool AlignCorners
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("alignCorners")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlignCornersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlignCornersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ScaleFactorX
	{
		[Export("scaleFactorX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScaleFactorXHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScaleFactorXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ScaleFactorY
	{
		[Export("scaleFactorY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScaleFactorYHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScaleFactorYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnUpsamplingBilinearNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnUpsamplingBilinearNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:integerScaleFactorX:integerScaleFactorY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnUpsamplingBilinearNode(MPSNNImageNode sourceNode, nuint integerScaleFactorX, nuint integerScaleFactorY)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY), "initWithSource:integerScaleFactorX:integerScaleFactorY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY), "initWithSource:integerScaleFactorX:integerScaleFactorY:");
		}
	}

	[Export("initWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnUpsamplingBilinearNode(MPSNNImageNode sourceNode, nuint integerScaleFactorX, nuint integerScaleFactorY, bool alignCorners)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_bool(base.Handle, selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY, alignCorners), "initWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_bool(base.SuperHandle, selInitWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY, alignCorners), "initWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:");
		}
	}

	[Export("nodeWithSource:integerScaleFactorX:integerScaleFactorY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnUpsamplingBilinearNode Create(MPSNNImageNode sourceNode, nuint integerScaleFactorX, nuint integerScaleFactorY)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnUpsamplingBilinearNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(class_ptr, selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY));
	}

	[Export("nodeWithSource:integerScaleFactorX:integerScaleFactorY:alignCorners:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnUpsamplingBilinearNode Create(MPSNNImageNode sourceNode, nuint integerScaleFactorX, nuint integerScaleFactorY, bool alignCorners)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnUpsamplingBilinearNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_bool(class_ptr, selNodeWithSource_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle, sourceNode.Handle, integerScaleFactorX, integerScaleFactorY, alignCorners));
	}
}
