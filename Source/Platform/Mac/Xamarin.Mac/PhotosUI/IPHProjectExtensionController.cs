using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "PHProjectExtensionController", WrapperType = typeof(PHProjectExtensionControllerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSupportedProjectTypes", Selector = "supportedProjectTypes", ReturnType = typeof(PHProjectTypeDescription[]))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginProject", Selector = "beginProjectWithExtensionContext:projectInfo:completion:", ParameterType = new Type[]
{
	typeof(PHProjectExtensionContext),
	typeof(PHProjectInfo),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResumeProject", Selector = "resumeProjectWithExtensionContext:completion:", ParameterType = new Type[]
{
	typeof(PHProjectExtensionContext),
	typeof(Action<NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V11)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishProject", Selector = "finishProjectWithCompletionHandler:", ParameterType = new Type[] { typeof(Action) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDAction) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTypeDescriptionDataSource", Selector = "typeDescriptionDataSourceForCategory:invalidator:", ReturnType = typeof(IPHProjectTypeDescriptionDataSource), ParameterType = new Type[]
{
	typeof(NSString),
	typeof(IPHProjectTypeDescriptionInvalidator)
}, ParameterByRef = new bool[] { false, false })]
public interface IPHProjectExtensionController : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginProjectWithExtensionContext:projectInfo:completion:")]
	[Preserve(Conditional = true)]
	void BeginProject(PHProjectExtensionContext extensionContext, PHProjectInfo projectInfo, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resumeProjectWithExtensionContext:completion:")]
	[Preserve(Conditional = true)]
	void ResumeProject(PHProjectExtensionContext extensionContext, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishProjectWithCompletionHandler:")]
	[Preserve(Conditional = true)]
	void FinishProject([BlockProxy(typeof(Trampolines.NIDAction))] Action completion);
}
