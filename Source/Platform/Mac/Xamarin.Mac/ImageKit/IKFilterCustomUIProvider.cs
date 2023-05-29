using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKFilterCustomUIProvider", true)]
[Model]
public abstract class IKFilterCustomUIProvider : NSObject
{
	private static NSString _SizeFlavor;

	private static NSString _SizeMini;

	private static NSString _SizeSmall;

	private static NSString _SizeRegular;

	private static NSString _MaxSize;

	private static NSString _FlavorAllowFallback;

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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKFilterCustomUIProvider()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKFilterCustomUIProvider(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKFilterCustomUIProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKFilterCustomUIProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("provideViewForUIConfiguration:excludedKeys:")]
	public abstract IKFilterUIView GetFilterUIView(NSDictionary configurationOptions, NSArray excludedKeys);
}
