using System;
using ObjCRuntime;

namespace Foundation;

public static class NSStreamDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HandleEvent(this INSStreamDelegate This, NSStream theStream, NSStreamEvent streamEvent)
	{
		if (theStream == null)
		{
			throw new ArgumentNullException("theStream");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("stream:handleEvent:"), theStream.Handle, (ulong)streamEvent);
	}
}
