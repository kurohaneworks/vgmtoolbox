﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using ICSharpCode.SharpZipLib.Checksums;

using VGMToolbox.util.ObjectPooling;

namespace VGMToolbox.format
{
    interface IFormat
    {
        byte[] getAsciiSignature();
        void getDatFileCrc32(string pPath, ref Dictionary<string, ByteArray> pLibHash,
            ref Crc32 pChecksum, bool pUseLibHash, bool pStreamInput);        
        void getDatFileCrc32(string pPath, ref Dictionary<string, ByteArray> pLibHash, 
            ref Crc32 pChecksum, ref CryptoStream pMd5CryptoStream, ref CryptoStream pSha1CryptoStream, 
            bool pUseLibHash, bool pStreamInput);
        string getFormatAbbreviation();
        void initialize(byte[] pBytes);
        void initialize(ByteArray pBytes);
        void initialize(Stream pStream);
        bool IsFileLibrary(string pPath);
    }
}