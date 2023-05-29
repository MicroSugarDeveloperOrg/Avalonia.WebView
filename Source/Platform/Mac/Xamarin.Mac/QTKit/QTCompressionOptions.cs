using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCompressionOptions", true)]
public class QTCompressionOptions : NSObject
{
	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selLocalizedDisplayNameHandle = Selector.GetHandle("localizedDisplayName");

	private static readonly IntPtr selLocalizedCompressionOptionsSummaryHandle = Selector.GetHandle("localizedCompressionOptionsSummary");

	private static readonly IntPtr selCompressionOptionsIdentifiersForMediaType_Handle = Selector.GetHandle("compressionOptionsIdentifiersForMediaType:");

	private static readonly IntPtr selCompressionOptionsWithIdentifier_Handle = Selector.GetHandle("compressionOptionsWithIdentifier:");

	private static readonly IntPtr selIsEqualToCompressionOptions_Handle = Selector.GetHandle("isEqualToCompressionOptions:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTCompressionOptions");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual string LocalizedDisplayName
	{
		[Export("localizedDisplayName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDisplayNameHandle));
		}
	}

	public virtual string LocalizedCompressionOptionsSummary
	{
		[Export("localizedCompressionOptionsSummary")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCompressionOptionsSummaryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCompressionOptionsSummaryHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCompressionOptions()
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
	public QTCompressionOptions(NSCoder coder)
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
	public QTCompressionOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCompressionOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compressionOptionsIdentifiersForMediaType:")]
	public static string[] GetCompressionOptionsIdentifiers(string forMediaType)
	{
		if (forMediaType == null)
		{
			throw new ArgumentNullException("forMediaType");
		}
		IntPtr arg = NSString.CreateNative(forMediaType);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompressionOptionsIdentifiersForMediaType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compressionOptionsWithIdentifier:")]
	public static NSObject FromIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompressionOptionsWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("isEqualToCompressionOptions:")]
	public virtual bool IsEqualToCompressionOptions(QTCompressionOptions compressionOptions)
	{
		if (compressionOptions == null)
		{
			throw new ArgumentNullException("compressionOptions");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToCompressionOptions_Handle, compressionOptions.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToCompressionOptions_Handle, compressionOptions.Handle);
	}
}
