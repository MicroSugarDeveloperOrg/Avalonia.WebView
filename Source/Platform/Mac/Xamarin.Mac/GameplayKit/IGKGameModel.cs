using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "GKGameModel", WrapperType = typeof(GKGameModelWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPlayers", Selector = "players", ReturnType = typeof(IGKGameModelPlayer[]))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetActivePlayer", Selector = "activePlayer", ReturnType = typeof(IGKGameModelPlayer))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetGameModel", Selector = "setGameModel:", ParameterType = new Type[] { typeof(IGKGameModel) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetGameModelUpdates", Selector = "gameModelUpdatesForPlayer:", ReturnType = typeof(IGKGameModelUpdate[]), ParameterType = new Type[] { typeof(IGKGameModelPlayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ApplyGameModelUpdate", Selector = "applyGameModelUpdate:", ParameterType = new Type[] { typeof(IGKGameModelUpdate) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetScore", Selector = "scoreForPlayer:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(IGKGameModelPlayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsWin", Selector = "isWinForPlayer:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(IGKGameModelPlayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsLoss", Selector = "isLossForPlayer:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(IGKGameModelPlayer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnapplyGameModelUpdate", Selector = "unapplyGameModelUpdate:", ParameterType = new Type[] { typeof(IGKGameModelUpdate) }, ParameterByRef = new bool[] { false })]
public interface IGKGameModel : INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("players")]
	[Preserve(Conditional = true)]
	IGKGameModelPlayer[]? GetPlayers();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("activePlayer")]
	[Preserve(Conditional = true)]
	IGKGameModelPlayer? GetActivePlayer();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setGameModel:")]
	[Preserve(Conditional = true)]
	void SetGameModel(IGKGameModel gameModel);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("gameModelUpdatesForPlayer:")]
	[Preserve(Conditional = true)]
	IGKGameModelUpdate[]? GetGameModelUpdates(IGKGameModelPlayer player);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("applyGameModelUpdate:")]
	[Preserve(Conditional = true)]
	void ApplyGameModelUpdate(IGKGameModelUpdate gameModelUpdate);
}
