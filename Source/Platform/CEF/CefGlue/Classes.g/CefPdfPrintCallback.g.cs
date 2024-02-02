﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefPdfPrintCallback
    {
        private static Dictionary<IntPtr, CefPdfPrintCallback> _roots = new Dictionary<IntPtr, CefPdfPrintCallback>();
        
        private int _refct;
        private cef_pdf_print_callback_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_pdf_print_callback_t.add_ref_delegate _ds0;
        private cef_pdf_print_callback_t.release_delegate _ds1;
        private cef_pdf_print_callback_t.has_one_ref_delegate _ds2;
        private cef_pdf_print_callback_t.has_at_least_one_ref_delegate _ds3;
        private cef_pdf_print_callback_t.on_pdf_print_finished_delegate _ds4;
        
        protected CefPdfPrintCallback()
        {
            _self = cef_pdf_print_callback_t.Alloc();
        
            _ds0 = new cef_pdf_print_callback_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_pdf_print_callback_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_pdf_print_callback_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_pdf_print_callback_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_pdf_print_callback_t.on_pdf_print_finished_delegate(on_pdf_print_finished);
            _self->_on_pdf_print_finished = Marshal.GetFunctionPointerForDelegate(_ds4);
        }
        
        ~CefPdfPrintCallback()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_pdf_print_callback_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_pdf_print_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_pdf_print_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_pdf_print_callback_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_pdf_print_callback_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_pdf_print_callback_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_pdf_print_callback_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}