using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "GKStrategist", WrapperType = typeof(GKStrategistWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBestMoveForActivePlayer", Selector = "bestMoveForActivePlayer", ReturnType = typeof(IGKGameModelUpdate))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "GameModel", Selector = "gameModel", PropertyType = typeof(IGKGameModel), GetterSelector = "gameModel", SetterSelector = "setGameModel:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RandomSource", Selector = "randomSource", PropertyType = typeof(IGKRandom), GetterSelector = "randomSource", SetterSelector = "setRandomSource:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface IGKStrategist : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IGKGameModel? GameModel
	{
		[Export("gameModel", ArgumentSemantic.Retain)]
		get;
		[Export("setGameModel:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	IGKRandom? RandomSource
	{
		[Export("randomSource", ArgumentSemantic.Retain)]
		get;
		[Export("setRandomSource:", ArgumentSemantic.Retain)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("bestMoveForActivePlayer")]
	[Preserve(Conditional = true)]
	IGKGameModelUpdate GetBestMoveForActivePlayer();
}
