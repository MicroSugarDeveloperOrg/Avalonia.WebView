using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMutableParagraphStyle", true)]
public class NSMutableParagraphStyle : NSParagraphStyle
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTabStop_ = "addTabStop:";

	private static readonly IntPtr selAddTabStop_Handle = Selector.GetHandle("addTabStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDefaultTighteningForTruncation = "allowsDefaultTighteningForTruncation";

	private static readonly IntPtr selAllowsDefaultTighteningForTruncationHandle = Selector.GetHandle("allowsDefaultTighteningForTruncation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseWritingDirection = "baseWritingDirection";

	private static readonly IntPtr selBaseWritingDirectionHandle = Selector.GetHandle("baseWritingDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTabInterval = "defaultTabInterval";

	private static readonly IntPtr selDefaultTabIntervalHandle = Selector.GetHandle("defaultTabInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstLineHeadIndent = "firstLineHeadIndent";

	private static readonly IntPtr selFirstLineHeadIndentHandle = Selector.GetHandle("firstLineHeadIndent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeadIndent = "headIndent";

	private static readonly IntPtr selHeadIndentHandle = Selector.GetHandle("headIndent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeaderLevel = "headerLevel";

	private static readonly IntPtr selHeaderLevelHandle = Selector.GetHandle("headerLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHyphenationFactor = "hyphenationFactor";

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineBreakMode = "lineBreakMode";

	private static readonly IntPtr selLineBreakModeHandle = Selector.GetHandle("lineBreakMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineHeightMultiple = "lineHeightMultiple";

	private static readonly IntPtr selLineHeightMultipleHandle = Selector.GetHandle("lineHeightMultiple");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineSpacing = "lineSpacing";

	private static readonly IntPtr selLineSpacingHandle = Selector.GetHandle("lineSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumLineHeight = "maximumLineHeight";

	private static readonly IntPtr selMaximumLineHeightHandle = Selector.GetHandle("maximumLineHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumLineHeight = "minimumLineHeight";

	private static readonly IntPtr selMinimumLineHeightHandle = Selector.GetHandle("minimumLineHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSpacing = "paragraphSpacing";

	private static readonly IntPtr selParagraphSpacingHandle = Selector.GetHandle("paragraphSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParagraphSpacingBefore = "paragraphSpacingBefore";

	private static readonly IntPtr selParagraphSpacingBeforeHandle = Selector.GetHandle("paragraphSpacingBefore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTabStop_ = "removeTabStop:";

	private static readonly IntPtr selRemoveTabStop_Handle = Selector.GetHandle("removeTabStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_ = "setAlignment:";

	private static readonly IntPtr selSetAlignment_Handle = Selector.GetHandle("setAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsDefaultTighteningForTruncation_ = "setAllowsDefaultTighteningForTruncation:";

	private static readonly IntPtr selSetAllowsDefaultTighteningForTruncation_Handle = Selector.GetHandle("setAllowsDefaultTighteningForTruncation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseWritingDirection_ = "setBaseWritingDirection:";

	private static readonly IntPtr selSetBaseWritingDirection_Handle = Selector.GetHandle("setBaseWritingDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTabInterval_ = "setDefaultTabInterval:";

	private static readonly IntPtr selSetDefaultTabInterval_Handle = Selector.GetHandle("setDefaultTabInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFirstLineHeadIndent_ = "setFirstLineHeadIndent:";

	private static readonly IntPtr selSetFirstLineHeadIndent_Handle = Selector.GetHandle("setFirstLineHeadIndent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeadIndent_ = "setHeadIndent:";

	private static readonly IntPtr selSetHeadIndent_Handle = Selector.GetHandle("setHeadIndent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeaderLevel_ = "setHeaderLevel:";

	private static readonly IntPtr selSetHeaderLevel_Handle = Selector.GetHandle("setHeaderLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHyphenationFactor_ = "setHyphenationFactor:";

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineBreakMode_ = "setLineBreakMode:";

	private static readonly IntPtr selSetLineBreakMode_Handle = Selector.GetHandle("setLineBreakMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineHeightMultiple_ = "setLineHeightMultiple:";

	private static readonly IntPtr selSetLineHeightMultiple_Handle = Selector.GetHandle("setLineHeightMultiple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineSpacing_ = "setLineSpacing:";

	private static readonly IntPtr selSetLineSpacing_Handle = Selector.GetHandle("setLineSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumLineHeight_ = "setMaximumLineHeight:";

	private static readonly IntPtr selSetMaximumLineHeight_Handle = Selector.GetHandle("setMaximumLineHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumLineHeight_ = "setMinimumLineHeight:";

	private static readonly IntPtr selSetMinimumLineHeight_Handle = Selector.GetHandle("setMinimumLineHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParagraphSpacing_ = "setParagraphSpacing:";

	private static readonly IntPtr selSetParagraphSpacing_Handle = Selector.GetHandle("setParagraphSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParagraphSpacingBefore_ = "setParagraphSpacingBefore:";

	private static readonly IntPtr selSetParagraphSpacingBefore_Handle = Selector.GetHandle("setParagraphSpacingBefore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParagraphStyle_ = "setParagraphStyle:";

	private static readonly IntPtr selSetParagraphStyle_Handle = Selector.GetHandle("setParagraphStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTabStops_ = "setTabStops:";

	private static readonly IntPtr selSetTabStops_Handle = Selector.GetHandle("setTabStops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTailIndent_ = "setTailIndent:";

	private static readonly IntPtr selSetTailIndent_Handle = Selector.GetHandle("setTailIndent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextBlocks_ = "setTextBlocks:";

	private static readonly IntPtr selSetTextBlocks_Handle = Selector.GetHandle("setTextBlocks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextLists_ = "setTextLists:";

	private static readonly IntPtr selSetTextLists_Handle = Selector.GetHandle("setTextLists:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTighteningFactorForTruncation_ = "setTighteningFactorForTruncation:";

	private static readonly IntPtr selSetTighteningFactorForTruncation_Handle = Selector.GetHandle("setTighteningFactorForTruncation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabStops = "tabStops";

	private static readonly IntPtr selTabStopsHandle = Selector.GetHandle("tabStops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTailIndent = "tailIndent";

	private static readonly IntPtr selTailIndentHandle = Selector.GetHandle("tailIndent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTighteningFactorForTruncation = "tighteningFactorForTruncation";

	private static readonly IntPtr selTighteningFactorForTruncationHandle = Selector.GetHandle("tighteningFactorForTruncation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableParagraphStyle");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSTextAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
		[Export("setAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlignment_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual bool AllowsDefaultTighteningForTruncation
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("allowsDefaultTighteningForTruncation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDefaultTighteningForTruncationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDefaultTighteningForTruncationHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAllowsDefaultTighteningForTruncation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsDefaultTighteningForTruncation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsDefaultTighteningForTruncation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSWritingDirection BaseWritingDirection
	{
		[Export("baseWritingDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWritingDirection)Messaging.Int64_objc_msgSend(base.Handle, selBaseWritingDirectionHandle);
			}
			return (NSWritingDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBaseWritingDirectionHandle);
		}
		[Export("setBaseWritingDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBaseWritingDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBaseWritingDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat DefaultTabInterval
	{
		[Export("defaultTabInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDefaultTabIntervalHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDefaultTabIntervalHandle);
		}
		[Export("setDefaultTabInterval:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDefaultTabInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDefaultTabInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat FirstLineHeadIndent
	{
		[Export("firstLineHeadIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFirstLineHeadIndentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFirstLineHeadIndentHandle);
		}
		[Export("setFirstLineHeadIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFirstLineHeadIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFirstLineHeadIndent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat HeadIndent
	{
		[Export("headIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selHeadIndentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selHeadIndentHandle);
		}
		[Export("setHeadIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetHeadIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetHeadIndent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nint HeaderLevel
	{
		[Export("headerLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHeaderLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHeaderLevelHandle);
		}
		[Export("setHeaderLevel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHeaderLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHeaderLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override float HyphenationFactor
	{
		[Export("hyphenationFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHyphenationFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHyphenationFactorHandle);
		}
		[Export("setHyphenationFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHyphenationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHyphenationFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSLineBreakMode LineBreakMode
	{
		[Export("lineBreakMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLineBreakMode)Messaging.UInt64_objc_msgSend(base.Handle, selLineBreakModeHandle);
			}
			return (NSLineBreakMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineBreakModeHandle);
		}
		[Export("setLineBreakMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineBreakMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineBreakMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat LineHeightMultiple
	{
		[Export("lineHeightMultiple")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineHeightMultipleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineHeightMultipleHandle);
		}
		[Export("setLineHeightMultiple:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineHeightMultiple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineHeightMultiple_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat LineSpacing
	{
		[Export("lineSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineSpacingHandle);
		}
		[Export("setLineSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat MaximumLineHeight
	{
		[Export("maximumLineHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumLineHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumLineHeightHandle);
		}
		[Export("setMaximumLineHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMaximumLineHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMaximumLineHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat MinimumLineHeight
	{
		[Export("minimumLineHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumLineHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumLineHeightHandle);
		}
		[Export("setMinimumLineHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumLineHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumLineHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat ParagraphSpacing
	{
		[Export("paragraphSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParagraphSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParagraphSpacingHandle);
		}
		[Export("setParagraphSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParagraphSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParagraphSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat ParagraphSpacingBefore
	{
		[Export("paragraphSpacingBefore")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selParagraphSpacingBeforeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selParagraphSpacingBeforeHandle);
		}
		[Export("setParagraphSpacingBefore:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetParagraphSpacingBefore_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetParagraphSpacingBefore_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSTextTab[] TabStops
	{
		[Export("tabStops", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSend(base.Handle, selTabStopsHandle));
			}
			return NSArray.ArrayFromHandle<NSTextTab>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTabStopsHandle));
		}
		[Export("setTabStops:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTabStops_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTabStops_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override nfloat TailIndent
	{
		[Export("tailIndent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTailIndentHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTailIndentHandle);
		}
		[Export("setTailIndent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTailIndent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTailIndent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override float TighteningFactorForTruncation
	{
		[Export("tighteningFactorForTruncation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selTighteningFactorForTruncationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTighteningFactorForTruncationHandle);
		}
		[Export("setTighteningFactorForTruncation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetTighteningFactorForTruncation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetTighteningFactorForTruncation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableParagraphStyle()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableParagraphStyle(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMutableParagraphStyle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableParagraphStyle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addTabStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTabStop(NSTextTab anObject)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTabStop_Handle, anObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTabStop_Handle, anObject.Handle);
		}
	}

	[Export("removeTabStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTabStop(NSTextTab anObject)
	{
		NSApplication.EnsureUIThread();
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTabStop_Handle, anObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTabStop_Handle, anObject.Handle);
		}
	}

	[Export("setParagraphStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetParagraphStyle(NSParagraphStyle obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParagraphStyle_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParagraphStyle_Handle, obj.Handle);
		}
	}

	[Export("setTextBlocks:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextBlocks(NSTextBlock[] array)
	{
		NSApplication.EnsureUIThread();
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTextLists(NSTextList[] array)
	{
		NSApplication.EnsureUIThread();
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextLists_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextLists_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
