using System.Diagnostics;

namespace WebViewCore.Helpers;
public class OpenUriHelper
{
    public static void OpenInProcess(Uri uri)
    {
        using (var launchBrowser = new Process())
        {
            launchBrowser.StartInfo.UseShellExecute = true;
            launchBrowser.StartInfo.FileName = uri.ToString();
            launchBrowser.Start();
        }
    }
}
