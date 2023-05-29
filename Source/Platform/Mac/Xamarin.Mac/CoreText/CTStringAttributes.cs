using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTStringAttributes
{
	private const int UnderlineStyleMask = 15;

	private const int UnderlineStyleModifiersMask = 1792;

	public NSDictionary Dictionary { get; private set; }

	public CTFont Font
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.Font.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CTFont(value, owns: false);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.Font, value);
		}
	}

	public bool ForegroundColorFromContext
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTStringAttributeKey.ForegroundColorFromContext.Handle);
		}
		set
		{
			Adapter.AssertWritable(Dictionary);
			CFMutableDictionary.SetValue(Dictionary.Handle, CTStringAttributeKey.ForegroundColorFromContext.Handle, value);
		}
	}

	public float? KerningAdjustment
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTStringAttributeKey.KerningAdjustment);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.KerningAdjustment, value);
		}
	}

	public CTLigatureFormation? LigatureFormation
	{
		get
		{
			int? int32Value = Adapter.GetInt32Value(Dictionary, CTStringAttributeKey.LigatureFormation);
			if (int32Value.HasValue)
			{
				return (CTLigatureFormation)int32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.LigatureFormation, value.HasValue ? new int?((int)value.Value) : null);
		}
	}

	public CGColor ForegroundColor
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.ForegroundColor.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CGColor(value);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.ForegroundColor, value);
		}
	}

	public CTParagraphStyle ParagraphStyle
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.ParagraphStyle.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CTParagraphStyle(value, owns: false);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.ParagraphStyle, value);
		}
	}

	public float? StrokeWidth
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTStringAttributeKey.StrokeWidth);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.StrokeWidth, value);
		}
	}

	public CGColor StrokeColor
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.StrokeColor.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CGColor(value);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.StrokeColor, value);
		}
	}

	public int? UnderlineStyleValue
	{
		get
		{
			return Adapter.GetInt32Value(Dictionary, CTStringAttributeKey.UnderlineStyle);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.UnderlineStyle, value);
		}
	}

	public CTUnderlineStyle? UnderlineStyle
	{
		get
		{
			int? underlineStyleValue = UnderlineStyleValue;
			if (underlineStyleValue.HasValue)
			{
				return (CTUnderlineStyle)(underlineStyleValue.Value & 0xF);
			}
			return null;
		}
		set
		{
			CTUnderlineStyleModifiers? underlineStyleModifiers = UnderlineStyleModifiers;
			UnderlineStyleValue = Adapter.BitwiseOr(underlineStyleModifiers.HasValue ? new int?((int)underlineStyleModifiers.Value) : null, value.HasValue ? new int?((int)value.Value) : null);
		}
	}

	public CTUnderlineStyleModifiers? UnderlineStyleModifiers
	{
		get
		{
			int? underlineStyleValue = UnderlineStyleValue;
			if (underlineStyleValue.HasValue)
			{
				return (CTUnderlineStyleModifiers)(underlineStyleValue.Value & 0x700);
			}
			return null;
		}
		set
		{
			CTUnderlineStyleModifiers? underlineStyleModifiers = UnderlineStyleModifiers;
			UnderlineStyleValue = Adapter.BitwiseOr(underlineStyleModifiers.HasValue ? new int?((int)underlineStyleModifiers.Value) : null, value.HasValue ? new int?((int)value.Value) : null);
		}
	}

	public CTSuperscriptStyle? Superscript
	{
		get
		{
			int? int32Value = Adapter.GetInt32Value(Dictionary, CTStringAttributeKey.Superscript);
			if (int32Value.HasValue)
			{
				return (CTSuperscriptStyle)int32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.Superscript, value.HasValue ? new int?((int)value.Value) : null);
		}
	}

	public CGColor UnderlineColor
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.UnderlineColor.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CGColor(value);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.UnderlineColor, value);
		}
	}

	public bool VerticalForms
	{
		get
		{
			return CFDictionary.GetBooleanValue(Dictionary.Handle, CTStringAttributeKey.VerticalForms.Handle);
		}
		set
		{
			Adapter.AssertWritable(Dictionary);
			CFMutableDictionary.SetValue(Dictionary.Handle, CTStringAttributeKey.VerticalForms.Handle, value);
		}
	}

	public CTGlyphInfo GlyphInfo
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.GlyphInfo.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CTGlyphInfo(value, owns: false);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.GlyphInfo, value);
		}
	}

	public int? CharacterShape
	{
		get
		{
			return Adapter.GetInt32Value(Dictionary, CTStringAttributeKey.CharacterShape);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.CharacterShape, value);
		}
	}

	public CTRunDelegate RunDelegate
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.RunDelegate.Handle);
			if (!(value == IntPtr.Zero))
			{
				return new CTRunDelegate(value, owns: false);
			}
			return null;
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.RunDelegate, value);
		}
	}

	[Since(6, 0)]
	public CTBaselineClass? BaselineClass
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.BaselineClass.Handle);
			if (!(value == IntPtr.Zero))
			{
				return CTBaselineClassID.FromHandle(value);
			}
			return null;
		}
		set
		{
			NSString value2 = ((!value.HasValue) ? null : CTBaselineClassID.ToNSString(value.Value));
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.BaselineClass, value2);
		}
	}

	public CTStringAttributes()
		: this(new NSMutableDictionary())
	{
	}

	public CTStringAttributes(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}

	[Since(6, 0)]
	public void SetBaselineInfo(CTBaselineClass baselineClass, double offset)
	{
		SetBaseline(baselineClass, offset, CTStringAttributeKey.BaselineInfo);
	}

	[Since(6, 0)]
	public void SetBaselineReferenceInfo(CTBaselineClass baselineClass, double offset)
	{
		SetBaseline(baselineClass, offset, CTStringAttributeKey.BaselineReferenceInfo);
	}

	private void SetBaseline(CTBaselineClass baselineClass, double offset, NSString infoKey)
	{
		IntPtr value = CFDictionary.GetValue(Dictionary.Handle, infoKey.Handle);
		NSMutableDictionary nSMutableDictionary = ((value == IntPtr.Zero) ? new NSMutableDictionary() : new NSMutableDictionary(value));
		NSString key = CTBaselineClassID.ToNSString(baselineClass);
		Adapter.SetValue(nSMutableDictionary, key, new NSNumber(offset));
		if (value == IntPtr.Zero)
		{
			Adapter.SetNativeValue(Dictionary, (NSObject)infoKey, (INativeObject)nSMutableDictionary);
		}
	}

	[Since(6, 0)]
	public void SetWritingDirection(params CTWritingDirection[] writingDirections)
	{
		IntPtr[] array = new IntPtr[writingDirections.Length];
		for (int i = 0; i < writingDirections.Length; i++)
		{
			array[i] = new NSNumber((int)writingDirections[i]).Handle;
		}
		IntPtr value = CFArray.Create(array);
		CFMutableDictionary.SetValue(Dictionary.Handle, CTStringAttributeKey.WritingDirection.Handle, value);
	}
}
