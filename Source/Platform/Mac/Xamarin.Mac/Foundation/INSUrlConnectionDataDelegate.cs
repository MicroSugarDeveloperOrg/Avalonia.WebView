using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Protocol(Name = "NSURLConnectionDataDelegate", WrapperType = typeof(NSUrlConnectionDataDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequest", Selector = "connection:willSendRequest:redirectResponse:", ReturnType = typeof(NSUrlRequest), ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlRequest),
	typeof(NSUrlResponse)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "connection:didReceiveResponse:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlResponse)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "connection:didReceiveData:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedNewBodyStream", Selector = "connection:needNewBodyStream:", ReturnType = typeof(NSInputStream), ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SentBodyData", Selector = "connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(nint),
	typeof(nint),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCacheResponse", Selector = "connection:willCacheResponse:", ReturnType = typeof(NSCachedUrlResponse), ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSCachedUrlResponse)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "connectionDidFinishLoading:", ParameterType = new Type[] { typeof(NSUrlConnection) }, ParameterByRef = new bool[] { false })]
public interface INSUrlConnectionDataDelegate : INativeObject, IDisposable, INSUrlConnectionDelegate
{
}
