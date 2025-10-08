using System.Collections.Generic;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.CableChannels
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public List<Channel> Channels { get; set; }
        public string CommercialLibraryPath { get; set; }
        public string PreRollLibraryPath { get; set; }
        public int CommercialBreakFrequencyMinutes { get; set; }
        public int CommercialBreakDurationSeconds { get; set; }

        public PluginConfiguration()
        {
            Channels = new List<Channel>();
            CommercialLibraryPath = string.Empty;
            PreRollLibraryPath = string.Empty;
            CommercialBreakFrequencyMinutes = 15;
            CommercialBreakDurationSeconds = 120;
        }
    }
}
