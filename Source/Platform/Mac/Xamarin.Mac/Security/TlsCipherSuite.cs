using ObjCRuntime;

namespace Security;

[Watch(6, 0)]
[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
public enum TlsCipherSuite : ushort
{
	RsaWith3desEdeCbcSha = 10,
	RsaWithAes128CbcSha = 47,
	RsaWithAes256CbcSha = 53,
	RsaWithAes128GcmSha256 = 156,
	RsaWithAes256GcmSha384 = 157,
	RsaWithAes128CbcSha256 = 60,
	RsaWithAes256CbcSha256 = 61,
	EcdheEcdsaWith3desEdeCbcSha = 49160,
	EcdheEcdsaWithAes128CbcSha = 49161,
	EcdheEcdsaWithAes256CbcSha = 49162,
	EcdheRsaWith3desEdeCbcSha = 49170,
	EcdheRsaWithAes128CbcSha = 49171,
	EcdheRsaWithAes256CbcSha = 49172,
	EcdheEcdsaWithAes128CbcSha256 = 49187,
	EcdheEcdsaWithAes256CbcSha384 = 49188,
	EcdheRsaWithAes128CbcSha256 = 49191,
	EcdheRsaWithAes256CbcSha384 = 49192,
	EcdheEcdsaWithAes128GcmSha256 = 49195,
	EcdheEcdsaWithAes256GcmSha384 = 49196,
	EcdheRsaWithAes128GcmSha256 = 49199,
	EcdheRsaWithAes256GcmSha384 = 49200,
	EcdheRsaWithChacha20Poly1305Sha256 = 52392,
	EcdheEcdsaWithChacha20Poly1305Sha256 = 52393,
	Aes128GcmSha256 = 4865,
	Aes256GcmSha384 = 4866,
	Chacha20Poly1305Sha256 = 4867
}
