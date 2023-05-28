namespace Security;

public enum SecAuthenticationType
{
	Invalid = -1,
	Ntlm,
	Msn,
	Dpa,
	Rpa,
	HttpBasic,
	HttpDigest,
	HtmlForm,
	Default
}
