using System;

namespace AudioUnit;

internal struct AUSamplerInstrumentData
{
	public IntPtr FileUrl;

	public InstrumentType InstrumentType;

	public byte BankMSB;

	public byte BankLSB;

	public byte PresetID;
}
