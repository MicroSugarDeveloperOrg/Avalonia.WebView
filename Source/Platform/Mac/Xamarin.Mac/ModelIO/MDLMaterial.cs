using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using SceneKit;

namespace ModelIO;

[Register("MDLMaterial", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLMaterial : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseMaterial = "baseMaterial";

	private static readonly IntPtr selBaseMaterialHandle = Selector.GetHandle("baseMaterial");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ScatteringFunction_ = "initWithName:scatteringFunction:";

	private static readonly IntPtr selInitWithName_ScatteringFunction_Handle = Selector.GetHandle("initWithName:scatteringFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadTexturesUsingResolver_ = "loadTexturesUsingResolver:";

	private static readonly IntPtr selLoadTexturesUsingResolver_Handle = Selector.GetHandle("loadTexturesUsingResolver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterialFace = "materialFace";

	private static readonly IntPtr selMaterialFaceHandle = Selector.GetHandle("materialFace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterialWithSCNMaterial_ = "materialWithSCNMaterial:";

	private static readonly IntPtr selMaterialWithSCNMaterial_Handle = Selector.GetHandle("materialWithSCNMaterial:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertiesWithSemantic_ = "propertiesWithSemantic:";

	private static readonly IntPtr selPropertiesWithSemantic_Handle = Selector.GetHandle("propertiesWithSemantic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyNamed_ = "propertyNamed:";

	private static readonly IntPtr selPropertyNamed_Handle = Selector.GetHandle("propertyNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyWithSemantic_ = "propertyWithSemantic:";

	private static readonly IntPtr selPropertyWithSemantic_Handle = Selector.GetHandle("propertyWithSemantic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllProperties = "removeAllProperties";

	private static readonly IntPtr selRemoveAllPropertiesHandle = Selector.GetHandle("removeAllProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveProperty_ = "removeProperty:";

	private static readonly IntPtr selRemoveProperty_Handle = Selector.GetHandle("removeProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveTexturesWithResolver_ = "resolveTexturesWithResolver:";

	private static readonly IntPtr selResolveTexturesWithResolver_Handle = Selector.GetHandle("resolveTexturesWithResolver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScatteringFunction = "scatteringFunction";

	private static readonly IntPtr selScatteringFunctionHandle = Selector.GetHandle("scatteringFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseMaterial_ = "setBaseMaterial:";

	private static readonly IntPtr selSetBaseMaterial_Handle = Selector.GetHandle("setBaseMaterial:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaterialFace_ = "setMaterialFace:";

	private static readonly IntPtr selSetMaterialFace_Handle = Selector.GetHandle("setMaterialFace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperty_ = "setProperty:";

	private static readonly IntPtr selSetProperty_Handle = Selector.GetHandle("setProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMaterial");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterial? BaseMaterial
	{
		[Export("baseMaterial", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLMaterial>(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseMaterialHandle));
			}
			return Runtime.GetNSObject<MDLMaterial>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseMaterialHandle));
		}
		[Export("setBaseMaterial:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBaseMaterial_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBaseMaterial_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual MDLMaterialFace MaterialFace
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("materialFace", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialFace)Messaging.UInt64_objc_msgSend(base.Handle, selMaterialFaceHandle);
			}
			return (MDLMaterialFace)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMaterialFaceHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setMaterialFace:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMaterialFace_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMaterialFace_Handle, (ulong)value);
			}
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
	public virtual MDLScatteringFunction ScatteringFunction
	{
		[Export("scatteringFunction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLScatteringFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selScatteringFunctionHandle));
			}
			return Runtime.GetNSObject<MDLScatteringFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScatteringFunctionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLMaterial()
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
	protected MDLMaterial(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMaterial(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:scatteringFunction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterial(string name, MDLScatteringFunction scatteringFunction)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (scatteringFunction == null)
		{
			throw new ArgumentNullException("scatteringFunction");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_ScatteringFunction_Handle, arg, scatteringFunction.Handle), "initWithName:scatteringFunction:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_ScatteringFunction_Handle, arg, scatteringFunction.Handle), "initWithName:scatteringFunction:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("materialWithSCNMaterial:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMaterial FromSceneMaterial(SCNMaterial material)
	{
		if (material == null)
		{
			throw new ArgumentNullException("material");
		}
		return Runtime.GetNSObject<MDLMaterial>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selMaterialWithSCNMaterial_Handle, material.Handle));
	}

	[Export("propertiesWithSemantic:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty[] GetProperties(MDLMaterialSemantic semantic)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selPropertiesWithSemantic_Handle, (ulong)semantic));
		}
		return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selPropertiesWithSemantic_Handle, (ulong)semantic));
	}

	[Export("propertyNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty? GetProperty(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLMaterialProperty result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyNamed_Handle, arg)) : Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("propertyWithSemantic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty? GetProperty(MDLMaterialSemantic semantic)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selPropertyWithSemantic_Handle, (ulong)semantic));
		}
		return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selPropertyWithSemantic_Handle, (ulong)semantic));
	}

	[Export("loadTexturesUsingResolver:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadTextures(IMDLAssetResolver? resolver)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadTexturesUsingResolver_Handle, resolver?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadTexturesUsingResolver_Handle, resolver?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual MDLMaterialProperty? ObjectAtIndexedSubscript(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, idx));
		}
		return Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, idx));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual MDLMaterialProperty? ObjectForKeyedSubscript(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLMaterialProperty result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, arg)) : Runtime.GetNSObject<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeAllProperties")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllProperties()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllPropertiesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllPropertiesHandle);
		}
	}

	[Export("removeProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveProperty(MDLMaterialProperty property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveProperty_Handle, property.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveProperty_Handle, property.Handle);
		}
	}

	[Export("resolveTexturesWithResolver:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResolveTextures(IMDLAssetResolver? resolver)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResolveTexturesWithResolver_Handle, resolver?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResolveTexturesWithResolver_Handle, resolver?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("setProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetProperty(MDLMaterialProperty property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProperty_Handle, property.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProperty_Handle, property.Handle);
		}
	}
}
