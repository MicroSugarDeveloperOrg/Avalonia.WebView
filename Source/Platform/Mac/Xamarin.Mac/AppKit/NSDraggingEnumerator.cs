using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate void NSDraggingEnumerator(NSDraggingItem draggingItem, nint idx, ref bool stop);
