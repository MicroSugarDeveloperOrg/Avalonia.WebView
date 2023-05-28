using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Native]
public enum INIntentErrorCode : long
{
	InteractionOperationNotSupported = 1900L,
	DonatingInteraction = 1901L,
	DeletingAllInteractions = 1902L,
	DeletingInteractionWithIdentifiers = 1903L,
	DeletingInteractionWithGroupIdentifier = 1904L,
	IntentSupportedByMultipleExtension = 2001L,
	RestrictedIntentsNotSupportedByExtension = 2002L,
	NoHandlerProvidedForIntent = 2003L,
	InvalidIntentName = 2004L,
	NoAppAvailable = 2005L,
	RequestTimedOut = 3001L,
	MissingInformation = 3002L,
	InvalidUserVocabularyFileLocation = 4000L,
	ExtensionLaunchingTimeout = 5000L,
	ExtensionBringUpFailed = 5001L,
	ImageGeneric = 6000L,
	ImageNoServiceAvailable = 6001L,
	ImageStorageFailed = 6002L,
	ImageLoadingFailed = 6003L,
	ImageRetrievalFailed = 6004L,
	ImageProxyLoop = 6005L,
	ImageProxyInvalid = 6006L,
	ImageProxyTimeout = 6007L,
	ImageServiceFailure = 6008L,
	ImageScalingFailed = 6009L,
	PermissionDenied = 6010L,
	VoiceShortcutCreationFailed = 7000L,
	VoiceShortcutGetFailed = 7001L,
	VoiceShortcutDeleteFailed = 7002L,
	EncodingGeneric = 8000L,
	EncodingFailed = 8001L,
	DecodingGeneric = 9000L
}
