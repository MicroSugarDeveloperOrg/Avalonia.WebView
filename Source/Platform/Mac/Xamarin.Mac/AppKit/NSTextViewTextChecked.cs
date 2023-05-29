using Foundation;

namespace AppKit;

public delegate NSTextCheckingResult[] NSTextViewTextChecked(NSTextView view, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, NSTextCheckingResult[] results, NSOrthography orthography, long wordCount);
