using Foundation;

namespace AppKit;

public delegate NSWindow NSSharingServiceSourceWindowForShareItems(NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope);
