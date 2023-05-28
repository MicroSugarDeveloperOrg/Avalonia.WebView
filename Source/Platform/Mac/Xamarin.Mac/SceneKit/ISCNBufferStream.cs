using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNBufferStream", WrapperType = typeof(SCNBufferStreamWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Length", Selector = "writeBytes:length:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
public interface ISCNBufferStream : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("writeBytes:length:")]
	[Preserve(Conditional = true)]
	void Length(IntPtr bytes, nuint length);
}
