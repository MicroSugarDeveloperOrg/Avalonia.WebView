using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFBundle : INativeObject, IDisposable
{
	public enum PackageType
	{
		Application,
		Framework,
		Bundle
	}

	public struct PackageInfo
	{
		public PackageType Type { get; private set; }

		public string Creator { get; private set; }

		public PackageInfo(PackageType type, string creator)
		{
			Type = type;
			Creator = creator;
		}
	}

	public enum Architecture
	{
		I386 = 7,
		X86_64 = 16777223,
		ARM = 18,
		ARM64 = 16777234,
		PPC = 24,
		PPC64 = 16777240
	}

	private IntPtr handle;

	public IntPtr Handle => handle;

	public bool HasLoadedExecutable => CFBundleIsExecutableLoaded(handle);

	public NSUrl BuiltInPlugInsUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopyBuiltInPlugInsURL(handle), owns: true);

	public NSUrl ExecutableUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopyExecutableURL(handle), owns: true);

	public NSUrl PrivateFrameworksUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopyPrivateFrameworksURL(handle), owns: true);

	public NSUrl ResourcesDirectoryUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopyResourcesDirectoryURL(handle), owns: true);

	public NSUrl SharedFrameworksUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopySharedFrameworksURL(handle), owns: true);

	public NSUrl SharedSupportUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopySharedSupportURL(handle), owns: true);

	public NSUrl SupportFilesDirectoryUrl => Runtime.GetNSObject<NSUrl>(CFBundleCopySupportFilesDirectoryURL(handle), owns: true);

	public NSUrl Url => Runtime.GetNSObject<NSUrl>(CFBundleCopyBundleURL(handle), owns: true);

	public string DevelopmentRegion => CFString.FetchString(CFBundleGetDevelopmentRegion(handle));

	public string Identifier => CFString.FetchString(CFBundleGetIdentifier(handle));

	public NSDictionary InfoDictionary => Runtime.GetNSObject<NSDictionary>(CFBundleGetInfoDictionary(handle));

	public NSDictionary LocalInfoDictionary => Runtime.GetNSObject<NSDictionary>(CFBundleGetLocalInfoDictionary(handle));

	public PackageInfo Info
	{
		get
		{
			uint packageType = 0u;
			uint packageCreator = 0u;
			CFBundleGetPackageInfo(handle, out packageType, out packageCreator);
			string creator = FourCCToString(packageCreator);
			return packageType switch
			{
				1095782476u => new PackageInfo(PackageType.Application, creator), 
				1179473739u => new PackageInfo(PackageType.Framework, creator), 
				_ => new PackageInfo(PackageType.Bundle, creator), 
			};
		}
	}

	public Architecture[] Architectures
	{
		get
		{
			using CFArray cFArray = new CFArray(CFBundleCopyExecutableArchitectures(handle), owns: true);
			Architecture[] array = new Architecture[(long)cFArray.Count];
			for (int i = 0; i < cFArray.Count; i++)
			{
				int value = 0;
				if (CFDictionary.CFNumberGetValue(cFArray.GetValue(i), (nint)3, out value))
				{
					array[i] = (Architecture)value;
				}
			}
			return array;
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	~CFBundle()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal CFBundle(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal CFBundle(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(this.handle);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCreate(IntPtr allocator, IntPtr bundleURL);

	public CFBundle(NSUrl bundleUrl)
	{
		if (bundleUrl == null)
		{
			throw new ArgumentNullException("bundleUrl");
		}
		handle = CFBundleCreate(IntPtr.Zero, bundleUrl.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCreateBundlesFromDirectory(IntPtr allocator, IntPtr directoryURL, IntPtr bundleType);

	public static CFBundle[] GetBundlesFromDirectory(NSUrl directoryUrl, string bundleType)
	{
		if (directoryUrl == null)
		{
			throw new ArgumentNullException("directoryUrl");
		}
		if (string.IsNullOrEmpty(bundleType))
		{
			throw new ArgumentException("bundleType");
		}
		using CFString cFString = new CFString(bundleType);
		using CFArray cFArray = new CFArray(CFBundleCreateBundlesFromDirectory(IntPtr.Zero, directoryUrl.Handle, cFString.Handle), owns: true);
		CFBundle[] array = new CFBundle[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new CFBundle(cFArray.GetValue(i), owns: true);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetAllBundles();

	public static CFBundle[] GetAll()
	{
		using CFArray cFArray = new CFArray(CFBundleGetAllBundles());
		using CFArray cFArray2 = cFArray.Clone();
		nint count = cFArray2.Count;
		CFBundle[] array = new CFBundle[(long)count];
		for (int i = 0; i < count; i++)
		{
			array[i] = new CFBundle(cFArray2.GetValue(i), owns: false);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetBundleWithIdentifier(IntPtr bundleID);

	public static CFBundle Get(string bundleID)
	{
		if (string.IsNullOrEmpty(bundleID))
		{
			throw new ArgumentException("bundleID");
		}
		using CFString cFString = new CFString(bundleID);
		IntPtr intPtr = CFBundleGetBundleWithIdentifier(cFString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFBundle(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetMainBundle();

	public static CFBundle GetMain()
	{
		IntPtr intPtr = CFBundleGetMainBundle();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFBundle(CFBundleGetMainBundle(), owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFBundleIsExecutableLoaded(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFBundlePreflightExecutable(IntPtr bundle, out IntPtr error);

	public bool PreflightExecutable(out NSError error)
	{
		IntPtr error2 = IntPtr.Zero;
		bool result = CFBundlePreflightExecutable(handle, out error2);
		error = Runtime.GetNSObject<NSError>(error2);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFBundleLoadExecutableAndReturnError(IntPtr bundle, out IntPtr error);

	public bool LoadExecutable(out NSError error)
	{
		IntPtr error2 = IntPtr.Zero;
		bool result = CFBundleLoadExecutableAndReturnError(handle, out error2);
		error = Runtime.GetNSObject<NSError>(error2);
		return result;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFBundleUnloadExecutable(IntPtr bundle);

	public void UnloadExecutable()
	{
		CFBundleUnloadExecutable(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyAuxiliaryExecutableURL(IntPtr bundle, IntPtr executableName);

	public NSUrl GetAuxiliaryExecutableUrl(string executableName)
	{
		if (string.IsNullOrEmpty(executableName))
		{
			throw new ArgumentException("executableName");
		}
		using CFString cFString = new CFString(executableName);
		IntPtr intPtr = CFBundleCopyAuxiliaryExecutableURL(handle, cFString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetNSObject<NSUrl>(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyBuiltInPlugInsURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyExecutableURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyPrivateFrameworksURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourcesDirectoryURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopySharedFrameworksURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopySharedSupportURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopySupportFilesDirectoryURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURL(IntPtr bundle, IntPtr resourceName, IntPtr resourceType, IntPtr subDirName);

	public NSUrl GetResourceUrl(string resourceName, string resourceType, string subDirName)
	{
		if (string.IsNullOrEmpty(resourceName))
		{
			throw new ArgumentException("resourceName");
		}
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceType");
		}
		using CFString cFString = new CFString(resourceName);
		using CFString cFString2 = new CFString(resourceType);
		using CFString cFString3 = ((subDirName == null) ? new CFString("") : new CFString(subDirName));
		IntPtr ptr = CFBundleCopyResourceURL(handle, cFString.Handle, cFString2.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString3.Handle);
		return Runtime.GetNSObject<NSUrl>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURLInDirectory(IntPtr bundleURL, IntPtr resourceName, IntPtr resourceType, IntPtr subDirName);

	public static NSUrl GetResourceUrl(NSUrl bundleUrl, string resourceName, string resourceType, string subDirName)
	{
		if (bundleUrl == null)
		{
			throw new ArgumentNullException("bundleUrl");
		}
		if (string.IsNullOrEmpty(resourceName))
		{
			throw new ArgumentException("resourceName");
		}
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceType");
		}
		using CFString cFString = new CFString(resourceName);
		using CFString cFString2 = new CFString(resourceType);
		using CFString cFString3 = new CFString(subDirName ?? string.Empty);
		IntPtr ptr = CFBundleCopyResourceURLInDirectory(bundleUrl.Handle, cFString.Handle, cFString2.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString3.Handle);
		return Runtime.GetNSObject<NSUrl>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURLsOfType(IntPtr bundle, IntPtr resourceType, IntPtr subDirName);

	public NSUrl[] GetResourceUrls(string resourceType, string subDirName)
	{
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceName");
		}
		using CFString cFString = new CFString(resourceType);
		using CFString cFString2 = new CFString(subDirName ?? string.Empty);
		using CFArray cFArray = new CFArray(CFBundleCopyResourceURLsOfType(handle, cFString.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString2.Handle), owns: true);
		NSUrl[] array = new NSUrl[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = Runtime.GetNSObject<NSUrl>(cFArray.GetValue(i), owns: true);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURLsOfTypeInDirectory(IntPtr bundleURL, IntPtr resourceType, IntPtr subDirName);

	public static NSUrl[] GetResourceUrls(NSUrl bundleUrl, string resourceType, string subDirName)
	{
		if (bundleUrl == null)
		{
			throw new ArgumentNullException("bundleUrl");
		}
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceType");
		}
		using CFString cFString = new CFString(resourceType);
		using CFString cFString2 = new CFString(subDirName ?? string.Empty);
		using CFArray cFArray = new CFArray(CFBundleCopyResourceURLsOfTypeInDirectory(bundleUrl.Handle, cFString.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString2.Handle), owns: true);
		NSUrl[] array = new NSUrl[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = Runtime.GetNSObject<NSUrl>(cFArray.GetValue(i), owns: true);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURLForLocalization(IntPtr bundle, IntPtr resourceName, IntPtr resourceType, IntPtr subDirName, IntPtr localizationName);

	public NSUrl GetResourceUrl(string resourceName, string resourceType, string subDirName, string localizationName)
	{
		if (string.IsNullOrEmpty(resourceName))
		{
			throw new ArgumentException("resourceName");
		}
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceType");
		}
		if (string.IsNullOrEmpty(localizationName))
		{
			throw new ArgumentException("localizationName");
		}
		using CFString cFString = new CFString(resourceName);
		using CFString cFString2 = new CFString(resourceType);
		using CFString cFString3 = new CFString(subDirName ?? string.Empty);
		using CFString cFString4 = new CFString(localizationName);
		IntPtr ptr = CFBundleCopyResourceURLForLocalization(handle, cFString.Handle, cFString2.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString3.Handle, cFString4.Handle);
		return Runtime.GetNSObject<NSUrl>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyResourceURLsOfTypeForLocalization(IntPtr bundle, IntPtr resourceType, IntPtr subDirName, IntPtr localizationName);

	public NSUrl[] GetResourceUrls(string resourceType, string subDirName, string localizationName)
	{
		if (string.IsNullOrEmpty(resourceType))
		{
			throw new ArgumentException("resourceType");
		}
		if (string.IsNullOrEmpty(localizationName))
		{
			throw new ArgumentException("localizationName");
		}
		using CFString cFString = new CFString(resourceType);
		using CFString cFString2 = new CFString(subDirName ?? string.Empty);
		using CFString cFString3 = new CFString(localizationName);
		using CFArray cFArray = new CFArray(CFBundleCopyResourceURLsOfTypeForLocalization(handle, cFString.Handle, string.IsNullOrEmpty(subDirName) ? IntPtr.Zero : cFString2.Handle, cFString3.Handle), owns: true);
		NSUrl[] array = new NSUrl[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = Runtime.GetNSObject<NSUrl>(cFArray.GetValue(i), owns: true);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyLocalizedString(IntPtr bundle, IntPtr key, IntPtr value, IntPtr tableName);

	public string GetLocalizedString(string key, string defaultValue, string tableName)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentException("key");
		}
		if (string.IsNullOrEmpty(tableName))
		{
			throw new ArgumentException("tableName");
		}
		if (defaultValue == null)
		{
			defaultValue = string.Empty;
		}
		using CFString cFString = new CFString(key);
		using CFString cFString2 = new CFString(defaultValue);
		using CFString cFString3 = new CFString(tableName);
		return CFString.FetchString(CFBundleCopyLocalizedString(handle, cFString.Handle, cFString2.Handle, cFString3.Handle), releaseHandle: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyLocalizationsForPreferences(IntPtr locArray, IntPtr prefArray);

	public static string[] GetLocalizationsForPreferences(string[] locArray, string[] prefArray)
	{
		if (locArray == null)
		{
			throw new ArgumentNullException("locArray");
		}
		if (prefArray == null)
		{
			throw new ArgumentNullException("prefArray");
		}
		CFString[] array = new CFString[locArray.Length];
		for (int i = 0; i < locArray.Length; i++)
		{
			array[i] = new CFString(locArray[i]);
		}
		CFString[] array2 = new CFString[prefArray.Length];
		for (int j = 0; j < prefArray.Length; j++)
		{
			array2[j] = new CFString(prefArray[j]);
		}
		INativeObject[] values = array;
		using CFArray cFArray = CFArray.FromNativeObjects(values);
		values = array2;
		using CFArray cFArray2 = CFArray.FromNativeObjects(values);
		using CFArray cFArray3 = new CFArray(CFBundleCopyLocalizationsForPreferences(cFArray.Handle, cFArray2.Handle), owns: true);
		string[] array3 = new string[(long)cFArray3.Count];
		for (int k = 0; k < cFArray3.Count; k++)
		{
			array3[k] = CFString.FetchString(cFArray3.GetValue(k));
		}
		return array3;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyLocalizationsForURL(IntPtr url);

	public static string[] GetLocalizations(NSUrl bundle)
	{
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		using CFArray cFArray = new CFArray(CFBundleCopyLocalizationsForURL(bundle.Handle), owns: true);
		string[] array = new string[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = CFString.FetchString(cFArray.GetValue(i));
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyPreferredLocalizationsFromArray(IntPtr locArray);

	public static string[] GetPreferredLocalizations(string[] locArray)
	{
		if (locArray == null)
		{
			throw new ArgumentNullException("locArray");
		}
		CFString[] array = new CFString[locArray.Length];
		for (int i = 0; i < locArray.Length; i++)
		{
			array[i] = new CFString(locArray[i]);
		}
		INativeObject[] values = array;
		using CFArray cFArray = CFArray.FromNativeObjects(values);
		using CFArray cFArray2 = new CFArray(CFBundleCopyPreferredLocalizationsFromArray(cFArray.Handle), owns: true);
		string[] array2 = new string[(long)cFArray2.Count];
		for (int j = 0; j < cFArray2.Count; j++)
		{
			array2[j] = CFString.FetchString(cFArray2.GetValue(j));
		}
		return array2;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyBundleURL(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetDevelopmentRegion(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetIdentifier(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetInfoDictionary(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleGetLocalInfoDictionary(IntPtr bundle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyInfoDictionaryForURL(IntPtr url);

	public static NSDictionary GetInfoDictionary(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSDictionary>(CFBundleCopyInfoDictionaryForURL(url.Handle));
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFBundleGetPackageInfo(IntPtr bundle, out uint packageType, out uint packageCreator);

	private static string FourCCToString(uint code)
	{
		return new string(new char[4]
		{
			(char)(byte)(code >> 24),
			(char)(byte)(code >> 16),
			(char)(byte)(code >> 8),
			(char)(byte)code
		});
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFBundleCopyExecutableArchitectures(IntPtr bundle);
}
