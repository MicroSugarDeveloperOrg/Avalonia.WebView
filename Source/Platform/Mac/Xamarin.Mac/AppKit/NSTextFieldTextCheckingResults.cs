using Foundation;

namespace AppKit;

public delegate NSTextCheckingResult[] NSTextFieldTextCheckingResults(NSTextField textField, NSTextView textView, NSTextCheckingResult[] candidates, NSRange selectedRange);
