using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerFeatureTemplate", true)]
public class ICScannerFeatureTemplate : ICScannerFeature
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargets = "targets";

	private static readonly IntPtr selTargetsHandle = Selector.GetHandle("targets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFeatureTemplate");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableArray[] Targets
	{
		[Export("targets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSMutableArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetsHandle));
			}
			return NSArray.ArrayFromHandle<NSMutableArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFeatureTemplate(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFeatureTemplate(IntPtr handle)
		: base(handle)
	{
	}
}
