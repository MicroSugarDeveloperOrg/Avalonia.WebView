using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NSCollectionLayoutSectionOrthogonalScrollingBehavior : long
{
	None,
	Continuous,
	ContinuousGroupLeadingBoundary,
	Paging,
	GroupPaging,
	GroupPagingCentered
}
