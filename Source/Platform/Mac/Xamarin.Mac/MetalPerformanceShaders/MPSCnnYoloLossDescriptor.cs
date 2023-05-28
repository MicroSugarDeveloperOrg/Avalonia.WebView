using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNYOLOLossDescriptor", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSCnnYoloLossDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWHLossDescriptor = "WHLossDescriptor";

	private static readonly IntPtr selWHLossDescriptorHandle = Selector.GetHandle("WHLossDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXYLossDescriptor = "XYLossDescriptor";

	private static readonly IntPtr selXYLossDescriptorHandle = Selector.GetHandle("XYLossDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorBoxes = "anchorBoxes";

	private static readonly IntPtr selAnchorBoxesHandle = Selector.GetHandle("anchorBoxes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassesLossDescriptor = "classesLossDescriptor";

	private static readonly IntPtr selClassesLossDescriptorHandle = Selector.GetHandle("classesLossDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnLossDescriptorWithXYLossType_WHLossType_ConfidenceLossType_ClassesLossType_ReductionType_AnchorBoxes_NumberOfAnchorBoxes_ = "cnnLossDescriptorWithXYLossType:WHLossType:confidenceLossType:classesLossType:reductionType:anchorBoxes:numberOfAnchorBoxes:";

	private static readonly IntPtr selCnnLossDescriptorWithXYLossType_WHLossType_ConfidenceLossType_ClassesLossType_ReductionType_AnchorBoxes_NumberOfAnchorBoxes_Handle = Selector.GetHandle("cnnLossDescriptorWithXYLossType:WHLossType:confidenceLossType:classesLossType:reductionType:anchorBoxes:numberOfAnchorBoxes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfidenceLossDescriptor = "confidenceLossDescriptor";

	private static readonly IntPtr selConfidenceLossDescriptorHandle = Selector.GetHandle("confidenceLossDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxIOUForObjectAbsence = "maxIOUForObjectAbsence";

	private static readonly IntPtr selMaxIOUForObjectAbsenceHandle = Selector.GetHandle("maxIOUForObjectAbsence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinIOUForObjectPresence = "minIOUForObjectPresence";

	private static readonly IntPtr selMinIOUForObjectPresenceHandle = Selector.GetHandle("minIOUForObjectPresence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfAnchorBoxes = "numberOfAnchorBoxes";

	private static readonly IntPtr selNumberOfAnchorBoxesHandle = Selector.GetHandle("numberOfAnchorBoxes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReductionType = "reductionType";

	private static readonly IntPtr selReductionTypeHandle = Selector.GetHandle("reductionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRescore = "rescore";

	private static readonly IntPtr selRescoreHandle = Selector.GetHandle("rescore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleClass = "scaleClass";

	private static readonly IntPtr selScaleClassHandle = Selector.GetHandle("scaleClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleNoObject = "scaleNoObject";

	private static readonly IntPtr selScaleNoObjectHandle = Selector.GetHandle("scaleNoObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleObject = "scaleObject";

	private static readonly IntPtr selScaleObjectHandle = Selector.GetHandle("scaleObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleWH = "scaleWH";

	private static readonly IntPtr selScaleWHHandle = Selector.GetHandle("scaleWH");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXY = "scaleXY";

	private static readonly IntPtr selScaleXYHandle = Selector.GetHandle("scaleXY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorBoxes_ = "setAnchorBoxes:";

	private static readonly IntPtr selSetAnchorBoxes_Handle = Selector.GetHandle("setAnchorBoxes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClassesLossDescriptor_ = "setClassesLossDescriptor:";

	private static readonly IntPtr selSetClassesLossDescriptor_Handle = Selector.GetHandle("setClassesLossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfidenceLossDescriptor_ = "setConfidenceLossDescriptor:";

	private static readonly IntPtr selSetConfidenceLossDescriptor_Handle = Selector.GetHandle("setConfidenceLossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxIOUForObjectAbsence_ = "setMaxIOUForObjectAbsence:";

	private static readonly IntPtr selSetMaxIOUForObjectAbsence_Handle = Selector.GetHandle("setMaxIOUForObjectAbsence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinIOUForObjectPresence_ = "setMinIOUForObjectPresence:";

	private static readonly IntPtr selSetMinIOUForObjectPresence_Handle = Selector.GetHandle("setMinIOUForObjectPresence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfAnchorBoxes_ = "setNumberOfAnchorBoxes:";

	private static readonly IntPtr selSetNumberOfAnchorBoxes_Handle = Selector.GetHandle("setNumberOfAnchorBoxes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReductionType_ = "setReductionType:";

	private static readonly IntPtr selSetReductionType_Handle = Selector.GetHandle("setReductionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRescore_ = "setRescore:";

	private static readonly IntPtr selSetRescore_Handle = Selector.GetHandle("setRescore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleClass_ = "setScaleClass:";

	private static readonly IntPtr selSetScaleClass_Handle = Selector.GetHandle("setScaleClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleNoObject_ = "setScaleNoObject:";

	private static readonly IntPtr selSetScaleNoObject_Handle = Selector.GetHandle("setScaleNoObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleObject_ = "setScaleObject:";

	private static readonly IntPtr selSetScaleObject_Handle = Selector.GetHandle("setScaleObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleWH_ = "setScaleWH:";

	private static readonly IntPtr selSetScaleWH_Handle = Selector.GetHandle("setScaleWH:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScaleXY_ = "setScaleXY:";

	private static readonly IntPtr selSetScaleXY_Handle = Selector.GetHandle("setScaleXY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWHLossDescriptor_ = "setWHLossDescriptor:";

	private static readonly IntPtr selSetWHLossDescriptor_Handle = Selector.GetHandle("setWHLossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXYLossDescriptor_ = "setXYLossDescriptor:";

	private static readonly IntPtr selSetXYLossDescriptor_Handle = Selector.GetHandle("setXYLossDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNYOLOLossDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData AnchorBoxes
	{
		[Export("anchorBoxes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnchorBoxesHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnchorBoxesHandle));
		}
		[Export("setAnchorBoxes:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnchorBoxes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnchorBoxes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLossDescriptor ClassesLossDescriptor
	{
		[Export("classesLossDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selClassesLossDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassesLossDescriptorHandle));
		}
		[Export("setClassesLossDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClassesLossDescriptor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClassesLossDescriptor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLossDescriptor ConfidenceLossDescriptor
	{
		[Export("confidenceLossDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfidenceLossDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfidenceLossDescriptorHandle));
		}
		[Export("setConfidenceLossDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfidenceLossDescriptor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfidenceLossDescriptor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaxIouForObjectAbsence
	{
		[Export("maxIOUForObjectAbsence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaxIOUForObjectAbsenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaxIOUForObjectAbsenceHandle);
		}
		[Export("setMaxIOUForObjectAbsence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaxIOUForObjectAbsence_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaxIOUForObjectAbsence_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinIouForObjectPresence
	{
		[Export("minIOUForObjectPresence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinIOUForObjectPresenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinIOUForObjectPresenceHandle);
		}
		[Export("setMinIOUForObjectPresence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinIOUForObjectPresence_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinIOUForObjectPresence_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfAnchorBoxes
	{
		[Export("numberOfAnchorBoxes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfAnchorBoxesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfAnchorBoxesHandle);
		}
		[Export("setNumberOfAnchorBoxes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfAnchorBoxes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfAnchorBoxes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnReductionType ReductionType
	{
		[Export("reductionType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnReductionType)Messaging.int_objc_msgSend(base.Handle, selReductionTypeHandle);
			}
			return (MPSCnnReductionType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selReductionTypeHandle);
		}
		[Export("setReductionType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetReductionType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetReductionType_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Rescore
	{
		[Export("rescore")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRescoreHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRescoreHandle);
		}
		[Export("setRescore:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRescore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRescore_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleClass
	{
		[Export("scaleClass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleClassHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleClassHandle);
		}
		[Export("setScaleClass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleClass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleClass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleNoObject
	{
		[Export("scaleNoObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleNoObjectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleNoObjectHandle);
		}
		[Export("setScaleNoObject:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleNoObject_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleNoObject_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleObject
	{
		[Export("scaleObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleObjectHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleObjectHandle);
		}
		[Export("setScaleObject:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleObject_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleObject_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleWH
	{
		[Export("scaleWH")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleWHHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleWHHandle);
		}
		[Export("setScaleWH:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleWH_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleWH_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ScaleXY
	{
		[Export("scaleXY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleXYHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleXYHandle);
		}
		[Export("setScaleXY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetScaleXY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetScaleXY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLossDescriptor WHLossDescriptor
	{
		[Export("WHLossDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selWHLossDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWHLossDescriptorHandle));
		}
		[Export("setWHLossDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWHLossDescriptor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWHLossDescriptor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnLossDescriptor XYLossDescriptor
	{
		[Export("XYLossDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selXYLossDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSCnnLossDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXYLossDescriptorHandle));
		}
		[Export("setXYLossDescriptor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetXYLossDescriptor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetXYLossDescriptor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnYoloLossDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnYoloLossDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("cnnLossDescriptorWithXYLossType:WHLossType:confidenceLossType:classesLossType:reductionType:anchorBoxes:numberOfAnchorBoxes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnYoloLossDescriptor Create(MPSCnnLossType xyLossType, MPSCnnLossType whLossType, MPSCnnLossType confidenceLossType, MPSCnnLossType classesLossType, MPSCnnReductionType reductionType, NSData anchorBoxes, nuint numberOfAnchorBoxes)
	{
		if (anchorBoxes == null)
		{
			throw new ArgumentNullException("anchorBoxes");
		}
		return Runtime.GetNSObject<MPSCnnYoloLossDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32_UInt32_UInt32_UInt32_int_IntPtr_nuint(class_ptr, selCnnLossDescriptorWithXYLossType_WHLossType_ConfidenceLossType_ClassesLossType_ReductionType_AnchorBoxes_NumberOfAnchorBoxes_Handle, (uint)xyLossType, (uint)whLossType, (uint)confidenceLossType, (uint)classesLossType, (int)reductionType, anchorBoxes.Handle, numberOfAnchorBoxes));
	}
}
