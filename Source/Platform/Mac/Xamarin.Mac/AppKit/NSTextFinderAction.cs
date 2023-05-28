using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSTextFinderAction : long
{
	ShowFindInterface = 1L,
	NextMatch,
	PreviousMatch,
	ReplaceAll,
	Replace,
	ReplaceAndFind,
	SetSearchString,
	ReplaceAllInSelection,
	SelectAll,
	SelectAllInSelection,
	HideFindInterface,
	ShowReplaceInterface,
	HideReplaceInterface
}
