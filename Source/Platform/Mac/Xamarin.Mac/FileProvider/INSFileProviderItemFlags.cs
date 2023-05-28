using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFileProviderItemFlags", WrapperType = typeof(NSFileProviderItemFlagsWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserExecutable", Selector = "userExecutable", PropertyType = typeof(bool), GetterSelector = "isUserExecutable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserReadable", Selector = "userReadable", PropertyType = typeof(bool), GetterSelector = "isUserReadable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserWritable", Selector = "userWritable", PropertyType = typeof(bool), GetterSelector = "isUserWritable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Hidden", Selector = "hidden", PropertyType = typeof(bool), GetterSelector = "isHidden", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PathExtensionHidden", Selector = "pathExtensionHidden", PropertyType = typeof(bool), GetterSelector = "isPathExtensionHidden", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSFileProviderItemFlags : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool UserExecutable
	{
		[Export("isUserExecutable")]
		get;
	}

	[Preserve(Conditional = true)]
	bool UserReadable
	{
		[Export("isUserReadable")]
		get;
	}

	[Preserve(Conditional = true)]
	bool UserWritable
	{
		[Export("isUserWritable")]
		get;
	}

	[Preserve(Conditional = true)]
	bool Hidden
	{
		[Export("isHidden")]
		get;
	}

	[Preserve(Conditional = true)]
	bool PathExtensionHidden
	{
		[Export("isPathExtensionHidden")]
		get;
	}
}
