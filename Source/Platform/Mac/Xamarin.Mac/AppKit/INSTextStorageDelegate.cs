using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSTextStorageDelegate", WrapperType = typeof(NSTextStorageDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextStorageWillProcessEditing", Selector = "textStorageWillProcessEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextStorageDidProcessEditing", Selector = "textStorageDidProcessEditing:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillProcessEditing", Selector = "textStorage:willProcessEditing:range:changeInLength:", ParameterType = new Type[]
{
	typeof(NSTextStorage),
	typeof(NSTextStorageEditActions),
	typeof(NSRange),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProcessEditing", Selector = "textStorage:didProcessEditing:range:changeInLength:", ParameterType = new Type[]
{
	typeof(NSTextStorage),
	typeof(NSTextStorageEditActions),
	typeof(NSRange),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSTextStorageDelegate : INativeObject, IDisposable
{
}
