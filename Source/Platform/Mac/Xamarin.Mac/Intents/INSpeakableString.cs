using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSpeakableString", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSpeakableString : NSObject, IINSpeakable, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternativeSpeakableMatches = "alternativeSpeakableMatches";

	private static readonly IntPtr selAlternativeSpeakableMatchesHandle = Selector.GetHandle("alternativeSpeakableMatches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_SpokenPhrase_PronunciationHint_ = "initWithIdentifier:spokenPhrase:pronunciationHint:";

	private static readonly IntPtr selInitWithIdentifier_SpokenPhrase_PronunciationHint_Handle = Selector.GetHandle("initWithIdentifier:spokenPhrase:pronunciationHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSpokenPhrase_ = "initWithSpokenPhrase:";

	private static readonly IntPtr selInitWithSpokenPhrase_Handle = Selector.GetHandle("initWithSpokenPhrase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVocabularyIdentifier_SpokenPhrase_PronunciationHint_ = "initWithVocabularyIdentifier:spokenPhrase:pronunciationHint:";

	private static readonly IntPtr selInitWithVocabularyIdentifier_SpokenPhrase_PronunciationHint_Handle = Selector.GetHandle("initWithVocabularyIdentifier:spokenPhrase:pronunciationHint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPronunciationHint = "pronunciationHint";

	private static readonly IntPtr selPronunciationHintHandle = Selector.GetHandle("pronunciationHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpokenPhrase = "spokenPhrase";

	private static readonly IntPtr selSpokenPhraseHandle = Selector.GetHandle("spokenPhrase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVocabularyIdentifier = "vocabularyIdentifier";

	private static readonly IntPtr selVocabularyIdentifierHandle = Selector.GetHandle("vocabularyIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSpeakableString");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual IINSpeakable[]? AlternativeSpeakableMatches
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("alternativeSpeakableMatches")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IINSpeakable>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternativeSpeakableMatchesHandle));
			}
			return NSArray.ArrayFromHandle<IINSpeakable>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternativeSpeakableMatchesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	public virtual string? Identifier
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
	[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
	public virtual string? PronunciationHint
	{
		[Export("pronunciationHint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPronunciationHintHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPronunciationHintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
	[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
	public virtual string SpokenPhrase
	{
		[Export("spokenPhrase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSpokenPhraseHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpokenPhraseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? VocabularyIdentifier
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("vocabularyIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVocabularyIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVocabularyIdentifierHandle));
		}
	}

	public INSpeakableString(string identifier, string spokenPhrase, string pronunciationHint)
		: base(NSObjectFlag.Empty)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			InitializeHandle(InitWithVocabularyIdentifier(identifier, spokenPhrase, pronunciationHint));
		}
		else
		{
			InitializeHandle(InitWithIdentifier(identifier, spokenPhrase, pronunciationHint));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INSpeakableString(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected INSpeakableString(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSpeakableString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSpokenPhrase:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSpeakableString(string spokenPhrase)
		: base(NSObjectFlag.Empty)
	{
		if (spokenPhrase == null)
		{
			throw new ArgumentNullException("spokenPhrase");
		}
		IntPtr arg = NSString.CreateNative(spokenPhrase);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSpokenPhrase_Handle, arg), "initWithSpokenPhrase:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSpokenPhrase_Handle, arg), "initWithSpokenPhrase:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
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

	[Export("initWithIdentifier:spokenPhrase:pronunciationHint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithIdentifier(string identifier, string spokenPhrase, string? pronunciationHint)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (spokenPhrase == null)
		{
			throw new ArgumentNullException("spokenPhrase");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(spokenPhrase);
		IntPtr arg3 = NSString.CreateNative(pronunciationHint);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_SpokenPhrase_PronunciationHint_Handle, arg, arg2, arg3) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_SpokenPhrase_PronunciationHint_Handle, arg, arg2, arg3));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("initWithVocabularyIdentifier:spokenPhrase:pronunciationHint:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithVocabularyIdentifier(string vocabularyIdentifier, string spokenPhrase, string? pronunciationHint)
	{
		if (vocabularyIdentifier == null)
		{
			throw new ArgumentNullException("vocabularyIdentifier");
		}
		if (spokenPhrase == null)
		{
			throw new ArgumentNullException("spokenPhrase");
		}
		IntPtr arg = NSString.CreateNative(vocabularyIdentifier);
		IntPtr arg2 = NSString.CreateNative(spokenPhrase);
		IntPtr arg3 = NSString.CreateNative(pronunciationHint);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithVocabularyIdentifier_SpokenPhrase_PronunciationHint_Handle, arg, arg2, arg3) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithVocabularyIdentifier_SpokenPhrase_PronunciationHint_Handle, arg, arg2, arg3));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}
}
