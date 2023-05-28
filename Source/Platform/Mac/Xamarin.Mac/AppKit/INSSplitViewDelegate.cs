using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSSplitViewDelegate", WrapperType = typeof(NSSplitViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanCollapse", Selector = "splitView:canCollapseSubview:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(NSView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCollapseForDoubleClick", Selector = "splitView:shouldCollapseSubview:forDoubleClickOnDividerAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(NSView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMinCoordinateOfSubview", Selector = "splitView:constrainMinCoordinate:ofSubviewAt:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(nfloat),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetMaxCoordinateOfSubview", Selector = "splitView:constrainMaxCoordinate:ofSubviewAt:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(nfloat),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConstrainSplitPosition", Selector = "splitView:constrainSplitPosition:ofSubviewAt:", ReturnType = typeof(nfloat), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(nfloat),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Resize", Selector = "splitView:resizeSubviewsWithOldSize:", ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAdjustSize", Selector = "splitView:shouldAdjustSizeOfSubview:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(NSView)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldHideDivider", Selector = "splitView:shouldHideDividerAtIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEffectiveRect", Selector = "splitView:effectiveRect:forDrawnRect:ofDividerAtIndex:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(CGRect),
	typeof(CGRect),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAdditionalEffectiveRect", Selector = "splitView:additionalEffectiveRectOfDividerAtIndex:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSSplitView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SplitViewWillResizeSubviews", Selector = "splitViewWillResizeSubviews:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResizeSubviews", Selector = "splitViewDidResizeSubviews:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSSplitViewDelegate : INativeObject, IDisposable
{
}
