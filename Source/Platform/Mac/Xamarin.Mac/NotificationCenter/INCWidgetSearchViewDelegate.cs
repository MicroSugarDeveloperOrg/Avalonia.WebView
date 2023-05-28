using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NotificationCenter;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NCWidgetSearchViewDelegate", WrapperType = typeof(NCWidgetSearchViewDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SearchForTearm", Selector = "widgetSearch:searchForTerm:maxResults:", ParameterType = new Type[]
{
	typeof(NCWidgetSearchViewController),
	typeof(string),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "TermCleared", Selector = "widgetSearchTermCleared:", ParameterType = new Type[] { typeof(NCWidgetSearchViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResultSelected", Selector = "widgetSearch:resultSelected:", ParameterType = new Type[]
{
	typeof(NCWidgetSearchViewController),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
public interface INCWidgetSearchViewDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("widgetSearch:searchForTerm:maxResults:")]
	[Preserve(Conditional = true)]
	void SearchForTearm(NCWidgetSearchViewController controller, string searchTerm, nuint max);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("widgetSearchTermCleared:")]
	[Preserve(Conditional = true)]
	void TermCleared(NCWidgetSearchViewController controller);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("widgetSearch:resultSelected:")]
	[Preserve(Conditional = true)]
	void ResultSelected(NCWidgetSearchViewController controller, NSObject obj);
}
