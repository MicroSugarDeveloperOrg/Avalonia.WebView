using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreML;

public static class MLCustomLayer_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Encode(this IMLCustomLayer This, IMTLCommandBuffer commandBuffer, IMTLTexture[] inputs, IMTLTexture[] outputs, out NSError? error)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (inputs == null)
		{
			throw new ArgumentNullException("inputs");
		}
		if (outputs == null)
		{
			throw new ArgumentNullException("outputs");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(inputs);
		NSArray nSArray2 = NSArray.FromNSObjects(outputs);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("encodeToCommandBuffer:inputs:outputs:error:"), commandBuffer.Handle, nSArray.Handle, nSArray2.Handle, ref arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
