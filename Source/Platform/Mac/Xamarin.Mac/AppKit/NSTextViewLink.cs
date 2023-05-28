using System;
using Foundation;

namespace AppKit;

public delegate bool NSTextViewLink(NSTextView textView, NSObject link, nuint charIndex);
