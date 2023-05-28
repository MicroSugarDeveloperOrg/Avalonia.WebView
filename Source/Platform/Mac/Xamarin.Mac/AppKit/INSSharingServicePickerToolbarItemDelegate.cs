using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSSharingServicePickerToolbarItemDelegate", WrapperType = typeof(NSSharingServicePickerToolbarItemDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItems", Selector = "itemsForSharingServicePickerToolbarItem:", ReturnType = typeof(NSObject[]), ParameterType = new Type[] { typeof(NSSharingServicePickerToolbarItem) }, ParameterByRef = new bool[] { false })]
public interface INSSharingServicePickerToolbarItemDelegate : INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("itemsForSharingServicePickerToolbarItem:")]
	[Preserve(Conditional = true)]
	NSObject[] GetItems(NSSharingServicePickerToolbarItem pickerToolbarItem);
}
