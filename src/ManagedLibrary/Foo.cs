using System;
using System.Runtime.InteropServices;

namespace ManagedLibrary
{
    public class Foo
    {
        public int Bar()
        {
            return (int)NativeMethods.NativeBar();
        }

        private class NativeMethods
        {
            [DllImport("NativeLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr NativeBar();
        }
    }
}
