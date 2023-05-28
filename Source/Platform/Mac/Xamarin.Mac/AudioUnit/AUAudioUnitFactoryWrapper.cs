using System;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

internal sealed class AUAudioUnitFactoryWrapper : BaseWrapper, IAUAudioUnitFactory, INativeObject, IDisposable, INSExtensionRequestHandling
{
	[Preserve(Conditional = true)]
	public AUAudioUnitFactoryWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("createAudioUnitWithComponentDescription:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AUAudioUnit? CreateAudioUnit(AudioComponentDescription desc, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		AUAudioUnit nSObject = Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSend_AudioComponentDescription_ref_IntPtr(base.Handle, Selector.GetHandle("createAudioUnitWithComponentDescription:error:"), desc, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("beginRequestWithExtensionContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("beginRequestWithExtensionContext:"), context.Handle);
	}
}
