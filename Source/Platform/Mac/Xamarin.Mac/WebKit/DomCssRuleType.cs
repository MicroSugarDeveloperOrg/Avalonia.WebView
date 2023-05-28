using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public enum DomCssRuleType : ushort
{
	Unknown,
	Style,
	Charset,
	Import,
	Media,
	FontFace,
	Page,
	Variables,
	WebKitKeyFrames,
	WebKitKeyFrame,
	NamespaceRule
}
