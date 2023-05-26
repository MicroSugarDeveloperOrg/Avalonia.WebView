using System.Runtime.InteropServices;

namespace AudioToolbox;

internal static class AudioServices
{
	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	public static extern AudioServicesError AudioServicesGetProperty(AudioServicesPropertyKey propertyId, uint specifierSize, ref uint specifier, out uint propertyDataSize, out uint propertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	public static extern AudioServicesError AudioServicesSetProperty(AudioServicesPropertyKey propertyId, uint specifierSize, ref uint specifier, uint propertyDataSize, ref uint propertyData);
}
