using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
internal static class PdfDocumentAttributeKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreatorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeywordsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModificationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProducerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SubjectKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleKey;

	[Field("PDFDocumentAuthorAttribute", "Quartz")]
	public static NSString AuthorKey
	{
		get
		{
			if (_AuthorKey == null)
			{
				_AuthorKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentAuthorAttribute");
			}
			return _AuthorKey;
		}
	}

	[Field("PDFDocumentCreationDateAttribute", "Quartz")]
	public static NSString CreationDateKey
	{
		get
		{
			if (_CreationDateKey == null)
			{
				_CreationDateKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentCreationDateAttribute");
			}
			return _CreationDateKey;
		}
	}

	[Field("PDFDocumentCreatorAttribute", "Quartz")]
	public static NSString CreatorKey
	{
		get
		{
			if (_CreatorKey == null)
			{
				_CreatorKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentCreatorAttribute");
			}
			return _CreatorKey;
		}
	}

	[Field("PDFDocumentKeywordsAttribute", "Quartz")]
	public static NSString KeywordsKey
	{
		get
		{
			if (_KeywordsKey == null)
			{
				_KeywordsKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentKeywordsAttribute");
			}
			return _KeywordsKey;
		}
	}

	[Field("PDFDocumentModificationDateAttribute", "Quartz")]
	public static NSString ModificationDateKey
	{
		get
		{
			if (_ModificationDateKey == null)
			{
				_ModificationDateKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentModificationDateAttribute");
			}
			return _ModificationDateKey;
		}
	}

	[Field("PDFDocumentProducerAttribute", "Quartz")]
	public static NSString ProducerKey
	{
		get
		{
			if (_ProducerKey == null)
			{
				_ProducerKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentProducerAttribute");
			}
			return _ProducerKey;
		}
	}

	[Field("PDFDocumentSubjectAttribute", "Quartz")]
	public static NSString SubjectKey
	{
		get
		{
			if (_SubjectKey == null)
			{
				_SubjectKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentSubjectAttribute");
			}
			return _SubjectKey;
		}
	}

	[Field("PDFDocumentTitleAttribute", "Quartz")]
	public static NSString TitleKey
	{
		get
		{
			if (_TitleKey == null)
			{
				_TitleKey = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentTitleAttribute");
			}
			return _TitleKey;
		}
	}
}
