using System;
using System.Collections.Generic;

namespace Jellyfin.Plugin.CableChannels
{
    public class Channel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> ContentLibraryIds { get; set; }
        public ChannelType Type { get; set; }
        public bool EnableCommercials { get; set; }
        public bool EnablePreRolls { get; set; }
        public int CommercialFrequencyMinutes { get; set; }
        public ScheduleMode ScheduleMode { get; set; }

        public Channel()
        {
            Id = Guid.NewGuid().ToString();
            Name = string.Empty;
            Description = string.Empty;
            ContentLibraryIds = new List<string>();
            EnableCommercials = true;
            EnablePreRolls = false;
            CommercialFrequencyMinutes = 15;
            ScheduleMode = ScheduleMode.Shuffle;
        }
    }

    public enum ChannelType
    {
        Mixed,
        Movies,
        TVShows
    }

    public enum ScheduleMode
    {
        Shuffle,
        Sequential,
        Scheduled
    }
}
