using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSDirectoryEnumerator", true)]
public class NSDirectoryEnumerator : NSEnumerator, IEnumerator<NSString>, IDisposable, IEnumerator, IEnumerator<string>
{
	private NSObject current;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectoryAttributes = "directoryAttributes";

	private static readonly IntPtr selDirectoryAttributesHandle = Selector.GetHandle("directoryAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileAttributes = "fileAttributes";

	private static readonly IntPtr selFileAttributesHandle = Selector.GetHandle("fileAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnumeratingDirectoryPostOrder = "isEnumeratingDirectoryPostOrder";

	private static readonly IntPtr selIsEnumeratingDirectoryPostOrderHandle = Selector.GetHandle("isEnumeratingDirectoryPostOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkipDescendents = "skipDescendents";

	private static readonly IntPtr selSkipDescendentsHandle = Selector.GetHandle("skipDescendents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDirectoryEnumerator");

	string IEnumerator<string>.Current => current.ToString();

	NSString IEnumerator<NSString>.Current => current as NSString;

	object IEnumerator.Current => current;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DirectoryAttributes
	{
		[Export("directoryAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FileAttributes
	{
		[Export("fileAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool IsEnumeratingDirectoryPostOrder
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isEnumeratingDirectoryPostOrder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnumeratingDirectoryPostOrderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnumeratingDirectoryPostOrderHandle);
		}
	}

	bool IEnumerator.MoveNext()
	{
		current = NextObject();
		return current != null;
	}

	void IEnumerator.Reset()
	{
		throw new InvalidOperationException();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDirectoryEnumerator()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDirectoryEnumerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDirectoryEnumerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("skipDescendents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SkipDescendents()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSkipDescendentsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSkipDescendentsHandle);
		}
	}
}
