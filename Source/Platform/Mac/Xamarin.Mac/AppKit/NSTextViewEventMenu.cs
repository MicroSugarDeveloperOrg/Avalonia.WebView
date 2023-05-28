using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate NSMenu NSTextViewEventMenu(NSTextView view, NSMenu menu, NSEvent theEvent, nuint charIndex);
