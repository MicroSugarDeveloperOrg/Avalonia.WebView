using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontTraits
{
	internal const int ClassMaskShift = 28;

	internal const uint StylisticClassMask = 4026531840u;

	public NSDictionary Dictionary { get; private set; }

	public uint? Symbolic
	{
		get
		{
			return Adapter.GetUInt32Value(Dictionary, CTFontTraitKey.Symbolic);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontTraitKey.Symbolic, value);
		}
	}

	public CTFontSymbolicTraits? SymbolicTraits
	{
		get
		{
			uint? symbolic = Symbolic;
			if (symbolic.HasValue)
			{
				return (CTFontSymbolicTraits)(symbolic.Value & 0xFFFFFFFu);
			}
			return null;
		}
		set
		{
			CTFontStylisticClass? stylisticClass = StylisticClass;
			Symbolic = Adapter.BitwiseOr(stylisticClass.HasValue ? new uint?((uint)stylisticClass.Value) : null, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public CTFontStylisticClass? StylisticClass
	{
		get
		{
			uint? symbolic = Symbolic;
			if (symbolic.HasValue)
			{
				return (CTFontStylisticClass)(symbolic.Value & 0xF0000000u);
			}
			return null;
		}
		set
		{
			CTFontSymbolicTraits? symbolicTraits = SymbolicTraits;
			Symbolic = Adapter.BitwiseOr(symbolicTraits.HasValue ? new uint?((uint)symbolicTraits.Value) : null, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public float? Weight
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontTraitKey.Weight);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontTraitKey.Weight, value);
		}
	}

	public float? Width
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontTraitKey.Width);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontTraitKey.Width, value);
		}
	}

	public float? Slant
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontTraitKey.Slant);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontTraitKey.Slant, value);
		}
	}

	public CTFontTraits()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontTraits(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
