using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace GLKit;

[Register("GLKEffectPropertyMaterial", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKEffectPropertyMaterial : GLKEffectProperty
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbientColor = "ambientColor";

	private static readonly IntPtr selAmbientColorHandle = Selector.GetHandle("ambientColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiffuseColor = "diffuseColor";

	private static readonly IntPtr selDiffuseColorHandle = Selector.GetHandle("diffuseColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmissiveColor = "emissiveColor";

	private static readonly IntPtr selEmissiveColorHandle = Selector.GetHandle("emissiveColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAmbientColor_ = "setAmbientColor:";

	private static readonly IntPtr selSetAmbientColor_Handle = Selector.GetHandle("setAmbientColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDiffuseColor_ = "setDiffuseColor:";

	private static readonly IntPtr selSetDiffuseColor_Handle = Selector.GetHandle("setDiffuseColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmissiveColor_ = "setEmissiveColor:";

	private static readonly IntPtr selSetEmissiveColor_Handle = Selector.GetHandle("setEmissiveColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShininess_ = "setShininess:";

	private static readonly IntPtr selSetShininess_Handle = Selector.GetHandle("setShininess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpecularColor_ = "setSpecularColor:";

	private static readonly IntPtr selSetSpecularColor_Handle = Selector.GetHandle("setSpecularColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShininess = "shininess";

	private static readonly IntPtr selShininessHandle = Selector.GetHandle("shininess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecularColor = "specularColor";

	private static readonly IntPtr selSpecularColorHandle = Selector.GetHandle("specularColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKEffectPropertyMaterial");

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
	public unsafe virtual Vector4 EmissiveColor
	{
		[Export("emissiveColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selEmissiveColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selEmissiveColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setEmissiveColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetEmissiveColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetEmissiveColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Shininess
	{
		[Export("shininess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selShininessHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selShininessHandle);
		}
		[Export("setShininess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetShininess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetShininess_Handle, value);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKEffectPropertyMaterial()
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
	protected GLKEffectPropertyMaterial(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKEffectPropertyMaterial(IntPtr handle)
		: base(handle)
	{
	}
}
