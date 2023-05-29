using System.Runtime.InteropServices;
using Foundation;

namespace AudioToolbox;

[StructLayout(LayoutKind.Explicit)]
public struct AudioQueueParameterEvent
{
	[FieldOffset(0)]
	[Advice("Use Parameter")]
	public uint ID;

	[FieldOffset(0)]
	public AudioQueueParameter Parameter;

	[FieldOffset(4)]
	public float Value;

	public AudioQueueParameterEvent(AudioQueueParameter parameter, float value)
	{
		ID = (uint)parameter;
		Parameter = parameter;
		Value = value;
	}
}
