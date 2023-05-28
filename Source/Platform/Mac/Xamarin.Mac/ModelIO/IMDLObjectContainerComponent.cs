using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLObjectContainerComponent", WrapperType = typeof(MDLObjectContainerComponentWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddObject", Selector = "addObject:", ParameterType = new Type[] { typeof(MDLObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveObject", Selector = "removeObject:", ParameterType = new Type[] { typeof(MDLObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetObject", Selector = "objectAtIndexedSubscript:", ReturnType = typeof(MDLObject), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Count", Selector = "count", PropertyType = typeof(nuint), GetterSelector = "count", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Objects", Selector = "objects", PropertyType = typeof(MDLObject[]), GetterSelector = "objects", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface IMDLObjectContainerComponent : INativeObject, IDisposable, IMDLComponent
{
	[Preserve(Conditional = true)]
	MDLObject[] Objects
	{
		[Export("objects", ArgumentSemantic.Retain)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addObject:")]
	[Preserve(Conditional = true)]
	void AddObject(MDLObject @object);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeObject:")]
	[Preserve(Conditional = true)]
	void RemoveObject(MDLObject @object);
}
