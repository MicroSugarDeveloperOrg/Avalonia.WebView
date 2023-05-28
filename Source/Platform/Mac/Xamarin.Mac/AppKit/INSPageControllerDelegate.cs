using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPageControllerDelegate", WrapperType = typeof(NSPageControllerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetIdentifier", Selector = "pageController:identifierForObject:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSPageController),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetViewController", Selector = "pageController:viewControllerForIdentifier:", ReturnType = typeof(NSViewController), ParameterType = new Type[]
{
	typeof(NSPageController),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFrame", Selector = "pageController:frameForObject:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSPageController),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareViewController", Selector = "pageController:prepareViewController:withObject:", ParameterType = new Type[]
{
	typeof(NSPageController),
	typeof(NSViewController),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTransition", Selector = "pageController:didTransitionToObject:", ParameterType = new Type[]
{
	typeof(NSPageController),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLiveTransition", Selector = "pageControllerWillStartLiveTransition:", ParameterType = new Type[] { typeof(NSPageController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndLiveTransition", Selector = "pageControllerDidEndLiveTransition:", ParameterType = new Type[] { typeof(NSPageController) }, ParameterByRef = new bool[] { false })]
public interface INSPageControllerDelegate : INativeObject, IDisposable
{
}
