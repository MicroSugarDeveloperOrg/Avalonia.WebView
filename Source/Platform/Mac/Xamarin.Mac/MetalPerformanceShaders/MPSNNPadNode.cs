using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNPadNode", true)]
[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
public class MPSNNPadNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillValue = "fillValue";

	private static readonly IntPtr selFillValueHandle = Selector.GetHandle("fillValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_ = "initWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:";

	private static readonly IntPtr selInitWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_Handle = Selector.GetHandle("initWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_ = "nodeWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:";

	private static readonly IntPtr selNodeWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_Handle = Selector.GetHandle("nodeWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillValue_ = "setFillValue:";

	private static readonly IntPtr selSetFillValue_Handle = Selector.GetHandle("setFillValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNPadNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FillValue
	{
		[Export("fillValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFillValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFillValueHandle);
		}
		[Export("setFillValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFillValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFillValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNPadNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNPadNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNPadNode(MPSNNImageNode source, MPSImageCoordinate paddingSizeBefore, MPSImageCoordinate paddingSizeAfter, MPSImageEdgeMode edgeMode)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MPSImageCoordinate_MPSImageCoordinate_UInt64(base.Handle, selInitWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_Handle, source.Handle, paddingSizeBefore, paddingSizeAfter, (ulong)edgeMode), "initWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MPSImageCoordinate_MPSImageCoordinate_UInt64(base.SuperHandle, selInitWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_Handle, source.Handle, paddingSizeBefore, paddingSizeAfter, (ulong)edgeMode), "initWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:");
		}
	}

	[Export("nodeWithSource:paddingSizeBefore:paddingSizeAfter:edgeMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNPadNode Create(MPSNNImageNode source, MPSImageCoordinate paddingSizeBefore, MPSImageCoordinate paddingSizeAfter, MPSImageEdgeMode edgeMode)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSNNPadNode>(Messaging.IntPtr_objc_msgSend_IntPtr_MPSImageCoordinate_MPSImageCoordinate_UInt64(class_ptr, selNodeWithSource_PaddingSizeBefore_PaddingSizeAfter_EdgeMode_Handle, source.Handle, paddingSizeBefore, paddingSizeAfter, (ulong)edgeMode));
	}
}
