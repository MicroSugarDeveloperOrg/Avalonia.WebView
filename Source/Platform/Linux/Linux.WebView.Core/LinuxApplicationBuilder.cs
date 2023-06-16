namespace Linux.WebView.Core;

public class LinuxApplicationBuilder
{
    public static ILinuxApplication Build(bool isWslDevelop) => new LinuxApplication(isWslDevelop);
}
