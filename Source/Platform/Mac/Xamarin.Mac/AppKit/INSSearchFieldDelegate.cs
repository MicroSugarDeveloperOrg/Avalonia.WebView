using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSearchFieldDelegate", WrapperType = typeof(NSSearchFieldDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchingStarted", Selector = "searchFieldDidStartSearching:", ParameterType = new Type[] { typeof(NSSearchField) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchingEnded", Selector = "searchFieldDidEndSearching:", ParameterType = new Type[] { typeof(NSSearchField) }, ParameterByRef = new bool[] { false })]
public interface INSSearchFieldDelegate : INativeObject, IDisposable, INSTextFieldDelegate
{
}
