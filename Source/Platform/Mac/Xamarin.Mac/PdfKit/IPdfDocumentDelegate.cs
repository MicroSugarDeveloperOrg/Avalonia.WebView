using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "PDFDocumentDelegate", WrapperType = typeof(PdfDocumentDelegateWrapper), FormalSince = "10.13")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnlock", Selector = "documentDidUnlock:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBeginDocumentFind", Selector = "documentDidBeginDocumentFind:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMatchString", Selector = "didMatchString:", ParameterType = new Type[] { typeof(PdfSelection) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetClassForPage", Selector = "classForPage", ReturnType = typeof(Class))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetClassForAnnotationType", Selector = "classForAnnotationType:", ReturnType = typeof(Class), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClassForAnnotationClass", Selector = "classForAnnotationClass:", ReturnType = typeof(Class), ParameterType = new Type[] { typeof(Class) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FindFinished", Selector = "documentDidEndDocumentFind:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageFindStarted", Selector = "documentDidBeginPageFind:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PageFindFinished", Selector = "documentDidEndPageFind:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MatchFound", Selector = "documentDidFindMatch:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface IPdfDocumentDelegate : INativeObject, IDisposable
{
}
