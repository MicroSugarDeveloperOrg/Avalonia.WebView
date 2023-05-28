using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVAsynchronousKeyValueLoading", false)]
[Model]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public abstract class AVAsynchronousKeyValueLoading : NSObject, IAVAsynchronousKeyValueLoading, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected AVAsynchronousKeyValueLoading()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAsynchronousKeyValueLoading(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAsynchronousKeyValueLoading(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void LoadValuesAsynchronously(string[] keys, [BlockProxy(typeof(Trampolines.NIDAction))] Action? handler);

	[Export("statusOfValueForKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract AVKeyValueStatus StatusOfValueForKeyerror(string key, IntPtr outError);
}
