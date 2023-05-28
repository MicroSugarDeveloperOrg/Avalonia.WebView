using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTextFieldSelectCandidate(NSTextField textField, NSTextView textView, nuint index);
