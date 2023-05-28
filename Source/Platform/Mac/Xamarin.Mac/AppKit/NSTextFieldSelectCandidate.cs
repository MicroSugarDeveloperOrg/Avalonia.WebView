using System;

namespace AppKit;

public delegate bool NSTextFieldSelectCandidate(NSTextField textField, NSTextView textView, nuint index);
