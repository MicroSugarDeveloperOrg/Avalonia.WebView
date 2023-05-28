using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSharingServicePickerDelegate", WrapperType = typeof(NSSharingServicePickerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SharingServicesForItems", Selector = "sharingServicePicker:sharingServicesForItems:proposedSharingServices:", ReturnType = typeof(NSSharingService[]), ParameterType = new Type[]
{
	typeof(NSSharingServicePicker),
	typeof(NSObject[]),
	typeof(NSSharingService[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DelegateForSharingService", Selector = "sharingServicePicker:delegateForSharingService:", ReturnType = typeof(INSSharingServiceDelegate), ParameterType = new Type[]
{
	typeof(NSSharingServicePicker),
	typeof(NSSharingService)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChooseSharingService", Selector = "sharingServicePicker:didChooseSharingService:", ParameterType = new Type[]
{
	typeof(NSSharingServicePicker),
	typeof(NSSharingService)
}, ParameterByRef = new bool[] { false, false })]
public interface INSSharingServicePickerDelegate : INativeObject, IDisposable
{
}
