using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNComparisonNode", true)]
[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
public class MPSNNComparisonNode : MPSNNBinaryArithmeticNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComparisonType = "comparisonType";

	private static readonly IntPtr selComparisonTypeHandle = Selector.GetHandle("comparisonType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetComparisonType_ = "setComparisonType:";

	private static readonly IntPtr selSetComparisonType_Handle = Selector.GetHandle("setComparisonType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNComparisonNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNComparisonType ComparisonType
	{
		[Export("comparisonType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNComparisonType)Messaging.UInt64_objc_msgSend(base.Handle, selComparisonTypeHandle);
			}
			return (MPSNNComparisonType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selComparisonTypeHandle);
		}
		[Export("setComparisonType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetComparisonType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetComparisonType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNComparisonNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNComparisonNode(IntPtr handle)
		: base(handle)
	{
	}
}
