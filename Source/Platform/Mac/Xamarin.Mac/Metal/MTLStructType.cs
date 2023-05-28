using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLStructType", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLStructType : MTLType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMemberByName_ = "memberByName:";

	private static readonly IntPtr selMemberByName_Handle = Selector.GetHandle("memberByName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMembers = "members";

	private static readonly IntPtr selMembersHandle = Selector.GetHandle("members");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLStructType");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructMember[] Members
	{
		[Export("members")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MTLStructMember>(Messaging.IntPtr_objc_msgSend(base.Handle, selMembersHandle));
			}
			return NSArray.ArrayFromHandle<MTLStructMember>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMembersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLStructType()
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
	protected MTLStructType(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLStructType(IntPtr handle)
		: base(handle)
	{
	}

	[Export("memberByName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructMember Lookup(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MTLStructMember result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MTLStructMember>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMemberByName_Handle, arg)) : Runtime.GetNSObject<MTLStructMember>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMemberByName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
