using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

[iOS(9, 0)]
[Mac(10, 11)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class SCNRenderingOptions : DictionaryContainer
{
	public SCNRenderingApi? RenderingApi
	{
		get
		{
			nuint? nUIntValue = GetNUIntValue(SCNRenderingOptionsKeys.RenderingApiKey);
			if (nUIntValue.HasValue)
			{
				return (SCNRenderingApi)(uint)nUIntValue.Value;
			}
			return null;
		}
		set
		{
			if (value.HasValue)
			{
				SetNumberValue(SCNRenderingOptionsKeys.RenderingApiKey, (nuint?)(nuint)(uint)value.Value);
			}
			else
			{
				RemoveValue(SCNRenderingOptionsKeys.RenderingApiKey);
			}
		}
	}

	public IMTLDevice? Device
	{
		get
		{
			return base.Dictionary[SCNRenderingOptionsKeys.DeviceKey] as IMTLDevice;
		}
		set
		{
			SetNativeValue(SCNRenderingOptionsKeys.DeviceKey, value);
		}
	}

	public bool? LowPowerDevice
	{
		get
		{
			return GetBoolValue(SCNRenderingOptionsKeys.LowPowerDeviceKey);
		}
		set
		{
			SetBooleanValue(SCNRenderingOptionsKeys.LowPowerDeviceKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNRenderingOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNRenderingOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
