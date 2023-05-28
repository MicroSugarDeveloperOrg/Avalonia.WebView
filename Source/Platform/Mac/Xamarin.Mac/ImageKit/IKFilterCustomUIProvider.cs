using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol]
[Register("IKFilterCustomUIProvider", false)]
[Model]
public abstract class IKFilterCustomUIProvider : NSObject, IIKFilterCustomUIProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FlavorAllowFallback;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxSize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeFlavor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeMini;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeRegular;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeSmall;

	[Field("IKUIFlavorAllowFallback", "ImageKit")]
	public static NSString FlavorAllowFallback
	{
		get
		{
			if (_FlavorAllowFallback == null)
			{
				_FlavorAllowFallback = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUIFlavorAllowFallback");
			}
			return _FlavorAllowFallback;
		}
	}

	[Field("IKUImaxSize", "ImageKit")]
	public static NSString MaxSize
	{
		get
		{
			if (_MaxSize == null)
			{
				_MaxSize = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUImaxSize");
			}
			return _MaxSize;
		}
	}

	[Field("IKUISizeFlavor", "ImageKit")]
	public static NSString SizeFlavor
	{
		get
		{
			if (_SizeFlavor == null)
			{
				_SizeFlavor = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUISizeFlavor");
			}
			return _SizeFlavor;
		}
	}

	[Field("IKUISizeMini", "ImageKit")]
	public static NSString SizeMini
	{
		get
		{
			if (_SizeMini == null)
			{
				_SizeMini = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUISizeMini");
			}
			return _SizeMini;
		}
	}

	[Field("IKUISizeRegular", "ImageKit")]
	public static NSString SizeRegular
	{
		get
		{
			if (_SizeRegular == null)
			{
				_SizeRegular = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUISizeRegular");
			}
			return _SizeRegular;
		}
	}

	[Field("IKUISizeSmall", "ImageKit")]
	public static NSString SizeSmall
	{
		get
		{
			if (_SizeSmall == null)
			{
				_SizeSmall = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKUISizeSmall");
			}
			return _SizeSmall;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected IKFilterCustomUIProvider()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKFilterCustomUIProvider(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKFilterCustomUIProvider(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("provideViewForUIConfiguration:excludedKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IKFilterUIView ProvideFilterUIView(NSDictionary configurationOptions, NSArray? excludedKeys);
}
