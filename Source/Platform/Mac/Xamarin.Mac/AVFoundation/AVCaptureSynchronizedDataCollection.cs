using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureSynchronizedDataCollection", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class AVCaptureSynchronizedDataCollection : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizedDataForCaptureOutput_ = "synchronizedDataForCaptureOutput:";

	private static readonly IntPtr selSynchronizedDataForCaptureOutput_Handle = Selector.GetHandle("synchronizedDataForCaptureOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureSynchronizedDataCollection");

	public AVCaptureSynchronizedData this[AVCaptureOutput captureOutput] => GetSynchronizedData(captureOutput);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureSynchronizedDataCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureSynchronizedDataCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Obsolete("Use 'GetSynchronizedData' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureSynchronizedData? From(AVCaptureOutput captureOutput)
	{
		return GetSynchronizedData(captureOutput);
	}

	[Export("synchronizedDataForCaptureOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureSynchronizedData? GetSynchronizedData(AVCaptureOutput captureOutput)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVCaptureSynchronizedData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSynchronizedDataForCaptureOutput_Handle, captureOutput.Handle));
		}
		return Runtime.GetNSObject<AVCaptureSynchronizedData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSynchronizedDataForCaptureOutput_Handle, captureOutput.Handle));
	}

	[Export("objectForKeyedSubscript:")]
	[Obsolete("Use 'GetSynchronizedData' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureSynchronizedData? ObjectForKeyedSubscript(AVCaptureOutput key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVCaptureSynchronizedData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, key.Handle));
		}
		return Runtime.GetNSObject<AVCaptureSynchronizedData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, key.Handle));
	}
}
