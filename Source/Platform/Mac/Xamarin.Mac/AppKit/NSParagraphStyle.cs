using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSParagraphStyle", true)]
public class NSParagraphStyle : NSObject
{
	private static readonly IntPtr selDefaultParagraphStyleHandle = Selector.GetHandle("defaultParagraphStyle");

	private static readonly IntPtr selSetDefaultParagraphStyle_Handle = Selector.GetHandle("setDefaultParagraphStyle:");

	private static readonly IntPtr selLineSpacingHandle = Selector.GetHandle("lineSpacing");

	private static readonly IntPtr selSetLineSpacing_Handle = Selector.GetHandle("setLineSpacing:");

	private static readonly IntPtr selParagraphSpacingHandle = Selector.GetHandle("paragraphSpacing");

	private static readonly IntPtr selSetParagraphSpacing_Handle = Selector.GetHandle("setParagraphSpacing:");

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	private static readonly IntPtr selHeadIndentHandle = Selector.GetHandle("headIndent");

	private static readonly IntPtr selSetHeadIndent_Handle = Selector.GetHandle("setHeadIndent:");

	private static readonly IntPtr selTailIndentHandle = Selector.GetHandle("tailIndent");

	private static readonly IntPtr selSetTailIndent_Handle = Selector.GetHandle("setTailIndent:");

	private static readonly IntPtr selFirstLineHeadIndentHandle = Selector.GetHandle("firstLineHeadIndent");

	private static readonly IntPtr selSetFirstLineHeadIndent_Handle = Selector.GetHandle("setFirstLineHeadIndent:");

	private static readonly IntPtr selTabStopsHandle = Selector.GetHandle("tabStops");

	private static readonly IntPtr selSetTabStops_Handle = Selector.GetHandle("setTabStops:");

	private static readonly IntPtr selMinimumLineHeightHandle = Selector.GetHandle("minimumLineHeight");

	private static readonly IntPtr selSetMinimumLineHeight_Handle = Selector.GetHandle("setMinimumLineHeight:");

	private static readonly IntPtr selMaximumLineHeightHandle = Selector.GetHandle("maximumLineHeight");

	private static readonly IntPtr selSetMaximumLineHeight_Handle = Selector.GetHandle("setMaximumLineHeight:");

	private static readonly IntPtr selLineBreakModeHandle = Selector.GetHandle("lineBreakMode");

	private static readonly IntPtr selSetLineBreakMode_Handle = Selector.GetHandle("setLineBreakMode:");

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	private static readonly IntPtr selLineHeightMultipleHandle = Selector.GetHandle("lineHeightMultiple");

	private static readonly IntPtr selSetLineHeightMultiple_Handle = Selector.GetHandle("setLineHeightMultiple:");

	private static readonly IntPtr selParagraphSpacingBeforeHandle = Selector.GetHandle("paragraphSpacingBefore");

	private static readonly IntPtr selSetParagraphSpacingBefore_Handle = Selector.GetHandle("setParagraphSpacingBefore:");

	private static readonly IntPtr selDefaultTabIntervalHandle = Selector.GetHandle("defaultTabInterval");

	private static readonly IntPtr selSetDefaultTabInterval_Handle = Selector.GetHandle("setDefaultTabInterval:");

	private static readonly IntPtr selTextBlocksHandle = Selector.GetHandle("textBlocks");

	private static readonly IntPtr selSetTextBlocks_Handle = Selector.GetHandle("setTextBlocks:");

	private static readonly IntPtr selTextListsHandle = Selector.GetHandle("textLists");

	private static readonly IntPtr selSetTextLists_Handle = Selector.GetHandle("setTextLists:");

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	private static readonly IntPtr selTighteningFactorForTruncationHandle = Selector.GetHandle("tighteningFactorForTruncation");

	private static readonly IntPtr selSetTighteningFactorForTruncation_Handle = Selector.GetHandle("setTighteningFactorForTruncation:");

	private static readonly IntPtr selHeaderLevelHandle = Selector.GetHandle("headerLevel");

	private static readonly IntPtr selSetHeaderLevel_Handle = Selector.GetHandle("setHeaderLevel:");

	private static readonly IntPtr selDefaultWritingDirectionForLanguage_Handle = Selector.GetHandle("defaultWritingDirectionForLanguage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSParagraphStyle");

	private static object __mt_DefaultParagraphStyle_var_static;

	private object __mt_TabStops_var;

	private object __mt_TextBlocks_var;

	private object __mt_TextLists_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSParagraphStyle DefaultParagraphStyle
	{
		[Export("defaultParagraphStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSParagraphStyle)(__mt_DefaultParagraphStyle_var_static = (NSParagraphStyle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultParagraphStyleHandle)));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double LineSpacing
	{
		[Export("lineSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLineSpacingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLineSpacingHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double ParagraphSpacing
	{
		[Export("paragraphSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selParagraphSpacingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selParagraphSpacingHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double HeadIndent
	{
		[Export("headIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHeadIndentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHeadIndentHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double TailIndent
	{
		[Export("tailIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTailIndentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTailIndentHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double FirstLineHeadIndent
	{
		[Export("firstLineHeadIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFirstLineHeadIndentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFirstLineHeadIndentHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSTextTab[] TabStops
	{
		[Export("tabStops")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextTab[])(__mt_TabStops_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabStopsHandle)) : NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabStopsHandle))));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double MinimumLineHeight
	{
		[Export("minimumLineHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumLineHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumLineHeightHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double MaximumLineHeight
	{
		[Export("maximumLineHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaximumLineHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaximumLineHeightHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSLineBreakMode LineBreakMode
	{
		[Export("lineBreakMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLineBreakMode)Messaging.UInt64_objc_msgSend(base.Handle, selLineBreakModeHandle);
			}
			return (NSLineBreakMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineBreakModeHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSWritingDirection BaseWritingDirection
	{
		[Export("baseWritingDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWritingDirection)Messaging.Int64_objc_msgSend(base.Handle, selBaseWritingDirectionHandle);
			}
			return (NSWritingDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBaseWritingDirectionHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double LineHeightMultiple
	{
		[Export("lineHeightMultiple")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLineHeightMultipleHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLineHeightMultipleHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double ParagraphSpacingBefore
	{
		[Export("paragraphSpacingBefore")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selParagraphSpacingBeforeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selParagraphSpacingBeforeHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual double DefaultTabInterval
	{
		[Export("defaultTabInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDefaultTabIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDefaultTabIntervalHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSTextTableBlock[] TextBlocks
	{
		[Export("textBlocks")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextTableBlock[])(__mt_TextBlocks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextTableBlock>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextBlocksHandle)) : NSArray.ArrayFromHandle<NSTextTableBlock>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextBlocksHandle))));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual NSTextList[] TextLists
	{
		[Export("textLists")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextList[])(__mt_TextLists_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextListsHandle)) : NSArray.ArrayFromHandle<NSTextList>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextListsHandle))));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual float HyphenationFactor
	{
		[Export("hyphenationFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHyphenationFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHyphenationFactorHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual float TighteningFactorForTruncation
	{
		[Export("tighteningFactorForTruncation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTighteningFactorForTruncationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTighteningFactorForTruncationHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual long HeaderLevel
	{
		[Export("headerLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selHeaderLevelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHeaderLevelHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSParagraphStyle()
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
	public NSParagraphStyle(NSCoder coder)
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
	public NSParagraphStyle(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSParagraphStyle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("defaultWritingDirectionForLanguage:")]
	public static NSWritingDirection DefaultWritingDirection(string languageName)
	{
		NSApplication.EnsureUIThread();
		if (languageName == null)
		{
			throw new ArgumentNullException("languageName");
		}
		IntPtr arg = NSString.CreateNative(languageName);
		long result = Messaging.Int64_objc_msgSend_IntPtr(class_ptr, selDefaultWritingDirectionForLanguage_Handle, arg);
		NSString.ReleaseNative(arg);
		return (NSWritingDirection)result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TabStops_var = null;
			__mt_TextBlocks_var = null;
			__mt_TextLists_var = null;
		}
	}
}
