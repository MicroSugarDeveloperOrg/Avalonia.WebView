using Foundation;

namespace AppKit;

public delegate string[] NSTextViewCompletion(NSTextView textView, string[] words, NSRange charRange, long index);
