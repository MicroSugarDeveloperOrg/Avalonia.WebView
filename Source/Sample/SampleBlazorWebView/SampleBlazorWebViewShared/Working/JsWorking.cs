using Microsoft.JSInterop;
using System.Xml.Serialization;

namespace SampleBlazorWebViewShared.Working;
public class JsWorking
{
    [JSInvokable]
    public static Task<int[]> ReturnArrayAsync()
    {
        Console.WriteLine(new int[] { 1,2,3 }); 
        return Task.FromResult(new int[] { 1,2,3 });
    }

}
