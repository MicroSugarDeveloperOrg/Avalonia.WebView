namespace Xamarin.Bundler;

internal class Errors
{
	internal const string @default = "The error message for code {0} could not be found. Please report this missing message on GitHub at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT0000 = "Unexpected error - Please fill a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT0001 = "'-devname' was provided without any device-specific action";

	internal const string MM0001 = "This version of Xamarin.Mac requires Mono {0} (the current Mono version is {1}). Please update the Mono.framework from http://mono-project.com/Downloads";

	internal const string MT0002 = "Could not parse the environment variable '{0}'";

	internal const string MX0003 = "Application name '{0}.exe' conflicts with an SDK or product assembly (.dll) name.";

	internal const string MT0004 = "New refcounting logic requires SGen to be enabled too.";

	internal const string MT0005 = "The output directory * does not exist.";

	internal const string MT0006 = "There is no devel platform at {0}, use --platform=PLAT to specify the SDK.";

	internal const string MX0007 = "The root assembly '{0}' does not exist";

	internal const string MM0008 = "You should provide one root assembly only, found {0} assemblies: '{1}'";

	internal const string MX0009 = "Error while loading assemblies: {0}.";

	internal const string MX0010 = "Could not parse the command line arguments: {0}";

	internal const string MT0011 = "{0} was built against a more recent runtime ({1}) than Xamarin.iOS supports.";

	internal const string MT0012 = "Incomplete data is provided to complete *.";

	internal const string MT0013 = "Profiling support requires sgen to be enabled too.";

	internal const string MT0014 = "The iOS {0} SDK does not support building applications targeting {1}.";

	internal const string MT0015 = "Invalid ABI: {0}. Supported ABIs are: i386, x86_64, armv7, armv7+llvm, armv7+llvm+thumb2, armv7s, armv7s+llvm, armv7s+llvm+thumb2, armv7k, armv7k+llvm, arm64, arm64+llvm, arm64_32 and arm64_32+llvm.";

	internal const string MX0016 = "The option '{0}' has been deprecated.";

	internal const string MX0017 = "You should provide a root assembly.";

	internal const string MX0018 = "Unknown command line argument: '{0}'";

	internal const string MT0019 = "Only one --[log|install|kill|launch]dev or --[launch|debug]sim option can be used.";

	internal const string MX0020 = "The valid options for '{0}' are '{1}'.";

	internal const string MT0021 = "Cannot compile using gcc/g++ (--use-gcc) when using the static registrar (this is the default when compiling for device). Either remove the --use-gcc flag or use the dynamic registrar (--registrar:dynamic).";

	internal const string MT0022 = "The options '--unsupported--enable-generics-in-registrar' and '--registrar' are not compatible.";

	internal const string MT0023 = "The root assembly {0} conflicts with another assembly ({1}).";

	internal const string MM0023 = "Application name '{0}.exe' conflicts with another user assembly.";

	internal const string MT0024 = "Could not find required file '{0}'.";

	internal const string MT0025 = "No SDK version was provided. Please add --sdk=X.Y to specify which {0} SDK should be used to build your application.";

	internal const string MX0026 = "Could not parse the command line argument '-{0}': {1}";

	internal const string MT0027 = "The options '\\*' and '\\*' are not compatible.";

	internal const string MT0028 = "Cannot enable PIE (-pie) when targeting iOS 4.1 or earlier. Please disable PIE (-pie:false) or set the deployment target to at least iOS 4.2";

	internal const string MT0029 = "REPL (--enable-repl) is only supported in the simulator (--sim).";

	internal const string MT0030 = "The executable name ({0}) and the app name ({1}) are different, this may prevent crash logs from getting symbolicated properly.";

	internal const string MT0031 = "The command line arguments '--enable-background-fetch' and '--launch-for-background-fetch' require '--launchsim' too.";

	internal const string MT0032 = "The option '--debugtrack' is ignored unless '--debug' is also specified.";

	internal const string MT0033 = "A Xamarin.iOS project must reference either monotouch.dll or Xamarin.iOS.dll";

	internal const string MT0034 = "Cannot reference '{0}.dll' in a {1} project - it is implicitly referenced by '{2}'.";

	internal const string MT0036 = "Cannot launch a * simulator for a * app. Please enable the correct architecture(s) in your project's iOS Build options (Advanced page).";

	internal const string MT0037 = "monotouch.dll is not 64-bit compatible. Either reference Xamarin.iOS.dll, or do not build for a 64-bit architecture (ARM64 and/or x86_64).";

	internal const string MT0038 = "The old registrars (--registrar:oldstatic|olddynamic) are not supported when referencing Xamarin.iOS.dll.";

	internal const string MT0039 = "Applications targeting ARMv6 cannot reference Xamarin.iOS.dll.";

	internal const string MT0040 = "Could not find the assembly '\\*', referenced by '\\*'.";

	internal const string MT0041 = "Cannot reference '{0}' in a {1} app.";

	internal const string MT0042 = "No reference to either monotouch.dll or Xamarin.iOS.dll was found. A reference to monotouch.dll will be added.";

	internal const string MX0043 = "The Boehm garbage collector is not supported. The SGen garbage collector has been selected instead.";

	internal const string MT0044 = "--listsim is only supported with Xcode 6.0 or later.";

	internal const string MT0045 = "--extension is only supported when using the iOS 8.0 (or later) SDK.";

	internal const string MT0047 = "The minimum deployment target for Unified applications is 5.1.1, the current deployment target is '*'. Please select a newer deployment target in your project's iOS Application options.";

	internal const string MT0049 = "{0}.framework is supported only if deployment target is 8.0 or later. {0} features might not work correctly.";

	internal const string MM0050 = "You cannot provide a root assembly if --no-root-assembly is passed, found {0} assemblies: '{1}'";

	internal const string MT0051 = "{3} {0} requires Xcode {4} or later. The current Xcode version (found in {2}) is {1}.";

	internal const string MM0051 = "An output directory (--output) is required if --no-root-assembly is passed.";

	internal const string MT0052 = "No command specified.";

	internal const string MT0054 = "Unable to canonicalize the path '{0}': {1} ({2}).";

	internal const string MT0055 = "The Xcode path '{0}' does not exist.";

	internal const string MX0056 = "Cannot find Xcode in the default location (/Applications/Xcode.app). Please install Xcode, or pass a custom path using --sdkroot <path>.";

	internal const string MT0057 = "Cannot determine the path to Xcode.app from the sdk root '{0}'. Please specify the full path to the Xcode.app bundle.";

	internal const string MT0058 = "The Xcode.app '{0}' is invalid (the file '{1}' does not exist).";

	internal const string MX0059 = "Could not find the currently selected Xcode on the system: {0}";

	internal const string MX0060 = "Could not find the currently selected Xcode on the system. 'xcode-select --print-path' returned '{0}', but that directory does not exist.";

	internal const string MT0061 = "No Xcode.app specified (using --sdkroot), using the system Xcode as reported by 'xcode-select --print-path': {0}";

	internal const string MT0062 = "No Xcode.app specified (using --sdkroot or 'xcode-select --print-path'), using the default Xcode instead: {0}";

	internal const string MT0063 = "Cannot find the executable in the extension * (no CFBundleExecutable entry in its Info.plist)";

	internal const string MT0064 = "Xamarin.iOS only supports embedded frameworks with Unified projects.";

	internal const string MT0065 = "Xamarin.iOS only supports embedded frameworks when deployment target is at least 8.0 (current deployment target: '{0}'; embedded frameworks: '{1}')";

	internal const string MT0065_A = "Xamarin.iOS only supports embedded frameworks when deployment target is at least 2.0 (current deployment target: '{0}'; embedded frameworks: '{1}')";

	internal const string MT0066 = "Invalid build registrar assembly: *";

	internal const string MT0067 = "Invalid registrar: {0}";

	internal const string MX0068 = "Invalid value for target framework: {0}.";

	internal const string MX0070 = "Invalid target framework: {0}. Valid target frameworks are: {1}.";

	internal const string MX0071 = "Unknown platform: {0}. This usually indicates a bug in {1}; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case.";

	internal const string MT0072 = "Extensions are not supported for the platform '{0}'.";

	internal const string MT0073 = "{4} {0} does not support a deployment target of {1} for {3} (the minimum is {2}). Please select a newer deployment target in your project's Info.plist.";

	internal const string MX0074 = "{4} {0} does not support a deployment target of {1} for {3} (the maximum is {2}). Please select an older deployment target in your project's Info.plist or upgrade to a newer version of {4}.";

	internal const string MT0075 = "Invalid architecture '{0}' for {1} projects. Valid architectures are: {2}";

	internal const string MT0076 = "No architecture specified (using the --abi argument). An architecture is required for {0} projects.";

	internal const string MT0077 = "WatchOS projects must be extensions.";

	internal const string MT0078 = "Incremental builds are enabled with a deployment target < 8.0 (currently {0}). This is not supported (the resulting application will not launch on iOS 9), so the deployment target will be set to 8.0.";

	internal const string MT0079 = "The recommended Xcode version for {4} {0} is Xcode {3} or later. The current Xcode version (found in {2}) is {1}.";

	internal const string MM0079 = "No executable was copied into the app bundle.  Please contact 'support@xamarin.com'";

	internal const string MX0080 = "Disabling the new refcount logic is deprecated.";

	internal const string MT0081 = "The command line argument --download-crash-report also requires --download-crash-report-to.";

	internal const string MT0082 = "REPL (--enable-repl) is only supported when linking is not used (--nolink).";

	internal const string MT0083 = "Asm-only bitcode is not supported on watchOS. Use either --bitcode:marker or --bitcode:full.";

	internal const string MT0084 = "Bitcode is not supported in the simulator. Do not pass --bitcode when building for the simulator.";

	internal const string MT0085 = "No reference to '{0}' was found. It will be added automatically.";

	internal const string MX0086 = "A target framework (--target-framework) must be specified.";

	internal const string MT0087 = "Incremental builds (--fastdev) is not supported with the Boehm GC. Incremental builds will be disabled.";

	internal const string MT0088 = "The GC must be in cooperative mode for watchOS apps. Please remove the --coop:false argument to mtouch.";

	internal const string MT0089 = "The option '{0}' cannot take the value '{1}' when cooperative mode is enabled for the GC.";

	internal const string MX0090 = "The target framework '{0}' is deprecated. Use '{1}' instead.";

	internal const string MX0091 = "This version of {0} requires the {1} {2} SDK (shipped with Xcode {3}). Either upgrade Xcode to get the required header files or {4} (to try to avoid the new APIs).";

	internal const string MT0093 = "Could not find 'mlaunch'.";

	internal const string MT0095 = "Aot files could not be copied to the destination directory {0}: {1}";

	internal const string MT0095_A = "Aot files could not be copied to the destination directory {0}: Could not start process.";

	internal const string MT0095_B = "Aot files could not be copied to the destination directory {0}";

	internal const string MT0096 = "No reference to Xamarin.iOS.dll was found.";

	internal const string MM0097 = "machine.config file '{0}' can not be found.";

	internal const string MX0099 = "Internal error: {0}. Please file an issue at https://github.com/xamarin/xamarin-macios/issues/new.";

	internal const string MX0129 = "Debugging symbol file for '{0}' does not match the assembly and is ignored.";

	internal const string MX0130 = "No root assemblies found. You should provide at least one root assembly.";

	internal const string MX0131 = "Product assembly '{0}' not found in assembly list: '{1}'";

	internal const string MX0132 = "Unknown optimization: '{0}'. Valid optimizations are: {1}.";

	internal const string MX0133 = "Found more than 1 assembly matching '{0}' choosing first:{1}{2}";

	internal const string MX0135 = "Did not link system framework '{0}' (referenced by assembly '{1}') because it was introduced in {2} {3}, and we're using the {2} {4} SDK.";

	internal const string MX0148 = "Unable to parse the linker flags '{0}' from the LinkWith attribute for the library '{1}' in {2} : {3}";

	internal const string MT0150 = "Internal error: The interpreter is currently only available for 64 bits.";

	internal const string MT0100 = "Invalid assembly build target: '{0}'. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0101 = "The assembly '{0}' is specified multiple times in --assembly-build-target arguments.";

	internal const string MT0102 = "The assemblies '{0}' and '{1}' have the same target name ('{2}'), but different targets ('{3}' and '{4}').";

	internal const string MT0103 = "The static object '{0}' contains more than one assembly ('{1}'), but each static object must correspond with exactly one assembly.";

	internal const string MT0105 = "No assembly build target was specified for '{0}'.";

	internal const string MT0106 = "The assembly build target name '{0}' is invalid: the character '{1}' is not allowed.";

	internal const string MT0107 = "The assemblies '{0}' have different custom LLVM optimizations ('{1}'), which is not allowed when they are all compiled to a single binary.";

	internal const string MT0108 = "The assembly build target '{0}' did not match any assemblies.";

	internal const string MT0109 = "The assembly '{0}' was loaded from a different path than the provided path (provided path: {1}, actual path: {2}).";

	internal const string MT0110 = "Incremental builds have been disabled because this version of Xamarin.iOS does not support incremental builds in projects that include third-party binding libraries and that compiles to bitcode.";

	internal const string MT0111 = "Bitcode has been enabled because this version of Xamarin.iOS does not support building watchOS projects using LLVM without enabling bitcode.";

	internal const string MT0112 = "Native code sharing has been disabled because {0}";

	internal const string MT0112_a = "the container app's deployment target is earlier than iOS 8.0 (it's {0}).";

	internal const string MT0112_b = "the container app includes I18N assemblies ({0}).";

	internal const string MT0112_c = "the container app has custom xml definitions for the managed linker ({0}).";

	internal const string MT0113 = "Native code sharing has been disabled for the extension '{0}' because {1}";

	internal const string MT0113_a = "the bitcode options differ between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_b = "the --assembly-build-target options are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_c = "the I18N assemblies are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_d = "the arguments to the AOT compiler are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_e = "the other arguments to the AOT compiler are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_f = "LLVM is not enabled or disabled in both the container app ({0}) and the extension ({1}).";

	internal const string MT0113_g = "the managed linker settings are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_h = "the skipped assemblies for the managed linker are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_i = "the extension has custom xml definitions for the managed linker ({0}).";

	internal const string MT0113_j = "the interpreter settings are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_k = "the interpreted assemblies are different between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_l = "the container app does not build for the ABI {0} (while the extension is building for this ABI).";

	internal const string MT0113_m = "the container app is building for the ABI {0}, which is not compatible with the extension's ABI ({1}).";

	internal const string MT0113_n = "the remove-dynamic-registrar optimization differ between the container app ({0}) and the extension ({1}).";

	internal const string MT0113_o = "the container app is referencing the assembly '{0}' from '{1}', while the extension references a different version from '{2}'.";

	internal const string MM0114 = "Hybrid AOT compilation requires all assemblies to be AOT compiled";

	internal const string MT0115 = "It is recommended to reference dynamic symbols using code (--dynamic-symbol-mode=code) when bitcode is enabled.";

	internal const string MT0116 = "Invalid architecture: {0}. 32-bit architectures are not supported when deployment target is 11 or later.";

	internal const string MT0117 = "Can't launch a 32-bit app on a simulator that only supports 64-bit.";

	internal const string MT0118 = "The directory {0} containing the mono symbols could not be found.";

	internal const string MT0123 = "The executable assembly {0} does not reference {1}.dll.";

	internal const string MT0124 = "Could not set the current language to '{0}' (according to LANG={1}): {2}";

	internal const string MT0125 = "The --assembly-build-target command-line argument is ignored in the simulator.";

	internal const string MT0126 = "Incremental builds have been disabled because incremental builds are not supported in the simulator.";

	internal const string MT0127 = "Incremental builds have been disabled because this version of Xamarin.iOS does not support incremental builds in projects that include more than one third-party binding libraries.";

	internal const string MT0128 = "Could not touch the file '{0}': {1}";

	internal const string MT0136 = "Cannot find the assembly '{0}' referenced from '{1}'.";

	internal const string MT0137 = "Cannot find the assembly '{0}', referenced by a {2} attribute in '{1}'.";

	internal const string MT0140 = "File '{0}' is not a valid framework.";

	internal const string MT0141 = "The interpreter is not supported in the simulator. Switching to REPL which provide the same extra features on the simulator.";

	internal const string MT0142 = "Cannot find the assembly '{0}', passed as an argument to --interpreter.";

	internal const string MM0143 = "Projects using the Classic API are not supported anymore. Please migrate the project to the Unified API.";

	internal const string MM0144 = "Building 32-bit apps is not supported anymore. Please change the architecture in the project's Mac Build options to 'x86_64'.";

	internal const string MT0145 = "Please use device specific builds on WatchOS when building for Debug.";

	internal const string MT0146 = "ARM64_32 Debug mode requires --interpreter[=all], forcing it.";

	internal const string MM0147 = "Unable to parse the cflags '{0} from pkg-config: {1}";

	internal const string MT0156 = "Internal error: byref array is neither string, NSObject or INativeObject.";

	internal const string MT0157 = "Internal error: can't convert from '{0}' to '{1}' in {2}. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0158 = "Internal error: the smart enum {0} doesn't seem to be a smart enum after all. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0159 = "Internal error: unsupported tokentype ({0}) for {1}. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0160 = "Internal error: the static registrar should not execute unless the linker also executed (or was disabled). A potential workaround is to pass '-f' as an additional {0} argument to force a full build. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0161 = "Internal error: symbol without a name (type: {0}). Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0168 = "Internal error: 'can't convert frameworks to frameworks: {0}'. Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).";

	internal const string MT0174_a = "The assembly {0} was referenced by another assembly, but at the same time linked out by the linker.";

	internal const string MT0175_a = "The linker output contains more than one assemblies named '{0}':\\n\\t{1}";

	internal const string MT0175_b = "Not all assemblies for {0} have link tasks";

	internal const string MT0175_c = "Link tasks for {0} aren't all the same";

	internal const string MX1009 = "Could not copy the assembly '{0}' to '{1}': {2}";

	internal const string MT1010 = "Could not load the assembly '{0}': {1}";

	internal const string MT1013 = "Dependency tracking error: no files to compare. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case.";

	internal const string MT1014 = "Failed to re-use cached version of '{0}': {1}.";

	internal const string MT1015 = "Failed to create the executable '{0}': {1}";

	internal const string MT1016 = "Failed to create the NOTICE file because a directory already exists with the same name.";

	internal const string MT1017 = "Failed to create the NOTICE file: {0}";

	internal const string MT1022 = "Could not copy the directory '{0}' to '{1}': {2}";

	internal const string MM1034 = "Could not create symlink '{0}' -> '{1}': error {2}";

	internal const string MT1035 = "Cannot include different versions of the framework '{0}'";

	internal const string MT1036 = "Framework '{0}' included from: {1} (Related to previous error)";

	internal const string MT1300 = "Unsupported bitcode platform: {0}.";

	internal const string MT1301 = "Unsupported TvOS ABI: {0}.";

	internal const string MT1302 = "Could not extract the native library '{0}' from '{1}'. Please ensure the native library was properly embedded in the managed assembly (if the assembly was built using a binding project, the native library must be included in the project, and its Build Action must be 'ObjcBindingNativeLibrary').";

	internal const string MT1302_A = "Invalid escape sequence when converting .s to .ll, \\\\ as the last characted in {0}:{1}.";

	internal const string MT1302_B = "Invalid escape sequence when converting .s to .ll, bad octal escape in {0}:{1} due to {2}.";

	internal const string MT1303 = "Could not decompress the native framework '{0}' from '{1}'. Please review the build log for more information from the native 'unzip' command.";

	internal const string MT1305 = "The binding library '{0}' contains a user framework ({0}), but embedded user frameworks require iOS 8.0 (the deployment target is {1}). Please set the deployment target in the Info.plist file to at least 8.0.";

	internal const string MM1401 = "The required 'Xamarin.Mac.dll' assembly is missing from the references";

	internal const string MM1402 = "The assembly '{0}' is not compatible with this tool or profile";

	internal const string MM1403 = "{0} {1} could not be found. Target framework '{2}' is unusable to package the application.";

	internal const string MM1404 = "Target framework '{0}' is invalid.";

	internal const string MM1405 = "useFullXamMacFramework must always target framework .NET 4.5, not '{0}' which is invalid.";

	internal const string MM1407 = "Mismatch between Xamarin.Mac reference '{0}' and target framework selected '{1}'.";

	internal const string MM1501 = "Can not resolve reference: {0}";

	internal const string MX1502 = "One or more reference(s) to type '{0}' already exists inside '{1}' before linking";

	internal const string MX1503 = "One or more reference(s) to type '{0}' still exists inside '{1}' after linking";

	internal const string MX1600 = "Not a Mach-O dynamic library (unknown header '0x{0}'): {1}.";

	internal const string MX1602 = "Not a Mach-O dynamic library (unknown header '0x{0}'): {1}.";

	internal const string MX1603 = "Unknown format for fat entry at position {0} in {1}.";

	internal const string MX1604 = "File of type {0} is not a MachO file ({1}).";

	internal const string MT1601 = "Not a Mach-O static library (unknown header '{0}', expected '!<arch>').";

	internal const string MT1605 = "Invalid entry '{0}' in the static library '{1}', entry header doesn't end with 0x60 0x0A (found '0x{2} 0x{3}')";

	internal const string MX2001 = "Could not link assemblies. {0}";

	internal const string MT2002 = "Can not resolve reference: {0}";

	internal const string MT2003 = "Option '--optimize={0}{1}' will be ignored since the static registrar is not enabled";

	internal const string MT2003_A = "Option '--optimize={0}' will be ignored since it's only applicable to watchOS.";

	internal const string MT2003_B = "Option '--optimize={0}{1}' will be ignored since linking is disabled";

	internal const string MX2004 = "Extra linker definitions file '{0}' could not be located.";

	internal const string MX2005 = "Definitions from '{0}' could not be parsed.";

	internal const string MT2006 = "Can not load mscorlib.dll from: '{0}'. Please reinstall Xamarin.iOS.";

	internal const string MM2006 = "Native library '{0}' was referenced but could not be found.";

	internal const string MT2007 = "Failed to resolve \"{0}\" reference from \"{1}\"";

	internal const string MM2007 = "Xamarin.Mac Unified API against a full .NET framework does not support linking SDK or All assemblies. Pass either the `-nolink` or `-linkplatform` flag.";

	internal const string MM2009 = "Referenced by {0}.{1}";

	internal const string MT2010 = "Unknown HttpMessageHandler `{0}`. Valid values are HttpClientHandler (default), CFNetworkHandler or NSUrlSessionHandler";

	internal const string MM2012 = "Only first {0} of {1} \\\"Referenced by\\\" warnings shown.";

	internal const string MM2013 = "Failed to resolve the reference to \\\"{0}\\\", referenced in \\\"{1}\\\". The app will not include the referenced assembly, and may fail at runtime.";

	internal const string MT2014 = "Unable to link assembly '{0}' as it is mixed-mode.";

	internal const string MT2015 = "Invalid HttpMessageHandler `{0}` for watchOS. The only valid value is NSUrlSessionHandler.";

	internal const string MX2017 = "Could not process XML description: {0}";

	internal const string MT2018 = "The assembly '{0}' is referenced from two different locations: '{1}' and '{2}'.";

	internal const string MT2019 = "Can not load the root assembly '{0}'.";

	internal const string MT2101 = "Can't resolve the reference '{0}', referenced from the method '{1}' in '{2}'.";

	internal const string MT2102 = "Error processing the method '{0}' in the assembly '{1}': {2}";

	internal const string MT2102_A = "Error processing the method '{0}' in the assembly '{1}'";

	internal const string MX2103 = "Error processing assembly '{0}': {1}";

	internal const string MT2105_A = "The [BindingImpl] attribute on the member '{0}' is invalid: did not expect fields.";

	internal const string MT2105_B = "The [BindingImpl] attribute on the member '{0}' is invalid: did not expect properties.";

	internal const string MT2105_C = "The [BindingImpl] attribute on the member '{0}' is invalid: did not expect a constructor with a '{1}' parameter type (expected 'ObjCRuntime.BindingImplOptions).";

	internal const string MT2105_D = "The [BindingImpl] attribute on the member '{0}' is invalid: did not expect a constructor with a {1} parameters (expected 1 parameters).";

	internal const string MT2105_E = "The property {0}.{1} contains a '{2}' exception clause, which is currently not supported when compiling for bitcode. This property will throw an exception if called.";

	internal const string MT2105_F = "The method {0}.{1} contains a '{2}' exception clause, which is currently not supported when compiling for bitcode. This method will throw an exception if called.";

	internal const string MM2106 = "Could not optimize the call to BlockLiteral.{2} in {0} at offset {1} because the previous instruction was unexpected ({3})";

	internal const string MM2106_A = "Could not optimize the call to BlockLiteral.{2} in {0} at offset {1} because could not determine the type of the delegate type of the first argument (instruction: {3})";

	internal const string MM2106_B = "Could not optimize the call to BlockLiteral.{2} in {0} because the type of the value passed as the first argument (the trampoline) is {1}, which makes it impossible to compute the block signature.";

	internal const string MM2106_C = "Could not optimize the call to BlockLiteral.SetupBlock in {0} at offset {1} because no [UserDelegateType] attribute could be found on {2}.";

	internal const string MM2106_D = "Could not optimize the call to BlockLiteral.SetupBlock in {0} at offset {1}: {2}.";

	internal const string MM2107 = "It's not safe to remove the dynamic registrar, because {0} references '{1}.{2} ({3})'.";

	internal const string MM2108 = "{0} was stripped of architectures except {1} to comply with App Store restrictions. This could break existing codesigning signatures. Consider stripping the library with lipo or disabling with --optimize=-trim-architectures";

	internal const string MM2110 = "Xamarin.Mac 'Partial Static' registrar does not support linking. Disable linking or use another registrar mode.";

	internal const string MX3001 = "Could not {0} the assembly '{1}'";

	internal const string MT3003 = "Debugging is not supported when building with LLVM. Debugging has been disabled.";

	internal const string MT3004 = "Could not AOT the assembly '{0}' because it doesn't exist.";

	internal const string MT3005 = "The dependency '{0}' of the assembly '{1}' was not found. Please review the project's references.";

	internal const string MT3006 = "Could not compute a complete dependency map for the project. This will result in slower build times because Xamarin.iOS can't properly detect what needs to be rebuilt (and what does not need to be rebuilt). Please review previous warnings for more details.";

	internal const string MT3007 = "Debug info files (*.mdb / *.pdb) will not be loaded when llvm is enabled.";

	internal const string MT3008 = "Bitcode support requires the use of LLVM (--abi=arm64+llvm etc.)";

	internal const string MM3009 = "AOT of '{0}' was requested but was not found";

	internal const string MM3010 = "Exclusion of AOT of '{0}' was requested but was not found";

	internal const string MT4001 = "The main template could not be expanded to `{0}`.";

	internal const string MT4002 = "Failed to compile the generated code for P/Invoke methods. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4101 = "The registrar cannot build a signature for type `{0}`.";

	internal const string MT4102 = "The registrar found an invalid type `{0}` in signature for method `{2}`. Use `{1}` instead.";

	internal const string MT4103 = "The registrar found an invalid type `{0}` in signature for method `{1}`: The type implements INativeObject, but does not have a constructor that takes two (IntPtr, bool) arguments.";

	internal const string MT4104 = "The registrar cannot marshal the return value for type `{0}` in signature for method `{1}`.";

	internal const string MT4104_A = "The registrar cannot marshal the return value of type `{0}` in the method `{1}.{2}`.";

	internal const string MT4105 = "The registrar cannot marshal the parameter of type `{0}` in signature for method `{1}`.";

	internal const string MT4108 = "The registrar cannot get the ObjectiveC type for managed type `{0}`.";

	internal const string MT4109 = "Failed to compile the generated registrar code. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4110 = "The registrar cannot marshal the out parameter of type `{0}` in signature for method `{1}`.";

	internal const string MT4111 = "The registrar cannot build a signature for type `{0}' in method `{1}`.";

	internal const string MT4113 = "The registrar found a generic method: '{0}'. Exporting generic methods is not supported, and will lead to random behavior and/or crashes";

	internal const string MT4114 = "Unexpected error in the registrar for the method '{0}.{1}' - Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4116 = "Could not register the assembly '{0}': {1}";

	internal const string MT4117 = "The registrar found a signature mismatch in the method '{0}.{1}' - the selector '{4}' indicates the method takes {2} parameters, while the managed method has {3} parameters.";

	internal const string MT4118 = "Cannot register two managed types ('{0}' and '{1}') with the same native name ('{2}').";

	internal const string MT4119 = "Could not register the selector '{0}' of the member '{1}.{2}' because the selector is already registered on the member '{3}'.";

	internal const string MT4120 = "The registrar found an unknown field type '{0}' in field '{1}.{2}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4121 = "Cannot use GCC/G++ to compile the generated code from the static registrar when using the Accounts framework (the header files provided by Apple used during the compilation require Clang). Either use Clang (--compiler:clang) or the dynamic registrar (--registrar:dynamic).";

	internal const string MT4123 = "The type of the variadic parameter in the variadic function '{0}' must be System.IntPtr.";

	internal const string MT4124 = "Invalid {0} found on '{1}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_A = "Invalid RegisterAttribute property {1} found on '{0}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_B = "Invalid AdoptsAttribute found on '{0}': expected 1 constructor arguments, got {1}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_C = "Invalid BindAsAttribute found on '{0}.{1}': unknown field {2}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_D = "Invalid {0} found on '{1}.{2}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_E = "Invalid BindAsAttribute found on '{0}': should have 1 constructor arguments, found {1}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4124_H = "Invalid BindAsAttribute found on '{0}': could not find the underlying enum type of {1}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4125 = "The registrar found an invalid type '{0}' in signature for method '{1}': The interface must have a Protocol attribute specifying its wrapper type.";

	internal const string MT4126 = "Cannot register two managed protocols ('{0}' and '{1}') with the same native name ('{2}').";

	internal const string MT4127 = "Cannot register more than one interface method for the method '{0}.{1}'.";

	internal const string MT4128 = "The registrar found an invalid generic parameter type '{0}' in the parameter {2} of the method '{1}'. The generic parameter must have an 'NSObject' constraint.";

	internal const string MT4129 = "The registrar found an invalid generic return type '{0}' in the method '{1}'. The generic return type must have an 'NSObject' constraint.";

	internal const string MT4130 = "The registrar cannot export static methods in generic classes ('{0}').";

	internal const string MT4131 = "The registrar cannot export static properties in generic classes ('{0}.{1}').";

	internal const string MT4132 = "The registrar found an invalid generic return type '{0}' in the property '{1}.{2}'. The return type must have an 'NSObject' constraint.";

	internal const string MT4134 = "Your application is using the '{0}' framework, which isn't included in the {3} SDK you're using to build your app (this framework was introduced in {3} {2}, while you're building with the {3} {1} SDK.) Please select a newer SDK in your app's {3} Build options.";

	internal const string MM4134 = "Your application is using the '{0}' framework, which isn't included in the {3} SDK you're using to build your app (this framework was introduced in {3} {2}, while you're building with the {3} {1} SDK.) This configuration is not supported with the static registrar (pass --registrar:dynamic as an additional mmp argument in your project's Mac Build option to select). Alternatively select a newer SDK in your app's Mac Build options.";

	internal const string MT4135 = "The member '{0}' has an Export attribute without a selector. A selector is required.";

	internal const string MT4136 = "The registrar cannot marshal the parameter type '{0}' of the parameter '{1}' in the method '{2}.{3}'";

	internal const string MT4137 = "The method '{0}.{1}' is implementing '{2}.{3}'.";

	internal const string MT4138 = "The registrar cannot marshal the property type '{0}' of the property '{1}.{2}'.";

	internal const string MT4139 = "The registrar cannot marshal the property type '{0}' of the property '{1}.{2}'. Properties with the [Connect] attribute must have a property type of NSObject (or a subclass of NSObject).";

	internal const string MT4140 = "The registrar found a signature mismatch in the method '{0}.{1}' - the selector '{4}' indicates the variadic method takes {2} parameters, while the managed method has {3} parameters.";

	internal const string MT4141 = "Cannot register the selector '{0}' on the member '{1}.{2}' because Xamarin.iOS implicitly registers this selector.";

	internal const string MT4145 = "Invalid enum '{0}': enums with the [Native] attribute must have a underlying enum type of either 'long' or 'ulong'.";

	internal const string MT4146 = "The Name parameter of the Registrar attribute on the class '{0}' ('{3}') contains an invalid character: '{1}' (0x{2}).";

	internal const string MT4147 = "Invalid {0} found on '{1}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4148 = "The registrar found a generic protocol: '{0}'. Exporting generic protocols is not supported.";

	internal const string MT4149 = "Cannot register the extension method '{0}.{1}' because the type of the first parameter ('{2}') does not match the category type ('{3}').";

	internal const string MT4150 = "Cannot register the type '{0}' because the category type '{1}' in its Category attribute does not inherit from NSObject.";

	internal const string MT4151 = "Cannot register the type '{0}' because the Type property in its Category attribute isn't set.";

	internal const string MT4152 = "Cannot register the type '{0}' as a category because it implements INativeObject or subclasses NSObject.";

	internal const string MT4153 = "Cannot register the type '{0}' as a category because it's generic.";

	internal const string MT4154 = "Cannot register the method '{0}.{1}' as a category method because it's generic.";

	internal const string MT4156 = "Cannot register two categories ('{0}' and '{1}') with the same native name ('{2}')";

	internal const string MT4157 = "Cannot register the category method '{0}.{1}' because at least one parameter is required for extension methods (and its type must match the category type '{2}').";

	internal const string MT4158 = "Cannot register the constructor {0}.{1} in the category {0} because constructors in categories are not supported.";

	internal const string MT4159 = "Cannot register the method '{0}.{1}' as a category method because category methods must be static.";

	internal const string MT4160 = "Invalid character '{0}' (0x{1}) found in selector '{2}' for '{3}.{4}'";

	internal const string MT4161 = "The registrar found an unsupported structure '{0}': All fields in a structure must also be structures (field '{1}' with type '{2}' is not a structure).";

	internal const string MT4162 = "The type '{0}' (used as {1} {2}) is not available in {3} {4} (it was introduced in {3} {5}){6} Please build with a newer {3} SDK (usually done by using the most recent version of Xcode).";

	internal const string MT4162_A = "The type '{0}' is not available in {3} {4} (it was introduced in {3} {5}){6} Please build with a newer {3} SDK (usually done by using the most recent version of Xcode).";

	internal const string MT4163 = "Internal error in the registrar ({0} ctor with {1} arguments). Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4163_A = "Internal error in the registrar (Unknown availability kind: {0}). Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4163_B = "Internal error in the registrar (BindAs parameters can't be ref/out: {0}). Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4164 = "Cannot export the property '{0}' because its selector '{1}' is an Objective-C keyword. Please use a different name.";

	internal const string MT4165 = "The registrar couldn't find the type 'System.Void' in any of the referenced assemblies.";

	internal const string MT4166 = "Cannot register the method '{0}' because the signature contains a type ({1}) that isn't a reference type.";

	internal const string MT4167 = "Cannot register the method '{0}' because the signature contains a generic type ({1}) with a generic argument type that doesn't implement INativeObject ({2}).";

	internal const string MT4168 = "Cannot register the type '{0}' because its Objective-C name '{1}' is an Objective-C keyword. Please use a different name.";

	internal const string MT4169 = "Failed to generate a P/Invoke wrapper for {0}: {1}";

	internal const string MT4170 = "The registrar can't convert from '{0}' to '{1}' for the return value in the method {2}.";

	internal const string MT4171 = "The BindAs attribute on the return value of the method {0} is invalid: the BindAs type {1} is different from the return type {2}.";

	internal const string MT4171_A = "The BindAs attribute on the parameter #{0} is invalid: the BindAs type {1} is different from the parameter type {2}.";

	internal const string MT4171_B = "The BindAs attribute on the property {0}.{1} is invalid: the BindAs type {2} is different from the property type {1}.";

	internal const string MT4172 = "The registrar can't convert from '{0}' to '{1}' for the parameter '{2}' in the method {3}.";

	internal const string MT4173 = "The registrar can't compute the block signature for the delegate of type {0} in the method {1} because {0} doesn't have a specific signature.";

	internal const string MT4173_A = "The registrar can't compute the block signature for the delegate of type {0} in the method {1} because it couldn't find the Invoke method of the delegate type.";

	internal const string MT4174 = "Unable to locate the block to delegate conversion method for the method {0}'s parameter #{1}.";

	internal const string MT4175 = "Unable to locate the block to delegate conversion method for the method {0}'s parameter #{1}.";

	internal const string MT4176 = "Unable to locate the delegate to block conversion type for the return value of the method {0}.";

	internal const string MT4177 = "The 'ProtocolType' parameter of the 'Adopts' attribute used in class '{0}' contains an invalid character. Value used: '{1}' Invalid Char: '{2}'";

	internal const string MT4178 = "The class '{0}' will not be registered because the WatchKit framework has been removed from the iOS SDK.";

	internal const string MT4179 = "The registrar found the abstract type '{0}' in the signature for '{1}'. Abstract types should not be used in the signature for a member exported to Objective-C.";

	internal const string MT4184 = "Internal error in the registrar (BindAs parameters can't be ref/out: {0}). Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT4185 = "The registrar can't compute the block signature for the delegate of type {0} in the method {1} because it couldn't find the Invoke method of the delegate type.";

	internal const string MT5101 = "Missing '{0}' compiler. Please install Xcode 'Command-Line Tools' component";

	internal const string MT5103 = "Could not find neither the '{0}' nor the '{1}' compiler. Please install Xcode 'Command-Line Tools' component";

	internal const string MM5103 = "Failed to compile. Error code - {0}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT5103_A = "Failed to compile the file(s) '{0}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT5106 = "Could not compile the file(s) '{0}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT5107 = "The assembly '{0}' can't be AOT-compiled for 32-bit architectures because the native code is too big for the 32-bit ARM architecture.";

	internal const string MT5108 = "The compiler output is too long, it's been limited to 1000 lines.";

	internal const string MM5109 = "Native linking failed with error code 1.  Check build log for details.";

	internal const string MT5201 = "Native linking failed. Please review the build log and the user flags provided to gcc: {0}";

	internal const string MT5202 = "Native linking failed. Please review the build log.";

	internal const string MM5202 = "Mono.framework MDK is missing. Please install the MDK for your Mono.framework version from https://www.mono-project.com/download/";

	internal const string MT5203 = "Native linking warning: {0}";

	internal const string MM5203 = "Can't find {0}, likely because of a corrupted Xamarin.Mac installation. Please reinstall Xamarin.Mac.";

	internal const string MT5204 = "Native linking failed. Please review the build log.";

	internal const string MM5205 = "Invalid architecture '{0}'. The only valid architectures is x86_64.";

	internal const string MT5209 = "Native linking error: {0}";

	internal const string MT5210 = "Native linking failed, undefined symbol: {0}. Please verify that all the necessary frameworks have been referenced and native libraries are properly linked in.";

	internal const string MT5211 = "Native linking failed, undefined Objective-C class: {0}. The symbol '{1}' could not be found in any of the libraries or frameworks linked with your application.";

	internal const string MT5212 = "Native linking failed, duplicate symbol: '{0}'.";

	internal const string MT5213 = "Duplicate symbol in: {0} (Location related to previous error)";

	internal const string MT5214 = "Native linking failed, undefined symbol: {0}. This symbol was referenced by the managed member {1}.{2}. Please verify that all the necessary frameworks have been referenced and native libraries linked.";

	internal const string MT5215 = "References to '{0}' might require additional -framework=XXX or -lXXX instructions to the native linker";

	internal const string MT5216 = "Native linking failed for '{0}'. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new";

	internal const string MT5217 = "Native linking possibly failed because the linker command line was too long ({0} characters).";

	internal const string MT5218 = "Can't ignore the dynamic symbol {0} (--ignore-dynamic-symbol={0}) because it was not detected as a dynamic symbol.";

	internal const string MT5219 = "Not linking with WatchKit because it has been removed from iOS.";

	internal const string MM5220 = "Skipping framework '{0}'. It is prohibited (rejected) by the Mac App Store";

	internal const string MM5221 = "Linking against framework '{0}'. It is prohibited (rejected) by the Mac App Store";

	internal const string MT5301 = "Missing 'strip' tool. Please install Xcode 'Command-Line Tools' component";

	internal const string MT5302 = "Missing 'dsymutil' tool. Please install Xcode 'Command-Line Tools' component";

	internal const string MT5303 = "Failed to generate the debug symbols (dSYM directory). Please review the build log.";

	internal const string MT5304 = "Failed to strip the final binary. Please review the build log.";

	internal const string MX5305 = "Missing 'lipo' tool. Please install Xcode 'Command-Line Tools' component";

	internal const string MT5306 = "Failed to create the a fat library. Please review the build log.";

	internal const string MX5307 = "Missing '{0}' tool. Please install Xcode 'Command-Line Tools' component";

	internal const string MM5308 = "Xcode license agreement may not have been accepted.  Please launch Xcode.";

	internal const string MX5309 = "Failed to execute the tool '{0}', it failed with an error code '{1}'. Please check the build log for details.";

	internal const string MM5310 = "install_name_tool failed with an error code '{0}'. Check build log for details.";

	internal const string MX5311 = "lipo failed with an error code '{0}'. Check build log for details.";

	internal const string MX5312 = "pkg-config failed with an error code '{0}'. Check build log for details.";

	internal const string MX5313 = "Could not find pkg-config. Please install the Mono.framework from https://mono-project.com/Downloads";

	internal const string MX5314 = "Failed to execute pkg-config: '{0}'. Check build log for details.";

	internal const string MX5315 = "The tool xcrun failed to find result when looking for the tool '{0}' (the file '{1}' does not exist). Check build log for details.";

	internal const string MT8018 = "Internal consistency error. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new.";
}
