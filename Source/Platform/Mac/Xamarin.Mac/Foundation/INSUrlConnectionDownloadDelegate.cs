using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLConnectionDownloadDelegate", WrapperType = typeof(NSUrlConnectionDownloadDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteData", Selector = "connection:didWriteData:totalBytesWritten:expectedTotalBytes:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(long),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResumedDownloading", Selector = "connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedDownloading", Selector = "connectionDidFinishDownloading:destinationURL:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUrlConnectionDownloadDelegate : INativeObject, IDisposable, INSUrlConnectionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("connectionDidFinishDownloading:destinationURL:")]
	[Preserve(Conditional = true)]
	void FinishedDownloading(NSUrlConnection connection, NSUrl destinationUrl);
}
