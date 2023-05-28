using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Protocol(Name = "QLPreviewItem", WrapperType = typeof(QLPreviewItemWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreviewItemURL", Selector = "previewItemURL", PropertyType = typeof(NSUrl), GetterSelector = "previewItemURL", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreviewItemTitle", Selector = "previewItemTitle", PropertyType = typeof(string), GetterSelector = "previewItemTitle", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreviewItemDisplayState", Selector = "previewItemDisplayState", PropertyType = typeof(NSObject), GetterSelector = "previewItemDisplayState", ArgumentSemantic = ArgumentSemantic.None)]
public interface IQLPreviewItem : INativeObject, IDisposable
{
}
