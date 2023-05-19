namespace AvaloniaBlazorWebView.Core;
internal class FileProviderBuilder
{
    public FileProviderBuilder()
    {

    }

    public static IFileProvider Build(string root)
    {
        if (Directory.Exists(root))
            return new PhysicalFileProvider(root);
        else
            return new NullFileProvider();
    }
}
