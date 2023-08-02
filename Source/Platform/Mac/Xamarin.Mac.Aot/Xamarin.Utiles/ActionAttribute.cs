using Foundation;
using System;

namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Method)]
public sealed class ActionAttribute : ExportAttribute
{
    public ActionAttribute()
    {
    }

    public ActionAttribute(string selector)
        : base(selector)
    {
    }
}
