using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;
internal static class Method
{
    public unsafe static IntPtr Trampoline => Runtime.options->Trampolines->tramp;

    public unsafe static IntPtr SingleTrampoline => Runtime.options->Trampolines->fpret_single_tramp;

    public unsafe static IntPtr StaticSingleTrampoline => Runtime.options->Trampolines->static_fpret_single_tramp;

    public unsafe static IntPtr DoubleTrampoline => Runtime.options->Trampolines->fpret_double_tramp;

    public unsafe static IntPtr StaticDoubleTrampoline => Runtime.options->Trampolines->static_fpret_double_tramp;

    public unsafe static IntPtr StretTrampoline => Runtime.options->Trampolines->stret_tramp;

    public unsafe static IntPtr StaticStretTrampoline => Runtime.options->Trampolines->static_stret_tramp;

    public unsafe static IntPtr StaticTrampoline => Runtime.options->Trampolines->static_tramp;

    public unsafe static IntPtr ConstructorTrampoline => Runtime.options->Trampolines->ctor_tramp;

    internal unsafe static IntPtr ReleaseTrampoline => Runtime.options->Trampolines->release_tramp;

    internal unsafe static IntPtr RetainTrampoline => Runtime.options->Trampolines->retain_tramp;

    internal unsafe static IntPtr X86_DoubleABI_StretTrampoline => Runtime.options->Trampolines->x86_double_abi_stret_tramp;

    internal unsafe static IntPtr X86_DoubleABI_StaticStretTrampoline => Runtime.options->Trampolines->x86_double_abi_static_stret_tramp;

    internal unsafe static IntPtr LongTrampoline => Runtime.options->Trampolines->long_tramp;

    internal unsafe static IntPtr StaticLongTrampoline => Runtime.options->Trampolines->static_long_tramp;

    internal unsafe static IntPtr CopyWithZone1 => Runtime.options->Trampolines->copy_with_zone_1;

    internal unsafe static IntPtr CopyWithZone2 => Runtime.options->Trampolines->copy_with_zone_2;

    internal unsafe static IntPtr GetGCHandleTrampoline => Runtime.options->Trampolines->get_gchandle_tramp;

    internal unsafe static IntPtr SetGCHandleTrampoline => Runtime.options->Trampolines->set_gchandle_tramp;
}
