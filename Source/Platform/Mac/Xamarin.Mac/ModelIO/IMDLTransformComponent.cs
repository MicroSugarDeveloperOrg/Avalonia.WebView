using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLTransformComponent", WrapperType = typeof(MDLTransformComponentWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLocalTransform", Selector = "setLocalTransform:forTime:", ParameterType = new Type[]
{
	typeof(Matrix4),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLocalTransform", Selector = "setLocalTransform:", ParameterType = new Type[] { typeof(Matrix4) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLocalTransform", Selector = "localTransformAtTime:", ReturnType = typeof(Matrix4), ParameterType = new Type[] { typeof(double) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = true, Name = "CreateGlobalTransform", Selector = "globalTransformWithObject:atTime:", ReturnType = typeof(Matrix4), ParameterType = new Type[]
{
	typeof(MDLObject),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Matrix", Selector = "matrix", PropertyType = typeof(Matrix4), GetterSelector = "matrix", SetterSelector = "setMatrix:", ArgumentSemantic = ArgumentSemantic.Assign)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ResetsTransform", Selector = "resetsTransform", PropertyType = typeof(bool), GetterSelector = "resetsTransform", SetterSelector = "setResetsTransform:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinimumTime", Selector = "minimumTime", PropertyType = typeof(double), GetterSelector = "minimumTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumTime", Selector = "maximumTime", PropertyType = typeof(double), GetterSelector = "maximumTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "KeyTimes", Selector = "keyTimes", PropertyType = typeof(NSNumber[]), GetterSelector = "keyTimes", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface IMDLTransformComponent : INativeObject, IDisposable, IMDLComponent
{
	[Preserve(Conditional = true)]
	Matrix4 Matrix
	{
		[Export("matrix", ArgumentSemantic.Assign)]
		get;
		[Export("setMatrix:", ArgumentSemantic.Assign)]
		set;
	}

	[Preserve(Conditional = true)]
	double MinimumTime
	{
		[Export("minimumTime")]
		get;
	}

	[Preserve(Conditional = true)]
	double MaximumTime
	{
		[Export("maximumTime")]
		get;
	}
}
