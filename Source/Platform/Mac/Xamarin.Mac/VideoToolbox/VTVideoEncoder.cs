using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[iOS(8, 0)]
[TV(10, 2)]
public class VTVideoEncoder
{
	public int CodecType { get; private set; }

	public string CodecName { get; private set; }

	public string DisplayName { get; private set; }

	public string EncoderId { get; private set; }

	public string EncoderName { get; private set; }

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	private static extern VTStatus VTCopyVideoEncoderList(IntPtr options, out IntPtr listOfVideoEncodersOut);

	public static VTVideoEncoder[] GetEncoderList()
	{
		if (VTCopyVideoEncoderList(IntPtr.Zero, out var listOfVideoEncodersOut) != 0)
		{
			return null;
		}
		NSDictionary[] array = NSArray.ArrayFromHandle<NSDictionary>(listOfVideoEncodersOut);
		VTVideoEncoder[] array2 = new VTVideoEncoder[array.Length];
		int num = 0;
		NSDictionary[] array3 = array;
		foreach (NSDictionary nSDictionary in array3)
		{
			array2[num] = new VTVideoEncoder(nSDictionary[VTVideoEncoderList.CodecType] as NSNumber, nSDictionary[VTVideoEncoderList.CodecName] as NSString, nSDictionary[VTVideoEncoderList.DisplayName] as NSString, nSDictionary[VTVideoEncoderList.EncoderID] as NSString, nSDictionary[VTVideoEncoderList.EncoderName] as NSString);
			num++;
		}
		CFObject.CFRelease(listOfVideoEncodersOut);
		return array2;
	}

	internal VTVideoEncoder(NSNumber codecType, NSString codecName, NSString displayName, NSString encoderId, NSString encoderName)
	{
		CodecType = codecType.Int32Value;
		CodecName = codecName;
		DisplayName = displayName;
		EncoderId = encoderId;
		EncoderName = encoderName;
	}

	[DllImport("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox")]
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	private static extern VTStatus VTCopySupportedPropertyDictionaryForEncoder(int width, int height, CMVideoCodecType codecType, IntPtr encoderSpecification, out IntPtr outEncoderId, out IntPtr outSupportedProperties);

	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	public static VTSupportedEncoderProperties GetSupportedEncoderProperties(int width, int height, CMVideoCodecType codecType, NSDictionary encoderSpecification = null)
	{
		IntPtr outEncoderId = IntPtr.Zero;
		IntPtr outSupportedProperties = IntPtr.Zero;
		if (VTCopySupportedPropertyDictionaryForEncoder(width, height, codecType, encoderSpecification?.Handle ?? IntPtr.Zero, out outEncoderId, out outSupportedProperties) != 0)
		{
			if (outEncoderId != IntPtr.Zero)
			{
				CFObject.CFRelease(outEncoderId);
			}
			if (outSupportedProperties != IntPtr.Zero)
			{
				CFObject.CFRelease(outSupportedProperties);
			}
			return null;
		}
		return new VTSupportedEncoderProperties
		{
			EncoderId = CFString.FetchString(outEncoderId, releaseHandle: true),
			SupportedProperties = Runtime.GetNSObject<NSDictionary>(outSupportedProperties, owns: true)
		};
	}
}
