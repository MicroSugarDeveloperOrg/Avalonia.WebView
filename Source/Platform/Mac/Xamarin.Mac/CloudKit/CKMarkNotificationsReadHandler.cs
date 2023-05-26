using Foundation;

namespace CloudKit;

public delegate void CKMarkNotificationsReadHandler(CKNotificationID[] notificationIDsMarkedRead, NSError operationError);
