﻿namespace DVMConsole
{
    /// <summary>
    /// From https://github.com/W3AXL/rc2-dvm/blob/main/rc2-dvm/Audio.cs
    /// No license info or copyright header was present, but attempting to give credit where credit is due.
    /// </summary>
    public class VocoderToneLookupTable
    {
        /// <summary>
        /// This lookup table was obtained by recording the single-tone frames output from a EF Johnson VP8000
        /// </summary>
        public static SortedDictionary<ushort, byte[]> IMBEToneFrames = new SortedDictionary<ushort, byte[]>()
        {
            { 281, new byte[] { 0x10, 0xFF, 0xF9, 0x45, 0x31, 0xCC, 0x8A, 0xC4, 0x3C, 0x16, 0x4B } },
            { 313, new byte[] { 0x0C, 0xFF, 0xF9, 0x45, 0x31, 0xCC, 0x8A, 0xC4, 0x3C, 0x17, 0x48 } },
            { 344, new byte[] { 0x5, 0x7F, 0xBC, 0xD6, 0xC6, 0x75, 0x80, 0x43, 0x39, 0x53, 0x9F } },
            { 375, new byte[] { 0x1, 0x7F, 0xF3, 0x13, 0xF1, 0xD9, 0x8A, 0xAC, 0x1D, 0x8F, 0xC6 } },
            { 406, new byte[] { 0x24, 0xF7, 0x7C, 0x1F, 0x40, 0x78, 0x81, 0xA0, 0x50, 0xBA, 0x0F } },
            { 438, new byte[] { 0x20, 0xF6, 0x67, 0x81, 0xF2, 0x96, 0x82, 0xAE, 0xA5, 0x47, 0x5C } },
            { 469, new byte[] { 0x1C, 0xFE, 0x54, 0xE9, 0x48, 0x4D, 0x86, 0x88, 0x54, 0x4F, 0x52 } },
            { 500, new byte[] { 0x18, 0xDF, 0x94, 0x2A, 0x5F, 0x28, 0x86, 0x20, 0x0B, 0xF6, 0xF2 } },
            { 531, new byte[] { 0x14, 0xF6, 0xE7, 0x2, 0xA4, 0xC5, 0x86, 0x24, 0x31, 0x58, 0x9A } },
            { 563, new byte[] { 0x10, 0xDF, 0x60, 0x5C, 0x3D, 0x4B, 0x8C, 0x44, 0xEC, 0x20, 0x4A } },
            { 594, new byte[] { 0x0C, 0xDF, 0x60, 0x5C, 0x3D, 0x4B, 0x2C, 0x44, 0xAC, 0x39, 0x6C } },
            { 625, new byte[] { 0x0C, 0xDF, 0x60, 0x5C, 0x3D, 0x4B, 0x8C, 0x44, 0xEC, 0x61, 0x48 } },
            { 656, new byte[] { 0x9, 0x76, 0x98, 0x2C, 0x66, 0xF1, 0x82, 0x18, 0x35, 0x2F, 0x2B } },
            { 688, new byte[] { 0x5, 0x5C, 0x30, 0xE2, 0x82, 0x79, 0x88, 0x13, 0x9, 0x54, 0x9E } },
            { 719, new byte[] { 0x5, 0x5C, 0x31, 0xE0, 0x80, 0x78, 0x88, 0x11, 0x28, 0x4C, 0x1A } },
            { 750, new byte[] { 0x1, 0x61, 0xC2, 0x83, 0x1, 0xD9, 0x90, 0x2E, 0x98, 0x88, 0xCF } },
            { 781, new byte[] { 0x1, 0x61, 0xC3, 0x82, 0x0, 0xD8, 0x90, 0xA4, 0x12, 0x0A, 0x4B } },
            { 813, new byte[] { 0x15, 0x47, 0x9D, 0x1B, 0xDC, 0xED, 0x82, 0x20, 0x71, 0x1E, 0x98 } },
            { 844, new byte[] { 0x11, 0x50, 0xD9, 0xF7, 0xA9, 0x4F, 0x89, 0xC7, 0x9C, 0x13, 0x43 } },
            { 875, new byte[] { 0x0D, 0x50, 0xD3, 0xFD, 0xBC, 0x4D, 0xC5, 0xC4, 0x9C, 0x3, 0x4E } },
            { 906, new byte[] { 0x0D, 0x50, 0xD3, 0xFD, 0xBC, 0x4D, 0xC5, 0xC4, 0x1C, 0x13, 0x4A } },
            { 938, new byte[] { 0x0D, 0x50, 0xD3, 0xFD, 0xB4, 0x4F, 0xC5, 0xC5, 0x1C, 0x73, 0x41 } },
            { 969, new byte[] { 0x9, 0x23, 0x0B, 0x0D, 0xC4, 0xA5, 0xC8, 0xE8, 0xA8, 0x2A, 0x2D } },
            { 1000, new byte[] { 0x9, 0x23, 0x0B, 0x0D, 0xC4, 0xA5, 0xCA, 0xE8, 0x28, 0x0A, 0x32 } },
            { 1031, new byte[] { 0x5, 0x51, 0xFB, 0xCA, 0xCE, 0x49, 0xCC, 0x3, 0x25, 0x59, 0x97 } },
            { 1063, new byte[] { 0x5, 0x51, 0xFB, 0xCA, 0xCE, 0x49, 0xCC, 0x3, 0x25, 0x59, 0x94 } },
            { 1094, new byte[] { 0x5, 0x51, 0xFB, 0xCA, 0xCE, 0x49, 0x0C, 0x43, 0x5, 0x41, 0x90 } },
            { 1125, new byte[] { 0x1, 0xC7, 0x9B, 0x13, 0x31, 0x59, 0x80, 0xAA, 0x99, 0x89, 0xCF } },
            { 1156, new byte[] { 0x1, 0xE7, 0x1A, 0x12, 0x30, 0x58, 0x80, 0xA2, 0x91, 0x89, 0xCD } },
            { 1188, new byte[] { 0x1, 0xE7, 0x1A, 0x12, 0x30, 0x58, 0x80, 0xA2, 0x91, 0x89, 0xCA } },
            { 1219, new byte[] { 0x0D, 0x50, 0x93, 0x4D, 0x28, 0x0D, 0x4D, 0x85, 0xB4, 0x32, 0x43 } },
            { 1250, new byte[] { 0x0D, 0x50, 0x93, 0x4D, 0x28, 0x0D, 0x4D, 0x85, 0xB4, 0x32, 0x41 } },
            { 1281, new byte[] { 0x9, 0x24, 0x7D, 0x7B, 0xD4, 0xDD, 0x49, 0xB8, 0xB6, 0x2C, 0xA5 } },
            { 1313, new byte[] { 0x9, 0x24, 0x7D, 0x7B, 0xD4, 0xDD, 0x45, 0xB8, 0xB6, 0x2C, 0xAA } },
            { 1344, new byte[] { 0x9, 0x24, 0x7D, 0x7B, 0xD4, 0xDD, 0x45, 0xF8, 0xA6, 0x2A, 0xB8 } },
            { 1375, new byte[] { 0x5, 0xC1, 0x8A, 0xE8, 0x94, 0x2C, 0x41, 0x1D, 0x22, 0x45, 0x16 } },
            { 1406, new byte[] { 0x5, 0xC1, 0x8A, 0xE8, 0x98, 0x66, 0x40, 0x7D, 0x32, 0x5D, 0x14 } },
            { 1438, new byte[] { 0x5, 0xC1, 0x8A, 0xE8, 0x98, 0x66, 0x40, 0x7D, 0x32, 0x5D, 0x13 } },
            { 1469, new byte[] { 0x5, 0xC1, 0x8A, 0xE8, 0x98, 0x66, 0x40, 0x7D, 0x32, 0x57, 0x11 } },
            { 1500, new byte[] { 0x1, 0x2D, 0xA7, 0x2A, 0xDD, 0xA8, 0x5C, 0xC8, 0x5C, 0x49, 0x46 } },
            { 1531, new byte[] { 0x1, 0x2D, 0xA7, 0x2A, 0xDD, 0xA8, 0x5C, 0xC8, 0x5C, 0x49, 0x65 } },
            { 1563, new byte[] { 0x1, 0x2D, 0xA7, 0x2A, 0xDD, 0xA8, 0x5C, 0xC8, 0x58, 0x4F, 0x62 } },
            { 1594, new byte[] { 0x1, 0x2D, 0xA7, 0x2A, 0xDD, 0xA8, 0x5C, 0x48, 0xDC, 0xCB, 0xE3 } },
            { 1625, new byte[] { 0x9, 0x24, 0xF0, 0x6C, 0xC5, 0x55, 0x4B, 0xF0, 0x54, 0x30, 0x35 } },
            { 1656, new byte[] { 0x9, 0x24, 0xF0, 0x6C, 0xC5, 0x55, 0x4B, 0xF0, 0x44, 0x34, 0x23 } },
            { 1688, new byte[] { 0x9, 0x24, 0xF0, 0x6C, 0xC5, 0x55, 0x4B, 0xF0, 0x44, 0x24, 0x31 } },
            { 1719, new byte[] { 0x5, 0x0B, 0x69, 0xE9, 0x8D, 0x74, 0x4A, 0x0D, 0x0A, 0xC5, 0x5E } },
            { 1750, new byte[] { 0x5, 0x0B, 0x68, 0xEB, 0x8F, 0x65, 0x4A, 0x2F, 0x1B, 0xCD, 0xDD } },
            { 1781, new byte[] { 0x5, 0x0B, 0x68, 0xEB, 0x8F, 0x65, 0x4A, 0x2F, 0x1B, 0xCD, 0xDA } },
            { 1813, new byte[] { 0x5, 0x0B, 0x68, 0xEB, 0x8F, 0x65, 0x4A, 0x2F, 0x1B, 0xCD, 0xDB } },
            { 1844, new byte[] { 0x5, 0x0B, 0x68, 0xEB, 0x8F, 0x65, 0x4A, 0x3F, 0x13, 0xC1, 0x58 } },
            { 1875, new byte[] { 0x1, 0x2C, 0xA2, 0xA2, 0x55, 0x1, 0x5B, 0x0C, 0x92, 0x8D, 0xA7 } },
            { 1906, new byte[] { 0x1, 0x2C, 0xA2, 0xA2, 0x55, 0x1, 0x53, 0x0C, 0x92, 0x8F, 0xAC } },
            { 1938, new byte[] { 0x1, 0x2C, 0xA2, 0xA2, 0x55, 0x1, 0x53, 0x0C, 0x92, 0x8B, 0x2D } },
            { 1969, new byte[] { 0x1, 0x2C, 0xA2, 0xA2, 0x55, 0x1, 0x53, 0x0C, 0x92, 0x8A, 0x2B } },
            { 2000, new byte[] { 0x1, 0x2C, 0xA2, 0xA2, 0x55, 0x1, 0x53, 0x0C, 0x92, 0x83, 0x2A } },
            { 2031, new byte[] { 0x9, 0x0E, 0xD4, 0x38, 0xDF, 0x3D, 0x6C, 0xD4, 0x2F, 0x0E, 0xE8 } },
            { 2063, new byte[] { 0x5, 0x0B, 0x59, 0x4C, 0xC0, 0x48, 0x6C, 0x1C, 0x4E, 0x5C, 0x0E } },
            { 2094, new byte[] { 0x5, 0x0B, 0x58, 0x4E, 0xC2, 0x49, 0x6C, 0x1E, 0x4F, 0x5C, 0x8C } },
            { 2125, new byte[] { 0x5, 0x0B, 0x58, 0x4E, 0xD2, 0x41, 0x6C, 0x0E, 0x47, 0x58, 0x8D } },
            { 2156, new byte[] { 0x5, 0x0B, 0x58, 0x4E, 0xD2, 0x41, 0x6C, 0x0E, 0x47, 0x50, 0x82 } },
            { 2188, new byte[] { 0x5, 0x0B, 0x58, 0x4E, 0xD2, 0x41, 0x6C, 0x0E, 0x47, 0x40, 0x0 } },
            { 2219, new byte[] { 0x5, 0x0B, 0x58, 0x4E, 0xD2, 0x41, 0x6C, 0x0E, 0x47, 0x40, 0x1 } },
            { 2250, new byte[] { 0x1, 0xAA, 0x66, 0xBF, 0x5C, 0x4, 0x42, 0x60, 0xFA, 0x6D, 0xAE } },
            { 2281, new byte[] { 0x1, 0xAA, 0x66, 0xBF, 0x5C, 0x4, 0x42, 0x60, 0xFB, 0x6D, 0xAE } },
            { 2313, new byte[] { 0x1, 0xAA, 0x66, 0xBF, 0x5C, 0x4, 0x42, 0x60, 0xFA, 0x63, 0x2D } },
            { 2344, new byte[] { 0x1, 0xAA, 0x66, 0xBF, 0x5C, 0x4, 0x42, 0x62, 0xF8, 0x61, 0x2B } },
            { 2375, new byte[] { 0x1, 0xAA, 0x66, 0xBF, 0x5C, 0x4, 0x42, 0x62, 0xF9, 0x60, 0x2A } },
            { 2406, new byte[] { 0x5, 0x6, 0xFB, 0x63, 0xCD, 0xD9, 0x2B, 0x42, 0xE1, 0xD7, 0x6F } },
            { 2438, new byte[] { 0x5, 0x6, 0xFB, 0x63, 0xCD, 0xD9, 0x2B, 0x42, 0xE1, 0xC7, 0x6C } },
            { 2469, new byte[] { 0x5, 0x6, 0xFB, 0x63, 0xCD, 0xD9, 0x2B, 0x42, 0xE1, 0xCF, 0x6D } },
            { 2500, new byte[] { 0x5, 0x6, 0xFB, 0x63, 0xCD, 0xD9, 0x2B, 0x42, 0xE1, 0xCF, 0x6B } },
        };
    }
}
