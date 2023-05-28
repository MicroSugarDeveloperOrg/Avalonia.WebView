using System;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVQueuedSampleBufferRenderingWrapper : BaseWrapper, IAVQueuedSampleBufferRendering, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CMTimebase Timebase
	{
		[Export("timebase", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("timebase"));
			return (intPtr == IntPtr.Zero) ? null : new CMTimebase(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ReadyForMoreMediaData
	{
		[Export("isReadyForMoreMediaData")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isReadyForMoreMediaData"));
		}
	}

	[Preserve(Conditional = true)]
	public AVQueuedSampleBufferRenderingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("enqueueSampleBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Enqueue(CMSampleBuffer sampleBuffer)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("enqueueSampleBuffer:"), sampleBuffer.Handle);
	}

	[Export("flush")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Flush()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("flush"));
	}

	[Export("requestMediaDataWhenReadyOnQueue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void RequestMediaData(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("requestMediaDataWhenReadyOnQueue:usingBlock:"), queue.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("stopRequestingMediaData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StopRequestingMediaData()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("stopRequestingMediaData"));
	}
}
