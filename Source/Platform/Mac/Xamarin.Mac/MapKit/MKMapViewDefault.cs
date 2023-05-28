using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class MKMapViewDefault
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnnotationViewReuseIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ClusterAnnotationViewReuseIdentifier;

	[Field("MKMapViewDefaultAnnotationViewReuseIdentifier", "MapKit")]
	public static NSString AnnotationViewReuseIdentifier
	{
		get
		{
			if (_AnnotationViewReuseIdentifier == null)
			{
				_AnnotationViewReuseIdentifier = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKMapViewDefaultAnnotationViewReuseIdentifier");
			}
			return _AnnotationViewReuseIdentifier;
		}
	}

	[Field("MKMapViewDefaultClusterAnnotationViewReuseIdentifier", "MapKit")]
	public static NSString ClusterAnnotationViewReuseIdentifier
	{
		get
		{
			if (_ClusterAnnotationViewReuseIdentifier == null)
			{
				_ClusterAnnotationViewReuseIdentifier = Dlfcn.GetStringConstant(Libraries.MapKit.Handle, "MKMapViewDefaultClusterAnnotationViewReuseIdentifier");
			}
			return _ClusterAnnotationViewReuseIdentifier;
		}
	}
}
