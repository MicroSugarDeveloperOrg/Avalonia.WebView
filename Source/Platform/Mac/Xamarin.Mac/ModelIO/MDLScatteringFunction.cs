using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLScatteringFunction", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLScatteringFunction : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbientOcclusion = "ambientOcclusion";

	private static readonly IntPtr selAmbientOcclusionHandle = Selector.GetHandle("ambientOcclusion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAmbientOcclusionScale = "ambientOcclusionScale";

	private static readonly IntPtr selAmbientOcclusionScaleHandle = Selector.GetHandle("ambientOcclusionScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseColor = "baseColor";

	private static readonly IntPtr selBaseColorHandle = Selector.GetHandle("baseColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmission = "emission";

	private static readonly IntPtr selEmissionHandle = Selector.GetHandle("emission");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceIndexOfRefraction = "interfaceIndexOfRefraction";

	private static readonly IntPtr selInterfaceIndexOfRefractionHandle = Selector.GetHandle("interfaceIndexOfRefraction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterialIndexOfRefraction = "materialIndexOfRefraction";

	private static readonly IntPtr selMaterialIndexOfRefractionHandle = Selector.GetHandle("materialIndexOfRefraction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormal = "normal";

	private static readonly IntPtr selNormalHandle = Selector.GetHandle("normal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpecular = "specular";

	private static readonly IntPtr selSpecularHandle = Selector.GetHandle("specular");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLScatteringFunction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty AmbientOcclusion
	{
		[Export("ambientOcclusion", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAmbientOcclusionHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAmbientOcclusionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty AmbientOcclusionScale
	{
		[Export("ambientOcclusionScale", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selAmbientOcclusionScaleHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAmbientOcclusionScaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty BaseColor
	{
		[Export("baseColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseColorHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Emission
	{
		[Export("emission", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selEmissionHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmissionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty InterfaceIndexOfRefraction
	{
		[Export("interfaceIndexOfRefraction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selInterfaceIndexOfRefractionHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterfaceIndexOfRefractionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty MaterialIndexOfRefraction
	{
		[Export("materialIndexOfRefraction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaterialIndexOfRefractionHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaterialIndexOfRefractionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Normal
	{
		[Export("normal", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selNormalHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNormalHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty Specular
	{
		[Export("specular", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpecularHandle));
			}
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpecularHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLScatteringFunction()
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
	protected MDLScatteringFunction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLScatteringFunction(IntPtr handle)
		: base(handle)
	{
	}
}
