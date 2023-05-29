using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMImplementation", true)]
public class DomImplementation : DomObject
{
	private static readonly IntPtr selHasFeatureVersion_Handle = Selector.GetHandle("hasFeature:version:");

	private static readonly IntPtr selCreateDocumentTypePublicIdSystemId_Handle = Selector.GetHandle("createDocumentType:publicId:systemId:");

	private static readonly IntPtr selCreateDocumentQualifiedNameDoctype_Handle = Selector.GetHandle("createDocument:qualifiedName:doctype:");

	private static readonly IntPtr selCreateCSSStyleSheetMedia_Handle = Selector.GetHandle("createCSSStyleSheet:media:");

	private static readonly IntPtr selCreateHTMLDocument_Handle = Selector.GetHandle("createHTMLDocument:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMImplementation");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomImplementation(NSCoder coder)
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
	public DomImplementation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomImplementation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("hasFeature:version:")]
	public virtual bool HasFeature(string feature, string version)
	{
		if (feature == null)
		{
			throw new ArgumentNullException("feature");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		IntPtr arg = NSString.CreateNative(feature);
		IntPtr arg2 = NSString.CreateNative(version);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHasFeatureVersion_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selHasFeatureVersion_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createDocumentType:publicId:systemId:")]
	public virtual DomDocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId)
	{
		if (qualifiedName == null)
		{
			throw new ArgumentNullException("qualifiedName");
		}
		if (publicId == null)
		{
			throw new ArgumentNullException("publicId");
		}
		if (systemId == null)
		{
			throw new ArgumentNullException("systemId");
		}
		IntPtr arg = NSString.CreateNative(qualifiedName);
		IntPtr arg2 = NSString.CreateNative(publicId);
		IntPtr arg3 = NSString.CreateNative(systemId);
		DomDocumentType result = ((!IsDirectBinding) ? ((DomDocumentType)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateDocumentTypePublicIdSystemId_Handle, arg, arg2, arg3))) : ((DomDocumentType)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateDocumentTypePublicIdSystemId_Handle, arg, arg2, arg3))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("createDocument:qualifiedName:doctype:")]
	public virtual DomDocument CreateDocument(string namespaceUri, string qualifiedName, DomDocumentType doctype)
	{
		if (namespaceUri == null)
		{
			throw new ArgumentNullException("namespaceUri");
		}
		if (qualifiedName == null)
		{
			throw new ArgumentNullException("qualifiedName");
		}
		if (doctype == null)
		{
			throw new ArgumentNullException("doctype");
		}
		IntPtr arg = NSString.CreateNative(namespaceUri);
		IntPtr arg2 = NSString.CreateNative(qualifiedName);
		DomDocument result = ((!IsDirectBinding) ? ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateDocumentQualifiedNameDoctype_Handle, arg, arg2, doctype.Handle))) : ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateDocumentQualifiedNameDoctype_Handle, arg, arg2, doctype.Handle))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createCSSStyleSheet:media:")]
	public virtual DomCssStyleSheet CreateCssStyleSheet(string title, string media)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (media == null)
		{
			throw new ArgumentNullException("media");
		}
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(media);
		DomCssStyleSheet result = ((!IsDirectBinding) ? ((DomCssStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateCSSStyleSheetMedia_Handle, arg, arg2))) : ((DomCssStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateCSSStyleSheetMedia_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createHTMLDocument:")]
	public virtual DomHtmlDocument CreateHtmlDocument(string title)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		DomHtmlDocument result = ((!IsDirectBinding) ? ((DomHtmlDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateHTMLDocument_Handle, arg))) : ((DomHtmlDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateHTMLDocument_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}
}
