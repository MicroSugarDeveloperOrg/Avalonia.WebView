using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using ObjCRuntime;
using QuickLookUI;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURL", true)]
public class NSUrl : NSObject, IEquatable<NSUrl>, INSCoding, INativeObject, IDisposable, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSSecureCoding, INSPasteboardReading, INSPasteboardWriting, IQLPreviewItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByAppendingPathComponent_IsDirectory_ = "URLByAppendingPathComponent:isDirectory:";

	private static readonly IntPtr selURLByAppendingPathComponent_IsDirectory_Handle = Selector.GetHandle("URLByAppendingPathComponent:isDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByAppendingPathExtension_ = "URLByAppendingPathExtension:";

	private static readonly IntPtr selURLByAppendingPathExtension_Handle = Selector.GetHandle("URLByAppendingPathExtension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByDeletingLastPathComponent = "URLByDeletingLastPathComponent";

	private static readonly IntPtr selURLByDeletingLastPathComponentHandle = Selector.GetHandle("URLByDeletingLastPathComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByDeletingPathExtension = "URLByDeletingPathExtension";

	private static readonly IntPtr selURLByDeletingPathExtensionHandle = Selector.GetHandle("URLByDeletingPathExtension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByResolvingAliasFileAtURL_Options_Error_ = "URLByResolvingAliasFileAtURL:options:error:";

	private static readonly IntPtr selURLByResolvingAliasFileAtURL_Options_Error_Handle = Selector.GetHandle("URLByResolvingAliasFileAtURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_ = "URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:";

	private static readonly IntPtr selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_Handle = Selector.GetHandle("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLFromPasteboard_ = "URLFromPasteboard:";

	private static readonly IntPtr selURLFromPasteboard_Handle = Selector.GetHandle("URLFromPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLWithDataRepresentation_RelativeToURL_ = "URLWithDataRepresentation:relativeToURL:";

	private static readonly IntPtr selURLWithDataRepresentation_RelativeToURL_Handle = Selector.GetHandle("URLWithDataRepresentation:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLWithString_ = "URLWithString:";

	private static readonly IntPtr selURLWithString_Handle = Selector.GetHandle("URLWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLWithString_RelativeToURL_ = "URLWithString:relativeToURL:";

	private static readonly IntPtr selURLWithString_RelativeToURL_Handle = Selector.GetHandle("URLWithString:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsoluteString = "absoluteString";

	private static readonly IntPtr selAbsoluteStringHandle = Selector.GetHandle("absoluteString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsoluteURL = "absoluteURL";

	private static readonly IntPtr selAbsoluteURLHandle = Selector.GetHandle("absoluteURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAbsoluteURLWithDataRepresentation_RelativeToURL_ = "absoluteURLWithDataRepresentation:relativeToURL:";

	private static readonly IntPtr selAbsoluteURLWithDataRepresentation_RelativeToURL_Handle = Selector.GetHandle("absoluteURLWithDataRepresentation:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseURL = "baseURL";

	private static readonly IntPtr selBaseURLHandle = Selector.GetHandle("baseURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBookmarkDataWithContentsOfURL_Error_ = "bookmarkDataWithContentsOfURL:error:";

	private static readonly IntPtr selBookmarkDataWithContentsOfURL_Error_Handle = Selector.GetHandle("bookmarkDataWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_ = "bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:";

	private static readonly IntPtr selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_Handle = Selector.GetHandle("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataRepresentation = "dataRepresentation";

	private static readonly IntPtr selDataRepresentationHandle = Selector.GetHandle("dataRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilePathURL = "filePathURL";

	private static readonly IntPtr selFilePathURLHandle = Selector.GetHandle("filePathURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileReferenceURL = "fileReferenceURL";

	private static readonly IntPtr selFileReferenceURLHandle = Selector.GetHandle("fileReferenceURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileSystemRepresentation = "fileSystemRepresentation";

	private static readonly IntPtr selFileSystemRepresentationHandle = Selector.GetHandle("fileSystemRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_ = "fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:";

	private static readonly IntPtr selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_Handle = Selector.GetHandle("fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLWithPath_IsDirectory_RelativeToURL_ = "fileURLWithPath:isDirectory:relativeToURL:";

	private static readonly IntPtr selFileURLWithPath_IsDirectory_RelativeToURL_Handle = Selector.GetHandle("fileURLWithPath:isDirectory:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLWithPath_RelativeToURL_ = "fileURLWithPath:relativeToURL:";

	private static readonly IntPtr selFileURLWithPath_RelativeToURL_Handle = Selector.GetHandle("fileURLWithPath:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLWithPathComponents_ = "fileURLWithPathComponents:";

	private static readonly IntPtr selFileURLWithPathComponents_Handle = Selector.GetHandle("fileURLWithPathComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragment = "fragment";

	private static readonly IntPtr selFragmentHandle = Selector.GetHandle("fragment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFileSystemRepresentation_MaxLength_ = "getFileSystemRepresentation:maxLength:";

	private static readonly IntPtr selGetFileSystemRepresentation_MaxLength_Handle = Selector.GetHandle("getFileSystemRepresentation:maxLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetResourceValue_ForKey_Error_ = "getResourceValue:forKey:error:";

	private static readonly IntPtr selGetResourceValue_ForKey_Error_Handle = Selector.GetHandle("getResourceValue:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDirectoryPath = "hasDirectoryPath";

	private static readonly IntPtr selHasDirectoryPathHandle = Selector.GetHandle("hasDirectoryPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHost = "host";

	private static readonly IntPtr selHostHandle = Selector.GetHandle("host");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_ = "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:";

	private static readonly IntPtr selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_Handle = Selector.GetHandle("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_ = "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:";

	private static readonly IntPtr selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_Handle = Selector.GetHandle("initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFileURLWithPath_IsDirectory_ = "initFileURLWithPath:isDirectory:";

	private static readonly IntPtr selInitFileURLWithPath_IsDirectory_Handle = Selector.GetHandle("initFileURLWithPath:isDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFileURLWithPath_IsDirectory_RelativeToURL_ = "initFileURLWithPath:isDirectory:relativeToURL:";

	private static readonly IntPtr selInitFileURLWithPath_IsDirectory_RelativeToURL_Handle = Selector.GetHandle("initFileURLWithPath:isDirectory:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithScheme_Host_Path_ = "initWithScheme:host:path:";

	private static readonly IntPtr selInitWithScheme_Host_Path_Handle = Selector.GetHandle("initWithScheme:host:path:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_RelativeToURL_ = "initWithString:relativeToURL:";

	private static readonly IntPtr selInitWithString_RelativeToURL_Handle = Selector.GetHandle("initWithString:relativeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqual_ = "isEqual:";

	private static readonly IntPtr selIsEqual_Handle = Selector.GetHandle("isEqual:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFileReferenceURL = "isFileReferenceURL";

	private static readonly IntPtr selIsFileReferenceURLHandle = Selector.GetHandle("isFileReferenceURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFileURL = "isFileURL";

	private static readonly IntPtr selIsFileURLHandle = Selector.GetHandle("isFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_ = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";

	private static readonly IntPtr selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle = Selector.GetHandle("itemProviderVisibilityForRepresentationWithTypeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastPathComponent = "lastPathComponent";

	private static readonly IntPtr selLastPathComponentHandle = Selector.GetHandle("lastPathComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_ = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";

	private static readonly IntPtr selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle = Selector.GetHandle("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithItemProviderData_TypeIdentifier_Error_ = "objectWithItemProviderData:typeIdentifier:error:";

	private static readonly IntPtr selObjectWithItemProviderData_TypeIdentifier_Error_Handle = Selector.GetHandle("objectWithItemProviderData:typeIdentifier:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterString = "parameterString";

	private static readonly IntPtr selParameterStringHandle = Selector.GetHandle("parameterString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPassword = "password";

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathComponents = "pathComponents";

	private static readonly IntPtr selPathComponentsHandle = Selector.GetHandle("pathComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathExtension = "pathExtension";

	private static readonly IntPtr selPathExtensionHandle = Selector.GetHandle("pathExtension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPort = "port";

	private static readonly IntPtr selPortHandle = Selector.GetHandle("port");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewItemDisplayState = "previewItemDisplayState";

	private static readonly IntPtr selPreviewItemDisplayStateHandle = Selector.GetHandle("previewItemDisplayState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewItemTitle = "previewItemTitle";

	private static readonly IntPtr selPreviewItemTitleHandle = Selector.GetHandle("previewItemTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewItemURL = "previewItemURL";

	private static readonly IntPtr selPreviewItemURLHandle = Selector.GetHandle("previewItemURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuery = "query";

	private static readonly IntPtr selQueryHandle = Selector.GetHandle("query");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypeIdentifiersForItemProvider = "readableTypeIdentifiersForItemProvider";

	private static readonly IntPtr selReadableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("readableTypeIdentifiersForItemProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativePath = "relativePath";

	private static readonly IntPtr selRelativePathHandle = Selector.GetHandle("relativePath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelativeString = "relativeString";

	private static readonly IntPtr selRelativeStringHandle = Selector.GetHandle("relativeString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllCachedResourceValues = "removeAllCachedResourceValues";

	private static readonly IntPtr selRemoveAllCachedResourceValuesHandle = Selector.GetHandle("removeAllCachedResourceValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCachedResourceValueForKey_ = "removeCachedResourceValueForKey:";

	private static readonly IntPtr selRemoveCachedResourceValueForKey_Handle = Selector.GetHandle("removeCachedResourceValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceSpecifier = "resourceSpecifier";

	private static readonly IntPtr selResourceSpecifierHandle = Selector.GetHandle("resourceSpecifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceValuesForKeys_Error_ = "resourceValuesForKeys:error:";

	private static readonly IntPtr selResourceValuesForKeys_Error_Handle = Selector.GetHandle("resourceValuesForKeys:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheme = "scheme";

	private static readonly IntPtr selSchemeHandle = Selector.GetHandle("scheme");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResourceValue_ForKey_Error_ = "setResourceValue:forKey:error:";

	private static readonly IntPtr selSetResourceValue_ForKey_Error_Handle = Selector.GetHandle("setResourceValue:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTemporaryResourceValue_ForKey_ = "setTemporaryResourceValue:forKey:";

	private static readonly IntPtr selSetTemporaryResourceValue_ForKey_Handle = Selector.GetHandle("setTemporaryResourceValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardizedURL = "standardizedURL";

	private static readonly IntPtr selStandardizedURLHandle = Selector.GetHandle("standardizedURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAccessingSecurityScopedResource = "startAccessingSecurityScopedResource";

	private static readonly IntPtr selStartAccessingSecurityScopedResourceHandle = Selector.GetHandle("startAccessingSecurityScopedResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopAccessingSecurityScopedResource = "stopAccessingSecurityScopedResource";

	private static readonly IntPtr selStopAccessingSecurityScopedResourceHandle = Selector.GetHandle("stopAccessingSecurityScopedResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUser = "user";

	private static readonly IntPtr selUserHandle = Selector.GetHandle("user");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypeIdentifiersForItemProvider = "writableTypeIdentifiersForItemProvider";

	private static readonly IntPtr selWritableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("writableTypeIdentifiersForItemProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

	private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteBookmarkData_ToURL_Options_Error_ = "writeBookmarkData:toURL:options:error:";

	private static readonly IntPtr selWriteBookmarkData_ToURL_Options_Error_Handle = Selector.GetHandle("writeBookmarkData:toURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToPasteboard_ = "writeToPasteboard:";

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

	private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AddedToDirectoryDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeModificationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentAccessDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentModificationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CreationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CustomIconKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DocumentIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EffectiveIconKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileAllocatedSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeBlockSpecial;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeCharacterSpecial;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeDirectory;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeNamedPipe;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeRegular;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeSocket;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeSymbolicLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileResourceTypeUnknown;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileSecurityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenerationIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasHiddenExtensionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsAliasFileKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsApplicationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsDirectoryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsExcludedFromBackupKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsExecutableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsHiddenKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsMountTriggerKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsPackageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsReadableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsRegularFileKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsSymbolicLinkKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsSystemImmutableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsUbiquitousItemKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsUserImmutableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsVolumeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsWritableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeysOfUnsetValuesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LabelColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LabelNumberKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalizedLabelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalizedNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalizedTypeDescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ParentDirectoryURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PathKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredIOBlockSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThumbnailDictionaryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TotalFileAllocatedSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TotalFileSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TypeIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemContainerDisplayNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadRequestedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingStatusCurrent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingStatusDownloaded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingStatusKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemDownloadingStatusNotDownloaded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemHasUnresolvedConflictsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsDownloadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsDownloadingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsSharedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsUploadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemIsUploadingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemPercentDownloadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemPercentUploadedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousItemUploadingErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemCurrentUserPermissionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemCurrentUserRoleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemMostRecentEditorNameComponentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemOwnerNameComponentsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemPermissionsReadOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemPermissionsReadWrite;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemRoleOwner;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UbiquitousSharedItemRoleParticipant;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeAvailableCapacityForImportantUsageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeAvailableCapacityForOpportunisticUsageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeAvailableCapacityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeCreationDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsAutomountedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsBrowsableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsEjectableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsEncryptedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsInternalKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsJournalingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsLocalKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsReadOnlyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsRemovableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeIsRootFileSystemKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeLocalizedFormatDescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeLocalizedNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeMaximumFileSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeResourceCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsAccessPermissionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsAdvisoryFileLockingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsCasePreservedNamesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsCaseSensitiveNamesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsCompressionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsExclusiveRenamingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsExtendedSecurityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsFileCloningKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsHardLinksKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsImmutableFilesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsJournalingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsPersistentIDsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsRenamingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsRootDirectoryDatesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsSparseFilesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsSwapRenamingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsSymbolicLinksKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsVolumeSizesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeSupportsZeroRunsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeTotalCapacityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeURLForRemountingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VolumeUUIDStringKey;

	public int Port => (int)(PortNumber ?? ((NSNumber)(-1)));

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AbsoluteString
	{
		[Export("absoluteString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl AbsoluteUrl
	{
		[Export("absoluteURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAbsoluteURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAbsoluteURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl BaseUrl
	{
		[Export("baseURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSData DataRepresentation
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("dataRepresentation", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRepresentationHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl FilePathUrl
	{
		[Export("filePathURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilePathURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilePathURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl FileReferenceUrl
	{
		[Export("fileReferenceURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileReferenceURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileReferenceURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Fragment
	{
		[Export("fragment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFragmentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFragmentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual IntPtr GetFileSystemRepresentationAsUtf8Ptr
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("fileSystemRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selFileSystemRepresentationHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileSystemRepresentationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool HasDirectoryPath
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("hasDirectoryPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDirectoryPathHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDirectoryPathHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Host
	{
		[Export("host")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHostHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHostHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFileReferenceUrl
	{
		[Export("isFileReferenceURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFileReferenceURLHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFileReferenceURLHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFileUrl
	{
		[Export("isFileURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFileURLHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFileURLHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LastPathComponent
	{
		[Export("lastPathComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLastPathComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastPathComponentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
	public virtual string ParameterString
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
		[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Always return 'null'. Use and parse 'Path' instead.")]
		[Export("parameterString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selParameterStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParameterStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Password
	{
		[Export("password")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPasswordHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasswordHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Path
	{
		[Export("path")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] PathComponents
	{
		[Export("pathComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PathExtension
	{
		[Export("pathExtension")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathExtensionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathExtensionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSNumber? PortNumber
	{
		[Export("port")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPortHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPortHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PreviewItemDisplayState
	{
		[Export("previewItemDisplayState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewItemDisplayStateHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewItemDisplayStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreviewItemTitle
	{
		[Export("previewItemTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewItemTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PreviewItemURL
	{
		[Export("previewItemURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewItemURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewItemURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Query
	{
		[Export("query")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selQueryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static string[] ReadableTypeIdentifiers
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableTypeIdentifiersForItemProviderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RelativePath
	{
		[Export("relativePath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelativePathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelativePathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RelativeString
	{
		[Export("relativeString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRelativeStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRelativeStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ResourceSpecifier
	{
		[Export("resourceSpecifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceSpecifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceSpecifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Scheme
	{
		[Export("scheme")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSchemeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSchemeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl StandardizedUrl
	{
		[Export("standardizedURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardizedURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardizedURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string User
	{
		[Export("user")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static string[] WritableTypeIdentifiers
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selWritableTypeIdentifiersForItemProviderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string[] WritableTypeIdentifiersForItemProvider
	{
		[Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWritableTypeIdentifiersForItemProviderHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWritableTypeIdentifiersForItemProviderHandle));
		}
	}

	[Field("NSURLAddedToDirectoryDateKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AddedToDirectoryDateKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AddedToDirectoryDateKey == null)
			{
				_AddedToDirectoryDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAddedToDirectoryDateKey");
			}
			return _AddedToDirectoryDateKey;
		}
	}

	[Field("NSURLAttributeModificationDateKey", "Foundation")]
	public static NSString AttributeModificationDateKey
	{
		get
		{
			if (_AttributeModificationDateKey == null)
			{
				_AttributeModificationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLAttributeModificationDateKey");
			}
			return _AttributeModificationDateKey;
		}
	}

	[Field("NSURLContentAccessDateKey", "Foundation")]
	public static NSString ContentAccessDateKey
	{
		get
		{
			if (_ContentAccessDateKey == null)
			{
				_ContentAccessDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLContentAccessDateKey");
			}
			return _ContentAccessDateKey;
		}
	}

	[Field("NSURLContentModificationDateKey", "Foundation")]
	public static NSString ContentModificationDateKey
	{
		get
		{
			if (_ContentModificationDateKey == null)
			{
				_ContentModificationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLContentModificationDateKey");
			}
			return _ContentModificationDateKey;
		}
	}

	[Field("NSURLCreationDateKey", "Foundation")]
	public static NSString CreationDateKey
	{
		get
		{
			if (_CreationDateKey == null)
			{
				_CreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCreationDateKey");
			}
			return _CreationDateKey;
		}
	}

	[Field("NSURLCustomIconKey", "Foundation")]
	public static NSString CustomIconKey
	{
		get
		{
			if (_CustomIconKey == null)
			{
				_CustomIconKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCustomIconKey");
			}
			return _CustomIconKey;
		}
	}

	[Field("NSURLDocumentIdentifierKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString DocumentIdentifierKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DocumentIdentifierKey == null)
			{
				_DocumentIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLDocumentIdentifierKey");
			}
			return _DocumentIdentifierKey;
		}
	}

	[Field("NSURLEffectiveIconKey", "Foundation")]
	public static NSString EffectiveIconKey
	{
		get
		{
			if (_EffectiveIconKey == null)
			{
				_EffectiveIconKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLEffectiveIconKey");
			}
			return _EffectiveIconKey;
		}
	}

	[Field("NSURLFileAllocatedSizeKey", "Foundation")]
	public static NSString FileAllocatedSizeKey
	{
		get
		{
			if (_FileAllocatedSizeKey == null)
			{
				_FileAllocatedSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileAllocatedSizeKey");
			}
			return _FileAllocatedSizeKey;
		}
	}

	[Field("NSURLFileResourceIdentifierKey", "Foundation")]
	public static NSString FileResourceIdentifierKey
	{
		get
		{
			if (_FileResourceIdentifierKey == null)
			{
				_FileResourceIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceIdentifierKey");
			}
			return _FileResourceIdentifierKey;
		}
	}

	[Field("NSURLFileResourceTypeBlockSpecial", "Foundation")]
	public static NSString FileResourceTypeBlockSpecial
	{
		get
		{
			if (_FileResourceTypeBlockSpecial == null)
			{
				_FileResourceTypeBlockSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeBlockSpecial");
			}
			return _FileResourceTypeBlockSpecial;
		}
	}

	[Field("NSURLFileResourceTypeCharacterSpecial", "Foundation")]
	public static NSString FileResourceTypeCharacterSpecial
	{
		get
		{
			if (_FileResourceTypeCharacterSpecial == null)
			{
				_FileResourceTypeCharacterSpecial = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeCharacterSpecial");
			}
			return _FileResourceTypeCharacterSpecial;
		}
	}

	[Field("NSURLFileResourceTypeDirectory", "Foundation")]
	public static NSString FileResourceTypeDirectory
	{
		get
		{
			if (_FileResourceTypeDirectory == null)
			{
				_FileResourceTypeDirectory = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeDirectory");
			}
			return _FileResourceTypeDirectory;
		}
	}

	[Field("NSURLFileResourceTypeKey", "Foundation")]
	public static NSString FileResourceTypeKey
	{
		get
		{
			if (_FileResourceTypeKey == null)
			{
				_FileResourceTypeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeKey");
			}
			return _FileResourceTypeKey;
		}
	}

	[Field("NSURLFileResourceTypeNamedPipe", "Foundation")]
	public static NSString FileResourceTypeNamedPipe
	{
		get
		{
			if (_FileResourceTypeNamedPipe == null)
			{
				_FileResourceTypeNamedPipe = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeNamedPipe");
			}
			return _FileResourceTypeNamedPipe;
		}
	}

	[Field("NSURLFileResourceTypeRegular", "Foundation")]
	public static NSString FileResourceTypeRegular
	{
		get
		{
			if (_FileResourceTypeRegular == null)
			{
				_FileResourceTypeRegular = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeRegular");
			}
			return _FileResourceTypeRegular;
		}
	}

	[Field("NSURLFileResourceTypeSocket", "Foundation")]
	public static NSString FileResourceTypeSocket
	{
		get
		{
			if (_FileResourceTypeSocket == null)
			{
				_FileResourceTypeSocket = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeSocket");
			}
			return _FileResourceTypeSocket;
		}
	}

	[Field("NSURLFileResourceTypeSymbolicLink", "Foundation")]
	public static NSString FileResourceTypeSymbolicLink
	{
		get
		{
			if (_FileResourceTypeSymbolicLink == null)
			{
				_FileResourceTypeSymbolicLink = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeSymbolicLink");
			}
			return _FileResourceTypeSymbolicLink;
		}
	}

	[Field("NSURLFileResourceTypeUnknown", "Foundation")]
	public static NSString FileResourceTypeUnknown
	{
		get
		{
			if (_FileResourceTypeUnknown == null)
			{
				_FileResourceTypeUnknown = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileResourceTypeUnknown");
			}
			return _FileResourceTypeUnknown;
		}
	}

	[Field("NSURLFileSecurityKey", "Foundation")]
	public static NSString FileSecurityKey
	{
		get
		{
			if (_FileSecurityKey == null)
			{
				_FileSecurityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileSecurityKey");
			}
			return _FileSecurityKey;
		}
	}

	[Field("NSURLFileSizeKey", "Foundation")]
	public static NSString FileSizeKey
	{
		get
		{
			if (_FileSizeKey == null)
			{
				_FileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLFileSizeKey");
			}
			return _FileSizeKey;
		}
	}

	[Field("NSURLGenerationIdentifierKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString GenerationIdentifierKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GenerationIdentifierKey == null)
			{
				_GenerationIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLGenerationIdentifierKey");
			}
			return _GenerationIdentifierKey;
		}
	}

	[Field("NSURLHasHiddenExtensionKey", "Foundation")]
	public static NSString HasHiddenExtensionKey
	{
		get
		{
			if (_HasHiddenExtensionKey == null)
			{
				_HasHiddenExtensionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLHasHiddenExtensionKey");
			}
			return _HasHiddenExtensionKey;
		}
	}

	[Field("NSURLIsAliasFileKey", "Foundation")]
	public static NSString IsAliasFileKey
	{
		get
		{
			if (_IsAliasFileKey == null)
			{
				_IsAliasFileKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsAliasFileKey");
			}
			return _IsAliasFileKey;
		}
	}

	[Field("NSURLIsApplicationKey", "Foundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString IsApplicationKey
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_IsApplicationKey == null)
			{
				_IsApplicationKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsApplicationKey");
			}
			return _IsApplicationKey;
		}
	}

	[Field("NSURLIsDirectoryKey", "Foundation")]
	public static NSString IsDirectoryKey
	{
		get
		{
			if (_IsDirectoryKey == null)
			{
				_IsDirectoryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsDirectoryKey");
			}
			return _IsDirectoryKey;
		}
	}

	[Field("NSURLIsExcludedFromBackupKey", "Foundation")]
	public static NSString IsExcludedFromBackupKey
	{
		get
		{
			if (_IsExcludedFromBackupKey == null)
			{
				_IsExcludedFromBackupKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsExcludedFromBackupKey");
			}
			return _IsExcludedFromBackupKey;
		}
	}

	[Field("NSURLIsExecutableKey", "Foundation")]
	public static NSString IsExecutableKey
	{
		get
		{
			if (_IsExecutableKey == null)
			{
				_IsExecutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsExecutableKey");
			}
			return _IsExecutableKey;
		}
	}

	[Field("NSURLIsHiddenKey", "Foundation")]
	public static NSString IsHiddenKey
	{
		get
		{
			if (_IsHiddenKey == null)
			{
				_IsHiddenKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsHiddenKey");
			}
			return _IsHiddenKey;
		}
	}

	[Field("NSURLIsMountTriggerKey", "Foundation")]
	public static NSString IsMountTriggerKey
	{
		get
		{
			if (_IsMountTriggerKey == null)
			{
				_IsMountTriggerKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsMountTriggerKey");
			}
			return _IsMountTriggerKey;
		}
	}

	[Field("NSURLIsPackageKey", "Foundation")]
	public static NSString IsPackageKey
	{
		get
		{
			if (_IsPackageKey == null)
			{
				_IsPackageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsPackageKey");
			}
			return _IsPackageKey;
		}
	}

	[Field("NSURLIsReadableKey", "Foundation")]
	public static NSString IsReadableKey
	{
		get
		{
			if (_IsReadableKey == null)
			{
				_IsReadableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsReadableKey");
			}
			return _IsReadableKey;
		}
	}

	[Field("NSURLIsRegularFileKey", "Foundation")]
	public static NSString IsRegularFileKey
	{
		get
		{
			if (_IsRegularFileKey == null)
			{
				_IsRegularFileKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsRegularFileKey");
			}
			return _IsRegularFileKey;
		}
	}

	[Field("NSURLIsSymbolicLinkKey", "Foundation")]
	public static NSString IsSymbolicLinkKey
	{
		get
		{
			if (_IsSymbolicLinkKey == null)
			{
				_IsSymbolicLinkKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsSymbolicLinkKey");
			}
			return _IsSymbolicLinkKey;
		}
	}

	[Field("NSURLIsSystemImmutableKey", "Foundation")]
	public static NSString IsSystemImmutableKey
	{
		get
		{
			if (_IsSystemImmutableKey == null)
			{
				_IsSystemImmutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsSystemImmutableKey");
			}
			return _IsSystemImmutableKey;
		}
	}

	[Field("NSURLIsUbiquitousItemKey", "Foundation")]
	public static NSString IsUbiquitousItemKey
	{
		get
		{
			if (_IsUbiquitousItemKey == null)
			{
				_IsUbiquitousItemKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsUbiquitousItemKey");
			}
			return _IsUbiquitousItemKey;
		}
	}

	[Field("NSURLIsUserImmutableKey", "Foundation")]
	public static NSString IsUserImmutableKey
	{
		get
		{
			if (_IsUserImmutableKey == null)
			{
				_IsUserImmutableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsUserImmutableKey");
			}
			return _IsUserImmutableKey;
		}
	}

	[Field("NSURLIsVolumeKey", "Foundation")]
	public static NSString IsVolumeKey
	{
		get
		{
			if (_IsVolumeKey == null)
			{
				_IsVolumeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsVolumeKey");
			}
			return _IsVolumeKey;
		}
	}

	[Field("NSURLIsWritableKey", "Foundation")]
	public static NSString IsWritableKey
	{
		get
		{
			if (_IsWritableKey == null)
			{
				_IsWritableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLIsWritableKey");
			}
			return _IsWritableKey;
		}
	}

	[Field("NSURLKeysOfUnsetValuesKey", "Foundation")]
	public static NSString KeysOfUnsetValuesKey
	{
		get
		{
			if (_KeysOfUnsetValuesKey == null)
			{
				_KeysOfUnsetValuesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLKeysOfUnsetValuesKey");
			}
			return _KeysOfUnsetValuesKey;
		}
	}

	[Field("NSURLLabelColorKey", "Foundation")]
	public static NSString LabelColorKey
	{
		get
		{
			if (_LabelColorKey == null)
			{
				_LabelColorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLabelColorKey");
			}
			return _LabelColorKey;
		}
	}

	[Field("NSURLLabelNumberKey", "Foundation")]
	public static NSString LabelNumberKey
	{
		get
		{
			if (_LabelNumberKey == null)
			{
				_LabelNumberKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLabelNumberKey");
			}
			return _LabelNumberKey;
		}
	}

	[Field("NSURLLinkCountKey", "Foundation")]
	public static NSString LinkCountKey
	{
		get
		{
			if (_LinkCountKey == null)
			{
				_LinkCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLinkCountKey");
			}
			return _LinkCountKey;
		}
	}

	[Field("NSURLLocalizedLabelKey", "Foundation")]
	public static NSString LocalizedLabelKey
	{
		get
		{
			if (_LocalizedLabelKey == null)
			{
				_LocalizedLabelKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedLabelKey");
			}
			return _LocalizedLabelKey;
		}
	}

	[Field("NSURLLocalizedNameKey", "Foundation")]
	public static NSString LocalizedNameKey
	{
		get
		{
			if (_LocalizedNameKey == null)
			{
				_LocalizedNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedNameKey");
			}
			return _LocalizedNameKey;
		}
	}

	[Field("NSURLLocalizedTypeDescriptionKey", "Foundation")]
	public static NSString LocalizedTypeDescriptionKey
	{
		get
		{
			if (_LocalizedTypeDescriptionKey == null)
			{
				_LocalizedTypeDescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLLocalizedTypeDescriptionKey");
			}
			return _LocalizedTypeDescriptionKey;
		}
	}

	[Field("NSURLNameKey", "Foundation")]
	public static NSString NameKey
	{
		get
		{
			if (_NameKey == null)
			{
				_NameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLNameKey");
			}
			return _NameKey;
		}
	}

	[Field("NSURLParentDirectoryURLKey", "Foundation")]
	public static NSString ParentDirectoryURLKey
	{
		get
		{
			if (_ParentDirectoryURLKey == null)
			{
				_ParentDirectoryURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLParentDirectoryURLKey");
			}
			return _ParentDirectoryURLKey;
		}
	}

	[Field("NSURLPathKey", "Foundation")]
	public static NSString PathKey
	{
		get
		{
			if (_PathKey == null)
			{
				_PathKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLPathKey");
			}
			return _PathKey;
		}
	}

	[Field("NSURLPreferredIOBlockSizeKey", "Foundation")]
	public static NSString PreferredIOBlockSizeKey
	{
		get
		{
			if (_PreferredIOBlockSizeKey == null)
			{
				_PreferredIOBlockSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLPreferredIOBlockSizeKey");
			}
			return _PreferredIOBlockSizeKey;
		}
	}

	[Field("NSURLThumbnailDictionaryKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ThumbnailDictionaryKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ThumbnailDictionaryKey == null)
			{
				_ThumbnailDictionaryKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLThumbnailDictionaryKey");
			}
			return _ThumbnailDictionaryKey;
		}
	}

	[Field("NSURLTotalFileAllocatedSizeKey", "Foundation")]
	public static NSString TotalFileAllocatedSizeKey
	{
		get
		{
			if (_TotalFileAllocatedSizeKey == null)
			{
				_TotalFileAllocatedSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTotalFileAllocatedSizeKey");
			}
			return _TotalFileAllocatedSizeKey;
		}
	}

	[Field("NSURLTotalFileSizeKey", "Foundation")]
	public static NSString TotalFileSizeKey
	{
		get
		{
			if (_TotalFileSizeKey == null)
			{
				_TotalFileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTotalFileSizeKey");
			}
			return _TotalFileSizeKey;
		}
	}

	[Field("NSURLTypeIdentifierKey", "Foundation")]
	public static NSString TypeIdentifierKey
	{
		get
		{
			if (_TypeIdentifierKey == null)
			{
				_TypeIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLTypeIdentifierKey");
			}
			return _TypeIdentifierKey;
		}
	}

	[Field("NSURLUbiquitousItemContainerDisplayNameKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemContainerDisplayNameKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemContainerDisplayNameKey == null)
			{
				_UbiquitousItemContainerDisplayNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemContainerDisplayNameKey");
			}
			return _UbiquitousItemContainerDisplayNameKey;
		}
	}

	[Field("NSURLUbiquitousItemDownloadRequestedKey", "Foundation")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadRequestedKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadRequestedKey == null)
			{
				_UbiquitousItemDownloadRequestedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadRequestedKey");
			}
			return _UbiquitousItemDownloadRequestedKey;
		}
	}

	[Field("NSURLUbiquitousItemDownloadingErrorKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingErrorKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingErrorKey == null)
			{
				_UbiquitousItemDownloadingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingErrorKey");
			}
			return _UbiquitousItemDownloadingErrorKey;
		}
	}

	[Field("NSURLUbiquitousItemDownloadingStatusCurrent", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingStatusCurrent
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingStatusCurrent == null)
			{
				_UbiquitousItemDownloadingStatusCurrent = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusCurrent");
			}
			return _UbiquitousItemDownloadingStatusCurrent;
		}
	}

	[Field("NSURLUbiquitousItemDownloadingStatusDownloaded", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingStatusDownloaded
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingStatusDownloaded == null)
			{
				_UbiquitousItemDownloadingStatusDownloaded = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusDownloaded");
			}
			return _UbiquitousItemDownloadingStatusDownloaded;
		}
	}

	[Field("NSURLUbiquitousItemDownloadingStatusKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingStatusKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingStatusKey == null)
			{
				_UbiquitousItemDownloadingStatusKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusKey");
			}
			return _UbiquitousItemDownloadingStatusKey;
		}
	}

	[Field("NSURLUbiquitousItemDownloadingStatusNotDownloaded", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemDownloadingStatusNotDownloaded
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemDownloadingStatusNotDownloaded == null)
			{
				_UbiquitousItemDownloadingStatusNotDownloaded = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemDownloadingStatusNotDownloaded");
			}
			return _UbiquitousItemDownloadingStatusNotDownloaded;
		}
	}

	[Field("NSURLUbiquitousItemHasUnresolvedConflictsKey", "Foundation")]
	public static NSString UbiquitousItemHasUnresolvedConflictsKey
	{
		get
		{
			if (_UbiquitousItemHasUnresolvedConflictsKey == null)
			{
				_UbiquitousItemHasUnresolvedConflictsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemHasUnresolvedConflictsKey");
			}
			return _UbiquitousItemHasUnresolvedConflictsKey;
		}
	}

	[Field("NSURLUbiquitousItemIsDownloadedKey", "Foundation")]
	public static NSString UbiquitousItemIsDownloadedKey
	{
		get
		{
			if (_UbiquitousItemIsDownloadedKey == null)
			{
				_UbiquitousItemIsDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadedKey");
			}
			return _UbiquitousItemIsDownloadedKey;
		}
	}

	[Field("NSURLUbiquitousItemIsDownloadingKey", "Foundation")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemIsDownloadingKey
	{
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemIsDownloadingKey == null)
			{
				_UbiquitousItemIsDownloadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsDownloadingKey");
			}
			return _UbiquitousItemIsDownloadingKey;
		}
	}

	[Field("NSURLUbiquitousItemIsSharedKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemIsSharedKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemIsSharedKey == null)
			{
				_UbiquitousItemIsSharedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsSharedKey");
			}
			return _UbiquitousItemIsSharedKey;
		}
	}

	[Field("NSURLUbiquitousItemIsUploadedKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadedKey
	{
		get
		{
			if (_UbiquitousItemIsUploadedKey == null)
			{
				_UbiquitousItemIsUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadedKey");
			}
			return _UbiquitousItemIsUploadedKey;
		}
	}

	[Field("NSURLUbiquitousItemIsUploadingKey", "Foundation")]
	public static NSString UbiquitousItemIsUploadingKey
	{
		get
		{
			if (_UbiquitousItemIsUploadingKey == null)
			{
				_UbiquitousItemIsUploadingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemIsUploadingKey");
			}
			return _UbiquitousItemIsUploadingKey;
		}
	}

	[Field("NSURLUbiquitousItemPercentDownloadedKey", "Foundation")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
	public static NSString UbiquitousItemPercentDownloadedKey
	{
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentDownloadedKey' on 'NSMetadataItem' instead.")]
		get
		{
			if (_UbiquitousItemPercentDownloadedKey == null)
			{
				_UbiquitousItemPercentDownloadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentDownloadedKey");
			}
			return _UbiquitousItemPercentDownloadedKey;
		}
	}

	[Field("NSURLUbiquitousItemPercentUploadedKey", "Foundation")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
	public static NSString UbiquitousItemPercentUploadedKey
	{
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NSMetadataQuery.UbiquitousItemPercentUploadedKey' on 'NSMetadataItem' instead.")]
		get
		{
			if (_UbiquitousItemPercentUploadedKey == null)
			{
				_UbiquitousItemPercentUploadedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemPercentUploadedKey");
			}
			return _UbiquitousItemPercentUploadedKey;
		}
	}

	[Field("NSURLUbiquitousItemUploadingErrorKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UbiquitousItemUploadingErrorKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousItemUploadingErrorKey == null)
			{
				_UbiquitousItemUploadingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousItemUploadingErrorKey");
			}
			return _UbiquitousItemUploadingErrorKey;
		}
	}

	[Field("NSURLUbiquitousSharedItemCurrentUserPermissionsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemCurrentUserPermissionsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemCurrentUserPermissionsKey == null)
			{
				_UbiquitousSharedItemCurrentUserPermissionsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemCurrentUserPermissionsKey");
			}
			return _UbiquitousSharedItemCurrentUserPermissionsKey;
		}
	}

	[Field("NSURLUbiquitousSharedItemCurrentUserRoleKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemCurrentUserRoleKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemCurrentUserRoleKey == null)
			{
				_UbiquitousSharedItemCurrentUserRoleKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemCurrentUserRoleKey");
			}
			return _UbiquitousSharedItemCurrentUserRoleKey;
		}
	}

	[Field("NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemMostRecentEditorNameComponentsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemMostRecentEditorNameComponentsKey == null)
			{
				_UbiquitousSharedItemMostRecentEditorNameComponentsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey");
			}
			return _UbiquitousSharedItemMostRecentEditorNameComponentsKey;
		}
	}

	[Field("NSURLUbiquitousSharedItemOwnerNameComponentsKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemOwnerNameComponentsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemOwnerNameComponentsKey == null)
			{
				_UbiquitousSharedItemOwnerNameComponentsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemOwnerNameComponentsKey");
			}
			return _UbiquitousSharedItemOwnerNameComponentsKey;
		}
	}

	[Field("NSURLUbiquitousSharedItemPermissionsReadOnly", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemPermissionsReadOnly
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemPermissionsReadOnly == null)
			{
				_UbiquitousSharedItemPermissionsReadOnly = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemPermissionsReadOnly");
			}
			return _UbiquitousSharedItemPermissionsReadOnly;
		}
	}

	[Field("NSURLUbiquitousSharedItemPermissionsReadWrite", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemPermissionsReadWrite
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemPermissionsReadWrite == null)
			{
				_UbiquitousSharedItemPermissionsReadWrite = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemPermissionsReadWrite");
			}
			return _UbiquitousSharedItemPermissionsReadWrite;
		}
	}

	[Field("NSURLUbiquitousSharedItemRoleOwner", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemRoleOwner
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemRoleOwner == null)
			{
				_UbiquitousSharedItemRoleOwner = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemRoleOwner");
			}
			return _UbiquitousSharedItemRoleOwner;
		}
	}

	[Field("NSURLUbiquitousSharedItemRoleParticipant", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UbiquitousSharedItemRoleParticipant
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UbiquitousSharedItemRoleParticipant == null)
			{
				_UbiquitousSharedItemRoleParticipant = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLUbiquitousSharedItemRoleParticipant");
			}
			return _UbiquitousSharedItemRoleParticipant;
		}
	}

	[Field("NSURLVolumeAvailableCapacityForImportantUsageKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeAvailableCapacityForImportantUsageKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeAvailableCapacityForImportantUsageKey == null)
			{
				_VolumeAvailableCapacityForImportantUsageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityForImportantUsageKey");
			}
			return _VolumeAvailableCapacityForImportantUsageKey;
		}
	}

	[Field("NSURLVolumeAvailableCapacityForOpportunisticUsageKey", "Foundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeAvailableCapacityForOpportunisticUsageKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeAvailableCapacityForOpportunisticUsageKey == null)
			{
				_VolumeAvailableCapacityForOpportunisticUsageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityForOpportunisticUsageKey");
			}
			return _VolumeAvailableCapacityForOpportunisticUsageKey;
		}
	}

	[Field("NSURLVolumeAvailableCapacityKey", "Foundation")]
	public static NSString VolumeAvailableCapacityKey
	{
		get
		{
			if (_VolumeAvailableCapacityKey == null)
			{
				_VolumeAvailableCapacityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeAvailableCapacityKey");
			}
			return _VolumeAvailableCapacityKey;
		}
	}

	[Field("NSURLVolumeCreationDateKey", "Foundation")]
	public static NSString VolumeCreationDateKey
	{
		get
		{
			if (_VolumeCreationDateKey == null)
			{
				_VolumeCreationDateKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeCreationDateKey");
			}
			return _VolumeCreationDateKey;
		}
	}

	[Field("NSURLVolumeIdentifierKey", "Foundation")]
	public static NSString VolumeIdentifierKey
	{
		get
		{
			if (_VolumeIdentifierKey == null)
			{
				_VolumeIdentifierKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIdentifierKey");
			}
			return _VolumeIdentifierKey;
		}
	}

	[Field("NSURLVolumeIsAutomountedKey", "Foundation")]
	public static NSString VolumeIsAutomountedKey
	{
		get
		{
			if (_VolumeIsAutomountedKey == null)
			{
				_VolumeIsAutomountedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsAutomountedKey");
			}
			return _VolumeIsAutomountedKey;
		}
	}

	[Field("NSURLVolumeIsBrowsableKey", "Foundation")]
	public static NSString VolumeIsBrowsableKey
	{
		get
		{
			if (_VolumeIsBrowsableKey == null)
			{
				_VolumeIsBrowsableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsBrowsableKey");
			}
			return _VolumeIsBrowsableKey;
		}
	}

	[Field("NSURLVolumeIsEjectableKey", "Foundation")]
	public static NSString VolumeIsEjectableKey
	{
		get
		{
			if (_VolumeIsEjectableKey == null)
			{
				_VolumeIsEjectableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsEjectableKey");
			}
			return _VolumeIsEjectableKey;
		}
	}

	[Field("NSURLVolumeIsEncryptedKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeIsEncryptedKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeIsEncryptedKey == null)
			{
				_VolumeIsEncryptedKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsEncryptedKey");
			}
			return _VolumeIsEncryptedKey;
		}
	}

	[Field("NSURLVolumeIsInternalKey", "Foundation")]
	public static NSString VolumeIsInternalKey
	{
		get
		{
			if (_VolumeIsInternalKey == null)
			{
				_VolumeIsInternalKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsInternalKey");
			}
			return _VolumeIsInternalKey;
		}
	}

	[Field("NSURLVolumeIsJournalingKey", "Foundation")]
	public static NSString VolumeIsJournalingKey
	{
		get
		{
			if (_VolumeIsJournalingKey == null)
			{
				_VolumeIsJournalingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsJournalingKey");
			}
			return _VolumeIsJournalingKey;
		}
	}

	[Field("NSURLVolumeIsLocalKey", "Foundation")]
	public static NSString VolumeIsLocalKey
	{
		get
		{
			if (_VolumeIsLocalKey == null)
			{
				_VolumeIsLocalKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsLocalKey");
			}
			return _VolumeIsLocalKey;
		}
	}

	[Field("NSURLVolumeIsReadOnlyKey", "Foundation")]
	public static NSString VolumeIsReadOnlyKey
	{
		get
		{
			if (_VolumeIsReadOnlyKey == null)
			{
				_VolumeIsReadOnlyKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsReadOnlyKey");
			}
			return _VolumeIsReadOnlyKey;
		}
	}

	[Field("NSURLVolumeIsRemovableKey", "Foundation")]
	public static NSString VolumeIsRemovableKey
	{
		get
		{
			if (_VolumeIsRemovableKey == null)
			{
				_VolumeIsRemovableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsRemovableKey");
			}
			return _VolumeIsRemovableKey;
		}
	}

	[Field("NSURLVolumeIsRootFileSystemKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeIsRootFileSystemKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeIsRootFileSystemKey == null)
			{
				_VolumeIsRootFileSystemKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeIsRootFileSystemKey");
			}
			return _VolumeIsRootFileSystemKey;
		}
	}

	[Field("NSURLVolumeLocalizedFormatDescriptionKey", "Foundation")]
	public static NSString VolumeLocalizedFormatDescriptionKey
	{
		get
		{
			if (_VolumeLocalizedFormatDescriptionKey == null)
			{
				_VolumeLocalizedFormatDescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeLocalizedFormatDescriptionKey");
			}
			return _VolumeLocalizedFormatDescriptionKey;
		}
	}

	[Field("NSURLVolumeLocalizedNameKey", "Foundation")]
	public static NSString VolumeLocalizedNameKey
	{
		get
		{
			if (_VolumeLocalizedNameKey == null)
			{
				_VolumeLocalizedNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeLocalizedNameKey");
			}
			return _VolumeLocalizedNameKey;
		}
	}

	[Field("NSURLVolumeMaximumFileSizeKey", "Foundation")]
	public static NSString VolumeMaximumFileSizeKey
	{
		get
		{
			if (_VolumeMaximumFileSizeKey == null)
			{
				_VolumeMaximumFileSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeMaximumFileSizeKey");
			}
			return _VolumeMaximumFileSizeKey;
		}
	}

	[Field("NSURLVolumeNameKey", "Foundation")]
	public static NSString VolumeNameKey
	{
		get
		{
			if (_VolumeNameKey == null)
			{
				_VolumeNameKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeNameKey");
			}
			return _VolumeNameKey;
		}
	}

	[Field("NSURLVolumeResourceCountKey", "Foundation")]
	public static NSString VolumeResourceCountKey
	{
		get
		{
			if (_VolumeResourceCountKey == null)
			{
				_VolumeResourceCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeResourceCountKey");
			}
			return _VolumeResourceCountKey;
		}
	}

	[Field("NSURLVolumeSupportsAccessPermissionsKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsAccessPermissionsKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsAccessPermissionsKey == null)
			{
				_VolumeSupportsAccessPermissionsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsAccessPermissionsKey");
			}
			return _VolumeSupportsAccessPermissionsKey;
		}
	}

	[Field("NSURLVolumeSupportsAdvisoryFileLockingKey", "Foundation")]
	public static NSString VolumeSupportsAdvisoryFileLockingKey
	{
		get
		{
			if (_VolumeSupportsAdvisoryFileLockingKey == null)
			{
				_VolumeSupportsAdvisoryFileLockingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsAdvisoryFileLockingKey");
			}
			return _VolumeSupportsAdvisoryFileLockingKey;
		}
	}

	[Field("NSURLVolumeSupportsCasePreservedNamesKey", "Foundation")]
	public static NSString VolumeSupportsCasePreservedNamesKey
	{
		get
		{
			if (_VolumeSupportsCasePreservedNamesKey == null)
			{
				_VolumeSupportsCasePreservedNamesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsCasePreservedNamesKey");
			}
			return _VolumeSupportsCasePreservedNamesKey;
		}
	}

	[Field("NSURLVolumeSupportsCaseSensitiveNamesKey", "Foundation")]
	public static NSString VolumeSupportsCaseSensitiveNamesKey
	{
		get
		{
			if (_VolumeSupportsCaseSensitiveNamesKey == null)
			{
				_VolumeSupportsCaseSensitiveNamesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsCaseSensitiveNamesKey");
			}
			return _VolumeSupportsCaseSensitiveNamesKey;
		}
	}

	[Field("NSURLVolumeSupportsCompressionKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsCompressionKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsCompressionKey == null)
			{
				_VolumeSupportsCompressionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsCompressionKey");
			}
			return _VolumeSupportsCompressionKey;
		}
	}

	[Field("NSURLVolumeSupportsExclusiveRenamingKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsExclusiveRenamingKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsExclusiveRenamingKey == null)
			{
				_VolumeSupportsExclusiveRenamingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsExclusiveRenamingKey");
			}
			return _VolumeSupportsExclusiveRenamingKey;
		}
	}

	[Field("NSURLVolumeSupportsExtendedSecurityKey", "Foundation")]
	public static NSString VolumeSupportsExtendedSecurityKey
	{
		get
		{
			if (_VolumeSupportsExtendedSecurityKey == null)
			{
				_VolumeSupportsExtendedSecurityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsExtendedSecurityKey");
			}
			return _VolumeSupportsExtendedSecurityKey;
		}
	}

	[Field("NSURLVolumeSupportsFileCloningKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsFileCloningKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsFileCloningKey == null)
			{
				_VolumeSupportsFileCloningKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsFileCloningKey");
			}
			return _VolumeSupportsFileCloningKey;
		}
	}

	[Field("NSURLVolumeSupportsHardLinksKey", "Foundation")]
	public static NSString VolumeSupportsHardLinksKey
	{
		get
		{
			if (_VolumeSupportsHardLinksKey == null)
			{
				_VolumeSupportsHardLinksKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsHardLinksKey");
			}
			return _VolumeSupportsHardLinksKey;
		}
	}

	[Field("NSURLVolumeSupportsImmutableFilesKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsImmutableFilesKey
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsImmutableFilesKey == null)
			{
				_VolumeSupportsImmutableFilesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsImmutableFilesKey");
			}
			return _VolumeSupportsImmutableFilesKey;
		}
	}

	[Field("NSURLVolumeSupportsJournalingKey", "Foundation")]
	public static NSString VolumeSupportsJournalingKey
	{
		get
		{
			if (_VolumeSupportsJournalingKey == null)
			{
				_VolumeSupportsJournalingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsJournalingKey");
			}
			return _VolumeSupportsJournalingKey;
		}
	}

	[Field("NSURLVolumeSupportsPersistentIDsKey", "Foundation")]
	public static NSString VolumeSupportsPersistentIDsKey
	{
		get
		{
			if (_VolumeSupportsPersistentIDsKey == null)
			{
				_VolumeSupportsPersistentIDsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsPersistentIDsKey");
			}
			return _VolumeSupportsPersistentIDsKey;
		}
	}

	[Field("NSURLVolumeSupportsRenamingKey", "Foundation")]
	public static NSString VolumeSupportsRenamingKey
	{
		get
		{
			if (_VolumeSupportsRenamingKey == null)
			{
				_VolumeSupportsRenamingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsRenamingKey");
			}
			return _VolumeSupportsRenamingKey;
		}
	}

	[Field("NSURLVolumeSupportsRootDirectoryDatesKey", "Foundation")]
	public static NSString VolumeSupportsRootDirectoryDatesKey
	{
		get
		{
			if (_VolumeSupportsRootDirectoryDatesKey == null)
			{
				_VolumeSupportsRootDirectoryDatesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsRootDirectoryDatesKey");
			}
			return _VolumeSupportsRootDirectoryDatesKey;
		}
	}

	[Field("NSURLVolumeSupportsSparseFilesKey", "Foundation")]
	public static NSString VolumeSupportsSparseFilesKey
	{
		get
		{
			if (_VolumeSupportsSparseFilesKey == null)
			{
				_VolumeSupportsSparseFilesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsSparseFilesKey");
			}
			return _VolumeSupportsSparseFilesKey;
		}
	}

	[Field("NSURLVolumeSupportsSwapRenamingKey", "Foundation")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VolumeSupportsSwapRenamingKey
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VolumeSupportsSwapRenamingKey == null)
			{
				_VolumeSupportsSwapRenamingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsSwapRenamingKey");
			}
			return _VolumeSupportsSwapRenamingKey;
		}
	}

	[Field("NSURLVolumeSupportsSymbolicLinksKey", "Foundation")]
	public static NSString VolumeSupportsSymbolicLinksKey
	{
		get
		{
			if (_VolumeSupportsSymbolicLinksKey == null)
			{
				_VolumeSupportsSymbolicLinksKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsSymbolicLinksKey");
			}
			return _VolumeSupportsSymbolicLinksKey;
		}
	}

	[Field("NSURLVolumeSupportsVolumeSizesKey", "Foundation")]
	public static NSString VolumeSupportsVolumeSizesKey
	{
		get
		{
			if (_VolumeSupportsVolumeSizesKey == null)
			{
				_VolumeSupportsVolumeSizesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsVolumeSizesKey");
			}
			return _VolumeSupportsVolumeSizesKey;
		}
	}

	[Field("NSURLVolumeSupportsZeroRunsKey", "Foundation")]
	public static NSString VolumeSupportsZeroRunsKey
	{
		get
		{
			if (_VolumeSupportsZeroRunsKey == null)
			{
				_VolumeSupportsZeroRunsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeSupportsZeroRunsKey");
			}
			return _VolumeSupportsZeroRunsKey;
		}
	}

	[Field("NSURLVolumeTotalCapacityKey", "Foundation")]
	public static NSString VolumeTotalCapacityKey
	{
		get
		{
			if (_VolumeTotalCapacityKey == null)
			{
				_VolumeTotalCapacityKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeTotalCapacityKey");
			}
			return _VolumeTotalCapacityKey;
		}
	}

	[Field("NSURLVolumeURLForRemountingKey", "Foundation")]
	public static NSString VolumeURLForRemountingKey
	{
		get
		{
			if (_VolumeURLForRemountingKey == null)
			{
				_VolumeURLForRemountingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeURLForRemountingKey");
			}
			return _VolumeURLForRemountingKey;
		}
	}

	[Field("NSURLVolumeURLKey", "Foundation")]
	public static NSString VolumeURLKey
	{
		get
		{
			if (_VolumeURLKey == null)
			{
				_VolumeURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeURLKey");
			}
			return _VolumeURLKey;
		}
	}

	[Field("NSURLVolumeUUIDStringKey", "Foundation")]
	public static NSString VolumeUUIDStringKey
	{
		get
		{
			if (_VolumeUUIDStringKey == null)
			{
				_VolumeUUIDStringKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLVolumeUUIDStringKey");
			}
			return _VolumeUUIDStringKey;
		}
	}

	public NSUrl(string path, string relativeToUrl)
		: this(path, new NSUrl(relativeToUrl))
	{
	}

	public bool Equals(NSUrl url)
	{
		if (url == null)
		{
			return false;
		}
		return (base.IsDirectBinding && url.IsDirectBinding) ? IsEqual(url) : Equals((object)url);
	}

	public static implicit operator Uri(NSUrl url)
	{
		if (url.RelativePath == url.Path)
		{
			return new Uri(url.AbsoluteString, UriKind.Absolute);
		}
		return new Uri(url.RelativePath, UriKind.Relative);
	}

	public static implicit operator NSUrl(Uri uri)
	{
		if (uri.IsAbsoluteUri)
		{
			return new NSUrl(uri.AbsoluteUri);
		}
		return new NSUrl(uri.PathAndQuery);
	}

	public static NSUrl FromFilename(string url)
	{
		return new NSUrl(url, isDir: false);
	}

	public NSUrl MakeRelative(string url)
	{
		return _FromStringRelative(url, this);
	}

	public override string ToString()
	{
		return AbsoluteString ?? base.ToString();
	}

	public bool TryGetResource(NSString nsUrlResourceKey, out NSObject value, out NSError error)
	{
		return GetResourceValue(out value, nsUrlResourceKey, out error);
	}

	public bool TryGetResource(NSString nsUrlResourceKey, out NSObject value)
	{
		NSError error;
		return GetResourceValue(out value, nsUrlResourceKey, out error);
	}

	public bool SetResource(NSString nsUrlResourceKey, NSObject value, out NSError error)
	{
		return SetResourceValue(value, nsUrlResourceKey, out error);
	}

	public bool SetResource(NSString nsUrlResourceKey, NSObject value)
	{
		NSError error;
		return SetResourceValue(value, nsUrlResourceKey, out error);
	}

	public static bool operator ==(NSUrl? x, NSUrl? y)
	{
		if ((object)x == y)
		{
			return true;
		}
		if ((object)x == null || (object)y == null)
		{
			return false;
		}
		return x.Equals(y);
	}

	public static bool operator !=(NSUrl? x, NSUrl? y)
	{
		return !(x == y);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrl(NSCoder coder)
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
	protected NSUrl(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithScheme:host:path:")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlComponents' instead.")]
	[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, "Use 'NSUrlComponents' instead.")]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlComponents' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlComponents' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(string scheme, string host, string path)
		: base(NSObjectFlag.Empty)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(scheme);
		IntPtr arg2 = NSString.CreateNative(host);
		IntPtr arg3 = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithScheme_Host_Path_Handle, arg, arg2, arg3), "initWithScheme:host:path:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithScheme_Host_Path_Handle, arg, arg2, arg3), "initWithScheme:host:path:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initFileURLWithPath:isDirectory:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(string path, bool isDir)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitFileURLWithPath_IsDirectory_Handle, arg, isDir), "initFileURLWithPath:isDirectory:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitFileURLWithPath_IsDirectory_Handle, arg, isDir), "initFileURLWithPath:isDirectory:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(string urlString)
		: base(NSObjectFlag.Empty)
	{
		if (urlString == null)
		{
			throw new ArgumentNullException("urlString");
		}
		IntPtr arg = NSString.CreateNative(urlString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:relativeToURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(string urlString, NSUrl relativeToUrl)
		: base(NSObjectFlag.Empty)
	{
		if (urlString == null)
		{
			throw new ArgumentNullException("urlString");
		}
		if (relativeToUrl == null)
		{
			throw new ArgumentNullException("relativeToUrl");
		}
		IntPtr arg = NSString.CreateNative(urlString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithString_RelativeToURL_Handle, arg, relativeToUrl.Handle), "initWithString:relativeToURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithString_RelativeToURL_Handle, arg, relativeToUrl.Handle), "initWithString:relativeToURL:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(IntPtr ptrUtf8path, bool isDir, NSUrl baseURL)
		: base(NSObjectFlag.Empty)
	{
		if (baseURL == null)
		{
			throw new ArgumentNullException("baseURL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_Handle, ptrUtf8path, isDir, baseURL.Handle), "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selInitFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_Handle, ptrUtf8path, isDir, baseURL.Handle), "initFileURLWithFileSystemRepresentation:isDirectory:relativeToURL:");
		}
	}

	[Export("initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(NSData bookmarkData, NSUrlBookmarkResolutionOptions resolutionOptions, NSUrl? relativeUrl, out bool bookmarkIsStale, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (bookmarkData == null)
		{
			throw new ArgumentNullException("bookmarkData");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_ref_IntPtr(base.Handle, selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_Handle, bookmarkData.Handle, (ulong)resolutionOptions, (relativeUrl == null) ? IntPtr.Zero : relativeUrl.Handle, out bookmarkIsStale, ref arg), "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_out_Boolean_ref_IntPtr(base.SuperHandle, selInitByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_Handle, bookmarkData.Handle, (ulong)resolutionOptions, (relativeUrl == null) ? IntPtr.Zero : relativeUrl.Handle, out bookmarkIsStale, ref arg), "initByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initFileURLWithPath:isDirectory:relativeToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl(string path, bool isDir, NSUrl? relativeToUrl)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selInitFileURLWithPath_IsDirectory_RelativeToURL_Handle, arg, isDir, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle), "initFileURLWithPath:isDirectory:relativeToURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selInitFileURLWithPath_IsDirectory_RelativeToURL_Handle, arg, isDir, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle), "initFileURLWithPath:isDirectory:relativeToURL:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("URLByAppendingPathComponent:isDirectory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Append(string pathComponent, bool isDirectory)
	{
		if (pathComponent == null)
		{
			throw new ArgumentNullException("pathComponent");
		}
		IntPtr arg = NSString.CreateNative(pathComponent);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selURLByAppendingPathComponent_IsDirectory_Handle, arg, isDirectory)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selURLByAppendingPathComponent_IsDirectory_Handle, arg, isDirectory)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("URLByAppendingPathExtension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl AppendPathExtension(string extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException("extension");
		}
		IntPtr arg = NSString.CreateNative(extension);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selURLByAppendingPathExtension_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selURLByAppendingPathExtension_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("absoluteURLWithDataRepresentation:relativeToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl CreateAbsoluteUrlWithDataRepresentation(NSData data, NSUrl? relativeToUrl)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAbsoluteURLWithDataRepresentation_RelativeToURL_Handle, data.Handle, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle));
	}

	[Export("bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData CreateBookmarkData(NSUrlBookmarkCreationOptions options, string[] resourceValues, NSUrl? relativeUrl, out NSError error)
	{
		if (resourceValues == null)
		{
			throw new ArgumentNullException("resourceValues");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromStrings(resourceValues);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_Handle, (ulong)options, nSArray.Handle, (relativeUrl == null) ? IntPtr.Zero : relativeUrl.Handle, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_ref_IntPtr(base.Handle, selBookmarkDataWithOptions_IncludingResourceValuesForKeys_RelativeToURL_Error_Handle, (ulong)options, nSArray.Handle, (relativeUrl == null) ? IntPtr.Zero : relativeUrl.Handle, ref arg)));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fileURLWithPathComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl CreateFileUrl(string[] pathComponents)
	{
		if (pathComponents == null)
		{
			throw new ArgumentNullException("pathComponents");
		}
		NSArray nSArray = NSArray.FromStrings(pathComponents);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileURLWithPathComponents_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fileURLWithPath:isDirectory:relativeToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl CreateFileUrl(string path, bool isDir, NSUrl? relativeToUrl)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(class_ptr, selFileURLWithPath_IsDirectory_RelativeToURL_Handle, arg, isDir, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fileURLWithPath:relativeToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl CreateFileUrl(string path, NSUrl? relativeToUrl)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFileURLWithPath_RelativeToURL_Handle, arg, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("URLWithDataRepresentation:relativeToURL:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl CreateWithDataRepresentation(NSData data, NSUrl? relativeToUrl)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selURLWithDataRepresentation_RelativeToURL_Handle, data.Handle, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("URLByResolvingBookmarkData:options:relativeToURL:bookmarkDataIsStale:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl FromBookmarkData(NSData data, NSUrlBookmarkResolutionOptions options, NSUrl? relativeToUrl, out bool isStale, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_ref_IntPtr(class_ptr, selURLByResolvingBookmarkData_Options_RelativeToURL_BookmarkDataIsStale_Error_Handle, data.Handle, (ulong)options, (relativeToUrl == null) ? IntPtr.Zero : relativeToUrl.Handle, out isStale, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("URLFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl FromPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLFromPasteboard_Handle, pasteboard.Handle));
	}

	[Export("URLWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl FromString(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		IntPtr arg = NSString.CreateNative(s);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selURLWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fileURLWithFileSystemRepresentation:isDirectory:relativeToURL:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl FromUTF8Pointer(IntPtr ptrUtf8path, bool isDir, NSUrl baseURL)
	{
		if (baseURL == null)
		{
			throw new ArgumentNullException("baseURL");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(class_ptr, selFileURLWithFileSystemRepresentation_IsDirectory_RelativeToURL_Handle, ptrUtf8path, isDir, baseURL.Handle));
	}

	[Export("bookmarkDataWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData GetBookmarkData(NSUrl bookmarkFileUrl, out NSError error)
	{
		if (bookmarkFileUrl == null)
		{
			throw new ArgumentNullException("bookmarkFileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selBookmarkDataWithContentsOfURL_Error_Handle, bookmarkFileUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("getFileSystemRepresentation:maxLength:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetFileSystemRepresentation(IntPtr buffer, nint maxBufferLength)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nint(base.Handle, selGetFileSystemRepresentation_MaxLength_Handle, buffer, maxBufferLength);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selGetFileSystemRepresentation_MaxLength_Handle, buffer, maxBufferLength);
	}

	[Export("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier(string typeIdentifier)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		NSItemProviderRepresentationVisibility result = (NSItemProviderRepresentationVisibility)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectWithItemProviderData:typeIdentifier:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? GetObject(NSData data, string typeIdentifier, out NSError? outError)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeIdentifier);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_Handle, data.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getResourceValue:forKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool GetResourceValue(out NSObject value, NSString key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetResourceValue_ForKey_Error_Handle, ref arg, key.Handle, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetResourceValue_ForKey_Error_Handle, ref arg, key.Handle, ref arg2));
		value = Runtime.GetNSObject<NSObject>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("resourceValuesForKeys:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetResourceValues(NSString[] keys, out NSError error)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(keys);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selResourceValuesForKeys_Error_Handle, nSArray.Handle, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selResourceValuesForKeys_Error_Handle, nSArray.Handle, ref arg)));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqual:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool IsEqual(NSUrl? other)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqual_Handle, (other == null) ? IntPtr.Zero : other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqual_Handle, (other == null) ? IntPtr.Zero : other.Handle);
	}

	[Export("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress? LoadData(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataAsync(string typeIdentifier)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataAsync(string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		result = LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("removeAllCachedResourceValues")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllCachedResourceValues()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllCachedResourceValuesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllCachedResourceValuesHandle);
		}
	}

	[Export("removeCachedResourceValueForKey:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCachedResourceValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCachedResourceValueForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCachedResourceValueForKey_Handle, key.Handle);
		}
	}

	[Export("URLByDeletingLastPathComponent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl RemoveLastPathComponent()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLByDeletingLastPathComponentHandle));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLByDeletingLastPathComponentHandle));
	}

	[Export("URLByDeletingPathExtension")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl RemovePathExtension()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLByDeletingPathExtensionHandle));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLByDeletingPathExtensionHandle));
	}

	[Export("URLByResolvingAliasFileAtURL:options:error:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl ResolveAlias(NSUrl aliasFileUrl, NSUrlBookmarkResolutionOptions options, out NSError error)
	{
		if (aliasFileUrl == null)
		{
			throw new ArgumentNullException("aliasFileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selURLByResolvingAliasFileAtURL_Options_Error_Handle, aliasFileUrl.Handle, (ulong)options, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("setResourceValue:forKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool SetResourceValue(NSObject value, NSString key, out NSError error)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selSetResourceValue_ForKey_Error_Handle, value.Handle, key.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selSetResourceValue_ForKey_Error_Handle, value.Handle, key.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setTemporaryResourceValue:forKey:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTemporaryResourceValue(NSObject value, NSString key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetTemporaryResourceValue_ForKey_Handle, value.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetTemporaryResourceValue_ForKey_Handle, value.Handle, key.Handle);
		}
	}

	[Export("startAccessingSecurityScopedResource")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartAccessingSecurityScopedResource()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartAccessingSecurityScopedResourceHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartAccessingSecurityScopedResourceHandle);
	}

	[Export("stopAccessingSecurityScopedResource")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopAccessingSecurityScopedResource()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAccessingSecurityScopedResourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAccessingSecurityScopedResourceHandle);
		}
	}

	[Export("writeBookmarkData:toURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool WriteBookmarkData(NSData data, NSUrl bookmarkFileUrl, NSUrlBookmarkCreationOptions options, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (bookmarkFileUrl == null)
		{
			throw new ArgumentNullException("bookmarkFileUrl");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(class_ptr, selWriteBookmarkData_ToURL_Options_Error_Handle, data.Handle, bookmarkFileUrl.Handle, (ulong)options, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeToPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteToPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
	}

	[Export("URLWithString:relativeToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrl _FromStringRelative(string url, NSUrl relative)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (relative == null)
		{
			throw new ArgumentNullException("relative");
		}
		IntPtr arg = NSString.CreateNative(url);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selURLWithString_RelativeToURL_Handle, arg, relative.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
