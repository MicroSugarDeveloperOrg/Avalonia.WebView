using System;
using Foundation;
using ObjCRuntime;

namespace Vision;

internal sealed class VNRequestProgressProvidingWrapper : BaseWrapper, IVNRequestProgressProviding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNRequestProgressHandler ProgressHandler
	{
		[Export("progressHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDVNRequestProgressHandler))]
		get
		{
			IntPtr block = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("progressHandler"));
			return Trampolines.NIDVNRequestProgressHandler.Create(block);
		}
		[Export("setProgressHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDVNRequestProgressHandler))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestProgressHandler.Handler, value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setProgressHandler:"), (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Indeterminate
	{
		[Export("indeterminate")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("indeterminate"));
		}
	}

	[Preserve(Conditional = true)]
	public VNRequestProgressProvidingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
