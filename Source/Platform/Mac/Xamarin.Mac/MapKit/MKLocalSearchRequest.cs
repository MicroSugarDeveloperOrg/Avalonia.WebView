using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKLocalSearchRequest", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKLocalSearchRequest : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompletion_ = "initWithCompletion:";

	private static readonly IntPtr selInitWithCompletion_Handle = Selector.GetHandle("initWithCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNaturalLanguageQuery_ = "initWithNaturalLanguageQuery:";

	private static readonly IntPtr selInitWithNaturalLanguageQuery_Handle = Selector.GetHandle("initWithNaturalLanguageQuery:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNaturalLanguageQuery_Region_ = "initWithNaturalLanguageQuery:region:";

	private static readonly IntPtr selInitWithNaturalLanguageQuery_Region_Handle = Selector.GetHandle("initWithNaturalLanguageQuery:region:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalLanguageQuery = "naturalLanguageQuery";

	private static readonly IntPtr selNaturalLanguageQueryHandle = Selector.GetHandle("naturalLanguageQuery");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointOfInterestFilter = "pointOfInterestFilter";

	private static readonly IntPtr selPointOfInterestFilterHandle = Selector.GetHandle("pointOfInterestFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegion = "region";

	private static readonly IntPtr selRegionHandle = Selector.GetHandle("region");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultTypes = "resultTypes";

	private static readonly IntPtr selResultTypesHandle = Selector.GetHandle("resultTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNaturalLanguageQuery_ = "setNaturalLanguageQuery:";

	private static readonly IntPtr selSetNaturalLanguageQuery_Handle = Selector.GetHandle("setNaturalLanguageQuery:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPointOfInterestFilter_ = "setPointOfInterestFilter:";

	private static readonly IntPtr selSetPointOfInterestFilter_Handle = Selector.GetHandle("setPointOfInterestFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegion_ = "setRegion:";

	private static readonly IntPtr selSetRegion_Handle = Selector.GetHandle("setRegion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultTypes_ = "setResultTypes:";

	private static readonly IntPtr selSetResultTypes_Handle = Selector.GetHandle("setResultTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKLocalSearchRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? NaturalLanguageQuery
	{
		[Export("naturalLanguageQuery", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNaturalLanguageQueryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNaturalLanguageQueryHandle));
		}
		[Export("setNaturalLanguageQuery:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNaturalLanguageQuery_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNaturalLanguageQuery_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKPointOfInterestFilter? PointOfInterestFilter
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("pointOfInterestFilter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointOfInterestFilterHandle));
			}
			return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointOfInterestFilterHandle));
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setPointOfInterestFilter:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPointOfInterestFilter_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MKCoordinateRegion Region
	{
		[Export("region", ArgumentSemantic.Assign)]
		get
		{
			MKCoordinateRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MKCoordinateRegion_objc_msgSend_stret(out retval, base.Handle, selRegionHandle);
			}
			else
			{
				Messaging.MKCoordinateRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRegionHandle);
			}
			return retval;
		}
		[Export("setRegion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MKCoordinateRegion(base.Handle, selSetRegion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MKCoordinateRegion(base.SuperHandle, selSetRegion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual MKLocalSearchResultType ResultTypes
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("resultTypes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MKLocalSearchResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypesHandle);
			}
			return (MKLocalSearchResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypesHandle);
		}
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("setResultTypes:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetResultTypes_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetResultTypes_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKLocalSearchRequest()
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
	protected MKLocalSearchRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKLocalSearchRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletion:")]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKLocalSearchRequest(MKLocalSearchCompletion completion)
		: base(NSObjectFlag.Empty)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompletion_Handle, completion.Handle), "initWithCompletion:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompletion_Handle, completion.Handle), "initWithCompletion:");
		}
	}

	[Export("initWithNaturalLanguageQuery:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKLocalSearchRequest(string naturalLanguageQuery)
		: base(NSObjectFlag.Empty)
	{
		if (naturalLanguageQuery == null)
		{
			throw new ArgumentNullException("naturalLanguageQuery");
		}
		IntPtr arg = NSString.CreateNative(naturalLanguageQuery);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithNaturalLanguageQuery_Handle, arg), "initWithNaturalLanguageQuery:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithNaturalLanguageQuery_Handle, arg), "initWithNaturalLanguageQuery:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithNaturalLanguageQuery:region:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKLocalSearchRequest(string naturalLanguageQuery, MKCoordinateRegion region)
		: base(NSObjectFlag.Empty)
	{
		if (naturalLanguageQuery == null)
		{
			throw new ArgumentNullException("naturalLanguageQuery");
		}
		IntPtr arg = NSString.CreateNative(naturalLanguageQuery);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MKCoordinateRegion(base.Handle, selInitWithNaturalLanguageQuery_Region_Handle, arg, region), "initWithNaturalLanguageQuery:region:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MKCoordinateRegion(base.SuperHandle, selInitWithNaturalLanguageQuery_Region_Handle, arg, region), "initWithNaturalLanguageQuery:region:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
