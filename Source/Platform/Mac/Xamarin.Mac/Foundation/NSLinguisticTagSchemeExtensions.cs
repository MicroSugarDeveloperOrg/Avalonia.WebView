using System;
using ObjCRuntime;

namespace Foundation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSLinguisticTagSchemeExtensions
{
	private static IntPtr[] values = new IntPtr[7];

	[Field("NSLinguisticTagSchemeTokenType", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeTokenType
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeTokenType", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeLexicalClass", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeLexicalClass
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLexicalClass", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeNameType", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeNameType
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameType", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeNameTypeOrLexicalClass", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeNameTypeOrLexicalClass
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameTypeOrLexicalClass", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeLemma", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeLemma
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLemma", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeLanguage", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeLanguage
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeLanguage", storage);
			}
		}
	}

	[Field("NSLinguisticTagSchemeScript", "Foundation")]
	internal unsafe static IntPtr NSLinguisticTagSchemeScript
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSLinguisticTagSchemeScript", storage);
			}
		}
	}

	public static NSString? GetConstant(this NSLinguisticTagScheme self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = NSLinguisticTagSchemeTokenType;
			break;
		case 1:
			ptr = NSLinguisticTagSchemeLexicalClass;
			break;
		case 2:
			ptr = NSLinguisticTagSchemeNameType;
			break;
		case 3:
			ptr = NSLinguisticTagSchemeNameTypeOrLexicalClass;
			break;
		case 4:
			ptr = NSLinguisticTagSchemeLemma;
			break;
		case 5:
			ptr = NSLinguisticTagSchemeLanguage;
			break;
		case 6:
			ptr = NSLinguisticTagSchemeScript;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static NSLinguisticTagScheme GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeTokenType))
		{
			return NSLinguisticTagScheme.Token;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeLexicalClass))
		{
			return NSLinguisticTagScheme.LexicalClass;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeNameType))
		{
			return NSLinguisticTagScheme.Name;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeNameTypeOrLexicalClass))
		{
			return NSLinguisticTagScheme.NameOrLexicalClass;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeLemma))
		{
			return NSLinguisticTagScheme.Lemma;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeLanguage))
		{
			return NSLinguisticTagScheme.Language;
		}
		if (constant.IsEqualTo(NSLinguisticTagSchemeScript))
		{
			return NSLinguisticTagScheme.Script;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
