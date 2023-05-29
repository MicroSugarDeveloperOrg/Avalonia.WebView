using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSLinguisticTagger", true)]
public class NSLinguisticTagger : NSObject
{
	private static readonly IntPtr selTagSchemesHandle = Selector.GetHandle("tagSchemes");

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	private static readonly IntPtr selInitWithTagSchemesOptions_Handle = Selector.GetHandle("initWithTagSchemes:options:");

	private static readonly IntPtr selAvailableTagSchemesForLanguage_Handle = Selector.GetHandle("availableTagSchemesForLanguage:");

	private static readonly IntPtr selSetOrthographyRange_Handle = Selector.GetHandle("setOrthography:range:");

	private static readonly IntPtr selOrthographyAtIndexEffectiveRange_Handle = Selector.GetHandle("orthographyAtIndex:effectiveRange:");

	private static readonly IntPtr selStringEditedInRangeChangeInLength_Handle = Selector.GetHandle("stringEditedInRange:changeInLength:");

	private static readonly IntPtr selEnumerateTagsInRangeSchemeOptionsUsingBlock_Handle = Selector.GetHandle("enumerateTagsInRange:scheme:options:usingBlock:");

	private static readonly IntPtr selSentenceRangeForRange_Handle = Selector.GetHandle("sentenceRangeForRange:");

	private static readonly IntPtr selTagAtIndexSchemeTokenRangeSentenceRange_Handle = Selector.GetHandle("tagAtIndex:scheme:tokenRange:sentenceRange:");

	private static readonly IntPtr selTagsInRangeSchemeOptionsTokenRanges_Handle = Selector.GetHandle("tagsInRange:scheme:options:tokenRanges:");

	private static readonly IntPtr selPossibleTagsAtIndexSchemeTokenRangeSentenceRangeScores_Handle = Selector.GetHandle("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSLinguisticTagger");

	private object __mt_TagSchemes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSString[] TagSchemes
	{
		[Export("tagSchemes")]
		get
		{
			return (NSString[])(__mt_TagSchemes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTagSchemesHandle)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTagSchemesHandle))));
		}
	}

	public virtual string AnalysisString
	{
		[Export("string")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLinguisticTagger()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLinguisticTagger(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLinguisticTagger(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLinguisticTagger(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTagSchemes:options:")]
	public NSLinguisticTagger(NSString[] tagSchemes, NSLinguisticTaggerOptions opts)
		: base(NSObjectFlag.Empty)
	{
		if (tagSchemes == null)
		{
			throw new ArgumentNullException("tagSchemes");
		}
		NSArray nSArray = NSArray.FromNSObjects(tagSchemes);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithTagSchemesOptions_Handle, nSArray.Handle, (ulong)opts);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithTagSchemesOptions_Handle, nSArray.Handle, (ulong)opts);
		}
		nSArray.Dispose();
	}

	[Export("availableTagSchemesForLanguage:")]
	public static NSString[] GetAvailableTagSchemesForLanguage(string language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		NSString[] result = NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAvailableTagSchemesForLanguage_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setOrthography:range:")]
	public virtual void SetOrthographyrange(NSOrthography orthography, NSRange range)
	{
		if (orthography == null)
		{
			throw new ArgumentNullException("orthography");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetOrthographyRange_Handle, orthography.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetOrthographyRange_Handle, orthography.Handle, range);
		}
	}

	[Export("orthographyAtIndex:effectiveRange:")]
	public virtual NSOrthography GetOrthography(ulong charIndex, ref NSRange effectiveRange)
	{
		if (IsDirectBinding)
		{
			return (NSOrthography)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_out_NSRange(base.Handle, selOrthographyAtIndexEffectiveRange_Handle, charIndex, out effectiveRange));
		}
		return (NSOrthography)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_out_NSRange(base.SuperHandle, selOrthographyAtIndexEffectiveRange_Handle, charIndex, out effectiveRange));
	}

	[Export("stringEditedInRange:changeInLength:")]
	public virtual void StringEditedInRange(NSRange newRange, long delta)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64(base.Handle, selStringEditedInRangeChangeInLength_Handle, newRange, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64(base.SuperHandle, selStringEditedInRangeChangeInLength_Handle, newRange, delta);
		}
	}

	[Export("enumerateTagsInRange:scheme:options:usingBlock:")]
	public unsafe virtual void EnumerateTagsInRange(NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, NSLingusticEnumerator enumerator)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSLingusticEnumerator.Handler, enumerator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateTagsInRangeSchemeOptionsUsingBlock_Handle, range, tagScheme.Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateTagsInRangeSchemeOptionsUsingBlock_Handle, range, tagScheme.Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("sentenceRangeForRange:")]
	public virtual NSRange GetSentenceRangeForRange(NSRange range)
	{
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selSentenceRangeForRange_Handle, range);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selSentenceRangeForRange_Handle, range);
	}

	[Export("tagAtIndex:scheme:tokenRange:sentenceRange:")]
	public virtual string GetTag(ulong charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_out_NSRange_out_NSRange(base.Handle, selTagAtIndexSchemeTokenRangeSentenceRange_Handle, charIndex, tagScheme.Handle, out tokenRange, out sentenceRange));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_out_NSRange_out_NSRange(base.SuperHandle, selTagAtIndexSchemeTokenRangeSentenceRange_Handle, charIndex, tagScheme.Handle, out tokenRange, out sentenceRange));
	}

	[Export("tagsInRange:scheme:options:tokenRanges:")]
	internal virtual NSString[] GetTagsInRange(NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, ref NSArray tokenRanges)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSString[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr(base.SuperHandle, selTagsInRangeSchemeOptionsTokenRanges_Handle, range, tagScheme.Handle, (ulong)opts, intPtr)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr(base.Handle, selTagsInRangeSchemeOptionsTokenRanges_Handle, range, tagScheme.Handle, (ulong)opts, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		tokenRanges = ((intPtr2 != IntPtr.Zero) ? ((NSArray)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:")]
	internal virtual NSString[] GetPossibleTags(ulong charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange, ref NSArray scores)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSString[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_out_NSRange_out_NSRange_IntPtr(base.SuperHandle, selPossibleTagsAtIndexSchemeTokenRangeSentenceRangeScores_Handle, charIndex, tagScheme.Handle, out tokenRange, out sentenceRange, intPtr)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_out_NSRange_out_NSRange_IntPtr(base.Handle, selPossibleTagsAtIndexSchemeTokenRangeSentenceRangeScores_Handle, charIndex, tagScheme.Handle, out tokenRange, out sentenceRange, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		scores = ((intPtr2 != IntPtr.Zero) ? ((NSArray)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TagSchemes_var = null;
		}
	}
}
