using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INPerson", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INPerson : NSObject, IINSpeakable, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAliases = "aliases";

	private static readonly IntPtr selAliasesHandle = Selector.GetHandle("aliases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternativeSpeakableMatches = "alternativeSpeakableMatches";

	private static readonly IntPtr selAlternativeSpeakableMatchesHandle = Selector.GetHandle("alternativeSpeakableMatches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactIdentifier = "contactIdentifier";

	private static readonly IntPtr selContactIdentifierHandle = Selector.GetHandle("contactIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomIdentifier = "customIdentifier";

	private static readonly IntPtr selCustomIdentifierHandle = Selector.GetHandle("customIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_ = "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:";

	private static readonly IntPtr selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Handle = Selector.GetHandle("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Aliases_SuggestionType_ = "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:aliases:suggestionType:";

	private static readonly IntPtr selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Aliases_SuggestionType_Handle = Selector.GetHandle("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:aliases:suggestionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_IsMe_ = "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:isMe:";

	private static readonly IntPtr selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_IsMe_Handle = Selector.GetHandle("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:isMe:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMe = "isMe";

	private static readonly IntPtr selIsMeHandle = Selector.GetHandle("isMe");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameComponents = "nameComponents";

	private static readonly IntPtr selNameComponentsHandle = Selector.GetHandle("nameComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersonHandle = "personHandle";

	private static readonly IntPtr selPersonHandleHandle = Selector.GetHandle("personHandle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPronunciationHint = "pronunciationHint";

	private static readonly IntPtr selPronunciationHintHandle = Selector.GetHandle("pronunciationHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelationship = "relationship";

	private static readonly IntPtr selRelationshipHandle = Selector.GetHandle("relationship");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpokenPhrase = "spokenPhrase";

	private static readonly IntPtr selSpokenPhraseHandle = Selector.GetHandle("spokenPhrase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuggestionType = "suggestionType";

	private static readonly IntPtr selSuggestionTypeHandle = Selector.GetHandle("suggestionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVocabularyIdentifier = "vocabularyIdentifier";

	private static readonly IntPtr selVocabularyIdentifierHandle = Selector.GetHandle("vocabularyIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INPerson");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPersonHandle[]? Aliases
	{
		[Export("aliases", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INPersonHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selAliasesHandle));
			}
			return NSArray.ArrayFromHandle<INPersonHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAliasesHandle));
		}
	}

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
	public virtual string? ContactIdentifier
	{
		[Export("contactIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContactIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? CustomIdentifier
	{
		[Export("customIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCustomIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
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
	public virtual INImage? Image
	{
		[Export("image", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<INImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public virtual bool IsMe
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("isMe")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersonNameComponents? NameComponents
	{
		[Export("nameComponents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selNameComponentsHandle));
			}
			return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPersonHandle? PersonHandle
	{
		[Export("personHandle", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INPersonHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersonHandleHandle));
			}
			return Runtime.GetNSObject<INPersonHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersonHandleHandle));
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
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
	public INPersonRelationship Relationship
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
		get
		{
			return INPersonRelationshipExtensions.GetValue(WeakRelationship);
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
	public virtual INPersonSuggestionType SuggestionType
	{
		[Export("suggestionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INPersonSuggestionType)Messaging.Int64_objc_msgSend(base.Handle, selSuggestionTypeHandle);
			}
			return (INPersonSuggestionType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSuggestionTypeHandle);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
	protected virtual NSString? WeakRelationship
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
		[Export("relationship")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRelationshipHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelationshipHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INPerson(NSCoder coder)
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
	protected INPerson(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INPerson(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INPerson(INPersonHandle personHandle, NSPersonNameComponents? nameComponents, string? displayName, INImage? image, string? contactIdentifier, string? customIdentifier)
		: base(NSObjectFlag.Empty)
	{
		if (personHandle == null)
		{
			throw new ArgumentNullException("personHandle");
		}
		IntPtr arg = NSString.CreateNative(displayName);
		IntPtr arg2 = NSString.CreateNative(contactIdentifier);
		IntPtr arg3 = NSString.CreateNative(customIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:isMe:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INPerson(INPersonHandle personHandle, NSPersonNameComponents? nameComponents, string? displayName, INImage? image, string? contactIdentifier, string? customIdentifier, bool isMe)
		: base(NSObjectFlag.Empty)
	{
		if (personHandle == null)
		{
			throw new ArgumentNullException("personHandle");
		}
		IntPtr arg = NSString.CreateNative(displayName);
		IntPtr arg2 = NSString.CreateNative(contactIdentifier);
		IntPtr arg3 = NSString.CreateNative(customIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_IsMe_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3, isMe), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:isMe:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_IsMe_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3, isMe), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:isMe:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:aliases:suggestionType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INPerson(INPersonHandle personHandle, NSPersonNameComponents? nameComponents, string? displayName, INImage? image, string? contactIdentifier, string? customIdentifier, INPersonHandle[]? aliases, INPersonSuggestionType suggestionType)
		: base(NSObjectFlag.Empty)
	{
		if (personHandle == null)
		{
			throw new ArgumentNullException("personHandle");
		}
		IntPtr arg = NSString.CreateNative(displayName);
		IntPtr arg2 = NSString.CreateNative(contactIdentifier);
		IntPtr arg3 = NSString.CreateNative(customIdentifier);
		NSArray nSArray = ((aliases == null) ? null : NSArray.FromNSObjects(aliases));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.Handle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Aliases_SuggestionType_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3, nSArray?.Handle ?? IntPtr.Zero, (long)suggestionType), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:aliases:suggestionType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.SuperHandle, selInitWithPersonHandle_NameComponents_DisplayName_Image_ContactIdentifier_CustomIdentifier_Aliases_SuggestionType_Handle, personHandle.Handle, nameComponents?.Handle ?? IntPtr.Zero, arg, image?.Handle ?? IntPtr.Zero, arg2, arg3, nSArray?.Handle ?? IntPtr.Zero, (long)suggestionType), "initWithPersonHandle:nameComponents:displayName:image:contactIdentifier:customIdentifier:aliases:suggestionType:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		nSArray?.Dispose();
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
}
