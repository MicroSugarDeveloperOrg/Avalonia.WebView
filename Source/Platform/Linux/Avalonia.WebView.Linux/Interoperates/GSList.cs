namespace Avalonia.WebView.Linux.Interoperates;

[StructLayout(LayoutKind.Sequential)]
unsafe struct GSList
{
    public readonly nint Data;
    public readonly GSList* Next;
}