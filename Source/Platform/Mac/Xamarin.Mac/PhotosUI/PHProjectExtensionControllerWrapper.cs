using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

internal sealed class PHProjectExtensionControllerWrapper : BaseWrapper, IPHProjectExtensionController, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHProjectExtensionControllerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginProjectWithExtensionContext:projectInfo:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void BeginProject(PHProjectExtensionContext extensionContext, PHProjectInfo projectInfo, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion)
	{
		NSApplication.EnsureUIThread();
		if (extensionContext == null)
		{
			throw new ArgumentNullException("extensionContext");
		}
		if (projectInfo == null)
		{
			throw new ArgumentNullException("projectInfo");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("beginProjectWithExtensionContext:projectInfo:completion:"), extensionContext.Handle, projectInfo.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("resumeProjectWithExtensionContext:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void ResumeProject(PHProjectExtensionContext extensionContext, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion)
	{
		NSApplication.EnsureUIThread();
		if (extensionContext == null)
		{
			throw new ArgumentNullException("extensionContext");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("resumeProjectWithExtensionContext:completion:"), extensionContext.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("finishProjectWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void FinishProject([BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		NSApplication.EnsureUIThread();
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("finishProjectWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}
}
