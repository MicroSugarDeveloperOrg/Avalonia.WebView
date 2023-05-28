using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "PHProjectTypeDescriptionInvalidator", WrapperType = typeof(PHProjectTypeDescriptionInvalidatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateTypeDescription", Selector = "invalidateTypeDescriptionForProjectType:", ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateFooterTextForSubtypes", Selector = "invalidateFooterTextForSubtypesOfProjectType:", ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
public interface IPHProjectTypeDescriptionInvalidator : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("invalidateTypeDescriptionForProjectType:")]
	[Preserve(Conditional = true)]
	void InvalidateTypeDescription(NSString projectType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("invalidateFooterTextForSubtypesOfProjectType:")]
	[Preserve(Conditional = true)]
	void InvalidateFooterTextForSubtypes(NSString projectType);
}
