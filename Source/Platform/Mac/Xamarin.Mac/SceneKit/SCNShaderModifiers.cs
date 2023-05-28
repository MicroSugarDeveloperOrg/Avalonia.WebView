using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class SCNShaderModifiers : DictionaryContainer
{
	public string? EntryPointGeometry
	{
		get
		{
			return GetStringValue(_SCNShaderModifiers.EntryPointGeometryKey);
		}
		set
		{
			SetStringValue(_SCNShaderModifiers.EntryPointGeometryKey, value);
		}
	}

	public string? EntryPointSurface
	{
		get
		{
			return GetStringValue(_SCNShaderModifiers.EntryPointSurfaceKey);
		}
		set
		{
			SetStringValue(_SCNShaderModifiers.EntryPointSurfaceKey, value);
		}
	}

	public string? EntryPointLightingModel
	{
		get
		{
			return GetStringValue(_SCNShaderModifiers.EntryPointLightingModelKey);
		}
		set
		{
			SetStringValue(_SCNShaderModifiers.EntryPointLightingModelKey, value);
		}
	}

	public string? EntryPointFragment
	{
		get
		{
			return GetStringValue(_SCNShaderModifiers.EntryPointFragmentKey);
		}
		set
		{
			SetStringValue(_SCNShaderModifiers.EntryPointFragmentKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNShaderModifiers()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNShaderModifiers(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
