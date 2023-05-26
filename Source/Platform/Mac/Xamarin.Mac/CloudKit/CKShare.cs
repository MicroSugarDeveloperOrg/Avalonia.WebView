using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKShare", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKShare : CKRecord
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddParticipant_ = "addParticipant:";

	private static readonly IntPtr selAddParticipant_Handle = Selector.GetHandle("addParticipant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentUserParticipant = "currentUserParticipant";

	private static readonly IntPtr selCurrentUserParticipantHandle = Selector.GetHandle("currentUserParticipant");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRootRecord_ = "initWithRootRecord:";

	private static readonly IntPtr selInitWithRootRecord_Handle = Selector.GetHandle("initWithRootRecord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRootRecord_ShareID_ = "initWithRootRecord:shareID:";

	private static readonly IntPtr selInitWithRootRecord_ShareID_Handle = Selector.GetHandle("initWithRootRecord:shareID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwner = "owner";

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticipants = "participants";

	private static readonly IntPtr selParticipantsHandle = Selector.GetHandle("participants");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublicPermission = "publicPermission";

	private static readonly IntPtr selPublicPermissionHandle = Selector.GetHandle("publicPermission");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveParticipant_ = "removeParticipant:";

	private static readonly IntPtr selRemoveParticipant_Handle = Selector.GetHandle("removeParticipant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPublicPermission_ = "setPublicPermission:";

	private static readonly IntPtr selSetPublicPermission_Handle = Selector.GetHandle("setPublicPermission:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKShare");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKShareParticipant? CurrentUser
	{
		[Export("currentUserParticipant", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKShareParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentUserParticipantHandle));
			}
			return Runtime.GetNSObject<CKShareParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentUserParticipantHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKShareParticipant Owner
	{
		[Export("owner", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKShareParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle));
			}
			return Runtime.GetNSObject<CKShareParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKShareParticipant[] Participants
	{
		[Export("participants", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKShareParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticipantsHandle));
			}
			return NSArray.ArrayFromHandle<CKShareParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticipantsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKShareParticipantPermission PublicPermission
	{
		[Export("publicPermission", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CKShareParticipantPermission)Messaging.Int64_objc_msgSend(base.Handle, selPublicPermissionHandle);
			}
			return (CKShareParticipantPermission)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPublicPermissionHandle);
		}
		[Export("setPublicPermission:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPublicPermission_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPublicPermission_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CKShare(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKShare(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKShare(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRootRecord:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKShare(CKRecord rootRecord)
		: base(NSObjectFlag.Empty)
	{
		if (rootRecord == null)
		{
			throw new ArgumentNullException("rootRecord");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRootRecord_Handle, rootRecord.Handle), "initWithRootRecord:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRootRecord_Handle, rootRecord.Handle), "initWithRootRecord:");
		}
	}

	[Export("initWithRootRecord:shareID:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKShare(CKRecord rootRecord, CKRecordID shareID)
		: base(NSObjectFlag.Empty)
	{
		if (rootRecord == null)
		{
			throw new ArgumentNullException("rootRecord");
		}
		if (shareID == null)
		{
			throw new ArgumentNullException("shareID");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithRootRecord_ShareID_Handle, rootRecord.Handle, shareID.Handle), "initWithRootRecord:shareID:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithRootRecord_ShareID_Handle, rootRecord.Handle, shareID.Handle), "initWithRootRecord:shareID:");
		}
	}

	[Export("addParticipant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(CKShareParticipant participant)
	{
		if (participant == null)
		{
			throw new ArgumentNullException("participant");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddParticipant_Handle, participant.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddParticipant_Handle, participant.Handle);
		}
	}

	[Export("removeParticipant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(CKShareParticipant participant)
	{
		if (participant == null)
		{
			throw new ArgumentNullException("participant");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveParticipant_Handle, participant.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveParticipant_Handle, participant.Handle);
		}
	}
}
