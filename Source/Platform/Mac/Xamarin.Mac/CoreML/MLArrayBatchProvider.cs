using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLArrayBatchProvider", true)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MLArrayBatchProvider : NSObject, IMLBatchProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArray = "array";

	private static readonly IntPtr selArrayHandle = Selector.GetHandle("array");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeaturesAtIndex_ = "featuresAtIndex:";

	private static readonly IntPtr selFeaturesAtIndex_Handle = Selector.GetHandle("featuresAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDictionary_Error_ = "initWithDictionary:error:";

	private static readonly IntPtr selInitWithDictionary_Error_Handle = Selector.GetHandle("initWithDictionary:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFeatureProviderArray_ = "initWithFeatureProviderArray:";

	private static readonly IntPtr selInitWithFeatureProviderArray_Handle = Selector.GetHandle("initWithFeatureProviderArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLArrayBatchProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLFeatureProvider[] Array
	{
		[Export("array")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrayHandle));
			}
			return NSArray.ArrayFromHandle<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrayHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual nint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLArrayBatchProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLArrayBatchProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFeatureProviderArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLArrayBatchProvider(IMLFeatureProvider[] array)
		: base(NSObjectFlag.Empty)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		NSArray nSArray = NSArray.FromNSObjects(array);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFeatureProviderArray_Handle, nSArray.Handle), "initWithFeatureProviderArray:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFeatureProviderArray_Handle, nSArray.Handle), "initWithFeatureProviderArray:");
		}
		nSArray.Dispose();
	}

	[Export("initWithDictionary:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLArrayBatchProvider(NSDictionary<NSString, NSArray> dictionary, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithDictionary_Error_Handle, dictionary.Handle, ref arg), "initWithDictionary:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDictionary_Error_Handle, dictionary.Handle, ref arg), "initWithDictionary:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("featuresAtIndex:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLFeatureProvider GetFeatures(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selFeaturesAtIndex_Handle, index), owns: false);
		}
		return Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selFeaturesAtIndex_Handle, index), owns: false);
	}
}
