using Foundation;
using ObjCRuntime;

namespace WebKit;
public static class WebOpenPanelResultListener_Extensions
{
    public static void ChooseFilename(this IWebOpenPanelResultListener This, string filename)
    {
        if (filename == null)
        {
            throw new ArgumentNullException("filename");
        }
        IntPtr intPtr = NSString.CreateNative(filename);
        Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("chooseFilename:"), intPtr);
        NSString.ReleaseNative(intPtr);
    }

    public static void ChooseFilenames(this IWebOpenPanelResultListener This, string[] filenames)
    {
        if (filenames == null)
        {
            throw new ArgumentNullException("filenames");
        }
        NSArray nSArray = NSArray.FromStrings(filenames);
        Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("chooseFilenames:"), nSArray.Handle);
        nSArray.Dispose();
    }

    public static void Cancel(this IWebOpenPanelResultListener This)
    {
        Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("cancel"));
    }
}
