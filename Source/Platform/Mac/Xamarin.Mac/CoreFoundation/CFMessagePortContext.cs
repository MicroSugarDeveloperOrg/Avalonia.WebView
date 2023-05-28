using System;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

internal class CFMessagePortContext
{
	public Func<INativeObject> Retain { get; set; }

	public Action Release { get; set; }

	public Func<NSString> CopyDescription { get; set; }
}
