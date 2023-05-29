namespace Foundation;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public sealed class ProtocolAttribute : Attribute
{
    private string? informal_until;

    public Type WrapperType { get; set; }

    public string Name { get; set; }

    public bool IsInformal { get; set; }

    public string? FormalSince
    {
        get => informal_until;
        set
        {
            if (value != null)
                Version.Parse(value);

            informal_until = value;
        }
    }
}
