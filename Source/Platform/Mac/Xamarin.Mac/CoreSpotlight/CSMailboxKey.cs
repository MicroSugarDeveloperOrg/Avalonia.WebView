using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public static class CSMailboxKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Archive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Drafts;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Inbox;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Junk;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Sent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Trash;

	[Field("CSMailboxArchive", "CoreSpotlight")]
	public static NSString Archive
	{
		get
		{
			if (_Archive == null)
			{
				_Archive = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxArchive");
			}
			return _Archive;
		}
	}

	[Field("CSMailboxDrafts", "CoreSpotlight")]
	public static NSString Drafts
	{
		get
		{
			if (_Drafts == null)
			{
				_Drafts = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxDrafts");
			}
			return _Drafts;
		}
	}

	[Field("CSMailboxInbox", "CoreSpotlight")]
	public static NSString Inbox
	{
		get
		{
			if (_Inbox == null)
			{
				_Inbox = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxInbox");
			}
			return _Inbox;
		}
	}

	[Field("CSMailboxJunk", "CoreSpotlight")]
	public static NSString Junk
	{
		get
		{
			if (_Junk == null)
			{
				_Junk = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxJunk");
			}
			return _Junk;
		}
	}

	[Field("CSMailboxSent", "CoreSpotlight")]
	public static NSString Sent
	{
		get
		{
			if (_Sent == null)
			{
				_Sent = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxSent");
			}
			return _Sent;
		}
	}

	[Field("CSMailboxTrash", "CoreSpotlight")]
	public static NSString Trash
	{
		get
		{
			if (_Trash == null)
			{
				_Trash = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSMailboxTrash");
			}
			return _Trash;
		}
	}
}
