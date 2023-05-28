using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSTextInputTraits", WrapperType = typeof(NSTextInputTraitsWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutocorrectionType", Selector = "autocorrectionType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "autocorrectionType", SetterSelector = "setAutocorrectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpellCheckingType", Selector = "spellCheckingType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "spellCheckingType", SetterSelector = "setSpellCheckingType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "GrammarCheckingType", Selector = "grammarCheckingType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "grammarCheckingType", SetterSelector = "setGrammarCheckingType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartQuotesType", Selector = "smartQuotesType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "smartQuotesType", SetterSelector = "setSmartQuotesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartDashesType", Selector = "smartDashesType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "smartDashesType", SetterSelector = "setSmartDashesType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SmartInsertDeleteType", Selector = "smartInsertDeleteType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "smartInsertDeleteType", SetterSelector = "setSmartInsertDeleteType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextReplacementType", Selector = "textReplacementType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "textReplacementType", SetterSelector = "setTextReplacementType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DataDetectionType", Selector = "dataDetectionType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "dataDetectionType", SetterSelector = "setDataDetectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "LinkDetectionType", Selector = "linkDetectionType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "linkDetectionType", SetterSelector = "setLinkDetectionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "TextCompletionType", Selector = "textCompletionType", PropertyType = typeof(NSTextInputTraitType), GetterSelector = "textCompletionType", SetterSelector = "setTextCompletionType:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface INSTextInputTraits : INativeObject, IDisposable
{
}
