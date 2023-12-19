using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class BuiltInHostObject
{
    private object _originalHostObject;

    private EventConnector _eventConnector;

    private EventConnector EventConnector
    {
        get
        {
            if (_eventConnector == null)
            {
                _eventConnector = new EventConnector(_originalHostObject);
            }
            return _eventConnector;
        }
    }

    public BuiltInHostObject(object originalHostObject)
    {
        _originalHostObject = originalHostObject;
    }

    public void addEventListener(string eventName, object JSHandler)
    {
        EventConnector.addEventListener(eventName, JSHandler);
    }

    public void removeEventListener(string eventName, object JSHandler)
    {
        EventConnector.removeEventListener(eventName, JSHandler);
    }
}