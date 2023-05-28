using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AudioUnit;

[NoWatch]
[NoTV]
[Mac(10, 13)]
[iOS(11, 0)]
public class AudioComponentInfo : DictionaryContainer
{
	private static NSString typeK = new NSString("type");

	private static NSString subtypeK = new NSString("subtype");

	private static NSString manufacturerK = new NSString("manufacturer");

	private static NSString nameK = new NSString("name");

	private static NSString versionK = new NSString("version");

	private static NSString factoryFunctionK = new NSString("factoryFunction");

	private static NSString sandboxSafeK = new NSString("sandboxSafe");

	private static NSString resourceUsageK = new NSString("resourceUsage");

	private static NSString tagsK = new NSString("tags");

	public string Type
	{
		get
		{
			return GetStringValue(typeK);
		}
		set
		{
			SetStringValue(typeK, value);
		}
	}

	public string Subtype
	{
		get
		{
			return GetStringValue(subtypeK);
		}
		set
		{
			SetStringValue(subtypeK, value);
		}
	}

	public string Manufacturer
	{
		get
		{
			return GetStringValue(manufacturerK);
		}
		set
		{
			SetStringValue(manufacturerK, value);
		}
	}

	public string Name
	{
		get
		{
			return GetStringValue(nameK);
		}
		set
		{
			SetStringValue(nameK, value);
		}
	}

	public nuint? Version
	{
		get
		{
			return GetNUIntValue(versionK);
		}
		set
		{
			SetNumberValue(versionK, value);
		}
	}

	public string FactoryFunction
	{
		get
		{
			return GetStringValue(factoryFunctionK);
		}
		set
		{
			SetStringValue(factoryFunctionK, value);
		}
	}

	public bool? SandboxSafe
	{
		get
		{
			return GetBoolValue(sandboxSafeK);
		}
		set
		{
			SetBooleanValue(sandboxSafeK, value);
		}
	}

	public ResourceUsageInfo ResourceUsage
	{
		get
		{
			return GetStrongDictionary<ResourceUsageInfo>(resourceUsageK);
		}
		set
		{
			SetNativeValue(resourceUsageK, value?.Dictionary);
		}
	}

	public string[] Tags
	{
		get
		{
			NSArray nativeValue = GetNativeValue<NSArray>(tagsK);
			if (nativeValue == null)
			{
				return null;
			}
			return NSArray.StringArrayFromHandle(nativeValue.Handle);
		}
		set
		{
			if (value == null)
			{
				RemoveValue(tagsK);
			}
			else
			{
				SetArrayValue(tagsK, value);
			}
		}
	}

	public AudioComponentInfo()
	{
	}

	public AudioComponentInfo(NSDictionary dic)
		: base(dic)
	{
	}
}
