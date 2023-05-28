using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUnitConverter", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSUnitConverter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseUnitValueFromValue_ = "baseUnitValueFromValue:";

	private static readonly IntPtr selBaseUnitValueFromValue_Handle = Selector.GetHandle("baseUnitValueFromValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueFromBaseUnitValue_ = "valueFromBaseUnitValue:";

	private static readonly IntPtr selValueFromBaseUnitValue_Handle = Selector.GetHandle("valueFromBaseUnitValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUnitConverter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUnitConverter()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUnitConverter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUnitConverter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("baseUnitValueFromValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetBaseUnitValue(double value)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selBaseUnitValueFromValue_Handle, value);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selBaseUnitValueFromValue_Handle, value);
	}

	[Export("valueFromBaseUnitValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetValue(double baseUnitValue)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selValueFromBaseUnitValue_Handle, baseUnitValue);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selValueFromBaseUnitValue_Handle, baseUnitValue);
	}
}
