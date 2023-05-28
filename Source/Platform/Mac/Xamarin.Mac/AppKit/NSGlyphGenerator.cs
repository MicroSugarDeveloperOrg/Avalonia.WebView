using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSGlyphGenerator", true)]
public class NSGlyphGenerator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateGlyphsForGlyphStorage_DesiredNumberOfCharacters_GlyphIndex_CharacterIndex_ = "generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:";

	private static readonly IntPtr selGenerateGlyphsForGlyphStorage_DesiredNumberOfCharacters_GlyphIndex_CharacterIndex_Handle = Selector.GetHandle("generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedGlyphGenerator = "sharedGlyphGenerator";

	private static readonly IntPtr selSharedGlyphGeneratorHandle = Selector.GetHandle("sharedGlyphGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGlyphGenerator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSGlyphGenerator SharedGlyphGenerator
	{
		[Export("sharedGlyphGenerator")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSGlyphGenerator>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedGlyphGeneratorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGlyphGenerator()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSGlyphGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGlyphGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("generateGlyphsForGlyphStorage:desiredNumberOfCharacters:glyphIndex:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GenerateGlyphs(NSObject nsGlyphStorageOrNSLayoutManager, nuint nchars, ref nuint glyphIndex, ref nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (nsGlyphStorageOrNSLayoutManager == null)
		{
			throw new ArgumentNullException("nsGlyphStorageOrNSLayoutManager");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_ref_nuint_ref_nuint(base.Handle, selGenerateGlyphsForGlyphStorage_DesiredNumberOfCharacters_GlyphIndex_CharacterIndex_Handle, nsGlyphStorageOrNSLayoutManager.Handle, nchars, ref glyphIndex, ref charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_ref_nuint_ref_nuint(base.SuperHandle, selGenerateGlyphsForGlyphStorage_DesiredNumberOfCharacters_GlyphIndex_CharacterIndex_Handle, nsGlyphStorageOrNSLayoutManager.Handle, nchars, ref glyphIndex, ref charIndex);
		}
	}
}
