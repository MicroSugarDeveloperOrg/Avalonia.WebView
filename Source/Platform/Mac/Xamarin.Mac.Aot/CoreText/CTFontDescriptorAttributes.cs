using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTFontDescriptorAttributes
{
	public NSDictionary Dictionary { get; private set; }

	public NSUrl Url
	{
		get
		{
			return (NSUrl)Dictionary[CTFontDescriptorAttributeKey.Url];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Url, value);
		}
	}

	public string Name
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontDescriptorAttributeKey.Name);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Name, value);
		}
	}

	public string DisplayName
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontDescriptorAttributeKey.DisplayName);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.DisplayName, value);
		}
	}

	public string FamilyName
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontDescriptorAttributeKey.FamilyName);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.FamilyName, value);
		}
	}

	public string StyleName
	{
		get
		{
			return Adapter.GetStringValue(Dictionary, CTFontDescriptorAttributeKey.StyleName);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.StyleName, value);
		}
	}

	public CTFontTraits Traits
	{
		get
		{
			NSDictionary nSDictionary = (NSDictionary)Dictionary[CTFontDescriptorAttributeKey.Traits];
			if (nSDictionary == null)
			{
				return null;
			}
			return new CTFontTraits(nSDictionary);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Traits, value?.Dictionary);
		}
	}

	public CTFontVariation Variation
	{
		get
		{
			NSDictionary nSDictionary = (NSDictionary)Dictionary[CTFontDescriptorAttributeKey.Variation];
			if (nSDictionary != null)
			{
				return new CTFontVariation(nSDictionary);
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Variation, value?.Dictionary);
		}
	}

	public float? Size
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontDescriptorAttributeKey.Size);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Size, value);
		}
	}

	public unsafe CGAffineTransform? Matrix
	{
		get
		{
			NSData nSData = (NSData)Dictionary[CTFontDescriptorAttributeKey.Matrix];
			if (nSData == null)
			{
				return null;
			}
			return (CGAffineTransform)Marshal.PtrToStructure(nSData.Bytes, typeof(CGAffineTransform));
		}
		set
		{
			if (!value.HasValue)
			{
				Adapter.SetValue((IDictionary<NSObject, NSObject>)Dictionary, (NSObject)CTFontDescriptorAttributeKey.Matrix, (NSObject)null);
				return;
			}
			byte[] array = new byte[Marshal.SizeOf(typeof(CGAffineTransform))];
			fixed (byte* ptr = array)
			{
				Marshal.StructureToPtr(value.Value, (IntPtr)ptr, fDeleteOld: false);
			}
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Matrix, NSData.FromArray(array));
		}
	}

	public IEnumerable<CTFontDescriptor> CascadeList
	{
		get
		{
			return Adapter.GetNativeArray(Dictionary, CTFontDescriptorAttributeKey.CascadeList, (IntPtr d) => new CTFontDescriptor(d, owns: false));
		}
		set
		{
			Adapter.SetNativeValue(Dictionary, CTFontDescriptorAttributeKey.CascadeList, value);
		}
	}

	public NSCharacterSet CharacterSet
	{
		get
		{
			return (NSCharacterSet)Dictionary[CTFontDescriptorAttributeKey.CharacterSet];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.CharacterSet, value);
		}
	}

	public IEnumerable<string> Languages
	{
		get
		{
			return Adapter.GetStringArray(Dictionary, CTFontDescriptorAttributeKey.Languages);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Languages, value);
		}
	}

	public float? BaselineAdjust
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontDescriptorAttributeKey.BaselineAdjust);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.BaselineAdjust, value);
		}
	}

	public float? MacintoshEncodings
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontDescriptorAttributeKey.MacintoshEncodings);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.MacintoshEncodings, value);
		}
	}

	public IEnumerable<CTFontFeatures> Features
	{
		get
		{
			return Adapter.GetNativeArray(Dictionary, CTFontDescriptorAttributeKey.Features, (IntPtr d) => new CTFontFeatures((NSDictionary)Runtime.GetNSObject(d)));
		}
		set
		{
			List<CTFontFeatures> source;
			if (value == null || (source = new List<CTFontFeatures>(value)).Count == 0)
			{
				Adapter.SetValue((IDictionary<NSObject, NSObject>)Dictionary, (NSObject)CTFontDescriptorAttributeKey.Features, (NSObject)null);
				return;
			}
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Features, NSArray.FromNSObjects(((IEnumerable<CTFontFeatures>)source).Select((Func<CTFontFeatures, NSObject>)((CTFontFeatures e) => e.Dictionary)).ToList()));
		}
	}

	public IEnumerable<CTFontFeatureSettings> FeatureSettings
	{
		get
		{
			return Adapter.GetNativeArray(Dictionary, CTFontDescriptorAttributeKey.Features, (IntPtr d) => new CTFontFeatureSettings((NSDictionary)Runtime.GetNSObject(d)));
		}
		set
		{
			List<CTFontFeatureSettings> source;
			if (value == null || (source = new List<CTFontFeatureSettings>(value)).Count == 0)
			{
				Adapter.SetValue((IDictionary<NSObject, NSObject>)Dictionary, (NSObject)CTFontDescriptorAttributeKey.Features, (NSObject)null);
				return;
			}
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.FeatureSettings, NSArray.FromNSObjects(((IEnumerable<CTFontFeatureSettings>)source).Select((Func<CTFontFeatureSettings, NSObject>)((CTFontFeatureSettings e) => e.Dictionary)).ToList()));
		}
	}

	public float? FixedAdvance
	{
		get
		{
			return Adapter.GetSingleValue(Dictionary, CTFontDescriptorAttributeKey.FixedAdvance);
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.FixedAdvance, value);
		}
	}

	public CTFontOrientation? FontOrientation
	{
		get
		{
			uint? uInt32Value = Adapter.GetUInt32Value(Dictionary, CTFontDescriptorAttributeKey.FontOrientation);
			if (uInt32Value.HasValue)
			{
				return (CTFontOrientation)uInt32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.FontOrientation, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public CTFontFormat? FontFormat
	{
		get
		{
			uint? uInt32Value = Adapter.GetUInt32Value(Dictionary, CTFontDescriptorAttributeKey.FontFormat);
			if (uInt32Value.HasValue)
			{
				return (CTFontFormat)uInt32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.FontFormat, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public NSNumber RegistrationScope
	{
		get
		{
			return (NSNumber)Dictionary[CTFontDescriptorAttributeKey.RegistrationScope];
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.RegistrationScope, value);
		}
	}

	public CTFontPriority? Priority
	{
		get
		{
			uint? uInt32Value = Adapter.GetUInt32Value(Dictionary, CTFontDescriptorAttributeKey.Priority);
			if (uInt32Value.HasValue)
			{
				return (CTFontPriority)uInt32Value.Value;
			}
			return null;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Priority, value.HasValue ? new uint?((uint)value.Value) : null);
		}
	}

	public bool Enabled
	{
		get
		{
			NSNumber nSNumber = (NSNumber)Dictionary[CTFontDescriptorAttributeKey.Enabled];
			if (nSNumber == null)
			{
				return false;
			}
			return nSNumber.Int32Value != 0;
		}
		set
		{
			Adapter.SetValue(Dictionary, CTFontDescriptorAttributeKey.Enabled, value ? new NSNumber(1) : null);
		}
	}

	public CTFontDescriptorAttributes()
		: this(new NSMutableDictionary())
	{
	}

	public CTFontDescriptorAttributes(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}
}
