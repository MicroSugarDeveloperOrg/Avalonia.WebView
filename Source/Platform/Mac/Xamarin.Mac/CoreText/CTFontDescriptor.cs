using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontDescriptor : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	internal CTFontDescriptor(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal CTFontDescriptor(IntPtr handle, bool owns)
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

	~CTFontDescriptor()
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
	private static extern IntPtr CTFontDescriptorCreateWithNameAndSize(IntPtr name, double size);

	public CTFontDescriptor(string name, double size)
	{
		if (name == null)
		{
			throw ConstructorError.ArgumentNull(this, "name");
		}
		using (CFString cFString = (CFString)name)
		{
			handle = CTFontDescriptorCreateWithNameAndSize(cFString.Handle, size);
		}
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateWithAttributes(IntPtr attributes);

	public CTFontDescriptor(CTFontDescriptorAttributes attributes)
	{
		if (attributes == null)
		{
			throw ConstructorError.ArgumentNull(this, "attributes");
		}
		handle = CTFontDescriptorCreateWithAttributes(attributes.Dictionary.Handle);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateCopyWithAttributes(IntPtr original, IntPtr attributes);

	public CTFontDescriptor WithAttributes(NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return CreateDescriptor(CTFontDescriptorCreateCopyWithAttributes(handle, attributes.Handle));
	}

	private static CTFontDescriptor CreateDescriptor(IntPtr h)
	{
		if (h == IntPtr.Zero)
		{
			return null;
		}
		return new CTFontDescriptor(h, owns: true);
	}

	public CTFontDescriptor WithAttributes(CTFontDescriptorAttributes attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return CreateDescriptor(CTFontDescriptorCreateCopyWithAttributes(handle, attributes.Dictionary.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateCopyWithVariation(IntPtr original, IntPtr variationIdentifier, double variationValue);

	public CTFontDescriptor WithVariation(uint variationIdentifier, double variationValue)
	{
		using NSNumber nSNumber = new NSNumber(variationIdentifier);
		return CreateDescriptor(CTFontDescriptorCreateCopyWithVariation(handle, nSNumber.Handle, variationValue));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateCopyWithFeature(IntPtr original, IntPtr featureTypeIdentifier, IntPtr featureSelectorIdentifier);

	[Advice("Use WithFeature with specific selector")]
	public CTFontDescriptor WithFeature(NSNumber featureTypeIdentifier, NSNumber featureSelectorIdentifier)
	{
		if (featureTypeIdentifier == null)
		{
			throw new ArgumentNullException("featureTypeIdentifier");
		}
		if (featureSelectorIdentifier == null)
		{
			throw new ArgumentNullException("featureSelectorIdentifier");
		}
		return CreateDescriptor(CTFontDescriptorCreateCopyWithFeature(handle, featureTypeIdentifier.Handle, featureSelectorIdentifier.Handle));
	}

	public CTFontDescriptor WithFeature(CTFontFeatureAllTypographicFeatures.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.AllTypographicFeatures, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureLigatures.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.Ligatures, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCursiveConnection.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CursiveConnection, (int)featureSelector);
	}

	[Obsolete("Deprecated")]
	public CTFontDescriptor WithFeature(CTFontFeatureLetterCase.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.LetterCase, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureVerticalSubstitutionConnection.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.VerticalSubstitution, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureLinguisticRearrangementConnection.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.LinguisticRearrangement, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureNumberSpacing.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.NumberSpacing, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureSmartSwash.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.SmartSwash, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureDiacritics.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.Diacritics, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureVerticalPosition.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.VerticalPosition, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureFractions.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.Fractions, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureOverlappingCharacters.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.OverlappingCharacters, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureTypographicExtras.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.TypographicExtras, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureMathematicalExtras.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.MathematicalExtras, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureOrnamentSets.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.OrnamentSets, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCharacterAlternatives.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CharacterAlternatives, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureDesignComplexity.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.DesignComplexity, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureStyleOptions.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.StyleOptions, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCharacterShape.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CharacterShape, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureNumberCase.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.NumberCase, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureTextSpacing.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.TextSpacing, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureTransliteration.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.Transliteration, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureAnnotation.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.Annotation, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureKanaSpacing.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.KanaSpacing, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureIdeographicSpacing.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.IdeographicSpacing, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureUnicodeDecomposition.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.UnicodeDecomposition, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureRubyKana.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.RubyKana, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCJKSymbolAlternatives.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CJKSymbolAlternatives, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureIdeographicAlternatives.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.IdeographicAlternatives, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCJKVerticalRomanPlacement.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CJKVerticalRomanPlacement, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureItalicCJKRoman.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.ItalicCJKRoman, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCaseSensitiveLayout.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CaseSensitiveLayout, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureAlternateKana.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.AlternateKana, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureStylisticAlternatives.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.StylisticAlternatives, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureContextualAlternates.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.ContextualAlternates, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureLowerCase.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.LowerCase, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureUpperCase.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.UpperCase, (int)featureSelector);
	}

	public CTFontDescriptor WithFeature(CTFontFeatureCJKRomanSpacing.Selector featureSelector)
	{
		return WithFeature(FontFeatureGroup.CJKRomanSpacing, (int)featureSelector);
	}

	private CTFontDescriptor WithFeature(FontFeatureGroup featureGroup, int featureSelector)
	{
		using NSNumber nSNumber = new NSNumber((int)featureGroup);
		using NSNumber nSNumber2 = new NSNumber(featureSelector);
		return CreateDescriptor(CTFontDescriptorCreateCopyWithFeature(handle, nSNumber.Handle, nSNumber2.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateMatchingFontDescriptors(IntPtr descriptor, IntPtr mandatoryAttributes);

	public CTFontDescriptor[] GetMatchingFontDescriptors(NSSet mandatoryAttributes)
	{
		IntPtr cfArrayRef = CTFontDescriptorCreateMatchingFontDescriptors(handle, mandatoryAttributes?.Handle ?? IntPtr.Zero);
		if (cfArrayRef == IntPtr.Zero)
		{
			return new CTFontDescriptor[0];
		}
		CTFontDescriptor[] result = NSArray.ArrayFromHandle(cfArrayRef, (IntPtr fd) => new CTFontDescriptor(cfArrayRef, owns: false));
		CFObject.CFRelease(cfArrayRef);
		return result;
	}

	public CTFontDescriptor[] GetMatchingFontDescriptors(params NSString[] mandatoryAttributes)
	{
		NSSet mandatoryAttributes2 = NSSet.MakeNSObjectSet(mandatoryAttributes);
		return GetMatchingFontDescriptors(mandatoryAttributes2);
	}

	public CTFontDescriptor[] GetMatchingFontDescriptors()
	{
		NSSet mandatoryAttributes = null;
		return GetMatchingFontDescriptors(mandatoryAttributes);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCreateMatchingFontDescriptor(IntPtr descriptor, IntPtr mandatoryAttributes);

	public CTFontDescriptor GetMatchingFontDescriptor(NSSet mandatoryAttributes)
	{
		return CreateDescriptor(CTFontDescriptorCreateMatchingFontDescriptors(handle, mandatoryAttributes?.Handle ?? IntPtr.Zero));
	}

	public CTFontDescriptor GetMatchingFontDescriptor(params NSString[] mandatoryAttributes)
	{
		NSSet mandatoryAttributes2 = NSSet.MakeNSObjectSet(mandatoryAttributes);
		return GetMatchingFontDescriptor(mandatoryAttributes2);
	}

	public CTFontDescriptor GetMatchingFontDescriptor()
	{
		NSSet mandatoryAttributes = null;
		return GetMatchingFontDescriptor(mandatoryAttributes);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCopyAttributes(IntPtr descriptor);

	public CTFontDescriptorAttributes GetAttributes()
	{
		IntPtr intPtr = CTFontDescriptorCopyAttributes(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary obj = (NSDictionary)Runtime.GetNSObject(intPtr);
		obj.Release();
		return new CTFontDescriptorAttributes(obj);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCopyAttribute(IntPtr descriptor, IntPtr attribute);

	public NSObject GetAttribute(NSString attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		return Runtime.GetNSObject(CTFontDescriptorCopyAttribute(handle, attribute.Handle));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCopyLocalizedAttribute(IntPtr descriptor, IntPtr attribute, IntPtr language);

	public NSObject GetLocalizedAttribute(NSString attribute)
	{
		return Runtime.GetNSObject(CTFontDescriptorCopyLocalizedAttribute(handle, attribute.Handle, IntPtr.Zero));
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontDescriptorCopyLocalizedAttribute(IntPtr descriptor, IntPtr attribute, out IntPtr language);

	public NSObject GetLocalizedAttribute(NSString attribute, out NSString language)
	{
		IntPtr language2;
		NSObject nSObject = Runtime.GetNSObject(CTFontDescriptorCopyLocalizedAttribute(handle, attribute.Handle, out language2));
		language = (NSString)Runtime.GetNSObject(language2);
		if (language2 != IntPtr.Zero)
		{
			CFObject.CFRelease(language2);
		}
		return nSObject;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontDescriptorMatchFontDescriptorsWithProgressHandler(IntPtr descriptors, IntPtr mandatoryAttributes, Func<CTFontDescriptorMatchingState, IntPtr, bool> progressHandler);

	[Since(6, 0)]
	public static bool MatchFontDescriptors(CTFontDescriptor[] descriptors, NSSet mandatoryAttributes, Func<CTFontDescriptorMatchingState, IntPtr, bool> progressHandler)
	{
		IntPtr mandatoryAttributes2 = mandatoryAttributes?.Handle ?? IntPtr.Zero;
		using CFArray cFArray = CFArray.FromNativeObjects(descriptors);
		return CTFontDescriptorMatchFontDescriptorsWithProgressHandler(cFArray.Handle, mandatoryAttributes2, progressHandler);
	}
}
