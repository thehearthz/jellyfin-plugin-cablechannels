# Jellyfin Cable Channels Plugin

A Jellyfin plugin that creates cable-like channels with commercials, pre-rolls, TV shows, and movies for a traditional TV viewing experience.

## Features

- 🎬 **Multiple Channel Types**: Movies, TV Shows, or Mixed content
- 📺 **Commercial Breaks**: Automatic insertion at configurable intervals
- 🎞️ **Pre-Roll Support**: Optional intros before content
- 📅 **Flexible Scheduling**: Shuffle, Sequential, or Time-based scheduling
- 🔄 **Continuous Playback**: 24/7 synchronized streaming
- 👥 **Shared Experience**: Everyone sees the same content at the same time
- 🌐 **URL Access**: Direct links to channels
- 🔌 **REST API**: Full API for integration

## Installation

### From Plugin Repository

1. Open Jellyfin Dashboard
2. Navigate to **Plugins** → **Repositories**
3. Add repository: `https://raw.githubusercontent.com/thehearthz/jellyfin-plugin-cablechannels/main/manifest.json`
4. Go to **Catalog** and install **Cable Channels**
5. Restart Jellyfin

### Manual Installation

1. Download the latest release from [Releases](https://github.com/thehearthz/jellyfin-plugin-cablechannels/releases)
2. Extract to `jellyfin/plugins/CableChannels/`
3. Restart Jellyfin

## Quick Start

1. Create libraries for:
   - Your content (movies/TV shows)
   - Commercials
   - Pre-rolls (optional)

2. Configure the plugin:
   - Dashboard → Plugins → Cable Channels
   - Set commercial and pre-roll library paths
   - Configure break frequency and duration

3. Create channels and start watching

## URL Access

### Play a Channel
```
https://your-jellyfin-server/CableChannels/Play/{channelId}
```

### Get Channel Guide
```
https://your-jellyfin-server/CableChannels/Guide
```

### Get Channel Schedule
```
https://your-jellyfin-server/CableChannels/Channels/{channelId}/Schedule
```

## Building from Source

```cmd
git clone https://github.com/thehearthz/jellyfin-plugin-cablechannels.git
cd jellyfin-plugin-cablechannels
dotnet build Jellyfin.Plugin.CableChannels/Jellyfin.Plugin.CableChannels.csproj --configuration Release
```

## Contributing

Contributions welcome Please feel free to submit a Pull Request.

## License

MIT License - see [LICENSE](LICENSE) for details.

## Author

**matt**
- GitHub: [@thehearthz](https://github.com/thehearthz)

## Support

- [Issues](https://github.com/thehearthz/jellyfin-plugin-cablechannels/issues)
- [Discussions](https://github.com/thehearthz/jellyfin-plugin-cablechannels/discussions)
