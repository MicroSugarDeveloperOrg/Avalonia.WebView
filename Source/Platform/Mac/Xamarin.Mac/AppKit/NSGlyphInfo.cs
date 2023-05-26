using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGlyphInfo", true)]
public class NSGlyphInfo : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseString = "baseString";

	private static readonly IntPtr selBaseStringHandle = Selector.GetHandle("baseString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterCollection = "characterCollection";

	private static readonly IntPtr selCharacterCollectionHandle = Selector.GetHandle("characterCollection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIdentifier = "characterIdentifier";

	private static readonly IntPtr selCharacterIdentifierHandle = Selector.GetHandle("characterIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphID = "glyphID";

	private static readonly IntPtr selGlyphIDHandle = Selector.GetHandle("glyphID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphInfoWithCGGlyph_ForFont_BaseString_ = "glyphInfoWithCGGlyph:forFont:baseString:";

	private static readonly IntPtr selGlyphInfoWithCGGlyph_ForFont_BaseString_Handle = Selector.GetHandle("glyphInfoWithCGGlyph:forFont:baseString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphInfoWithCharacterIdentifier_Collection_BaseString_ = "glyphInfoWithCharacterIdentifier:collection:baseString:";

	private static readonly IntPtr selGlyphInfoWithCharacterIdentifier_Collection_BaseString_Handle = Selector.GetHandle("glyphInfoWithCharacterIdentifier:collection:baseString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphInfoWithGlyph_ForFont_BaseString_ = "glyphInfoWithGlyph:forFont:baseString:";

	private static readonly IntPtr selGlyphInfoWithGlyph_ForFont_BaseString_Handle = Selector.GetHandle("glyphInfoWithGlyph:forFont:baseString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphInfoWithGlyphName_ForFont_BaseString_ = "glyphInfoWithGlyphName:forFont:baseString:";

	private static readonly IntPtr selGlyphInfoWithGlyphName_ForFont_BaseString_Handle = Selector.GetHandle("glyphInfoWithGlyphName:forFont:baseString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphName = "glyphName";

	private static readonly IntPtr selGlyphNameHandle = Selector.GetHandle("glyphName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGlyphInfo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual string BaseString
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("baseString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCharacterCollection CharacterCollection
	{
		[Export("characterCollection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCharacterCollection)Messaging.UInt64_objc_msgSend(base.Handle, selCharacterCollectionHandle);
			}
			return (NSCharacterCollection)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCharacterCollectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CharacterIdentifier
	{
		[Export("characterIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCharacterIdentifierHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCharacterIdentifierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual ushort GlyphId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("glyphID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selGlyphIDHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selGlyphIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GlyphName
	{
		[Export("glyphName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGlyphNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlyphNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGlyphInfo()
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
	public NSGlyphInfo(NSCoder coder)
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
	protected NSGlyphInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGlyphInfo(IntPtr handle)
		: base(handle)
	{
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

	[Export("glyphInfoWithGlyphName:forFont:baseString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGlyphInfo Get(string glyphName, NSFont forFont, string baseString)
	{
		NSApplication.EnsureUIThread();
		if (glyphName == null)
		{
			throw new ArgumentNullException("glyphName");
		}
		if (forFont == null)
		{
			throw new ArgumentNullException("forFont");
		}
		if (baseString == null)
		{
			throw new ArgumentNullException("baseString");
		}
		IntPtr arg = NSString.CreateNative(glyphName);
		IntPtr arg2 = NSString.CreateNative(baseString);
		NSGlyphInfo nSObject = Runtime.GetNSObject<NSGlyphInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selGlyphInfoWithGlyphName_ForFont_BaseString_Handle, arg, forFont.Handle, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("glyphInfoWithGlyph:forFont:baseString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGlyphInfo Get(uint glyph, NSFont forFont, string baseString)
	{
		NSApplication.EnsureUIThread();
		if (forFont == null)
		{
			throw new ArgumentNullException("forFont");
		}
		if (baseString == null)
		{
			throw new ArgumentNullException("baseString");
		}
		IntPtr arg = NSString.CreateNative(baseString);
		NSGlyphInfo nSObject = Runtime.GetNSObject<NSGlyphInfo>(Messaging.IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr(class_ptr, selGlyphInfoWithGlyph_ForFont_BaseString_Handle, glyph, forFont.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("glyphInfoWithCharacterIdentifier:collection:baseString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGlyphInfo Get(nuint characterIdentifier, NSCharacterCollection characterCollection, string baseString)
	{
		NSApplication.EnsureUIThread();
		if (baseString == null)
		{
			throw new ArgumentNullException("baseString");
		}
		IntPtr arg = NSString.CreateNative(baseString);
		NSGlyphInfo nSObject = Runtime.GetNSObject<NSGlyphInfo>(Messaging.IntPtr_objc_msgSend_nuint_UInt64_IntPtr(class_ptr, selGlyphInfoWithCharacterIdentifier_Collection_BaseString_Handle, characterIdentifier, (ulong)characterCollection, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("glyphInfoWithCGGlyph:forFont:baseString:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGlyphInfo? GetGlyphInfo(ushort glyph, NSFont font, string @string)
	{
		NSApplication.EnsureUIThread();
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		NSGlyphInfo nSObject = Runtime.GetNSObject<NSGlyphInfo>(Messaging.IntPtr_objc_msgSend_UInt16_IntPtr_IntPtr(class_ptr, selGlyphInfoWithCGGlyph_ForFont_BaseString_Handle, glyph, font.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
