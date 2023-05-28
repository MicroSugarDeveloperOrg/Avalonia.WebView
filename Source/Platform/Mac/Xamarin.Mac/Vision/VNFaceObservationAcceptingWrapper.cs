using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

internal sealed class VNFaceObservationAcceptingWrapper : BaseWrapper, IVNFaceObservationAccepting, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNFaceObservation[]? InputFaceObservations
	{
		[Export("inputFaceObservations", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<VNFaceObservation>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("inputFaceObservations")));
		}
		[Export("setInputFaceObservations:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setInputFaceObservations:"), nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[Preserve(Conditional = true)]
	public VNFaceObservationAcceptingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
