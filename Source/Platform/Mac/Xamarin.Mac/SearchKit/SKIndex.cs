using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace SearchKit;

public class SKIndex : IDisposable, INativeObject
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	public nint DocumentCount => SKIndexGetDocumentCount(handle);

	public nint MaximumDocumentID => SKIndexGetMaximumDocumentID(handle);

	public nint MaximumTermID => SKIndexGetMaximumTermID(handle);

	public SKTextAnalysis AnalysisProperties => new SKTextAnalysis(Runtime.GetNSObject<NSDictionary>(SKIndexGetAnalysisProperties(handle)));

	[Advice("Apple recommends to use Flush instead of setting these parameters")]
	public nint MaximumBytesBeforeFlush
	{
		get
		{
			return SKIndexGetMaximumBytesBeforeFlush(handle);
		}
		set
		{
			SKIndexSetMaximumBytesBeforeFlush(handle, value);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexCreateWithURL(IntPtr url, IntPtr str, SKIndexType type, IntPtr dict);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexCreateWithMutableData(IntPtr url, IntPtr str, SKIndexType type, IntPtr dict);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexOpenWithURL(IntPtr url, IntPtr str, bool writeAccess);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexOpenWithMutableData(IntPtr mutableData, IntPtr str);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexOpenWithData(IntPtr mutableData, IntPtr str);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern void SKIndexClose(IntPtr handle);

	internal SKIndex(IntPtr handle)
	{
		this.handle = handle;
	}

	public static SKIndex CreateWithUrl(NSUrl url, string indexName, SKIndexType type, SKTextAnalysis analysisProperties)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		NSString nSString = ((indexName == null) ? null : new NSString(indexName));
		IntPtr intPtr = SKIndexCreateWithURL(url.Handle, (nSString == null) ? IntPtr.Zero : nSString.Handle, type, analysisProperties?.Dictionary.Handle ?? IntPtr.Zero);
		nSString.Dispose();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKIndex(intPtr);
	}

	public static SKIndex FromUrl(NSUrl url, string indexName, bool writeAccess)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (indexName == null)
		{
			throw new ArgumentNullException("indexName");
		}
		using NSString nSString = new NSString(indexName);
		IntPtr intPtr = SKIndexOpenWithURL(url.Handle, nSString.Handle, writeAccess);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKIndex(intPtr);
	}

	public static SKIndex CreateWithMutableData(NSMutableData data, string indexName, SKIndexType type, SKTextAnalysis analysisProperties)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (indexName == null)
		{
			throw new ArgumentNullException("indexName");
		}
		using NSString nSString = new NSString(indexName);
		IntPtr intPtr = SKIndexCreateWithMutableData(data.Handle, nSString.Handle, type, analysisProperties?.Dictionary.Handle ?? IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKIndex(intPtr);
	}

	public static SKIndex FromMutableData(NSMutableData data, string indexName)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (indexName == null)
		{
			throw new ArgumentNullException("indexName");
		}
		using NSString nSString = new NSString(indexName);
		IntPtr intPtr = SKIndexOpenWithMutableData(data.Handle, nSString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKIndex(intPtr);
	}

	public static SKIndex FromData(NSData data, string indexName)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (indexName == null)
		{
			throw new ArgumentNullException("indexName");
		}
		using NSString nSString = new NSString(indexName);
		IntPtr intPtr = SKIndexOpenWithData(data.Handle, nSString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKIndex(intPtr);
	}

	~SKIndex()
	{
		Dispose(disposing: false);
	}

	public void Close()
	{
		Dispose();
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
			SKIndexClose(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexAddDocumentWithText(IntPtr h, IntPtr doc, IntPtr str, bool canreplace);

	public bool AddDocumentWithText(SKDocument document, string text, bool canReplace)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		NSString nSString = ((text == null) ? null : new NSString(text));
		try
		{
			return SKIndexAddDocumentWithText(handle, document.Handle, (nSString == null) ? IntPtr.Zero : nSString.Handle, canReplace);
		}
		finally
		{
			if (nSString != null)
			{
				nSString.Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexAddDocument(IntPtr h, IntPtr doc, IntPtr mimeHintStr, bool canReplace);

	public bool AddDocument(SKDocument document, string mimeHint, bool canReplace)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		NSString nSString = ((mimeHint == null) ? null : new NSString(mimeHint));
		return SKIndexAddDocument(handle, document.Handle, (nSString == null) ? IntPtr.Zero : nSString.Handle, canReplace);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit", EntryPoint = "SKLoadDefaultExtractorPlugIns")]
	public static extern void LoadDefaultExtractorPlugIns();

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexFlush(IntPtr h);

	public bool Flush()
	{
		return SKIndexFlush(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexCompact(IntPtr h);

	public bool Compact()
	{
		return SKIndexCompact(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKIndexGetDocumentCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKIndexGetMaximumDocumentID(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKIndexGetMaximumTermID(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexGetAnalysisProperties(IntPtr h);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexMoveDocument(IntPtr h, IntPtr document, IntPtr newParent);

	public bool MoveDocument(SKDocument document, SKDocument newParent)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (newParent == null)
		{
			throw new ArgumentNullException("newParent");
		}
		return SKIndexMoveDocument(handle, document.Handle, newParent.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexRemoveDocument(IntPtr h, IntPtr doc);

	public bool RemoveDocument(SKDocument document)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		return SKIndexRemoveDocument(handle, document.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKIndexRenameDocument(IntPtr h, IntPtr doc, IntPtr newName);

	public bool RenameDocument(SKDocument document, string newName)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (newName == null)
		{
			throw new ArgumentNullException("newName");
		}
		using NSString nSString = new NSString(newName);
		return SKIndexRenameDocument(handle, document.Handle, nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern void SKIndexSetMaximumBytesBeforeFlush(IntPtr h, nint value);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKIndexGetMaximumBytesBeforeFlush(IntPtr h);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSearchCreate(IntPtr h, IntPtr str, SKSearchOptions options);

	public SKSearch Search(string query, SKSearchOptions options = SKSearchOptions.Default)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		using NSString nSString = new NSString(query);
		return new SKSearch(SKSearchCreate(handle, nSString.Handle, options));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKIndexCopyDocumentForDocumentID(IntPtr idx, nint docId);

	public SKDocument GetDocument(nint documentId)
	{
		IntPtr intPtr = SKIndexCopyDocumentForDocumentID(handle, documentId);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKDocument(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern void SKIndexSetDocumentProperties(IntPtr h, IntPtr doc, IntPtr dict);

	public void SetDocumentProperties(SKDocument document, NSDictionary dict)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (dict == null)
		{
			throw new ArgumentNullException("dict");
		}
		SKIndexSetDocumentProperties(handle, document.Handle, dict.Handle);
	}
}
