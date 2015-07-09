using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPUemu
{
    static class NumberHelper
    {
        private static string hexChars = "0123456789ABCDEF";

        /**
         * Prevent the user from typing in any invalid hexadecimal character.
         */
        public static bool validHexInput(string text)
        {
            if (text.Length == 0) return true;

            string validChars = "0123456789ABCDEF";
            bool returnValue = false;

            foreach (char c in text.ToCharArray())
            {
                returnValue = false;
                foreach (char d in validChars.ToCharArray())
                {
                    if (c == d)
                    {
                        returnValue = true;
                        break;
                    }
                }
                if (!returnValue) return false;
            }
            return true;
        }

        public static string shortToHex(ushort number)
        {
            char[] hexString = "????".ToCharArray();
            ushort mask = 0xF;

            for (int i = 3; i >= 0; i--)
            {
                hexString[i] = hexChars.ToCharArray()[number & mask];
                number = (ushort)(number >> 4);
            }

            return new string(hexString);
        }

        public static string byteToHex(byte number)
        {
            char[] hexString = "??".ToCharArray();
            byte mask = 0xF;

            for (int i = 1; i >= 0; i--)
            {
                hexString[i] = hexChars.ToCharArray()[number & mask];
                number = (byte)(number >> 4);
            }

            return new string(hexString);
        }

        public static ushort hexToShort(string hexString)
        {
            ushort number = 0;
            if (hexString.Length > 4) return number;

            for (int i = 0; i <= hexString.Length - 1; i++)
            {
                number = (ushort)(number << 4);
                number += (ushort)(hexChars.IndexOf(hexString.ToCharArray()[i]));
            }

            return number;
        }

        public static byte hexToByte(string hexString)
        {
            byte number = 0;
            if (hexString.Length > 2) return number;

            for (int i = 0; i <= hexString.Length - 1; i++)
            {
                number = (byte)(number << 4);
                number += (byte)(hexChars.IndexOf(hexString.ToCharArray()[i]));
            }

            return number;
        }
    }
}
