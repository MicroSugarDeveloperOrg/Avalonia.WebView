using System;
using Foundation;
using ObjCRuntime;

namespace GLKit;

[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Protocol(Name = "GLKNamedEffect", WrapperType = typeof(GLKNamedEffectWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrepareToDraw", Selector = "prepareToDraw")]
public interface IGLKNamedEffect : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("prepareToDraw")]
	[Preserve(Conditional = true)]
	void PrepareToDraw();
}
