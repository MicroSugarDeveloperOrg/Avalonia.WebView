using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTFontUIFontType : uint
{
	None = uint.MaxValue,
	User = 0u,
	UserFixedPitch = 1u,
	System = 2u,
	EmphasizedSystem = 3u,
	SmallSystem = 4u,
	SmallEmphasizedSystem = 5u,
	MiniSystem = 6u,
	MiniEmphasizedSystem = 7u,
	Views = 8u,
	Application = 9u,
	Label = 10u,
	MenuTitle = 11u,
	MenuItem = 12u,
	MenuItemMark = 13u,
	MenuItemCmdKey = 14u,
	WindowTitle = 15u,
	PushButton = 16u,
	UtilityWindowTitle = 17u,
	AlertHeader = 18u,
	SystemDetail = 19u,
	EmphasizedSystemDetail = 20u,
	Toolbar = 21u,
	SmallToolbar = 22u,
	Message = 23u,
	Palette = 24u,
	ToolTip = 25u,
	ControlContent = 26u
}
