using Foundation;
using ObjCRuntime;

namespace FileProvider;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFileProviderItem", WrapperType = typeof(NSFileProviderItemWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCapabilities", Selector = "capabilities", ReturnType = typeof(NSFileProviderItemCapabilities))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDocumentSize", Selector = "documentSize", ReturnType = typeof(NSNumber))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChildItemCount", Selector = "childItemCount", ReturnType = typeof(NSNumber))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCreationDate", Selector = "creationDate", ReturnType = typeof(NSDate))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentModificationDate", Selector = "contentModificationDate", ReturnType = typeof(NSDate))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLastUsedDate", Selector = "lastUsedDate", ReturnType = typeof(NSDate))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTagData", Selector = "tagData", ReturnType = typeof(NSData))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFavoriteRank", Selector = "favoriteRank", ReturnType = typeof(NSNumber))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsTrashed", Selector = "isTrashed", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsUploaded", Selector = "isUploaded", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsUploading", Selector = "isUploading", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUploadingError", Selector = "uploadingError", ReturnType = typeof(NSError))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDownloaded", Selector = "isDownloaded", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDownloading", Selector = "isDownloading", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDownloadingError", Selector = "downloadingError", ReturnType = typeof(NSError))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsMostRecentVersionDownloaded", Selector = "isMostRecentVersionDownloaded", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsShared", Selector = "isShared", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsSharedByCurrentUser", Selector = "isSharedByCurrentUser", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOwnerNameComponents", Selector = "ownerNameComponents", ReturnType = typeof(NSPersonNameComponents))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMostRecentEditorNameComponents", Selector = "mostRecentEditorNameComponents", ReturnType = typeof(NSPersonNameComponents))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUserInfo", Selector = "userInfo", ReturnType = typeof(NSDictionary))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "itemIdentifier", PropertyType = typeof(string), GetterSelector = "itemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentIdentifier", Selector = "parentItemIdentifier", PropertyType = typeof(string), GetterSelector = "parentItemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Filename", Selector = "filename", PropertyType = typeof(string), GetterSelector = "filename", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TypeIdentifier", Selector = "typeIdentifier", PropertyType = typeof(string), GetterSelector = "typeIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSFileProviderItem : INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    string Identifier
    {
        [Export("itemIdentifier")]
        get;
    }

    [Preserve(Conditional = true)]
    string ParentIdentifier
    {
        [Export("parentItemIdentifier")]
        get;
    }

    [Preserve(Conditional = true)]
    string Filename
    {
        [Export("filename")]
        get;
    }

    [Preserve(Conditional = true)]
    string TypeIdentifier
    {
        [Export("typeIdentifier")]
        get;
    }
}