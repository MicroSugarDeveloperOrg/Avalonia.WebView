using System;
using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NLTagSchemeExtensions
{
	private static IntPtr[] values = new IntPtr[8];

	[Field("NLTagSchemeTokenType", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeTokenType
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeTokenType", storage);
			}
		}
	}

	[Field("NLTagSchemeLexicalClass", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeLexicalClass
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeLexicalClass", storage);
			}
		}
	}

	[Field("NLTagSchemeNameType", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeNameType
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeNameType", storage);
			}
		}
	}

	[Field("NLTagSchemeNameTypeOrLexicalClass", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeNameTypeOrLexicalClass
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeNameTypeOrLexicalClass", storage);
			}
		}
	}

	[Field("NLTagSchemeLemma", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeLemma
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeLemma", storage);
			}
		}
	}

	[Field("NLTagSchemeLanguage", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeLanguage
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeLanguage", storage);
			}
		}
	}

	[Field("NLTagSchemeScript", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeScript
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeScript", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Field("NLTagSchemeSentimentScore", "NaturalLanguage")]
	internal unsafe static IntPtr NLTagSchemeSentimentScore
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.NaturalLanguage.Handle, "NLTagSchemeSentimentScore", storage);
			}
		}
	}

	public static NSString? GetConstant(this NLTagScheme self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NLTagSchemeTokenType;
			break;
		case 1:
			ptr = NLTagSchemeLexicalClass;
			break;
		case 2:
			ptr = NLTagSchemeNameType;
			break;
		case 3:
			ptr = NLTagSchemeNameTypeOrLexicalClass;
			break;
		case 4:
			ptr = NLTagSchemeLemma;
			break;
		case 5:
			ptr = NLTagSchemeLanguage;
			break;
		case 6:
			ptr = NLTagSchemeScript;
			break;
		case 7:
			ptr = NLTagSchemeSentimentScore;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NLTagScheme GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NLTagSchemeTokenType))
		{
			return NLTagScheme.TokenType;
		}
		if (constant.IsEqualTo(NLTagSchemeLexicalClass))
		{
			return NLTagScheme.LexicalClass;
		}
		if (constant.IsEqualTo(NLTagSchemeNameType))
		{
			return NLTagScheme.NameType;
		}
		if (constant.IsEqualTo(NLTagSchemeNameTypeOrLexicalClass))
		{
			return NLTagScheme.NameTypeOrLexicalClass;
		}
		if (constant.IsEqualTo(NLTagSchemeLemma))
		{
			return NLTagScheme.Lemma;
		}
		if (constant.IsEqualTo(NLTagSchemeLanguage))
		{
			return NLTagScheme.Language;
		}
		if (constant.IsEqualTo(NLTagSchemeScript))
		{
			return NLTagScheme.Script;
		}
		if (constant.IsEqualTo(NLTagSchemeSentimentScore))
		{
			return NLTagScheme.SentimentScore;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
