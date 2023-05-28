using Foundation;

namespace AppKit;

public delegate NSObject[] NSTextFieldGetCandidates(NSTextField textField, NSTextView textView, NSRange selectedRange);
