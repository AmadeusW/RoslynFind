// Guids.cs
// MUST match guids.h
using System;

namespace CodeConnect.RoslynSearch
{
    static class GuidList
    {
        public const string guidRoslynSearchPkgString = "06ce5d03-d3d3-4b8a-a4f7-ca76a11c9afa";
        public const string guidRoslynSearchCmdSetString = "fb173170-ddd5-41cb-a69d-3e404f3f5db5";
        public const string guidToolWindowPersistanceString = "958130d6-e1e1-45da-ab20-1f0cfe69c94b";

        public static readonly Guid guidRoslynSearchCmdSet = new Guid(guidRoslynSearchCmdSetString);
    };
}