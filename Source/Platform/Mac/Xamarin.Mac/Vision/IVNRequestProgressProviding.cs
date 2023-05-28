using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "VNRequestProgressProviding", WrapperType = typeof(VNRequestProgressProvidingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProgressHandler", Selector = "progressHandler", PropertyType = typeof(VNRequestProgressHandler), GetterSelector = "progressHandler", SetterSelector = "setProgressHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDVNRequestProgressHandler) }, ReturnTypeDelegateProxy = typeof(Trampolines.SDVNRequestProgressHandler))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Indeterminate", Selector = "indeterminate", PropertyType = typeof(bool), GetterSelector = "indeterminate", ArgumentSemantic = ArgumentSemantic.None)]
public interface IVNRequestProgressProviding : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	VNRequestProgressHandler ProgressHandler
	{
		[Export("progressHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDVNRequestProgressHandler))]
		get;
		[Export("setProgressHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDVNRequestProgressHandler))]
		set;
	}

	[Preserve(Conditional = true)]
	bool Indeterminate
	{
		[Export("indeterminate")]
		get;
	}
}
