using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;

[Flags]
public enum BindingImplOptions
{
    GeneratedCode = 1,
    Optimizable = 2
}
