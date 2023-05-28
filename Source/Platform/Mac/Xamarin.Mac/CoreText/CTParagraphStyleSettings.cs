using System;
using System.Collections.Generic;

namespace CoreText;

public class CTParagraphStyleSettings
{
	public IEnumerable<CTTextTab> TabStops { get; set; }

	public CTTextAlignment? Alignment { get; set; }

	public CTLineBreakMode? LineBreakMode { get; set; }

	public CTWritingDirection? BaseWritingDirection { get; set; }

	public CTLineBoundsOptions? LineBoundsOptions { get; set; }

	public nfloat? FirstLineHeadIndent { get; set; }

	public nfloat? HeadIndent { get; set; }

	public nfloat? TailIndent { get; set; }

	public nfloat? DefaultTabInterval { get; set; }

	public nfloat? LineHeightMultiple { get; set; }

	public nfloat? MaximumLineHeight { get; set; }

	public nfloat? MinimumLineHeight { get; set; }

	public nfloat? LineSpacing { get; set; }

	public nfloat? ParagraphSpacing { get; set; }

	public nfloat? ParagraphSpacingBefore { get; set; }

	public nfloat? MaximumLineSpacing { get; set; }

	public nfloat? MinimumLineSpacing { get; set; }

	public nfloat? LineSpacingAdjustment { get; set; }

	internal List<CTParagraphStyleSpecifierValue> GetSpecifiers()
	{
		List<CTParagraphStyleSpecifierValue> list = new List<CTParagraphStyleSpecifierValue>();
		if (TabStops != null)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.TabStops, TabStops));
		}
		if (Alignment.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.Alignment, (byte)Alignment.Value));
		}
		if (LineBreakMode.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.LineBreakMode, (byte)LineBreakMode.Value));
		}
		if (BaseWritingDirection.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.BaseWritingDirection, (byte)BaseWritingDirection.Value));
		}
		if (LineBoundsOptions.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.LineBoundsOptions, (nuint)(ulong)LineBoundsOptions.Value));
		}
		if (FirstLineHeadIndent.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.FirstLineHeadIndent, FirstLineHeadIndent.Value));
		}
		if (HeadIndent.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.HeadIndent, HeadIndent.Value));
		}
		if (TailIndent.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.TailIndent, TailIndent.Value));
		}
		if (DefaultTabInterval.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.DefaultTabInterval, DefaultTabInterval.Value));
		}
		if (LineHeightMultiple.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.LineHeightMultiple, LineHeightMultiple.Value));
		}
		if (MaximumLineHeight.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.MaximumLineHeight, MaximumLineHeight.Value));
		}
		if (MinimumLineHeight.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.MinimumLineHeight, MinimumLineHeight.Value));
		}
		if (LineSpacing.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.LineSpacing, LineSpacing.Value));
		}
		if (ParagraphSpacing.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.ParagraphSpacing, ParagraphSpacing.Value));
		}
		if (ParagraphSpacingBefore.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.ParagraphSpacingBefore, ParagraphSpacingBefore.Value));
		}
		if (MaximumLineSpacing.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.MaximumLineSpacing, MaximumLineSpacing.Value));
		}
		if (MinimumLineSpacing.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.MinimumLineSpacing, MinimumLineSpacing.Value));
		}
		if (LineSpacingAdjustment.HasValue)
		{
			list.Add(CreateValue(CTParagraphStyleSpecifier.LineSpacingAdjustment, LineSpacingAdjustment.Value));
		}
		return list;
	}

	private static CTParagraphStyleSpecifierValue CreateValue(CTParagraphStyleSpecifier spec, IEnumerable<CTTextTab> value)
	{
		List<IntPtr> list = new List<IntPtr>();
		foreach (CTTextTab item in value)
		{
			list.Add(item.Handle);
		}
		return new CTParagraphStyleSpecifierIntPtrsValue(spec, list.ToArray());
	}

	private static CTParagraphStyleSpecifierValue CreateValue(CTParagraphStyleSpecifier spec, byte value)
	{
		return new CTParagraphStyleSpecifierByteValue(spec, value);
	}

	private static CTParagraphStyleSpecifierValue CreateValue(CTParagraphStyleSpecifier spec, nfloat value)
	{
		return new CTParagraphStyleSpecifierSingleValue(spec, value);
	}

	private static CTParagraphStyleSpecifierValue CreateValue(CTParagraphStyleSpecifier spec, nuint value)
	{
		return new CTParagraphStyleSpecifierNativeIntValue(spec, value);
	}
}
