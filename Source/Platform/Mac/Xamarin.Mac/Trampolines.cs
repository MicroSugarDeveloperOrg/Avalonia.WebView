using System;
using System.Runtime.InteropServices;
using AppKit;
using AVFoundation;
using CoreMedia;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;
using WebKit;

internal static class Trampolines
{
    internal delegate void DActionArity1V0(IntPtr block, IntPtr obj);

    internal static class SDActionArity1V0
    {
        internal static readonly DActionArity1V0 Handler = TActionArity1V0;

        [MonoPInvokeCallback(typeof(DActionArity1V0))]
        private unsafe static void TActionArity1V0(IntPtr block, IntPtr obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<NSAnimationContext>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSAnimationContext)Runtime.GetNSObject(obj));
        }
    }

    internal delegate void DNSAction(IntPtr block);

    internal static class SDNSAction
    {
        internal static readonly DNSAction Handler = TNSAction;

        [MonoPInvokeCallback(typeof(DNSAction))]
        private unsafe static void TNSAction(IntPtr block)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSAction)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke();
        }
    }

    internal delegate void DNSWindowCompletionHandler(IntPtr block, IntPtr window, IntPtr error);

    internal static class SDNSWindowCompletionHandler
    {
        internal static readonly DNSWindowCompletionHandler Handler = TNSWindowCompletionHandler;

        [MonoPInvokeCallback(typeof(DNSWindowCompletionHandler))]
        private unsafe static void TNSWindowCompletionHandler(IntPtr block, IntPtr window, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSWindowCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSWindow)Runtime.GetNSObject(window), (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate void DNSDocumentCompletionHandler(IntPtr block, IntPtr nsErrorPointerOrZero);

    internal static class SDNSDocumentCompletionHandler
    {
        internal static readonly DNSDocumentCompletionHandler Handler = TNSDocumentCompletionHandler;

        [MonoPInvokeCallback(typeof(DNSDocumentCompletionHandler))]
        private unsafe static void TNSDocumentCompletionHandler(IntPtr block, IntPtr nsErrorPointerOrZero)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSDocumentCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(nsErrorPointerOrZero);
        }
    }

    internal delegate void DOpenDocumentCompletionHandler(IntPtr block, IntPtr document, bool documentWasAlreadyOpen, IntPtr error);

    internal static class SDOpenDocumentCompletionHandler
    {
        internal static readonly DOpenDocumentCompletionHandler Handler = TOpenDocumentCompletionHandler;

        [MonoPInvokeCallback(typeof(DOpenDocumentCompletionHandler))]
        private unsafe static void TOpenDocumentCompletionHandler(IntPtr block, IntPtr document, bool documentWasAlreadyOpen, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((OpenDocumentCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSDocument)Runtime.GetNSObject(document), documentWasAlreadyOpen, (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate IntPtr DNSDraggingItemImagesContentProvider(IntPtr block);

    internal static class SDNSDraggingItemImagesContentProvider
    {
        internal static readonly DNSDraggingItemImagesContentProvider Handler = TNSDraggingItemImagesContentProvider;

        [MonoPInvokeCallback(typeof(DNSDraggingItemImagesContentProvider))]
        private unsafe static IntPtr TNSDraggingItemImagesContentProvider(IntPtr block)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            return NSArray.FromNSObjects(((NSDraggingItemImagesContentProvider)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))()).Handle;
        }
    }

    internal delegate void DNSDraggingEnumerator(IntPtr block, IntPtr draggingItem, int idx, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSDraggingEnumerator
    {
        internal static readonly DNSDraggingEnumerator Handler = TNSDraggingEnumerator;

        [MonoPInvokeCallback(typeof(DNSDraggingEnumerator))]
        private unsafe static void TNSDraggingEnumerator(IntPtr block, IntPtr draggingItem, int idx, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSDraggingEnumerator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSDraggingItem)Runtime.GetNSObject(draggingItem), idx, ref stop);
        }
    }

    internal delegate void DGlobalEventHandler(IntPtr block, IntPtr theEvent);

    internal static class SDGlobalEventHandler
    {
        internal static readonly DGlobalEventHandler Handler = TGlobalEventHandler;

        [MonoPInvokeCallback(typeof(DGlobalEventHandler))]
        private unsafe static void TGlobalEventHandler(IntPtr block, IntPtr theEvent)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((GlobalEventHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSEvent)Runtime.GetNSObject(theEvent));
        }
    }

    internal delegate IntPtr DLocalEventHandler(IntPtr block, IntPtr theEvent);

    internal static class SDLocalEventHandler
    {
        internal static readonly DLocalEventHandler Handler = TLocalEventHandler;

        [MonoPInvokeCallback(typeof(DLocalEventHandler))]
        private unsafe static IntPtr TLocalEventHandler(IntPtr block, IntPtr theEvent)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            return ((LocalEventHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))((NSEvent)Runtime.GetNSObject(theEvent))?.Handle ?? IntPtr.Zero;
        }
    }

    internal delegate void DNSEventTrackHandler(IntPtr block, double gestureAmount, NSEventPhase eventPhase, bool isComplete, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSEventTrackHandler
    {
        internal static readonly DNSEventTrackHandler Handler = TNSEventTrackHandler;

        [MonoPInvokeCallback(typeof(DNSEventTrackHandler))]
        private unsafe static void TNSEventTrackHandler(IntPtr block, double gestureAmount, NSEventPhase eventPhase, bool isComplete, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSEventTrackHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(gestureAmount, eventPhase, isComplete, ref stop);
        }
    }

    internal delegate void DNSSavePanelComplete(IntPtr block, int result);

    internal static class SDNSSavePanelComplete
    {
        internal static readonly DNSSavePanelComplete Handler = TNSSavePanelComplete;

        [MonoPInvokeCallback(typeof(DNSSavePanelComplete))]
        private unsafe static void TNSSavePanelComplete(IntPtr block, int result)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSSavePanelComplete)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(result);
        }
    }

    internal delegate void DNSTableViewRowHandler(IntPtr block, IntPtr rowView, int row);

    internal static class SDNSTableViewRowHandler
    {
        internal static readonly DNSTableViewRowHandler Handler = TNSTableViewRowHandler;

        [MonoPInvokeCallback(typeof(DNSTableViewRowHandler))]
        private unsafe static void TNSTableViewRowHandler(IntPtr block, IntPtr rowView, int row)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSTableViewRowHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSTableRowView)Runtime.GetNSObject(rowView), row);
        }
    }

    internal delegate void DNSWorkspaceUrlHandler(IntPtr block, IntPtr newUrls, IntPtr error);

    internal static class SDNSWorkspaceUrlHandler
    {
        internal static readonly DNSWorkspaceUrlHandler Handler = TNSWorkspaceUrlHandler;

        [MonoPInvokeCallback(typeof(DNSWorkspaceUrlHandler))]
        private unsafe static void TNSWorkspaceUrlHandler(IntPtr block, IntPtr newUrls, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSWorkspaceUrlHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSDictionary)Runtime.GetNSObject(newUrls), (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate void DNSSharingServiceHandler(IntPtr block);

    internal static class SDNSSharingServiceHandler
    {
        internal static readonly DNSSharingServiceHandler Handler = TNSSharingServiceHandler;

        [MonoPInvokeCallback(typeof(DNSSharingServiceHandler))]
        private unsafe static void TNSSharingServiceHandler(IntPtr block)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSSharingServiceHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke();
        }
    }

    internal delegate void DAVAssetImageGeneratorCompletionHandler(IntPtr block, CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, IntPtr error);

    internal static class SDAVAssetImageGeneratorCompletionHandler
    {
        internal static readonly DAVAssetImageGeneratorCompletionHandler Handler = TAVAssetImageGeneratorCompletionHandler;

        [MonoPInvokeCallback(typeof(DAVAssetImageGeneratorCompletionHandler))]
        private unsafe static void TAVAssetImageGeneratorCompletionHandler(IntPtr block, CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((AVAssetImageGeneratorCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(requestedTime, imageRef, actualTime, result, (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate void DAVCompletionHandler(IntPtr block);

    internal static class SDAVCompletionHandler
    {
        internal static readonly DAVCompletionHandler Handler = TAVCompletionHandler;

        [MonoPInvokeCallback(typeof(DAVCompletionHandler))]
        private unsafe static void TAVCompletionHandler(IntPtr block)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((AVCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke();
        }
    }

    internal delegate void DAVCaptureCompletionHandler(IntPtr block, IntPtr imageDataSampleBuffer, IntPtr error);

    internal static class SDAVCaptureCompletionHandler
    {
        internal static readonly DAVCaptureCompletionHandler Handler = TAVCaptureCompletionHandler;

        [MonoPInvokeCallback(typeof(DAVCaptureCompletionHandler))]
        private unsafe static void TAVCaptureCompletionHandler(IntPtr block, IntPtr imageDataSampleBuffer, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((AVCaptureCompletionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(new CMSampleBuffer(imageDataSampleBuffer, owns: false), (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate void DAVTimeHandler(IntPtr block, CMTime time);

    internal static class SDAVTimeHandler
    {
        internal static readonly DAVTimeHandler Handler = TAVTimeHandler;

        [MonoPInvokeCallback(typeof(DAVTimeHandler))]
        private unsafe static void TAVTimeHandler(IntPtr block, CMTime time)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((AVTimeHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(time);
        }
    }

    internal delegate void DAVCompletion(IntPtr block, bool finished);

    internal static class SDAVCompletion
    {
        internal static readonly DAVCompletion Handler = TAVCompletion;

        [MonoPInvokeCallback(typeof(DAVCompletion))]
        private unsafe static void TAVCompletion(IntPtr block, bool finished)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((AVCompletion)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(finished);
        }
    }

    internal delegate long DNSComparator(IntPtr block, IntPtr obj1, IntPtr obj2);

    internal static class SDNSComparator
    {
        internal static readonly DNSComparator Handler = TNSComparator;

        [MonoPInvokeCallback(typeof(DNSComparator))]
        private unsafe static long TNSComparator(IntPtr block, IntPtr obj1, IntPtr obj2)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            return ((NSComparator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))(Runtime.GetNSObject(obj1), Runtime.GetNSObject(obj2));
        }
    }

    internal delegate void DNSAttributedRangeCallback(IntPtr block, IntPtr attrs, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSAttributedRangeCallback
    {
        internal static readonly DNSAttributedRangeCallback Handler = TNSAttributedRangeCallback;

        [MonoPInvokeCallback(typeof(DNSAttributedRangeCallback))]
        private unsafe static void TNSAttributedRangeCallback(IntPtr block, IntPtr attrs, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSAttributedRangeCallback)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSDictionary)Runtime.GetNSObject(attrs), range, ref stop);
        }
    }

    internal delegate void DNSAttributedStringCallback(IntPtr block, IntPtr value, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSAttributedStringCallback
    {
        internal static readonly DNSAttributedStringCallback Handler = TNSAttributedStringCallback;

        [MonoPInvokeCallback(typeof(DNSAttributedStringCallback))]
        private unsafe static void TNSAttributedStringCallback(IntPtr block, IntPtr value, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSAttributedStringCallback)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject(value), range, ref stop);
        }
    }

    internal delegate void DNSFileHandleUpdateHandler(IntPtr block, IntPtr handle);

    internal static class SDNSFileHandleUpdateHandler
    {
        internal static readonly DNSFileHandleUpdateHandler Handler = TNSFileHandleUpdateHandler;

        [MonoPInvokeCallback(typeof(DNSFileHandleUpdateHandler))]
        private unsafe static void TNSFileHandleUpdateHandler(IntPtr block, IntPtr handle)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSFileHandleUpdateHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSFileHandle)Runtime.GetNSObject(handle));
        }
    }

    internal delegate void DNSExpressionHandler(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context);

    internal static class SDNSExpressionHandler
    {
        internal static readonly DNSExpressionHandler Handler = TNSExpressionHandler;

        [MonoPInvokeCallback(typeof(DNSExpressionHandler))]
        private unsafe static void TNSExpressionHandler(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSExpressionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject(evaluatedObject), NSArray.ArrayFromHandle<NSExpression>(expressions), (NSMutableDictionary)Runtime.GetNSObject(context));
        }
    }

    internal delegate void DNSLingusticEnumerator(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSLingusticEnumerator
    {
        internal static readonly DNSLingusticEnumerator Handler = TNSLingusticEnumerator;

        [MonoPInvokeCallback(typeof(DNSLingusticEnumerator))]
        private unsafe static void TNSLingusticEnumerator(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSLingusticEnumerator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSString)Runtime.GetNSObject(tag), tokenRange, sentenceRange, ref stop);
        }
    }

    internal delegate void DNSSetEnumerator(IntPtr block, IntPtr obj, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSSetEnumerator
    {
        internal static readonly DNSSetEnumerator Handler = TNSSetEnumerator;

        [MonoPInvokeCallback(typeof(DNSSetEnumerator))]
        private unsafe static void TNSSetEnumerator(IntPtr block, IntPtr obj, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSSetEnumerator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject(obj), ref stop);
        }
    }

    internal delegate void DNSUrlConnectionDataResponse(IntPtr block, IntPtr response, IntPtr data, IntPtr error);

    internal static class SDNSUrlConnectionDataResponse
    {
        internal static readonly DNSUrlConnectionDataResponse Handler = TNSUrlConnectionDataResponse;

        [MonoPInvokeCallback(typeof(DNSUrlConnectionDataResponse))]
        private unsafe static void TNSUrlConnectionDataResponse(IntPtr block, IntPtr response, IntPtr data, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSUrlConnectionDataResponse)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSUrlResponse)Runtime.GetNSObject(response), (NSData)Runtime.GetNSObject(data), (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate void DNSRangeIterator(IntPtr block, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

    internal static class SDNSRangeIterator
    {
        internal static readonly DNSRangeIterator Handler = TNSRangeIterator;

        [MonoPInvokeCallback(typeof(DNSRangeIterator))]
        private unsafe static void TNSRangeIterator(IntPtr block, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSRangeIterator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(range, ref stop);
        }
    }

    internal delegate void DNSNotificationHandler(IntPtr block, IntPtr notification);

    internal static class SDNSNotificationHandler
    {
        internal static readonly DNSNotificationHandler Handler = TNSNotificationHandler;

        [MonoPInvokeCallback(typeof(DNSNotificationHandler))]
        private unsafe static void TNSNotificationHandler(IntPtr block, IntPtr notification)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSNotificationHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSNotification)Runtime.GetNSObject(notification));
        }
    }

    internal delegate void DNSFileCoordinatorWorker(IntPtr block, IntPtr newUrl);

    internal static class SDNSFileCoordinatorWorker
    {
        internal static readonly DNSFileCoordinatorWorker Handler = TNSFileCoordinatorWorker;

        [MonoPInvokeCallback(typeof(DNSFileCoordinatorWorker))]
        private unsafe static void TNSFileCoordinatorWorker(IntPtr block, IntPtr newUrl)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSFileCoordinatorWorker)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSUrl)Runtime.GetNSObject(newUrl));
        }
    }

    internal delegate void DNSFileCoordinatorWorkerRW(IntPtr block, IntPtr newReadingUrl, IntPtr newWritingUrl);

    internal static class SDNSFileCoordinatorWorkerRW
    {
        internal static readonly DNSFileCoordinatorWorkerRW Handler = TNSFileCoordinatorWorkerRW;

        [MonoPInvokeCallback(typeof(DNSFileCoordinatorWorkerRW))]
        private unsafe static void TNSFileCoordinatorWorkerRW(IntPtr block, IntPtr newReadingUrl, IntPtr newWritingUrl)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((NSFileCoordinatorWorkerRW)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSUrl)Runtime.GetNSObject(newReadingUrl), (NSUrl)Runtime.GetNSObject(newWritingUrl));
        }
    }

    internal delegate bool DNSEnumerateErrorHandler(IntPtr block, IntPtr url, IntPtr error);

    internal static class SDNSEnumerateErrorHandler
    {
        internal static readonly DNSEnumerateErrorHandler Handler = TNSEnumerateErrorHandler;

        [MonoPInvokeCallback(typeof(DNSEnumerateErrorHandler))]
        private unsafe static bool TNSEnumerateErrorHandler(IntPtr block, IntPtr url, IntPtr error)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            return ((NSEnumerateErrorHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))((NSUrl)Runtime.GetNSObject(url), (NSError)Runtime.GetNSObject(error));
        }
    }

    internal delegate bool DNSPredicateEvaluator(IntPtr block, IntPtr evaluatedObject, IntPtr bindings);

    internal static class SDNSPredicateEvaluator
    {
        internal static readonly DNSPredicateEvaluator Handler = TNSPredicateEvaluator;

        [MonoPInvokeCallback(typeof(DNSPredicateEvaluator))]
        private unsafe static bool TNSPredicateEvaluator(IntPtr block, IntPtr evaluatedObject, IntPtr bindings)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            return ((NSPredicateEvaluator)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))(Runtime.GetNSObject(evaluatedObject), (NSDictionary)Runtime.GetNSObject(bindings));
        }
    }

    #region

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action))]
    internal delegate void DAction(IntPtr block);

    internal static class SDAction
    {
        internal static readonly DAction Handler = Invoke;

        [MonoPInvokeCallback(typeof(DAction))]
        private unsafe static void Invoke(IntPtr block)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke();
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<NSHttpCookie[]>))]
    internal delegate void DActionArity1V31(IntPtr block, IntPtr obj);

    internal static class SDActionArity1V31
    {
        internal static readonly DActionArity1V31 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V31))]
        private unsafe static void Invoke(IntPtr block, IntPtr obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<NSHttpCookie[]>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(NSArray.ArrayFromHandle<NSHttpCookie>(obj));
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<NSArray>))]
    internal delegate void DActionArity1V96(IntPtr block, IntPtr obj);

    internal static class SDActionArity1V96
    {
        internal static readonly DActionArity1V96 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V96))]
        private unsafe static void Invoke(IntPtr block, IntPtr obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<NSArray>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject<NSArray>(obj));
        }
    }


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<WKNavigationActionPolicy>))]
    internal delegate void DActionArity1V93(IntPtr block, nint obj);

    internal static class SDActionArity1V93
    {
        internal static readonly DActionArity1V93 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V93))]
        private unsafe static void Invoke(IntPtr block, nint obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<WKNavigationActionPolicy>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((WKNavigationActionPolicy)(long)obj);
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<WKNavigationResponsePolicy>))]
    internal delegate void DActionArity1V94(IntPtr block, nint obj);

    internal static class SDActionArity1V94
    {
        internal static readonly DActionArity1V94 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V94))]
        private unsafe static void Invoke(IntPtr block, nint obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<WKNavigationResponsePolicy>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((WKNavigationResponsePolicy)(long)obj);
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<WKNavigationActionPolicy, WKWebpagePreferences>))]
    internal delegate void DActionArity2V85(IntPtr block, nint arg1, IntPtr arg2);

    internal static class SDActionArity2V85
    {
        internal static readonly DActionArity2V85 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity2V85))]
        private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<WKNavigationActionPolicy, WKWebpagePreferences>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((WKNavigationActionPolicy)(long)arg1, Runtime.GetNSObject<WKWebpagePreferences>(arg2));
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>))]
    internal delegate void DActionArity2V44(IntPtr block, nint arg1, IntPtr arg2);

    internal static class SDActionArity2V44
    {
        internal static readonly DActionArity2V44 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity2V44))]
        private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke((NSUrlSessionAuthChallengeDisposition)(long)arg1, Runtime.GetNSObject<NSUrlCredential>(arg2));
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<string>))]
    internal delegate void DActionArity1V44(IntPtr block, IntPtr obj);

    internal static class SDActionArity1V44
    {
        internal static readonly DActionArity1V44 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V44))]
        private unsafe static void Invoke(IntPtr block, IntPtr obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<string>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(NSString.FromHandle(obj));
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(Action<NSUrl[]>))]
    internal delegate void DActionArity1V95(IntPtr block, IntPtr obj);

    internal static class SDActionArity1V95
    {
        internal static readonly DActionArity1V95 Handler = Invoke;

        [MonoPInvokeCallback(typeof(DActionArity1V95))]
        private unsafe static void Invoke(IntPtr block, IntPtr obj)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((Action<NSUrl[]>)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(NSArray.ArrayFromHandle<NSUrl>(obj));
        }
    }


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(JSContextExceptionHandler))]
    internal delegate void DJSContextExceptionHandler(IntPtr block, IntPtr context, IntPtr exception);

    internal static class SDJSContextExceptionHandler
    {
        internal static readonly DJSContextExceptionHandler Handler = Invoke;

        [MonoPInvokeCallback(typeof(DJSContextExceptionHandler))]
        private unsafe static void Invoke(IntPtr block, IntPtr context, IntPtr exception)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((JSContextExceptionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject<JSContext>(context), Runtime.GetNSObject<JSValue>(exception));
        }
    }

    internal sealed class NIDJSContextExceptionHandler  
    {
        [Preserve(Conditional = true)]
        public unsafe static JSContextExceptionHandler? Create(IntPtr block)
        {
            if (block == IntPtr.Zero)
                return null;

            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            JSContextExceptionHandler jSContextExceptionHandler = (JSContextExceptionHandler)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target);
            return jSContextExceptionHandler;
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [UserDelegateType(typeof(JSPromiseCreationExecutor))]
    internal delegate void DJSPromiseCreationExecutor(IntPtr block, IntPtr resolve, IntPtr rejected);

    internal static class SDJSPromiseCreationExecutor
    {
        internal static readonly DJSPromiseCreationExecutor Handler = Invoke;

        [MonoPInvokeCallback(typeof(DJSPromiseCreationExecutor))]
        private unsafe static void Invoke(IntPtr block, IntPtr resolve, IntPtr rejected)
        {
            BlockLiteral* ptr = (BlockLiteral*)(void*)block;
            ((JSPromiseCreationExecutor)(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(Runtime.GetNSObject<JSValue>(resolve), Runtime.GetNSObject<JSValue>(rejected));
        }
    }


    #endregion

    //(ptr->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target)
}




