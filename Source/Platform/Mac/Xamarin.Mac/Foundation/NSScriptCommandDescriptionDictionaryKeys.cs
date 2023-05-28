namespace Foundation;

public static class NSScriptCommandDescriptionDictionaryKeys
{
	private static NSString cmdClass = new NSString("CommandClass");

	private static NSString codeClass = new NSString("AppleEventClassCode");

	private static NSString resultAppEventCode = new NSString("ResultAppleEventCode");

	private static NSString args = new NSString("Arguments");

	public static NSString CommandClassKey => cmdClass;

	public static NSString AppleEventCodeKey => NSScriptCommonKeys.AppleEventCodeKey;

	public static NSString AppleEventClassCodeKey => codeClass;

	public static NSString TypeKey => NSScriptCommonKeys.TypeKey;

	public static NSString ResultAppleEventCodeKey => resultAppEventCode;

	public static NSString ArgumentsKey => args;
}
