using System;
using System.Collections.Generic;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTParagraphStyleSettings
{
	public IEnumerable<CTTextTab> TabStops { get; set; }

	public CTTextAlignment? Alignment { get; set; }

	public CTLineBreakMode? LineBreakMode { get; set; }

	public CTWritingDirection? BaseWritingDirection { get; set; }

	public float? FirstLineHeadIndent { get; set; }

	public float? HeadIndent { get; set; }

	public float? TailIndent { get; set; }

	public float? DefaultTabInterval { get; set; }

	public float? LineHeightMultiple { get; set; }

	public float? MaximumLineHeight { get; set; }

	public float? MinimumLineHeight { get; set; }

	public float? LineSpacing { get; set; }

	public float? ParagraphSpacing { get; set; }

	public float? ParagraphSpacingBefore { get; set; }

	public float? MaximumLineSpacing { get; set; }

	public float? MinimumLineSpacing { get; set; }

	public float? LineSpacingAdjustment { get; set; }

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

	private static CTParagraphStyleSpecifierValue CreateValue(CTParagraphStyleSpecifier spec, float value)
	{
		return new CTParagraphStyleSpecifierSingleValue(spec, value);
	}
}
