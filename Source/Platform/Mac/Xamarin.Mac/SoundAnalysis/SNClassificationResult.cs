using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

[Register("SNClassificationResult", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class SNClassificationResult : NSObject, ISNResult, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassifications = "classifications";

	private static readonly IntPtr selClassificationsHandle = Selector.GetHandle("classifications");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRange = "timeRange";

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SNClassificationResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SNClassification[] Classifications
	{
		[Export("classifications")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SNClassification>(Messaging.IntPtr_objc_msgSend(base.Handle, selClassificationsHandle));
			}
			return NSArray.ArrayFromHandle<SNClassification>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassificationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SNClassificationResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SNClassificationResult(IntPtr handle)
		: base(handle)
	{
	}
}
