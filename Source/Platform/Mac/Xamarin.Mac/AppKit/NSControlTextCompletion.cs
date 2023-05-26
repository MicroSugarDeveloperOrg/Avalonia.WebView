using Foundation;

namespace AppKit;

public delegate string[] NSControlTextCompletion(NSControl control, NSTextView textView, string[] words, NSRange charRange, long index);
