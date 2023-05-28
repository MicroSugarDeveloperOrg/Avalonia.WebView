using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public enum MTLCommonCounter
{
	Timestamp,
	TessellationInputPatches,
	VertexInvocations,
	PostTessellationVertexInvocations,
	ClipperInvocations,
	ClipperPrimitivesOut,
	FragmentInvocations,
	FragmentsPassed,
	ComputeKernelInvocations,
	TotalCycles,
	VertexCycles,
	TessellationCycles,
	PostTessellationVertexCycles,
	FragmentCycles,
	RenderTargetWriteCycles,
	SetTimestamp,
	SetStageUtilization,
	SetStatistic
}
