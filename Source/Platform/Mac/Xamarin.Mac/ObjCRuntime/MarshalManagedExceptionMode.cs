using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;
public enum MarshalManagedExceptionMode
{
    Default,
    UnwindNativeCode,
    ThrowObjectiveCException,
    Abort,
    Disable
}