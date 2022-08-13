﻿using System;
using System.Runtime.InteropServices;

namespace HalosGatePoC.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SYSTEM_MODULE_INFORMATION
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public UIntPtr[] Reserved;
        public IntPtr ImageBase;
        public uint ImageSize;
        public uint Flags;
        public ushort LoadOrderIndex;
        public ushort InitOrderIndex;
        public ushort LoadCount;
        public ushort ModuleNameOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] ImageName;
    }
}
