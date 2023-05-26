using Foundation;

namespace AppKit;

public delegate bool NSTextViewChangeText(NSTextView textView, NSRange affectedCharRange, string replacementString);
