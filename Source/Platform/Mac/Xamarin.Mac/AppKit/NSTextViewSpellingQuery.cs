using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate nint NSTextViewSpellingQuery(NSTextView textView, nint value, NSRange affectedCharRange);
