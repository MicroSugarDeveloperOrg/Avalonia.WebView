using System;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace CoreAudioKit;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class AUAudioUnitViewControllerExtensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectViewConfiguration_ = "selectViewConfiguration:";

	private static readonly IntPtr selSelectViewConfiguration_Handle = Selector.GetHandle("selectViewConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedViewConfigurations_ = "supportedViewConfigurations:";

	private static readonly IntPtr selSupportedViewConfigurations_Handle = Selector.GetHandle("supportedViewConfigurations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AUAudioUnit");

	[Export("supportedViewConfigurations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet GetSupportedViewConfigurations(this AUAudioUnit This, AUAudioUnitViewConfiguration[] availableViewConfigurations)
	{
		if (availableViewConfigurations == null)
		{
			throw new ArgumentNullException("availableViewConfigurations");
		}
		NSArray nSArray = NSArray.FromNSObjects(availableViewConfigurations);
		NSIndexSet nSObject = Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selSupportedViewConfigurations_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("selectViewConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectViewConfiguration(this AUAudioUnit This, AUAudioUnitViewConfiguration viewConfiguration)
	{
		if (viewConfiguration == null)
		{
			throw new ArgumentNullException("viewConfiguration");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSelectViewConfiguration_Handle, viewConfiguration.Handle);
	}
}
