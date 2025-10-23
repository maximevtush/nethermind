// SPDX-FileCopyrightText: 2023 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using Nethermind.Int256;

namespace SendBlobs;
internal static class RpcQuantityParser
{
    public static UInt256 ParseUInt256(string s)
    {
        return (UInt256)ParseUInt64(s);
    }

    public static ulong ParseUInt64(string s)
    {
        return Convert.ToUInt64(s, s.StartsWith("0x") ? 16 : 10);
    }
}
