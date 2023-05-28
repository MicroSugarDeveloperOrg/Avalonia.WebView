using System;
using Foundation;

namespace Security;

public class SecKeyGenerationParameters : DictionaryContainer
{
	private SecAccessControl _secAccessControl;

	public SecKeyType KeyType
	{
		get
		{
			NSString nSStringValue = GetNSStringValue(SecKeyGenerationAttributeKeys.KeyTypeKey);
			if (nSStringValue == null)
			{
				return SecKeyType.Invalid;
			}
			return SecKeyTypeExtensions.GetValue(nSStringValue);
		}
		set
		{
			NSString constant = value.GetConstant();
			if (constant == null)
			{
				throw new ArgumentException("Unknown value for KeyType.");
			}
			SetStringValue(SecKeyGenerationAttributeKeys.KeyTypeKey, constant);
		}
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public SecAccessControl AccessControl
	{
		get
		{
			return _secAccessControl;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_secAccessControl = value;
			SetNativeValue(SecAttributeKeys.AccessControlKey, value);
		}
	}

	[iOS(9, 0)]
	[Mac(10, 12)]
	public SecTokenID TokenID
	{
		get
		{
			return SecTokenIDExtensions.GetValue(GetNSStringValue(SecKeyGenerationAttributeKeys.TokenIDKey));
		}
		set
		{
			SetStringValue(SecKeyGenerationAttributeKeys.TokenIDKey, value.GetConstant());
		}
	}

	public int? KeySizeInBits
	{
		get
		{
			return GetInt32Value(SecKeyGenerationAttributeKeys.KeySizeInBitsKey);
		}
		set
		{
			SetNumberValue(SecKeyGenerationAttributeKeys.KeySizeInBitsKey, value);
		}
	}

	public SecKeyParameters? PrivateKeyAttrs
	{
		get
		{
			return GetStrongDictionary<SecKeyParameters>(SecKeyGenerationAttributeKeys.PrivateKeyAttrsKey);
		}
		set
		{
			SetNativeValue(SecKeyGenerationAttributeKeys.PrivateKeyAttrsKey, value.GetDictionary());
		}
	}

	public SecKeyParameters? PublicKeyAttrs
	{
		get
		{
			return GetStrongDictionary<SecKeyParameters>(SecKeyGenerationAttributeKeys.PublicKeyAttrsKey);
		}
		set
		{
			SetNativeValue(SecKeyGenerationAttributeKeys.PublicKeyAttrsKey, value.GetDictionary());
		}
	}

	public string? Label
	{
		get
		{
			return GetStringValue(SecKeyGenerationAttributeKeys.LabelKey);
		}
		set
		{
			SetStringValue(SecKeyGenerationAttributeKeys.LabelKey, value);
		}
	}

	public bool? IsPermanent
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.IsPermanentKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.IsPermanentKey, value);
		}
	}

	public NSData? ApplicationTag
	{
		get
		{
			return base.Dictionary[SecKeyGenerationAttributeKeys.ApplicationTagKey] as NSData;
		}
		set
		{
			SetNativeValue(SecKeyGenerationAttributeKeys.ApplicationTagKey, value);
		}
	}

	public int? EffectiveKeySize
	{
		get
		{
			return GetInt32Value(SecKeyGenerationAttributeKeys.EffectiveKeySizeKey);
		}
		set
		{
			SetNumberValue(SecKeyGenerationAttributeKeys.EffectiveKeySizeKey, value);
		}
	}

	public bool? CanEncrypt
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanEncryptKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanEncryptKey, value);
		}
	}

	public bool? CanDecrypt
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanDecryptKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanDecryptKey, value);
		}
	}

	public bool? CanDerive
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanDeriveKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanDeriveKey, value);
		}
	}

	public bool? CanSign
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanSignKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanSignKey, value);
		}
	}

	public bool? CanVerify
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanVerifyKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanVerifyKey, value);
		}
	}

	public bool? CanWrap
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanWrapKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanWrapKey, value);
		}
	}

	public bool? CanUnwrap
	{
		get
		{
			return GetBoolValue(SecKeyGenerationAttributeKeys.CanUnwrapKey);
		}
		set
		{
			SetBooleanValue(SecKeyGenerationAttributeKeys.CanUnwrapKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SecKeyGenerationParameters()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SecKeyGenerationParameters(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
