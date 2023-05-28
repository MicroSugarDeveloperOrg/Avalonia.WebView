using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMImplementation", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomImplementation : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCSSStyleSheet_Media_ = "createCSSStyleSheet:media:";

	private static readonly IntPtr selCreateCSSStyleSheet_Media_Handle = Selector.GetHandle("createCSSStyleSheet:media:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDocument_QualifiedName_Doctype_ = "createDocument:qualifiedName:doctype:";

	private static readonly IntPtr selCreateDocument_QualifiedName_Doctype_Handle = Selector.GetHandle("createDocument:qualifiedName:doctype:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDocumentType_PublicId_SystemId_ = "createDocumentType:publicId:systemId:";

	private static readonly IntPtr selCreateDocumentType_PublicId_SystemId_Handle = Selector.GetHandle("createDocumentType:publicId:systemId:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateHTMLDocument_ = "createHTMLDocument:";

	private static readonly IntPtr selCreateHTMLDocument_Handle = Selector.GetHandle("createHTMLDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasFeature_Version_ = "hasFeature:version:";

	private static readonly IntPtr selHasFeature_Version_Handle = Selector.GetHandle("hasFeature:version:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMImplementation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomImplementation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomImplementation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createCSSStyleSheet:media:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomCssStyleSheet result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateCSSStyleSheet_Media_Handle, arg, arg2)) : Runtime.GetNSObject<DomCssStyleSheet>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateCSSStyleSheet_Media_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createDocument:qualifiedName:doctype:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomDocument result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateDocument_QualifiedName_Doctype_Handle, arg, arg2, doctype.Handle)) : Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateDocument_QualifiedName_Doctype_Handle, arg, arg2, doctype.Handle)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createDocumentType:publicId:systemId:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomDocumentType result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomDocumentType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCreateDocumentType_PublicId_SystemId_Handle, arg, arg2, arg3)) : Runtime.GetNSObject<DomDocumentType>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCreateDocumentType_PublicId_SystemId_Handle, arg, arg2, arg3)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("createHTMLDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlDocument CreateHtmlDocument(string title)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		DomHtmlDocument result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomHtmlDocument>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateHTMLDocument_Handle, arg)) : Runtime.GetNSObject<DomHtmlDocument>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateHTMLDocument_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasFeature:version:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHasFeature_Version_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selHasFeature_Version_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}
}
