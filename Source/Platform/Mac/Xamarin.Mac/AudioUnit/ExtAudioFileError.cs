namespace AudioUnit;

public enum ExtAudioFileError
{
	OK = 0,
	CodecUnavailableInputConsumed = -66559,
	CodecUnavailableInputNotConsumed = -66560,
	InvalidProperty = -66561,
	InvalidPropertySize = -66562,
	NonPCMClientFormat = -66563,
	InvalidChannelMap = -66564,
	InvalidOperationOrder = -66565,
	InvalidDataFormat = -66566,
	MaxPacketSizeUnknown = -66567,
	InvalidSeek = -66568,
	AsyncWriteTooLarge = -66569,
	AsyncWriteBufferOverflow = -66570,
	NotOpenError = -38,
	EndOfFileError = -39,
	PositionError = -40,
	FileNotFoundError = -43
}
