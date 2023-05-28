using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIPDF417BarcodeGenerator", WrapperType = typeof(CIPdf417BarcodeGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof(NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinWidth", Selector = "minWidth", PropertyType = typeof(float), GetterSelector = "minWidth", SetterSelector = "setMinWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxWidth", Selector = "maxWidth", PropertyType = typeof(float), GetterSelector = "maxWidth", SetterSelector = "setMaxWidth:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinHeight", Selector = "minHeight", PropertyType = typeof(float), GetterSelector = "minHeight", SetterSelector = "setMinHeight:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxHeight", Selector = "maxHeight", PropertyType = typeof(float), GetterSelector = "maxHeight", SetterSelector = "setMaxHeight:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputDataColumns", Selector = "dataColumns", PropertyType = typeof(float), GetterSelector = "dataColumns", SetterSelector = "setDataColumns:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputRows", Selector = "rows", PropertyType = typeof(float), GetterSelector = "rows", SetterSelector = "setRows:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreferredAspectRatio", Selector = "preferredAspectRatio", PropertyType = typeof(float), GetterSelector = "preferredAspectRatio", SetterSelector = "setPreferredAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCompactionMode", Selector = "compactionMode", PropertyType = typeof(float), GetterSelector = "compactionMode", SetterSelector = "setCompactionMode:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCompactStyle", Selector = "compactStyle", PropertyType = typeof(float), GetterSelector = "compactStyle", SetterSelector = "setCompactStyle:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCorrectionLevel", Selector = "correctionLevel", PropertyType = typeof(float), GetterSelector = "correctionLevel", SetterSelector = "setCorrectionLevel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputAlwaysSpecifyCompaction", Selector = "alwaysSpecifyCompaction", PropertyType = typeof(float), GetterSelector = "alwaysSpecifyCompaction", SetterSelector = "setAlwaysSpecifyCompaction:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIPdf417BarcodeGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get;
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float MinWidth
	{
		[Export("minWidth")]
		get;
		[Export("setMinWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float MaxWidth
	{
		[Export("maxWidth")]
		get;
		[Export("setMaxWidth:")]
		set;
	}

	[Preserve(Conditional = true)]
	float MinHeight
	{
		[Export("minHeight")]
		get;
		[Export("setMinHeight:")]
		set;
	}

	[Preserve(Conditional = true)]
	float MaxHeight
	{
		[Export("maxHeight")]
		get;
		[Export("setMaxHeight:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputDataColumns
	{
		[Export("dataColumns")]
		get;
		[Export("setDataColumns:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputRows
	{
		[Export("rows")]
		get;
		[Export("setRows:")]
		set;
	}

	[Preserve(Conditional = true)]
	float PreferredAspectRatio
	{
		[Export("preferredAspectRatio")]
		get;
		[Export("setPreferredAspectRatio:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputCompactionMode
	{
		[Export("compactionMode")]
		get;
		[Export("setCompactionMode:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputCompactStyle
	{
		[Export("compactStyle")]
		get;
		[Export("setCompactStyle:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputCorrectionLevel
	{
		[Export("correctionLevel")]
		get;
		[Export("setCorrectionLevel:")]
		set;
	}

	[Preserve(Conditional = true)]
	float InputAlwaysSpecifyCompaction
	{
		[Export("alwaysSpecifyCompaction")]
		get;
		[Export("setAlwaysSpecifyCompaction:")]
		set;
	}
}
