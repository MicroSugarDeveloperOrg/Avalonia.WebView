namespace Metal;

[Mac(10, 15)]
[iOS(13, 0)]
[TV(13, 0)]
public enum MTLTextureSwizzle : byte
{
    Zero,
    One,
    Red,
    Green,
    Blue,
    Alpha
}
