using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontDescriptor", true)]
public class NSFontDescriptor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontAttributes = "fontAttributes";

	private static readonly IntPtr selFontAttributesHandle = Selector.GetHandle("fontAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorByAddingAttributes_ = "fontDescriptorByAddingAttributes:";

	private static readonly IntPtr selFontDescriptorByAddingAttributes_Handle = Selector.GetHandle("fontDescriptorByAddingAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithDesign_ = "fontDescriptorWithDesign:";

	private static readonly IntPtr selFontDescriptorWithDesign_Handle = Selector.GetHandle("fontDescriptorWithDesign:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithFace_ = "fontDescriptorWithFace:";

	private static readonly IntPtr selFontDescriptorWithFace_Handle = Selector.GetHandle("fontDescriptorWithFace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithFamily_ = "fontDescriptorWithFamily:";

	private static readonly IntPtr selFontDescriptorWithFamily_Handle = Selector.GetHandle("fontDescriptorWithFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithFontAttributes_ = "fontDescriptorWithFontAttributes:";

	private static readonly IntPtr selFontDescriptorWithFontAttributes_Handle = Selector.GetHandle("fontDescriptorWithFontAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithMatrix_ = "fontDescriptorWithMatrix:";

	private static readonly IntPtr selFontDescriptorWithMatrix_Handle = Selector.GetHandle("fontDescriptorWithMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithName_Matrix_ = "fontDescriptorWithName:matrix:";

	private static readonly IntPtr selFontDescriptorWithName_Matrix_Handle = Selector.GetHandle("fontDescriptorWithName:matrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithName_Size_ = "fontDescriptorWithName:size:";

	private static readonly IntPtr selFontDescriptorWithName_Size_Handle = Selector.GetHandle("fontDescriptorWithName:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithSize_ = "fontDescriptorWithSize:";

	private static readonly IntPtr selFontDescriptorWithSize_Handle = Selector.GetHandle("fontDescriptorWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorWithSymbolicTraits_ = "fontDescriptorWithSymbolicTraits:";

	private static readonly IntPtr selFontDescriptorWithSymbolicTraits_Handle = Selector.GetHandle("fontDescriptorWithSymbolicTraits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFontAttributes_ = "initWithFontAttributes:";

	private static readonly IntPtr selInitWithFontAttributes_Handle = Selector.GetHandle("initWithFontAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingFontDescriptorWithMandatoryKeys_ = "matchingFontDescriptorWithMandatoryKeys:";

	private static readonly IntPtr selMatchingFontDescriptorWithMandatoryKeys_Handle = Selector.GetHandle("matchingFontDescriptorWithMandatoryKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingFontDescriptorsWithMandatoryKeys_ = "matchingFontDescriptorsWithMandatoryKeys:";

	private static readonly IntPtr selMatchingFontDescriptorsWithMandatoryKeys_Handle = Selector.GetHandle("matchingFontDescriptorsWithMandatoryKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrix = "matrix";

	private static readonly IntPtr selMatrixHandle = Selector.GetHandle("matrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKey_ = "objectForKey:";

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointSize = "pointSize";

	private static readonly IntPtr selPointSizeHandle = Selector.GetHandle("pointSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostscriptName = "postscriptName";

	private static readonly IntPtr selPostscriptNameHandle = Selector.GetHandle("postscriptName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresFontAssetRequest = "requiresFontAssetRequest";

	private static readonly IntPtr selRequiresFontAssetRequestHandle = Selector.GetHandle("requiresFontAssetRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbolicTraits = "symbolicTraits";

	private static readonly IntPtr selSymbolicTraitsHandle = Selector.GetHandle("symbolicTraits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFontDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FontAttributes
	{
		[Export("fontAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAffineTransform Matrix
	{
		[Export("matrix")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAffineTransform>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatrixHandle));
			}
			return Runtime.GetNSObject<NSAffineTransform>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatrixHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PointSize
	{
		[Export("pointSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPointSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPointSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PostscriptName
	{
		[Export("postscriptName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPostscriptNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPostscriptNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool RequiresFontAssetRequest
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("requiresFontAssetRequest")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequiresFontAssetRequestHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresFontAssetRequestHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontSymbolicTraits SymbolicTraits
	{
		[Export("symbolicTraits")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSFontSymbolicTraits)Messaging.int_objc_msgSend(base.Handle, selSymbolicTraitsHandle);
			}
			return (NSFontSymbolicTraits)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSymbolicTraitsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontDescriptor()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSFontDescriptor(NSCoder coder)
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
	protected NSFontDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFontDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFontAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFontDescriptor(NSDictionary? attributes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFontAttributes_Handle, attributes?.Handle ?? IntPtr.Zero), "initWithFontAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFontAttributes_Handle, attributes?.Handle ?? IntPtr.Zero), "initWithFontAttributes:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("fontDescriptorWithDesign:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor? Create(NSFontDescriptorSystemDesign design)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selFontDescriptorWithDesign_Handle, (int)design));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selFontDescriptorWithDesign_Handle, (int)design));
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

	[Export("fontDescriptorByAddingAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorByAddingAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorByAddingAttributes_Handle, attributes.Handle));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorByAddingAttributes_Handle, attributes.Handle));
	}

	[Export("fontDescriptorWithFace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorWithFace(string newFace)
	{
		NSApplication.EnsureUIThread();
		if (newFace == null)
		{
			throw new ArgumentNullException("newFace");
		}
		IntPtr arg = NSString.CreateNative(newFace);
		NSFontDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithFace_Handle, arg)) : Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithFace_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontDescriptorWithFamily:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorWithFamily(string newFamily)
	{
		NSApplication.EnsureUIThread();
		if (newFamily == null)
		{
			throw new ArgumentNullException("newFamily");
		}
		IntPtr arg = NSString.CreateNative(newFamily);
		NSFontDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithFamily_Handle, arg)) : Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithFamily_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontDescriptorWithMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorWithMatrix(NSAffineTransform matrix)
	{
		NSApplication.EnsureUIThread();
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithMatrix_Handle, matrix.Handle));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithMatrix_Handle, matrix.Handle));
	}

	[Export("fontDescriptorWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorWithSize(nfloat newPointSize)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selFontDescriptorWithSize_Handle, newPointSize));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selFontDescriptorWithSize_Handle, newPointSize));
	}

	[Export("fontDescriptorWithSymbolicTraits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptorWithSymbolicTraits(NSFontSymbolicTraits symbolicTraits)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selFontDescriptorWithSymbolicTraits_Handle, (int)symbolicTraits));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selFontDescriptorWithSymbolicTraits_Handle, (int)symbolicTraits));
	}

	[Export("fontDescriptorWithFontAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontDescriptor FromAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontDescriptorWithFontAttributes_Handle, attributes.Handle));
	}

	[Export("fontDescriptorWithName:matrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontDescriptor FromNameMatrix(string fontName, NSAffineTransform matrix)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		NSFontDescriptor nSObject = Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFontDescriptorWithName_Matrix_Handle, arg, matrix.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fontDescriptorWithName:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontDescriptor FromNameSize(string fontName, nfloat size)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		NSFontDescriptor nSObject = Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selFontDescriptorWithName_Size_Handle, arg, size));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("matchingFontDescriptorWithMandatoryKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor MatchingFontDescriptorWithMandatoryKeys(NSSet mandatoryKeys)
	{
		NSApplication.EnsureUIThread();
		if (mandatoryKeys == null)
		{
			throw new ArgumentNullException("mandatoryKeys");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingFontDescriptorWithMandatoryKeys_Handle, mandatoryKeys.Handle));
		}
		return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingFontDescriptorWithMandatoryKeys_Handle, mandatoryKeys.Handle));
	}

	[Export("matchingFontDescriptorsWithMandatoryKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] MatchingFontDescriptors(NSSet mandatoryKeys)
	{
		NSApplication.EnsureUIThread();
		if (mandatoryKeys == null)
		{
			throw new ArgumentNullException("mandatoryKeys");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingFontDescriptorsWithMandatoryKeys_Handle, mandatoryKeys.Handle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingFontDescriptorsWithMandatoryKeys_Handle, mandatoryKeys.Handle));
	}

	[Export("objectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectForKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
