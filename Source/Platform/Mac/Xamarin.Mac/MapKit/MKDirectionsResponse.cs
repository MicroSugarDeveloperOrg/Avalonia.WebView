using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKDirectionsResponse", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKDirectionsResponse : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestination = "destination";

	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoutes = "routes";

	private static readonly IntPtr selRoutesHandle = Selector.GetHandle("routes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKDirectionsResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapItem Destination
	{
		[Export("destination")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationHandle));
			}
			return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKRoute[] Routes
	{
		[Export("routes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKRoute>(Messaging.IntPtr_objc_msgSend(base.Handle, selRoutesHandle));
			}
			return NSArray.ArrayFromHandle<MKRoute>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRoutesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapItem Source
	{
		[Export("source")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceHandle));
			}
			return Runtime.GetNSObject<MKMapItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKDirectionsResponse()
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
	protected MKDirectionsResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKDirectionsResponse(IntPtr handle)
		: base(handle)
	{
	}
}
