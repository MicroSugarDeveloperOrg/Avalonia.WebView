using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTextCheckingController", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSTextCheckingController : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeSpelling_ = "changeSpelling:";

	private static readonly IntPtr selChangeSpelling_Handle = Selector.GetHandle("changeSpelling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpelling_ = "checkSpelling:";

	private static readonly IntPtr selCheckSpelling_Handle = Selector.GetHandle("checkSpelling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInDocument_ = "checkTextInDocument:";

	private static readonly IntPtr selCheckTextInDocument_Handle = Selector.GetHandle("checkTextInDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInRange_Types_Options_ = "checkTextInRange:types:options:";

	private static readonly IntPtr selCheckTextInRange_Types_Options_Handle = Selector.GetHandle("checkTextInRange:types:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckTextInSelection_ = "checkTextInSelection:";

	private static readonly IntPtr selCheckTextInSelection_Handle = Selector.GetHandle("checkTextInSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClient = "client";

	private static readonly IntPtr selClientHandle = Selector.GetHandle("client");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConsiderTextCheckingForRange_ = "considerTextCheckingForRange:";

	private static readonly IntPtr selConsiderTextCheckingForRange_Handle = Selector.GetHandle("considerTextCheckingForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeSelectedRange = "didChangeSelectedRange";

	private static readonly IntPtr selDidChangeSelectedRangeHandle = Selector.GetHandle("didChangeSelectedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeTextInRange_ = "didChangeTextInRange:";

	private static readonly IntPtr selDidChangeTextInRange_Handle = Selector.GetHandle("didChangeTextInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreSpelling_ = "ignoreSpelling:";

	private static readonly IntPtr selIgnoreSpelling_Handle = Selector.GetHandle("ignoreSpelling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithClient_ = "initWithClient:";

	private static readonly IntPtr selInitWithClient_Handle = Selector.GetHandle("initWithClient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertedTextInRange_ = "insertedTextInRange:";

	private static readonly IntPtr selInsertedTextInRange_Handle = Selector.GetHandle("insertedTextInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuAtIndex_ClickedOnSelection_EffectiveRange_ = "menuAtIndex:clickedOnSelection:effectiveRange:";

	private static readonly IntPtr selMenuAtIndex_ClickedOnSelection_EffectiveRange_Handle = Selector.GetHandle("menuAtIndex:clickedOnSelection:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontSubstitutionsPanel_ = "orderFrontSubstitutionsPanel:";

	private static readonly IntPtr selOrderFrontSubstitutionsPanel_Handle = Selector.GetHandle("orderFrontSubstitutionsPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpellCheckerDocumentTag_ = "setSpellCheckerDocumentTag:";

	private static readonly IntPtr selSetSpellCheckerDocumentTag_Handle = Selector.GetHandle("setSpellCheckerDocumentTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowGuessPanel_ = "showGuessPanel:";

	private static readonly IntPtr selShowGuessPanel_Handle = Selector.GetHandle("showGuessPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpellCheckerDocumentTag = "spellCheckerDocumentTag";

	private static readonly IntPtr selSpellCheckerDocumentTagHandle = Selector.GetHandle("spellCheckerDocumentTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCandidates = "updateCandidates";

	private static readonly IntPtr selUpdateCandidatesHandle = Selector.GetHandle("updateCandidates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidAnnotations = "validAnnotations";

	private static readonly IntPtr selValidAnnotationsHandle = Selector.GetHandle("validAnnotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextCheckingController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTextCheckingClient Client
	{
		[Export("client")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<INSTextCheckingClient>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientHandle), owns: false);
			}
			return Runtime.GetINativeObject<INSTextCheckingClient>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SpellCheckerDocumentTag
	{
		[Export("spellCheckerDocumentTag")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSpellCheckerDocumentTagHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSpellCheckerDocumentTagHandle);
		}
		[Export("setSpellCheckerDocumentTag:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSpellCheckerDocumentTag_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSpellCheckerDocumentTag_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ValidAnnotations
	{
		[Export("validAnnotations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValidAnnotationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValidAnnotationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextCheckingController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextCheckingController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithClient:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextCheckingController(INSTextCheckingClient client)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithClient_Handle, client.Handle), "initWithClient:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithClient_Handle, client.Handle), "initWithClient:");
		}
	}

	[Export("changeSpelling:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeSpelling(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("checkSpelling:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckSpelling(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("checkTextInRange:types:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckText(NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selCheckTextInRange_Types_Options_Handle, range, (ulong)checkingTypes, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selCheckTextInRange_Types_Options_Handle, range, (ulong)checkingTypes, options.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void CheckText(NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options)
	{
		CheckText(range, checkingTypes, options.GetDictionary());
	}

	[Export("checkTextInDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckTextInDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("checkTextInSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckTextInSelection(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCheckTextInSelection_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckTextInSelection_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("considerTextCheckingForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConsiderTextChecking(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selConsiderTextCheckingForRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selConsiderTextCheckingForRange_Handle, range);
		}
	}

	[Export("didChangeSelectedRange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeSelectedRange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDidChangeSelectedRangeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDidChangeSelectedRangeHandle);
		}
	}

	[Export("didChangeTextInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeText(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDidChangeTextInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDidChangeTextInRange_Handle, range);
		}
	}

	[Export("menuAtIndex:clickedOnSelection:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu? GetMenu(nuint location, bool clickedOnSelection, ref NSRange effectiveRange)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_nuint_bool_ref_NSRange(base.Handle, selMenuAtIndex_ClickedOnSelection_EffectiveRange_Handle, location, clickedOnSelection, ref effectiveRange));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_nuint_bool_ref_NSRange(base.SuperHandle, selMenuAtIndex_ClickedOnSelection_EffectiveRange_Handle, location, clickedOnSelection, ref effectiveRange));
	}

	[Export("ignoreSpelling:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IgnoreSpelling(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selIgnoreSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selIgnoreSpelling_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("insertedTextInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertedText(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInsertedTextInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInsertedTextInRange_Handle, range);
		}
	}

	[Export("invalidate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("orderFrontSubstitutionsPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontSubstitutionsPanel(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontSubstitutionsPanel_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontSubstitutionsPanel_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("showGuessPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowGuessPanel(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowGuessPanel_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowGuessPanel_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("updateCandidates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCandidates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateCandidatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateCandidatesHandle);
		}
	}
}
