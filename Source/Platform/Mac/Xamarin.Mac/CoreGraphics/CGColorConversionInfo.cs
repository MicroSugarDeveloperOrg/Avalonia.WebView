using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

[iOS(10, 0)]
[TV(10, 0)]
[Watch(3, 0)]
[Mac(10, 12)]
public class CGColorConversionInfo : INativeObject, IDisposable
{
	private static GColorConversionInfoTriple empty = default(GColorConversionInfoTriple);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BlackPointCompensationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TrcSizeKey;

	public IntPtr Handle { get; private set; }

	[Field("kCGColorConversionBlackPointCompensation", "CoreGraphics")]
	internal static NSString BlackPointCompensationKey
	{
		get
		{
			if (_BlackPointCompensationKey == null)
			{
				_BlackPointCompensationKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorConversionBlackPointCompensation");
			}
			return _BlackPointCompensationKey;
		}
	}

	[Field("kCGColorConversionTRCSize", "CoreGraphics")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	internal static NSString TrcSizeKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TrcSizeKey == null)
			{
				_TrcSizeKey = Dlfcn.GetStringConstant(Libraries.CoreGraphics.Handle, "kCGColorConversionTRCSize");
			}
			return _TrcSizeKey;
		}
	}

	internal CGColorConversionInfo(IntPtr handle)
	{
		Handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGColorConversionInfo(IntPtr handle, bool owns)
	{
		Handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(Handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGColorConversionInfoCreateFromList(IntPtr options, IntPtr space1, CGColorConversionInfoTransformType transform1, CGColorRenderingIntent intent1, IntPtr space2, CGColorConversionInfoTransformType transform2, CGColorRenderingIntent intent2, IntPtr space3, CGColorConversionInfoTransformType transform3, CGColorRenderingIntent intent3, IntPtr lastSpaceMarker);

	public CGColorConversionInfo(CGColorConversionOptions options, params GColorConversionInfoTriple[] triples)
		: this(options?.Dictionary, triples)
	{
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public CGColorConversionInfo(NSDictionary options, params GColorConversionInfoTriple[] triples)
	{
		if (triples == null || triples.Length == 0)
		{
			throw new ArgumentNullException("triples");
		}
		if (triples.Length > 3)
		{
			throw new ArgumentException("A maximum of 3 triples are supported");
		}
		IntPtr handle = options.GetHandle();
		GColorConversionInfoTriple gColorConversionInfoTriple = triples[0];
		GColorConversionInfoTriple gColorConversionInfoTriple2 = ((triples.Length > 1) ? triples[1] : empty);
		GColorConversionInfoTriple gColorConversionInfoTriple3 = ((triples.Length > 2) ? triples[2] : empty);
		Handle = CGColorConversionInfoCreateFromList(handle, gColorConversionInfoTriple.Space.GetHandle(), gColorConversionInfoTriple.Transform, gColorConversionInfoTriple.Intent, gColorConversionInfoTriple2.Space.GetHandle(), gColorConversionInfoTriple2.Transform, gColorConversionInfoTriple2.Intent, gColorConversionInfoTriple3.Space.GetHandle(), gColorConversionInfoTriple3.Transform, gColorConversionInfoTriple3.Intent, IntPtr.Zero);
		if (Handle == IntPtr.Zero)
		{
			throw new Exception("Failed to create CGColorConverter");
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	private static extern IntPtr CGColorConversionInfoCreate(IntPtr src, IntPtr dst);

	[iOS(10, 0)]
	[Mac(10, 12)]
	public CGColorConversionInfo(CGColorSpace source, CGColorSpace destination)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		Handle = CGColorConversionInfoCreate(source.Handle, destination.Handle);
		if (Handle == IntPtr.Zero)
		{
			throw new Exception("Failed to create CGColorConversionInfo");
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[Mac(10, 14, 6)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr CGColorConversionInfoCreateWithOptions(IntPtr src, IntPtr dst, IntPtr options);

	[Mac(10, 14, 6)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public CGColorConversionInfo(CGColorSpace source, CGColorSpace destination, NSDictionary options)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		Handle = CGColorConversionInfoCreateWithOptions(source.Handle, destination.Handle, options.GetHandle());
		if (Handle == IntPtr.Zero)
		{
			throw new Exception("Failed to create CGColorConversionInfo");
		}
	}

	[Mac(10, 15)]
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	public CGColorConversionInfo(CGColorSpace source, CGColorSpace destination, CGColorConversionOptions options)
		: this(source, destination, options?.Dictionary)
	{
	}

	~CGColorConversionInfo()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (Handle != IntPtr.Zero)
		{
			CFObject.CFRelease(Handle);
			Handle = IntPtr.Zero;
		}
	}
}
