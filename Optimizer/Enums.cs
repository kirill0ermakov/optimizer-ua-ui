﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    internal enum LogType
    {
        Information,
        Error,
    }

    internal enum WindowsVersion
    {
        Unsupported,
        Windows7,
        Windows8,
        Windows10
    }

    internal enum RegistryHive
    {
        CurrentUser,
        LocalMachine
    }


    internal enum StartupItemLocation
    {
        Folder,
        HKLM,
        HKLMWoW,
        HKCU
    }

    internal enum StartupItemType
    {
        None,
        Run,
        RunOnce
    }

    internal enum MessageType
    {
        Error,
        Optimize,
        Startup,
        Restart,
        Hosts,
        Integrator
    }

    internal enum DesktopItemType
    {
        Program,
        Folder,
        Link,
        File,
        Command
    }

    internal enum DesktopTypePosition
    {
        Top,
        Middle,
        Bottom
    }

    internal enum Theme
    {
        Zerg,
        Ocean,
        Caramel,
        Magma,
        Lime,
        Minimal
    }

    internal enum RecycleFlag : int
    {
        SHERB_NOCONFIRMATION = 0x00000001,
        SHERB_NOPROGRESSUI = 0x00000001,
        SHERB_NOSOUND = 0x00000004
    }
}
