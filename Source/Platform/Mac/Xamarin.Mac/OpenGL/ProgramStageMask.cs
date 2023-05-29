using System;

namespace OpenGL;

[Flags]
public enum ProgramStageMask
{
	VertexShaderBit = 1,
	FragmentShaderBit = 2,
	GeometryShaderBit = 4,
	TessControlShaderBit = 8,
	TessEvaluationShaderBit = 0x10,
	AllShaderBits = -1
}
