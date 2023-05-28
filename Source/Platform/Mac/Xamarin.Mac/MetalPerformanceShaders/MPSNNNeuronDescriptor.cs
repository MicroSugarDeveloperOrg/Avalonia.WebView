using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNNeuronDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNNeuronDescriptor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selA = "a";

	private static readonly IntPtr selAHandle = Selector.GetHandle("a");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selB = "b";

	private static readonly IntPtr selBHandle = Selector.GetHandle("b");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selC = "c";

	private static readonly IntPtr selCHandle = Selector.GetHandle("c");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnNeuronDescriptorWithType_ = "cnnNeuronDescriptorWithType:";

	private static readonly IntPtr selCnnNeuronDescriptorWithType_Handle = Selector.GetHandle("cnnNeuronDescriptorWithType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnNeuronDescriptorWithType_A_ = "cnnNeuronDescriptorWithType:a:";

	private static readonly IntPtr selCnnNeuronDescriptorWithType_A_Handle = Selector.GetHandle("cnnNeuronDescriptorWithType:a:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnNeuronDescriptorWithType_A_B_ = "cnnNeuronDescriptorWithType:a:b:";

	private static readonly IntPtr selCnnNeuronDescriptorWithType_A_B_Handle = Selector.GetHandle("cnnNeuronDescriptorWithType:a:b:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnNeuronDescriptorWithType_A_B_C_ = "cnnNeuronDescriptorWithType:a:b:c:";

	private static readonly IntPtr selCnnNeuronDescriptorWithType_A_B_C_Handle = Selector.GetHandle("cnnNeuronDescriptorWithType:a:b:c:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCnnNeuronPReLUDescriptorWithData_NoCopy_ = "cnnNeuronPReLUDescriptorWithData:noCopy:";

	private static readonly IntPtr selCnnNeuronPReLUDescriptorWithData_NoCopy_Handle = Selector.GetHandle("cnnNeuronPReLUDescriptorWithData:noCopy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetA_ = "setA:";

	private static readonly IntPtr selSetA_Handle = Selector.GetHandle("setA:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetB_ = "setB:";

	private static readonly IntPtr selSetB_Handle = Selector.GetHandle("setB:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetC_ = "setC:";

	private static readonly IntPtr selSetC_Handle = Selector.GetHandle("setC:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ = "setData:";

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNeuronType_ = "setNeuronType:";

	private static readonly IntPtr selSetNeuronType_Handle = Selector.GetHandle("setNeuronType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNNeuronDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float A
	{
		[Export("a")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAHandle);
		}
		[Export("setA:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetA_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetA_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float B
	{
		[Export("b")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBHandle);
		}
		[Export("setB:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetB_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetB_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float C
	{
		[Export("c")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCHandle);
		}
		[Export("setC:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetC_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetC_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Data
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
		[Export("setData:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Export("neuronType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnNeuronType)Messaging.int_objc_msgSend(base.Handle, selNeuronTypeHandle);
			}
			return (MPSCnnNeuronType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selNeuronTypeHandle);
		}
		[Export("setNeuronType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetNeuronType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetNeuronType_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNNeuronDescriptor(NSCoder coder)
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
	protected MPSNNNeuronDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNNeuronDescriptor(IntPtr handle)
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

	[Export("cnnNeuronDescriptorWithType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNNeuronDescriptor Create(MPSCnnNeuronType neuronType)
	{
		return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selCnnNeuronDescriptorWithType_Handle, (int)neuronType));
	}

	[Export("cnnNeuronDescriptorWithType:a:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNNeuronDescriptor Create(MPSCnnNeuronType neuronType, float a)
	{
		return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend_int_float(class_ptr, selCnnNeuronDescriptorWithType_A_Handle, (int)neuronType, a));
	}

	[Export("cnnNeuronDescriptorWithType:a:b:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNNeuronDescriptor Create(MPSCnnNeuronType neuronType, float a, float b)
	{
		return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend_int_float_float(class_ptr, selCnnNeuronDescriptorWithType_A_B_Handle, (int)neuronType, a, b));
	}

	[Export("cnnNeuronDescriptorWithType:a:b:c:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNNeuronDescriptor Create(MPSCnnNeuronType neuronType, float a, float b, float c)
	{
		return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend_int_float_float_float(class_ptr, selCnnNeuronDescriptorWithType_A_B_C_Handle, (int)neuronType, a, b, c));
	}

	[Export("cnnNeuronPReLUDescriptorWithData:noCopy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNNeuronDescriptor Create(NSData data, bool noCopy)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selCnnNeuronPReLUDescriptorWithData_NoCopy_Handle, data.Handle, noCopy));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
