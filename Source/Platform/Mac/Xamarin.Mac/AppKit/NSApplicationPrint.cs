using Foundation;

namespace AppKit;

public delegate NSApplicationPrintReply NSApplicationPrint(NSApplication application, string[] fileNames, NSDictionary printSettings, bool showPrintPanels);
