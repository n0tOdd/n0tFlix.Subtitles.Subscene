using System;
using System.Collections.Generic;
using n0tFlix.Subtitles.Subscene.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace n0tFlix.Subtitles.Subscene
{
    public class Plugin : BasePlugin<PluginConfiguration>
    {
        public override string Name => "Subscene Subtitles";

        public override Guid Id => Guid.Parse("dbcdaa14-0fac-4a88-97f1-8beb33ed11e0");

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public static Plugin Instance { get; private set; }


    }
}
