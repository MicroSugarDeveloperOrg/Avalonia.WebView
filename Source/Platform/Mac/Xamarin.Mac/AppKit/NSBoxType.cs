using Foundation;
using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSBoxType : ulong
{
	NSBoxPrimary,
	[Advice("Identical to 'NSBoxPrimary'.")]
	NSBoxSecondary,
	NSBoxSeparator,
	[Advice("'NSBoxOldStyle' is discouraged. Use 'NSBoxPrimary' or 'NSBoxCustom'.")]
	NSBoxOldStyle,
	NSBoxCustom
}
