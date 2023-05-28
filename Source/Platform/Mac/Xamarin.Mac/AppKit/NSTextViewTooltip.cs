using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate string NSTextViewTooltip(NSTextView textView, string tooltip, nuint characterIndex);
