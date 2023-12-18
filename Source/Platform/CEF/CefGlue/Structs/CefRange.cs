namespace CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CefGlue.Interop;

    public struct CefRange
    {
        private int _from;
        private int _to;

        public CefRange(int from, int to)
        {
            _from = from;
            _to = to;
        }

        public int From
        {
            get { return _from; }
            set { _from = value; }
        }

        public int To
        {
            get { return _to; }
            set { _to = value; }
        }
    }
}
