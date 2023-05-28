using ObjCRuntime;

namespace AppKit;

public static class NSTextInputTraits_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetAutocorrectionType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("autocorrectionType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAutocorrectionType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setAutocorrectionType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetSpellCheckingType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("spellCheckingType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSpellCheckingType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setSpellCheckingType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetGrammarCheckingType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("grammarCheckingType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetGrammarCheckingType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setGrammarCheckingType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetSmartQuotesType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("smartQuotesType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSmartQuotesType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setSmartQuotesType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetSmartDashesType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("smartDashesType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSmartDashesType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setSmartDashesType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetSmartInsertDeleteType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("smartInsertDeleteType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSmartInsertDeleteType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setSmartInsertDeleteType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetTextReplacementType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("textReplacementType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTextReplacementType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setTextReplacementType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetDataDetectionType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("dataDetectionType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDataDetectionType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setDataDetectionType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetLinkDetectionType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("linkDetectionType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetLinkDetectionType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setLinkDetectionType:"), (long)value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputTraitType GetTextCompletionType(this INSTextInputTraits This)
	{
		NSApplication.EnsureUIThread();
		return (NSTextInputTraitType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("textCompletionType"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetTextCompletionType(this INSTextInputTraits This, NSTextInputTraitType value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64(This.Handle, Selector.GetHandle("setTextCompletionType:"), (long)value);
	}
}
