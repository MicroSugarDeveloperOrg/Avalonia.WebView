using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKLocalSearchResponse", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKLocalSearchResponse : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRegion = "boundingRegion";

	private static readonly IntPtr selBoundingRegionHandle = Selector.GetHandle("boundingRegion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMapItems = "mapItems";

	private static readonly IntPtr selMapItemsHandle = Selector.GetHandle("mapItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKLocalSearchResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKMapItem[] MapItems
	{
		[Export("mapItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MKMapItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMapItemsHandle));
			}
			return NSArray.ArrayFromHandle<MKMapItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMapItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion Region
	{
		[Export("boundingRegion")]
		get
		{
			MKCoordinateRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKCoordinateRegion_objc_msgSend_stret(out retval, base.Handle, selBoundingRegionHandle);
			}
			else
			{
				Messaging.MKCoordinateRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingRegionHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKLocalSearchResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKLocalSearchResponse(IntPtr handle)
		: base(handle)
	{
	}
}
