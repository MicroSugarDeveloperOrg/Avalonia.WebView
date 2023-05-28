using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVAsynchronousKeyValueLoading", WrapperType = typeof(AVAsynchronousKeyValueLoadingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StatusOfValueForKeyerror", Selector = "statusOfValueForKey:error:", ReturnType = typeof(AVKeyValueStatus), ParameterType = new Type[]
{
	typeof(string),
	typeof(IntPtr)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadValuesAsynchronously", Selector = "loadValuesAsynchronouslyForKeys:completionHandler:", ParameterType = new Type[]
{
	typeof(string[]),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDAction)
})]
public interface IAVAsynchronousKeyValueLoading : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("statusOfValueForKey:error:")]
	[Preserve(Conditional = true)]
	AVKeyValueStatus StatusOfValueForKeyerror(string key, IntPtr outError);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	[Preserve(Conditional = true)]
	void LoadValuesAsynchronously(string[] keys, [BlockProxy(typeof(Trampolines.NIDAction))] Action? handler);
}
