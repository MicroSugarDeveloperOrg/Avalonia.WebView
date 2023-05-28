using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

internal sealed class AVAudio3DMixingWrapper : BaseWrapper, IAVAudio3DMixing, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Preserve(Conditional = true)]
	public AVAudio3DMixingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
