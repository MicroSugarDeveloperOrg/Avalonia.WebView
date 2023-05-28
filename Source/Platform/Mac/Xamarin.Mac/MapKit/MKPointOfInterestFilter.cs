using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKPointOfInterestFilter", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MKPointOfInterestFilter : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExcludesCategory_ = "excludesCategory:";

	private static readonly IntPtr selExcludesCategory_Handle = Selector.GetHandle("excludesCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterExcludingAllCategories = "filterExcludingAllCategories";

	private static readonly IntPtr selFilterExcludingAllCategoriesHandle = Selector.GetHandle("filterExcludingAllCategories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterIncludingAllCategories = "filterIncludingAllCategories";

	private static readonly IntPtr selFilterIncludingAllCategoriesHandle = Selector.GetHandle("filterIncludingAllCategories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludesCategory_ = "includesCategory:";

	private static readonly IntPtr selIncludesCategory_Handle = Selector.GetHandle("includesCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitExcludingCategories_ = "initExcludingCategories:";

	private static readonly IntPtr selInitExcludingCategories_Handle = Selector.GetHandle("initExcludingCategories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitIncludingCategories_ = "initIncludingCategories:";

	private static readonly IntPtr selInitIncludingCategories_Handle = Selector.GetHandle("initIncludingCategories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKPointOfInterestFilter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKPointOfInterestFilter FilterExcludingAllCategories
	{
		[Export("filterExcludingAllCategories")]
		get
		{
			return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSend(class_ptr, selFilterExcludingAllCategoriesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MKPointOfInterestFilter FilterIncludingAllCategories
	{
		[Export("filterIncludingAllCategories")]
		get
		{
			return Runtime.GetNSObject<MKPointOfInterestFilter>(Messaging.IntPtr_objc_msgSend(class_ptr, selFilterIncludingAllCategoriesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKPointOfInterestFilter()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MKPointOfInterestFilter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKPointOfInterestFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKPointOfInterestFilter(IntPtr handle)
		: base(handle)
	{
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("excludesCategory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExcludesCategory([BindAs(typeof(MKPointOfInterestCategory), OriginalType = typeof(NSString))] MKPointOfInterestCategory category)
	{
		NSString constant = category.GetConstant();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selExcludesCategory_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selExcludesCategory_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
	}

	[Export("includesCategory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludesCategory([BindAs(typeof(MKPointOfInterestCategory), OriginalType = typeof(NSString))] MKPointOfInterestCategory category)
	{
		NSString constant = category.GetConstant();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIncludesCategory_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIncludesCategory_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
	}

	[Export("initExcludingCategories:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitExcludingCategories([BindAs(typeof(MKPointOfInterestCategory[]), OriginalType = typeof(NSString[]))] MKPointOfInterestCategory[] categories)
	{
		if (categories == null)
		{
			throw new ArgumentNullException("categories");
		}
		NSArray nSArray = NSArray.FromNSObjects((MKPointOfInterestCategory o) => o.GetConstant(), categories);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitExcludingCategories_Handle, nSArray?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitExcludingCategories_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}

	[Export("initIncludingCategories:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitIncludingCategories([BindAs(typeof(MKPointOfInterestCategory[]), OriginalType = typeof(NSString[]))] MKPointOfInterestCategory[] categories)
	{
		if (categories == null)
		{
			throw new ArgumentNullException("categories");
		}
		NSArray nSArray = NSArray.FromNSObjects((MKPointOfInterestCategory o) => o.GetConstant(), categories);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitIncludingCategories_Handle, nSArray?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitIncludingCategories_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return result;
	}
}
