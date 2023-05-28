using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTextViewDelegate", WrapperType = typeof(NSTextViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkClicked", Selector = "textView:clickedOnLink:atIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSObject),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellClicked", Selector = "textView:clickedOnCell:inRect:atIndex:", ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextAttachmentCell),
	typeof(CGRect),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellDoubleClicked", Selector = "textView:doubleClickedOnCell:inRect:atIndex:", ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextAttachmentCell),
	typeof(CGRect),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritablePasteboardTypes", Selector = "textView:writablePasteboardTypesForCell:atIndex:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextAttachmentCell),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteCell", Selector = "textView:writeCell:atIndex:toPasteboard:type:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextAttachmentCell),
	typeof(nuint),
	typeof(NSPasteboard),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeSelection", Selector = "textView:willChangeSelectionFromCharacterRange:toCharacterRange:", ReturnType = typeof(NSRange), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeSelectionFromRanges", Selector = "textView:willChangeSelectionFromCharacterRanges:toCharacterRanges:", ReturnType = typeof(NSValue[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSValue[]),
	typeof(NSValue[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRanges", Selector = "textView:shouldChangeTextInRanges:replacementStrings:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSValue[]),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTypingAttributes", Selector = "textView:shouldChangeTypingAttributes:toAttributes:", ReturnType = typeof(NSDictionary), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSDictionary),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSelection", Selector = "textViewDidChangeSelection:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeTypingAttributes", Selector = "textViewDidChangeTypingAttributes:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayToolTip", Selector = "textView:willDisplayToolTip:forCharacterAtIndex:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(string),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCompletions", Selector = "textView:completions:forPartialWordRange:indexOfSelectedItem:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(string[]),
	typeof(NSRange),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRange", Selector = "textView:shouldChangeTextInRange:replacementString:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSRange),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DoCommandBySelector", Selector = "textView:doCommandBySelector:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(Selector)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSetSpellingState", Selector = "textView:shouldSetSpellingState:range:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(nint),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuForEvent", Selector = "textView:menu:forEvent:atIndex:", ReturnType = typeof(NSMenu), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSMenu),
	typeof(NSEvent),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCheckText", Selector = "textView:willCheckTextInRange:options:types:", ReturnType = typeof(NSDictionary), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSRange),
	typeof(NSDictionary),
	typeof(NSTextCheckingTypes)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCheckText", Selector = "textView:didCheckTextInRange:types:options:results:orthography:wordCount:", ReturnType = typeof(NSTextCheckingResult[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSRange),
	typeof(NSTextCheckingTypes),
	typeof(NSDictionary),
	typeof(NSTextCheckingResult[]),
	typeof(NSOrthography),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggedCell", Selector = "textView:draggedCell:inRect:event:", ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextAttachmentCell),
	typeof(CGRect),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUndoManager", Selector = "undoManagerForTextView:", ReturnType = typeof(NSUndoManager), ParameterType = new Type[] { typeof(NSTextView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldUpdateTouchBarItemIdentifiers", Selector = "textView:shouldUpdateTouchBarItemIdentifiers:", ReturnType = typeof(string[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCandidates", Selector = "textView:candidatesForSelectedRange:", ReturnType = typeof(NSObject[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTextCheckingCandidates", Selector = "textView:candidates:forSelectedRange:", ReturnType = typeof(NSTextCheckingResult[]), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(NSTextCheckingResult[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectCandidates", Selector = "textView:shouldSelectCandidateAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTextView),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
public interface INSTextViewDelegate : INativeObject, IDisposable, INSTextDelegate
{
}
