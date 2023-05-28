using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVPlayerItemMetadataCollectorPushDelegateWrapper : BaseWrapper, IAVPlayerItemMetadataCollectorPushDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVPlayerItemMetadataCollectorPushDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("metadataCollector:didCollectDateRangeMetadataGroups:indexesOfNewGroups:indexesOfModifiedGroups:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidCollectDateRange(AVPlayerItemMetadataCollector metadataCollector, AVDateRangeMetadataGroup[] metadataGroups, NSIndexSet indexesOfNewGroups, NSIndexSet indexesOfModifiedGroups)
	{
		if (metadataCollector == null)
		{
			throw new ArgumentNullException("metadataCollector");
		}
		if (metadataGroups == null)
		{
			throw new ArgumentNullException("metadataGroups");
		}
		if (indexesOfNewGroups == null)
		{
			throw new ArgumentNullException("indexesOfNewGroups");
		}
		if (indexesOfModifiedGroups == null)
		{
			throw new ArgumentNullException("indexesOfModifiedGroups");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataGroups);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("metadataCollector:didCollectDateRangeMetadataGroups:indexesOfNewGroups:indexesOfModifiedGroups:"), metadataCollector.Handle, nSArray.Handle, indexesOfNewGroups.Handle, indexesOfModifiedGroups.Handle);
		nSArray.Dispose();
	}
}
