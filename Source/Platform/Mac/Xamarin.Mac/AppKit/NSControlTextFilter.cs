using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate string[] NSControlTextFilter(NSControl control, NSTextView textView, string[] words, NSRange charRange, ref nint index);
