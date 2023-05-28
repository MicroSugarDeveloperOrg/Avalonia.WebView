using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMText", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomText : DomCharacterData
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceWholeText_ = "replaceWholeText:";

	private static readonly IntPtr selReplaceWholeText_Handle = Selector.GetHandle("replaceWholeText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSplitText_ = "splitText:";

	private static readonly IntPtr selSplitText_Handle = Selector.GetHandle("splitText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWholeText = "wholeText";

	private static readonly IntPtr selWholeTextHandle = Selector.GetHandle("wholeText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMText");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WholeText
	{
		[Export("wholeText", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWholeTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWholeTextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomText(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomText(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replaceWholeText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomText ReplaceWholeText(string content)
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		IntPtr arg = NSString.CreateNative(content);
		DomText result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceWholeText_Handle, arg)) : Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReplaceWholeText_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("splitText:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomText SplitText(uint offset)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selSplitText_Handle, offset));
		}
		return Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selSplitText_Handle, offset));
	}
}
