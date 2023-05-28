using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSharingServicePickerTouchBarItemDelegate", WrapperType = typeof(NSSharingServicePickerTouchBarItemDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ItemsForSharingServicePickerTouchBarItem", Selector = "itemsForSharingServicePickerTouchBarItem:", ReturnType = typeof(INSPasteboardWriting[]), ParameterType = new Type[] { typeof(NSSharingServicePickerTouchBarItem) }, ParameterByRef = new bool[] { false })]
public interface INSSharingServicePickerTouchBarItemDelegate : INativeObject, IDisposable, INSSharingServicePickerDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("itemsForSharingServicePickerTouchBarItem:")]
	[Preserve(Conditional = true)]
	INSPasteboardWriting[] ItemsForSharingServicePickerTouchBarItem(NSSharingServicePickerTouchBarItem pickerTouchBarItem);
}
