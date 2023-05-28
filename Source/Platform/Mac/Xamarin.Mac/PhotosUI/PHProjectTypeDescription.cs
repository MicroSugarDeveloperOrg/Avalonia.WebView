using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Register("PHProjectTypeDescription", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class PHProjectTypeDescription : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanProvideSubtypes = "canProvideSubtypes";

	private static readonly IntPtr selCanProvideSubtypesHandle = Selector.GetHandle("canProvideSubtypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_ = "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:";

	private static readonly IntPtr selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_Handle = Selector.GetHandle("initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_ = "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:";

	private static readonly IntPtr selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_Handle = Selector.GetHandle("initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProjectType_Title_Description_Image_ = "initWithProjectType:title:description:image:";

	private static readonly IntPtr selInitWithProjectType_Title_Description_Image_Handle = Selector.GetHandle("initWithProjectType:title:description:image:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_ = "initWithProjectType:title:description:image:canProvideSubtypes:";

	private static readonly IntPtr selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_Handle = Selector.GetHandle("initWithProjectType:title:description:image:canProvideSubtypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_ = "initWithProjectType:title:description:image:subtypeDescriptions:";

	private static readonly IntPtr selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_Handle = Selector.GetHandle("initWithProjectType:title:description:image:subtypeDescriptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedAttributedDescription = "localizedAttributedDescription";

	private static readonly IntPtr selLocalizedAttributedDescriptionHandle = Selector.GetHandle("localizedAttributedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescription = "localizedDescription";

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedTitle = "localizedTitle";

	private static readonly IntPtr selLocalizedTitleHandle = Selector.GetHandle("localizedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjectType = "projectType";

	private static readonly IntPtr selProjectTypeHandle = Selector.GetHandle("projectType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtypeDescriptions = "subtypeDescriptions";

	private static readonly IntPtr selSubtypeDescriptionsHandle = Selector.GetHandle("subtypeDescriptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHProjectTypeDescription");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual bool CanProvideSubtypes
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("canProvideSubtypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanProvideSubtypesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanProvideSubtypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? Image
	{
		[Export("image", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSAttributedString? LocalizedAttributedDescription
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("localizedAttributedDescription", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedAttributedDescriptionHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedAttributedDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedDescription
	{
		[Export("localizedDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedTitle
	{
		[Export("localizedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString ProjectType
	{
		[Export("projectType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selProjectTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProjectTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHProjectTypeDescription[] SubtypeDescriptions
	{
		[Export("subtypeDescriptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PHProjectTypeDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtypeDescriptionsHandle));
			}
			return NSArray.ArrayFromHandle<PHProjectTypeDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtypeDescriptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PHProjectTypeDescription(NSCoder coder)
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
	protected PHProjectTypeDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHProjectTypeDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProjectType:title:description:image:subtypeDescriptions:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription(NSString projectType, string localizedTitle, string? localizedDescription, NSImage? image, PHProjectTypeDescription[] subtypeDescriptions)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		if (localizedTitle == null)
		{
			throw new ArgumentNullException("localizedTitle");
		}
		if (subtypeDescriptions == null)
		{
			throw new ArgumentNullException("subtypeDescriptions");
		}
		IntPtr arg = NSString.CreateNative(localizedTitle);
		IntPtr arg2 = NSString.CreateNative(localizedDescription);
		NSArray nSArray = NSArray.FromNSObjects(subtypeDescriptions);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero, nSArray.Handle), "initWithProjectType:title:description:image:subtypeDescriptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProjectType_Title_Description_Image_SubtypeDescriptions_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero, nSArray.Handle), "initWithProjectType:title:description:image:subtypeDescriptions:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
	}

	[Export("initWithProjectType:title:description:image:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription(NSString projectType, string localizedTitle, string? localizedDescription, NSImage? image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		if (localizedTitle == null)
		{
			throw new ArgumentNullException("localizedTitle");
		}
		IntPtr arg = NSString.CreateNative(localizedTitle);
		IntPtr arg2 = NSString.CreateNative(localizedDescription);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProjectType_Title_Description_Image_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero), "initWithProjectType:title:description:image:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProjectType_Title_Description_Image_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero), "initWithProjectType:title:description:image:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithProjectType:title:attributedDescription:image:subtypeDescriptions:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription(NSString projectType, string localizedTitle, NSAttributedString? localizedAttributedDescription, NSImage? image, PHProjectTypeDescription[] subtypeDescriptions)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		if (localizedTitle == null)
		{
			throw new ArgumentNullException("localizedTitle");
		}
		if (subtypeDescriptions == null)
		{
			throw new ArgumentNullException("subtypeDescriptions");
		}
		IntPtr arg = NSString.CreateNative(localizedTitle);
		NSArray nSArray = NSArray.FromNSObjects(subtypeDescriptions);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_Handle, projectType.Handle, arg, localizedAttributedDescription?.Handle ?? IntPtr.Zero, image?.Handle ?? IntPtr.Zero, nSArray.Handle), "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProjectType_Title_AttributedDescription_Image_SubtypeDescriptions_Handle, projectType.Handle, arg, localizedAttributedDescription?.Handle ?? IntPtr.Zero, image?.Handle ?? IntPtr.Zero, nSArray.Handle), "initWithProjectType:title:attributedDescription:image:subtypeDescriptions:");
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}

	[Export("initWithProjectType:title:attributedDescription:image:canProvideSubtypes:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription(NSString projectType, string localizedTitle, NSAttributedString? localizedAttributedDescription, NSImage? image, bool canProvideSubtypes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		if (localizedTitle == null)
		{
			throw new ArgumentNullException("localizedTitle");
		}
		IntPtr arg = NSString.CreateNative(localizedTitle);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_Handle, projectType.Handle, arg, localizedAttributedDescription?.Handle ?? IntPtr.Zero, image?.Handle ?? IntPtr.Zero, canProvideSubtypes), "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithProjectType_Title_AttributedDescription_Image_CanProvideSubtypes_Handle, projectType.Handle, arg, localizedAttributedDescription?.Handle ?? IntPtr.Zero, image?.Handle ?? IntPtr.Zero, canProvideSubtypes), "initWithProjectType:title:attributedDescription:image:canProvideSubtypes:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithProjectType:title:description:image:canProvideSubtypes:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription(NSString projectType, string localizedTitle, string? localizedDescription, NSImage? image, bool canProvideSubtypes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		if (localizedTitle == null)
		{
			throw new ArgumentNullException("localizedTitle");
		}
		IntPtr arg = NSString.CreateNative(localizedTitle);
		IntPtr arg2 = NSString.CreateNative(localizedDescription);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero, canProvideSubtypes), "initWithProjectType:title:description:image:canProvideSubtypes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithProjectType_Title_Description_Image_CanProvideSubtypes_Handle, projectType.Handle, arg, arg2, image?.Handle ?? IntPtr.Zero, canProvideSubtypes), "initWithProjectType:title:description:image:canProvideSubtypes:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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
}
