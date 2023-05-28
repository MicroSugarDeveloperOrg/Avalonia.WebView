using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSTextInputClient", false)]
[Model]
public class NSTextInputClient : NSObject, INSTextInputClient, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedString
	{
		[Export("attributedString")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMarkedText
	{
		[Export("hasMarkedText")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange MarkedRange
	{
		[Export("markedRange")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange SelectedRange
	{
		[Export("selectedRange")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] ValidAttributesForMarkedText
	{
		[Export("validAttributesForMarkedText")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowLevel WindowLevel
	{
		[Export("windowLevel")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextInputClient()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextInputClient(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextInputClient(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("drawsVerticallyForCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrawsVertically(nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("attributedSubstringForProposedRange:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAttributedSubstring(NSRange proposedRange, out NSRange actualRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("baselineDeltaForCharacterAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetBaselineDelta(nuint charIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("characterIndexForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetCharacterIndex(CGPoint point)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("firstRectForCharacterRange:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetFirstRect(NSRange characterRange, out NSRange actualRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fractionOfDistanceThroughGlyphForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetFractionOfDistanceThroughGlyph(CGPoint point)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("insertText:replacementRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertText(NSObject text, NSRange replacementRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("setMarkedText:selectedRange:replacementRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMarkedText(NSObject text, NSRange selectedRange, NSRange replacementRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unmarkText")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnmarkText()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
