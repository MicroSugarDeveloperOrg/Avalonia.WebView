using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

internal sealed class NSFileProviderItemFlagsWrapper : BaseWrapper, INSFileProviderItemFlags, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool UserExecutable
	{
		[Export("isUserExecutable")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isUserExecutable"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool UserReadable
	{
		[Export("isUserReadable")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isUserReadable"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool UserWritable
	{
		[Export("isUserWritable")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isUserWritable"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Hidden
	{
		[Export("isHidden")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isHidden"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool PathExtensionHidden
	{
		[Export("isPathExtensionHidden")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isPathExtensionHidden"));
		}
	}

	[Preserve(Conditional = true)]
	public NSFileProviderItemFlagsWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
