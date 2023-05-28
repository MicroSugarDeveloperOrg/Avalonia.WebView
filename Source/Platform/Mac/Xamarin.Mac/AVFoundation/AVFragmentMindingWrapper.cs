using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVFragmentMindingWrapper : BaseWrapper, IAVFragmentMinding, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVFragmentMindingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
