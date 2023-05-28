using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SearchKit;

public class SKSummary : IDisposable, INativeObject
{
	private IntPtr handle;

	private nint[] hack;

	public IntPtr Handle => handle;

	public nint SentenceCount
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("disposed");
			}
			return SKSummaryGetSentenceCount(handle);
		}
	}

	public nint ParagraphCount
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("disposed");
			}
			return SKSummaryGetParagraphCount(handle);
		}
	}

	internal SKSummary(IntPtr handle)
	{
		this.handle = handle;
	}

	~SKSummary()
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

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSummaryCreateWithString(IntPtr str);

	public static SKSummary Create(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr str = NSString.CreateNative(text);
		IntPtr intPtr = SKSummaryCreateWithString(str);
		NSString.ReleaseNative(str);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKSummary(intPtr);
	}

	public static SKSummary Create(NSString nsString)
	{
		if (nsString == null)
		{
			throw new ArgumentNullException("nsString");
		}
		IntPtr intPtr = SKSummaryCreateWithString(nsString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new SKSummary(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKSummaryGetSentenceSummaryInfo(IntPtr summary, nint maxNumSentencesInSummary, IntPtr rankOrderOfSentences, IntPtr sentenceIndexOfSentences, IntPtr paragraphIndexOfSentences);

	public unsafe nint GetSentenceSummaryInfo(int maxNumSentencesInSummary, nint[] rankOrderOfSentences, nint[] sentenceIndexOfSentences, nint[] paragraphIndexOfSentences)
	{
		if (rankOrderOfSentences != null && rankOrderOfSentences.Length != maxNumSentencesInSummary)
		{
			throw new ArgumentException("array must contain as many element as specified in maxNumSentencesInSummary", "rankOrderOfSentences");
		}
		if (sentenceIndexOfSentences != null && sentenceIndexOfSentences.Length != maxNumSentencesInSummary)
		{
			throw new ArgumentException("array must contain as many element as specified in maxNumSentencesInSummary", "sentenceIndexOfSentences");
		}
		if (paragraphIndexOfSentences != null && paragraphIndexOfSentences.Length != maxNumSentencesInSummary)
		{
			throw new ArgumentException("array must contain as many element as specified in maxNumSentencesInSummary", "paragraphIndexOfSentences");
		}
		if (hack == null)
		{
			hack = new nint[1];
		}
		nint[] array = ((rankOrderOfSentences == null) ? hack : rankOrderOfSentences);
		nint[] array2 = ((sentenceIndexOfSentences == null) ? hack : sentenceIndexOfSentences);
		nint[] array3 = ((paragraphIndexOfSentences == null) ? hack : paragraphIndexOfSentences);
		fixed (nint* ptr = &array[0])
		{
			fixed (nint* ptr3 = &array2[0])
			{
				fixed (nint* ptr4 = &array3[0])
				{
					fixed (nint* ptr2 = &hack[0])
					{
						return SKSummaryGetSentenceSummaryInfo(handle, maxNumSentencesInSummary, (IntPtr)((ptr == ptr2) ? null : ptr), (IntPtr)((ptr3 == ptr2) ? null : ptr3), (IntPtr)((ptr4 == ptr2) ? null : ptr4));
					}
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKSummaryGetParagraphSummaryInfo(IntPtr summary, nint maxNumParagraphsInSummary, IntPtr rankOrderOfParagraphs, IntPtr paragraphIndexOfParagraphs);

	public unsafe nint GetParagraphSummaryInfo(nint maxNumParagraphsInSummary, nint[] rankOrderOfParagraphs, nint[] paragraphIndexOfParagraphs)
	{
		if (rankOrderOfParagraphs != null && rankOrderOfParagraphs.Length != maxNumParagraphsInSummary)
		{
			throw new ArgumentException("array must contain as many element as specified in maxNumParagraphsInSummary", "rankOrderOfParagraphs");
		}
		if (paragraphIndexOfParagraphs != null && paragraphIndexOfParagraphs.Length != maxNumParagraphsInSummary)
		{
			throw new ArgumentException("array must contain as many element as specified in maxNumParagraphsInSummary", "paragraphIndexOfParagraphs");
		}
		if (hack == null)
		{
			hack = new nint[1];
		}
		nint[] array = ((rankOrderOfParagraphs == null) ? hack : rankOrderOfParagraphs);
		nint[] array2 = ((paragraphIndexOfParagraphs == null) ? hack : paragraphIndexOfParagraphs);
		fixed (nint* ptr = &array[0])
		{
			fixed (nint* ptr3 = &array2[0])
			{
				fixed (nint* ptr2 = &hack[0])
				{
					return SKSummaryGetParagraphSummaryInfo(handle, maxNumParagraphsInSummary, (IntPtr)((ptr == ptr2) ? null : ptr), (IntPtr)((ptr3 == ptr2) ? null : ptr3));
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKSummaryGetSentenceCount(IntPtr summary);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern nint SKSummaryGetParagraphCount(IntPtr summary);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSummaryCopySentenceAtIndex(IntPtr summary, nint idx);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSummaryCopyParagraphAtIndex(IntPtr summary, nint idx);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSummaryCopySentenceSummaryString(IntPtr summary, nint maxSentences);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern IntPtr SKSummaryCopyParagraphSummaryString(IntPtr summary, nint maxParagraphs);

	public string GetSentence(nint idx)
	{
		return CFString.FetchString(SKSummaryCopySentenceAtIndex(handle, idx), releaseHandle: true);
	}

	public string GetParagraph(nint idx)
	{
		return CFString.FetchString(SKSummaryCopyParagraphAtIndex(handle, idx), releaseHandle: true);
	}

	public string GetSentenceSummary(nint maxSentences)
	{
		return CFString.FetchString(SKSummaryCopySentenceSummaryString(handle, maxSentences), releaseHandle: true);
	}

	public string GetParagraphSummary(nint maxParagraphs)
	{
		return CFString.FetchString(SKSummaryCopyParagraphSummaryString(handle, maxParagraphs), releaseHandle: true);
	}
}
