using System;

namespace AppKit;

public delegate string NSTextViewTooltip(NSTextView textView, string tooltip, nuint characterIndex);
