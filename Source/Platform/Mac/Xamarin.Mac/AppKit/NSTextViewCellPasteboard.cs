using System;

namespace AppKit;

public delegate bool NSTextViewCellPasteboard(NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type);
