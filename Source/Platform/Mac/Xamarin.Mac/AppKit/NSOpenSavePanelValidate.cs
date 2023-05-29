using Foundation;

namespace AppKit;

public delegate bool NSOpenSavePanelValidate(NSSavePanel panel, NSUrl url, out NSError outError);
