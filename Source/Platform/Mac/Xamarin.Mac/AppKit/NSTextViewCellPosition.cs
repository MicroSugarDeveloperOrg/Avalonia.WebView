using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate string[] NSTextViewCellPosition(NSTextView view, NSTextAttachmentCell forCell, nuint charIndex);
