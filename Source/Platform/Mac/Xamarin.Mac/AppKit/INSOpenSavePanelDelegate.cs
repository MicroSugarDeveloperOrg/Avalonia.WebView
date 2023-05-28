using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSOpenSavePanelDelegate", WrapperType = typeof(NSOpenSavePanelDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEnableUrl", Selector = "panel:shouldEnableURL:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateUrl", Selector = "panel:validateURL:error:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(NSUrl),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeToDirectory", Selector = "panel:didChangeToDirectoryURL:", ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserEnteredFilename", Selector = "panel:userEnteredFilename:confirmed:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(string),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExpand", Selector = "panel:willExpand:", ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "panelSelectionDidChange:", ParameterType = new Type[] { typeof(NSSavePanel) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsValidFilename", Selector = "panel:isValidFilename:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DirectoryDidChange", Selector = "panel:directoryDidChange:", ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompareFilenames", Selector = "panel:compareFilename:with:caseSensitive:", ReturnType = typeof(NSComparisonResult), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(string),
	typeof(string),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowFilename", Selector = "panel:shouldShowFilename:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSavePanel),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSOpenSavePanelDelegate : INativeObject, IDisposable
{
}
