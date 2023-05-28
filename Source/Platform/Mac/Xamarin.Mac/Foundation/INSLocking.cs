using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSLocking", WrapperType = typeof(NSLockingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Lock", Selector = "lock")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Unlock", Selector = "unlock")]
public interface INSLocking : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("lock")]
	[Preserve(Conditional = true)]
	void Lock();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("unlock")]
	[Preserve(Conditional = true)]
	void Unlock();
}
