using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTextViewCellPasteboard(NSTextView view, NSTextAttachmentCell cell, nuint charIndex, NSPasteboard pboard, string type);
