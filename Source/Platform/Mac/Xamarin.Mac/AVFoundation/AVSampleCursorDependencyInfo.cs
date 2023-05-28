using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AVFoundation;

[Mac(10, 10)]
[NoiOS]
[NoWatch]
[NoTV]
public struct AVSampleCursorDependencyInfo
{
	[MarshalAs(UnmanagedType.I1)]
	public bool IndicatesWhetherItHasDependentSamples;

	[MarshalAs(UnmanagedType.I1)]
	public bool HasDependentSamples;

	[MarshalAs(UnmanagedType.I1)]
	public bool IndicatesWhetherItDependsOnOthers;

	[MarshalAs(UnmanagedType.I1)]
	public bool DependsOnOthers;

	[MarshalAs(UnmanagedType.I1)]
	public bool IndicatesWhetherItHasRedundantCoding;

	[MarshalAs(UnmanagedType.I1)]
	public bool HasRedundantCoding;
}
