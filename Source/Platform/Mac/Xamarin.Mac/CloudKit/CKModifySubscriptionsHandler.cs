using Foundation;

namespace CloudKit;

public delegate void CKModifySubscriptionsHandler(CKSubscription[] savedSubscriptions, string[] deletedSubscriptionIds, NSError operationError);
