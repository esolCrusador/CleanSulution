// Guids.cs
// MUST match guids.h
using System;

namespace GloryS.SolutionCleanup_VSIX
{
    static class GuidList
    {
        public const string guidSolutionCleanup_VSIXPkgString = "a6558f5c-768c-4221-82a9-c37a81820baa";
        public const string guidSolutionCleanup_VSIXCmdSetString = "487d5e56-b6a0-43c7-bc16-54593800f3fa";
        public const string guidToolWindowPersistanceString = "ce835a5b-3a6e-4217-a8c9-cb525b41b1d8";

        public static readonly Guid guidSolutionCleanup_VSIXCmdSet = new Guid(guidSolutionCleanup_VSIXCmdSetString);
    };
}