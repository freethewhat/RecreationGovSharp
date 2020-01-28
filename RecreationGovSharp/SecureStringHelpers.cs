using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Runtime.InteropServices;

namespace RecreationGovSharp
{
    public static class SecureStringHelpers
    {
        public static string ToString(this SecureString secureString)
        {
            IntPtr stringPointer = Marshal.SecureStringToBSTR(secureString);
            var password = Marshal.PtrToStringBSTR(stringPointer);
            Marshal.ZeroFreeBSTR(stringPointer);
            return password;
        }

        public static SecureString ToSecureString(this string str)
        {
            SecureString secureString = new SecureString();
            
            // Add the characters into the secure string.
            for (int i = 0; i < str.Length; i++)
            {
                secureString.AppendChar(str[i]);
            }
            
            str = null;
            GC.Collect();

            return secureString;
        }
    }
}
