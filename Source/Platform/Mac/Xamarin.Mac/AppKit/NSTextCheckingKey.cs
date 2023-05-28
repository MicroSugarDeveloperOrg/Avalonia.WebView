using Foundation;
using ObjCRuntime;

namespace AppKit;

internal static class NSTextCheckingKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentAuthorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentTitleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentUrlKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OrthographyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuotesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceTimeZoneKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReplacementsKey;

	[Field("NSTextCheckingDocumentAuthorKey", "AppKit")]
	public static NSString DocumentAuthorKey
	{
		get
		{
			if (_DocumentAuthorKey == null)
			{
				_DocumentAuthorKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentAuthorKey");
			}
			return _DocumentAuthorKey;
		}
	}

	[Field("NSTextCheckingDocumentTitleKey", "AppKit")]
	public static NSString DocumentTitleKey
	{
		get
		{
			if (_DocumentTitleKey == null)
			{
				_DocumentTitleKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentTitleKey");
			}
			return _DocumentTitleKey;
		}
	}

	[Field("NSTextCheckingDocumentURLKey", "AppKit")]
	public static NSString DocumentUrlKey
	{
		get
		{
			if (_DocumentUrlKey == null)
			{
				_DocumentUrlKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentURLKey");
			}
			return _DocumentUrlKey;
		}
	}

	[Field("NSTextCheckingOrthographyKey", "AppKit")]
	public static NSString OrthographyKey
	{
		get
		{
			if (_OrthographyKey == null)
			{
				_OrthographyKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingOrthographyKey");
			}
			return _OrthographyKey;
		}
	}

	[Field("NSTextCheckingQuotesKey", "AppKit")]
	public static NSString QuotesKey
	{
		get
		{
			if (_QuotesKey == null)
			{
				_QuotesKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingQuotesKey");
			}
			return _QuotesKey;
		}
	}

	[Field("NSTextCheckingReferenceDateKey", "AppKit")]
	public static NSString ReferenceDateKey
	{
		get
		{
			if (_ReferenceDateKey == null)
			{
				_ReferenceDateKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReferenceDateKey");
			}
			return _ReferenceDateKey;
		}
	}

	[Field("NSTextCheckingReferenceTimeZoneKey", "AppKit")]
	public static NSString ReferenceTimeZoneKey
	{
		get
		{
			if (_ReferenceTimeZoneKey == null)
			{
				_ReferenceTimeZoneKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReferenceTimeZoneKey");
			}
			return _ReferenceTimeZoneKey;
		}
	}

	[Field("NSTextCheckingReplacementsKey", "AppKit")]
	public static NSString ReplacementsKey
	{
		get
		{
			if (_ReplacementsKey == null)
			{
				_ReplacementsKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReplacementsKey");
			}
			return _ReplacementsKey;
		}
	}
}
