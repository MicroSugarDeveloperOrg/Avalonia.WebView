using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using Foundation;
using ObjCRuntime;

namespace MediaAccessibility;

[iOS(7, 0)]
[Mac(10, 9)]
public static class MACaptionAppearance
{
	public static readonly NSString SettingsChangedNotification;

	[Advice("Use 'MediaCharacteristic.DescribesMusicAndSoundForAccessibility' getter.")]
	public static readonly NSString MediaCharacteristicDescribesMusicAndSoundForAccessibility;

	[Advice("Use 'MediaCharacteristic.TranscribesSpokenDialogForAccessibility' getter.")]
	public static readonly NSString MediaCharacteristicTranscribesSpokenDialogForAccessibility;

	static MACaptionAppearance()
	{
		IntPtr handle = Libraries.MediaAccessibility.Handle;
		SettingsChangedNotification = Dlfcn.GetStringConstant(handle, "kMACaptionAppearanceSettingsChangedNotification");
		MediaCharacteristicDescribesMusicAndSoundForAccessibility = Dlfcn.GetStringConstant(handle, "MAMediaCharacteristicDescribesMusicAndSoundForAccessibility");
		MediaCharacteristicTranscribesSpokenDialogForAccessibility = Dlfcn.GetStringConstant(handle, "MAMediaCharacteristicTranscribesSpokenDialogForAccessibility");
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern bool MACaptionAppearanceAddSelectedLanguage(nint domain, IntPtr language);

	public static bool AddSelectedLanguage(MACaptionAppearanceDomain domain, string language)
	{
		using CFString cFString = new CFString(language);
		return MACaptionAppearanceAddSelectedLanguage((int)domain, cFString.Handle);
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopySelectedLanguages(nint domain);

	public static string[] GetSelectedLanguages(MACaptionAppearanceDomain domain)
	{
		using CFArray cFArray = new CFArray(MACaptionAppearanceCopySelectedLanguages((int)domain), owns: true);
		string[] array = new string[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = CFString.FetchString(cFArray.GetValue(i));
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nint MACaptionAppearanceGetDisplayType(nint domain);

	public static MACaptionAppearanceDisplayType GetDisplayType(MACaptionAppearanceDomain domain)
	{
		return (MACaptionAppearanceDisplayType)(int)MACaptionAppearanceGetDisplayType((int)domain);
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern void MACaptionAppearanceSetDisplayType(nint domain, nint displayType);

	public static void SetDisplayType(MACaptionAppearanceDomain domain, MACaptionAppearanceDisplayType displayType)
	{
		MACaptionAppearanceSetDisplayType((int)domain, (int)displayType);
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopyPreferredCaptioningMediaCharacteristics(nint domain);

	public static NSString[] GetPreferredCaptioningMediaCharacteristics(MACaptionAppearanceDomain domain)
	{
		using CFArray cFArray = new CFArray(MACaptionAppearanceCopyPreferredCaptioningMediaCharacteristics((int)domain), owns: true);
		NSString[] array = new NSString[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new NSString(cFArray.GetValue(i));
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopyForegroundColor(nint domain, ref nint behavior);

	public static CGColor GetForegroundColor(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		CGColor result = new CGColor(MACaptionAppearanceCopyForegroundColor((int)domain, ref behavior2), owns: true);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopyBackgroundColor(nint domain, ref nint behavior);

	public static CGColor GetBackgroundColor(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		CGColor result = new CGColor(MACaptionAppearanceCopyBackgroundColor((int)domain, ref behavior2), owns: true);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopyWindowColor(nint domain, ref nint behavior);

	public static CGColor GetWindowColor(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		CGColor result = new CGColor(MACaptionAppearanceCopyWindowColor((int)domain, ref behavior2), owns: true);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nfloat MACaptionAppearanceGetForegroundOpacity(nint domain, ref nint behavior);

	public static nfloat GetForegroundOpacity(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nfloat result = MACaptionAppearanceGetForegroundOpacity((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nfloat MACaptionAppearanceGetBackgroundOpacity(nint domain, ref nint behavior);

	public static nfloat GetBackgroundOpacity(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nfloat result = MACaptionAppearanceGetBackgroundOpacity((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nfloat MACaptionAppearanceGetWindowOpacity(nint domain, ref nint behavior);

	public static nfloat GetWindowOpacity(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nfloat result = MACaptionAppearanceGetWindowOpacity((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nfloat MACaptionAppearanceGetWindowRoundedCornerRadius(nint domain, ref nint behavior);

	public static nfloat GetWindowRoundedCornerRadius(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nfloat result = MACaptionAppearanceGetWindowRoundedCornerRadius((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern IntPtr MACaptionAppearanceCopyFontDescriptorForStyle(nint domain, ref nint behavior, nint fontStyle);

	public static CTFontDescriptor GetFontDescriptor(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior, MACaptionAppearanceFontStyle fontStyle)
	{
		nint behavior2 = (int)behavior;
		CTFontDescriptor result = new CTFontDescriptor(MACaptionAppearanceCopyFontDescriptorForStyle((int)domain, ref behavior2, (int)fontStyle), owns: true);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nfloat MACaptionAppearanceGetRelativeCharacterSize(nint domain, ref nint behavior);

	public static nfloat GetRelativeCharacterSize(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nfloat result = MACaptionAppearanceGetRelativeCharacterSize((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return result;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	private static extern nint MACaptionAppearanceGetTextEdgeStyle(nint domain, ref nint behavior);

	public static MACaptionAppearanceTextEdgeStyle GetTextEdgeStyle(MACaptionAppearanceDomain domain, ref MACaptionAppearanceBehavior behavior)
	{
		nint behavior2 = (int)behavior;
		nint nint = MACaptionAppearanceGetTextEdgeStyle((int)domain, ref behavior2);
		behavior = (MACaptionAppearanceBehavior)(int)behavior2;
		return (MACaptionAppearanceTextEdgeStyle)(int)nint;
	}

	[DllImport("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void MACaptionAppearanceDidDisplayCaptions(IntPtr strings);

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static void DidDisplayCaptions(string[] strings)
	{
		if (strings == null || strings.Length == 0)
		{
			MACaptionAppearanceDidDisplayCaptions(IntPtr.Zero);
			return;
		}
		using NSArray nSArray = NSArray.FromStrings(strings);
		MACaptionAppearanceDidDisplayCaptions(nSArray.Handle);
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static void DidDisplayCaptions(NSAttributedString[] strings)
	{
		if (strings == null || strings.Length == 0)
		{
			MACaptionAppearanceDidDisplayCaptions(IntPtr.Zero);
			return;
		}
		using NSArray nSArray = NSArray.FromNSObjects(strings);
		MACaptionAppearanceDidDisplayCaptions(nSArray.Handle);
	}
}
