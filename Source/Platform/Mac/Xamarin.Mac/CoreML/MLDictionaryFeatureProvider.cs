using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLDictionaryFeatureProvider", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLDictionaryFeatureProvider : NSObject, IMLFeatureProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionary = "dictionary";

	private static readonly IntPtr selDictionaryHandle = Selector.GetHandle("dictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureNames = "featureNames";

	private static readonly IntPtr selFeatureNamesHandle = Selector.GetHandle("featureNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeatureValueForName_ = "featureValueForName:";

	private static readonly IntPtr selFeatureValueForName_Handle = Selector.GetHandle("featureValueForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDictionary_Error_ = "initWithDictionary:error:";

	private static readonly IntPtr selInitWithDictionary_Error_Handle = Selector.GetHandle("initWithDictionary:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLDictionaryFeatureProvider");

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public MLFeatureValue this[string featureName] => GetFeatureValue(featureName);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, MLFeatureValue> Dictionary
	{
		[Export("dictionary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, MLFeatureValue>>(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, MLFeatureValue>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSSet<NSString> FeatureNames
	{
		[Export("featureNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selFeatureNamesHandle));
			}
			return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFeatureNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MLDictionaryFeatureProvider()
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
	protected MLDictionaryFeatureProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLDictionaryFeatureProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDictionary:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLDictionaryFeatureProvider(NSDictionary<NSString, NSObject> dictionary, out NSError error)
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

	[Export("featureValueForName:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLFeatureValue? GetFeatureValue(string featureName)
	{
		if (featureName == null)
		{
			throw new ArgumentNullException("featureName");
		}
		IntPtr arg = NSString.CreateNative(featureName);
		MLFeatureValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFeatureValueForName_Handle, arg)) : Runtime.GetNSObject<MLFeatureValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFeatureValueForName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
