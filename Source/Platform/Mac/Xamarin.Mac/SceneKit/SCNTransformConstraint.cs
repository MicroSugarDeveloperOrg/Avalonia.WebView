using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNTransformConstraint", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNTransformConstraint : SCNConstraint
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientationConstraintInWorldSpace_WithBlock_ = "orientationConstraintInWorldSpace:withBlock:";

	private static readonly IntPtr selOrientationConstraintInWorldSpace_WithBlock_Handle = Selector.GetHandle("orientationConstraintInWorldSpace:withBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPositionConstraintInWorldSpace_WithBlock_ = "positionConstraintInWorldSpace:withBlock:";

	private static readonly IntPtr selPositionConstraintInWorldSpace_WithBlock_Handle = Selector.GetHandle("positionConstraintInWorldSpace:withBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformConstraintInWorldSpace_WithBlock_ = "transformConstraintInWorldSpace:withBlock:";

	private static readonly IntPtr selTransformConstraintInWorldSpace_WithBlock_Handle = Selector.GetHandle("transformConstraintInWorldSpace:withBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNTransformConstraint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNTransformConstraint(NSCoder coder)
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
	protected SCNTransformConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNTransformConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("transformConstraintInWorldSpace:withBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNTransformConstraint Create(bool inWorldSpace, [BlockProxy(typeof(Trampolines.NIDSCNTransformConstraintHandler))] SCNTransformConstraintHandler transformHandler)
	{
		if (transformHandler == null)
		{
			throw new ArgumentNullException("transformHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNTransformConstraintHandler.Handler, transformHandler);
		SCNTransformConstraint nSObject = Runtime.GetNSObject<SCNTransformConstraint>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(class_ptr, selTransformConstraintInWorldSpace_WithBlock_Handle, inWorldSpace, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("orientationConstraintInWorldSpace:withBlock:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNTransformConstraint CreateOrientationConstraint(bool inWorldSpace, [BlockProxy(typeof(Trampolines.NIDFuncArity3V1))] Func<SCNNode, SCNQuaternion, SCNQuaternion> transformHandler)
	{
		if (transformHandler == null)
		{
			throw new ArgumentNullException("transformHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity3V1.Handler, transformHandler);
		SCNTransformConstraint nSObject = Runtime.GetNSObject<SCNTransformConstraint>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(class_ptr, selOrientationConstraintInWorldSpace_WithBlock_Handle, inWorldSpace, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("positionConstraintInWorldSpace:withBlock:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNTransformConstraint CreatePositionConstraint(bool inWorldSpace, [BlockProxy(typeof(Trampolines.NIDFuncArity3V2))] Func<SCNNode, SCNVector3, SCNVector3> transformHandler)
	{
		if (transformHandler == null)
		{
			throw new ArgumentNullException("transformHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity3V2.Handler, transformHandler);
		SCNTransformConstraint nSObject = Runtime.GetNSObject<SCNTransformConstraint>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(class_ptr, selPositionConstraintInWorldSpace_WithBlock_Handle, inWorldSpace, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}
}
