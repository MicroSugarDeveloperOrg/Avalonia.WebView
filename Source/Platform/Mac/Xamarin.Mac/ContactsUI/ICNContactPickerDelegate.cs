using System;
using Contacts;
using Foundation;
using ObjCRuntime;

namespace ContactsUI;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "CNContactPickerDelegate", WrapperType = typeof(CNContactPickerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContactSelected", Selector = "contactPicker:didSelectContact:", ParameterType = new Type[]
{
	typeof(CNContactPicker),
	typeof(CNContact)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContactPropertySelected", Selector = "contactPicker:didSelectContactProperty:", ParameterType = new Type[]
{
	typeof(CNContactPicker),
	typeof(CNContactProperty)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClose", Selector = "contactPickerWillClose:", ParameterType = new Type[] { typeof(CNContactPicker) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "contactPickerDidClose:", ParameterType = new Type[] { typeof(CNContactPicker) }, ParameterByRef = new bool[] { false })]
public interface ICNContactPickerDelegate : INativeObject, IDisposable
{
}
