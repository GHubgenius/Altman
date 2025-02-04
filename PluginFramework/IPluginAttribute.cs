﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginFramework
{
    public interface IPluginAttribute
    {
        string Title { get; }
        string Group { get; }
        string Version { get; }
        string Author { get; }
        string Description { get; }
    }
}
