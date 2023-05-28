namespace Foundation;

public class NSObservedChange
{
	private NSDictionary dict;

	public NSKeyValueChange Change
	{
		get
		{
			NSNumber nSNumber = (NSNumber)dict[NSObject.ChangeKindKey];
			return (NSKeyValueChange)nSNumber.Int32Value;
		}
	}

	public NSObject NewValue => dict[NSObject.ChangeNewKey];

	public NSObject OldValue => dict[NSObject.ChangeOldKey];

	public NSIndexSet Indexes => (NSIndexSet)dict[NSObject.ChangeIndexesKey];

	public bool IsPrior
	{
		get
		{
			if (!(dict[NSObject.ChangeNotificationIsPriorKey] is NSNumber nSNumber))
			{
				return false;
			}
			return nSNumber.BoolValue;
		}
	}

	public NSObservedChange(NSDictionary source)
	{
		dict = source;
	}
}
