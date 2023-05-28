using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

internal sealed class MCAdvertiserAssistantDelegateWrapper : BaseWrapper, IMCAdvertiserAssistantDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MCAdvertiserAssistantDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
