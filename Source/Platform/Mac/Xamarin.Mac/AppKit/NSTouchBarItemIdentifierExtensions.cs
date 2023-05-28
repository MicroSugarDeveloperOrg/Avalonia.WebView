using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSTouchBarItemIdentifierExtensions
{
	private static IntPtr[] values = new IntPtr[11];

	[Field("NSTouchBarItemIdentifierFixedSpaceSmall", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierFixedSpaceSmall
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFixedSpaceSmall", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierFixedSpaceLarge", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierFixedSpaceLarge
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFixedSpaceLarge", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierFlexibleSpace", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierFlexibleSpace
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierFlexibleSpace", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierOtherItemsProxy", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierOtherItemsProxy
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierOtherItemsProxy", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierCharacterPicker", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierCharacterPicker
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierCharacterPicker", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierTextColorPicker", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierTextColorPicker
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierTextColorPicker", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierTextStyle", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierTextStyle
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierTextStyle", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierTextAlignment", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierTextAlignment
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierTextAlignment", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierTextList", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierTextList
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierTextList", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierTextFormat", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierTextFormat
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierTextFormat", storage);
			}
		}
	}

	[Field("NSTouchBarItemIdentifierCandidateList", "AppKit")]
	internal unsafe static IntPtr NSTouchBarItemIdentifierCandidateList
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSTouchBarItemIdentifierCandidateList", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSTouchBarItemIdentifier self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSTouchBarItemIdentifierFixedSpaceSmall;
			break;
		case 1:
			ptr = NSTouchBarItemIdentifierFixedSpaceLarge;
			break;
		case 2:
			ptr = NSTouchBarItemIdentifierFlexibleSpace;
			break;
		case 3:
			ptr = NSTouchBarItemIdentifierOtherItemsProxy;
			break;
		case 4:
			ptr = NSTouchBarItemIdentifierCharacterPicker;
			break;
		case 5:
			ptr = NSTouchBarItemIdentifierTextColorPicker;
			break;
		case 6:
			ptr = NSTouchBarItemIdentifierTextStyle;
			break;
		case 7:
			ptr = NSTouchBarItemIdentifierTextAlignment;
			break;
		case 8:
			ptr = NSTouchBarItemIdentifierTextList;
			break;
		case 9:
			ptr = NSTouchBarItemIdentifierTextFormat;
			break;
		case 10:
			ptr = NSTouchBarItemIdentifierCandidateList;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSTouchBarItemIdentifier GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierFixedSpaceSmall))
		{
			return NSTouchBarItemIdentifier.FixedSpaceSmall;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierFixedSpaceLarge))
		{
			return NSTouchBarItemIdentifier.FixedSpaceLarge;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierFlexibleSpace))
		{
			return NSTouchBarItemIdentifier.FlexibleSpace;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierOtherItemsProxy))
		{
			return NSTouchBarItemIdentifier.OtherItemsProxy;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierCharacterPicker))
		{
			return NSTouchBarItemIdentifier.CharacterPicker;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierTextColorPicker))
		{
			return NSTouchBarItemIdentifier.TextColorPicker;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierTextStyle))
		{
			return NSTouchBarItemIdentifier.TextStyle;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierTextAlignment))
		{
			return NSTouchBarItemIdentifier.TextAlignment;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierTextList))
		{
			return NSTouchBarItemIdentifier.TextList;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierTextFormat))
		{
			return NSTouchBarItemIdentifier.TextFormat;
		}
		if (constant.IsEqualTo(NSTouchBarItemIdentifierCandidateList))
		{
			return NSTouchBarItemIdentifier.CandidateList;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
