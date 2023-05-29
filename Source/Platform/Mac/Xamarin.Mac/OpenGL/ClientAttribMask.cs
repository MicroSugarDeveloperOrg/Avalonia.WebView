using System;

namespace OpenGL;

[Flags]
public enum ClientAttribMask
{
	ClientPixelStoreBit = 1,
	ClientVertexArrayBit = 2,
	ClientAllAttribBits = -1
}
