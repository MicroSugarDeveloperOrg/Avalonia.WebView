using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMutableParagraphStyle", true)]
public class NSMutableParagraphStyle : NSParagraphStyle
{
	private static readonly IntPtr selTabStopsHandle = Selector.GetHandle("tabStops");

	private static readonly IntPtr selSetTabStops_Handle = Selector.GetHandle("setTabStops:");

	private static readonly IntPtr selDefaultTabIntervalHandle = Selector.GetHandle("defaultTabInterval");

	private static readonly IntPtr selSetDefaultTabInterval_Handle = Selector.GetHandle("setDefaultTabInterval:");

	private static readonly IntPtr selTighteningFactorForTruncationHandle = Selector.GetHandle("tighteningFactorForTruncation");

	private static readonly IntPtr selSetTighteningFactorForTruncation_Handle = Selector.GetHandle("setTighteningFactorForTruncation:");

	private static readonly IntPtr selHeaderLevelHandle = Selector.GetHandle("headerLevel");

	private static readonly IntPtr selSetHeaderLevel_Handle = Selector.GetHandle("setHeaderLevel:");

	private static readonly IntPtr selLineSpacingHandle = Selector.GetHandle("lineSpacing");

	private static readonly IntPtr selSetLineSpacing_Handle = Selector.GetHandle("setLineSpacing:");

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	private static readonly IntPtr selHeadIndentHandle = Selector.GetHandle("headIndent");

	private static readonly IntPtr selSetHeadIndent_Handle = Selector.GetHandle("setHeadIndent:");

	private static readonly IntPtr selTailIndentHandle = Selector.GetHandle("tailIndent");

	private static readonly IntPtr selSetTailIndent_Handle = Selector.GetHandle("setTailIndent:");

	private static readonly IntPtr selFirstLineHeadIndentHandle = Selector.GetHandle("firstLineHeadIndent");

	private static readonly IntPtr selSetFirstLineHeadIndent_Handle = Selector.GetHandle("setFirstLineHeadIndent:");

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

	private static readonly IntPtr selParagraphSpacingHandle = Selector.GetHandle("paragraphSpacing");

	private static readonly IntPtr selSetParagraphSpacing_Handle = Selector.GetHandle("setParagraphSpacing:");

	private static readonly IntPtr selParagraphSpacingBeforeHandle = Selector.GetHandle("paragraphSpacingBefore");

	private static readonly IntPtr selSetParagraphSpacingBefore_Handle = Selector.GetHandle("setParagraphSpacingBefore:");

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	private static readonly IntPtr selAddTabStop_Handle = Selector.GetHandle("addTabStop:");

	private static readonly IntPtr selRemoveTabStop_Handle = Selector.GetHandle("removeTabStop:");

	private static readonly IntPtr selSetParagraphStyle_Handle = Selector.GetHandle("setParagraphStyle:");

	private static readonly IntPtr selSetTextBlocks_Handle = Selector.GetHandle("setTextBlocks:");

	private static readonly IntPtr selSetTextLists_Handle = Selector.GetHandle("setTextLists:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableParagraphStyle");

	private object __mt_TabStops_var;

	public override IntPtr ClassHandle => class_ptr;

	public override NSTextTab[] TabStops
	{
		[Export("tabStops")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextTab[])(__mt_TabStops_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabStopsHandle)) : NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabStopsHandle))));
		}
		[Export("setTabStops:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTabStops_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTabStops_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_TabStops_var = value;
		}
	}

	public override double DefaultTabInterval
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
		[Export("setDefaultTabInterval:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDefaultTabInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDefaultTabInterval_Handle, value);
			}
		}
	}

	public override float TighteningFactorForTruncation
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
		[Export("setTighteningFactorForTruncation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetTighteningFactorForTruncation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetTighteningFactorForTruncation_Handle, value);
			}
		}
	}

	public override long HeaderLevel
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
		[Export("setHeaderLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHeaderLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHeaderLevel_Handle, value);
			}
		}
	}

	public override double LineSpacing
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
		[Export("setLineSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLineSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLineSpacing_Handle, value);
			}
		}
	}

	public override NSTextAlignment Alignment
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
		[Export("setAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlignment_Handle, (ulong)value);
			}
		}
	}

	public override double HeadIndent
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
		[Export("setHeadIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetHeadIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetHeadIndent_Handle, value);
			}
		}
	}

	public override double TailIndent
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
		[Export("setTailIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTailIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTailIndent_Handle, value);
			}
		}
	}

	public override double FirstLineHeadIndent
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
		[Export("setFirstLineHeadIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFirstLineHeadIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFirstLineHeadIndent_Handle, value);
			}
		}
	}

	public override double MinimumLineHeight
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
		[Export("setMinimumLineHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinimumLineHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinimumLineHeight_Handle, value);
			}
		}
	}

	public override double MaximumLineHeight
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
		[Export("setMaximumLineHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMaximumLineHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMaximumLineHeight_Handle, value);
			}
		}
	}

	public override NSLineBreakMode LineBreakMode
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
		[Export("setLineBreakMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineBreakMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineBreakMode_Handle, (ulong)value);
			}
		}
	}

	public override NSWritingDirection BaseWritingDirection
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
		[Export("setBaseWritingDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBaseWritingDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBaseWritingDirection_Handle, (long)value);
			}
		}
	}

	public override double LineHeightMultiple
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
		[Export("setLineHeightMultiple:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetLineHeightMultiple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetLineHeightMultiple_Handle, value);
			}
		}
	}

	public override double ParagraphSpacing
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
		[Export("setParagraphSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetParagraphSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetParagraphSpacing_Handle, value);
			}
		}
	}

	public override double ParagraphSpacingBefore
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
		[Export("setParagraphSpacingBefore:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetParagraphSpacingBefore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetParagraphSpacingBefore_Handle, value);
			}
		}
	}

	public override float HyphenationFactor
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
		[Export("setHyphenationFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHyphenationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHyphenationFactor_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableParagraphStyle()
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
	public NSMutableParagraphStyle(NSCoder coder)
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
	public NSMutableParagraphStyle(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableParagraphStyle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addTabStop:")]
	public virtual void AddTabStop(NSTextTab anObject)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTabStop_Handle, anObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTabStop_Handle, anObject.Handle);
		}
		_ = TabStops;
	}

	[Export("removeTabStop:")]
	public virtual void RemoveTabStop(NSTextTab anObject)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTabStop_Handle, anObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTabStop_Handle, anObject.Handle);
		}
		_ = TabStops;
	}

	[Export("setParagraphStyle:")]
	public virtual void SetParagraphStyle(NSParagraphStyle obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParagraphStyle_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParagraphStyle_Handle, obj.Handle);
		}
	}

	[Export("setTextBlocks:")]
	public virtual void SetTextBlocks(NSTextBlock[] array)
	{
		NSApplication.EnsureUIThread();
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextBlocks_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextBlocks_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setTextLists:")]
	public virtual void SetTextLists(NSTextList[] array)
	{
		NSApplication.EnsureUIThread();
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextLists_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextLists_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TabStops_var = null;
		}
	}
}
