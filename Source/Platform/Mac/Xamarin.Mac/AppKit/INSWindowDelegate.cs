using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSWindowDelegate", WrapperType = typeof(NSWindowDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WindowShouldClose", Selector = "windowShouldClose:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillReturnFieldEditor", Selector = "windowWillReturnFieldEditor:toObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResize", Selector = "windowWillResize:toSize:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUseStandardFrame", Selector = "windowWillUseStandardFrame:defaultFrame:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldZoom", Selector = "windowShouldZoom:toFrame:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillReturnUndoManager", Selector = "windowWillReturnUndoManager:", ReturnType = typeof(NSUndoManager), ParameterType = new Type[] { typeof(NSWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPositionSheet", Selector = "window:willPositionSheet:usingRect:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSWindow),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPopUpDocumentPathMenu", Selector = "window:shouldPopUpDocumentPathMenu:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSMenu)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldDragDocumentWithEvent", Selector = "window:shouldDragDocumentWithEvent:from:withPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSEvent),
	typeof(CGPoint),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResize", Selector = "windowDidResize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidExpose", Selector = "windowDidExpose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillMove", Selector = "windowWillMove:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMove", Selector = "windowDidMove:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeKey", Selector = "windowDidBecomeKey:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResignKey", Selector = "windowDidResignKey:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeMain", Selector = "windowDidBecomeMain:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResignMain", Selector = "windowDidResignMain:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillClose", Selector = "windowWillClose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillMiniaturize", Selector = "windowWillMiniaturize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMiniaturize", Selector = "windowDidMiniaturize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDeminiaturize", Selector = "windowDidDeminiaturize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "windowDidUpdate:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeScreen", Selector = "windowDidChangeScreen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeScreenProfile", Selector = "windowDidChangeScreenProfile:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginSheet", Selector = "windowWillBeginSheet:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndSheet", Selector = "windowDidEndSheet:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartLiveResize", Selector = "windowWillStartLiveResize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndLiveResize", Selector = "windowDidEndLiveResize:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterFullScreen", Selector = "windowWillEnterFullScreen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnterFullScreen", Selector = "windowDidEnterFullScreen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExitFullScreen", Selector = "windowWillExitFullScreen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidExitFullScreen", Selector = "windowDidExitFullScreen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToEnterFullScreen", Selector = "windowDidFailToEnterFullScreen:", ParameterType = new Type[] { typeof(NSWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToExitFullScreen", Selector = "windowDidFailToExitFullScreen:", ParameterType = new Type[] { typeof(NSWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUseFullScreenContentSize", Selector = "window:willUseFullScreenContentSize:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillUseFullScreenPresentationOptions", Selector = "window:willUseFullScreenPresentationOptions:", ReturnType = typeof(NSApplicationPresentationOptions), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSApplicationPresentationOptions)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomWindowsToEnterFullScreen", Selector = "customWindowsToEnterFullScreenForWindow:", ReturnType = typeof(NSWindow[]), ParameterType = new Type[] { typeof(NSWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CustomWindowsToExitFullScreen", Selector = "customWindowsToExitFullScreenForWindow:", ReturnType = typeof(NSWindow[]), ParameterType = new Type[] { typeof(NSWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartCustomAnimationToEnterFullScreen", Selector = "window:startCustomAnimationToEnterFullScreenWithDuration:", ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartCustomAnimationToExitFullScreen", Selector = "window:startCustomAnimationToExitFullScreenWithDuration:", ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEncodeRestorableState", Selector = "window:willEncodeRestorableState:", ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSCoder)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDecodeRestorableState", Selector = "window:didDecodeRestorableState:", ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(NSCoder)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResizeForVersionBrowser", Selector = "window:willResizeForVersionBrowserWithMaxPreferredSize:maxAllowedSize:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSWindow),
	typeof(CGSize),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEnterVersionBrowser", Selector = "windowWillEnterVersionBrowser:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnterVersionBrowser", Selector = "windowDidEnterVersionBrowser:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExitVersionBrowser", Selector = "windowWillExitVersionBrowser:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidExitVersionBrowser", Selector = "windowDidExitVersionBrowser:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeBackingProperties", Selector = "windowDidChangeBackingProperties:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSWindowDelegate : INativeObject, IDisposable
{
}
