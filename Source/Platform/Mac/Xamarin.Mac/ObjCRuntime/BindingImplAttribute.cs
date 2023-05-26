using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class BindingImplAttribute : Attribute
{
    public BindingImplOptions Options { get; set; }

    public BindingImplAttribute(BindingImplOptions options)
    {
        Options = options;
    }
}
