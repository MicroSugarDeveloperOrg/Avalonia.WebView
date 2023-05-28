using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[NoWatch]
[NoTV]
[Mac(10, 13)]
[iOS(11, 0)]
public class ResourceUsageInfo : DictionaryContainer
{
	private static NSString userClientK = new NSString("iokit.user-client");

	private static NSString globalNameK = new NSString("mach-lookup.global-name");

	private static NSString networkClientK = new NSString("network.client");

	private static NSString exceptionK = new NSString("temporary-exception.files.all.read-write");

	public string[] IOKitUserClient
	{
		get
		{
			NSArray nativeValue = GetNativeValue<NSArray>(userClientK);
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
				RemoveValue(userClientK);
			}
			else
			{
				SetArrayValue(userClientK, value);
			}
		}
	}

	public string[] MachLookUpGlobalName
	{
		get
		{
			NSArray nativeValue = GetNativeValue<NSArray>(globalNameK);
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
				RemoveValue(globalNameK);
			}
			else
			{
				SetArrayValue(globalNameK, value);
			}
		}
	}

	public bool? NetworkClient
	{
		get
		{
			return GetBoolValue(networkClientK);
		}
		set
		{
			SetBooleanValue(networkClientK, value);
		}
	}

	public bool? TemporaryExceptionReadWrite
	{
		get
		{
			return GetBoolValue(exceptionK);
		}
		set
		{
			SetBooleanValue(exceptionK, value);
		}
	}

	public ResourceUsageInfo()
	{
	}

	public ResourceUsageInfo(NSDictionary dic)
		: base(dic)
	{
	}
}
