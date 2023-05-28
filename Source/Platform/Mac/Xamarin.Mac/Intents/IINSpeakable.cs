using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INSpeakable", WrapperType = typeof(INSpeakableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpokenPhrase", Selector = "spokenPhrase", PropertyType = typeof(string), GetterSelector = "spokenPhrase", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PronunciationHint", Selector = "pronunciationHint", PropertyType = typeof(string), GetterSelector = "pronunciationHint", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "VocabularyIdentifier", Selector = "vocabularyIdentifier", PropertyType = typeof(string), GetterSelector = "vocabularyIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AlternativeSpeakableMatches", Selector = "alternativeSpeakableMatches", PropertyType = typeof(IINSpeakable[]), GetterSelector = "alternativeSpeakableMatches", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof(string), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.None)]
public interface IINSpeakable : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string SpokenPhrase
	{
		[Export("spokenPhrase")]
		get;
	}

	[Preserve(Conditional = true)]
	string? PronunciationHint
	{
		[Export("pronunciationHint")]
		get;
	}

	[Preserve(Conditional = true)]
	string? Identifier
	{
		[Export("identifier")]
		get;
	}
}
