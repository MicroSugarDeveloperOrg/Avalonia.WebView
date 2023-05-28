using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSTextFinderClient", false)]
[Model]
public abstract class NSTextFinderClient : NSObject, INSTextFinderClient, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool Editable
	{
		[Export("isEditable")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSRange FirstSelectedRange
	{
		[Export("firstSelectedRange")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool Selectable
	{
		[Export("isSelectable")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSArray SelectedRanges
	{
		[Export("selectedRanges", ArgumentSemantic.Copy)]
		get;
		[Export("setSelectedRanges:", ArgumentSemantic.Copy)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSArray VisibleCharacterRanges
	{
		[Export("visibleCharacterRanges", ArgumentSemantic.Copy)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSTextFinderClient()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextFinderClient(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextFinderClient(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("contentViewAtIndex:effectiveCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSView ContentViewAtIndexeffectiveCharacterRange(nuint index, ref NSRange outRange);

	[Export("didReplaceCharacters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReplaceCharacters();

	[Export("drawCharactersInRange:forContentView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DrawCharactersInRangeforContentView(NSRange range, NSView view);

	[Export("rectsForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSArray RectsForCharacterRange(NSRange range);

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ReplaceCharactersInRangewithString(NSRange range, string str);

	[Export("scrollRangeToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ScrollRangeToVisible(NSRange range);

	[Export("shouldReplaceCharactersInRanges:withStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool ShouldReplaceCharactersInRangeswithStrings(NSArray ranges, NSArray strings);

	[Export("stringAtIndex:effectiveRange:endsWithSearchBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string StringAtIndexeffectiveRangeendsWithSearchBoundary(nuint characterIndex, ref NSRange outRange, bool outFlag);

	[Export("stringLength")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nuint StringLength();
}
