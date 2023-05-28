using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionDownloadDelegate", WrapperType = typeof(NSUrlSessionDownloadDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishDownloading", Selector = "URLSession:downloadTask:didFinishDownloadingToURL:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDownloadTask),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidWriteData", Selector = "URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDownloadTask),
	typeof(long),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResume", Selector = "URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDownloadTask),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSUrlSessionDownloadDelegate : INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("URLSession:downloadTask:didFinishDownloadingToURL:")]
	[Preserve(Conditional = true)]
	void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location);
}
