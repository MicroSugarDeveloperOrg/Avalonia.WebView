using System;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCloudSharingServiceDelegate", WrapperType = typeof(NSCloudSharingServiceDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Completed", Selector = "sharingService:didCompleteForItems:error:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSObject[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Options", Selector = "optionsForSharingService:shareProvider:", ReturnType = typeof(NSCloudKitSharingServiceOptions), ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSItemProvider)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Saved", Selector = "sharingService:didSaveShare:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(CKShare)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Stopped", Selector = "sharingService:didStopSharing:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(CKShare)
}, ParameterByRef = new bool[] { false, false })]
public interface INSCloudSharingServiceDelegate : INativeObject, IDisposable, INSSharingServiceDelegate
{
}
