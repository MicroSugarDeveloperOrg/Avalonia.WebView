using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace AudioToolbox;

public static class AudioFileGlobalInfo
{
	public unsafe static AudioFileType[] ReadableTypes
	{
		get
		{
			if (AudioFileGetGlobalInfoSize(AudioFileGlobalProperty.ReadableTypes, 0u, IntPtr.Zero, out var outDataSize) != 0)
			{
				return null;
			}
			AudioFileType[] array = new AudioFileType[outDataSize / 4u];
			fixed (AudioFileType* outPropertyData = array)
			{
				if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.ReadableTypes, 0u, IntPtr.Zero, ref outDataSize, outPropertyData) != 0)
				{
					return null;
				}
				return array;
			}
		}
	}

	public unsafe static AudioFileType[] WritableTypes
	{
		get
		{
			if (AudioFileGetGlobalInfoSize(AudioFileGlobalProperty.WritableTypes, 0u, IntPtr.Zero, out var outDataSize) != 0)
			{
				return null;
			}
			AudioFileType[] array = new AudioFileType[outDataSize / 4u];
			fixed (AudioFileType* outPropertyData = array)
			{
				if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.WritableTypes, 0u, IntPtr.Zero, ref outDataSize, outPropertyData) != 0)
				{
					return null;
				}
				return array;
			}
		}
	}

	public unsafe static string[] AllExtensions
	{
		get
		{
			uint ioDataSize = (uint)sizeof(IntPtr);
			if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.AllExtensions, 0u, IntPtr.Zero, ref ioDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
		}
	}

	public unsafe static string[] AllUTIs
	{
		get
		{
			uint ioDataSize = (uint)sizeof(IntPtr);
			if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.AllUTIs, 0u, IntPtr.Zero, ref ioDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
		}
	}

	public unsafe static string[] AllMIMETypes
	{
		get
		{
			uint ioDataSize = (uint)sizeof(IntPtr);
			if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.AllMIMETypes, 0u, IntPtr.Zero, ref ioDataSize, out IntPtr outPropertyData) != 0)
			{
				return null;
			}
			return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
		}
	}

	public unsafe static string GetFileTypeName(AudioFileType fileType)
	{
		uint ioDataSize = (uint)sizeof(IntPtr);
		if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.FileTypeName, 4u, ref fileType, ref ioDataSize, out var outPropertyData) != 0)
		{
			return null;
		}
		return CFString.FetchString(outPropertyData);
	}

	public unsafe static AudioFormatType[] GetAvailableFormats(AudioFileType fileType)
	{
		if (AudioFileGetGlobalInfoSize(AudioFileGlobalProperty.AvailableFormatIDs, 4u, ref fileType, out var outDataSize) != 0)
		{
			return null;
		}
		AudioFormatType[] array = new AudioFormatType[outDataSize / 4u];
		fixed (AudioFormatType* outPropertyData = array)
		{
			if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.AvailableFormatIDs, 4u, ref fileType, ref outDataSize, outPropertyData) != 0)
			{
				return null;
			}
			return array;
		}
	}

	public unsafe static AudioStreamBasicDescription[] GetAvailableStreamDescriptions(AudioFileType fileType, AudioFormatType formatType)
	{
		AudioFileTypeAndFormatID inSpecifier = default(AudioFileTypeAndFormatID);
		inSpecifier.FileType = fileType;
		inSpecifier.FormatType = formatType;
		if (AudioFileGetGlobalInfoSize(AudioFileGlobalProperty.AvailableStreamDescriptionsForFormat, (uint)sizeof(AudioFileTypeAndFormatID), ref inSpecifier, out var outDataSize) != 0)
		{
			return null;
		}
		AudioStreamBasicDescription[] array = new AudioStreamBasicDescription[(long)outDataSize / (long)sizeof(AudioStreamBasicDescription)];
		fixed (AudioStreamBasicDescription* outPropertyData = array)
		{
			if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.AvailableStreamDescriptionsForFormat, (uint)sizeof(AudioFileTypeAndFormatID), ref inSpecifier, ref outDataSize, outPropertyData) != 0)
			{
				return null;
			}
			return array;
		}
	}

	public unsafe static string[] GetExtensions(AudioFileType fileType)
	{
		uint ioDataSize = (uint)sizeof(IntPtr);
		if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.ExtensionsForType, 4u, ref fileType, ref ioDataSize, out var outPropertyData) != 0)
		{
			return null;
		}
		return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
	}

	public unsafe static string[] GetUTIs(AudioFileType fileType)
	{
		uint ioDataSize = (uint)sizeof(IntPtr);
		if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.UTIsForType, 4u, ref fileType, ref ioDataSize, out var outPropertyData) != 0)
		{
			return null;
		}
		return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
	}

	public unsafe static string[] GetMIMETypes(AudioFileType fileType)
	{
		uint ioDataSize = (uint)sizeof(IntPtr);
		if (AudioFileGetGlobalInfo(AudioFileGlobalProperty.MIMETypesForType, 4u, ref fileType, ref ioDataSize, out var outPropertyData) != 0)
		{
			return null;
		}
		return NSArray.ArrayFromHandleFunc(outPropertyData, (IntPtr l) => CFString.FetchString(l));
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfoSize(AudioFileGlobalProperty propertyID, uint size, IntPtr inSpecifier, out uint outDataSize);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfoSize(AudioFileGlobalProperty propertyID, uint size, ref AudioFileType inSpecifier, out uint outDataSize);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfoSize(AudioFileGlobalProperty propertyID, uint size, ref AudioFileTypeAndFormatID inSpecifier, out uint outDataSize);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, IntPtr inSpecifier, ref uint ioDataSize, AudioFileType* outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, ref AudioFileType inSpecifier, ref uint ioDataSize, AudioFormatType* outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private unsafe static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, ref AudioFileTypeAndFormatID inSpecifier, ref uint ioDataSize, AudioStreamBasicDescription* outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, ref AudioFileType inSpecifier, ref uint ioDataSize, out IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, IntPtr inSpecifier, ref uint ioDataSize, out IntPtr outPropertyData);

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioFileGetGlobalInfo(AudioFileGlobalProperty propertyID, uint size, IntPtr inSpecifier, ref uint ioDataSize, out uint outPropertyData);
}
