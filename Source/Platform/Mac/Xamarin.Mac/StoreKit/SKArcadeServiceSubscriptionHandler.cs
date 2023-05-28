using Foundation;

namespace StoreKit;

public delegate void SKArcadeServiceSubscriptionHandler(NSData subscriptionStatus, uint subscriptionStatusLength, NSData cmacOfNonce, uint cmacOfNonceLength, NSError error);
