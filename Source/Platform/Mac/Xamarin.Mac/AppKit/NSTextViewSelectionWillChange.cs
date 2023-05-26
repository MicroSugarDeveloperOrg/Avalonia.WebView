using Foundation;

namespace AppKit;

public delegate NSValue[] NSTextViewSelectionWillChange(NSTextView textView, NSValue[] oldSelectedCharRanges, NSValue[] newSelectedCharRanges);
