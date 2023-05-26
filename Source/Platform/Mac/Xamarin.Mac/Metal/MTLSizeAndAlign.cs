namespace Metal;

[iOS(10, 0)]
[TV(10, 0)]
[NoWatch]
[Mac(10, 12)]
public struct MTLSizeAndAlign
{
    public nuint Size;

    public nuint Align;

    public MTLSizeAndAlign(nuint size, nuint align)
    {
        Size = size;
        Align = align;
    }
}
