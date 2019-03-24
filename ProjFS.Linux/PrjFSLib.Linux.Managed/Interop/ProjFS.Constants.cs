namespace PrjFSLib.Linux.Interop
{
    internal partial class ProjFS
    {
        internal static class Constants
        {
            public const ulong PROJFS_ALLOW = 0x01;
            public const ulong PROJFS_DENY = 0x02;
            public const ulong PROJFS_CLOSE_WRITE = 0x00000008;
            public const ulong PROJFS_OPEN = 0x00000020;
            public const ulong PROJFS_DELETE_SELF = 0x00000400;
            public const ulong PROJFS_MOVE_SELF = 0x00000800;
            public const ulong PROJFS_ONDIR = 0x40000000;
            public const ulong PROJFS_CREATE_SELF = 0x000100000000;
        }
    }
}
