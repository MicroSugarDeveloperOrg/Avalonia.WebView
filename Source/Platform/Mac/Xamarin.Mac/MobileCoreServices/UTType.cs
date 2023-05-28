using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace MobileCoreServices;

public static class UTType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVIMovie;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Alembic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AliasFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AliasRecord;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleICNS;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleProtectedMPEG4Audio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleProtectedMPEG4Video;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Application;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationBundle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplicationFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Archive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssemblyLanguageSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Audio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioInterchangeFileFormat;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudiovisualContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BMP;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BinaryPropertyList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bookmark;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bundle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Bzip2Archive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CHeader;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CPlusPlusHeader;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CPlusPlusSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CalendarEvent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CommaSeparatedText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompositeContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConformsToKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Contact;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Content;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Data;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Database;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DelimitedText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Directory;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DiskImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ElectronicPublication;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmailMessage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Executable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExportedTypeDeclarationsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileURL;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FlatRTFD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Folder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Font;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Framework;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GIF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GNUZipArchive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HTML;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ICO;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IconFileKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Image;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImportedTypeDeclarationsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InkText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InternetLocation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Item;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JPEG;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JPEG2000;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JSON;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JavaArchive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JavaClass;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JavaScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JavaSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Log;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _M3UPlaylist;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MIDIAudio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MP3;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MPEG;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MPEG2TransportStream;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MPEG2Video;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MPEG4;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MPEG4Audio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Message;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MountPoint;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Movie;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OSAScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OSAScriptBundle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ObjectiveCPlusPlusSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ObjectiveCSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PDF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PHPScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PICT;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PKCS12;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PNG;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Package;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PerlScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlainText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Playlist;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PluginBundle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Polygon;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Presentation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PythonScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuickLookGenerator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuickTimeImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QuickTimeMovie;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RTF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RTFD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RawImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Resolvable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RubyScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalableVectorGraphics;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Script;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShellScript;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SourceCode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SpotlightImporter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Spreadsheet;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Stereolithography;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SwiftSource;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SymLink;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemPreferencesPane;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TIFF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TXNTextAndMultimediaData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TabSeparatedText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TagClassFilenameExtension;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TagClassMIMEType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TagClassNSPboardType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TagClassOSType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TagSpecificationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Text;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThreeDContent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ToDoItem;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _URL;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _URLBookmarkData;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UTF16ExternalPlainText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UTF16PlainText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UTF8PlainText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UTF8TabSeparatedText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UniversalSceneDescription;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnixExecutable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VCard;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VersionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Video;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Volume;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WaveformAudio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WebArchive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WindowsExecutable;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _X509Certificate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XML;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XMLPropertyList;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _XPCService;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ZipArchive;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _k3dObject;

	[Field("kUTTypeAVIMovie", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AVIMovie
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AVIMovie == null)
			{
				_AVIMovie = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAVIMovie");
			}
			return _AVIMovie;
		}
	}

	[Field("kUTTypeAlembic", "ModelIO")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Alembic
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Alembic == null)
			{
				_Alembic = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "kUTTypeAlembic");
			}
			return _Alembic;
		}
	}

	[Field("kUTTypeAliasFile", "CoreServices")]
	public static NSString AliasFile
	{
		get
		{
			if (_AliasFile == null)
			{
				_AliasFile = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAliasFile");
			}
			return _AliasFile;
		}
	}

	[Field("kUTTypeAliasRecord", "CoreServices")]
	public static NSString AliasRecord
	{
		get
		{
			if (_AliasRecord == null)
			{
				_AliasRecord = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAliasRecord");
			}
			return _AliasRecord;
		}
	}

	[Field("kUTTypeAppleICNS", "CoreServices")]
	public static NSString AppleICNS
	{
		get
		{
			if (_AppleICNS == null)
			{
				_AppleICNS = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAppleICNS");
			}
			return _AppleICNS;
		}
	}

	[Field("kUTTypeAppleProtectedMPEG4Audio", "CoreServices")]
	public static NSString AppleProtectedMPEG4Audio
	{
		get
		{
			if (_AppleProtectedMPEG4Audio == null)
			{
				_AppleProtectedMPEG4Audio = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAppleProtectedMPEG4Audio");
			}
			return _AppleProtectedMPEG4Audio;
		}
	}

	[Field("kUTTypeAppleProtectedMPEG4Video", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AppleProtectedMPEG4Video
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleProtectedMPEG4Video == null)
			{
				_AppleProtectedMPEG4Video = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAppleProtectedMPEG4Video");
			}
			return _AppleProtectedMPEG4Video;
		}
	}

	[Field("kUTTypeAppleScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AppleScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleScript == null)
			{
				_AppleScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAppleScript");
			}
			return _AppleScript;
		}
	}

	[Field("kUTTypeApplication", "CoreServices")]
	public static NSString Application
	{
		get
		{
			if (_Application == null)
			{
				_Application = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeApplication");
			}
			return _Application;
		}
	}

	[Field("kUTTypeApplicationBundle", "CoreServices")]
	public static NSString ApplicationBundle
	{
		get
		{
			if (_ApplicationBundle == null)
			{
				_ApplicationBundle = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeApplicationBundle");
			}
			return _ApplicationBundle;
		}
	}

	[Field("kUTTypeApplicationFile", "CoreServices")]
	public static NSString ApplicationFile
	{
		get
		{
			if (_ApplicationFile == null)
			{
				_ApplicationFile = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeApplicationFile");
			}
			return _ApplicationFile;
		}
	}

	[Field("kUTTypeArchive", "CoreServices")]
	public static NSString Archive
	{
		get
		{
			if (_Archive == null)
			{
				_Archive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeArchive");
			}
			return _Archive;
		}
	}

	[Field("kUTTypeAssemblyLanguageSource", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AssemblyLanguageSource
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AssemblyLanguageSource == null)
			{
				_AssemblyLanguageSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAssemblyLanguageSource");
			}
			return _AssemblyLanguageSource;
		}
	}

	[Field("kUTTypeAudio", "CoreServices")]
	public static NSString Audio
	{
		get
		{
			if (_Audio == null)
			{
				_Audio = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAudio");
			}
			return _Audio;
		}
	}

	[Field("kUTTypeAudioInterchangeFileFormat", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString AudioInterchangeFileFormat
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioInterchangeFileFormat == null)
			{
				_AudioInterchangeFileFormat = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAudioInterchangeFileFormat");
			}
			return _AudioInterchangeFileFormat;
		}
	}

	[Field("kUTTypeAudiovisualContent", "CoreServices")]
	public static NSString AudiovisualContent
	{
		get
		{
			if (_AudiovisualContent == null)
			{
				_AudiovisualContent = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeAudiovisualContent");
			}
			return _AudiovisualContent;
		}
	}

	[Field("kUTTypeBMP", "CoreServices")]
	public static NSString BMP
	{
		get
		{
			if (_BMP == null)
			{
				_BMP = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeBMP");
			}
			return _BMP;
		}
	}

	[Field("kUTTypeBinaryPropertyList", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString BinaryPropertyList
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BinaryPropertyList == null)
			{
				_BinaryPropertyList = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeBinaryPropertyList");
			}
			return _BinaryPropertyList;
		}
	}

	[Field("kUTTypeBookmark", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Bookmark
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Bookmark == null)
			{
				_Bookmark = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeBookmark");
			}
			return _Bookmark;
		}
	}

	[Field("kUTTypeBundle", "CoreServices")]
	public static NSString Bundle
	{
		get
		{
			if (_Bundle == null)
			{
				_Bundle = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeBundle");
			}
			return _Bundle;
		}
	}

	[Field("kUTTypeBzip2Archive", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Bzip2Archive
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Bzip2Archive == null)
			{
				_Bzip2Archive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeBzip2Archive");
			}
			return _Bzip2Archive;
		}
	}

	[Field("kUTTypeCHeader", "CoreServices")]
	public static NSString CHeader
	{
		get
		{
			if (_CHeader == null)
			{
				_CHeader = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCHeader");
			}
			return _CHeader;
		}
	}

	[Field("kUTTypeCPlusPlusHeader", "CoreServices")]
	public static NSString CPlusPlusHeader
	{
		get
		{
			if (_CPlusPlusHeader == null)
			{
				_CPlusPlusHeader = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCPlusPlusHeader");
			}
			return _CPlusPlusHeader;
		}
	}

	[Field("kUTTypeCPlusPlusSource", "CoreServices")]
	public static NSString CPlusPlusSource
	{
		get
		{
			if (_CPlusPlusSource == null)
			{
				_CPlusPlusSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCPlusPlusSource");
			}
			return _CPlusPlusSource;
		}
	}

	[Field("kUTTypeCSource", "CoreServices")]
	public static NSString CSource
	{
		get
		{
			if (_CSource == null)
			{
				_CSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCSource");
			}
			return _CSource;
		}
	}

	[Field("kUTTypeCalendarEvent", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString CalendarEvent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CalendarEvent == null)
			{
				_CalendarEvent = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCalendarEvent");
			}
			return _CalendarEvent;
		}
	}

	[Field("kUTTypeCommaSeparatedText", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString CommaSeparatedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CommaSeparatedText == null)
			{
				_CommaSeparatedText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCommaSeparatedText");
			}
			return _CommaSeparatedText;
		}
	}

	[Field("kUTTypeCompositeContent", "CoreServices")]
	public static NSString CompositeContent
	{
		get
		{
			if (_CompositeContent == null)
			{
				_CompositeContent = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeCompositeContent");
			}
			return _CompositeContent;
		}
	}

	[Field("kUTTypeConformsToKey", "CoreServices")]
	public static NSString ConformsToKey
	{
		get
		{
			if (_ConformsToKey == null)
			{
				_ConformsToKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeConformsToKey");
			}
			return _ConformsToKey;
		}
	}

	[Field("kUTTypeContact", "CoreServices")]
	public static NSString Contact
	{
		get
		{
			if (_Contact == null)
			{
				_Contact = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeContact");
			}
			return _Contact;
		}
	}

	[Field("kUTTypeContent", "CoreServices")]
	public static NSString Content
	{
		get
		{
			if (_Content == null)
			{
				_Content = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeContent");
			}
			return _Content;
		}
	}

	[Field("kUTTypeData", "CoreServices")]
	public static NSString Data
	{
		get
		{
			if (_Data == null)
			{
				_Data = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeData");
			}
			return _Data;
		}
	}

	[Field("kUTTypeDatabase", "CoreServices")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Database
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Database == null)
			{
				_Database = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeDatabase");
			}
			return _Database;
		}
	}

	[Field("kUTTypeDelimitedText", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString DelimitedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DelimitedText == null)
			{
				_DelimitedText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeDelimitedText");
			}
			return _DelimitedText;
		}
	}

	[Field("kUTTypeDescriptionKey", "CoreServices")]
	public static NSString DescriptionKey
	{
		get
		{
			if (_DescriptionKey == null)
			{
				_DescriptionKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeDescriptionKey");
			}
			return _DescriptionKey;
		}
	}

	[Field("kUTTypeDirectory", "CoreServices")]
	public static NSString Directory
	{
		get
		{
			if (_Directory == null)
			{
				_Directory = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeDirectory");
			}
			return _Directory;
		}
	}

	[Field("kUTTypeDiskImage", "CoreServices")]
	public static NSString DiskImage
	{
		get
		{
			if (_DiskImage == null)
			{
				_DiskImage = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeDiskImage");
			}
			return _DiskImage;
		}
	}

	[Field("kUTTypeElectronicPublication", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ElectronicPublication
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ElectronicPublication == null)
			{
				_ElectronicPublication = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeElectronicPublication");
			}
			return _ElectronicPublication;
		}
	}

	[Field("kUTTypeEmailMessage", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString EmailMessage
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EmailMessage == null)
			{
				_EmailMessage = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeEmailMessage");
			}
			return _EmailMessage;
		}
	}

	[Field("kUTTypeExecutable", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Executable
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Executable == null)
			{
				_Executable = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeExecutable");
			}
			return _Executable;
		}
	}

	[Field("kUTExportedTypeDeclarationsKey", "CoreServices")]
	public static NSString ExportedTypeDeclarationsKey
	{
		get
		{
			if (_ExportedTypeDeclarationsKey == null)
			{
				_ExportedTypeDeclarationsKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTExportedTypeDeclarationsKey");
			}
			return _ExportedTypeDeclarationsKey;
		}
	}

	[Field("kUTTypeFileURL", "CoreServices")]
	public static NSString FileURL
	{
		get
		{
			if (_FileURL == null)
			{
				_FileURL = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeFileURL");
			}
			return _FileURL;
		}
	}

	[Field("kUTTypeFlatRTFD", "CoreServices")]
	public static NSString FlatRTFD
	{
		get
		{
			if (_FlatRTFD == null)
			{
				_FlatRTFD = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeFlatRTFD");
			}
			return _FlatRTFD;
		}
	}

	[Field("kUTTypeFolder", "CoreServices")]
	public static NSString Folder
	{
		get
		{
			if (_Folder == null)
			{
				_Folder = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeFolder");
			}
			return _Folder;
		}
	}

	[Field("kUTTypeFont", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Font
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Font == null)
			{
				_Font = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeFont");
			}
			return _Font;
		}
	}

	[Field("kUTTypeFramework", "CoreServices")]
	public static NSString Framework
	{
		get
		{
			if (_Framework == null)
			{
				_Framework = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeFramework");
			}
			return _Framework;
		}
	}

	[Field("kUTTypeGIF", "CoreServices")]
	public static NSString GIF
	{
		get
		{
			if (_GIF == null)
			{
				_GIF = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeGIF");
			}
			return _GIF;
		}
	}

	[Field("kUTTypeGNUZipArchive", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString GNUZipArchive
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GNUZipArchive == null)
			{
				_GNUZipArchive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeGNUZipArchive");
			}
			return _GNUZipArchive;
		}
	}

	[Field("kUTTypeHTML", "CoreServices")]
	public static NSString HTML
	{
		get
		{
			if (_HTML == null)
			{
				_HTML = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeHTML");
			}
			return _HTML;
		}
	}

	[Field("kUTTypeICO", "CoreServices")]
	public static NSString ICO
	{
		get
		{
			if (_ICO == null)
			{
				_ICO = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeICO");
			}
			return _ICO;
		}
	}

	[Field("kUTTypeIconFileKey", "CoreServices")]
	public static NSString IconFileKey
	{
		get
		{
			if (_IconFileKey == null)
			{
				_IconFileKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeIconFileKey");
			}
			return _IconFileKey;
		}
	}

	[Field("kUTTypeIdentifierKey", "CoreServices")]
	public static NSString IdentifierKey
	{
		get
		{
			if (_IdentifierKey == null)
			{
				_IdentifierKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeIdentifierKey");
			}
			return _IdentifierKey;
		}
	}

	[Field("kUTTypeImage", "CoreServices")]
	public static NSString Image
	{
		get
		{
			if (_Image == null)
			{
				_Image = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeImage");
			}
			return _Image;
		}
	}

	[Field("kUTImportedTypeDeclarationsKey", "CoreServices")]
	public static NSString ImportedTypeDeclarationsKey
	{
		get
		{
			if (_ImportedTypeDeclarationsKey == null)
			{
				_ImportedTypeDeclarationsKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTImportedTypeDeclarationsKey");
			}
			return _ImportedTypeDeclarationsKey;
		}
	}

	[Field("kUTTypeInkText", "CoreServices")]
	public static NSString InkText
	{
		get
		{
			if (_InkText == null)
			{
				_InkText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeInkText");
			}
			return _InkText;
		}
	}

	[Field("kUTTypeInternetLocation", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString InternetLocation
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_InternetLocation == null)
			{
				_InternetLocation = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeInternetLocation");
			}
			return _InternetLocation;
		}
	}

	[Field("kUTTypeItem", "CoreServices")]
	public static NSString Item
	{
		get
		{
			if (_Item == null)
			{
				_Item = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeItem");
			}
			return _Item;
		}
	}

	[Field("kUTTypeJPEG", "CoreServices")]
	public static NSString JPEG
	{
		get
		{
			if (_JPEG == null)
			{
				_JPEG = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJPEG");
			}
			return _JPEG;
		}
	}

	[Field("kUTTypeJPEG2000", "CoreServices")]
	public static NSString JPEG2000
	{
		get
		{
			if (_JPEG2000 == null)
			{
				_JPEG2000 = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJPEG2000");
			}
			return _JPEG2000;
		}
	}

	[Field("kUTTypeJSON", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString JSON
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_JSON == null)
			{
				_JSON = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJSON");
			}
			return _JSON;
		}
	}

	[Field("kUTTypeJavaArchive", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString JavaArchive
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_JavaArchive == null)
			{
				_JavaArchive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJavaArchive");
			}
			return _JavaArchive;
		}
	}

	[Field("kUTTypeJavaClass", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString JavaClass
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_JavaClass == null)
			{
				_JavaClass = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJavaClass");
			}
			return _JavaClass;
		}
	}

	[Field("kUTTypeJavaScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString JavaScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_JavaScript == null)
			{
				_JavaScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJavaScript");
			}
			return _JavaScript;
		}
	}

	[Field("kUTTypeJavaSource", "CoreServices")]
	public static NSString JavaSource
	{
		get
		{
			if (_JavaSource == null)
			{
				_JavaSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeJavaSource");
			}
			return _JavaSource;
		}
	}

	[Field("kUTTypeLog", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Log
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Log == null)
			{
				_Log = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeLog");
			}
			return _Log;
		}
	}

	[Field("kUTTypeM3UPlaylist", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString M3UPlaylist
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_M3UPlaylist == null)
			{
				_M3UPlaylist = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeM3UPlaylist");
			}
			return _M3UPlaylist;
		}
	}

	[Field("kUTTypeMIDIAudio", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString MIDIAudio
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MIDIAudio == null)
			{
				_MIDIAudio = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMIDIAudio");
			}
			return _MIDIAudio;
		}
	}

	[Field("kUTTypeMP3", "CoreServices")]
	public static NSString MP3
	{
		get
		{
			if (_MP3 == null)
			{
				_MP3 = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMP3");
			}
			return _MP3;
		}
	}

	[Field("kUTTypeMPEG", "CoreServices")]
	public static NSString MPEG
	{
		get
		{
			if (_MPEG == null)
			{
				_MPEG = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMPEG");
			}
			return _MPEG;
		}
	}

	[Field("kUTTypeMPEG2TransportStream", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString MPEG2TransportStream
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MPEG2TransportStream == null)
			{
				_MPEG2TransportStream = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMPEG2TransportStream");
			}
			return _MPEG2TransportStream;
		}
	}

	[Field("kUTTypeMPEG2Video", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString MPEG2Video
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MPEG2Video == null)
			{
				_MPEG2Video = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMPEG2Video");
			}
			return _MPEG2Video;
		}
	}

	[Field("kUTTypeMPEG4", "CoreServices")]
	public static NSString MPEG4
	{
		get
		{
			if (_MPEG4 == null)
			{
				_MPEG4 = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMPEG4");
			}
			return _MPEG4;
		}
	}

	[Field("kUTTypeMPEG4Audio", "CoreServices")]
	public static NSString MPEG4Audio
	{
		get
		{
			if (_MPEG4Audio == null)
			{
				_MPEG4Audio = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMPEG4Audio");
			}
			return _MPEG4Audio;
		}
	}

	[Field("kUTTypeMessage", "CoreServices")]
	public static NSString Message
	{
		get
		{
			if (_Message == null)
			{
				_Message = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMessage");
			}
			return _Message;
		}
	}

	[Field("kUTTypeMountPoint", "CoreServices")]
	public static NSString MountPoint
	{
		get
		{
			if (_MountPoint == null)
			{
				_MountPoint = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMountPoint");
			}
			return _MountPoint;
		}
	}

	[Field("kUTTypeMovie", "CoreServices")]
	public static NSString Movie
	{
		get
		{
			if (_Movie == null)
			{
				_Movie = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeMovie");
			}
			return _Movie;
		}
	}

	[Field("kUTTypeOSAScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString OSAScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OSAScript == null)
			{
				_OSAScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeOSAScript");
			}
			return _OSAScript;
		}
	}

	[Field("kUTTypeOSAScriptBundle", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString OSAScriptBundle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OSAScriptBundle == null)
			{
				_OSAScriptBundle = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeOSAScriptBundle");
			}
			return _OSAScriptBundle;
		}
	}

	[Field("kUTTypeObjectiveCPlusPlusSource", "CoreServices")]
	public static NSString ObjectiveCPlusPlusSource
	{
		get
		{
			if (_ObjectiveCPlusPlusSource == null)
			{
				_ObjectiveCPlusPlusSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeObjectiveCPlusPlusSource");
			}
			return _ObjectiveCPlusPlusSource;
		}
	}

	[Field("kUTTypeObjectiveCSource", "CoreServices")]
	public static NSString ObjectiveCSource
	{
		get
		{
			if (_ObjectiveCSource == null)
			{
				_ObjectiveCSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeObjectiveCSource");
			}
			return _ObjectiveCSource;
		}
	}

	[Field("kUTTypePDF", "CoreServices")]
	public static NSString PDF
	{
		get
		{
			if (_PDF == null)
			{
				_PDF = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePDF");
			}
			return _PDF;
		}
	}

	[Field("kUTTypePHPScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PHPScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PHPScript == null)
			{
				_PHPScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePHPScript");
			}
			return _PHPScript;
		}
	}

	[Field("kUTTypePICT", "CoreServices")]
	public static NSString PICT
	{
		get
		{
			if (_PICT == null)
			{
				_PICT = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePICT");
			}
			return _PICT;
		}
	}

	[Field("kUTTypePKCS12", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PKCS12
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PKCS12 == null)
			{
				_PKCS12 = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePKCS12");
			}
			return _PKCS12;
		}
	}

	[Field("kUTTypePNG", "CoreServices")]
	public static NSString PNG
	{
		get
		{
			if (_PNG == null)
			{
				_PNG = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePNG");
			}
			return _PNG;
		}
	}

	[Field("kUTTypePackage", "CoreServices")]
	public static NSString Package
	{
		get
		{
			if (_Package == null)
			{
				_Package = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePackage");
			}
			return _Package;
		}
	}

	[Field("kUTTypePerlScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PerlScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PerlScript == null)
			{
				_PerlScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePerlScript");
			}
			return _PerlScript;
		}
	}

	[Field("kUTTypePlainText", "CoreServices")]
	public static NSString PlainText
	{
		get
		{
			if (_PlainText == null)
			{
				_PlainText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePlainText");
			}
			return _PlainText;
		}
	}

	[Field("kUTTypePlaylist", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Playlist
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Playlist == null)
			{
				_Playlist = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePlaylist");
			}
			return _Playlist;
		}
	}

	[Field("kUTTypePluginBundle", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PluginBundle
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PluginBundle == null)
			{
				_PluginBundle = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePluginBundle");
			}
			return _PluginBundle;
		}
	}

	[Field("kUTTypePolygon", "ModelIO")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Polygon
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Polygon == null)
			{
				_Polygon = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "kUTTypePolygon");
			}
			return _Polygon;
		}
	}

	[Field("kUTTypePresentation", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Presentation
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Presentation == null)
			{
				_Presentation = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePresentation");
			}
			return _Presentation;
		}
	}

	[Field("kUTTypePropertyList", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyList
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyList == null)
			{
				_PropertyList = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePropertyList");
			}
			return _PropertyList;
		}
	}

	[Field("kUTTypePythonScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString PythonScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PythonScript == null)
			{
				_PythonScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypePythonScript");
			}
			return _PythonScript;
		}
	}

	[Field("kUTTypeQuickLookGenerator", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString QuickLookGenerator
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QuickLookGenerator == null)
			{
				_QuickLookGenerator = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeQuickLookGenerator");
			}
			return _QuickLookGenerator;
		}
	}

	[Field("kUTTypeQuickTimeImage", "CoreServices")]
	public static NSString QuickTimeImage
	{
		get
		{
			if (_QuickTimeImage == null)
			{
				_QuickTimeImage = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeQuickTimeImage");
			}
			return _QuickTimeImage;
		}
	}

	[Field("kUTTypeQuickTimeMovie", "CoreServices")]
	public static NSString QuickTimeMovie
	{
		get
		{
			if (_QuickTimeMovie == null)
			{
				_QuickTimeMovie = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeQuickTimeMovie");
			}
			return _QuickTimeMovie;
		}
	}

	[Field("kUTTypeRTF", "CoreServices")]
	public static NSString RTF
	{
		get
		{
			if (_RTF == null)
			{
				_RTF = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeRTF");
			}
			return _RTF;
		}
	}

	[Field("kUTTypeRTFD", "CoreServices")]
	public static NSString RTFD
	{
		get
		{
			if (_RTFD == null)
			{
				_RTFD = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeRTFD");
			}
			return _RTFD;
		}
	}

	[Field("kUTTypeRawImage", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString RawImage
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RawImage == null)
			{
				_RawImage = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeRawImage");
			}
			return _RawImage;
		}
	}

	[Field("kUTTypeReferenceURLKey", "CoreServices")]
	public static NSString ReferenceURLKey
	{
		get
		{
			if (_ReferenceURLKey == null)
			{
				_ReferenceURLKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeReferenceURLKey");
			}
			return _ReferenceURLKey;
		}
	}

	[Field("kUTTypeResolvable", "CoreServices")]
	public static NSString Resolvable
	{
		get
		{
			if (_Resolvable == null)
			{
				_Resolvable = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeResolvable");
			}
			return _Resolvable;
		}
	}

	[Field("kUTTypeRubyScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString RubyScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RubyScript == null)
			{
				_RubyScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeRubyScript");
			}
			return _RubyScript;
		}
	}

	[Field("kUTTypeScalableVectorGraphics", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ScalableVectorGraphics
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ScalableVectorGraphics == null)
			{
				_ScalableVectorGraphics = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeScalableVectorGraphics");
			}
			return _ScalableVectorGraphics;
		}
	}

	[Field("kUTTypeScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Script
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Script == null)
			{
				_Script = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeScript");
			}
			return _Script;
		}
	}

	[Field("kUTTypeShellScript", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ShellScript
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ShellScript == null)
			{
				_ShellScript = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeShellScript");
			}
			return _ShellScript;
		}
	}

	[Field("kUTTypeSourceCode", "CoreServices")]
	public static NSString SourceCode
	{
		get
		{
			if (_SourceCode == null)
			{
				_SourceCode = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSourceCode");
			}
			return _SourceCode;
		}
	}

	[Field("kUTTypeSpotlightImporter", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString SpotlightImporter
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SpotlightImporter == null)
			{
				_SpotlightImporter = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSpotlightImporter");
			}
			return _SpotlightImporter;
		}
	}

	[Field("kUTTypeSpreadsheet", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString Spreadsheet
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Spreadsheet == null)
			{
				_Spreadsheet = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSpreadsheet");
			}
			return _Spreadsheet;
		}
	}

	[Field("kUTTypeStereolithography", "ModelIO")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Stereolithography
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Stereolithography == null)
			{
				_Stereolithography = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "kUTTypeStereolithography");
			}
			return _Stereolithography;
		}
	}

	[Field("kUTTypeSwiftSource", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString SwiftSource
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SwiftSource == null)
			{
				_SwiftSource = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSwiftSource");
			}
			return _SwiftSource;
		}
	}

	[Field("kUTTypeSymLink", "CoreServices")]
	public static NSString SymLink
	{
		get
		{
			if (_SymLink == null)
			{
				_SymLink = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSymLink");
			}
			return _SymLink;
		}
	}

	[Field("kUTTypeSystemPreferencesPane", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString SystemPreferencesPane
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SystemPreferencesPane == null)
			{
				_SystemPreferencesPane = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeSystemPreferencesPane");
			}
			return _SystemPreferencesPane;
		}
	}

	[Field("kUTTypeTIFF", "CoreServices")]
	public static NSString TIFF
	{
		get
		{
			if (_TIFF == null)
			{
				_TIFF = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeTIFF");
			}
			return _TIFF;
		}
	}

	[Field("kUTTypeTXNTextAndMultimediaData", "CoreServices")]
	public static NSString TXNTextAndMultimediaData
	{
		get
		{
			if (_TXNTextAndMultimediaData == null)
			{
				_TXNTextAndMultimediaData = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeTXNTextAndMultimediaData");
			}
			return _TXNTextAndMultimediaData;
		}
	}

	[Field("kUTTypeTabSeparatedText", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString TabSeparatedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TabSeparatedText == null)
			{
				_TabSeparatedText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeTabSeparatedText");
			}
			return _TabSeparatedText;
		}
	}

	[Field("kUTTagClassFilenameExtension", "CoreServices")]
	public static NSString TagClassFilenameExtension
	{
		get
		{
			if (_TagClassFilenameExtension == null)
			{
				_TagClassFilenameExtension = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTagClassFilenameExtension");
			}
			return _TagClassFilenameExtension;
		}
	}

	[Field("kUTTagClassMIMEType", "CoreServices")]
	public static NSString TagClassMIMEType
	{
		get
		{
			if (_TagClassMIMEType == null)
			{
				_TagClassMIMEType = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTagClassMIMEType");
			}
			return _TagClassMIMEType;
		}
	}

	[Field("kUTTagClassNSPboardType", "CoreServices")]
	public static NSString TagClassNSPboardType
	{
		get
		{
			if (_TagClassNSPboardType == null)
			{
				_TagClassNSPboardType = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTagClassNSPboardType");
			}
			return _TagClassNSPboardType;
		}
	}

	[Field("kUTTagClassOSType", "CoreServices")]
	public static NSString TagClassOSType
	{
		get
		{
			if (_TagClassOSType == null)
			{
				_TagClassOSType = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTagClassOSType");
			}
			return _TagClassOSType;
		}
	}

	[Field("kUTTypeTagSpecificationKey", "CoreServices")]
	public static NSString TagSpecificationKey
	{
		get
		{
			if (_TagSpecificationKey == null)
			{
				_TagSpecificationKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeTagSpecificationKey");
			}
			return _TagSpecificationKey;
		}
	}

	[Field("kUTTypeText", "CoreServices")]
	public static NSString Text
	{
		get
		{
			if (_Text == null)
			{
				_Text = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeText");
			}
			return _Text;
		}
	}

	[Field("kUTType3DContent", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ThreeDContent
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ThreeDContent == null)
			{
				_ThreeDContent = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTType3DContent");
			}
			return _ThreeDContent;
		}
	}

	[Field("kUTTypeToDoItem", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ToDoItem
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ToDoItem == null)
			{
				_ToDoItem = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeToDoItem");
			}
			return _ToDoItem;
		}
	}

	[Field("kUTTypeURL", "CoreServices")]
	public static NSString URL
	{
		get
		{
			if (_URL == null)
			{
				_URL = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeURL");
			}
			return _URL;
		}
	}

	[Field("kUTTypeURLBookmarkData", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString URLBookmarkData
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_URLBookmarkData == null)
			{
				_URLBookmarkData = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeURLBookmarkData");
			}
			return _URLBookmarkData;
		}
	}

	[Field("kUTTypeUTF16ExternalPlainText", "CoreServices")]
	public static NSString UTF16ExternalPlainText
	{
		get
		{
			if (_UTF16ExternalPlainText == null)
			{
				_UTF16ExternalPlainText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeUTF16ExternalPlainText");
			}
			return _UTF16ExternalPlainText;
		}
	}

	[Field("kUTTypeUTF16PlainText", "CoreServices")]
	public static NSString UTF16PlainText
	{
		get
		{
			if (_UTF16PlainText == null)
			{
				_UTF16PlainText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeUTF16PlainText");
			}
			return _UTF16PlainText;
		}
	}

	[Field("kUTTypeUTF8PlainText", "CoreServices")]
	public static NSString UTF8PlainText
	{
		get
		{
			if (_UTF8PlainText == null)
			{
				_UTF8PlainText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeUTF8PlainText");
			}
			return _UTF8PlainText;
		}
	}

	[Field("kUTTypeUTF8TabSeparatedText", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString UTF8TabSeparatedText
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UTF8TabSeparatedText == null)
			{
				_UTF8TabSeparatedText = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeUTF8TabSeparatedText");
			}
			return _UTF8TabSeparatedText;
		}
	}

	[Field("kUTTypeUniversalSceneDescription", "ModelIO")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString UniversalSceneDescription
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UniversalSceneDescription == null)
			{
				_UniversalSceneDescription = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "kUTTypeUniversalSceneDescription");
			}
			return _UniversalSceneDescription;
		}
	}

	[Field("kUTTypeUnixExecutable", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString UnixExecutable
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UnixExecutable == null)
			{
				_UnixExecutable = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeUnixExecutable");
			}
			return _UnixExecutable;
		}
	}

	[Field("kUTTypeVCard", "CoreServices")]
	public static NSString VCard
	{
		get
		{
			if (_VCard == null)
			{
				_VCard = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeVCard");
			}
			return _VCard;
		}
	}

	[Field("kUTTypeVersionKey", "CoreServices")]
	public static NSString VersionKey
	{
		get
		{
			if (_VersionKey == null)
			{
				_VersionKey = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeVersionKey");
			}
			return _VersionKey;
		}
	}

	[Field("kUTTypeVideo", "CoreServices")]
	public static NSString Video
	{
		get
		{
			if (_Video == null)
			{
				_Video = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeVideo");
			}
			return _Video;
		}
	}

	[Field("kUTTypeVolume", "CoreServices")]
	public static NSString Volume
	{
		get
		{
			if (_Volume == null)
			{
				_Volume = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeVolume");
			}
			return _Volume;
		}
	}

	[Field("kUTTypeWaveformAudio", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString WaveformAudio
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_WaveformAudio == null)
			{
				_WaveformAudio = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeWaveformAudio");
			}
			return _WaveformAudio;
		}
	}

	[Field("kUTTypeWebArchive", "CoreServices")]
	public static NSString WebArchive
	{
		get
		{
			if (_WebArchive == null)
			{
				_WebArchive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeWebArchive");
			}
			return _WebArchive;
		}
	}

	[Field("kUTTypeWindowsExecutable", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString WindowsExecutable
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_WindowsExecutable == null)
			{
				_WindowsExecutable = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeWindowsExecutable");
			}
			return _WindowsExecutable;
		}
	}

	[Field("kUTTypeX509Certificate", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString X509Certificate
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_X509Certificate == null)
			{
				_X509Certificate = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeX509Certificate");
			}
			return _X509Certificate;
		}
	}

	[Field("kUTTypeXML", "CoreServices")]
	public static NSString XML
	{
		get
		{
			if (_XML == null)
			{
				_XML = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeXML");
			}
			return _XML;
		}
	}

	[Field("kUTTypeXMLPropertyList", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString XMLPropertyList
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_XMLPropertyList == null)
			{
				_XMLPropertyList = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeXMLPropertyList");
			}
			return _XMLPropertyList;
		}
	}

	[Field("kUTTypeXPCService", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString XPCService
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_XPCService == null)
			{
				_XPCService = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeXPCService");
			}
			return _XPCService;
		}
	}

	[Field("kUTTypeZipArchive", "CoreServices")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public static NSString ZipArchive
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ZipArchive == null)
			{
				_ZipArchive = Dlfcn.GetStringConstant(Libraries.CoreServices.Handle, "kUTTypeZipArchive");
			}
			return _ZipArchive;
		}
	}

	[Field("kUTType3dObject", "ModelIO")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString k3dObject
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_k3dObject == null)
			{
				_k3dObject = Dlfcn.GetStringConstant(Libraries.ModelIO.Handle, "kUTType3dObject");
			}
			return _k3dObject;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern int UTTypeIsDynamic(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern int UTTypeIsDeclared(IntPtr handle);

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static bool IsDynamic(string utType)
	{
		if (utType == null)
		{
			throw new ArgumentNullException("utType");
		}
		using NSString nSString = new NSString(utType);
		return UTTypeIsDynamic(nSString.Handle) != 0;
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static bool IsDeclared(string utType)
	{
		if (utType == null)
		{
			throw new ArgumentNullException("utType");
		}
		using NSString nSString = new NSString(utType);
		return UTTypeIsDeclared(nSString.Handle) != 0;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCreatePreferredIdentifierForTag(IntPtr tagClassStr, IntPtr tagStr, IntPtr conformingToUtiStr);

	public static string CreatePreferredIdentifier(string tagClass, string tag, string conformingToUti)
	{
		IntPtr intPtr = NSString.CreateNative(tagClass);
		IntPtr intPtr2 = NSString.CreateNative(tag);
		IntPtr intPtr3 = NSString.CreateNative(conformingToUti);
		string result = NSString.FromHandle(UTTypeCreatePreferredIdentifierForTag(intPtr, intPtr2, intPtr3));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		NSString.ReleaseNative(intPtr3);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCreateAllIdentifiersForTag(IntPtr tagClassStr, IntPtr tagStr, IntPtr conformingToUtiStr);

	public static string[] CreateAllIdentifiers(string tagClass, string tag, string conformingToUti)
	{
		if (tagClass == null)
		{
			throw new ArgumentNullException("tagClass");
		}
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		IntPtr intPtr = NSString.CreateNative(tagClass);
		IntPtr intPtr2 = NSString.CreateNative(tag);
		IntPtr intPtr3 = NSString.CreateNative(conformingToUti);
		string[] result = NSArray.StringArrayFromHandle(UTTypeCreateAllIdentifiersForTag(intPtr, intPtr2, intPtr3));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		NSString.ReleaseNative(intPtr3);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[iOS(8, 0)]
	[Mac(10, 10)]
	private static extern IntPtr UTTypeCopyAllTagsWithClass(IntPtr utiStr, IntPtr tagClassStr);

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static string[] CopyAllTags(string uti, string tagClass)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		if (tagClass == null)
		{
			throw new ArgumentNullException("tagClass");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		IntPtr intPtr2 = NSString.CreateNative(tagClass);
		string[] result = NSArray.StringArrayFromHandle(UTTypeCopyAllTagsWithClass(intPtr, intPtr2));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern int UTTypeConformsTo(IntPtr utiStr, IntPtr conformsToUtiStr);

	public static bool ConformsTo(string uti, string conformsToUti)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		if (conformsToUti == null)
		{
			throw new ArgumentNullException("conformsToUti");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		IntPtr intPtr2 = NSString.CreateNative(conformsToUti);
		int num = UTTypeConformsTo(intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return num != 0;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCopyDescription(IntPtr utiStr);

	public static string GetDescription(string uti)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		string result = NSString.FromHandle(UTTypeCopyDescription(intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCopyPreferredTagWithClass(IntPtr uti, IntPtr tagClass);

	public static string GetPreferredTag(string uti, string tagClass)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		if (tagClass == null)
		{
			throw new ArgumentNullException("tagClass");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		IntPtr intPtr2 = NSString.CreateNative(tagClass);
		string result = NSString.FromHandle(UTTypeCopyPreferredTagWithClass(intPtr, intPtr2));
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCopyDeclaration(IntPtr utiStr);

	public static NSDictionary GetDeclaration(string uti)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(UTTypeCopyDeclaration(intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr UTTypeCopyDeclaringBundleURL(IntPtr utiStr);

	public static NSUrl GetDeclaringBundleURL(string uti)
	{
		if (uti == null)
		{
			throw new ArgumentNullException("uti");
		}
		IntPtr intPtr = NSString.CreateNative(uti);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(UTTypeCopyDeclaringBundleURL(intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool UTTypeEqual(IntPtr inUTI1, IntPtr inUTI2);

	[iOS(12, 0)]
	[TV(12, 0)]
	[Watch(5, 0)]
	public static bool Equals(NSString uti1, NSString uti2)
	{
		if (uti1 == null)
		{
			return uti2 == null;
		}
		if (uti2 == null)
		{
			return false;
		}
		return UTTypeEqual(uti1.Handle, uti2.Handle);
	}
}
