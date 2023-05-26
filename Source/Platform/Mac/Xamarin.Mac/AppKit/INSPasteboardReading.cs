using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace AppKit;

[Protocol(Name = "NSPasteboardReading", WrapperType = typeof(NSPasteboardReadingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetReadableTypesForPasteboard", Selector = "readableTypesForPasteboard:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetReadingOptionsForType", Selector = "readingOptionsForType:pasteboard:", ReturnType = typeof(NSPasteboardReadingOptions), ParameterType = new Type[]
{
    typeof(string),
    typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InitWithPasteboardPropertyList", Selector = "xamarinselector:removed:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
    typeof(NSObject),
    typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSPasteboardReading : INativeObject, IDisposable
{
    [Obsolete("It will never be called.", false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("xamarinselector:removed:")]
    [Preserve(Conditional = true)]
    NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type);
}
