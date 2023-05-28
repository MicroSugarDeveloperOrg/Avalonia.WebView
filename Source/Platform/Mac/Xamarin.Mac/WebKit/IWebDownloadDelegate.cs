using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "WebDownloadDelegate", WrapperType = typeof(WebDownloadDelegateWrapper), FormalSince = "10.11")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDownloadWindowForSheet", Selector = "downloadWindowForAuthenticationSheet:", ReturnType = typeof(NSWindow), ParameterType = new Type[] { typeof(WebDownload) }, ParameterByRef = new bool[] { false })]
public interface IWebDownloadDelegate : INativeObject, IDisposable
{
}
