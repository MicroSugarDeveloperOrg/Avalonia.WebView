using Foundation;

namespace AppKit;

public delegate NSRange NSTextViewSelectionChange(NSTextView textView, NSRange oldSelectedCharRange, NSRange newSelectedCharRange);
