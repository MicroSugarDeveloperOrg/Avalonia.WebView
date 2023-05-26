using System;
using System.Runtime.InteropServices;
using ModelIO;
using ObjCRuntime;

namespace GLKit;

[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
[iOS(9, 0)]
[Mac(10, 11)]
public struct GLKVertexAttributeParameters
{
	public uint Type;

	public uint Size;

	public bool Normalized;

	[DllImport("/System/Library/Frameworks/GLKit.framework/GLKit", EntryPoint = "GLKVertexAttributeParametersFromModelIO")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern GLKVertexAttributeParameters FromVertexFormat_(nuint vertexFormat);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public static GLKVertexAttributeParameters FromVertexFormat(MDLVertexFormat vertexFormat)
	{
		return FromVertexFormat_((nuint)(ulong)vertexFormat);
	}
}
