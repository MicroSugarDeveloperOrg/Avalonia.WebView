namespace JavaScriptCore;

[Flags]
public enum JSPropertyAttributes : uint
{
    None = 0u,
    ReadOnly = 2u,
    DontEnum = 4u,
    DontDelete = 8u
}
