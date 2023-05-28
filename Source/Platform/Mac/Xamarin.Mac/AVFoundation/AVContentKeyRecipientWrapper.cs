using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVContentKeyRecipientWrapper : BaseWrapper, IAVContentKeyRecipient, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool MayRequireContentKeysForMediaDataProcessing
	{
		[Export("mayRequireContentKeysForMediaDataProcessing")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("mayRequireContentKeysForMediaDataProcessing"));
		}
	}

	[Preserve(Conditional = true)]
	public AVContentKeyRecipientWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
