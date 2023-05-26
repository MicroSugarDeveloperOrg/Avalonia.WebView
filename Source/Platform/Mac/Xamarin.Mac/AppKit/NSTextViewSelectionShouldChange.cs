using Foundation;

namespace AppKit;

public delegate bool NSTextViewSelectionShouldChange(NSTextView textView, NSValue[] affectedRanges, string[] replacementStrings);
