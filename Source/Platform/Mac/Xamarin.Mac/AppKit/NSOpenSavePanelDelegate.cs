using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenSavePanelDelegate", true)]
[Model]
public class NSOpenSavePanelDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenSavePanelDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOpenSavePanelDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenSavePanelDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenSavePanelDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("panel:shouldEnableURL:")]
	public virtual bool ShouldEnableUrl(NSSavePanel panel, NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:validateURL:error:")]
	public virtual bool ValidateUrl(NSSavePanel panel, NSUrl url, out NSError outError)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:didChangeToDirectoryURL:")]
	public virtual void DidChangeToDirectory(NSSavePanel panel, NSUrl newDirectoryUrl)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:userEnteredFilename:confirmed:")]
	public virtual string UserEnteredFilename(NSSavePanel panel, string filename, bool confirmed)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:willExpand:")]
	public virtual void WillExpand(NSSavePanel panel, bool expanding)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panelSelectionDidChange:")]
	public virtual void SelectionDidChange(NSSavePanel panel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:isValidFilename:")]
	[Obsolete("On 10.6 and newer use ValidateUrlError", false)]
	public virtual bool IsValidFilename(NSSavePanel panel, string fileName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:directoryDidChange:")]
	[Obsolete("On 10.6 and newer Use DidChangeToDirectoryUrl instead", false)]
	public virtual void DirectoryDidChange(NSSavePanel panel, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:compareFilename:with:caseSensitive")]
	[Obsolete("After 10.6, this method is obsolete and does not control sorting order", false)]
	public virtual NSComparisonResult CompareFilenames(NSSavePanel panel, string name1, string name2, bool caseSensitive)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:shouldShowFilename:")]
	[Obsolete("On 10.6 and newer use ShouldEnableUrl", false)]
	public virtual bool ShouldShowFilename(NSSavePanel panel, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
