using System;

namespace ObjCRuntime;

public interface INativeObject
{
	IntPtr Handle { get; }
}
