using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

internal sealed class AVAudioMixingWrapper : BaseWrapper, IAVAudioMixing, INativeObject, IDisposable, IAVAudio3DMixing, IAVAudioStereoMixing
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Volume
	{
		[Export("volume")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("volume"));
		}
		[Export("setVolume:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setVolume:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm
	{
		[Export("renderingAlgorithm")]
		get
		{
			return (AVAudio3DMixingRenderingAlgorithm)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("renderingAlgorithm"));
		}
		[Export("setRenderingAlgorithm:")]
		set
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, Selector.GetHandle("setRenderingAlgorithm:"), (long)value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public float Rate
	{
		[Export("rate")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("rate"));
		}
		[Export("setRate:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setRate:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public float ReverbBlend
	{
		[Export("reverbBlend")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("reverbBlend"));
		}
		[Export("setReverbBlend:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setReverbBlend:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public float Obstruction
	{
		[Export("obstruction")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("obstruction"));
		}
		[Export("setObstruction:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setObstruction:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public float Occlusion
	{
		[Export("occlusion")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("occlusion"));
		}
		[Export("setOcclusion:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setOcclusion:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public Vector3 Position
	{
		[Export("position")]
		get
		{
			return Messaging.Vector3_objc_msgSend(base.Handle, Selector.GetHandle("position"));
		}
		[Export("setPosition:")]
		set
		{
			Messaging.void_objc_msgSend_Vector3(base.Handle, Selector.GetHandle("setPosition:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public float Pan
	{
		[Export("pan")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("pan"));
		}
		[Export("setPan:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setPan:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public AVAudioMixingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
