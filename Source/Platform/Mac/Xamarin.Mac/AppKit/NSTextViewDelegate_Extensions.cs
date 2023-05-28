using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSTextViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool LinkClicked(this INSTextViewDelegate This, NSTextView textView, NSObject link, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (link == null)
		{
			throw new ArgumentNullException("link");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("textView:clickedOnLink:atIndex:"), textView.Handle, link.Handle, charIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CellClicked(this INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_nuint(This.Handle, Selector.GetHandle("textView:clickedOnCell:inRect:atIndex:"), textView.Handle, cell.Handle, cellFrame, charIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CellDoubleClicked(this INSTextViewDelegate This, NSTextView textView, NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (cell == null)
		{
			throw new ArgumentNullException("cell");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_nuint(This.Handle, Selector.GetHandle("textView:doubleClickedOnCell:inRect:atIndex:"), textView.Handle, cell.Handle, cellFrame, charIndex);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetWritablePasteboardTypes(this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell forCell, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (forCell == null)
		{
			throw new ArgumentNullException("forCell");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("textView:writablePasteboardTypesForCell:atIndex:"), view.Handle, forCell.Handle, charIndex));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteCell(this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type)
	{
		NSApplication.EnsureUIThread();
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
		IntPtr intPtr = NSString.CreateNative(type);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:writeCell:atIndex:toPasteboard:type:"), view.Handle, cell.Handle, charIndex, pboard.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRange WillChangeSelection(this INSTextViewDelegate This, NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return Messaging.NSRange_objc_msgSend_IntPtr_NSRange_NSRange(This.Handle, Selector.GetHandle("textView:willChangeSelectionFromCharacterRange:toCharacterRange:"), textView.Handle, oldSelectedCharRange, newSelectedCharRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValue[] WillChangeSelectionFromRanges(this INSTextViewDelegate This, NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges)
	{
		NSApplication.EnsureUIThread();
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
		NSValue[] result = NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:"), textView.Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldChangeTextInRanges(this INSTextViewDelegate This, NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings)
	{
		NSApplication.EnsureUIThread();
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
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:shouldChangeTextInRanges:replacementStrings:"), textView.Handle, nSArray.Handle, nSArray2.Handle);
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary ShouldChangeTypingAttributes(this INSTextViewDelegate This, NSTextView textView, NSDictionary oldTypingAttributes, NSDictionary newTypingAttributes)
	{
		NSApplication.EnsureUIThread();
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
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:shouldChangeTypingAttributes:toAttributes:"), textView.Handle, oldTypingAttributes.Handle, newTypingAttributes.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeSelection(this INSTextViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textViewDidChangeSelection:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeTypingAttributes(this INSTextViewDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textViewDidChangeTypingAttributes:"), notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string? WillDisplayToolTip(this INSTextViewDelegate This, NSTextView textView, string tooltip, nuint characterIndex)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (tooltip == null)
		{
			throw new ArgumentNullException("tooltip");
		}
		IntPtr intPtr = NSString.CreateNative(tooltip);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("textView:willDisplayToolTip:forCharacterAtIndex:"), textView.Handle, intPtr, characterIndex));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetCompletions(this INSTextViewDelegate This, NSTextView textView, string[] words, NSRange charRange, ref nint index)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (words == null)
		{
			throw new ArgumentNullException("words");
		}
		NSArray nSArray = NSArray.FromStrings(words);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange_ref_nint(This.Handle, Selector.GetHandle("textView:completions:forPartialWordRange:indexOfSelectedItem:"), textView.Handle, nSArray.Handle, charRange, ref index));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldChangeTextInRange(this INSTextViewDelegate This, NSTextView textView, NSRange affectedCharRange, string replacementString)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr intPtr = NSString.CreateNative(replacementString);
		bool result = Messaging.bool_objc_msgSend_IntPtr_NSRange_IntPtr(This.Handle, Selector.GetHandle("textView:shouldChangeTextInRange:replacementString:"), textView.Handle, affectedCharRange, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool DoCommandBySelector(this INSTextViewDelegate This, NSTextView textView, Selector commandSelector)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (commandSelector == null)
		{
			throw new ArgumentNullException("commandSelector");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:doCommandBySelector:"), textView.Handle, commandSelector.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint ShouldSetSpellingState(this INSTextViewDelegate This, NSTextView textView, nint value, NSRange affectedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return Messaging.nint_objc_msgSend_IntPtr_nint_NSRange(This.Handle, Selector.GetHandle("textView:shouldSetSpellingState:range:"), textView.Handle, value, affectedCharRange);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMenu MenuForEvent(this INSTextViewDelegate This, NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
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
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("textView:menu:forEvent:atIndex:"), view.Handle, menu.Handle, theEvent.Handle, charIndex));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDictionary WillCheckText(this INSTextViewDelegate This, NSTextView view, NSRange range, NSDictionary options, NSTextCheckingTypes checkingTypes)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_IntPtr_UInt64(This.Handle, Selector.GetHandle("textView:willCheckTextInRange:options:types:"), view.Handle, range, options.Handle, (ulong)checkingTypes));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult[] DidCheckText(this INSTextViewDelegate This, NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, nint wordCount)
	{
		NSApplication.EnsureUIThread();
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
		NSTextCheckingResult[] result = NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_IntPtr_IntPtr_nint(This.Handle, Selector.GetHandle("textView:didCheckTextInRange:types:options:results:orthography:wordCount:"), view.Handle, range, (ulong)checkingTypes, options.Handle, nSArray.Handle, orthography.Handle, wordCount));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DraggedCell(this INSTextViewDelegate This, NSTextView view, NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
	{
		NSApplication.EnsureUIThread();
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr(This.Handle, Selector.GetHandle("textView:draggedCell:inRect:event:"), view.Handle, cell.Handle, rect, theevent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUndoManager GetUndoManager(this INSTextViewDelegate This, NSTextView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("undoManagerForTextView:"), view.Handle));
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ShouldUpdateTouchBarItemIdentifiers(this INSTextViewDelegate This, NSTextView textView, string[] identifiers)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("textView:shouldUpdateTouchBarItemIdentifiers:"), textView.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[]? GetCandidates(this INSTextViewDelegate This, NSTextView textView, NSRange selectedRange)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("textView:candidatesForSelectedRange:"), textView.Handle, selectedRange));
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult[] GetTextCheckingCandidates(this INSTextViewDelegate This, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (candidates == null)
		{
			throw new ArgumentNullException("candidates");
		}
		NSArray nSArray = NSArray.FromNSObjects(candidates);
		NSTextCheckingResult[] result = NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_NSRange(This.Handle, Selector.GetHandle("textView:candidates:forSelectedRange:"), textView.Handle, nSArray.Handle, selectedRange));
		nSArray.Dispose();
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldSelectCandidates(this INSTextViewDelegate This, NSTextView textView, nuint index)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		return Messaging.bool_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("textView:shouldSelectCandidateAtIndex:"), textView.Handle, index);
	}
}
