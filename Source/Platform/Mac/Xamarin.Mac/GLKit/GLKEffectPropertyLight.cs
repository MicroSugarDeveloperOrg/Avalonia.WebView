using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace GLKit;

[Register("GLKEffectPropertyLight", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKEffectPropertyLight : GLKEffectProperty
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbientColor = "ambientColor";

	private static readonly IntPtr selAmbientColorHandle = Selector.GetHandle("ambientColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstantAttenuation = "constantAttenuation";

	private static readonly IntPtr selConstantAttenuationHandle = Selector.GetHandle("constantAttenuation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiffuseColor = "diffuseColor";

	private static readonly IntPtr selDiffuseColorHandle = Selector.GetHandle("diffuseColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnabled = "enabled";

	private static readonly IntPtr selEnabledHandle = Selector.GetHandle("enabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinearAttenuation = "linearAttenuation";

	private static readonly IntPtr selLinearAttenuationHandle = Selector.GetHandle("linearAttenuation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPosition = "position";

	private static readonly IntPtr selPositionHandle = Selector.GetHandle("position");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuadraticAttenuation = "quadraticAttenuation";

	private static readonly IntPtr selQuadraticAttenuationHandle = Selector.GetHandle("quadraticAttenuation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAmbientColor_ = "setAmbientColor:";

	private static readonly IntPtr selSetAmbientColor_Handle = Selector.GetHandle("setAmbientColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstantAttenuation_ = "setConstantAttenuation:";

	private static readonly IntPtr selSetConstantAttenuation_Handle = Selector.GetHandle("setConstantAttenuation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiffuseColor_ = "setDiffuseColor:";

	private static readonly IntPtr selSetDiffuseColor_Handle = Selector.GetHandle("setDiffuseColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLinearAttenuation_ = "setLinearAttenuation:";

	private static readonly IntPtr selSetLinearAttenuation_Handle = Selector.GetHandle("setLinearAttenuation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPosition_ = "setPosition:";

	private static readonly IntPtr selSetPosition_Handle = Selector.GetHandle("setPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuadraticAttenuation_ = "setQuadraticAttenuation:";

	private static readonly IntPtr selSetQuadraticAttenuation_Handle = Selector.GetHandle("setQuadraticAttenuation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpecularColor_ = "setSpecularColor:";

	private static readonly IntPtr selSetSpecularColor_Handle = Selector.GetHandle("setSpecularColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpotCutoff_ = "setSpotCutoff:";

	private static readonly IntPtr selSetSpotCutoff_Handle = Selector.GetHandle("setSpotCutoff:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpotDirection_ = "setSpotDirection:";

	private static readonly IntPtr selSetSpotDirection_Handle = Selector.GetHandle("setSpotDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpotExponent_ = "setSpotExponent:";

	private static readonly IntPtr selSetSpotExponent_Handle = Selector.GetHandle("setSpotExponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransform_ = "setTransform:";

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecularColor = "specularColor";

	private static readonly IntPtr selSpecularColorHandle = Selector.GetHandle("specularColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpotCutoff = "spotCutoff";

	private static readonly IntPtr selSpotCutoffHandle = Selector.GetHandle("spotCutoff");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpotDirection = "spotDirection";

	private static readonly IntPtr selSpotDirectionHandle = Selector.GetHandle("spotDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpotExponent = "spotExponent";

	private static readonly IntPtr selSpotExponentHandle = Selector.GetHandle("spotExponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKEffectPropertyLight");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 AmbientColor
	{
		[Export("ambientColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selAmbientColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selAmbientColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setAmbientColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetAmbientColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetAmbientColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ConstantAttenuation
	{
		[Export("constantAttenuation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selConstantAttenuationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selConstantAttenuationHandle);
		}
		[Export("setConstantAttenuation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetConstantAttenuation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetConstantAttenuation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 DiffuseColor
	{
		[Export("diffuseColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selDiffuseColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selDiffuseColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setDiffuseColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetDiffuseColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetDiffuseColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("enabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LinearAttenuation
	{
		[Export("linearAttenuation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLinearAttenuationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLinearAttenuationHandle);
		}
		[Export("setLinearAttenuation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLinearAttenuation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLinearAttenuation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 Position
	{
		[Export("position", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selPositionHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selPositionHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setPosition:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetPosition_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetPosition_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float QuadraticAttenuation
	{
		[Export("quadraticAttenuation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selQuadraticAttenuationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selQuadraticAttenuationHandle);
		}
		[Export("setQuadraticAttenuation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetQuadraticAttenuation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetQuadraticAttenuation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 SpecularColor
	{
		[Export("specularColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selSpecularColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selSpecularColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setSpecularColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetSpecularColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetSpecularColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SpotCutoff
	{
		[Export("spotCutoff")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpotCutoffHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpotCutoffHandle);
		}
		[Export("setSpotCutoff:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpotCutoff_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpotCutoff_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 SpotDirection
	{
		[Export("spotDirection", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector3_objc_msgSend(base.Handle, selSpotDirectionHandle);
			}
			return Messaging.Vector3_objc_msgSendSuper(base.SuperHandle, selSpotDirectionHandle);
		}
		[Export("setSpotDirection:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector3(base.Handle, selSetSpotDirection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetSpotDirection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SpotExponent
	{
		[Export("spotExponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpotExponentHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpotExponentHandle);
		}
		[Export("setSpotExponent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpotExponent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpotExponent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTransform? Transform
	{
		[Export("transform", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyTransform>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransformHandle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyTransform>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformHandle));
		}
		[Export("setTransform:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTransform_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTransform_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKEffectPropertyLight()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GLKEffectPropertyLight(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKEffectPropertyLight(IntPtr handle)
		: base(handle)
	{
	}
}
