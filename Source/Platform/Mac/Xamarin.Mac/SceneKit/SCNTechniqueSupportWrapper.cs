using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNTechniqueSupportWrapper : BaseWrapper, ISCNTechniqueSupport, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public SCNTechnique? Technique
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("technique", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<SCNTechnique>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("technique")));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setTechnique:", ArgumentSemantic.Copy)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setTechnique:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[Preserve(Conditional = true)]
	public SCNTechniqueSupportWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
