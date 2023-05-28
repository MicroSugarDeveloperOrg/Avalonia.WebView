using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVPlayerItemLegibleOutputPushDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerItemLegibleOutputPushDelegate : AVPlayerItemOutputPushDelegate, IAVPlayerItemLegibleOutputPushDelegate, INativeObject, IDisposable, IAVPlayerItemOutputPushDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemLegibleOutputPushDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerItemLegibleOutputPushDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemLegibleOutputPushDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("legibleOutput:didOutputAttributedStrings:nativeSampleBuffers:forItemTime:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOutputAttributedStrings(AVPlayerItemLegibleOutput output, NSAttributedString[] strings, CMSampleBuffer[] nativeSamples, CMTime itemTime)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
