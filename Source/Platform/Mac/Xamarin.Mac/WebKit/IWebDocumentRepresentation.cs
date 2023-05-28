using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "WebDocumentRepresentation", WrapperType = typeof(WebDocumentRepresentationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDataSource", Selector = "setDataSource:", ParameterType = new Type[] { typeof(WebDataSource) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "receivedData:withDataSource:", ParameterType = new Type[]
{
	typeof(NSData),
	typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedError", Selector = "receivedError:withDataSource:", ParameterType = new Type[]
{
	typeof(NSError),
	typeof(WebDataSource)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "finishedLoadingWithDataSource:", ParameterType = new Type[] { typeof(WebDataSource) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CanProvideDocumentSource", Selector = "canProvideDocumentSource", PropertyType = typeof(bool), GetterSelector = "canProvideDocumentSource", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "DocumentSource", Selector = "documentSource", PropertyType = typeof(string), GetterSelector = "documentSource", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof(string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
public interface IWebDocumentRepresentation : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool CanProvideDocumentSource
	{
		[Export("canProvideDocumentSource")]
		get;
	}

	[Preserve(Conditional = true)]
	string DocumentSource
	{
		[Export("documentSource")]
		get;
	}

	[Preserve(Conditional = true)]
	string Title
	{
		[Export("title")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setDataSource:")]
	[Preserve(Conditional = true)]
	void SetDataSource(WebDataSource dataSource);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("receivedData:withDataSource:")]
	[Preserve(Conditional = true)]
	void ReceivedData(NSData data, WebDataSource dataSource);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("receivedError:withDataSource:")]
	[Preserve(Conditional = true)]
	void ReceivedError(NSError error, WebDataSource dataSource);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishedLoadingWithDataSource:")]
	[Preserve(Conditional = true)]
	void FinishedLoading(WebDataSource dataSource);
}
