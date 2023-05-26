using Foundation;

namespace AppKit;

public delegate NSComparisonResult NSOpenSaveCompare(NSSavePanel panel, string name1, string name2, bool caseSensitive);
