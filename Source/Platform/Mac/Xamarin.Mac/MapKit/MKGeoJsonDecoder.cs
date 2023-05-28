using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKGeoJSONDecoder", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKGeoJsonDecoder : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeoJSONObjectsWithData_Error_ = "geoJSONObjectsWithData:error:";

	private static readonly IntPtr selGeoJSONObjectsWithData_Error_Handle = Selector.GetHandle("geoJSONObjectsWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKGeoJSONDecoder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKGeoJsonDecoder()
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
	protected MKGeoJsonDecoder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKGeoJsonDecoder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("geoJSONObjectsWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMKGeoJsonObject[]? GeoJsonObjects(NSData data, out NSError? error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IMKGeoJsonObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<IMKGeoJsonObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selGeoJSONObjectsWithData_Error_Handle, data.Handle, ref arg)) : NSArray.ArrayFromHandle<IMKGeoJsonObject>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selGeoJSONObjectsWithData_Error_Handle, data.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
