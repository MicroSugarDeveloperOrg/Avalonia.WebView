using System;
using Foundation;
using ObjCRuntime;

namespace CoreAudioKit;

internal sealed class AUCustomViewPersistentDataWrapper : BaseWrapper, IAUCustomViewPersistentData, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary<NSString, NSObject>? CustomViewPersistentData
	{
		[Export("customViewPersistentData", ArgumentSemantic.Assign)]
		get
		{
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("customViewPersistentData")));
		}
		[Export("setCustomViewPersistentData:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setCustomViewPersistentData:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[Preserve(Conditional = true)]
	public AUCustomViewPersistentDataWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
