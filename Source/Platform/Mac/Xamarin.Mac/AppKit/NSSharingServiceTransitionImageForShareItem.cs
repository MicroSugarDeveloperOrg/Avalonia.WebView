using CoreGraphics;

namespace AppKit;

public delegate NSImage NSSharingServiceTransitionImageForShareItem(NSSharingService sharingService, NSPasteboardWriting item, CGRect contentRect);
