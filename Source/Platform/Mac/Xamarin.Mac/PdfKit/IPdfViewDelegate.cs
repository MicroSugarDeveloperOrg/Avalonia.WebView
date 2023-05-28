using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "PDFViewDelegate", WrapperType = typeof(PdfViewDelegateWrapper), FormalSince = "10.12")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeScaleFactor", Selector = "PDFViewWillChangeScaleFactor:toScale:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(PdfView),
	typeof(nfloat)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClickOnLink", Selector = "PDFViewWillClickOnLink:withURL:", ParameterType = new Type[]
{
	typeof(PdfView),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TitleOfPrintJob", Selector = "PDFViewPrintJobTitle:", ReturnType = typeof(string), ParameterType = new Type[] { typeof(PdfView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformFind", Selector = "PDFViewPerformFind:", ParameterType = new Type[] { typeof(PdfView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformGoToPage", Selector = "PDFViewPerformGoToPage:", ParameterType = new Type[] { typeof(PdfView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformPrint", Selector = "PDFViewPerformPrint:", ParameterType = new Type[] { typeof(PdfView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OpenPdf", Selector = "PDFViewOpenPDF:forRemoteGoToAction:", ParameterType = new Type[]
{
	typeof(PdfView),
	typeof(PdfActionRemoteGoTo)
}, ParameterByRef = new bool[] { false, false })]
public interface IPdfViewDelegate : INativeObject, IDisposable
{
}
