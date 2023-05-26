using CoreGraphics;
using Foundation;

namespace AppKit;

public delegate void NSTextLayoutEnumerateLineFragments(CGRect rect, CGRect usedRectangle, NSTextContainer textContainer, NSRange glyphRange, out bool stop);
