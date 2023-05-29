using System.ComponentModel;

namespace ObjCRuntime;

[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.Delegate, AllowMultiple = false)]
public sealed class UserDelegateTypeAttribute : Attribute
{
    public Type UserDelegateType { get; private set; }

    public UserDelegateTypeAttribute(Type userDelegateType)
    {
        UserDelegateType = userDelegateType;
    }
}
