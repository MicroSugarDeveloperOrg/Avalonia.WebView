using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSCollectionElementCategory : long
{
    Item,
    SupplementaryView,
    DecorationView,
    InterItemGap
}
