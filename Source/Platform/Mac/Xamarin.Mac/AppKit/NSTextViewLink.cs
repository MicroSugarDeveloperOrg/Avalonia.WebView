using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTextViewLink(NSTextView textView, NSObject link, nuint charIndex);
