using CoreGraphics;

namespace AppKit;

public delegate NSImage NSSharingServiceTransitionImageForShareItem(NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect);
