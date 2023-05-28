using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLAssetResolver", WrapperType = typeof(MDLAssetResolverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CanResolveAsset", Selector = "canResolveAssetNamed:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResolveAsset", Selector = "resolveAssetNamed:", ReturnType = typeof(NSUrl), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
public interface IMDLAssetResolver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("canResolveAssetNamed:")]
	[Preserve(Conditional = true)]
	bool CanResolveAsset(string name);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resolveAssetNamed:")]
	[Preserve(Conditional = true)]
	NSUrl ResolveAsset(string name);
}
