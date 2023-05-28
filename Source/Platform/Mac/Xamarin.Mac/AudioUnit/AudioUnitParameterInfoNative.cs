using System;

namespace AudioUnit;

internal struct AudioUnitParameterInfoNative
{
	private unsafe fixed byte name[52];

	public IntPtr UnitName;

	public AudioUnitClumpID ClumpID;

	public IntPtr NameString;

	public AudioUnitParameterUnit Unit;

	public float MinValue;

	public float MaxValue;

	public float DefaultValue;

	public AudioUnitParameterFlag Flags;
}
