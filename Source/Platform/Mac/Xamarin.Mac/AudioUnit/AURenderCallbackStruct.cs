using System;

namespace AudioUnit;

internal struct AURenderCallbackStruct
{
	public Delegate Proc;

	public IntPtr ProcRefCon;
}
