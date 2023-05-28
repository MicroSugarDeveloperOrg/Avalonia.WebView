using System;
using CoreFoundation;

namespace AudioUnit;

public class SamplerInstrumentData
{
	public const byte DefaultPercussionBankMSB = 120;

	public const byte DefaultMelodicBankMSB = 121;

	public const byte DefaultBankLSB = 0;

	public CFUrl FileUrl { get; private set; }

	public InstrumentType InstrumentType { get; private set; }

	public byte BankMSB { get; set; }

	public byte BankLSB { get; set; }

	public byte PresetID { get; set; }

	public SamplerInstrumentData(CFUrl fileUrl, InstrumentType instrumentType)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		FileUrl = fileUrl;
		InstrumentType = instrumentType;
	}

	internal AUSamplerInstrumentData ToStruct()
	{
		AUSamplerInstrumentData result = default(AUSamplerInstrumentData);
		result.FileUrl = FileUrl.Handle;
		result.InstrumentType = InstrumentType;
		result.BankMSB = BankMSB;
		result.BankLSB = BankLSB;
		result.PresetID = PresetID;
		return result;
	}
}
