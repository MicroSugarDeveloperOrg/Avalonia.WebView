using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSCollectionViewSectionHeaderView", WrapperType = typeof(NSCollectionViewSectionHeaderViewWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SectionCollapseButton", Selector = "sectionCollapseButton", PropertyType = typeof(NSButton), GetterSelector = "sectionCollapseButton", SetterSelector = "setSectionCollapseButton:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface INSCollectionViewSectionHeaderView : INativeObject, IDisposable, INSCollectionViewElement, INSUserInterfaceItemIdentification
{
}
