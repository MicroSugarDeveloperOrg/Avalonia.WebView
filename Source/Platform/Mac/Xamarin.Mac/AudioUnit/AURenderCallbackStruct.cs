using System;

namespace AudioUnit;

internal struct AURenderCallbackStruct
{
	public RenderCallbackShared Proc;

	public IntPtr ProcRefCon;
}
