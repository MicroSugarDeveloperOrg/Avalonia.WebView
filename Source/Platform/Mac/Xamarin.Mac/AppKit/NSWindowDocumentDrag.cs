using CoreGraphics;

namespace AppKit;

public delegate bool NSWindowDocumentDrag(NSWindow window, NSEvent theEvent, CGPoint dragImageLocation, NSPasteboard withPasteboard);
