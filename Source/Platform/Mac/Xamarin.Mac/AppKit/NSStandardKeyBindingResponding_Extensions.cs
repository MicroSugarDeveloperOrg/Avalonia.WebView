using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSStandardKeyBindingResponding_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertText(this INSStandardKeyBindingResponding This, NSObject insertString)
	{
		NSApplication.EnsureUIThread();
		if (insertString == null)
		{
			throw new ArgumentNullException("insertString");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertText:"), insertString.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DoCommandBySelector(this INSStandardKeyBindingResponding This, Selector selector)
	{
		NSApplication.EnsureUIThread();
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("doCommandBySelector:"), selector.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveForward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveForward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveRight(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveRight:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveBackward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveBackward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveLeft(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveLeft:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveUp(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveUp:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveDown(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveDown:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordForward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordForward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordBackward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordBackward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfParagraph(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfParagraph:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfParagraph(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfParagraph:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfDocument(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfDocument:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfDocument(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfDocument:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageDown(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageDown:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageUp(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageUp:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CenterSelectionInVisibleArea(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("centerSelectionInVisibleArea:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveBackwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveBackwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveForwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveForwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordForwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordForwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordBackwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordBackwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveUpAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveUpAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveDownAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveDownAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfLineAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfLineAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfLineAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfLineAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfParagraphAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfParagraphAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfParagraphAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfParagraphAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToEndOfDocumentAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToEndOfDocumentAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToBeginningOfDocumentAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToBeginningOfDocumentAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageDownAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageDownAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PageUpAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageUpAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveParagraphForwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveParagraphForwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveParagraphBackwardAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveParagraphBackwardAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordRight(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordRight:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordLeft(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordLeft:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveRightAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveRightAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveLeftAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveLeftAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordRightAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordRightAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveWordLeftAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveWordLeftAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToLeftEndOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToLeftEndOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToRightEndOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToRightEndOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToLeftEndOfLineAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToLeftEndOfLineAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MoveToRightEndOfLineAndModifySelection(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("moveToRightEndOfLineAndModifySelection:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollPageUp(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollPageUp:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollPageDown(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollPageDown:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollLineUp(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollLineUp:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollLineDown(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollLineDown:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollToBeginningOfDocument(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollToBeginningOfDocument:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScrollToEndOfDocument(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scrollToEndOfDocument:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Transpose(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("transpose:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TransposeWords(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("transposeWords:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectAll(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectAll:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectParagraph(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectParagraph:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectWord(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectWord:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Indent(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("indent:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertTab(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertTab:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertBacktab(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertBacktab:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertNewline(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertNewline:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertParagraphSeparator(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertParagraphSeparator:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertNewlineIgnoringFieldEditor(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertNewlineIgnoringFieldEditor:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertTabIgnoringFieldEditor(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertTabIgnoringFieldEditor:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertLineBreak(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertLineBreak:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertContainerBreak(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertContainerBreak:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertSingleQuoteIgnoringSubstitution(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertSingleQuoteIgnoringSubstitution:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void InsertDoubleQuoteIgnoringSubstitution(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("insertDoubleQuoteIgnoringSubstitution:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangeCaseOfLetter(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("changeCaseOfLetter:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UppercaseWord(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("uppercaseWord:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LowercaseWord(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("lowercaseWord:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CapitalizeWord(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("capitalizeWord:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteForward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteForward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteBackward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteBackward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteBackwardByDecomposingPreviousCharacter(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteBackwardByDecomposingPreviousCharacter:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteWordForward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteWordForward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteWordBackward(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteWordBackward:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteToBeginningOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteToBeginningOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteToEndOfLine(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteToEndOfLine:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteToBeginningOfParagraph(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteToBeginningOfParagraph:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteToEndOfParagraph(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteToEndOfParagraph:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Yank(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("yank:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Complete(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("complete:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetMark(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setMark:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteToMark(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deleteToMark:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectToMark(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("selectToMark:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SwapWithMark(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("swapWithMark:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelOperation(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cancelOperation:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeBaseWritingDirectionNatural(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeBaseWritingDirectionNatural:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeBaseWritingDirectionLeftToRight(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeBaseWritingDirectionLeftToRight:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeBaseWritingDirectionRightToLeft(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeBaseWritingDirectionRightToLeft:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeTextWritingDirectionNatural(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeTextWritingDirectionNatural:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeTextWritingDirectionLeftToRight(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeTextWritingDirectionLeftToRight:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MakeTextWritingDirectionRightToLeft(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("makeTextWritingDirectionRightToLeft:"), sender?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void QuickLookPreviewItems(this INSStandardKeyBindingResponding This, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("quickLookPreviewItems:"), sender?.Handle ?? IntPtr.Zero);
	}
}
