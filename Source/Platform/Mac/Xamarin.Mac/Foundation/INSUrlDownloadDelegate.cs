using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLDownloadDelegate", WrapperType = typeof(NSUrlDownloadDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadBegan", Selector = "downloadDidBegin:", ParameterType = new Type[] { typeof(NSUrlDownload) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequest", Selector = "download:willSendRequest:redirectResponse:", ReturnType = typeof(NSUrlRequest), ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSUrlRequest),
	typeof(NSUrlResponse)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "download:didReceiveAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledAuthenticationChallenge", Selector = "download:didCancelAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "download:didReceiveResponse:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSUrlResponse)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Resume", Selector = "download:willResumeWithResponse:fromByte:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSUrlResponse),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "download:didReceiveDataOfLength:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodeSourceData", Selector = "download:shouldDecodeSourceDataOfMIMEType:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecideDestination", Selector = "download:decideDestinationWithSuggestedFilename:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreatedDestination", Selector = "download:didCreateDestination:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "downloadDidFinish:", ParameterType = new Type[] { typeof(NSUrlDownload) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "download:didFailWithError:", ParameterType = new Type[]
{
	typeof(NSUrlDownload),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUrlDownloadDelegate : INativeObject, IDisposable
{
}
