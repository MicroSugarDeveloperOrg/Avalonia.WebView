using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public enum SecKeyAlgorithm
{
	RsaSignatureRaw,
	RsaSignatureDigestPkcs1v15Raw,
	RsaSignatureDigestPkcs1v15Sha1,
	RsaSignatureDigestPkcs1v15Sha224,
	RsaSignatureDigestPkcs1v15Sha256,
	RsaSignatureDigestPkcs1v15Sha384,
	RsaSignatureDigestPkcs1v15Sha512,
	RsaSignatureMessagePkcs1v15Sha1,
	RsaSignatureMessagePkcs1v15Sha224,
	RsaSignatureMessagePkcs1v15Sha256,
	RsaSignatureMessagePkcs1v15Sha384,
	RsaSignatureMessagePkcs1v15Sha512,
	EcdsaSignatureRfc4754,
	EcdsaSignatureDigestX962,
	EcdsaSignatureDigestX962Sha1,
	EcdsaSignatureDigestX962Sha224,
	EcdsaSignatureDigestX962Sha256,
	EcdsaSignatureDigestX962Sha384,
	EcdsaSignatureDigestX962Sha512,
	EcdsaSignatureMessageX962Sha1,
	EcdsaSignatureMessageX962Sha224,
	EcdsaSignatureMessageX962Sha256,
	EcdsaSignatureMessageX962Sha384,
	EcdsaSignatureMessageX962Sha512,
	RsaEncryptionRaw,
	RsaEncryptionPkcs1,
	RsaEncryptionOaepSha1,
	RsaEncryptionOaepSha224,
	RsaEncryptionOaepSha256,
	RsaEncryptionOaepSha384,
	RsaEncryptionOaepSha512,
	RsaEncryptionOaepSha1AesCgm,
	RsaEncryptionOaepSha224AesGcm,
	RsaEncryptionOaepSha256AesGcm,
	RsaEncryptionOaepSha384AesGcm,
	RsaEncryptionOaepSha512AesGcm,
	EciesEncryptionStandardX963Sha1AesGcm,
	EciesEncryptionStandardX963Sha224AesGcm,
	EciesEncryptionStandardX963Sha256AesGcm,
	EciesEncryptionStandardX963Sha384AesGcm,
	EciesEncryptionStandardX963Sha512AesGcm,
	EciesEncryptionCofactorX963Sha1AesGcm,
	EciesEncryptionCofactorX963Sha224AesGcm,
	EciesEncryptionCofactorX963Sha256AesGcm,
	EciesEncryptionCofactorX963Sha384AesGcm,
	EciesEncryptionCofactorX963Sha512AesGcm,
	EcdhKeyExchangeStandard,
	EcdhKeyExchangeStandardX963Sha1,
	EcdhKeyExchangeStandardX963Sha224,
	EcdhKeyExchangeStandardX963Sha256,
	EcdhKeyExchangeStandardX963Sha384,
	EcdhKeyExchangeStandardX963Sha512,
	EcdhKeyExchangeCofactor,
	EcdhKeyExchangeCofactorX963Sha1,
	EcdhKeyExchangeCofactorX963Sha224,
	EcdhKeyExchangeCofactorX963Sha256,
	EcdhKeyExchangeCofactorX963Sha384,
	EcdhKeyExchangeCofactorX963Sha512,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureDigestPssSha1,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureDigestPssSha224,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureDigestPssSha256,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureDigestPssSha384,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureDigestPssSha512,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureMessagePssSha1,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureMessagePssSha224,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureMessagePssSha256,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureMessagePssSha384,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	RsaSignatureMessagePssSha512,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionStandardVariableIvx963Sha224AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionStandardVariableIvx963Sha256AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionStandardVariableIvx963Sha384AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionStandardVariableIvx963Sha512AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionCofactorVariableIvx963Sha224AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionCofactorVariableIvx963Sha256AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionCofactorVariableIvx963Sha384AesGcm,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	EciesEncryptionCofactorVariableIvx963Sha512AesGcm
}
