using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMutableFontCollection", true)]
public class NSMutableFontCollection : NSFontCollection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddQueryForDescriptors_ = "addQueryForDescriptors:";

	private static readonly IntPtr selAddQueryForDescriptors_Handle = Selector.GetHandle("addQueryForDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithAllAvailableDescriptors = "fontCollectionWithAllAvailableDescriptors";

	private static readonly IntPtr selFontCollectionWithAllAvailableDescriptorsHandle = Selector.GetHandle("fontCollectionWithAllAvailableDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithDescriptors_ = "fontCollectionWithDescriptors:";

	private static readonly IntPtr selFontCollectionWithDescriptors_Handle = Selector.GetHandle("fontCollectionWithDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithLocale_ = "fontCollectionWithLocale:";

	private static readonly IntPtr selFontCollectionWithLocale_Handle = Selector.GetHandle("fontCollectionWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithName_ = "fontCollectionWithName:";

	private static readonly IntPtr selFontCollectionWithName_Handle = Selector.GetHandle("fontCollectionWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithName_Visibility_ = "fontCollectionWithName:visibility:";

	private static readonly IntPtr selFontCollectionWithName_Visibility_Handle = Selector.GetHandle("fontCollectionWithName:visibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveQueryForDescriptors_ = "removeQueryForDescriptors:";

	private static readonly IntPtr selRemoveQueryForDescriptors_Handle = Selector.GetHandle("removeQueryForDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExclusionDescriptors_ = "setExclusionDescriptors:";

	private static readonly IntPtr selSetExclusionDescriptors_Handle = Selector.GetHandle("setExclusionDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQueryDescriptors_ = "setQueryDescriptors:";

	private static readonly IntPtr selSetQueryDescriptors_Handle = Selector.GetHandle("setQueryDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableFontCollection");

	public override IntPtr ClassHandle => class_ptr;

	[Obsolete("macOS 10.12 does not allow creation via this constructor")]
	public NSMutableFontCollection()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableFontCollection(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSMutableFontCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableFontCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addQueryForDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddQueryForDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddQueryForDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddQueryForDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("fontCollectionWithDescriptors:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableFontCollection FromDescriptors(NSFontDescriptor[] queryDescriptors)
	{
		NSApplication.EnsureUIThread();
		if (queryDescriptors == null)
		{
			throw new ArgumentNullException("queryDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(queryDescriptors);
		NSMutableFontCollection nSObject = Runtime.GetNSObject<NSMutableFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithDescriptors_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fontCollectionWithLocale:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableFontCollection FromLocale(NSLocale locale)
	{
		NSApplication.EnsureUIThread();
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		return Runtime.GetNSObject<NSMutableFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithLocale_Handle, locale.Handle));
	}

	[Export("fontCollectionWithName:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableFontCollection FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSMutableFontCollection nSObject = Runtime.GetNSObject<NSMutableFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fontCollectionWithName:visibility:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableFontCollection FromName(string name, NSFontCollectionVisibility visibility)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSMutableFontCollection nSObject = Runtime.GetNSObject<NSMutableFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selFontCollectionWithName_Visibility_Handle, arg, (ulong)visibility));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fontCollectionWithAllAvailableDescriptors")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableFontCollection GetAllAvailableFonts()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSMutableFontCollection>(Messaging.IntPtr_objc_msgSend(class_ptr, selFontCollectionWithAllAvailableDescriptorsHandle));
	}

	[Export("removeQueryForDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveQueryForDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveQueryForDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveQueryForDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setExclusionDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetExclusionDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExclusionDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExclusionDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("setQueryDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetQueryDescriptors(NSFontDescriptor[] descriptors)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQueryDescriptors_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQueryDescriptors_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
