using ObjCRuntime;

internal static class Libraries
{
    public static class AppKit
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AppKit.framework/AppKit", 0);
    }

    public static class Foundation
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Foundation.framework/Foundation", 0);
    }

    public static class ImageKit
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/ImageKit.framework/ImageKit", 0);
    }

    public static class QTKit
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QTKit.framework/QTKit", 0);
    }

    public static class PdfKit
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/PDFKit.framework/PDFKit", 0);
    }

    public static class WebKit
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/WebKit.framework/WebKit", 0);
    }

    public static class QuartzComposer
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/QuartzComposer.framework/QuartzComposer", 0);
    }

    public static class AVFoundation
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AVFoundation.framework/AVFoundation", 0);
    }

    public static class CoreAnimation
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 0);
    }

    public static class CoreData
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreData.framework/CoreData", 0);
    }

    public static class Quartz
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 0);
    }

    public static class CoreImage
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/Versions/A/Frameworks/CoreImage.framework/CoreImage", 0);
    }

    public static class ImageIO
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", 0);
    }

    public static class CoreLocation
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreLocation.framework/CoreLocation", 0);
    }

    public static class QuickLook
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuickLook.framework/QuickLook", 0);
    }

    public static class JavaScriptCore
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/JavaScriptCore.framework/JavaScriptCore", 0);
    }

    public static class CoreFoundation
    {
        public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);
    }

}
