using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLPhysicallyPlausibleScatteringFunction", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLPhysicallyPlausibleScatteringFunction : MDLScatteringFunction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnisotropic = "anisotropic";

	private static readonly IntPtr selAnisotropicHandle = Selector.GetHandle("anisotropic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnisotropicRotation = "anisotropicRotation";

	private static readonly IntPtr selAnisotropicRotationHandle = Selector.GetHandle("anisotropicRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearcoat = "clearcoat";

	private static readonly IntPtr selClearcoatHandle = Selector.GetHandle("clearcoat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearcoatGloss = "clearcoatGloss";

	private static readonly IntPtr selClearcoatGlossHandle = Selector.GetHandle("clearcoatGloss");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetallic = "metallic";

	private static readonly IntPtr selMetallicHandle = Selector.GetHandle("metallic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoughness = "roughness";

	private static readonly IntPtr selRoughnessHandle = Selector.GetHandle("roughness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSheen = "sheen";

	private static readonly IntPtr selSheenHandle = Selector.GetHandle("sheen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSheenTint = "sheenTint";

	private static readonly IntPtr selSheenTintHandle = Selector.GetHandle("sheenTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecularAmount = "specularAmount";

	private static readonly IntPtr selSpecularAmountHandle = Selector.GetHandle("specularAmount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecularTint = "specularTint";

	private static readonly IntPtr selSpecularTintHandle = Selector.GetHandle("specularTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubsurface = "subsurface";

	private static readonly IntPtr selSubsurfaceHandle = Selector.GetHandle("subsurface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLPhysicallyPlausibleScatteringFunction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Anisotropic
	{
		[Export("anisotropic", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnisotropicHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnisotropicHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty AnisotropicRotation
	{
		[Export("anisotropicRotation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnisotropicRotationHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnisotropicRotationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Clearcoat
	{
		[Export("clearcoat", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selClearcoatHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClearcoatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty ClearcoatGloss
	{
		[Export("clearcoatGloss", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selClearcoatGlossHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClearcoatGlossHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Metallic
	{
		[Export("metallic", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetallicHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetallicHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Roughness
	{
		[Export("roughness", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selRoughnessHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRoughnessHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Sheen
	{
		[Export("sheen", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSheenHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSheenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty SheenTint
	{
		[Export("sheenTint", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSheenTintHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSheenTintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty SpecularAmount
	{
		[Export("specularAmount", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpecularAmountHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpecularAmountHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty SpecularTint
	{
		[Export("specularTint", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpecularTintHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpecularTintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Subsurface
	{
		[Export("subsurface", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubsurfaceHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubsurfaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Version
	{
		[Export("version")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selVersionHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLPhysicallyPlausibleScatteringFunction()
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
	protected MDLPhysicallyPlausibleScatteringFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLPhysicallyPlausibleScatteringFunction(IntPtr handle)
		: base(handle)
	{
	}
}
