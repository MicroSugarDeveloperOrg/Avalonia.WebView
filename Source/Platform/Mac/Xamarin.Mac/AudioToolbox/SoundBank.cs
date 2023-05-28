using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace AudioToolbox;

public static class SoundBank
{
	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[iOS(7, 0)]
	private static extern int CopyNameFromSoundBank(IntPtr inURL, ref IntPtr outName);

	[iOS(7, 0)]
	public static string GetName(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		string text = null;
		IntPtr outName = IntPtr.Zero;
		int num = CopyNameFromSoundBank(url.Handle, ref outName);
		if (outName != IntPtr.Zero)
		{
			using NSString nSString = new NSString(outName);
			text = nSString.ToString();
		}
		return (num != 0) ? null : text;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern int CopyInstrumentInfoFromSoundBank(IntPtr inURL, ref IntPtr outInstrumentInfo);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public static InstrumentInfo[] GetInstrumentInfo(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		InstrumentInfo[] array = null;
		IntPtr outInstrumentInfo = IntPtr.Zero;
		int num = CopyInstrumentInfoFromSoundBank(url.Handle, ref outInstrumentInfo);
		if (outInstrumentInfo != IntPtr.Zero)
		{
			NSDictionary[] array2 = NSArray.ArrayFromHandle<NSDictionary>(outInstrumentInfo);
			array = new InstrumentInfo[array2.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array[i] = new InstrumentInfo(array2[i]);
			}
			CFObject.CFRelease(outInstrumentInfo);
		}
		return (num != 0) ? null : array;
	}
}
