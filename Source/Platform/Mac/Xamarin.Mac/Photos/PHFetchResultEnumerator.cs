using Foundation;
using Xamarin.Mac.System.Mac;

namespace Photos;

public delegate void PHFetchResultEnumerator(NSObject element, nuint elementIndex, out bool stop);
