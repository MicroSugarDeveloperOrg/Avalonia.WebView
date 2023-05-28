using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Social;

[Register("SLComposeServiceViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SLComposeServiceViewController : NSViewController, INSTextViewDelegate, INativeObject, IDisposable, INSTextDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharactersRemaining = "charactersRemaining";

	private static readonly IntPtr selCharactersRemainingHandle = Selector.GetHandle("charactersRemaining");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentText = "contentText";

	private static readonly IntPtr selContentTextHandle = Selector.GetHandle("contentText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidSelectCancel = "didSelectCancel";

	private static readonly IntPtr selDidSelectCancelHandle = Selector.GetHandle("didSelectCancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidSelectPost = "didSelectPost";

	private static readonly IntPtr selDidSelectPostHandle = Selector.GetHandle("didSelectPost");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContentValid = "isContentValid";

	private static readonly IntPtr selIsContentValidHandle = Selector.GetHandle("isContentValid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholder = "placeholder";

	private static readonly IntPtr selPlaceholderHandle = Selector.GetHandle("placeholder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationAnimationDidFinish = "presentationAnimationDidFinish";

	private static readonly IntPtr selPresentationAnimationDidFinishHandle = Selector.GetHandle("presentationAnimationDidFinish");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCharactersRemaining_ = "setCharactersRemaining:";

	private static readonly IntPtr selSetCharactersRemaining_Handle = Selector.GetHandle("setCharactersRemaining:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaceholder_ = "setPlaceholder:";

	private static readonly IntPtr selSetPlaceholder_Handle = Selector.GetHandle("setPlaceholder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView = "textView";

	private static readonly IntPtr selTextViewHandle = Selector.GetHandle("textView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_Candidates_ForSelectedRange_ = "textView:candidates:forSelectedRange:";

	private static readonly IntPtr selTextView_Candidates_ForSelectedRange_Handle = Selector.GetHandle("textView:candidates:forSelectedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_CandidatesForSelectedRange_ = "textView:candidatesForSelectedRange:";

	private static readonly IntPtr selTextView_CandidatesForSelectedRange_Handle = Selector.GetHandle("textView:candidatesForSelectedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ClickedOnCell_InRect_AtIndex_ = "textView:clickedOnCell:inRect:atIndex:";

	private static readonly IntPtr selTextView_ClickedOnCell_InRect_AtIndex_Handle = Selector.GetHandle("textView:clickedOnCell:inRect:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ClickedOnLink_AtIndex_ = "textView:clickedOnLink:atIndex:";

	private static readonly IntPtr selTextView_ClickedOnLink_AtIndex_Handle = Selector.GetHandle("textView:clickedOnLink:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_ = "textView:completions:forPartialWordRange:indexOfSelectedItem:";

	private static readonly IntPtr selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_Handle = Selector.GetHandle("textView:completions:forPartialWordRange:indexOfSelectedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_ = "textView:didCheckTextInRange:types:options:results:orthography:wordCount:";

	private static readonly IntPtr selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_Handle = Selector.GetHandle("textView:didCheckTextInRange:types:options:results:orthography:wordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_DoCommandBySelector_ = "textView:doCommandBySelector:";

	private static readonly IntPtr selTextView_DoCommandBySelector_Handle = Selector.GetHandle("textView:doCommandBySelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_DoubleClickedOnCell_InRect_AtIndex_ = "textView:doubleClickedOnCell:inRect:atIndex:";

	private static readonly IntPtr selTextView_DoubleClickedOnCell_InRect_AtIndex_Handle = Selector.GetHandle("textView:doubleClickedOnCell:inRect:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_DraggedCell_InRect_Event_ = "textView:draggedCell:inRect:event:";

	private static readonly IntPtr selTextView_DraggedCell_InRect_Event_Handle = Selector.GetHandle("textView:draggedCell:inRect:event:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_Menu_ForEvent_AtIndex_ = "textView:menu:forEvent:atIndex:";

	private static readonly IntPtr selTextView_Menu_ForEvent_AtIndex_Handle = Selector.GetHandle("textView:menu:forEvent:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldChangeTextInRange_ReplacementString_ = "textView:shouldChangeTextInRange:replacementString:";

	private static readonly IntPtr selTextView_ShouldChangeTextInRange_ReplacementString_Handle = Selector.GetHandle("textView:shouldChangeTextInRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldChangeTextInRanges_ReplacementStrings_ = "textView:shouldChangeTextInRanges:replacementStrings:";

	private static readonly IntPtr selTextView_ShouldChangeTextInRanges_ReplacementStrings_Handle = Selector.GetHandle("textView:shouldChangeTextInRanges:replacementStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldChangeTypingAttributes_ToAttributes_ = "textView:shouldChangeTypingAttributes:toAttributes:";

	private static readonly IntPtr selTextView_ShouldChangeTypingAttributes_ToAttributes_Handle = Selector.GetHandle("textView:shouldChangeTypingAttributes:toAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldSelectCandidateAtIndex_ = "textView:shouldSelectCandidateAtIndex:";

	private static readonly IntPtr selTextView_ShouldSelectCandidateAtIndex_Handle = Selector.GetHandle("textView:shouldSelectCandidateAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldSetSpellingState_Range_ = "textView:shouldSetSpellingState:range:";

	private static readonly IntPtr selTextView_ShouldSetSpellingState_Range_Handle = Selector.GetHandle("textView:shouldSetSpellingState:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_ShouldUpdateTouchBarItemIdentifiers_ = "textView:shouldUpdateTouchBarItemIdentifiers:";

	private static readonly IntPtr selTextView_ShouldUpdateTouchBarItemIdentifiers_Handle = Selector.GetHandle("textView:shouldUpdateTouchBarItemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_ = "textView:willChangeSelectionFromCharacterRange:toCharacterRange:";

	private static readonly IntPtr selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_Handle = Selector.GetHandle("textView:willChangeSelectionFromCharacterRange:toCharacterRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_ = "textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:";

	private static readonly IntPtr selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_Handle = Selector.GetHandle("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WillCheckTextInRange_Options_Types_ = "textView:willCheckTextInRange:options:types:";

	private static readonly IntPtr selTextView_WillCheckTextInRange_Options_Types_Handle = Selector.GetHandle("textView:willCheckTextInRange:options:types:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WillDisplayToolTip_ForCharacterAtIndex_ = "textView:willDisplayToolTip:forCharacterAtIndex:";

	private static readonly IntPtr selTextView_WillDisplayToolTip_ForCharacterAtIndex_Handle = Selector.GetHandle("textView:willDisplayToolTip:forCharacterAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WritablePasteboardTypesForCell_AtIndex_ = "textView:writablePasteboardTypesForCell:atIndex:";

	private static readonly IntPtr selTextView_WritablePasteboardTypesForCell_AtIndex_Handle = Selector.GetHandle("textView:writablePasteboardTypesForCell:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView_WriteCell_AtIndex_ToPasteboard_Type_ = "textView:writeCell:atIndex:toPasteboard:type:";

	private static readonly IntPtr selTextView_WriteCell_AtIndex_ToPasteboard_Type_Handle = Selector.GetHandle("textView:writeCell:atIndex:toPasteboard:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextViewDidChangeSelection_ = "textViewDidChangeSelection:";

	private static readonly IntPtr selTextViewDidChangeSelection_Handle = Selector.GetHandle("textViewDidChangeSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextViewDidChangeTypingAttributes_ = "textViewDidChangeTypingAttributes:";

	private static readonly IntPtr selTextViewDidChangeTypingAttributes_Handle = Selector.GetHandle("textViewDidChangeTypingAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoManagerForTextView_ = "undoManagerForTextView:";

	private static readonly IntPtr selUndoManagerForTextView_Handle = Selector.GetHandle("undoManagerForTextView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateContent = "validateContent";

	private static readonly IntPtr selValidateContentHandle = Selector.GetHandle("validateContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SLComposeServiceViewController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? CharactersRemaining
	{
		[Export("charactersRemaining", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selCharactersRemainingHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharactersRemainingHandle));
		}
		[Export("setCharactersRemaining:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCharactersRemaining_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCharactersRemaining_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ContentText
	{
		[Export("contentText")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentTextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Placeholder
	{
		[Export("placeholder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderHandle));
		}
		[Export("setPlaceholder:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholder_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholder_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextView TextView
	{
		[Export("textView")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextViewHandle));
			}
			return Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SLComposeServiceViewController()
		: base(NSObjectFlag.Empty)
	{
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
	public SLComposeServiceViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected SLComposeServiceViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SLComposeServiceViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SLComposeServiceViewController(string? nibName, NSBundle? bundle)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("textView:clickedOnCell:inRect:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_nuint(base.Handle, selTextView_ClickedOnCell_InRect_AtIndex_Handle, textView.Handle, cell.Handle, cellFrame, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_nuint(base.SuperHandle, selTextView_ClickedOnCell_InRect_AtIndex_Handle, textView.Handle, cell.Handle, cellFrame, charIndex);
		}
	}

	[Export("textView:doubleClickedOnCell:inRect:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellDoubleClicked(NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_nuint(base.Handle, selTextView_DoubleClickedOnCell_InRect_AtIndex_Handle, textView.Handle, cell.Handle, cellFrame, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_nuint(base.SuperHandle, selTextView_DoubleClickedOnCell_InRect_AtIndex_Handle, textView.Handle, cell.Handle, cellFrame, charIndex);
		}
	}

	[Export("textViewDidChangeSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeSelection(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextViewDidChangeSelection_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextViewDidChangeSelection_Handle, notification.Handle);
		}
	}

	[Export("textViewDidChangeTypingAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeTypingAttributes(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextViewDidChangeTypingAttributes_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextViewDidChangeTypingAttributes_Handle, notification.Handle);
		}
	}

	[Export("textView:didCheckTextInRange:types:options:results:orthography:wordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] DidCheckText(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (results == null)
		{
			throw new ArgumentNullException("results");
		}
		if (orthography == null)
		{
			throw new ArgumentNullException("orthography");
		}
		NSArray nSArray = NSArray.FromNSObjects(results);
		NSTextCheckingResult[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_nint(base.SuperHandle, selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_Handle, view.Handle, range, (ulong)checkingTypes, options.Handle, nSArray.Handle, orthography.Handle, wordCount)) : NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_nint(base.Handle, selTextView_DidCheckTextInRange_Types_Options_Results_Orthography_WordCount_Handle, view.Handle, range, (ulong)checkingTypes, options.Handle, nSArray.Handle, orthography.Handle, wordCount)));
		nSArray.Dispose();
		return result;
	}

	[Export("didSelectCancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelectCancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidSelectCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidSelectCancelHandle);
		}
	}

	[Export("didSelectPost")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelectPost()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidSelectPostHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidSelectPostHandle);
		}
	}

	[Export("textView:doCommandBySelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoCommandBySelector(NSTextView textView, Selector commandSelector)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (commandSelector == null)
		{
			throw new ArgumentNullException("commandSelector");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTextView_DoCommandBySelector_Handle, textView.Handle, commandSelector.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTextView_DoCommandBySelector_Handle, textView.Handle, commandSelector.Handle);
	}

	[Export("textView:draggedCell:inRect:event:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DraggedCell(NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (theevent == null)
		{
			throw new ArgumentNullException("theevent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr(base.Handle, selTextView_DraggedCell_InRect_Event_Handle, view.Handle, cell.Handle, rect, theevent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr(base.SuperHandle, selTextView_DraggedCell_InRect_Event_Handle, view.Handle, cell.Handle, rect, theevent.Handle);
		}
	}

	[Export("textView:candidatesForSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[]? GetCandidates(NSTextView textView, NSRange selectedRange)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(base.Handle, selTextView_CandidatesForSelectedRange_Handle, textView.Handle, selectedRange));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selTextView_CandidatesForSelectedRange_Handle, textView.Handle, selectedRange));
	}

	[Export("textView:completions:forPartialWordRange:indexOfSelectedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetCompletions(NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (words == null)
		{
			throw new ArgumentNullException("words");
		}
		NSArray nSArray = NSArray.FromStrings(words);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_NSRange_ref_nint(base.SuperHandle, selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_Handle, textView.Handle, nSArray.Handle, charRange, ref index)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange_ref_nint(base.Handle, selTextView_Completions_ForPartialWordRange_IndexOfSelectedItem_Handle, textView.Handle, nSArray.Handle, charRange, ref index)));
		nSArray.Dispose();
		return result;
	}

	[Export("textView:candidates:forSelectedRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] GetTextCheckingCandidates(NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (candidates == null)
		{
			throw new ArgumentNullException("candidates");
		}
		NSArray nSArray = NSArray.FromNSObjects(candidates);
		NSTextCheckingResult[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_NSRange(base.SuperHandle, selTextView_Candidates_ForSelectedRange_Handle, textView.Handle, nSArray.Handle, selectedRange)) : NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selTextView_Candidates_ForSelectedRange_Handle, textView.Handle, nSArray.Handle, selectedRange)));
		nSArray.Dispose();
		return result;
	}

	[Export("undoManagerForTextView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager GetUndoManager(NSTextView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUndoManagerForTextView_Handle, view.Handle));
		}
		return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUndoManagerForTextView_Handle, view.Handle));
	}

	[Export("textView:writablePasteboardTypesForCell:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritablePasteboardTypes(NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (forCell == null)
		{
			throw new ArgumentNullException("forCell");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selTextView_WritablePasteboardTypesForCell_AtIndex_Handle, view.Handle, forCell.Handle, charIndex));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selTextView_WritablePasteboardTypesForCell_AtIndex_Handle, view.Handle, forCell.Handle, charIndex));
	}

	[Export("isContentValid")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsContentValid()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsContentValidHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContentValidHandle);
	}

	[Export("textView:clickedOnLink:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LinkClicked(NSTextView textView, NSObject link, nuint charIndex)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (link == null)
		{
			throw new ArgumentNullException("link");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selTextView_ClickedOnLink_AtIndex_Handle, textView.Handle, link.Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selTextView_ClickedOnLink_AtIndex_Handle, textView.Handle, link.Handle, charIndex);
	}

	[Export("textView:menu:forEvent:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu MenuForEvent(NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selTextView_Menu_ForEvent_AtIndex_Handle, view.Handle, menu.Handle, theEvent.Handle, charIndex));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selTextView_Menu_ForEvent_AtIndex_Handle, view.Handle, menu.Handle, theEvent.Handle, charIndex));
	}

	[Export("presentationAnimationDidFinish")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentationAnimationDidFinish()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPresentationAnimationDidFinishHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPresentationAnimationDidFinishHandle);
		}
	}

	[Export("textView:shouldChangeTextInRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeTextInRange(NSTextView textView, NSRange affectedCharRange, string replacementString)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr(base.SuperHandle, selTextView_ShouldChangeTextInRange_ReplacementString_Handle, textView.Handle, affectedCharRange, arg) : Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr(base.Handle, selTextView_ShouldChangeTextInRange_ReplacementString_Handle, textView.Handle, affectedCharRange, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("textView:shouldChangeTextInRanges:replacementStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeTextInRanges(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (affectedRanges == null)
		{
			throw new ArgumentNullException("affectedRanges");
		}
		if (replacementStrings == null)
		{
			throw new ArgumentNullException("replacementStrings");
		}
		NSArray nSArray = NSArray.FromNSObjects(affectedRanges);
		NSArray nSArray2 = NSArray.FromStrings(replacementStrings);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextView_ShouldChangeTextInRanges_ReplacementStrings_Handle, textView.Handle, nSArray.Handle, nSArray2.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selTextView_ShouldChangeTextInRanges_ReplacementStrings_Handle, textView.Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("textView:shouldChangeTypingAttributes:toAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ShouldChangeTypingAttributes(NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (oldTypingAttributes == null)
		{
			throw new ArgumentNullException("oldTypingAttributes");
		}
		if (newTypingAttributes == null)
		{
			throw new ArgumentNullException("newTypingAttributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selTextView_ShouldChangeTypingAttributes_ToAttributes_Handle, textView.Handle, oldTypingAttributes.Handle, newTypingAttributes.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextView_ShouldChangeTypingAttributes_ToAttributes_Handle, textView.Handle, oldTypingAttributes.Handle, newTypingAttributes.Handle));
	}

	[Export("textView:shouldSelectCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSelectCandidates(NSTextView textView, nuint index)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nuint(base.Handle, selTextView_ShouldSelectCandidateAtIndex_Handle, textView.Handle, index);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selTextView_ShouldSelectCandidateAtIndex_Handle, textView.Handle, index);
	}

	[Export("textView:shouldSetSpellingState:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ShouldSetSpellingState(NSTextView textView, nint value, NSRange affectedCharRange)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_nint_NSRange(base.Handle, selTextView_ShouldSetSpellingState_Range_Handle, textView.Handle, value, affectedCharRange);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_nint_NSRange(base.SuperHandle, selTextView_ShouldSetSpellingState_Range_Handle, textView.Handle, value, affectedCharRange);
	}

	[Export("textView:shouldUpdateTouchBarItemIdentifiers:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ShouldUpdateTouchBarItemIdentifiers(NSTextView textView, string[] identifiers)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTextView_ShouldUpdateTouchBarItemIdentifiers_Handle, textView.Handle, nSArray.Handle)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTextView_ShouldUpdateTouchBarItemIdentifiers_Handle, textView.Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("validateContent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ValidateContent()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateContentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateContentHandle);
		}
	}

	[Export("textView:willChangeSelectionFromCharacterRange:toCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange WillChangeSelection(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_NSRange_NSRange(base.Handle, selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_Handle, textView.Handle, oldSelectedCharRange, newSelectedCharRange);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_NSRange_NSRange(base.SuperHandle, selTextView_WillChangeSelectionFromCharacterRange_ToCharacterRange_Handle, textView.Handle, oldSelectedCharRange, newSelectedCharRange);
	}

	[Export("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] WillChangeSelectionFromRanges(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (oldSelectedCharRanges == null)
		{
			throw new ArgumentNullException("oldSelectedCharRanges");
		}
		if (newSelectedCharRanges == null)
		{
			throw new ArgumentNullException("newSelectedCharRanges");
		}
		NSArray nSArray = NSArray.FromNSObjects(oldSelectedCharRanges);
		NSArray nSArray2 = NSArray.FromNSObjects(newSelectedCharRanges);
		NSValue[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_Handle, textView.Handle, nSArray.Handle, nSArray2.Handle)) : NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selTextView_WillChangeSelectionFromCharacterRanges_ToCharacterRanges_Handle, textView.Handle, nSArray.Handle, nSArray2.Handle)));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("textView:willCheckTextInRange:options:types:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary WillCheckText(NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_IntPtr_UInt64(base.Handle, selTextView_WillCheckTextInRange_Options_Types_Handle, view.Handle, range, options.Handle, (ulong)checkingTypes));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange_IntPtr_UInt64(base.SuperHandle, selTextView_WillCheckTextInRange_Options_Types_Handle, view.Handle, range, options.Handle, (ulong)checkingTypes));
	}

	[Export("textView:willDisplayToolTip:forCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? WillDisplayToolTip(NSTextView textView, string tooltip, nuint characterIndex)
	{
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (tooltip == null)
		{
			throw new ArgumentNullException("tooltip");
		}
		IntPtr arg = NSString.CreateNative(tooltip);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selTextView_WillDisplayToolTip_ForCharacterAtIndex_Handle, textView.Handle, arg, characterIndex)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selTextView_WillDisplayToolTip_ForCharacterAtIndex_Handle, textView.Handle, arg, characterIndex)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("textView:writeCell:atIndex:toPasteboard:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteCell(NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		if (pboard == null)
		{
			throw new ArgumentNullException("pboard");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_IntPtr(base.SuperHandle, selTextView_WriteCell_AtIndex_ToPasteboard_Type_Handle, view.Handle, cell.Handle, charIndex, pboard.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_IntPtr(base.Handle, selTextView_WriteCell_AtIndex_ToPasteboard_Type_Handle, view.Handle, cell.Handle, charIndex, pboard.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}
