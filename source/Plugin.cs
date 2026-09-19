using System;
using Shoko.Abstractions.Plugin;

namespace Shoko.Plugin.Template;

public class Plugin : IPlugin
{
    public Guid ID => new("00000000-0000-0000-0000-000000000001");

    public string Name => "Template";
}
