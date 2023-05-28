using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCompressionOptions", true)]
public class QTCompressionOptions : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressionOptionsIdentifiersForMediaType_ = "compressionOptionsIdentifiersForMediaType:";

	private static readonly IntPtr selCompressionOptionsIdentifiersForMediaType_Handle = Selector.GetHandle("compressionOptionsIdentifiersForMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressionOptionsWithIdentifier_ = "compressionOptionsWithIdentifier:";

	private static readonly IntPtr selCompressionOptionsWithIdentifier_Handle = Selector.GetHandle("compressionOptionsWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToCompressionOptions_ = "isEqualToCompressionOptions:";

	private static readonly IntPtr selIsEqualToCompressionOptions_Handle = Selector.GetHandle("isEqualToCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedCompressionOptionsSummary = "localizedCompressionOptionsSummary";

	private static readonly IntPtr selLocalizedCompressionOptionsSummaryHandle = Selector.GetHandle("localizedCompressionOptionsSummary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDisplayName = "localizedDisplayName";

	private static readonly IntPtr selLocalizedDisplayNameHandle = Selector.GetHandle("localizedDisplayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTCompressionOptions");

	public QTMediaType MediaTypeValue => QTMedia.QTMediaTypeFromNSString((NSString)MediaType);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedCompressionOptionsSummary
	{
		[Export("localizedCompressionOptionsSummary")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCompressionOptionsSummaryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCompressionOptionsSummaryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedDisplayName
	{
		[Export("localizedDisplayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public string[] GetCompressionOptionsIdentifiers(QTMediaType forMediaType)
	{
		return GetCompressionOptionsIdentifiers(QTMedia.NSStringFromQTMediaType(forMediaType));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCompressionOptions()
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
	protected QTCompressionOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCompressionOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compressionOptionsWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("compressionOptionsIdentifiersForMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("isEqualToCompressionOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToCompressionOptions(QTCompressionOptions compressionOptions)
	{
		if (compressionOptions == null)
		{
			throw new ArgumentNullException("compressionOptions");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToCompressionOptions_Handle, compressionOptions.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToCompressionOptions_Handle, compressionOptions.Handle);
	}
}
