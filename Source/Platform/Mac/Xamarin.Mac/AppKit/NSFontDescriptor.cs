using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontDescriptor", true)]
public class NSFontDescriptor : NSObject
{
	private static readonly IntPtr selPostscriptNameHandle = Selector.GetHandle("postscriptName");

	private static readonly IntPtr selPointSizeHandle = Selector.GetHandle("pointSize");

	private static readonly IntPtr selMatrixHandle = Selector.GetHandle("matrix");

	private static readonly IntPtr selSymbolicTraitsHandle = Selector.GetHandle("symbolicTraits");

	private static readonly IntPtr selFontAttributesHandle = Selector.GetHandle("fontAttributes");

	private static readonly IntPtr selObjectForKey_Handle = Selector.GetHandle("objectForKey:");

	private static readonly IntPtr selFontDescriptorWithFontAttributes_Handle = Selector.GetHandle("fontDescriptorWithFontAttributes:");

	private static readonly IntPtr selFontDescriptorWithNameSize_Handle = Selector.GetHandle("fontDescriptorWithName:size:");

	private static readonly IntPtr selFontDescriptorWithNameMatrix_Handle = Selector.GetHandle("fontDescriptorWithName:matrix:");

	private static readonly IntPtr selInitWithFontAttributes_Handle = Selector.GetHandle("initWithFontAttributes:");

	private static readonly IntPtr selMatchingFontDescriptorsWithMandatoryKeys_Handle = Selector.GetHandle("matchingFontDescriptorsWithMandatoryKeys:");

	private static readonly IntPtr selMatchingFontDescriptorWithMandatoryKeys_Handle = Selector.GetHandle("matchingFontDescriptorWithMandatoryKeys:");

	private static readonly IntPtr selFontDescriptorByAddingAttributes_Handle = Selector.GetHandle("fontDescriptorByAddingAttributes:");

	private static readonly IntPtr selFontDescriptorWithSymbolicTraits_Handle = Selector.GetHandle("fontDescriptorWithSymbolicTraits:");

	private static readonly IntPtr selFontDescriptorWithSize_Handle = Selector.GetHandle("fontDescriptorWithSize:");

	private static readonly IntPtr selFontDescriptorWithMatrix_Handle = Selector.GetHandle("fontDescriptorWithMatrix:");

	private static readonly IntPtr selFontDescriptorWithFace_Handle = Selector.GetHandle("fontDescriptorWithFace:");

	private static readonly IntPtr selFontDescriptorWithFamily_Handle = Selector.GetHandle("fontDescriptorWithFamily:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFontDescriptor");

	private object __mt_Matrix_var;

	private object __mt_FontAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string PostscriptName
	{
		[Export("postscriptName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPostscriptNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPostscriptNameHandle));
		}
	}

	public virtual double PointSize
	{
		[Export("pointSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPointSizeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPointSizeHandle);
		}
	}

	public virtual NSAffineTransform Matrix
	{
		[Export("matrix")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAffineTransform)(__mt_Matrix_var = ((!IsDirectBinding) ? ((NSAffineTransform)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatrixHandle))) : ((NSAffineTransform)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMatrixHandle)))));
		}
	}

	public virtual NSFontSymbolicTraits SymbolicTraits
	{
		[Export("symbolicTraits")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSFontSymbolicTraits)Messaging.int_objc_msgSend(base.Handle, selSymbolicTraitsHandle);
			}
			return (NSFontSymbolicTraits)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSymbolicTraitsHandle);
		}
	}

	public virtual NSDictionary FontAttributes
	{
		[Export("fontAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_FontAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFontAttributesHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontDescriptor()
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
	public NSFontDescriptor(NSCoder coder)
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
	public NSFontDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFontDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectForKey:")]
	public virtual NSObject ObjectForKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontDescriptorWithFontAttributes:")]
	public static NSFontDescriptor FromAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontDescriptorWithFontAttributes_Handle, attributes.Handle));
	}

	[Export("fontDescriptorWithName:size:")]
	public static NSFontDescriptor FromNameSize(string fontName, double size)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		NSFontDescriptor result = (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFontDescriptorWithNameSize_Handle, arg, size));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontDescriptorWithName:matrix:")]
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
		NSFontDescriptor result = (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFontDescriptorWithNameMatrix_Handle, arg, matrix.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithFontAttributes:")]
	public NSFontDescriptor(NSDictionary attributes)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFontAttributes_Handle, attributes.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFontAttributes_Handle, attributes.Handle);
		}
	}

	[Export("matchingFontDescriptorsWithMandatoryKeys:")]
	public virtual NSFontDescriptor[] MatchingFontDescriptors(NSSet mandatoryKeys)
	{
		NSApplication.EnsureUIThread();
		if (mandatoryKeys == null)
		{
			throw new ArgumentNullException("mandatoryKeys");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingFontDescriptorsWithMandatoryKeys_Handle, mandatoryKeys.Handle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingFontDescriptorsWithMandatoryKeys_Handle, mandatoryKeys.Handle));
	}

	[Export("matchingFontDescriptorWithMandatoryKeys:")]
	public virtual NSFontDescriptor MatchingFontDescriptorWithMandatoryKeys(NSSet mandatoryKeys)
	{
		NSApplication.EnsureUIThread();
		if (mandatoryKeys == null)
		{
			throw new ArgumentNullException("mandatoryKeys");
		}
		if (IsDirectBinding)
		{
			return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingFontDescriptorWithMandatoryKeys_Handle, mandatoryKeys.Handle));
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingFontDescriptorWithMandatoryKeys_Handle, mandatoryKeys.Handle));
	}

	[Export("fontDescriptorByAddingAttributes:")]
	public virtual NSFontDescriptor FontDescriptorByAddingAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (IsDirectBinding)
		{
			return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorByAddingAttributes_Handle, attributes.Handle));
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorByAddingAttributes_Handle, attributes.Handle));
	}

	[Export("fontDescriptorWithSymbolicTraits:")]
	public virtual NSFontDescriptor FontDescriptorWithSymbolicTraits(NSFontSymbolicTraits symbolicTraits)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selFontDescriptorWithSymbolicTraits_Handle, (int)symbolicTraits));
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selFontDescriptorWithSymbolicTraits_Handle, (int)symbolicTraits));
	}

	[Export("fontDescriptorWithSize:")]
	public virtual NSFontDescriptor FontDescriptorWithSize(double newPointSize)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selFontDescriptorWithSize_Handle, newPointSize));
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selFontDescriptorWithSize_Handle, newPointSize));
	}

	[Export("fontDescriptorWithMatrix:")]
	public virtual NSFontDescriptor FontDescriptorWithMatrix(NSAffineTransform matrix)
	{
		NSApplication.EnsureUIThread();
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		if (IsDirectBinding)
		{
			return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithMatrix_Handle, matrix.Handle));
		}
		return (NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithMatrix_Handle, matrix.Handle));
	}

	[Export("fontDescriptorWithFace:")]
	public virtual NSFontDescriptor FontDescriptorWithFace(string newFace)
	{
		NSApplication.EnsureUIThread();
		if (newFace == null)
		{
			throw new ArgumentNullException("newFace");
		}
		IntPtr arg = NSString.CreateNative(newFace);
		NSFontDescriptor result = ((!IsDirectBinding) ? ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithFace_Handle, arg))) : ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithFace_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontDescriptorWithFamily:")]
	public virtual NSFontDescriptor FontDescriptorWithFamily(string newFamily)
	{
		NSApplication.EnsureUIThread();
		if (newFamily == null)
		{
			throw new ArgumentNullException("newFamily");
		}
		IntPtr arg = NSString.CreateNative(newFamily);
		NSFontDescriptor result = ((!IsDirectBinding) ? ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorWithFamily_Handle, arg))) : ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorWithFamily_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Matrix_var = null;
			__mt_FontAttributes_var = null;
		}
	}
}
