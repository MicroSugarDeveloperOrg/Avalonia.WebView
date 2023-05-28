using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MLWritable", WrapperType = typeof(MLWritableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Write", Selector = "writeToURL:error:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
public interface IMLWritable : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("writeToURL:error:")]
	[Preserve(Conditional = true)]
	bool Write(NSUrl url, out NSError? error);
}
