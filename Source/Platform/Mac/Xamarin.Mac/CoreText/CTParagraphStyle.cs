using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTParagraphStyle : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CTTextAlignment Alignment => (CTTextAlignment)GetByteValue(CTParagraphStyleSpecifier.Alignment);

	public CTLineBreakMode LineBreakMode => (CTLineBreakMode)GetByteValue(CTParagraphStyleSpecifier.Alignment);

	public CTWritingDirection BaseWritingDirection => (CTWritingDirection)GetByteValue(CTParagraphStyleSpecifier.Alignment);

	public float FirstLineHeadIndent => GetFloatValue(CTParagraphStyleSpecifier.FirstLineHeadIndent);

	public float HeadIndent => GetFloatValue(CTParagraphStyleSpecifier.HeadIndent);

	public float TailIndent => GetFloatValue(CTParagraphStyleSpecifier.TailIndent);

	public float DefaultTabInterval => GetFloatValue(CTParagraphStyleSpecifier.DefaultTabInterval);

	public float LineHeightMultiple => GetFloatValue(CTParagraphStyleSpecifier.LineHeightMultiple);

	public float MaximumLineHeight => GetFloatValue(CTParagraphStyleSpecifier.MaximumLineHeight);

	public float MinimumLineHeight => GetFloatValue(CTParagraphStyleSpecifier.MinimumLineHeight);

	public float LineSpacing => GetFloatValue(CTParagraphStyleSpecifier.LineSpacing);

	public float ParagraphSpacing => GetFloatValue(CTParagraphStyleSpecifier.ParagraphSpacing);

	public float ParagraphSpacingBefore => GetFloatValue(CTParagraphStyleSpecifier.ParagraphSpacingBefore);

	internal CTParagraphStyle(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.ArgumentNull(this, "handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTParagraphStyle()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTParagraphStyleCreate(CTParagraphStyleSetting[] settings, int settingCount);

	public CTParagraphStyle(CTParagraphStyleSettings settings)
	{
		handle = ((settings == null) ? CTParagraphStyleCreate(null, 0) : CreateFromSettings(settings));
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	private unsafe static IntPtr CreateFromSettings(CTParagraphStyleSettings s)
	{
		IntPtr zero = IntPtr.Zero;
		List<CTParagraphStyleSpecifierValue> specifiers = s.GetSpecifiers();
		CTParagraphStyleSetting[] array = new CTParagraphStyleSetting[specifiers.Count];
		CTParagraphStyleSettingValue[] array2 = new CTParagraphStyleSettingValue[specifiers.Count];
		int num = 0;
		foreach (CTParagraphStyleSpecifierValue item in specifiers)
		{
			item.WriteValue(array2, num);
			array[num].spec = item.Spec;
			array[num].valueSize = (uint)item.ValueSize;
			num++;
		}
		fixed (CTParagraphStyleSettingValue* ptr = array2)
		{
			for (num = 0; num < array.Length; num++)
			{
				byte* ptr2 = &ptr[num].int8;
				array[num].value = (IntPtr)ptr2;
			}
			zero = CTParagraphStyleCreate(array, array.Length);
		}
		num = 0;
		foreach (CTParagraphStyleSpecifierValue item2 in specifiers)
		{
			item2.Dispose(array2, num);
		}
		return zero;
	}

	public CTParagraphStyle()
		: this(null)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTParagraphStyleCreateCopy(IntPtr paragraphStyle);

	public CTParagraphStyle Clone()
	{
		return new CTParagraphStyle(CTParagraphStyleCreateCopy(handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private unsafe static extern bool CTParagraphStyleGetValueForSpecifier(IntPtr paragraphStyle, CTParagraphStyleSpecifier spec, uint valueBufferSize, void* valueBuffer);

	public unsafe CTTextTab[] GetTabStops()
	{
		IntPtr intPtr = default(IntPtr);
		if (!CTParagraphStyleGetValueForSpecifier(handle, CTParagraphStyleSpecifier.TabStops, (uint)IntPtr.Size, &intPtr))
		{
			throw new InvalidOperationException("Unable to get property value.");
		}
		if (intPtr == IntPtr.Zero)
		{
			return new CTTextTab[0];
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr p) => new CTTextTab(p, owns: false));
	}

	private unsafe byte GetByteValue(CTParagraphStyleSpecifier spec)
	{
		byte result = default(byte);
		if (!CTParagraphStyleGetValueForSpecifier(handle, spec, 1u, &result))
		{
			throw new InvalidOperationException("Unable to get property value.");
		}
		return result;
	}

	private unsafe float GetFloatValue(CTParagraphStyleSpecifier spec)
	{
		float result = default(float);
		if (!CTParagraphStyleGetValueForSpecifier(handle, spec, 4u, &result))
		{
			throw new InvalidOperationException("Unable to get property value.");
		}
		return result;
	}
}
