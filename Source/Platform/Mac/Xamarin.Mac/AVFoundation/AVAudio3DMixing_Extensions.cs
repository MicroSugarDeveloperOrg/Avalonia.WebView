using ObjCRuntime;

namespace AVFoundation;

public static class AVAudio3DMixing_Extensions
{
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudio3DMixingSourceMode GetSourceMode(this IAVAudio3DMixing This)
	{
		return (AVAudio3DMixingSourceMode)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("sourceMode"));
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSourceMode(this IAVAudio3DMixing This, AVAudio3DMixingSourceMode sourceMode)
	{
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setSourceMode:"), (long)sourceMode);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudio3DMixingPointSourceInHeadMode GetPointSourceInHeadMode(this IAVAudio3DMixing This)
	{
		return (AVAudio3DMixingPointSourceInHeadMode)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("pointSourceInHeadMode"));
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetPointSourceInHeadMode(this IAVAudio3DMixing This, AVAudio3DMixingPointSourceInHeadMode pointSourceInHeadMode)
	{
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setPointSourceInHeadMode:"), (long)pointSourceInHeadMode);
	}
}
