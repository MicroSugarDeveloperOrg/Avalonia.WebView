using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public enum ITLibPlaylistProperty
{
	Name,
	AllItemsPlaylist,
	DistinguisedKind,
	Master,
	ParentPersistentId,
	Visible,
	Items,
	Kind
}
