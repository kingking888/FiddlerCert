﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using VCSJones.FiddlerCert.Interop;

namespace VCSJones.FiddlerCert
{
    public static class DistinguishedNameParser
    {
        public static Dictionary<string, List<string>> Parse(string distingishedName)
        {
            var result = new Dictionary<string, List<string>>(StringComparer.CurrentCultureIgnoreCase);
            var distinguishedNamePtr = IntPtr.Zero;
            try
            {
                distinguishedNamePtr = Marshal.StringToCoTaskMemUni(distingishedName);
                //We need to copy the IntPtr.
                //The copy is necessary because DsGetRdnW modifies the pointer to advance it. We need to keep
                //The original so we can free it later, otherwise we'll leak memory.
                var distinguishedNamePtrCopy = distinguishedNamePtr;
                uint pcDN = (uint)distingishedName.Length, pcKey, pcVal;
                IntPtr ppKey, ppVal;
                while (pcDN != 0 && Ntdsapi.DsGetRdnW(ref distinguishedNamePtrCopy, ref pcDN, out ppKey, out pcKey, out ppVal, out pcVal) == 0)
                {
                    if (pcKey == 0 || pcVal == 0)
                    {
                        continue;
                    }
                    var key = Marshal.PtrToStringUni(ppKey, (int)pcKey);
                    var value = Marshal.PtrToStringUni(ppVal, (int)pcVal);
                    if (result.ContainsKey(key))
                    {
                        result[key].Add(value);
                    }
                    else
                    {
                        result.Add(key, new List<string> { value });
                    }
                    if (pcDN == 0)
                    {
                        break;
                    }
                }
                return result;

            }
            finally
            {
                Marshal.FreeCoTaskMem(distinguishedNamePtr);
            }
        }
    }
}
