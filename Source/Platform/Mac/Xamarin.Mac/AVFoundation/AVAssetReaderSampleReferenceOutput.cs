using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderSampleReferenceOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAssetReaderSampleReferenceOutput : AVAssetReaderOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderSampleReferenceOutputWithTrack_ = "assetReaderSampleReferenceOutputWithTrack:";

	private static readonly IntPtr selAssetReaderSampleReferenceOutputWithTrack_Handle = Selector.GetHandle("assetReaderSampleReferenceOutputWithTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTrack_ = "initWithTrack:";

	private static readonly IntPtr selInitWithTrack_Handle = Selector.GetHandle("initWithTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrack = "track";

	private static readonly IntPtr selTrackHandle = Selector.GetHandle("track");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderSampleReferenceOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack Track
	{
		[Export("track")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackHandle));
			}
			return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderSampleReferenceOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderSampleReferenceOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTrack:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderSampleReferenceOutput(AVAssetTrack track)
		: base(NSObjectFlag.Empty)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTrack_Handle, track.Handle), "initWithTrack:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTrack_Handle, track.Handle), "initWithTrack:");
		}
	}

	[Export("assetReaderSampleReferenceOutputWithTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReaderSampleReferenceOutput Create(AVAssetTrack track)
	{
		if (track == null)
		{
			throw new ArgumentNullException("track");
		}
		return Runtime.GetNSObject<AVAssetReaderSampleReferenceOutput>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetReaderSampleReferenceOutputWithTrack_Handle, track.Handle));
	}
}
