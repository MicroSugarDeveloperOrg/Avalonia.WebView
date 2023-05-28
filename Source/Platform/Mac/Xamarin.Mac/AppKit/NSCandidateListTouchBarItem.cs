using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCandidateListTouchBarItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSCandidateListTouchBarItem : NSTouchBarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCollapsing = "allowsCollapsing";

	private static readonly IntPtr selAllowsCollapsingHandle = Selector.GetHandle("allowsCollapsing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsTextInputContextCandidates = "allowsTextInputContextCandidates";

	private static readonly IntPtr selAllowsTextInputContextCandidatesHandle = Selector.GetHandle("allowsTextInputContextCandidates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringForCandidate = "attributedStringForCandidate";

	private static readonly IntPtr selAttributedStringForCandidateHandle = Selector.GetHandle("attributedStringForCandidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidates = "candidates";

	private static readonly IntPtr selCandidatesHandle = Selector.GetHandle("candidates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClient = "client";

	private static readonly IntPtr selClientHandle = Selector.GetHandle("client");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomizationLabel = "customizationLabel";

	private static readonly IntPtr selCustomizationLabelHandle = Selector.GetHandle("customizationLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCandidateListVisible = "isCandidateListVisible";

	private static readonly IntPtr selIsCandidateListVisibleHandle = Selector.GetHandle("isCandidateListVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCollapsed = "isCollapsed";

	private static readonly IntPtr selIsCollapsedHandle = Selector.GetHandle("isCollapsed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCollapsing_ = "setAllowsCollapsing:";

	private static readonly IntPtr selSetAllowsCollapsing_Handle = Selector.GetHandle("setAllowsCollapsing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsTextInputContextCandidates_ = "setAllowsTextInputContextCandidates:";

	private static readonly IntPtr selSetAllowsTextInputContextCandidates_Handle = Selector.GetHandle("setAllowsTextInputContextCandidates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedStringForCandidate_ = "setAttributedStringForCandidate:";

	private static readonly IntPtr selSetAttributedStringForCandidate_Handle = Selector.GetHandle("setAttributedStringForCandidate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCandidates_ForSelectedRange_InString_ = "setCandidates:forSelectedRange:inString:";

	private static readonly IntPtr selSetCandidates_ForSelectedRange_InString_Handle = Selector.GetHandle("setCandidates:forSelectedRange:inString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClient_ = "setClient:";

	private static readonly IntPtr selSetClient_Handle = Selector.GetHandle("setClient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollapsed_ = "setCollapsed:";

	private static readonly IntPtr selSetCollapsed_Handle = Selector.GetHandle("setCollapsed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomizationLabel_ = "setCustomizationLabel:";

	private static readonly IntPtr selSetCustomizationLabel_Handle = Selector.GetHandle("setCustomizationLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithInsertionPointVisibility_ = "updateWithInsertionPointVisibility:";

	private static readonly IntPtr selUpdateWithInsertionPointVisibility_Handle = Selector.GetHandle("updateWithInsertionPointVisibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCandidateListTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Client_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsCollapsing
	{
		[Export("allowsCollapsing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCollapsingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCollapsingHandle);
		}
		[Export("setAllowsCollapsing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCollapsing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCollapsing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsTextInputContextCandidates
	{
		[Export("allowsTextInputContextCandidates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTextInputContextCandidatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTextInputContextCandidatesHandle);
		}
		[Export("setAllowsTextInputContextCandidates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTextInputContextCandidates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTextInputContextCandidates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AttributedStringForCandidateHandler? AttributedStringForCandidate
	{
		[Export("attributedStringForCandidate", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDAttributedStringForCandidateHandler))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringForCandidateHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringForCandidateHandle));
			return Trampolines.NIDAttributedStringForCandidateHandler.Create(block);
		}
		[Export("setAttributedStringForCandidate:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDAttributedStringForCandidateHandler))]
		set
		{
			NSApplication.EnsureUIThread();
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAttributedStringForCandidateHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedStringForCandidate_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedStringForCandidate_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CandidateListVisible
	{
		[Export("isCandidateListVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCandidateListVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCandidateListVisibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Candidates
	{
		[Export("candidates", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selCandidatesHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCandidatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTextInputClient? Client
	{
		[Export("client", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSTextInputClient iNSTextInputClient = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSTextInputClient>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientHandle), owns: false) : Runtime.GetINativeObject<INSTextInputClient>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientHandle), owns: false));
			MarkDirty();
			__mt_Client_var = iNSTextInputClient;
			return iNSTextInputClient;
		}
		[Export("setClient:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClient_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClient_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Client_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Collapsed
	{
		[Export("isCollapsed")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCollapsedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCollapsedHandle);
		}
		[Export("setCollapsed:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCollapsed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCollapsed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string CustomizationLabel
	{
		[Export("customizationLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomizationLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomizationLabelHandle));
		}
		[Export("setCustomizationLabel:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomizationLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomizationLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSCandidateListTouchBarItemDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSCandidateListTouchBarItemDelegate iNSCandidateListTouchBarItemDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSCandidateListTouchBarItemDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<INSCandidateListTouchBarItemDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iNSCandidateListTouchBarItemDelegate;
			return iNSCandidateListTouchBarItemDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCandidateListTouchBarItem(NSCoder coder)
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
	protected NSCandidateListTouchBarItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCandidateListTouchBarItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCandidateListTouchBarItem(string identifier)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setCandidates:forSelectedRange:inString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCandidates(NSObject[] candidates, NSRange selectedRange, string? originalString)
	{
		NSApplication.EnsureUIThread();
		if (candidates == null)
		{
			throw new ArgumentNullException("candidates");
		}
		NSArray nSArray = NSArray.FromNSObjects(candidates);
		IntPtr arg = NSString.CreateNative(originalString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_IntPtr(base.Handle, selSetCandidates_ForSelectedRange_InString_Handle, nSArray.Handle, selectedRange, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_IntPtr(base.SuperHandle, selSetCandidates_ForSelectedRange_InString_Handle, nSArray.Handle, selectedRange, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("updateWithInsertionPointVisibility:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateWithInsertionPointVisibility(bool isVisible)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selUpdateWithInsertionPointVisibility_Handle, isVisible);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selUpdateWithInsertionPointVisibility_Handle, isVisible);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Client_var = null;
			__mt_Delegate_var = null;
		}
	}
}
