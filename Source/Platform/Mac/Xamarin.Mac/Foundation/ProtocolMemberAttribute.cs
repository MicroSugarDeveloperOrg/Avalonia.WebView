using ObjCRuntime;

namespace Foundation;
[AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
public sealed class ProtocolMemberAttribute : Attribute
{
    public bool IsRequired { get; set; }

    public bool IsProperty { get; set; }

    public bool IsStatic { get; set; }

    public string? Name { get; set; }

    public string? Selector { get; set; }

    public Type? ReturnType { get; set; }

    public Type? ReturnTypeDelegateProxy { get; set; }

    public Type[]? ParameterType { get; set; }

    public bool[]? ParameterByRef { get; set; }

    public Type?[]? ParameterBlockProxy { get; set; }

    public bool IsVariadic { get; set; }

    public Type? PropertyType { get; set; }

    public string? GetterSelector { get; set; }

    public string? SetterSelector { get; set; }

    public ArgumentSemantic ArgumentSemantic { get; set; }
}