using Foundation;

namespace AppKit;

public delegate NSTextCheckingResult[] NSTextViewTextCheckingResults(NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange);
