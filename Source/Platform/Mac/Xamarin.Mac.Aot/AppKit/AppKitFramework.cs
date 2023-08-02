using System.Runtime.InteropServices;

namespace AppKit;

public class AppKitFramework
{
	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	public static extern void NSBeep();
}
