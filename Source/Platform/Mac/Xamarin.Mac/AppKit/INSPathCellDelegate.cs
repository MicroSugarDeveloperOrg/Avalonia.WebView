using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPathCellDelegate", WrapperType = typeof(NSPathCellDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayOpenPanel", Selector = "pathCell:willDisplayOpenPanel:", ParameterType = new Type[]
{
	typeof(NSPathCell),
	typeof(NSOpenPanel)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPopupMenu", Selector = "pathCell:willPopUpMenu:", ParameterType = new Type[]
{
	typeof(NSPathCell),
	typeof(NSMenu)
}, ParameterByRef = new bool[] { false, false })]
public interface INSPathCellDelegate : INativeObject, IDisposable
{
}
