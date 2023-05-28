using System;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCloudSharingValidation", WrapperType = typeof(NSCloudSharingValidationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCloudShare", Selector = "cloudShareForUserInterfaceItem:", ReturnType = typeof(CKShare), ParameterType = new Type[] { typeof(INSValidatedUserInterfaceItem) }, ParameterByRef = new bool[] { false })]
public interface INSCloudSharingValidation : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cloudShareForUserInterfaceItem:")]
	[Preserve(Conditional = true)]
	CKShare? GetCloudShare(INSValidatedUserInterfaceItem item);
}
