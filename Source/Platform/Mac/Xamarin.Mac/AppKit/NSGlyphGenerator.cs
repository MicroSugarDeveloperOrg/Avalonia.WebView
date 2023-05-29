using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGlyphGenerator", true)]
public class NSGlyphGenerator : NSObject
{
	private static readonly IntPtr selSharedGlyphGeneratorHandle = Selector.GetHandle("sharedGlyphGenerator");

	private static readonly IntPtr selGenerateGlyphsForGlyphStorageDesiredNumberOfCharactersGlyphIndexCharacterIndex_Handle = Selector.GetHandle("generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSGlyphGenerator");

	private static object __mt_SharedGlyphGenerator_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSGlyphGenerator SharedGlyphGenerator
	{
		[Export("sharedGlyphGenerator")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSGlyphGenerator)(__mt_SharedGlyphGenerator_var_static = (NSGlyphGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedGlyphGeneratorHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGlyphGenerator()
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
	public NSGlyphGenerator(NSCoder coder)
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
	public NSGlyphGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSGlyphGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:")]
	public virtual void GenerateGlyphs(NSObject nsGlyphStorageOrNSLayoutManager, ulong nchars, ref ulong glyphIndex, ref ulong charIndex)
	{
		NSApplication.EnsureUIThread();
		if (nsGlyphStorageOrNSLayoutManager == null)
		{
			throw new ArgumentNullException("nsGlyphStorageOrNSLayoutManager");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_out_UInt64_out_UInt64(base.Handle, selGenerateGlyphsForGlyphStorageDesiredNumberOfCharactersGlyphIndexCharacterIndex_Handle, nsGlyphStorageOrNSLayoutManager.Handle, nchars, out glyphIndex, out charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_out_UInt64_out_UInt64(base.SuperHandle, selGenerateGlyphsForGlyphStorageDesiredNumberOfCharactersGlyphIndexCharacterIndex_Handle, nsGlyphStorageOrNSLayoutManager.Handle, nchars, out glyphIndex, out charIndex);
		}
	}
}
