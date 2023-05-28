using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPasteboardWriting", WrapperType = typeof(NSPasteboardWritingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritableTypesForPasteboard", Selector = "writableTypesForPasteboard:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWritingOptionsForType", Selector = "writingOptionsForType:pasteboard:", ReturnType = typeof(NSPasteboardWritingOptions), ParameterType = new Type[]
{
	typeof(string),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPasteboardPropertyListForType", Selector = "pasteboardPropertyListForType:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
public interface INSPasteboardWriting : INativeObject, IDisposable
{
}
