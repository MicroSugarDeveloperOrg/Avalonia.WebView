using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Protocol(Name = "NSObject", WrapperType = typeof(NSObjectProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNativeHash", Selector = "hash", ReturnType = typeof(nuint))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsEqual", Selector = "isEqual:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSObject) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformSelector", Selector = "performSelector:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(Selector) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformSelector", Selector = "performSelector:withObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(Selector),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformSelector", Selector = "performSelector:withObject:withObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(Selector),
	typeof(NSObject),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsKindOfClass", Selector = "isKindOfClass:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(Class) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsMemberOfClass", Selector = "isMemberOfClass:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(Class) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConformsToProtocol", Selector = "conformsToProtocol:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(IntPtr) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RespondsToSelector", Selector = "respondsToSelector:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(Selector) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DangerousRetain", Selector = "retain", ReturnType = typeof(NSObject))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DangerousRelease", Selector = "release")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DangerousAutorelease", Selector = "autorelease", ReturnType = typeof(NSObject))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Description", Selector = "description", PropertyType = typeof(string), GetterSelector = "description", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DebugDescription", Selector = "debugDescription", PropertyType = typeof(string), GetterSelector = "debugDescription", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Superclass", Selector = "superclass", PropertyType = typeof(Class), GetterSelector = "superclass", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Class", Selector = "class", PropertyType = typeof(Class), GetterSelector = "class", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Self", Selector = "self", PropertyType = typeof(NSObject), GetterSelector = "self", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsProxy", Selector = "isProxy", PropertyType = typeof(bool), GetterSelector = "isProxy", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RetainCount", Selector = "retainCount", PropertyType = typeof(nuint), GetterSelector = "retainCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Zone", Selector = "zone", PropertyType = typeof(NSZone), GetterSelector = "zone", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSObjectProtocol : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Description
	{
		[Export("description")]
		get;
	}

	[Preserve(Conditional = true)]
	Class Superclass
	{
		[Export("superclass")]
		get;
	}

	[Preserve(Conditional = true)]
	Class Class
	{
		[Export("class")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject Self
	{
		[Export("self")]
		get;
	}

	[Preserve(Conditional = true)]
	bool IsProxy
	{
		[Export("isProxy")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint RetainCount
	{
		[Export("retainCount")]
		get;
	}

	[Preserve(Conditional = true)]
	NSZone Zone
	{
		[Export("zone")]
		get;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("hash")]
	[Preserve(Conditional = true)]
	nuint GetNativeHash();

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isEqual:")]
	[Preserve(Conditional = true)]
	bool IsEqual(NSObject? anObject);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("performSelector:")]
	[Preserve(Conditional = true)]
	NSObject PerformSelector(Selector aSelector);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("performSelector:withObject:")]
	[Preserve(Conditional = true)]
	NSObject PerformSelector(Selector aSelector, NSObject? anObject);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("performSelector:withObject:withObject:")]
	[Preserve(Conditional = true)]
	NSObject PerformSelector(Selector aSelector, NSObject? object1, NSObject? object2);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isKindOfClass:")]
	[Preserve(Conditional = true)]
	bool IsKindOfClass(Class? aClass);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("isMemberOfClass:")]
	[Preserve(Conditional = true)]
	bool IsMemberOfClass(Class? aClass);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("conformsToProtocol:")]
	[Preserve(Conditional = true)]
	bool ConformsToProtocol(IntPtr aProtocol);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("respondsToSelector:")]
	[Preserve(Conditional = true)]
	bool RespondsToSelector(Selector? sel);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("retain")]
	[Preserve(Conditional = true)]
	NSObject DangerousRetain();

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("release")]
	[Preserve(Conditional = true)]
	void DangerousRelease();

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("autorelease")]
	[Preserve(Conditional = true)]
	NSObject DangerousAutorelease();
}
