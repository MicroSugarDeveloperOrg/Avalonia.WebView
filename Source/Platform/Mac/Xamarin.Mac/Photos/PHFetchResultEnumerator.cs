using System;
using Foundation;

namespace Photos;

public delegate void PHFetchResultEnumerator(NSObject element, nuint elementIndex, out bool stop);
