using Foundation;
using ObjCRuntime;

namespace WebKit;

[Protocol(Name = "WebPolicyDecisionListener", WrapperType = typeof(WebPolicyDecisionListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Use", Selector = "use")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Download", Selector = "download")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Ignore", Selector = "ignore")]
public interface IWebPolicyDecisionListener : INativeObject, IDisposable
{
}
