using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "PHProjectTypeDescriptionDataSource", WrapperType = typeof(PHProjectTypeDescriptionDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSubtypes", Selector = "subtypesForProjectType:", ReturnType = typeof(PHProjectTypeDescription[]), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTypeDescription", Selector = "typeDescriptionForProjectType:", ReturnType = typeof(PHProjectTypeDescription), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFooterTextForSubtypes", Selector = "footerTextForSubtypesOfProjectType:", ReturnType = typeof(NSAttributedString), ParameterType = new Type[] { typeof(NSString) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDiscardDataSource", Selector = "extensionWillDiscardDataSource")]
public interface IPHProjectTypeDescriptionDataSource : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("subtypesForProjectType:")]
	[Preserve(Conditional = true)]
	PHProjectTypeDescription[] GetSubtypes(NSString projectType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("typeDescriptionForProjectType:")]
	[Preserve(Conditional = true)]
	PHProjectTypeDescription? GetTypeDescription(NSString projectType);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("footerTextForSubtypesOfProjectType:")]
	[Preserve(Conditional = true)]
	NSAttributedString? GetFooterTextForSubtypes(NSString projectType);
}
