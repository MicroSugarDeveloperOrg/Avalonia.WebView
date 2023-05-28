using System;
using Foundation;

namespace AppKit;

public delegate nint NSTextViewSpellingQuery(NSTextView textView, nint value, NSRange affectedCharRange);
