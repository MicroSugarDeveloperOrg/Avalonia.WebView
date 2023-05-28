using System;
using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

internal sealed class AEAssessmentSessionDelegateWrapper : BaseWrapper, IAEAssessmentSessionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AEAssessmentSessionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
