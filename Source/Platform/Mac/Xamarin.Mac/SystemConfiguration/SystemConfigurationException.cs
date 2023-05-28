using System;

namespace SystemConfiguration;

public class SystemConfigurationException : Exception
{
	public StatusCode StatusErrorCode { get; private set; }

	public SystemConfigurationException(StatusCode statusErrorCode)
		: base(StatusCodeError.GetErrorDescription(statusErrorCode))
	{
		StatusErrorCode = statusErrorCode;
	}

	internal static SystemConfigurationException FromMostRecentCall()
	{
		StatusCode statusErrorCode = StatusCodeError.SCError();
		return new SystemConfigurationException(statusErrorCode);
	}
}
