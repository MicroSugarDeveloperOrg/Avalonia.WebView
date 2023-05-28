using System;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

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
			return (value == IntPtr.Zero) ? null : new CTFont(value, owns: false);
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
			return (!int32Value.HasValue) ? null : new CTLigatureFormation?((CTLigatureFormation)int32Value.Value);
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
			return (value == IntPtr.Zero) ? null : new CGColor(value);
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.ForegroundColor, value);
		}
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	public CGColor BackgroundColor
	{
		get
		{
			IntPtr intPtr = IntPtr.Zero;
			NSString backgroundColor = CTStringAttributeKey.BackgroundColor;
			if (backgroundColor != null)
			{
				intPtr = CFDictionary.GetValue(Dictionary.Handle, backgroundColor.Handle);
			}
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		set
		{
			NSString backgroundColor = CTStringAttributeKey.BackgroundColor;
			if (backgroundColor != null)
			{
				Adapter.SetNativeValue(Dictionary, backgroundColor, value);
			}
		}
	}

	public CTParagraphStyle ParagraphStyle
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.ParagraphStyle.Handle);
			return (value == IntPtr.Zero) ? null : new CTParagraphStyle(value, owns: false);
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
			return (value == IntPtr.Zero) ? null : new CGColor(value);
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.StrokeColor, value);
		}
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public float? TrackingAdjustment
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTStringAttributeKey.TrackingAttributeName);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.TrackingAttributeName, value);
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
			return (!underlineStyleValue.HasValue) ? null : new CTUnderlineStyle?((CTUnderlineStyle)(underlineStyleValue.Value & 0xF));
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
			return (!underlineStyleValue.HasValue) ? null : new CTUnderlineStyleModifiers?((CTUnderlineStyleModifiers)(underlineStyleValue.Value & 0x700));
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
			return (!int32Value.HasValue) ? null : new CTSuperscriptStyle?((CTSuperscriptStyle)int32Value.Value);
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
			return (value == IntPtr.Zero) ? null : new CGColor(value);
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

	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	public int? HorizontalInVerticalForms
	{
		get
		{
			NSString horizontalInVerticalForms = CTStringAttributeKey.HorizontalInVerticalForms;
			return (horizontalInVerticalForms != null) ? Adapter.GetInt32Value(Dictionary, horizontalInVerticalForms) : null;
		}
		set
		{
			NSString horizontalInVerticalForms = CTStringAttributeKey.HorizontalInVerticalForms;
			if (horizontalInVerticalForms != null)
			{
				Adapter.SetValue(Dictionary, horizontalInVerticalForms, value);
			}
		}
	}

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[Watch(4, 0)]
	public float? BaselineOffset
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTStringAttributeKey.BaselineOffset);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTStringAttributeKey.BaselineOffset, value);
		}
	}

	public CTGlyphInfo GlyphInfo
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.GlyphInfo.Handle);
			return (value == IntPtr.Zero) ? null : new CTGlyphInfo(value, owns: false);
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
			return (value == IntPtr.Zero) ? null : new CTRunDelegate(value, owns: false);
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTStringAttributeKey.RunDelegate, value);
		}
	}

	public CTBaselineClass? BaselineClass
	{
		get
		{
			IntPtr value = CFDictionary.GetValue(Dictionary.Handle, CTStringAttributeKey.BaselineClass.Handle);
			return (value == IntPtr.Zero) ? null : new CTBaselineClass?(CTBaselineClassID.FromHandle(value));
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

	public void SetBaselineInfo(CTBaselineClass baselineClass, double offset)
	{
		SetBaseline(baselineClass, offset, CTStringAttributeKey.BaselineInfo);
	}

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
