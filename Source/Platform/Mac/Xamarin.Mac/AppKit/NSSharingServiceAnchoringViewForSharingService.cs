using CoreGraphics;

namespace AppKit;

public delegate NSView NSSharingServiceAnchoringViewForSharingService(NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge);
