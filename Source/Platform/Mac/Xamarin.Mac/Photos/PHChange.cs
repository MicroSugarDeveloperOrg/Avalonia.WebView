using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHChange", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHChange : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeDetailsForFetchResult_ = "changeDetailsForFetchResult:";

	private static readonly IntPtr selChangeDetailsForFetchResult_Handle = Selector.GetHandle("changeDetailsForFetchResult:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeDetailsForObject_ = "changeDetailsForObject:";

	private static readonly IntPtr selChangeDetailsForObject_Handle = Selector.GetHandle("changeDetailsForObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHChange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHChange()
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
	protected PHChange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHChange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("changeDetailsForFetchResult:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHFetchResultChangeDetails GetFetchResultChangeDetails(PHFetchResult obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PHFetchResultChangeDetails>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChangeDetailsForFetchResult_Handle, obj.Handle));
		}
		return Runtime.GetNSObject<PHFetchResultChangeDetails>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDetailsForFetchResult_Handle, obj.Handle));
	}

	[Export("changeDetailsForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObjectChangeDetails GetObjectChangeDetails(PHObject? obj)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PHObjectChangeDetails>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChangeDetailsForObject_Handle, obj?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<PHObjectChangeDetails>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeDetailsForObject_Handle, obj?.Handle ?? IntPtr.Zero));
	}
}
