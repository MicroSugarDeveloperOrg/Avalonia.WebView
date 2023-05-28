using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLMeshBufferZoneWrapper : BaseWrapper, IMDLMeshBufferZone, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MDLMeshBufferZoneWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
